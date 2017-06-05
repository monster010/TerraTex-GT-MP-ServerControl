namespace TerraTex_GT_MP_ServerControl
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.liveServerTabPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeLiveServer = new System.Windows.Forms.NumericUpDown();
            this.liveServerPath = new System.Windows.Forms.Label();
            this.autostartLiveServer = new System.Windows.Forms.CheckBox();
            this.selectLiveServerPath = new System.Windows.Forms.Button();
            this.devServerTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timeDevServer = new System.Windows.Forms.NumericUpDown();
            this.devServerPath = new System.Windows.Forms.Label();
            this.autostartDevServer = new System.Windows.Forms.CheckBox();
            this.selectDevServerPath = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.liveServerStatusPicture = new System.Windows.Forms.PictureBox();
            this.liveServerStatus = new System.Windows.Forms.Label();
            this.liveServerStartButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.devServerStartButton = new System.Windows.Forms.Button();
            this.devServerStatus = new System.Windows.Forms.Label();
            this.devServerStatusPicture = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labeln = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jenkinsUser = new System.Windows.Forms.TextBox();
            this.jenkinsPassword = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.liveServerTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLiveServer)).BeginInit();
            this.devServerTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeDevServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveServerStatusPicture)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devServerStatusPicture)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "TerraTex GT-MP ServerControl";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.liveServerTabPage);
            this.tabControl1.Controls.Add(this.devServerTabPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-1, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 205);
            this.tabControl1.TabIndex = 0;
            // 
            // liveServerTabPage
            // 
            this.liveServerTabPage.Controls.Add(this.groupBox3);
            this.liveServerTabPage.Controls.Add(this.groupBox1);
            this.liveServerTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveServerTabPage.Location = new System.Drawing.Point(4, 22);
            this.liveServerTabPage.Name = "liveServerTabPage";
            this.liveServerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.liveServerTabPage.Size = new System.Drawing.Size(556, 179);
            this.liveServerTabPage.TabIndex = 0;
            this.liveServerTabPage.Text = "Live-Server";
            this.liveServerTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.liveServerStartButton);
            this.groupBox3.Controls.Add(this.liveServerStatus);
            this.groupBox3.Controls.Add(this.liveServerStatusPicture);
            this.groupBox3.Location = new System.Drawing.Point(6, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 59);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Live-Server-Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.timeLiveServer);
            this.groupBox1.Controls.Add(this.liveServerPath);
            this.groupBox1.Controls.Add(this.autostartLiveServer);
            this.groupBox1.Controls.Add(this.selectLiveServerPath);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings Live-Server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Minimum Time until restart:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Executable Path:";
            // 
            // timeLiveServer
            // 
            this.timeLiveServer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timeLiveServer.Location = new System.Drawing.Point(166, 70);
            this.timeLiveServer.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.timeLiveServer.Name = "timeLiveServer";
            this.timeLiveServer.Size = new System.Drawing.Size(120, 20);
            this.timeLiveServer.TabIndex = 14;
            this.timeLiveServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeLiveServer.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // liveServerPath
            // 
            this.liveServerPath.AutoSize = true;
            this.liveServerPath.Location = new System.Drawing.Point(224, 24);
            this.liveServerPath.Name = "liveServerPath";
            this.liveServerPath.Size = new System.Drawing.Size(97, 15);
            this.liveServerPath.TabIndex = 10;
            this.liveServerPath.Text = "Please Select ....";
            // 
            // autostartLiveServer
            // 
            this.autostartLiveServer.AutoSize = true;
            this.autostartLiveServer.Location = new System.Drawing.Point(6, 45);
            this.autostartLiveServer.Name = "autostartLiveServer";
            this.autostartLiveServer.Size = new System.Drawing.Size(263, 19);
            this.autostartLiveServer.TabIndex = 12;
            this.autostartLiveServer.Text = "Automatic Restart after Crash or Shutdown?";
            this.autostartLiveServer.UseVisualStyleBackColor = true;
            // 
            // selectLiveServerPath
            // 
            this.selectLiveServerPath.Location = new System.Drawing.Point(108, 19);
            this.selectLiveServerPath.Name = "selectLiveServerPath";
            this.selectLiveServerPath.Size = new System.Drawing.Size(110, 23);
            this.selectLiveServerPath.TabIndex = 11;
            this.selectLiveServerPath.Text = "Select";
            this.selectLiveServerPath.UseVisualStyleBackColor = true;
            this.selectLiveServerPath.Click += new System.EventHandler(this.selectLiveServerPath_Click);
            // 
            // devServerTabPage
            // 
            this.devServerTabPage.Controls.Add(this.groupBox4);
            this.devServerTabPage.Controls.Add(this.groupBox2);
            this.devServerTabPage.Location = new System.Drawing.Point(4, 22);
            this.devServerTabPage.Name = "devServerTabPage";
            this.devServerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.devServerTabPage.Size = new System.Drawing.Size(556, 179);
            this.devServerTabPage.TabIndex = 1;
            this.devServerTabPage.Text = "Dev-Server";
            this.devServerTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.timeDevServer);
            this.groupBox2.Controls.Add(this.devServerPath);
            this.groupBox2.Controls.Add(this.autostartDevServer);
            this.groupBox2.Controls.Add(this.selectDevServerPath);
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings Development-Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Minimum Time until restart:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seconds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Executable Path:";
            // 
            // timeDevServer
            // 
            this.timeDevServer.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timeDevServer.Location = new System.Drawing.Point(166, 70);
            this.timeDevServer.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.timeDevServer.Name = "timeDevServer";
            this.timeDevServer.Size = new System.Drawing.Size(120, 20);
            this.timeDevServer.TabIndex = 14;
            this.timeDevServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.timeDevServer.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // devServerPath
            // 
            this.devServerPath.AutoSize = true;
            this.devServerPath.Location = new System.Drawing.Point(224, 24);
            this.devServerPath.Name = "devServerPath";
            this.devServerPath.Size = new System.Drawing.Size(97, 15);
            this.devServerPath.TabIndex = 10;
            this.devServerPath.Text = "Please Select ....";
            // 
            // autostartDevServer
            // 
            this.autostartDevServer.AutoSize = true;
            this.autostartDevServer.Location = new System.Drawing.Point(6, 45);
            this.autostartDevServer.Name = "autostartDevServer";
            this.autostartDevServer.Size = new System.Drawing.Size(263, 19);
            this.autostartDevServer.TabIndex = 12;
            this.autostartDevServer.Text = "Automatic Restart after Crash or Shutdown?";
            this.autostartDevServer.UseVisualStyleBackColor = true;
            // 
            // selectDevServerPath
            // 
            this.selectDevServerPath.Location = new System.Drawing.Point(108, 19);
            this.selectDevServerPath.Name = "selectDevServerPath";
            this.selectDevServerPath.Size = new System.Drawing.Size(110, 23);
            this.selectDevServerPath.TabIndex = 11;
            this.selectDevServerPath.Text = "Select";
            this.selectDevServerPath.UseVisualStyleBackColor = true;
            this.selectDevServerPath.Click += new System.EventHandler(this.selectDevServerPath_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(504, 0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(59, 20);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // liveServerStatusPicture
            // 
            this.liveServerStatusPicture.Image = ((System.Drawing.Image)(resources.GetObject("liveServerStatusPicture.Image")));
            this.liveServerStatusPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("liveServerStatusPicture.InitialImage")));
            this.liveServerStatusPicture.Location = new System.Drawing.Point(6, 19);
            this.liveServerStatusPicture.Name = "liveServerStatusPicture";
            this.liveServerStatusPicture.Size = new System.Drawing.Size(32, 32);
            this.liveServerStatusPicture.TabIndex = 0;
            this.liveServerStatusPicture.TabStop = false;
            // 
            // liveServerStatus
            // 
            this.liveServerStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.liveServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveServerStatus.ForeColor = System.Drawing.Color.Red;
            this.liveServerStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.liveServerStatus.Location = new System.Drawing.Point(44, 19);
            this.liveServerStatus.Name = "liveServerStatus";
            this.liveServerStatus.Size = new System.Drawing.Size(492, 32);
            this.liveServerStatus.TabIndex = 1;
            this.liveServerStatus.Text = "Offline since xxx seconds";
            this.liveServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // liveServerStartButton
            // 
            this.liveServerStartButton.Location = new System.Drawing.Point(362, 21);
            this.liveServerStartButton.Name = "liveServerStartButton";
            this.liveServerStartButton.Size = new System.Drawing.Size(174, 30);
            this.liveServerStartButton.TabIndex = 2;
            this.liveServerStartButton.Text = "Start Now!";
            this.liveServerStartButton.UseVisualStyleBackColor = true;
            this.liveServerStartButton.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.devServerStartButton);
            this.groupBox4.Controls.Add(this.devServerStatus);
            this.groupBox4.Controls.Add(this.devServerStatusPicture);
            this.groupBox4.Location = new System.Drawing.Point(6, 109);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(542, 59);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Development-Server-Status";
            // 
            // devServerStartButton
            // 
            this.devServerStartButton.Location = new System.Drawing.Point(362, 21);
            this.devServerStartButton.Name = "devServerStartButton";
            this.devServerStartButton.Size = new System.Drawing.Size(174, 30);
            this.devServerStartButton.TabIndex = 2;
            this.devServerStartButton.Text = "Start Now!";
            this.devServerStartButton.UseVisualStyleBackColor = true;
            this.devServerStartButton.Visible = false;
            // 
            // devServerStatus
            // 
            this.devServerStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.devServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devServerStatus.ForeColor = System.Drawing.Color.Red;
            this.devServerStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devServerStatus.Location = new System.Drawing.Point(44, 19);
            this.devServerStatus.Name = "devServerStatus";
            this.devServerStatus.Size = new System.Drawing.Size(492, 32);
            this.devServerStatus.TabIndex = 1;
            this.devServerStatus.Text = "Offline since xxx seconds";
            this.devServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // devServerStatusPicture
            // 
            this.devServerStatusPicture.Image = ((System.Drawing.Image)(resources.GetObject("devServerStatusPicture.Image")));
            this.devServerStatusPicture.InitialImage = ((System.Drawing.Image)(resources.GetObject("devServerStatusPicture.InitialImage")));
            this.devServerStatusPicture.Location = new System.Drawing.Point(6, 19);
            this.devServerStatusPicture.Name = "devServerStatusPicture";
            this.devServerStatusPicture.Size = new System.Drawing.Size(32, 32);
            this.devServerStatusPicture.TabIndex = 0;
            this.devServerStatusPicture.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "GrandTheftMultiplayer.Server.exe";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.jenkinsPassword);
            this.tabPage1.Controls.Add(this.jenkinsUser);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labeln);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(556, 179);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "General Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labeln
            // 
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(38, 16);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(78, 15);
            this.labeln.TabIndex = 0;
            this.labeln.Text = "Jenkins User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenkins Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // jenkinsUser
            // 
            this.jenkinsUser.Location = new System.Drawing.Point(122, 16);
            this.jenkinsUser.Name = "jenkinsUser";
            this.jenkinsUser.Size = new System.Drawing.Size(242, 20);
            this.jenkinsUser.TabIndex = 2;
            // 
            // jenkinsPassword
            // 
            this.jenkinsPassword.Location = new System.Drawing.Point(122, 42);
            this.jenkinsPassword.Name = "jenkinsPassword";
            this.jenkinsPassword.Size = new System.Drawing.Size(242, 20);
            this.jenkinsPassword.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(563, 206);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TerraTex GT-MP ServerControl";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.liveServerTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLiveServer)).EndInit();
            this.devServerTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeDevServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveServerStatusPicture)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.devServerStatusPicture)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage devServerTabPage;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TabPage liveServerTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timeLiveServer;
        private System.Windows.Forms.Label liveServerPath;
        private System.Windows.Forms.CheckBox autostartLiveServer;
        private System.Windows.Forms.Button selectLiveServerPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown timeDevServer;
        private System.Windows.Forms.Label devServerPath;
        private System.Windows.Forms.CheckBox autostartDevServer;
        private System.Windows.Forms.Button selectDevServerPath;
        private System.Windows.Forms.PictureBox liveServerStatusPicture;
        private System.Windows.Forms.Button liveServerStartButton;
        private System.Windows.Forms.Label liveServerStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button devServerStartButton;
        private System.Windows.Forms.Label devServerStatus;
        private System.Windows.Forms.PictureBox devServerStatusPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.TextBox jenkinsPassword;
        private System.Windows.Forms.TextBox jenkinsUser;
    }
}

