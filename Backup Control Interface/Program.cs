using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Control_Interface
{

    public class task
    {
        private string uuid, namelabel, namedescription, status, progress;

        public string UUID
        {
            get
            {
                return uuid;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(value);
                }

                uuid = value;
            }
        }
        public string NameLabel
        {
            get
            {
                return namelabel;
            }
            set
            {
                namelabel = value;
            }
        }
        public string NameDescription
        {
            get
            {
                return namedescription;
            }
            set
            {
                namedescription = value;
            }
        }
        public string Progress
        {
            get
            {
                return progress;
            }
            set
            {
                progress = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public override string ToString()
        {
            return $"{namelabel}";
        }

        public List<string> getProperties()
        {
            var output = new List<string>{};
            output.Add($"UUID: {uuid}");
            output.Add($"Name: {namelabel}");
            output.Add($"Description: {namedescription}");
            output.Add($"Status: {status}");
            output.Add($"Progress: {progress}");

            return output;
        }
    }

    public class server
    {
        private string uuid, name, server_sr_path;

        public string UUID
        {
            get
            {
                return uuid;
            }
            set
            {
                uuid = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public string Server_SR_Path
        {
            get
            {
                return server_sr_path;
            }

            set
            {
                server_sr_path = value;
            }
        }


        public override string ToString()
        {
            return $"{name}: {uuid}";
        }

        public string[] getProperties()
        {
            string[] properties =new string[] { name, uuid };
            return properties;
        }

    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
    }
}
