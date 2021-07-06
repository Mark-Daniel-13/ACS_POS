namespace NTT_POS.SubForms.Admin
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.btnAddnewuser = new System.Windows.Forms.Button();
            this.lblUserSearch = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtUserSearch = new System.Windows.Forms.TextBox();
            this.userInfopnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblpnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnshow1 = new System.Windows.Forms.Button();
            this.btnhide1 = new System.Windows.Forms.Button();
            this.btnAccStat = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblUserIdValue = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpUsersData = new System.Windows.Forms.GroupBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddedByUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlUsers.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.userInfopnl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tblpnlButtons.SuspendLayout();
            this.grpUserInfo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grpUsersData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsers
            // 
            this.pnlUsers.AutoScroll = true;
            this.pnlUsers.AutoScrollMinSize = new System.Drawing.Size(600, 0);
            this.pnlUsers.BackColor = System.Drawing.Color.Transparent;
            this.pnlUsers.Controls.Add(this.btnAddnewuser);
            this.pnlUsers.Controls.Add(this.lblUserSearch);
            this.pnlUsers.Controls.Add(this.pnlSearch);
            this.pnlUsers.Controls.Add(this.userInfopnl);
            this.pnlUsers.Controls.Add(this.pnlMain);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsers.Location = new System.Drawing.Point(0, 0);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(1046, 715);
            this.pnlUsers.TabIndex = 0;
            // 
            // btnAddnewuser
            // 
            this.btnAddnewuser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddnewuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnAddnewuser.FlatAppearance.BorderSize = 0;
            this.btnAddnewuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnewuser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewuser.ForeColor = System.Drawing.Color.White;
            this.btnAddnewuser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddnewuser.Image")));
            this.btnAddnewuser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddnewuser.Location = new System.Drawing.Point(20, 667);
            this.btnAddnewuser.Name = "btnAddnewuser";
            this.btnAddnewuser.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddnewuser.Size = new System.Drawing.Size(161, 36);
            this.btnAddnewuser.TabIndex = 118;
            this.btnAddnewuser.Text = "Add new user";
            this.btnAddnewuser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddnewuser.UseVisualStyleBackColor = false;
            this.btnAddnewuser.Click += new System.EventHandler(this.BtnAddnewuser_Click);
            // 
            // lblUserSearch
            // 
            this.lblUserSearch.AutoSize = true;
            this.lblUserSearch.ForeColor = System.Drawing.Color.White;
            this.lblUserSearch.Location = new System.Drawing.Point(24, 13);
            this.lblUserSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserSearch.Name = "lblUserSearch";
            this.lblUserSearch.Size = new System.Drawing.Size(49, 19);
            this.lblUserSearch.TabIndex = 108;
            this.lblUserSearch.Text = "Search";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtUserSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.MinimumSize = new System.Drawing.Size(1100, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1100, 39);
            this.pnlSearch.TabIndex = 117;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(464, 9);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 26);
            this.btnSearch.TabIndex = 114;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtUserSearch
            // 
            this.txtUserSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserSearch.Location = new System.Drawing.Point(97, 10);
            this.txtUserSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUserSearch.Name = "txtUserSearch";
            this.txtUserSearch.Size = new System.Drawing.Size(362, 26);
            this.txtUserSearch.TabIndex = 1;
            // 
            // userInfopnl
            // 
            this.userInfopnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfopnl.AutoScroll = true;
            this.userInfopnl.BackColor = System.Drawing.Color.DimGray;
            this.userInfopnl.Controls.Add(this.panel2);
            this.userInfopnl.Controls.Add(this.panel1);
            this.userInfopnl.Controls.Add(this.tblpnlButtons);
            this.userInfopnl.Controls.Add(this.grpUserInfo);
            this.userInfopnl.Location = new System.Drawing.Point(27, 76);
            this.userInfopnl.Name = "userInfopnl";
            this.userInfopnl.Size = new System.Drawing.Size(992, 554);
            this.userInfopnl.TabIndex = 115;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnUpdateUser);
            this.panel2.Controls.Add(this.btnSaveUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 56);
            this.panel2.TabIndex = 119;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(527, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(197, 47);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnUpdateUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.Image")));
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Location = new System.Drawing.Point(304, 5);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUpdateUser.Size = new System.Drawing.Size(197, 47);
            this.btnUpdateUser.TabIndex = 7;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnSaveUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUser.ForeColor = System.Drawing.Color.White;
            this.btnSaveUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveUser.Image")));
            this.btnSaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUser.Location = new System.Drawing.Point(304, 5);
            this.btnSaveUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSaveUser.Size = new System.Drawing.Size(197, 47);
            this.btnSaveUser.TabIndex = 6;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.UseVisualStyleBackColor = false;
            this.btnSaveUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 40);
            this.panel1.TabIndex = 118;
            // 
            // tblpnlButtons
            // 
            this.tblpnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpnlButtons.ColumnCount = 4;
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblpnlButtons.Controls.Add(this.btnClearFields, 0, 0);
            this.tblpnlButtons.Controls.Add(this.btnDeleteUser, 1, 0);
            this.tblpnlButtons.Location = new System.Drawing.Point(42, 256);
            this.tblpnlButtons.Name = "tblpnlButtons";
            this.tblpnlButtons.RowCount = 1;
            this.tblpnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tblpnlButtons.Size = new System.Drawing.Size(0, 59);
            this.tblpnlButtons.TabIndex = 117;
            this.tblpnlButtons.Visible = false;
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(154)))), ((int)(((byte)(155)))));
            this.btnClearFields.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(108)))));
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.Location = new System.Drawing.Point(4, 6);
            this.btnClearFields.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(1, 47);
            this.btnClearFields.TabIndex = 8;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(104)))), ((int)(((byte)(48)))));
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(15)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(4, 6);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(1, 47);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUserInfo.Controls.Add(this.btnShow);
            this.grpUserInfo.Controls.Add(this.btnshow1);
            this.grpUserInfo.Controls.Add(this.btnhide1);
            this.grpUserInfo.Controls.Add(this.btnAccStat);
            this.grpUserInfo.Controls.Add(this.cbRole);
            this.grpUserInfo.Controls.Add(this.lblRole);
            this.grpUserInfo.Controls.Add(this.txtConfirmPassword);
            this.grpUserInfo.Controls.Add(this.lblConfirmPassword);
            this.grpUserInfo.Controls.Add(this.txtPassword);
            this.grpUserInfo.Controls.Add(this.lblPassword);
            this.grpUserInfo.Controls.Add(this.txtUserName);
            this.grpUserInfo.Controls.Add(this.lblUserName);
            this.grpUserInfo.Controls.Add(this.txtLastName);
            this.grpUserInfo.Controls.Add(this.txtFirstName);
            this.grpUserInfo.Controls.Add(this.lblLastName);
            this.grpUserInfo.Controls.Add(this.lblFirstName);
            this.grpUserInfo.Controls.Add(this.lblUserIdValue);
            this.grpUserInfo.Controls.Add(this.lblUserId);
            this.grpUserInfo.Controls.Add(this.btnHide);
            this.grpUserInfo.ForeColor = System.Drawing.Color.White;
            this.grpUserInfo.Location = new System.Drawing.Point(216, 71);
            this.grpUserInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpUserInfo.Size = new System.Drawing.Size(570, 333);
            this.grpUserInfo.TabIndex = 111;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "User Info";
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.BackColor = System.Drawing.Color.White;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Image = global::NTT_POS.Properties.Resources.btnshow1_Image;
            this.btnShow.Location = new System.Drawing.Point(536, 245);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(23, 23);
            this.btnShow.TabIndex = 18;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // btnshow1
            // 
            this.btnshow1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnshow1.BackColor = System.Drawing.Color.White;
            this.btnshow1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnshow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnshow1.Image = global::NTT_POS.Properties.Resources.btnshow1_Image;
            this.btnshow1.Location = new System.Drawing.Point(536, 284);
            this.btnshow1.Name = "btnshow1";
            this.btnshow1.Size = new System.Drawing.Size(23, 23);
            this.btnshow1.TabIndex = 16;
            this.btnshow1.UseVisualStyleBackColor = false;
            this.btnshow1.Click += new System.EventHandler(this.Btnshow1_Click);
            // 
            // btnhide1
            // 
            this.btnhide1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhide1.BackColor = System.Drawing.Color.White;
            this.btnhide1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnhide1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhide1.Image = global::NTT_POS.Properties.Resources.btnhide1_Image;
            this.btnhide1.Location = new System.Drawing.Point(536, 284);
            this.btnhide1.Name = "btnhide1";
            this.btnhide1.Size = new System.Drawing.Size(23, 23);
            this.btnhide1.TabIndex = 17;
            this.btnhide1.UseVisualStyleBackColor = false;
            this.btnhide1.Click += new System.EventHandler(this.Btnhide1_Click);
            // 
            // btnAccStat
            // 
            this.btnAccStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnAccStat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnAccStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccStat.ForeColor = System.Drawing.Color.White;
            this.btnAccStat.Image = ((System.Drawing.Image)(resources.GetObject("btnAccStat.Image")));
            this.btnAccStat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccStat.Location = new System.Drawing.Point(364, 45);
            this.btnAccStat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAccStat.Name = "btnAccStat";
            this.btnAccStat.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnAccStat.Size = new System.Drawing.Size(197, 33);
            this.btnAccStat.TabIndex = 11;
            this.btnAccStat.Text = "View Account Status";
            this.btnAccStat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccStat.UseVisualStyleBackColor = false;
            this.btnAccStat.Click += new System.EventHandler(this.btnAccStat_Click);
            // 
            // cbRole
            // 
            this.cbRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(174, 167);
            this.cbRole.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(388, 27);
            this.cbRole.TabIndex = 2;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(9, 170);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(70, 19);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "User Role:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(173, 282);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtConfirmPassword.MaxLength = 200;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(388, 26);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(6, 285);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(123, 19);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(174, 244);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(388, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 247);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 19);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password:";
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(174, 206);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUserName.MaxLength = 200;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(388, 26);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(7, 209);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(80, 19);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(174, 129);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtLastName.MaxLength = 200;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(388, 26);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.TextChanged += new System.EventHandler(this.TxtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(173, 91);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFirstName.MaxLength = 200;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(388, 26);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.TxtFirstName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(7, 132);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(77, 19);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 94);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(78, 19);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblUserIdValue
            // 
            this.lblUserIdValue.AutoSize = true;
            this.lblUserIdValue.Location = new System.Drawing.Point(169, 56);
            this.lblUserIdValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserIdValue.Name = "lblUserIdValue";
            this.lblUserIdValue.Size = new System.Drawing.Size(0, 19);
            this.lblUserIdValue.TabIndex = 1;
            this.lblUserIdValue.TextChanged += new System.EventHandler(this.lblUserIdValue_TextChanged);
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(6, 56);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(58, 19);
            this.lblUserId.TabIndex = 1;
            this.lblUserId.Text = "User ID:";
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.BackColor = System.Drawing.Color.White;
            this.btnHide.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Image = global::NTT_POS.Properties.Resources.btnhide1_Image;
            this.btnHide.Location = new System.Drawing.Point(536, 245);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(23, 23);
            this.btnHide.TabIndex = 19;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click_1);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Controls.Add(this.grpUsersData, 0, 0);
            this.pnlMain.Location = new System.Drawing.Point(20, 45);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 1;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Size = new System.Drawing.Size(1007, 597);
            this.pnlMain.TabIndex = 116;
            // 
            // grpUsersData
            // 
            this.grpUsersData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUsersData.Controls.Add(this.dgvUsers);
            this.grpUsersData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsersData.ForeColor = System.Drawing.Color.Black;
            this.grpUsersData.Location = new System.Drawing.Point(4, 6);
            this.grpUsersData.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpUsersData.Name = "grpUsersData";
            this.grpUsersData.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpUsersData.Size = new System.Drawing.Size(999, 585);
            this.grpUsersData.TabIndex = 110;
            this.grpUsersData.TabStop = false;
            this.grpUsersData.Text = "Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvUsers.ColumnHeadersHeight = 35;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserId,
            this.FirstName,
            this.LastName,
            this.Role,
            this.Username,
            this.Password,
            this.AddedByUser,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvUsers.Location = new System.Drawing.Point(4, 25);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(991, 554);
            this.dgvUsers.TabIndex = 100;
            this.dgvUsers.TabStop = false;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "User ID";
            this.UserId.MinimumWidth = 100;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UserId.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.FirstName.DefaultCellStyle = dataGridViewCellStyle14;
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 100;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.LastName.DefaultCellStyle = dataGridViewCellStyle15;
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 100;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Role.DefaultCellStyle = dataGridViewCellStyle16;
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 100;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Username.DefaultCellStyle = dataGridViewCellStyle17;
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 100;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 100;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // AddedByUser
            // 
            this.AddedByUser.DataPropertyName = "AddedByUser";
            this.AddedByUser.HeaderText = "Added By";
            this.AddedByUser.MinimumWidth = 100;
            this.AddedByUser.Name = "AddedByUser";
            this.AddedByUser.ReadOnly = true;
            this.AddedByUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::NTT_POS.Properties.Resources.icons8_edit_24__2_;
            this.Edit.Name = "Edit";
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // frmUsers
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 715);
            this.Controls.Add(this.pnlUsers);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmUsers";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            this.Resize += new System.EventHandler(this.FrmUsers_Resize);
            this.pnlUsers.ResumeLayout(false);
            this.pnlUsers.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.userInfopnl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tblpnlButtons.ResumeLayout(false);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.grpUsersData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.GroupBox grpUsersData;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblUserSearch;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.TextBox txtUserSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Panel userInfopnl;
        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.TableLayoutPanel tblpnlButtons;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.Button btnAccStat;

        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblUserIdValue;
        private System.Windows.Forms.Label lblUserId;

        private System.Windows.Forms.Button btnshow1;
        private System.Windows.Forms.Button btnhide1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnAddnewuser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddedByUser;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}