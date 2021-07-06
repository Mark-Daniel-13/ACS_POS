namespace NTT_POS.SubForms.Admin
{
    partial class frmPurchaseHistory
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.grpOrders = new System.Windows.Forms.GroupBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.ProductOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.OrderDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelivered = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblpnlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productOrderDeitalViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productOrderViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.grpOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.tblpnlButtons.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderDeitalViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbSearch.ForeColor = System.Drawing.Color.Black;
            this.lbSearch.Location = new System.Drawing.Point(20, 25);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(61, 19);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.Text = "Supplier:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(534, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 25);
            this.btnSearch.TabIndex = 115;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(87, 19);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(440, 25);
            this.cbSearch.TabIndex = 116;
            this.cbSearch.SelectedValueChanged += new System.EventHandler(this.cbSearch_SelectedValueChanged);
            this.cbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSearch_KeyDown);
            // 
            // grpOrders
            // 
            this.grpOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrders.BackColor = System.Drawing.Color.Transparent;
            this.grpOrders.Controls.Add(this.dgvOrders);
            this.grpOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grpOrders.ForeColor = System.Drawing.Color.Black;
            this.grpOrders.Location = new System.Drawing.Point(12, 58);
            this.grpOrders.Name = "grpOrders";
            this.grpOrders.Size = new System.Drawing.Size(787, 231);
            this.grpOrders.TabIndex = 117;
            this.grpOrders.TabStop = false;
            this.grpOrders.Text = "Orders:";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.ColumnHeadersHeight = 35;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductOrderId,
            this.CreationDate,
            this.OrderStatusId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvOrders.Location = new System.Drawing.Point(3, 22);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            this.dgvOrders.RowTemplate.Height = 100;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(781, 206);
            this.dgvOrders.TabIndex = 101;
            this.dgvOrders.TabStop = false;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            this.dgvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellContentClick);
            // 
            // ProductOrderId
            // 
            this.ProductOrderId.DataPropertyName = "ProductOrderId";
            this.ProductOrderId.HeaderText = "ProductOrderId";
            this.ProductOrderId.Name = "ProductOrderId";
            this.ProductOrderId.ReadOnly = true;
            this.ProductOrderId.Visible = false;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "Order Date";
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // OrderStatusId
            // 
            this.OrderStatusId.DataPropertyName = "OrderStatusId";
            this.OrderStatusId.HeaderText = "Order Status";
            this.OrderStatusId.Name = "OrderStatusId";
            this.OrderStatusId.ReadOnly = true;
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOrderDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpOrderDetails.Controls.Add(this.dgvOrderDetails);
            this.grpOrderDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grpOrderDetails.ForeColor = System.Drawing.Color.Black;
            this.grpOrderDetails.Location = new System.Drawing.Point(12, 295);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Size = new System.Drawing.Size(787, 428);
            this.grpOrderDetails.TabIndex = 118;
            this.grpOrderDetails.TabStop = false;
            this.grpOrderDetails.Text = "Order Details:";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.AllowUserToAddRows = false;
            this.dgvOrderDetails.AllowUserToDeleteRows = false;
            this.dgvOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderDetails.ColumnHeadersHeight = 35;
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderDetailsId,
            this.ProductId,
            this.ProductName,
            this.OrderQuantity,
            this.ProductUnitCost,
            this.ProductTotalUnitCost,
            this.ExpirationDate});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.EnableHeadersVisualStyles = false;
            this.dgvOrderDetails.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvOrderDetails.Location = new System.Drawing.Point(3, 22);
            this.dgvOrderDetails.MultiSelect = false;
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersVisible = false;
            this.dgvOrderDetails.RowTemplate.Height = 24;
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(781, 403);
            this.dgvOrderDetails.TabIndex = 103;
            this.dgvOrderDetails.TabStop = false;
            this.dgvOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrderDetails_CellClick);
            this.dgvOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellContentClick);
            this.dgvOrderDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOrderDetails_CellEndEdit);
            this.dgvOrderDetails.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvOrderDetails_CellValidating);
            this.dgvOrderDetails.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.DgvOrderDetails_ColumnWidthChanged);
            this.dgvOrderDetails.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvOrderDetails_EditingControlShowing);
            this.dgvOrderDetails.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_RowLeave);
            this.dgvOrderDetails.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DgvOrderDetails_Scroll);
            // 
            // OrderDetailsId
            // 
            this.OrderDetailsId.DataPropertyName = "OrderDetailsId";
            this.OrderDetailsId.HeaderText = "productDetailId";
            this.OrderDetailsId.Name = "OrderDetailsId";
            this.OrderDetailsId.Visible = false;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // OrderQuantity
            // 
            this.OrderQuantity.DataPropertyName = "OrderQuantity";
            this.OrderQuantity.HeaderText = "Order Quantity";
            this.OrderQuantity.MaxInputLength = 10;
            this.OrderQuantity.Name = "OrderQuantity";
            // 
            // ProductUnitCost
            // 
            this.ProductUnitCost.DataPropertyName = "ProductUnitCost";
            this.ProductUnitCost.HeaderText = "Product Unit Cost";
            this.ProductUnitCost.MaxInputLength = 10;
            this.ProductUnitCost.Name = "ProductUnitCost";
            // 
            // ProductTotalUnitCost
            // 
            this.ProductTotalUnitCost.DataPropertyName = "ProductTotalUnitCost";
            dataGridViewCellStyle4.NullValue = null;
            this.ProductTotalUnitCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProductTotalUnitCost.HeaderText = "Total Unit Cost";
            this.ProductTotalUnitCost.Name = "ProductTotalUnitCost";
            this.ProductTotalUnitCost.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.DataPropertyName = "ExpirationDate";
            dataGridViewCellStyle5.Format = "MM/dd/yyyy";
            dataGridViewCellStyle5.NullValue = null;
            this.ExpirationDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.Name = "ExpirationDate";
            // 
            // btnDelivered
            // 
            this.btnDelivered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnDelivered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelivered.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(120)))), ((int)(((byte)(48)))));
            this.btnDelivered.FlatAppearance.BorderSize = 0;
            this.btnDelivered.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelivered.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnDelivered.ForeColor = System.Drawing.Color.White;
            this.btnDelivered.Image = ((System.Drawing.Image)(resources.GetObject("btnDelivered.Image")));
            this.btnDelivered.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelivered.Location = new System.Drawing.Point(190, 3);
            this.btnDelivered.Name = "btnDelivered";
            this.btnDelivered.Size = new System.Drawing.Size(171, 43);
            this.btnDelivered.TabIndex = 121;
            this.btnDelivered.Text = "Order Received";
            this.btnDelivered.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelivered.UseVisualStyleBackColor = false;
            this.btnDelivered.Click += new System.EventHandler(this.btnDelivered_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(15)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(3, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 43);
            this.btnCancel.TabIndex = 122;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tblpnlButtons
            // 
            this.tblpnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tblpnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.tblpnlButtons.ColumnCount = 3;
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.48359F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.032804F));
            this.tblpnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.4836F));
            this.tblpnlButtons.Controls.Add(this.btnModify, 2, 0);
            this.tblpnlButtons.Controls.Add(this.btnView, 0, 0);
            this.tblpnlButtons.Location = new System.Drawing.Point(12, 735);
            this.tblpnlButtons.Name = "tblpnlButtons";
            this.tblpnlButtons.RowCount = 1;
            this.tblpnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlButtons.Size = new System.Drawing.Size(372, 49);
            this.tblpnlButtons.TabIndex = 123;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(120)))), ((int)(((byte)(48)))));
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnModify.ForeColor = System.Drawing.Color.White;
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(194, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(175, 43);
            this.btnModify.TabIndex = 123;
            this.btnModify.Text = "Modify Order";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(120)))), ((int)(((byte)(48)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(3, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(174, 43);
            this.btnView.TabIndex = 124;
            this.btnView.Text = "View Order";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.Controls.Add(this.cbSearch);
            this.pnlTopBar.Controls.Add(this.lbSearch);
            this.pnlTopBar.Controls.Add(this.btnSearch);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(811, 52);
            this.pnlTopBar.TabIndex = 124;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.45361F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.092783F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.45361F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelivered, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(432, 735);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 49);
            this.tableLayoutPanel1.TabIndex = 128;
            // 
            // productOrderDeitalViewModelBindingSource
            // 
            this.productOrderDeitalViewModelBindingSource.DataSource = typeof(NTT_POS.ViewModels.ProductOrderDeitalViewModel);
            // 
            // productOrderViewModelBindingSource
            // 
            this.productOrderViewModelBindingSource.DataSource = typeof(NTT_POS.ViewModels.ProductOrderViewModel);
            // 
            // frmPurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(811, 793);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.tblpnlButtons);
            this.Controls.Add(this.grpOrderDetails);
            this.Controls.Add(this.grpOrders);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseHistory";
            this.Text = "PurchaseOrder";
            this.Load += new System.EventHandler(this.PurchaseOrder_Load);
            this.grpOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.grpOrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.tblpnlButtons.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productOrderDeitalViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productOrderViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.GroupBox grpOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.GroupBox grpOrderDetails;
        private System.Windows.Forms.Button btnDelivered;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tblpnlButtons;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusId;
        private System.Windows.Forms.BindingSource productOrderViewModelBindingSource;
        private System.Windows.Forms.BindingSource productOrderDeitalViewModelBindingSource;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDetailsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
    }
}