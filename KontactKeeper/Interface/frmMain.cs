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
using FacebookAPI;
using BusinessLogic;
using System.IO;
using DataAccess;

namespace Interface
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            btnAdmins1.Click += new EventHandler(btnAdmins_Click);
            btnCallAgents1.Click += new EventHandler(btnCallAgents_Click);
            btnEndUsers1.Click += new EventHandler(btnEndUsers_Click);
            FBConf.Login("kontactkeeper09@gmail.com", "J@nnesventer009");
            refresh();
        }
        
        public void refresh()
        {
            Connector conn = new Connector();

            BindingSource BsAdmin = new BindingSource();
            BsAdmin.DataSource = conn.GetAdmins();
            dgvAdmin.DataSource = BsAdmin;
            txtAAdminID.DataBindings.Clear();
            txtAAdminID.DataBindings.Add(new Binding("Text", BsAdmin, "pidadmin"));
            txtAFName.DataBindings.Clear();
            txtAFName.DataBindings.Add(new Binding("Text", BsAdmin, "fname"));
            txtALname.DataBindings.Clear();
            txtALname.DataBindings.Add(new Binding("Text", BsAdmin, "lname"));
            txtAUname.DataBindings.Clear();
            txtAUname.DataBindings.Add(new Binding("Text", BsAdmin, "uname"));
            txtAPassword.DataBindings.Clear();
            txtAPassword.DataBindings.Add(new Binding("Text", BsAdmin, "password"));

            BindingSource BsAgent = new BindingSource();
            BsAgent.DataSource = conn.GetCallAgents();
            dgvCallAgent.DataSource = BsAgent;
            txtCID.DataBindings.Clear();
            txtCID.DataBindings.Add(new Binding("Text", BsAgent, "pidagent"));
            txtCFName.DataBindings.Clear();
            txtCFName.DataBindings.Add(new Binding("Text", BsAgent, "fname"));
            txtCLName.DataBindings.Clear();
            txtCLName.DataBindings.Add(new Binding("Text", BsAgent, "lname"));
            txtCUserName.DataBindings.Clear();
            txtCUserName.DataBindings.Add(new Binding("Text", BsAgent, "uname"));
            txtCPassword.DataBindings.Clear();
            txtCPassword.DataBindings.Add(new Binding("Text", BsAgent, "password"));
            txtCTotalCalls.DataBindings.Clear();
            txtCTotalCalls.DataBindings.Add(new Binding("Text", BsAgent, "totalcalls"));
            txtCAgentEXT.DataBindings.Clear();
            txtCAgentEXT.DataBindings.Add(new Binding("Text", BsAgent, "agentext"));
            txtCAVG.DataBindings.Clear();
            txtCAVG.DataBindings.Add(new Binding("Text", BsAgent, "avgcalllength"));
            txtCTotalHours.DataBindings.Clear();
            txtCTotalHours.DataBindings.Add(new Binding("Text", BsAgent, "totalhours"));
            txtCPerformance.DataBindings.Clear();
            txtCPerformance.DataBindings.Add(new Binding("Text", BsAgent, "performancescore"));

            BindingSource BsEUser = new BindingSource();
            BsEUser.DataSource = conn.GetEndUsers();
            dgvEndUser.DataSource = BsEUser;
            txtEID.DataBindings.Clear();
            txtEID.DataBindings.Add(new Binding("Text", BsEUser, "pidenduser"));
            txtEFName.DataBindings.Clear();
            txtEFName.DataBindings.Add(new Binding("Text", BsEUser, "fname"));
            txtELName.DataBindings.Clear();
            txtELName.DataBindings.Add(new Binding("Text", BsEUser, "lname"));
            txtEUName.DataBindings.Clear();
            txtEUName.DataBindings.Add(new Binding("Text", BsEUser, "uname"));
            txtEPassword.DataBindings.Clear();
            txtEPassword.DataBindings.Add(new Binding("Text", BsEUser, "password"));
            txtECell.DataBindings.Clear();
            txtECell.DataBindings.Add(new Binding("Text", BsEUser, "cellnumber"));
            txtEEmail.DataBindings.Clear();
            txtEEmail.DataBindings.Add(new Binding("Text", BsEUser, "email"));
            txtEFBID.DataBindings.Clear();
            txtEFBID.DataBindings.Add(new Binding("Text", BsEUser, "fbid"));
        }
        

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmsettings = new frmSettings();
            frmsettings.Show();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings.Get("Fullscreen") == "1")
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Fullscreen"].Value = "1";
                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");

                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Fullscreen"].Value = "0";
                config.Save(ConfigurationSaveMode.Modified);

                ConfigurationManager.RefreshSection("appSettings");

                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            btnHome.Focus();
            panButtons.Hide();
            panAdmins.Hide();
            panCallAgents.Hide();
            panEndUsers.Hide();
            panHome.Show();
            refresh();
        }
        private void btnAdmins_Click(object sender, EventArgs e)
        {
            this.ActiveControl = this.btnAdmins;
            panButtons.Show();
            panAdmins.Show();
            panCallAgents.Hide();
            panEndUsers.Hide();
            panHome.Hide();
            refresh();
        }

        private void btnCallAgents_Click(object sender, EventArgs e)
        {
            this.ActiveControl = this.btnCallAgents;
            panButtons.Show();
            panAdmins.Hide();
            panCallAgents.Show();
            panEndUsers.Hide();
            panHome.Hide();
            refresh();
        }

        private void btnEndUsers_Click(object sender, EventArgs e)
        {
            this.ActiveControl = this.btnEndUsers;
            panButtons.Show();
            panAdmins.Hide();
            panCallAgents.Hide();
            panEndUsers.Show();
            panHome.Hide();
            refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnCAAdd_Click(object sender, EventArgs e)
        {
            Connector cn = new Connector();
            cn.AddAdmin(txtAFName.Text, txtALname.Text);
        }

        private void dgvEndUser_CellContentClick(object sender, DataGridViewCellEventArgs e) //Added the datagridview
        {
            Admin administrator = (Admin)dgvAdmin.SelectedRows[0].DataBoundItem;
            txtAAdminID.Text = administrator.PIDAdmin.ToString();
            txtAFName.Text = administrator.FName;
            txtALname.Text = administrator.LName;
            txtAUname.Text = administrator.UName;
            txtAPassword.Text = administrator.Password;

            Agent agents = (Agent)dgvCallAgent.SelectedRows[0].DataBoundItem;
            txtCID.Text = agents.PIDAgent.ToString();
            txtCFName.Text = agents.FName;
            txtCLName.Text = agents.LName;
            txtCAgentEXT.Text = agents.AgentEXT;
            txtCTotalCalls.Text = agents.TotalCalls.ToString();

            EndUser endUser = (EndUser)dgvEndUser.SelectedRows[0].DataBoundItem;
            txtEID.Text = endUser.PIDEndUser.ToString();
            txtEFName.Text = endUser.FName;
            txtELName.Text = endUser.LName;
            txtEFBID.Text = endUser.FBID;
            txtEEmail.Text = endUser.Email;
            txtECell.Text = endUser.CellNumber;
        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
