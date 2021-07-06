namespace NTT_POS.SubForms.Admin
{
    partial class frmCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.btnAddnewcategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.grpCategoryInfo = new System.Windows.Forms.GroupBox();
            this.txtCategoryDesc = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryDesc = new System.Windows.Forms.Label();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryIdValue = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.pnlsub = new System.Windows.Forms.TableLayoutPanel();
            this.grpCategoryData = new System.Windows.Forms.GroupBox();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtCategorySearch = new System.Windows.Forms.TextBox();
            this.lblCategorySearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlCategories.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpCategoryInfo.SuspendLayout();
            this.pnlsub.SuspendLayout();
            this.grpCategoryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategories
            // 
            this.pnlCategories.AutoScroll = true;
            this.pnlCategories.AutoScrollMinSize = new System.Drawing.Size(600, 0);
            this.pnlCategories.BackColor = System.Drawing.Color.Transparent;
            this.pnlCategories.Controls.Add(this.btnAddnewcategory);
            this.pnlCategories.Controls.Add(this.panel1);
            this.pnlCategories.Controls.Add(this.pnlsub);
            this.pnlCategories.Controls.Add(this.pnlSearch);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategories.Location = new System.Drawing.Point(0, 0);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(1370, 774);
            this.pnlCategories.TabIndex = 0;
            // 
            // btnAddnewcategory
            // 
            this.btnAddnewcategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddnewcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnAddnewcategory.FlatAppearance.BorderSize = 0;
            this.btnAddnewcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnewcategory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewcategory.ForeColor = System.Drawing.Color.White;
            this.btnAddnewcategory.Image = global::NTT_POS.Properties.Resources.icons8_category_32;
            this.btnAddnewcategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddnewcategory.Location = new System.Drawing.Point(22, 726);
            this.btnAddnewcategory.Name = "btnAddnewcategory";
            this.btnAddnewcategory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddnewcategory.Size = new System.Drawing.Size(193, 36);
            this.btnAddnewcategory.TabIndex = 120;
            this.btnAddnewcategory.Text = "Add new category";
            this.btnAddnewcategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddnewcategory.UseVisualStyleBackColor = false;
            this.btnAddnewcategory.Click += new System.EventHandler(this.BtnAddnewcustomer_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.grpCategoryInfo);
            this.panel1.Location = new System.Drawing.Point(27, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 569);
            this.panel1.TabIndex = 117;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnUpdateCategory);
            this.panel3.Controls.Add(this.btnAddCategory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1312, 59);
            this.panel3.TabIndex = 122;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::NTT_POS.Properties.Resources.icons8_return_30;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(642, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(197, 47);
            this.btnCancel.TabIndex = 121;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnUpdateCategory
            // 
            this.btnUpdateCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnUpdateCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnUpdateCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCategory.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCategory.Image = global::NTT_POS.Properties.Resources.icons8_update_32;
            this.btnUpdateCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCategory.Location = new System.Drawing.Point(422, 7);
            this.btnUpdateCategory.Name = "btnUpdateCategory";
            this.btnUpdateCategory.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUpdateCategory.Size = new System.Drawing.Size(197, 47);
            this.btnUpdateCategory.TabIndex = 3;
            this.btnUpdateCategory.Text = "Update";
            this.btnUpdateCategory.UseVisualStyleBackColor = false;
            this.btnUpdateCategory.Click += new System.EventHandler(this.btnUpdateCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Image = global::NTT_POS.Properties.Resources.icons8_save_32;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(422, 7);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnAddCategory.Size = new System.Drawing.Size(197, 47);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Save";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 40);
            this.panel2.TabIndex = 120;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteCategory, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnClearFields, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 370);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(117, 55);
            this.tableLayoutPanel1.TabIndex = 115;
            this.tableLayoutPanel1.Visible = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(104)))), ((int)(((byte)(48)))));
            this.btnDeleteCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteCategory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(15)))));
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(90, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(24, 49);
            this.btnDeleteCategory.TabIndex = 5;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(154)))), ((int)(((byte)(155)))));
            this.btnClearFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearFields.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(108)))));
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.ForeColor = System.Drawing.Color.White;
            this.btnClearFields.Location = new System.Drawing.Point(61, 3);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(23, 49);
            this.btnClearFields.TabIndex = 4;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // grpCategoryInfo
            // 
            this.grpCategoryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCategoryInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpCategoryInfo.Controls.Add(this.txtCategoryDesc);
            this.grpCategoryInfo.Controls.Add(this.txtCategoryName);
            this.grpCategoryInfo.Controls.Add(this.lblCategoryDesc);
            this.grpCategoryInfo.Controls.Add(this.lblCategoryName);
            this.grpCategoryInfo.Controls.Add(this.lblCategoryIdValue);
            this.grpCategoryInfo.Controls.Add(this.lblCategoryId);
            this.grpCategoryInfo.ForeColor = System.Drawing.Color.White;
            this.grpCategoryInfo.Location = new System.Drawing.Point(225, 203);
            this.grpCategoryInfo.Name = "grpCategoryInfo";
            this.grpCategoryInfo.Size = new System.Drawing.Size(832, 148);
            this.grpCategoryInfo.TabIndex = 103;
            this.grpCategoryInfo.TabStop = false;
            this.grpCategoryInfo.Text = "Category Info";
            // 
            // txtCategoryDesc
            // 
            this.txtCategoryDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryDesc.Location = new System.Drawing.Point(122, 101);
            this.txtCategoryDesc.MaxLength = 200;
            this.txtCategoryDesc.Name = "txtCategoryDesc";
            this.txtCategoryDesc.Size = new System.Drawing.Size(646, 26);
            this.txtCategoryDesc.TabIndex = 1;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoryName.Location = new System.Drawing.Point(122, 66);
            this.txtCategoryName.MaxLength = 200;
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(646, 26);
            this.txtCategoryName.TabIndex = 0;
            // 
            // lblCategoryDesc
            // 
            this.lblCategoryDesc.AutoSize = true;
            this.lblCategoryDesc.Location = new System.Drawing.Point(6, 106);
            this.lblCategoryDesc.Name = "lblCategoryDesc";
            this.lblCategoryDesc.Size = new System.Drawing.Size(78, 19);
            this.lblCategoryDesc.TabIndex = 3;
            this.lblCategoryDesc.Text = "Description";
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(6, 69);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(48, 19);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Name:";
            // 
            // lblCategoryIdValue
            // 
            this.lblCategoryIdValue.AutoSize = true;
            this.lblCategoryIdValue.Location = new System.Drawing.Point(118, 37);
            this.lblCategoryIdValue.Name = "lblCategoryIdValue";
            this.lblCategoryIdValue.Size = new System.Drawing.Size(0, 19);
            this.lblCategoryIdValue.TabIndex = 1;
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(6, 37);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(86, 19);
            this.lblCategoryId.TabIndex = 0;
            this.lblCategoryId.Text = "Category ID:";
            // 
            // pnlsub
            // 
            this.pnlsub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlsub.ColumnCount = 1;
            this.pnlsub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlsub.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlsub.Controls.Add(this.grpCategoryData, 0, 0);
            this.pnlsub.Location = new System.Drawing.Point(22, 45);
            this.pnlsub.Name = "pnlsub";
            this.pnlsub.RowCount = 1;
            this.pnlsub.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlsub.Size = new System.Drawing.Size(1323, 600);
            this.pnlsub.TabIndex = 116;
            // 
            // grpCategoryData
            // 
            this.grpCategoryData.BackColor = System.Drawing.Color.Transparent;
            this.grpCategoryData.Controls.Add(this.dgvCategories);
            this.grpCategoryData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCategoryData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategoryData.Location = new System.Drawing.Point(3, 3);
            this.grpCategoryData.Name = "grpCategoryData";
            this.grpCategoryData.Size = new System.Drawing.Size(1317, 594);
            this.grpCategoryData.TabIndex = 102;
            this.grpCategoryData.TabStop = false;
            this.grpCategoryData.Text = "Categories";
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategories.ColumnHeadersHeight = 35;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName,
            this.CategoryDesc,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.EnableHeadersVisualStyles = false;
            this.dgvCategories.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCategories.Location = new System.Drawing.Point(3, 22);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            this.dgvCategories.RowTemplate.Height = 24;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(1311, 569);
            this.dgvCategories.TabIndex = 100;
            this.dgvCategories.TabStop = false;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellClick);
            this.dgvCategories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategories_CellContentClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.txtCategorySearch);
            this.pnlSearch.Controls.Add(this.lblCategorySearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.MinimumSize = new System.Drawing.Size(1100, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1370, 44);
            this.pnlSearch.TabIndex = 101;
            // 
            // txtCategorySearch
            // 
            this.txtCategorySearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategorySearch.Location = new System.Drawing.Point(84, 10);
            this.txtCategorySearch.Name = "txtCategorySearch";
            this.txtCategorySearch.Size = new System.Drawing.Size(632, 26);
            this.txtCategorySearch.TabIndex = 101;
            // 
            // lblCategorySearch
            // 
            this.lblCategorySearch.AutoSize = true;
            this.lblCategorySearch.BackColor = System.Drawing.Color.Transparent;
            this.lblCategorySearch.ForeColor = System.Drawing.Color.White;
            this.lblCategorySearch.Location = new System.Drawing.Point(29, 17);
            this.lblCategorySearch.Name = "lblCategorySearch";
            this.lblCategorySearch.Size = new System.Drawing.Size(49, 19);
            this.lblCategorySearch.TabIndex = 100;
            this.lblCategorySearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::NTT_POS.Properties.Resources.icons8_search_20;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(736, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 26);
            this.btnSearch.TabIndex = 114;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::NTT_POS.Properties.Resources.icons8_edit_24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::NTT_POS.Properties.Resources.icons8_delete_bin_24;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // CategoryId
            // 
            this.CategoryId.DataPropertyName = "CategoryId";
            this.CategoryId.HeaderText = "Category ID";
            this.CategoryId.MinimumWidth = 10;
            this.CategoryId.Name = "CategoryId";
            this.CategoryId.ReadOnly = true;
            this.CategoryId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CategoryId.Visible = false;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CategoryName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CategoryName.HeaderText = "Name";
            this.CategoryName.MinimumWidth = 199;
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CategoryDesc
            // 
            this.CategoryDesc.DataPropertyName = "Description";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CategoryDesc.DefaultCellStyle = dataGridViewCellStyle3;
            this.CategoryDesc.HeaderText = "Description";
            this.CategoryDesc.MinimumWidth = 198;
            this.CategoryDesc.Name = "CategoryDesc";
            this.CategoryDesc.ReadOnly = true;
            this.CategoryDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.Delete.Image = global::NTT_POS.Properties.Resources.icons8_delete_bin_24;
            this.Delete.Name = "Delete";
            this.Delete.Width = 5;
            // 
            // frmCategories
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 774);
            this.Controls.Add(this.pnlCategories);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategories";
            this.Load += new System.EventHandler(this.frmCategories_Load);
            this.Resize += new System.EventHandler(this.FrmCategories_Resize);
            this.pnlCategories.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grpCategoryInfo.ResumeLayout(false);
            this.grpCategoryInfo.PerformLayout();
            this.pnlsub.ResumeLayout(false);
            this.grpCategoryData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnUpdateCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.GroupBox grpCategoryInfo;
        private System.Windows.Forms.TextBox txtCategoryDesc;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label lblCategoryDesc;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryIdValue;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox txtCategorySearch;
        private System.Windows.Forms.Label lblCategorySearch;
        private System.Windows.Forms.GroupBox grpCategoryData;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel pnlsub;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btnAddnewcategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryDesc;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}