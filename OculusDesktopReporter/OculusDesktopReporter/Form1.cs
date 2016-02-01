using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvergreenDesktopReporter
{
    public partial class frm_Main : Form
    {
        TcpClient clientSocket = null;
        PollingThread pollingThread = null;
        Thread polling = null;
        Boolean muteMode;

        public frm_Main()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            this.Location = new Point(System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Right - Size.Width, System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Bottom - Size.Height - 20);
            muteMode = false;
            loadSettings();

            if(EvergreenDesktopReporter.Properties.Settings.Default.AutoConnect)
            {
                setupConnection();
            }
        }

        private void loadSettings()
        {
            chkb_VolumeControl.Checked= EvergreenDesktopReporter.Properties.Settings.Default.volumeControl;
            this.chkb_VolumeControl.CheckedChanged += new System.EventHandler(this.chkb_VolumeControl_CheckedChanged);

            chkb_MonitorControl.Checked = EvergreenDesktopReporter.Properties.Settings.Default.monitorControl;
            this.chkb_MonitorControl.CheckedChanged += new System.EventHandler(this.chkb_MonitorControl_CheckedChanged);

            chkb_StatusReadEnable.Checked = EvergreenDesktopReporter.Properties.Settings.Default.statusReadEnable;
            this.chkb_StatusReadEnable.CheckedChanged += new System.EventHandler(this.chkb_StatusReadEnable_CheckedChanged);

            chkb_RemoteLock.Checked = EvergreenDesktopReporter.Properties.Settings.Default.remoteLock;
            this.chkb_RemoteLock.CheckedChanged += new System.EventHandler(this.chkb_RemoteLock_CheckedChanged);

            chkb_ShareScreenEnable.Checked = EvergreenDesktopReporter.Properties.Settings.Default.shareScreenEnable;
            this.chkb_WebCamFeedEnable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);

            chkb_WebCamFeedEnable.Checked = EvergreenDesktopReporter.Properties.Settings.Default.webcamFeedEnable;
            this.chkb_ShareScreenEnable.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);

        }

        private void minimize()
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }
        private void maximize()
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.BringToFront();
            Activate();
        }

        private void ntfy_Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                minimize();
            }
            else
            {
                maximize();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disconnect();
            Dispose();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            disconnect();
            Dispose();
        }

        public void displayLine(String message, Boolean balloon = false)
        {
            try
            {
                if (balloon && !this.ContainsFocus && !muteMode)
                {
                    ntfy_Tray.BalloonTipTitle = message;
                    ntfy_Tray.BalloonTipText = message;
                    ntfy_Tray.ShowBalloonTip(3000);
                }
            }
            catch (Exception)
            { }
        }

        public string readFromServer()
        {
            String read = String.Empty;
            try
            {
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Flush();
                byte[] bytesFrom = new byte[(int)clientSocket.ReceiveBufferSize];
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                networkStream.Flush();

                String dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                read = dataFromClient.Substring(0, dataFromClient.IndexOf("$$"));
            }
            catch (Exception e)
            {
                displayLine("Disconnected");
                Exception ex = new Exception("Read from Server failed");
                throw ex;
            }
            return read;
        }

        public String writeToServer(String serverResponse)
        {
            String read = String.Empty;
            try
            {
                NetworkStream networkStream = clientSocket.GetStream();
                serverResponse = serverResponse.Trim();
                serverResponse += "$$";
                byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);
                networkStream.Write(sendBytes, 0, sendBytes.Length);
                networkStream.Flush();

                byte[] bytesFrom = new byte[(int)clientSocket.ReceiveBufferSize];
                networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                networkStream.Flush();

                String dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                read = dataFromClient.Substring(0, dataFromClient.LastIndexOf("$$"));

                return read;
            }
            catch (Exception e)
            {
                displayLine("Disconnected");
                disconnect();
                return read;
            }
        }

        public void disconnect()
        {
            try
            {
                this.Text = "Oculus Desktop Reporter (Offline)";
                if (polling != null && polling.IsAlive)
                    polling.Abort();
                polling = null;

                if (clientSocket != null)
                {
                    clientSocket.Close();
                    clientSocket = null;
                }

                if (!EvergreenDesktopReporter.Properties.Settings.Default.RememberMe)
                {
                    EvergreenDesktopReporter.Properties.Settings.Default.Username = "";
                    EvergreenDesktopReporter.Properties.Settings.Default.Password = "";

                    EvergreenDesktopReporter.Properties.Settings.Default.Save();
                }
            }
            catch (Exception)
            { }
            displayLine("Client offline");
        }

        public void setupConnection()
        {
            if (clientSocket != null)
                disconnect();

            displayLine("Client started");

            try
            {
                clientSocket = new TcpClient();
                displayLine("Checking IP address:" + EvergreenDesktopReporter.Properties.Settings.Default.ServerIP);
                clientSocket.Connect(EvergreenDesktopReporter.Properties.Settings.Default.ServerIP, 6669);
                displayLine("Connected to Evergreen Server",true);

                String status = writeToServer(EvergreenDesktopReporter.Properties.Settings.Default.Username + ":" + EvergreenDesktopReporter.Properties.Settings.Default.Password);
                //String status = readFromServer();
                displayLine(status);
                if (status == "OculusMessage:Authentication Failed")
                {
                    disconnect();
                    return;
                }
                pollingThread = new PollingThread(this, EvergreenDesktopReporter.Properties.Settings.Default.Username, clientSocket,this.Handle);
                polling = new Thread(new ThreadStart(pollingThread.poll));
                polling.Start();
                this.Text = EvergreenDesktopReporter.Properties.Settings.Default.Username;
                return;
            }
            catch (Exception)
            {
                displayLine("No server found in that IP",true);
            }

            displayLine("Server Not Found",true);
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings obj = new Settings(this);
            obj.Show();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            disconnect();
        }

        private void aboutEvergreenDesktopReporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        private void chkb_VolumeControl_CheckedChanged(object sender, EventArgs e)
        {
            EvergreenDesktopReporter.Properties.Settings.Default.volumeControl = !EvergreenDesktopReporter.Properties.Settings.Default.volumeControl;
            EvergreenDesktopReporter.Properties.Settings.Default.Save();
        }

        private void chkb_MonitorControl_CheckedChanged(object sender, EventArgs e)
        {
            EvergreenDesktopReporter.Properties.Settings.Default.monitorControl = !EvergreenDesktopReporter.Properties.Settings.Default.monitorControl;
            EvergreenDesktopReporter.Properties.Settings.Default.Save();
        }

        private void chkb_StatusReadEnable_CheckedChanged(object sender, EventArgs e)
        {
            EvergreenDesktopReporter.Properties.Settings.Default.statusReadEnable = !EvergreenDesktopReporter.Properties.Settings.Default.statusReadEnable;
            EvergreenDesktopReporter.Properties.Settings.Default.Save();
        }

        private void chkb_RemoteLock_CheckedChanged(object sender, EventArgs e)
        {
            EvergreenDesktopReporter.Properties.Settings.Default.remoteLock = !EvergreenDesktopReporter.Properties.Settings.Default.remoteLock;
            EvergreenDesktopReporter.Properties.Settings.Default.Save();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            EvergreenDesktopReporter.Properties.Settings.Default.shareScreenEnable = !EvergreenDesktopReporter.Properties.Settings.Default.shareScreenEnable;
            EvergreenDesktopReporter.Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            EvergreenDesktopReporter.Properties.Settings.Default.webcamFeedEnable = !EvergreenDesktopReporter.Properties.Settings.Default.webcamFeedEnable;
            EvergreenDesktopReporter.Properties.Settings.Default.Save();
        }

        private void muteModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (muteMode)
            {
                muteModeToolStripMenuItem.Checked = false;
                muteMode = false;
            }
            else
            {
                muteModeToolStripMenuItem.Checked = true;
                muteMode = true;
            }
        }
    }
}
