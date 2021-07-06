
namespace NTT_POS.SubForms.Admin
{
    partial class frmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.dgvTransDetails = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retailprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.TransactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholesaleReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.tblpnlTransType = new System.Windows.Forms.TableLayoutPanel();
            this.lbTransType = new System.Windows.Forms.Label();
            this.cbWholeSale = new System.Windows.Forms.CheckBox();
            this.cbRetail = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpDailyEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDailyStartDate = new System.Windows.Forms.DateTimePicker();
            this.grpTransaction = new System.Windows.Forms.GroupBox();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.tblPnlPaging = new System.Windows.Forms.TableLayoutPanel();
            this.tblPnlPageNumber = new System.Windows.Forms.TableLayoutPanel();
            this.lblPage = new System.Windows.Forms.Label();
            this.tbCurrentPage = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblrowcout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.tblpnlTransType.SuspendLayout();
            this.grpTransaction.SuspendLayout();
            this.grpDetails.SuspendLayout();
            this.tblPnlPaging.SuspendLayout();
            this.tblPnlPageNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransDetails
            // 
            this.dgvTransDetails.AllowUserToAddRows = false;
            this.dgvTransDetails.AllowUserToDeleteRows = false;
            this.dgvTransDetails.AllowUserToResizeRows = false;
            this.dgvTransDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTransDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransDetails.ColumnHeadersHeight = 45;
            this.dgvTransDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ProductId,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.Quantity,
            this.retailprice,
            this.dataGridViewTextBoxColumn8});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransDetails.EnableHeadersVisualStyles = false;
            this.dgvTransDetails.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTransDetails.Location = new System.Drawing.Point(3, 22);
            this.dgvTransDetails.MultiSelect = false;
            this.dgvTransDetails.Name = "dgvTransDetails";
            this.dgvTransDetails.ReadOnly = true;
            this.dgvTransDetails.RowHeadersVisible = false;
            this.dgvTransDetails.RowTemplate.Height = 24;
            this.dgvTransDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransDetails.Size = new System.Drawing.Size(1334, 246);
            this.dgvTransDetails.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TransactionDetailId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Transaction Detail ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TransactionId";
            this.dataGridViewTextBoxColumn2.HeaderText = "Transaction ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Product ID";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductId.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn3.HeaderText = "Barcode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // retailprice
            // 
            this.retailprice.DataPropertyName = "RetailPrice";
            this.retailprice.HeaderText = "Retail Price";
            this.retailprice.Name = "retailprice";
            this.retailprice.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn8.FillWeight = 80.90362F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.AllowUserToResizeRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactions.ColumnHeadersHeight = 45;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionId,
            this.ReceiptNumber,
            this.CustomerName,
            this.UserName,
            this.TransactionType,
            this.WholesaleReason,
            this.DiscountAmount,
            this.CreationDate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTransactions.Location = new System.Drawing.Point(3, 22);
            this.dgvTransactions.MultiSelect = false;
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.RowTemplate.Height = 24;
            this.dgvTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactions.Size = new System.Drawing.Size(1340, 271);
            this.dgvTransactions.TabIndex = 0;
            this.dgvTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellContentClick);
            this.dgvTransactions.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransactions_CellEnter);
            // 
            // TransactionId
            // 
            this.TransactionId.DataPropertyName = "TransactionId";
            this.TransactionId.HeaderText = "Transaction ID";
            this.TransactionId.Name = "TransactionId";
            this.TransactionId.ReadOnly = true;
            this.TransactionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TransactionId.Visible = false;
            // 
            // ReceiptNumber
            // 
            this.ReceiptNumber.DataPropertyName = "ReceiptNumber";
            this.ReceiptNumber.FillWeight = 71.47208F;
            this.ReceiptNumber.HeaderText = "Receipt Number";
            this.ReceiptNumber.MinimumWidth = 140;
            this.ReceiptNumber.Name = "ReceiptNumber";
            this.ReceiptNumber.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.FillWeight = 0.2073784F;
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 150;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.FillWeight = 0.2073784F;
            this.UserName.HeaderText = "Cashier Name";
            this.UserName.MinimumWidth = 150;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // TransactionType
            // 
            this.TransactionType.DataPropertyName = "TransactionType";
            this.TransactionType.FillWeight = 5.94815F;
            this.TransactionType.HeaderText = "Type";
            this.TransactionType.MinimumWidth = 100;
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.ReadOnly = true;
            // 
            // WholesaleReason
            // 
            this.WholesaleReason.DataPropertyName = "WholesaleReason";
            this.WholesaleReason.FillWeight = 0.3190436F;
            this.WholesaleReason.HeaderText = "Reason";
            this.WholesaleReason.MinimumWidth = 250;
            this.WholesaleReason.Name = "WholesaleReason";
            this.WholesaleReason.ReadOnly = true;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.DataPropertyName = "DiscountAmount";
            this.DiscountAmount.FillWeight = 16.61364F;
            this.DiscountAmount.HeaderText = "Discount";
            this.DiscountAmount.MinimumWidth = 80;
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.FillWeight = 81.23232F;
            this.CreationDate.HeaderText = "Date";
            this.CreationDate.MinimumWidth = 120;
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::NTT_POS.Properties.Resources.icons8_print_32__1_;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(1096, 687);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPrint.Size = new System.Drawing.Size(262, 47);
            this.btnPrint.TabIndex = 107;
            this.btnPrint.TabStop = false;
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.tblpnlTransType);
            this.pnlSearch.Controls.Add(this.btnRefresh);
            this.pnlSearch.Controls.Add(this.dtpDailyEndDate);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Controls.Add(this.dtpDailyStartDate);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.MinimumSize = new System.Drawing.Size(1100, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1370, 55);
            this.pnlSearch.TabIndex = 112;
            // 
            // tblpnlTransType
            // 
            this.tblpnlTransType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblpnlTransType.ColumnCount = 3;
            this.tblpnlTransType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpnlTransType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpnlTransType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblpnlTransType.Controls.Add(this.lbTransType, 0, 0);
            this.tblpnlTransType.Controls.Add(this.cbWholeSale, 2, 0);
            this.tblpnlTransType.Controls.Add(this.cbRetail, 1, 0);
            this.tblpnlTransType.Location = new System.Drawing.Point(972, 15);
            this.tblpnlTransType.Name = "tblpnlTransType";
            this.tblpnlTransType.RowCount = 1;
            this.tblpnlTransType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlTransType.Size = new System.Drawing.Size(383, 30);
            this.tblpnlTransType.TabIndex = 1;
            // 
            // lbTransType
            // 
            this.lbTransType.AutoSize = true;
            this.lbTransType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTransType.Location = new System.Drawing.Point(3, 0);
            this.lbTransType.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lbTransType.Name = "lbTransType";
            this.lbTransType.Size = new System.Drawing.Size(114, 30);
            this.lbTransType.TabIndex = 116;
            this.lbTransType.Text = "Transaction Type:";
            this.lbTransType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbWholeSale
            // 
            this.cbWholeSale.AutoSize = true;
            this.cbWholeSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWholeSale.Location = new System.Drawing.Point(257, 3);
            this.cbWholeSale.Name = "cbWholeSale";
            this.cbWholeSale.Size = new System.Drawing.Size(123, 24);
            this.cbWholeSale.TabIndex = 1;
            this.cbWholeSale.Text = "Wholesale";
            this.cbWholeSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbWholeSale.UseVisualStyleBackColor = true;
            this.cbWholeSale.CheckedChanged += new System.EventHandler(this.cbWholeSale_CheckedChanged);
            // 
            // cbRetail
            // 
            this.cbRetail.AutoSize = true;
            this.cbRetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRetail.Location = new System.Drawing.Point(130, 3);
            this.cbRetail.Name = "cbRetail";
            this.cbRetail.Size = new System.Drawing.Size(121, 24);
            this.cbRetail.TabIndex = 0;
            this.cbRetail.Text = "Retail";
            this.cbRetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbRetail.UseVisualStyleBackColor = true;
            this.cbRetail.CheckStateChanged += new System.EventHandler(this.cbRetail_CheckStateChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(529, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 26);
            this.btnRefresh.TabIndex = 115;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpDailyEndDate
            // 
            this.dtpDailyEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDailyEndDate.Checked = false;
            this.dtpDailyEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDailyEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDailyEndDate.Location = new System.Drawing.Point(373, 16);
            this.dtpDailyEndDate.Name = "dtpDailyEndDate";
            this.dtpDailyEndDate.Size = new System.Drawing.Size(149, 26);
            this.dtpDailyEndDate.TabIndex = 23;
            this.dtpDailyEndDate.ValueChanged += new System.EventHandler(this.dtpDailyEndDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(292, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Start Date:";
            // 
            // dtpDailyStartDate
            // 
            this.dtpDailyStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDailyStartDate.Checked = false;
            this.dtpDailyStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDailyStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDailyStartDate.Location = new System.Drawing.Point(125, 16);
            this.dtpDailyStartDate.Name = "dtpDailyStartDate";
            this.dtpDailyStartDate.Size = new System.Drawing.Size(149, 26);
            this.dtpDailyStartDate.TabIndex = 21;
            this.dtpDailyStartDate.ValueChanged += new System.EventHandler(this.dtpDailyStartDate_ValueChanged);
            // 
            // grpTransaction
            // 
            this.grpTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTransaction.Controls.Add(this.dgvTransactions);
            this.grpTransaction.Location = new System.Drawing.Point(12, 61);
            this.grpTransaction.Name = "grpTransaction";
            this.grpTransaction.Size = new System.Drawing.Size(1346, 296);
            this.grpTransaction.TabIndex = 113;
            this.grpTransaction.TabStop = false;
            this.grpTransaction.Text = "Transactions:";
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.dgvTransDetails);
            this.grpDetails.Location = new System.Drawing.Point(15, 410);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(1340, 271);
            this.grpDetails.TabIndex = 114;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Transaction Details";
            // 
            // tblPnlPaging
            // 
            this.tblPnlPaging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPnlPaging.ColumnCount = 3;
            this.tblPnlPaging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnlPaging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnlPaging.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnlPaging.Controls.Add(this.tblPnlPageNumber, 1, 0);
            this.tblPnlPaging.Controls.Add(this.btnPrev, 0, 0);
            this.tblPnlPaging.Controls.Add(this.btnNext, 2, 0);
            this.tblPnlPaging.Location = new System.Drawing.Point(717, 363);
            this.tblPnlPaging.Name = "tblPnlPaging";
            this.tblPnlPaging.RowCount = 1;
            this.tblPnlPaging.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlPaging.Size = new System.Drawing.Size(638, 41);
            this.tblPnlPaging.TabIndex = 116;
            // 
            // tblPnlPageNumber
            // 
            this.tblPnlPageNumber.ColumnCount = 2;
            this.tblPnlPageNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlPageNumber.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlPageNumber.Controls.Add(this.lblPage, 1, 0);
            this.tblPnlPageNumber.Controls.Add(this.tbCurrentPage, 0, 0);
            this.tblPnlPageNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnlPageNumber.Location = new System.Drawing.Point(215, 3);
            this.tblPnlPageNumber.Name = "tblPnlPageNumber";
            this.tblPnlPageNumber.RowCount = 1;
            this.tblPnlPageNumber.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPnlPageNumber.Size = new System.Drawing.Size(206, 35);
            this.tblPnlPageNumber.TabIndex = 116;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.Location = new System.Drawing.Point(106, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(97, 35);
            this.lblPage.TabIndex = 116;
            this.lblPage.Text = "/0";
            this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCurrentPage
            // 
            this.tbCurrentPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrentPage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentPage.Location = new System.Drawing.Point(0, 0);
            this.tbCurrentPage.Margin = new System.Windows.Forms.Padding(0);
            this.tbCurrentPage.Name = "tbCurrentPage";
            this.tbCurrentPage.Size = new System.Drawing.Size(103, 33);
            this.tbCurrentPage.TabIndex = 117;
            this.tbCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCurrentPage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCurrentPage_KeyDown);
            this.tbCurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCurrentPage_KeyPress);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(4, 6);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(204, 29);
            this.btnPrev.TabIndex = 114;
            this.btnPrev.TabStop = false;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(428, 6);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(206, 29);
            this.btnNext.TabIndex = 115;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblrowcout
            // 
            this.lblrowcout.AutoSize = true;
            this.lblrowcout.Location = new System.Drawing.Point(14, 366);
            this.lblrowcout.Name = "lblrowcout";
            this.lblrowcout.Size = new System.Drawing.Size(17, 19);
            this.lblrowcout.TabIndex = 117;
            this.lblrowcout.Text = "0";
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 746);
            this.Controls.Add(this.lblrowcout);
            this.Controls.Add(this.tblPnlPaging);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.grpTransaction);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnPrint);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSales";
            this.Load += new System.EventHandler(this.frmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.tblpnlTransType.ResumeLayout(false);
            this.tblpnlTransType.PerformLayout();
            this.grpTransaction.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.tblPnlPaging.ResumeLayout(false);
            this.tblPnlPageNumber.ResumeLayout(false);
            this.tblPnlPageNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTransDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn retailprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.DateTimePicker dtpDailyEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDailyStartDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grpTransaction;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TableLayoutPanel tblpnlTransType;
        private System.Windows.Forms.CheckBox cbWholeSale;
        private System.Windows.Forms.CheckBox cbRetail;
        private System.Windows.Forms.Label lbTransType;
        private System.Windows.Forms.TableLayoutPanel tblPnlPaging;
        private System.Windows.Forms.TableLayoutPanel tblPnlPageNumber;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.TextBox tbCurrentPage;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblrowcout;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn WholesaleReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
    }
}