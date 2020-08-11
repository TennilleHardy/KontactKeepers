namespace Interface
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCalls = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.panAdmins = new System.Windows.Forms.Panel();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtCATime = new System.Windows.Forms.MaskedTextBox();
            this.btnCAUpdate = new System.Windows.Forms.Button();
            this.btnCADelete = new System.Windows.Forms.Button();
            this.btnCAAdd = new System.Windows.Forms.Button();
            this.btnCASearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCACallNo = new System.Windows.Forms.TextBox();
            this.dgvCalls = new System.Windows.Forms.DataGridView();
            this.panCallAgents = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCLClientNo = new System.Windows.Forms.TextBox();
            this.btnCLUpdate = new System.Windows.Forms.Button();
            this.btnCLDelete = new System.Windows.Forms.Button();
            this.btnCLAdd = new System.Windows.Forms.Button();
            this.btnCLSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCLAccountNo = new System.Windows.Forms.TextBox();
            this.txtCLSurname = new System.Windows.Forms.TextBox();
            this.txtCLName = new System.Windows.Forms.TextBox();
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.panEndUsers = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtCODate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCOUpdate = new System.Windows.Forms.Button();
            this.btnCODelete = new System.Windows.Forms.Button();
            this.btnCOAdd = new System.Windows.Forms.Button();
            this.btnCOSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCOSequenceNo = new System.Windows.Forms.TextBox();
            this.txtCOImportance = new System.Windows.Forms.TextBox();
            this.txtCOType = new System.Windows.Forms.TextBox();
            this.txtCOClientNo = new System.Windows.Forms.TextBox();
            this.txtCOContractNo = new System.Windows.Forms.TextBox();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.panHome = new System.Windows.Forms.Panel();
            this.btnContracts1 = new System.Windows.Forms.Button();
            this.btnClients1 = new System.Windows.Forms.Button();
            this.btnCalls1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panButtons = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panAdmins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalls)).BeginInit();
            this.panCallAgents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.panEndUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.panHome.SuspendLayout();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalls
            // 
            this.btnCalls.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCalls.Location = new System.Drawing.Point(121, 11);
            this.btnCalls.Name = "btnCalls";
            this.btnCalls.Size = new System.Drawing.Size(75, 25);
            this.btnCalls.TabIndex = 1;
            this.btnCalls.Text = "Admins";
            this.btnCalls.UseVisualStyleBackColor = true;
            this.btnCalls.Click += new System.EventHandler(this.btnCalls_Click);
            // 
            // btnClients
            // 
            this.btnClients.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnClients.Location = new System.Drawing.Point(202, 11);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(75, 25);
            this.btnClients.TabIndex = 2;
            this.btnClients.Text = "Call agents";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnContracts.Location = new System.Drawing.Point(283, 11);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(75, 25);
            this.btnContracts.TabIndex = 3;
            this.btnContracts.Text = "End users";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // panAdmins
            // 
            this.panAdmins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panAdmins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panAdmins.Controls.Add(this.maskedTextBox1);
            this.panAdmins.Controls.Add(this.txtCATime);
            this.panAdmins.Controls.Add(this.btnCAUpdate);
            this.panAdmins.Controls.Add(this.btnCADelete);
            this.panAdmins.Controls.Add(this.btnCAAdd);
            this.panAdmins.Controls.Add(this.btnCASearch);
            this.panAdmins.Controls.Add(this.label9);
            this.panAdmins.Controls.Add(this.label8);
            this.panAdmins.Controls.Add(this.label2);
            this.panAdmins.Controls.Add(this.txtCACallNo);
            this.panAdmins.Controls.Add(this.dgvCalls);
            this.panAdmins.Location = new System.Drawing.Point(13, 68);
            this.panAdmins.Name = "panAdmins";
            this.panAdmins.Size = new System.Drawing.Size(559, 481);
            this.panAdmins.TabIndex = 0;
            this.panAdmins.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(451, 56);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 26;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // txtCATime
            // 
            this.txtCATime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCATime.Location = new System.Drawing.Point(452, 29);
            this.txtCATime.Name = "txtCATime";
            this.txtCATime.Size = new System.Drawing.Size(100, 20);
            this.txtCATime.TabIndex = 25;
            this.txtCATime.ValidatingType = typeof(System.DateTime);
            // 
            // btnCAUpdate
            // 
            this.btnCAUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCAUpdate.Location = new System.Drawing.Point(451, 168);
            this.btnCAUpdate.Name = "btnCAUpdate";
            this.btnCAUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCAUpdate.TabIndex = 24;
            this.btnCAUpdate.Text = "Update";
            this.btnCAUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCADelete
            // 
            this.btnCADelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCADelete.Location = new System.Drawing.Point(451, 140);
            this.btnCADelete.Name = "btnCADelete";
            this.btnCADelete.Size = new System.Drawing.Size(75, 23);
            this.btnCADelete.TabIndex = 23;
            this.btnCADelete.Text = "Delete";
            this.btnCADelete.UseVisualStyleBackColor = true;
            // 
            // btnCAAdd
            // 
            this.btnCAAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCAAdd.Location = new System.Drawing.Point(451, 111);
            this.btnCAAdd.Name = "btnCAAdd";
            this.btnCAAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCAAdd.TabIndex = 22;
            this.btnCAAdd.Text = "Add";
            this.btnCAAdd.UseVisualStyleBackColor = true;
            // 
            // btnCASearch
            // 
            this.btnCASearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCASearch.Location = new System.Drawing.Point(451, 82);
            this.btnCASearch.Name = "btnCASearch";
            this.btnCASearch.Size = new System.Drawing.Size(75, 23);
            this.btnCASearch.TabIndex = 21;
            this.btnCASearch.Text = "Search";
            this.btnCASearch.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(360, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Password";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Admin ID";
            // 
            // txtCACallNo
            // 
            this.txtCACallNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCACallNo.Location = new System.Drawing.Point(452, 3);
            this.txtCACallNo.Name = "txtCACallNo";
            this.txtCACallNo.Size = new System.Drawing.Size(100, 20);
            this.txtCACallNo.TabIndex = 7;
            // 
            // dgvCalls
            // 
            this.dgvCalls.AllowUserToAddRows = false;
            this.dgvCalls.AllowUserToDeleteRows = false;
            this.dgvCalls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalls.Location = new System.Drawing.Point(4, 4);
            this.dgvCalls.Name = "dgvCalls";
            this.dgvCalls.ReadOnly = true;
            this.dgvCalls.Size = new System.Drawing.Size(350, 470);
            this.dgvCalls.TabIndex = 0;
            // 
            // panCallAgents
            // 
            this.panCallAgents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCallAgents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panCallAgents.Controls.Add(this.textBox2);
            this.panCallAgents.Controls.Add(this.textBox1);
            this.panCallAgents.Controls.Add(this.txtCLClientNo);
            this.panCallAgents.Controls.Add(this.btnCLUpdate);
            this.panCallAgents.Controls.Add(this.btnCLDelete);
            this.panCallAgents.Controls.Add(this.btnCLAdd);
            this.panCallAgents.Controls.Add(this.btnCLSearch);
            this.panCallAgents.Controls.Add(this.label3);
            this.panCallAgents.Controls.Add(this.label13);
            this.panCallAgents.Controls.Add(this.label14);
            this.panCallAgents.Controls.Add(this.label15);
            this.panCallAgents.Controls.Add(this.label16);
            this.panCallAgents.Controls.Add(this.label17);
            this.panCallAgents.Controls.Add(this.txtCLAccountNo);
            this.panCallAgents.Controls.Add(this.txtCLSurname);
            this.panCallAgents.Controls.Add(this.txtCLName);
            this.panCallAgents.Controls.Add(this.dgvClients);
            this.panCallAgents.Location = new System.Drawing.Point(13, 68);
            this.panCallAgents.Name = "panCallAgents";
            this.panCallAgents.Size = new System.Drawing.Size(559, 481);
            this.panCallAgents.TabIndex = 1;
            this.panCallAgents.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(451, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(451, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 43;
            // 
            // txtCLClientNo
            // 
            this.txtCLClientNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCLClientNo.Location = new System.Drawing.Point(451, 3);
            this.txtCLClientNo.Name = "txtCLClientNo";
            this.txtCLClientNo.Size = new System.Drawing.Size(100, 20);
            this.txtCLClientNo.TabIndex = 42;
            // 
            // btnCLUpdate
            // 
            this.btnCLUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLUpdate.Location = new System.Drawing.Point(451, 245);
            this.btnCLUpdate.Name = "btnCLUpdate";
            this.btnCLUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCLUpdate.TabIndex = 41;
            this.btnCLUpdate.Text = "Update";
            this.btnCLUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCLDelete
            // 
            this.btnCLDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLDelete.Location = new System.Drawing.Point(451, 217);
            this.btnCLDelete.Name = "btnCLDelete";
            this.btnCLDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCLDelete.TabIndex = 40;
            this.btnCLDelete.Text = "Delete";
            this.btnCLDelete.UseVisualStyleBackColor = true;
            // 
            // btnCLAdd
            // 
            this.btnCLAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLAdd.Location = new System.Drawing.Point(451, 188);
            this.btnCLAdd.Name = "btnCLAdd";
            this.btnCLAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCLAdd.TabIndex = 39;
            this.btnCLAdd.Text = "Add";
            this.btnCLAdd.UseVisualStyleBackColor = true;
            // 
            // btnCLSearch
            // 
            this.btnCLSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCLSearch.Location = new System.Drawing.Point(451, 159);
            this.btnCLSearch.Name = "btnCLSearch";
            this.btnCLSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCLSearch.TabIndex = 38;
            this.btnCLSearch.Text = "Search";
            this.btnCLSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Performance score";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(359, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Total Calls";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Agent EXT";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(359, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Last Name";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(359, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "First Name";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(359, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Call agent ID";
            // 
            // txtCLAccountNo
            // 
            this.txtCLAccountNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCLAccountNo.Location = new System.Drawing.Point(451, 107);
            this.txtCLAccountNo.Name = "txtCLAccountNo";
            this.txtCLAccountNo.Size = new System.Drawing.Size(100, 20);
            this.txtCLAccountNo.TabIndex = 31;
            // 
            // txtCLSurname
            // 
            this.txtCLSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCLSurname.Location = new System.Drawing.Point(451, 55);
            this.txtCLSurname.Name = "txtCLSurname";
            this.txtCLSurname.Size = new System.Drawing.Size(100, 20);
            this.txtCLSurname.TabIndex = 28;
            // 
            // txtCLName
            // 
            this.txtCLName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCLName.Location = new System.Drawing.Point(451, 29);
            this.txtCLName.Name = "txtCLName";
            this.txtCLName.Size = new System.Drawing.Size(100, 20);
            this.txtCLName.TabIndex = 27;
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(3, 4);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.Size = new System.Drawing.Size(350, 470);
            this.dgvClients.TabIndex = 25;
            // 
            // panEndUsers
            // 
            this.panEndUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panEndUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panEndUsers.Controls.Add(this.textBox4);
            this.panEndUsers.Controls.Add(this.label5);
            this.panEndUsers.Controls.Add(this.textBox3);
            this.panEndUsers.Controls.Add(this.txtCODate);
            this.panEndUsers.Controls.Add(this.label4);
            this.panEndUsers.Controls.Add(this.btnCOUpdate);
            this.panEndUsers.Controls.Add(this.btnCODelete);
            this.panEndUsers.Controls.Add(this.btnCOAdd);
            this.panEndUsers.Controls.Add(this.btnCOSearch);
            this.panEndUsers.Controls.Add(this.label7);
            this.panEndUsers.Controls.Add(this.label18);
            this.panEndUsers.Controls.Add(this.label19);
            this.panEndUsers.Controls.Add(this.label20);
            this.panEndUsers.Controls.Add(this.label21);
            this.panEndUsers.Controls.Add(this.label22);
            this.panEndUsers.Controls.Add(this.txtCOSequenceNo);
            this.panEndUsers.Controls.Add(this.txtCOImportance);
            this.panEndUsers.Controls.Add(this.txtCOType);
            this.panEndUsers.Controls.Add(this.txtCOClientNo);
            this.panEndUsers.Controls.Add(this.txtCOContractNo);
            this.panEndUsers.Controls.Add(this.dgvContracts);
            this.panEndUsers.Location = new System.Drawing.Point(13, 68);
            this.panEndUsers.Name = "panEndUsers";
            this.panEndUsers.Size = new System.Drawing.Size(559, 481);
            this.panEndUsers.TabIndex = 1;
            this.panEndUsers.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(451, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Twitter URL";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(451, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 54;
            // 
            // txtCODate
            // 
            this.txtCODate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCODate.Location = new System.Drawing.Point(451, 56);
            this.txtCODate.Name = "txtCODate";
            this.txtCODate.Size = new System.Drawing.Size(100, 20);
            this.txtCODate.TabIndex = 53;
            this.txtCODate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Facebook URL";
            // 
            // btnCOUpdate
            // 
            this.btnCOUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOUpdate.Location = new System.Drawing.Point(452, 360);
            this.btnCOUpdate.Name = "btnCOUpdate";
            this.btnCOUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCOUpdate.TabIndex = 41;
            this.btnCOUpdate.Text = "Update";
            this.btnCOUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCODelete
            // 
            this.btnCODelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCODelete.Location = new System.Drawing.Point(452, 332);
            this.btnCODelete.Name = "btnCODelete";
            this.btnCODelete.Size = new System.Drawing.Size(75, 23);
            this.btnCODelete.TabIndex = 40;
            this.btnCODelete.Text = "Delete";
            this.btnCODelete.UseVisualStyleBackColor = true;
            // 
            // btnCOAdd
            // 
            this.btnCOAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOAdd.Location = new System.Drawing.Point(452, 303);
            this.btnCOAdd.Name = "btnCOAdd";
            this.btnCOAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCOAdd.TabIndex = 39;
            this.btnCOAdd.Text = "Add";
            this.btnCOAdd.UseVisualStyleBackColor = true;
            // 
            // btnCOSearch
            // 
            this.btnCOSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCOSearch.Location = new System.Drawing.Point(452, 274);
            this.btnCOSearch.Name = "btnCOSearch";
            this.btnCOSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCOSearch.TabIndex = 38;
            this.btnCOSearch.Text = "Search";
            this.btnCOSearch.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Email";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(359, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "Cell number";
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(359, 84);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "ID Number";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(359, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Last Name";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(359, 32);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(57, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "First Name";
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(359, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 32;
            this.label22.Text = "EndUser ID";
            // 
            // txtCOSequenceNo
            // 
            this.txtCOSequenceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCOSequenceNo.Location = new System.Drawing.Point(451, 133);
            this.txtCOSequenceNo.Name = "txtCOSequenceNo";
            this.txtCOSequenceNo.Size = new System.Drawing.Size(100, 20);
            this.txtCOSequenceNo.TabIndex = 31;
            // 
            // txtCOImportance
            // 
            this.txtCOImportance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCOImportance.Location = new System.Drawing.Point(451, 107);
            this.txtCOImportance.Name = "txtCOImportance";
            this.txtCOImportance.Size = new System.Drawing.Size(100, 20);
            this.txtCOImportance.TabIndex = 30;
            // 
            // txtCOType
            // 
            this.txtCOType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCOType.Location = new System.Drawing.Point(451, 81);
            this.txtCOType.Name = "txtCOType";
            this.txtCOType.Size = new System.Drawing.Size(100, 20);
            this.txtCOType.TabIndex = 29;
            // 
            // txtCOClientNo
            // 
            this.txtCOClientNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCOClientNo.Location = new System.Drawing.Point(451, 29);
            this.txtCOClientNo.Name = "txtCOClientNo";
            this.txtCOClientNo.Size = new System.Drawing.Size(100, 20);
            this.txtCOClientNo.TabIndex = 27;
            // 
            // txtCOContractNo
            // 
            this.txtCOContractNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCOContractNo.Location = new System.Drawing.Point(451, 3);
            this.txtCOContractNo.Name = "txtCOContractNo";
            this.txtCOContractNo.Size = new System.Drawing.Size(100, 20);
            this.txtCOContractNo.TabIndex = 26;
            // 
            // dgvContracts
            // 
            this.dgvContracts.AllowUserToAddRows = false;
            this.dgvContracts.AllowUserToDeleteRows = false;
            this.dgvContracts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(3, 4);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.ReadOnly = true;
            this.dgvContracts.Size = new System.Drawing.Size(350, 470);
            this.dgvContracts.TabIndex = 25;
            // 
            // panHome
            // 
            this.panHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panHome.Controls.Add(this.btnContracts1);
            this.panHome.Controls.Add(this.btnClients1);
            this.panHome.Controls.Add(this.btnCalls1);
            this.panHome.Controls.Add(this.label1);
            this.panHome.Location = new System.Drawing.Point(13, 68);
            this.panHome.Name = "panHome";
            this.panHome.Size = new System.Drawing.Size(559, 481);
            this.panHome.TabIndex = 2;
            // 
            // btnContracts1
            // 
            this.btnContracts1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnContracts1.Location = new System.Drawing.Point(147, 167);
            this.btnContracts1.Name = "btnContracts1";
            this.btnContracts1.Size = new System.Drawing.Size(272, 29);
            this.btnContracts1.TabIndex = 3;
            this.btnContracts1.Text = "End users";
            this.btnContracts1.UseMnemonic = false;
            this.btnContracts1.UseVisualStyleBackColor = true;
            // 
            // btnClients1
            // 
            this.btnClients1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClients1.Location = new System.Drawing.Point(147, 132);
            this.btnClients1.Name = "btnClients1";
            this.btnClients1.Size = new System.Drawing.Size(272, 29);
            this.btnClients1.TabIndex = 2;
            this.btnClients1.Text = "Call agents";
            this.btnClients1.UseMnemonic = false;
            this.btnClients1.UseVisualStyleBackColor = true;
            // 
            // btnCalls1
            // 
            this.btnCalls1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCalls1.Location = new System.Drawing.Point(147, 97);
            this.btnCalls1.Name = "btnCalls1";
            this.btnCalls1.Size = new System.Drawing.Size(272, 29);
            this.btnCalls1.TabIndex = 1;
            this.btnCalls1.Text = "Admins";
            this.btnCalls1.UseMnemonic = false;
            this.btnCalls1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "ContactKeeper";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(18, 39);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(31, 25);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(547, 36);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(30, 28);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.btnCalls);
            this.panButtons.Controls.Add(this.btnClients);
            this.panButtons.Controls.Add(this.btnContracts);
            this.panButtons.Location = new System.Drawing.Point(53, 27);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(488, 40);
            this.panButtons.TabIndex = 7;
            this.panButtons.Visible = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label23.Location = new System.Drawing.Point(188, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(217, 31);
            this.label23.TabIndex = 8;
            this.label23.Text = "Admin interface";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panCallAgents);
            this.Controls.Add(this.panEndUsers);
            this.Controls.Add(this.panAdmins);
            this.Controls.Add(this.panHome);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSettings);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactKeeper";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.panAdmins.ResumeLayout(false);
            this.panAdmins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalls)).EndInit();
            this.panCallAgents.ResumeLayout(false);
            this.panCallAgents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.panEndUsers.ResumeLayout(false);
            this.panEndUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.panHome.ResumeLayout(false);
            this.panButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnCalls;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panAdmins;
        private System.Windows.Forms.Panel panCallAgents;
        private System.Windows.Forms.Panel panEndUsers;
        private System.Windows.Forms.Panel panHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContracts1;
        private System.Windows.Forms.Button btnClients1;
        private System.Windows.Forms.Button btnCalls1;
        private System.Windows.Forms.Panel panButtons;
        private System.Windows.Forms.Button btnCOUpdate;
        private System.Windows.Forms.Button btnCODelete;
        private System.Windows.Forms.Button btnCOAdd;
        private System.Windows.Forms.Button btnCOSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCOSequenceNo;
        private System.Windows.Forms.TextBox txtCOImportance;
        private System.Windows.Forms.TextBox txtCOType;
        private System.Windows.Forms.TextBox txtCOClientNo;
        private System.Windows.Forms.TextBox txtCOContractNo;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Button btnCAUpdate;
        private System.Windows.Forms.Button btnCADelete;
        private System.Windows.Forms.Button btnCAAdd;
        private System.Windows.Forms.Button btnCASearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCACallNo;
        private System.Windows.Forms.DataGridView dgvCalls;
        private System.Windows.Forms.Button btnCLUpdate;
        private System.Windows.Forms.Button btnCLDelete;
        private System.Windows.Forms.Button btnCLAdd;
        private System.Windows.Forms.Button btnCLSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCLAccountNo;
        private System.Windows.Forms.TextBox txtCLSurname;
        private System.Windows.Forms.TextBox txtCLName;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCLClientNo;
        private System.Windows.Forms.MaskedTextBox txtCATime;
        private System.Windows.Forms.MaskedTextBox txtCODate;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
    }
}

