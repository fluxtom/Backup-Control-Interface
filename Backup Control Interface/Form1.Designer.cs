using System.Collections.Generic;


namespace Backup_Control_Interface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxHostname = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.EnterServer = new System.Windows.Forms.Button();
            this.listBoxServers = new System.Windows.Forms.ListBox();
            this.labelServer = new System.Windows.Forms.Label();
            this.labelVMs = new System.Windows.Forms.Label();
            this.listBoxVMs = new System.Windows.Forms.ListBox();
            this.labelVMsError1 = new System.Windows.Forms.Label();
            this.labelVMsCommand1 = new System.Windows.Forms.Label();
            this.enterVMs = new System.Windows.Forms.Button();
            this.labelSnapshots = new System.Windows.Forms.Label();
            this.listBoxSnapshots = new System.Windows.Forms.ListBox();
            this.labelSnapshots1 = new System.Windows.Forms.Label();
            this.labelSnapshotsError1 = new System.Windows.Forms.Label();
            this.enterSnapshots = new System.Windows.Forms.Button();
            this.labelServerCommand1 = new System.Windows.Forms.Label();
            this.labelServerError1 = new System.Windows.Forms.Label();
            this.textBoxSnapshotCommand = new System.Windows.Forms.TextBox();
            this.textBoxVMsCommand = new System.Windows.Forms.TextBox();
            this.textBoxServerCommand = new System.Windows.Forms.TextBox();
            this.textBoxServerError = new System.Windows.Forms.TextBox();
            this.textBoxVMsError = new System.Windows.Forms.TextBox();
            this.textBoxSnapshotError = new System.Windows.Forms.TextBox();
            this.labelTasks = new System.Windows.Forms.Label();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.listBoxTasksName = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelConsole = new System.Windows.Forms.Label();
            this.textBoxConsoleInput = new System.Windows.Forms.TextBox();
            this.buttonConsole = new System.Windows.Forms.Button();
            this.textBoxConsoleOutput = new System.Windows.Forms.TextBox();
            this.listBoxTasksDesc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxHostname
            // 
            this.textBoxHostname.Location = new System.Drawing.Point(13, 13);
            this.textBoxHostname.Name = "textBoxHostname";
            this.textBoxHostname.Size = new System.Drawing.Size(100, 20);
            this.textBoxHostname.TabIndex = 0;
            this.textBoxHostname.Text = "marina.lan";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(119, 13);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "guest";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(225, 13);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.Text = "guest123";
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxConsoleInput_KeyDown);
            // 
            // EnterServer
            // 
            this.EnterServer.Location = new System.Drawing.Point(13, 122);
            this.EnterServer.Name = "EnterServer";
            this.EnterServer.Size = new System.Drawing.Size(75, 23);
            this.EnterServer.TabIndex = 3;
            this.EnterServer.Text = "Enter";
            this.EnterServer.UseVisualStyleBackColor = true;
            this.EnterServer.Click += new System.EventHandler(this.enterServer_click);
            // 
            // listBoxServers
            // 
            this.listBoxServers.ForeColor = System.Drawing.Color.Black;
            this.listBoxServers.FormattingEnabled = true;
            this.listBoxServers.Location = new System.Drawing.Point(13, 60);
            this.listBoxServers.Name = "listBoxServers";
            this.listBoxServers.Size = new System.Drawing.Size(312, 56);
            this.listBoxServers.TabIndex = 4;
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(13, 40);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(92, 13);
            this.labelServer.TabIndex = 5;
            this.labelServer.Text = "Available Servers:";
            // 
            // labelVMs
            // 
            this.labelVMs.AutoSize = true;
            this.labelVMs.Location = new System.Drawing.Point(12, 157);
            this.labelVMs.Name = "labelVMs";
            this.labelVMs.Size = new System.Drawing.Size(77, 13);
            this.labelVMs.TabIndex = 6;
            this.labelVMs.Text = "Available VMs:";
            // 
            // listBoxVMs
            // 
            this.listBoxVMs.FormattingEnabled = true;
            this.listBoxVMs.Location = new System.Drawing.Point(13, 173);
            this.listBoxVMs.Name = "listBoxVMs";
            this.listBoxVMs.Size = new System.Drawing.Size(312, 134);
            this.listBoxVMs.TabIndex = 7;
            // 
            // labelVMsError1
            // 
            this.labelVMsError1.AutoSize = true;
            this.labelVMsError1.Location = new System.Drawing.Point(332, 211);
            this.labelVMsError1.Name = "labelVMsError1";
            this.labelVMsError1.Size = new System.Drawing.Size(32, 13);
            this.labelVMsError1.TabIndex = 8;
            this.labelVMsError1.Text = "Error:";
            this.labelVMsError1.Visible = false;
            // 
            // labelVMsCommand1
            // 
            this.labelVMsCommand1.AutoSize = true;
            this.labelVMsCommand1.Location = new System.Drawing.Point(331, 173);
            this.labelVMsCommand1.Name = "labelVMsCommand1";
            this.labelVMsCommand1.Size = new System.Drawing.Size(80, 13);
            this.labelVMsCommand1.TabIndex = 9;
            this.labelVMsCommand1.Text = "Command sent:";
            // 
            // enterVMs
            // 
            this.enterVMs.Location = new System.Drawing.Point(12, 313);
            this.enterVMs.Name = "enterVMs";
            this.enterVMs.Size = new System.Drawing.Size(75, 23);
            this.enterVMs.TabIndex = 12;
            this.enterVMs.Text = "Enter";
            this.enterVMs.UseVisualStyleBackColor = true;
            this.enterVMs.Click += new System.EventHandler(this.enterVMs_Click);
            // 
            // labelSnapshots
            // 
            this.labelSnapshots.AutoSize = true;
            this.labelSnapshots.Location = new System.Drawing.Point(13, 358);
            this.labelSnapshots.Name = "labelSnapshots";
            this.labelSnapshots.Size = new System.Drawing.Size(106, 13);
            this.labelSnapshots.TabIndex = 13;
            this.labelSnapshots.Text = "Available Snapshots:";
            // 
            // listBoxSnapshots
            // 
            this.listBoxSnapshots.FormattingEnabled = true;
            this.listBoxSnapshots.Location = new System.Drawing.Point(13, 374);
            this.listBoxSnapshots.Name = "listBoxSnapshots";
            this.listBoxSnapshots.Size = new System.Drawing.Size(312, 134);
            this.listBoxSnapshots.TabIndex = 14;
            // 
            // labelSnapshots1
            // 
            this.labelSnapshots1.AutoSize = true;
            this.labelSnapshots1.Location = new System.Drawing.Point(332, 374);
            this.labelSnapshots1.Name = "labelSnapshots1";
            this.labelSnapshots1.Size = new System.Drawing.Size(80, 13);
            this.labelSnapshots1.TabIndex = 15;
            this.labelSnapshots1.Text = "Command sent:";
            // 
            // labelSnapshotsError1
            // 
            this.labelSnapshotsError1.AutoSize = true;
            this.labelSnapshotsError1.Location = new System.Drawing.Point(332, 456);
            this.labelSnapshotsError1.Name = "labelSnapshotsError1";
            this.labelSnapshotsError1.Size = new System.Drawing.Size(32, 13);
            this.labelSnapshotsError1.TabIndex = 17;
            this.labelSnapshotsError1.Text = "Error:";
            this.labelSnapshotsError1.Visible = false;
            // 
            // enterSnapshots
            // 
            this.enterSnapshots.Location = new System.Drawing.Point(12, 514);
            this.enterSnapshots.Name = "enterSnapshots";
            this.enterSnapshots.Size = new System.Drawing.Size(75, 23);
            this.enterSnapshots.TabIndex = 18;
            this.enterSnapshots.Text = "Enter";
            this.enterSnapshots.UseVisualStyleBackColor = true;
            this.enterSnapshots.Click += new System.EventHandler(this.enterSnapshot_Click);
            // 
            // labelServerCommand1
            // 
            this.labelServerCommand1.AutoSize = true;
            this.labelServerCommand1.Location = new System.Drawing.Point(331, 60);
            this.labelServerCommand1.Name = "labelServerCommand1";
            this.labelServerCommand1.Size = new System.Drawing.Size(80, 13);
            this.labelServerCommand1.TabIndex = 21;
            this.labelServerCommand1.Text = "Command sent:";
            // 
            // labelServerError1
            // 
            this.labelServerError1.AutoSize = true;
            this.labelServerError1.Location = new System.Drawing.Point(332, 98);
            this.labelServerError1.Name = "labelServerError1";
            this.labelServerError1.Size = new System.Drawing.Size(32, 13);
            this.labelServerError1.TabIndex = 20;
            this.labelServerError1.Text = "Error:";
            this.labelServerError1.Visible = false;
            // 
            // textBoxSnapshotCommand
            // 
            this.textBoxSnapshotCommand.Location = new System.Drawing.Point(334, 390);
            this.textBoxSnapshotCommand.Multiline = true;
            this.textBoxSnapshotCommand.Name = "textBoxSnapshotCommand";
            this.textBoxSnapshotCommand.ReadOnly = true;
            this.textBoxSnapshotCommand.Size = new System.Drawing.Size(419, 63);
            this.textBoxSnapshotCommand.TabIndex = 25;
            // 
            // textBoxVMsCommand
            // 
            this.textBoxVMsCommand.Location = new System.Drawing.Point(331, 188);
            this.textBoxVMsCommand.Name = "textBoxVMsCommand";
            this.textBoxVMsCommand.ReadOnly = true;
            this.textBoxVMsCommand.Size = new System.Drawing.Size(421, 20);
            this.textBoxVMsCommand.TabIndex = 26;
            // 
            // textBoxServerCommand
            // 
            this.textBoxServerCommand.Location = new System.Drawing.Point(334, 77);
            this.textBoxServerCommand.Name = "textBoxServerCommand";
            this.textBoxServerCommand.ReadOnly = true;
            this.textBoxServerCommand.Size = new System.Drawing.Size(419, 20);
            this.textBoxServerCommand.TabIndex = 27;
            // 
            // textBoxServerError
            // 
            this.textBoxServerError.Location = new System.Drawing.Point(335, 115);
            this.textBoxServerError.Name = "textBoxServerError";
            this.textBoxServerError.ReadOnly = true;
            this.textBoxServerError.Size = new System.Drawing.Size(418, 20);
            this.textBoxServerError.TabIndex = 28;
            this.textBoxServerError.Visible = false;
            // 
            // textBoxVMsError
            // 
            this.textBoxVMsError.Location = new System.Drawing.Point(332, 228);
            this.textBoxVMsError.Name = "textBoxVMsError";
            this.textBoxVMsError.ReadOnly = true;
            this.textBoxVMsError.Size = new System.Drawing.Size(421, 20);
            this.textBoxVMsError.TabIndex = 29;
            this.textBoxVMsError.Visible = false;
            // 
            // textBoxSnapshotError
            // 
            this.textBoxSnapshotError.Location = new System.Drawing.Point(334, 473);
            this.textBoxSnapshotError.Name = "textBoxSnapshotError";
            this.textBoxSnapshotError.ReadOnly = true;
            this.textBoxSnapshotError.Size = new System.Drawing.Size(419, 20);
            this.textBoxSnapshotError.TabIndex = 30;
            this.textBoxSnapshotError.Visible = false;
            // 
            // labelTasks
            // 
            this.labelTasks.AutoSize = true;
            this.labelTasks.Location = new System.Drawing.Point(796, 16);
            this.labelTasks.Name = "labelTasks";
            this.labelTasks.Size = new System.Drawing.Size(121, 13);
            this.labelTasks.TabIndex = 31;
            this.labelTasks.Text = "Currently Running Task:";
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(941, 13);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(21, 20);
            this.textBoxFrequency.TabIndex = 32;
            this.textBoxFrequency.Text = "2";
            // 
            // listBoxTasksName
            // 
            this.listBoxTasksName.FormattingEnabled = true;
            this.listBoxTasksName.Location = new System.Drawing.Point(799, 40);
            this.listBoxTasksName.Name = "listBoxTasksName";
            this.listBoxTasksName.Size = new System.Drawing.Size(424, 147);
            this.listBoxTasksName.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(968, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Update frequency (seconds)";
            // 
            // labelConsole
            // 
            this.labelConsole.AutoSize = true;
            this.labelConsole.Location = new System.Drawing.Point(799, 316);
            this.labelConsole.Name = "labelConsole";
            this.labelConsole.Size = new System.Drawing.Size(73, 13);
            this.labelConsole.TabIndex = 35;
            this.labelConsole.Text = "SSH Console:";
            // 
            // textBoxConsoleInput
            // 
            this.textBoxConsoleInput.Location = new System.Drawing.Point(799, 332);
            this.textBoxConsoleInput.Name = "textBoxConsoleInput";
            this.textBoxConsoleInput.Size = new System.Drawing.Size(390, 20);
            this.textBoxConsoleInput.TabIndex = 36;
            this.textBoxConsoleInput.Text = "input";
            this.textBoxConsoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxConsoleInput_KeyDown);
            // 
            // buttonConsole
            // 
            this.buttonConsole.Location = new System.Drawing.Point(1195, 331);
            this.buttonConsole.Name = "buttonConsole";
            this.buttonConsole.Size = new System.Drawing.Size(45, 23);
            this.buttonConsole.TabIndex = 37;
            this.buttonConsole.Text = "Enter";
            this.buttonConsole.UseVisualStyleBackColor = true;
            this.buttonConsole.Click += new System.EventHandler(this.enterConsole_click);
            // 
            // textBoxConsoleOutput
            // 
            this.textBoxConsoleOutput.Location = new System.Drawing.Point(799, 358);
            this.textBoxConsoleOutput.Multiline = true;
            this.textBoxConsoleOutput.Name = "textBoxConsoleOutput";
            this.textBoxConsoleOutput.ReadOnly = true;
            this.textBoxConsoleOutput.Size = new System.Drawing.Size(441, 150);
            this.textBoxConsoleOutput.TabIndex = 38;
            this.textBoxConsoleOutput.Text = "output";
            // 
            // listBoxTasksDesc
            // 
            this.listBoxTasksDesc.FormattingEnabled = true;
            this.listBoxTasksDesc.Location = new System.Drawing.Point(799, 189);
            this.listBoxTasksDesc.Name = "listBoxTasksDesc";
            this.listBoxTasksDesc.Size = new System.Drawing.Size(424, 121);
            this.listBoxTasksDesc.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1252, 550);
            this.Controls.Add(this.listBoxTasksDesc);
            this.Controls.Add(this.textBoxConsoleOutput);
            this.Controls.Add(this.buttonConsole);
            this.Controls.Add(this.textBoxConsoleInput);
            this.Controls.Add(this.labelConsole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTasksName);
            this.Controls.Add(this.textBoxFrequency);
            this.Controls.Add(this.labelTasks);
            this.Controls.Add(this.textBoxSnapshotError);
            this.Controls.Add(this.textBoxVMsError);
            this.Controls.Add(this.textBoxServerError);
            this.Controls.Add(this.textBoxServerCommand);
            this.Controls.Add(this.textBoxVMsCommand);
            this.Controls.Add(this.textBoxSnapshotCommand);
            this.Controls.Add(this.labelServerCommand1);
            this.Controls.Add(this.labelServerError1);
            this.Controls.Add(this.enterSnapshots);
            this.Controls.Add(this.labelSnapshotsError1);
            this.Controls.Add(this.labelSnapshots1);
            this.Controls.Add(this.listBoxSnapshots);
            this.Controls.Add(this.labelSnapshots);
            this.Controls.Add(this.enterVMs);
            this.Controls.Add(this.labelVMsCommand1);
            this.Controls.Add(this.labelVMsError1);
            this.Controls.Add(this.listBoxVMs);
            this.Controls.Add(this.labelVMs);
            this.Controls.Add(this.labelServer);
            this.Controls.Add(this.listBoxServers);
            this.Controls.Add(this.EnterServer);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxHostname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxHostname;
        public System.Windows.Forms.TextBox textBoxUsername;
        public System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button EnterServer;
        private System.Windows.Forms.ListBox listBoxServers;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelVMs;
        private System.Windows.Forms.ListBox listBoxVMs;
        private System.Windows.Forms.Label labelVMsError1;
        private System.Windows.Forms.Label labelVMsCommand1;
        private System.Windows.Forms.Button enterVMs;
        private System.Windows.Forms.Label labelSnapshots;
        private System.Windows.Forms.ListBox listBoxSnapshots;
        private System.Windows.Forms.Label labelSnapshots1;
        private System.Windows.Forms.Label labelSnapshotsError1;
        private System.Windows.Forms.Button enterSnapshots;
        private System.Windows.Forms.Label labelServerCommand1;
        private System.Windows.Forms.Label labelServerError1;
        private System.Windows.Forms.TextBox textBoxSnapshotCommand;
        private System.Windows.Forms.TextBox textBoxVMsCommand;
        private System.Windows.Forms.TextBox textBoxServerCommand;
        private System.Windows.Forms.TextBox textBoxServerError;
        private System.Windows.Forms.TextBox textBoxVMsError;
        private System.Windows.Forms.TextBox textBoxSnapshotError;
        private System.Windows.Forms.Label labelTasks;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.ListBox listBoxTasksName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelConsole;
        private System.Windows.Forms.TextBox textBoxConsoleInput;
        private System.Windows.Forms.Button buttonConsole;
        private System.Windows.Forms.TextBox textBoxConsoleOutput;
        private System.Windows.Forms.ListBox listBoxTasksDesc;
    }
}

