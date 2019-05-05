using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using System.IO;
using Renci.SshNet;

namespace Backup_Control_Interface
{
    public partial class Form1 : Form
    {

        delegate void getTasksDelegate(string serverName);

        SshClient c;

        public Form1()
        {
            InitializeComponent();

            /*c.Connect();
            c.RunCommand("echo \"hello\"");
            c.Disconnect();*/

            var servers = new List<server>
            {
                new server{
                    Name = "allegro",
                    UUID = "",
                    Server_SR_Path = "/backup/allegro/58698fd5-578f-63ac-178d-07acf349054f"},

                new server{
                    Name = "marina",
                    UUID = "6724a0d2-4d93-d791-3582-5f42965b206f" ,
                    Server_SR_Path = "/mnt/test-server-2"}
            };

            listBoxServers.DataSource = servers;

        }


        public List<string> stringSanitiser(string r)
        {
            var resultList = r.Split(Environment.NewLine.ToCharArray());

            var resultListFormatted = new List<string> { };

            for (int i = 0; i < resultList.Length; i++)
            /* every other item (i.e. 1,3,4) in the 
             * resultList will be control character, so
             * only add every even indexed item (0,2,4 etc.)
             */
            {
                if ((i % 2) == 0)
                {
                    resultListFormatted.Add(resultList[i]);
                }
            }

            for (int i = 0; i < resultListFormatted.ToArray().Length; i++)
            {
                var result = resultListFormatted[i];
                var resultLength = (result.Length - 1);

                for (int j = 0; j < resultLength; j++)
                {
                    if (result[j].ToString() == " ")
                    {
                        resultListFormatted[i] = result.Insert(j, @"\");
                    }
                }
            }

            return resultListFormatted;
        }

        private static string LogExceptionMessage(Exception exception)
        {
            var message = exception.Message;
            Console.WriteLine($"Exception: {message}");
            return message;
        }

        public void getTasks(string serverName)
        {

            int count2 = 0;
            Console.WriteLine("getTasks thread started.");
            while (true)
            {

                var client2 = new SshClient(
                    host: textBoxHostname.Text,
                    username: textBoxUsername.Text,
                    password: textBoxPassword.Text
                    );

                client2.Connect();
                var result = client2.RunCommand("./tasks.sh").Result;
                client2.Disconnect();

                var stringListTasks = new List<string> { };
                var tasks = new List<task> { };

                var count = 0;
                var lastTask = 0;

                /*three \n come between each task 
                 *so the string can be seperated by those \n
                 */
                for (int i = 0; i < result.Length; i++)
                {
                    var character = result[i].ToString();
                    if (character.Contains("\n"))
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }

                    if (count == 3)
                    {
                        stringListTasks.Add(result.Substring(lastTask, (i - lastTask - 3)));
                        lastTask = i;
                    }
                }

                for (int i = 0; i < stringListTasks.ToArray().Length; i++)
                {
                    var tempTask = new task { };

                    //split each task on the colon
                    var stringListTasksElements = new List<string>(stringListTasks[i].Split(new[] { ":", "\n" }, StringSplitOptions.None));

                    //removing any left over \n and whitespace
                    for (int j = 0; j < stringListTasksElements.ToArray().Length; j++)
                    {
                        stringListTasksElements[j] = stringListTasksElements[j].Replace("\n", "").Replace(" ", "");

                    }

                    var index = 0;

                    //removing the white space at beginning of each task array
                    foreach (var element in stringListTasksElements)
                    {
                        if (element != "")
                        {
                            index = stringListTasksElements.IndexOf(element);
                            break;
                        }
                    }

                    stringListTasksElements.RemoveRange(0, index);

                    foreach (string element in stringListTasksElements)
                    {
                        switch (element)
                        {
                            case "uuid(RO)":
                                tempTask.UUID = (string)stringListTasksElements[stringListTasksElements.IndexOf(element) + 1];
                                break;
                            case "name-label(RO)":
                                tempTask.NameLabel = stringListTasksElements[stringListTasksElements.IndexOf(element) + 1];
                                break;
                            case "name-description(RO)":
                                tempTask.NameDescription = stringListTasksElements[stringListTasksElements.IndexOf(element) + 1];
                                break;
                            case "status(RO)":
                                tempTask.Status = stringListTasksElements[stringListTasksElements.IndexOf(element) + 1];
                                break;
                            case "progress(RO)":
                                tempTask.Progress = stringListTasksElements[stringListTasksElements.IndexOf(element) + 1];
                                break;
                        }
                    }

                    tasks.Add(tempTask);

                }

                var taskNames = new List<string> { };

                foreach (var task in tasks)
                {
                    taskNames.Add(task.NameLabel);
                }

                Console.WriteLine("\n\n\n");

                var sleepTime = 2000;

                try
                {
                    sleepTime = Convert.ToInt32(textBoxFrequency.Text) * 1000;

                }
                catch (System.FormatException)
                {
                    ;
                }

                Invoke(new Action(() =>
                {
                    listBoxTasksName.DataSource = tasks;
                }));

                if (count2 != 0)
                {
                    Thread.Sleep(sleepTime);
                }
                else
                {
                    Thread.Sleep(5000);
                }
                    

                string selectedUUID = "";
                string correctUUID = "";
                

                Invoke(new Action(() =>
                {
                    task taskChoice = (task)listBoxTasksName.SelectedItem;
                    selectedUUID = taskChoice.UUID;
                    Console.WriteLine($"selected UUID: {selectedUUID}.\ncount2: {count2}");
                    if (selectedUUID != correctUUID)
                    {
                        if (count2 == 0)
                        {
                            correctUUID = selectedUUID;
                        }
                    }

                    foreach (var task in tasks)
                    {
                        if (task.UUID == correctUUID)
                        {
                            listBoxTasksDesc.DataSource = task.getProperties();
                        }
                    }
                    
                }));

                count2++;
            }
        }

        public void errorCheck (string Error, Label label, TextBox textbox)
        {
            if (!string.IsNullOrEmpty(Error))
            {
                label.Visible = true;
                textbox.Visible = true;
                textbox.Text = Error;
            }
        }


        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterServer_click(sender, e);
            }
        }

        private void textBoxConsoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                enterConsole_click(sender, e);
            }
        }

        

        private void enterServer_click(object sender, EventArgs e)
        {

            var server = (server)listBoxServers.Items[listBoxServers.SelectedIndex];
            
            var command = $"ls /srv{server.Server_SR_Path}/";

            try
            {
                c = new SshClient(
                    host: textBoxHostname.Text,
                    username: textBoxUsername.Text,
                    password: textBoxPassword.Text);

                c.Connect();
                
                var output = c.RunCommand(command);

                var results = output.Result;
                var resultList = stringSanitiser(results);

                textBoxServerCommand.Text = output.CommandText;
                errorCheck(output.Error, labelServerError1, textBoxServerError);

                listBoxVMs.DataSource = resultList;
            }
            catch (Exception exception)
            {
                textBoxServerError.Text = LogExceptionMessage(exception);
            }
            
            c.Disconnect();

        }
        

        private void enterVMs_Click(object sender, EventArgs e)
        {
            try
            {
                var VM = listBoxVMs.Items[listBoxVMs.SelectedIndex].ToString();
                var server = (server)listBoxServers.Items[listBoxServers.SelectedIndex];
                
                var command = $"ls /srv{server.Server_SR_Path}/{VM}/";

                c.Connect();
                var output = c.RunCommand(command);


                var resultList = stringSanitiser(output.Result);

                textBoxVMsCommand.Text = command;
                errorCheck(output.Error, labelVMsError1, textBoxVMsError);
                listBoxSnapshots.DataSource = resultList;
            }
            catch (Exception exception)
            {
                textBoxServerError.Text = LogExceptionMessage(exception);
            }

            c.Disconnect();

        }

        

        private void enterSnapshot_Click(object sender, EventArgs e)
        {

            try
            {
                var snapshot = listBoxSnapshots.Items[listBoxSnapshots.SelectedIndex].ToString();
                var VM = listBoxVMs.Items[listBoxVMs.SelectedIndex].ToString();
                var server = (server)listBoxServers.Items[listBoxServers.SelectedIndex];

                getTasksDelegate tasks = new getTasksDelegate(getTasks);
                tasks.BeginInvoke(((string)server.Name), null, null);

                var command = $"echo “scp {textBoxUsername.Text}@backup.lan:{server.Server_SR_Path}/{server.Name}/{snapshot}/{server.Name}/{VM}.xva.gz /dev/stdout | pigz -dc /dev/stdin | xe vm-import sr-uuid={server.UUID} preserve=true filename=/dev/stdin”";

                c.Connect();
                var output = c.RunCommand(command);

                var resultList = stringSanitiser(output.Result);

                textBoxSnapshotCommand.Text = command;
                errorCheck(output.Error, labelSnapshotsError1, textBoxSnapshotError);


            }
            catch (Exception exception)
            {
                textBoxServerError.Text = LogExceptionMessage(exception);
            }


            c.Disconnect();

        }

        private void enterConsole_click(object sender, EventArgs e)
        {
            var client3 = new SshClient(
                    host: textBoxHostname.Text,
                    username: textBoxUsername.Text,
                    password: textBoxPassword.Text);

            var input = new MemoryStream();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

