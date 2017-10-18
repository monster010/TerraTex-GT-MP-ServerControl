using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerraTex_GT_MP_ServerControl
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = !this.Visible;
            if (this.Visible)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.BringToFront();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLiveServer.Value = app.Default.live_timeuntilrestart;
            liveServerPath.Text = app.Default.live_path;
            autostartLiveServer.Checked = app.Default.live_autorestart;

            timeDevServer.Value = app.Default.dev_timeuntilrestart;
            devServerPath.Text = app.Default.dev_path;
            autostartDevServer.Checked = app.Default.dev_autorestart;

            jenkinsUser.Text = app.Default.jenkinsUser;
            jenkinsPassword.Text = app.Default.jenkinsPassword;

            Program.Worker = new CheckProcess(this);
            Program.WorkerThread = new Thread(Program.Worker.DoWork);
            Program.WorkerThread.Start();

            CheckSocket cs = new CheckSocket(this);
            Thread csTh = new Thread(cs.DoWork);
            csTh.Start();
        }

        private void selectDevServerPath_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = ConfigurationManager.AppSettings["dev_path"];
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                devServerPath.Text = openFileDialog.FileName;
            }
        }

        private void selectLiveServerPath_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = ConfigurationManager.AppSettings["live_path"];
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                liveServerPath.Text = openFileDialog.FileName;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            app.Default.live_timeuntilrestart = timeLiveServer.Value;
            app.Default.live_path = liveServerPath.Text;
            app.Default.live_autorestart = autostartLiveServer.Checked;

            app.Default.dev_timeuntilrestart = timeDevServer.Value;
            app.Default.dev_path = devServerPath.Text;
            app.Default.dev_autorestart = autostartDevServer.Checked;

            app.Default.jenkinsUser = jenkinsUser.Text;
            app.Default.jenkinsPassword = jenkinsPassword.Text;

            app.Default.Save();
        }

        public void SetDevServerStatus(int statusId, int seconds)
        {
            if (statusId == 0)
            {
                SetControlPropertyThreadSafe(devServerStatusPicture, "ImageLocation", "./red.png");
                SetControlPropertyThreadSafe(devServerStatus, "Text", "Offline for " + seconds + " Seconds");
                SetControlPropertyThreadSafe(devServerStatus, "ForeColor", Color.Red);
            }
            else if (statusId == 1)
            {
                SetControlPropertyThreadSafe(devServerStatusPicture, "ImageLocation", "./green.png");
                SetControlPropertyThreadSafe(devServerStatus, "Text", "Online");
                SetControlPropertyThreadSafe(devServerStatus, "ForeColor", Color.Green);
            }
            else if (statusId == 2)
            {
                SetControlPropertyThreadSafe(devServerStatusPicture, "ImageLocation", "./yellow.png");
                SetControlPropertyThreadSafe(devServerStatus, "Text", "Waiting for Jenkins to finish Deployment");
                SetControlPropertyThreadSafe(devServerStatus, "ForeColor", Color.Orange);
            }
        }

        public bool GetLiveStatus()
        {
            return liveServerStatus.ForeColor == Color.Green;
        }

        public bool GetDevStatus()
        {
            return devServerStatus.ForeColor == Color.Green;
        }

        public void SetLiveServerStatus(int statusId, int seconds)
        {
            if (statusId == 0)
            {
                SetControlPropertyThreadSafe(liveServerStatusPicture, "ImageLocation", "./red.png");
                SetControlPropertyThreadSafe(liveServerStatus, "Text", "Offline for " + seconds + " Seconds") ;
                SetControlPropertyThreadSafe(liveServerStatus, "ForeColor", Color.Red);
            }
            else if (statusId == 1)
            {
                SetControlPropertyThreadSafe(liveServerStatusPicture, "ImageLocation", "./green.png");
                SetControlPropertyThreadSafe(liveServerStatus, "Text", "Online");
                SetControlPropertyThreadSafe(liveServerStatus, "ForeColor", Color.Green);
            }
            else if (statusId == 2)
            {
                SetControlPropertyThreadSafe(liveServerStatusPicture, "ImageLocation", "./yellow.png");
                SetControlPropertyThreadSafe(liveServerStatus, "Text", "Waiting for Jenkins to finish Deployment");
                SetControlPropertyThreadSafe(liveServerStatus, "ForeColor", Color.Orange);
            }
        }

        private delegate void SetControlPropertyThreadSafeDelegate(
            Control control,
            string propertyName,
            object propertyValue);

        public static void SetControlPropertyThreadSafe(
            Control control,
            string propertyName,
            object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                        (SetControlPropertyThreadSafe),
                    new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Worker.RequestStop();
        }
    }
}
