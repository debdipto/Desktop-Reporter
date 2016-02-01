using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvergreenDesktopReporter
{
    public partial class OculusSettings : UserControl
    {
        frm_Main main;
        public OculusSettings(frm_Main _main)
        {
            InitializeComponent();
            Initialize();
            main = _main;
        }

        private void Initialize()
        {
            if(EvergreenDesktopReporter.Properties.Settings.Default.RememberMe)
            {
                txtb_ServerIP.Text = EvergreenDesktopReporter.Properties.Settings.Default.ServerIP;
                chk_AutoConnect.Checked = EvergreenDesktopReporter.Properties.Settings.Default.AutoConnect;

                txtb_UserName.Text = EvergreenDesktopReporter.Properties.Settings.Default.Username;
                txtb_Password.Text = EvergreenDesktopReporter.Properties.Settings.Default.Password;

                chk_RememberMe.Checked = EvergreenDesktopReporter.Properties.Settings.Default.RememberMe;
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {             
            EvergreenDesktopReporter.Properties.Settings.Default.ServerIP = txtb_ServerIP.Text;
            EvergreenDesktopReporter.Properties.Settings.Default.AutoConnect = chk_AutoConnect.Checked;

            EvergreenDesktopReporter.Properties.Settings.Default.Username = txtb_UserName.Text;
            EvergreenDesktopReporter.Properties.Settings.Default.Password = txtb_Password.Text;

            EvergreenDesktopReporter.Properties.Settings.Default.RememberMe = chk_RememberMe.Checked;

            EvergreenDesktopReporter.Properties.Settings.Default.Save();
            main.setupConnection();
        }
    }
}
