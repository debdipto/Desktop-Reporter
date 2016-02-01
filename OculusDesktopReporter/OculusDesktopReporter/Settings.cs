using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvergreenDesktopReporter
{
    public partial class Settings : Form
    {
        frm_Main main;
        public Settings(frm_Main _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void lstb_settings_SelectedValueChanged(object sender, EventArgs e)
        {
            grpb_settings.Text = lstb_settings.SelectedItem.ToString();
            grpb_settings.Controls.Clear();
            try
            {
                switch (lstb_settings.SelectedItem.ToString())
                {
                    case "Application Settings":
                        {
                            /*StorageConfigurations obj = new StorageConfigurations();
                            obj.Location = new Point(1, 20);
                            grpb_settings.Controls.Add(obj);*/
                        }
                        break;
                    case "Evergreen Server Settings":
                        {
                            OculusSettings obj = new OculusSettings(main);
                            obj.Location = new Point(1, 20);
                            grpb_settings.Controls.Add(obj);
                        }
                        break;
                }
            }
            catch(Exception)
            {
                main.displayLine("loading settings...please retry.");
            }
        }
    }
}
