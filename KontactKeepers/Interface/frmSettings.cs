using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Interface
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            if (ConfigurationManager.AppSettings.Get("Fullscreen") == "0")
            {
                cbFullscreen.Checked = false;
            }
            else
            {
                cbFullscreen.Checked = true;
            }
        }

        private void btnFullscreen_Click(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings.Get("Fullscreen") == "0")
            {
                ConfigurationManager.AppSettings.Set("Fullscreen", "1");
                cbFullscreen.Checked = true;
            }
            else
            {
                ConfigurationManager.AppSettings.Set("Fullscreen", "0");
                cbFullscreen.Checked = false;
            }
            this.Hide();
            this.Show();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
