namespace NTT_POS
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpPOS = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpData = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBreaker1 = new System.Windows.Forms.Panel();
            this.tlpTransCommands = new System.Windows.Forms.TableLayoutPanel();
            this.btnItemVoid = new System.Windows.Forms.Button();
            this.btnTransVoid = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnEditQuantity = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpTransactionInfo = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBreaker5 = new System.Windows.Forms.Panel();
            this.pnlBreaker4 = new System.Windows.Forms.Panel();
            this.lblTotalAmountDueLG = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlBreaker2 = new System.Windows.Forms.Panel();
            this.tlpAmountDueItems = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.pnlBreaker3 = new System.Windows.Forms.Panel();
            this.tlpItemCommands = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tlpTransactionDue = new System.Windows.Forms.TableLayoutPanel();
            this.txtAmountTendered = new System.Windows.Forms.TextBox();
            this.lblChangeValue = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblTotalAmountDueSM = new System.Windows.Forms.Label();
            this.lblTotalAmountDueSMValue = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblSubTotalValue = new System.Windows.Forms.Label();
            this.tlpDiscount = new System.Windows.Forms.TableLayoutPanel();
            this.lblDiscountValue = new System.Windows.Forms.Label();
            this.lblPDiscountValue = new System.Windows.Forms.Label();
            this.tlpProcessMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tlpProductQuantity = new System.Windows.Forms.TableLayoutPanel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.tblPnlCenterTexbox = new System.Windows.Forms.TableLayoutPanel();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.tlpDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurrDatetimeValue = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.tblpnlDivider = new System.Windows.Forms.TableLayoutPanel();
            this.lblLoggedUserValue = new System.Windows.Forms.Label();
            this.lblCustomerValue = new System.Windows.Forms.Label();
            this.btnTheme = new System.Windows.Forms.Button();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.tlpPOS.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpData.SuspendLayout();
            this.tlpTransCommands.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.tlpTransactionInfo.SuspendLayout();
            this.tlpAmountDueItems.SuspendLayout();
            this.tlpItemCommands.SuspendLayout();
            this.tlpTransactionDue.SuspendLayout();
            this.tlpDiscount.SuspendLayout();
            this.tlpProcessMenu.SuspendLayout();
            this.tlpProductQuantity.SuspendLayout();
            this.tblPnlCenterTexbox.SuspendLayout();
            this.tlpDetails.SuspendLayout();
            this.tblpnlDivider.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPOS
            // 
            this.tlpPOS.BackColor = System.Drawing.Color.Transparent;
            this.tlpPOS.ColumnCount = 1;
            this.tlpPOS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPOS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpPOS.Controls.Add(this.tlpMain, 0, 0);
            this.tlpPOS.Controls.Add(this.tlpDetails, 0, 1);
            this.tlpPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPOS.Location = new System.Drawing.Point(0, 0);
            this.tlpPOS.Name = "tlpPOS";
            this.tlpPOS.RowCount = 2;
            this.tlpPOS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlpPOS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpPOS.Size = new System.Drawing.Size(1080, 700);
            this.tlpPOS.TabIndex = 0;
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.Transparent;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpData, 0, 0);
            this.tlpMain.Controls.Add(this.tlpTransactionInfo, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpMain.Location = new System.Drawing.Point(4, 4);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(4);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1072, 657);
            this.tlpMain.TabIndex = 4;
            // 
            // tlpData
            // 
            this.tlpData.BackColor = System.Drawing.Color.Transparent;
            this.tlpData.ColumnCount = 1;
            this.tlpData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpData.Controls.Add(this.pnlBreaker1, 0, 1);
            this.tlpData.Controls.Add(this.tlpTransCommands, 0, 2);
            this.tlpData.Controls.Add(this.pnlData, 0, 0);
            this.tlpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpData.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpData.Location = new System.Drawing.Point(4, 4);
            this.tlpData.Margin = new System.Windows.Forms.Padding(4);
            this.tlpData.Name = "tlpData";
            this.tlpData.RowCount = 3;
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlpData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlpData.Size = new System.Drawing.Size(635, 649);
            this.tlpData.TabIndex = 0;
            // 
            // pnlBreaker1
            // 
            this.pnlBreaker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.pnlBreaker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBreaker1.Location = new System.Drawing.Point(3, 522);
            this.pnlBreaker1.Name = "pnlBreaker1";
            this.pnlBreaker1.Size = new System.Drawing.Size(629, 1);
            this.pnlBreaker1.TabIndex = 103;
            // 
            // tlpTransCommands
            // 
            this.tlpTransCommands.ColumnCount = 3;
            this.tlpTransCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTransCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTransCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpTransCommands.Controls.Add(this.btnItemVoid, 2, 1);
            this.tlpTransCommands.Controls.Add(this.btnTransVoid, 1, 1);
            this.tlpTransCommands.Controls.Add(this.btnDiscount, 0, 1);
            this.tlpTransCommands.Controls.Add(this.btnReturn, 2, 0);
            this.tlpTransCommands.Controls.Add(this.btnLookup, 1, 0);
            this.tlpTransCommands.Controls.Add(this.btnEditQuantity, 0, 0);
            this.tlpTransCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTransCommands.Location = new System.Drawing.Point(0, 525);
            this.tlpTransCommands.Margin = new System.Windows.Forms.Padding(0);
            this.tlpTransCommands.Name = "tlpTransCommands";
            this.tlpTransCommands.RowCount = 2;
            this.tlpTransCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTransCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpTransCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTransCommands.Size = new System.Drawing.Size(635, 124);
            this.tlpTransCommands.TabIndex = 104;
            // 
            // btnItemVoid
            // 
            this.btnItemVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnItemVoid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnItemVoid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnItemVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemVoid.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemVoid.ForeColor = System.Drawing.Color.White;
            this.btnItemVoid.Image = ((System.Drawing.Image)(resources.GetObject("btnItemVoid.Image")));
            this.btnItemVoid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemVoid.Location = new System.Drawing.Point(425, 65);
            this.btnItemVoid.Name = "btnItemVoid";
            this.btnItemVoid.Size = new System.Drawing.Size(207, 56);
            this.btnItemVoid.TabIndex = 5;
            this.btnItemVoid.TabStop = false;
            this.btnItemVoid.Text = "ITEM VOID";
            this.btnItemVoid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemVoid.UseVisualStyleBackColor = false;
            this.btnItemVoid.Click += new System.EventHandler(this.btnItemVoid_Click);
            // 
            // btnTransVoid
            // 
            this.btnTransVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnTransVoid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransVoid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnTransVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransVoid.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransVoid.ForeColor = System.Drawing.Color.White;
            this.btnTransVoid.Image = ((System.Drawing.Image)(resources.GetObject("btnTransVoid.Image")));
            this.btnTransVoid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransVoid.Location = new System.Drawing.Point(214, 65);
            this.btnTransVoid.Name = "btnTransVoid";
            this.btnTransVoid.Size = new System.Drawing.Size(205, 56);
            this.btnTransVoid.TabIndex = 4;
            this.btnTransVoid.TabStop = false;
            this.btnTransVoid.Text = "TRANS VOID";
            this.btnTransVoid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransVoid.UseVisualStyleBackColor = false;
            this.btnTransVoid.Click += new System.EventHandler(this.btnTransVoid_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiscount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(3, 65);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(205, 56);
            this.btnDiscount.TabIndex = 3;
            this.btnDiscount.TabStop = false;
            this.btnDiscount.Text = "DISCOUNT";
            this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(425, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(207, 56);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.TabStop = false;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnLookup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLookup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookup.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.ForeColor = System.Drawing.Color.White;
            this.btnLookup.Image = ((System.Drawing.Image)(resources.GetObject("btnLookup.Image")));
            this.btnLookup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLookup.Location = new System.Drawing.Point(214, 3);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(205, 56);
            this.btnLookup.TabIndex = 1;
            this.btnLookup.TabStop = false;
            this.btnLookup.Text = "LOOKUP";
            this.btnLookup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLookup.UseVisualStyleBackColor = false;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // btnEditQuantity
            // 
            this.btnEditQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnEditQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditQuantity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnEditQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditQuantity.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuantity.ForeColor = System.Drawing.Color.White;
            this.btnEditQuantity.Image = ((System.Drawing.Image)(resources.GetObject("btnEditQuantity.Image")));
            this.btnEditQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditQuantity.Location = new System.Drawing.Point(3, 3);
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.Size = new System.Drawing.Size(205, 56);
            this.btnEditQuantity.TabIndex = 0;
            this.btnEditQuantity.TabStop = false;
            this.btnEditQuantity.Text = "EDIT";
            this.btnEditQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditQuantity.UseVisualStyleBackColor = false;
            this.btnEditQuantity.Click += new System.EventHandler(this.btnEditQuantity_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvTransaction);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlData.Location = new System.Drawing.Point(3, 3);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(629, 513);
            this.pnlData.TabIndex = 105;
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToResizeRows = false;
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantity,
            this.ProductId,
            this.Product,
            this.Price,
            this.Amount});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransaction.EnableHeadersVisualStyles = false;
            this.dgvTransaction.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTransaction.Location = new System.Drawing.Point(0, 0);
            this.dgvTransaction.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.RowHeadersVisible = false;
            this.dgvTransaction.RowTemplate.Height = 24;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(629, 513);
            this.dgvTransaction.TabIndex = 102;
            this.dgvTransaction.TabStop = false;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantity.FillWeight = 50F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 100;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Product.DefaultCellStyle = dataGridViewCellStyle3;
            this.Product.FillWeight = 200F;
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 282;
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Price.DefaultCellStyle = dataGridViewCellStyle4;
            this.Price.FillWeight = 50F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle5;
            this.Amount.FillWeight = 50F;
            this.Amount.HeaderText = "Total";
            this.Amount.MinimumWidth = 100;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tlpTransactionInfo
            // 
            this.tlpTransactionInfo.ColumnCount = 1;
            this.tlpTransactionInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTransactionInfo.Controls.Add(this.pnlBreaker5, 0, 9);
            this.tlpTransactionInfo.Controls.Add(this.pnlBreaker4, 0, 7);
            this.tlpTransactionInfo.Controls.Add(this.lblTotalAmountDueLG, 0, 3);
            this.tlpTransactionInfo.Controls.Add(this.pnlLogo, 0, 0);
            this.tlpTransactionInfo.Controls.Add(this.pnlBreaker2, 0, 1);
            this.tlpTransactionInfo.Controls.Add(this.tlpAmountDueItems, 0, 2);
            this.tlpTransactionInfo.Controls.Add(this.pnlBreaker3, 0, 4);
            this.tlpTransactionInfo.Controls.Add(this.tlpItemCommands, 0, 6);
            this.tlpTransactionInfo.Controls.Add(this.tlpTransactionDue, 0, 8);
            this.tlpTransactionInfo.Controls.Add(this.tlpProcessMenu, 0, 10);
            this.tlpTransactionInfo.Controls.Add(this.tlpProductQuantity, 0, 5);
            this.tlpTransactionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTransactionInfo.Location = new System.Drawing.Point(646, 3);
            this.tlpTransactionInfo.Name = "tlpTransactionInfo";
            this.tlpTransactionInfo.RowCount = 11;
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.75057F));
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.990159F));
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.950795F));
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8202F));
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.990159F));
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.90159F));
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.931114F));
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.990159F));
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.76382F));
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 0.990159F));
            this.tlpTransactionInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.921272F));
            this.tlpTransactionInfo.Size = new System.Drawing.Size(423, 651);
            this.tlpTransactionInfo.TabIndex = 1;
            // 
            // pnlBreaker5
            // 
            this.pnlBreaker5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.pnlBreaker5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBreaker5.Location = new System.Drawing.Point(3, 592);
            this.pnlBreaker5.Name = "pnlBreaker5";
            this.pnlBreaker5.Size = new System.Drawing.Size(417, 1);
            this.pnlBreaker5.TabIndex = 10;
            // 
            // pnlBreaker4
            // 
            this.pnlBreaker4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.pnlBreaker4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBreaker4.Location = new System.Drawing.Point(3, 432);
            this.pnlBreaker4.Name = "pnlBreaker4";
            this.pnlBreaker4.Size = new System.Drawing.Size(417, 1);
            this.pnlBreaker4.TabIndex = 9;
            // 
            // lblTotalAmountDueLG
            // 
            this.lblTotalAmountDueLG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.lblTotalAmountDueLG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmountDueLG.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountDueLG.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountDueLG.Location = new System.Drawing.Point(3, 244);
            this.lblTotalAmountDueLG.Name = "lblTotalAmountDueLG";
            this.lblTotalAmountDueLG.Size = new System.Drawing.Size(417, 70);
            this.lblTotalAmountDueLG.TabIndex = 4;
            this.lblTotalAmountDueLG.Text = "0";
            this.lblTotalAmountDueLG.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::NTT_POS.Properties.Resources.bolt_1011;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogo.Location = new System.Drawing.Point(3, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(417, 200);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlBreaker2
            // 
            this.pnlBreaker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.pnlBreaker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBreaker2.Location = new System.Drawing.Point(3, 209);
            this.pnlBreaker2.Name = "pnlBreaker2";
            this.pnlBreaker2.Size = new System.Drawing.Size(417, 1);
            this.pnlBreaker2.TabIndex = 2;
            // 
            // tlpAmountDueItems
            // 
            this.tlpAmountDueItems.ColumnCount = 2;
            this.tlpAmountDueItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpAmountDueItems.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpAmountDueItems.Controls.Add(this.lblTotalItems, 1, 0);
            this.tlpAmountDueItems.Controls.Add(this.lblAmountDue, 0, 0);
            this.tlpAmountDueItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAmountDueItems.Location = new System.Drawing.Point(3, 215);
            this.tlpAmountDueItems.Name = "tlpAmountDueItems";
            this.tlpAmountDueItems.RowCount = 1;
            this.tlpAmountDueItems.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAmountDueItems.Size = new System.Drawing.Size(417, 26);
            this.tlpAmountDueItems.TabIndex = 3;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalItems.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.ForeColor = System.Drawing.Color.White;
            this.lblTotalItems.Location = new System.Drawing.Point(274, 0);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(140, 26);
            this.lblTotalItems.TabIndex = 3;
            this.lblTotalItems.Text = "0 Item(s)";
            this.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAmountDue.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.ForeColor = System.Drawing.Color.White;
            this.lblAmountDue.Location = new System.Drawing.Point(3, 0);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(265, 26);
            this.lblAmountDue.TabIndex = 0;
            this.lblAmountDue.Text = "Total Amount Due:";
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBreaker3
            // 
            this.pnlBreaker3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.pnlBreaker3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBreaker3.Location = new System.Drawing.Point(3, 317);
            this.pnlBreaker3.Name = "pnlBreaker3";
            this.pnlBreaker3.Size = new System.Drawing.Size(417, 1);
            this.pnlBreaker3.TabIndex = 5;
            // 
            // tlpItemCommands
            // 
            this.tlpItemCommands.ColumnCount = 2;
            this.tlpItemCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpItemCommands.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpItemCommands.Controls.Add(this.btnAddItem, 0, 0);
            this.tlpItemCommands.Controls.Add(this.btnCancel, 1, 0);
            this.tlpItemCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpItemCommands.Location = new System.Drawing.Point(3, 387);
            this.tlpItemCommands.Name = "tlpItemCommands";
            this.tlpItemCommands.RowCount = 1;
            this.tlpItemCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpItemCommands.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpItemCommands.Size = new System.Drawing.Size(417, 39);
            this.tlpItemCommands.TabIndex = 7;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.Location = new System.Drawing.Point(3, 3);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddItem.Size = new System.Drawing.Size(202, 33);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.TabStop = false;
            this.btnAddItem.Text = "ADD ITEM";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(211, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.btnCancel.Size = new System.Drawing.Size(203, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tlpTransactionDue
            // 
            this.tlpTransactionDue.ColumnCount = 2;
            this.tlpTransactionDue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpTransactionDue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpTransactionDue.Controls.Add(this.txtAmountTendered, 1, 3);
            this.tlpTransactionDue.Controls.Add(this.lblChangeValue, 1, 4);
            this.tlpTransactionDue.Controls.Add(this.lblChange, 0, 4);
            this.tlpTransactionDue.Controls.Add(this.lblCash, 0, 3);
            this.tlpTransactionDue.Controls.Add(this.lblTotalAmountDueSM, 0, 2);
            this.tlpTransactionDue.Controls.Add(this.lblTotalAmountDueSMValue, 1, 2);
            this.tlpTransactionDue.Controls.Add(this.lblDiscount, 0, 1);
            this.tlpTransactionDue.Controls.Add(this.lblSubTotal, 0, 0);
            this.tlpTransactionDue.Controls.Add(this.lblSubTotalValue, 1, 0);
            this.tlpTransactionDue.Controls.Add(this.tlpDiscount, 1, 1);
            this.tlpTransactionDue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTransactionDue.Location = new System.Drawing.Point(3, 438);
            this.tlpTransactionDue.Name = "tlpTransactionDue";
            this.tlpTransactionDue.RowCount = 5;
            this.tlpTransactionDue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTransactionDue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTransactionDue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTransactionDue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTransactionDue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpTransactionDue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTransactionDue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTransactionDue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpTransactionDue.Size = new System.Drawing.Size(417, 148);
            this.tlpTransactionDue.TabIndex = 8;
            // 
            // txtAmountTendered
            // 
            this.txtAmountTendered.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAmountTendered.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountTendered.ForeColor = System.Drawing.Color.Black;
            this.txtAmountTendered.Location = new System.Drawing.Point(128, 90);
            this.txtAmountTendered.Name = "txtAmountTendered";
            this.txtAmountTendered.Size = new System.Drawing.Size(286, 32);
            this.txtAmountTendered.TabIndex = 14;
            this.txtAmountTendered.Text = "0.00";
            this.txtAmountTendered.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmountTendered.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAmountTendered_MouseClick);
            this.txtAmountTendered.TextChanged += new System.EventHandler(this.txtAmountTendered_TextChanged);
            this.txtAmountTendered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmountTendered_KeyPress);
            // 
            // lblChangeValue
            // 
            this.lblChangeValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChangeValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeValue.ForeColor = System.Drawing.Color.White;
            this.lblChangeValue.Location = new System.Drawing.Point(128, 116);
            this.lblChangeValue.Name = "lblChangeValue";
            this.lblChangeValue.Size = new System.Drawing.Size(286, 30);
            this.lblChangeValue.TabIndex = 13;
            this.lblChangeValue.Text = "0.00";
            this.lblChangeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChange
            // 
            this.lblChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.White;
            this.lblChange.Location = new System.Drawing.Point(3, 116);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(119, 30);
            this.lblChange.TabIndex = 12;
            this.lblChange.Text = "Change";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCash
            // 
            this.lblCash.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCash.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.White;
            this.lblCash.Location = new System.Drawing.Point(3, 87);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(119, 29);
            this.lblCash.TabIndex = 11;
            this.lblCash.Text = "Cash";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmountDueSM
            // 
            this.lblTotalAmountDueSM.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalAmountDueSM.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountDueSM.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountDueSM.Location = new System.Drawing.Point(3, 58);
            this.lblTotalAmountDueSM.Name = "lblTotalAmountDueSM";
            this.lblTotalAmountDueSM.Size = new System.Drawing.Size(119, 29);
            this.lblTotalAmountDueSM.TabIndex = 9;
            this.lblTotalAmountDueSM.Text = "Total Amount";
            this.lblTotalAmountDueSM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalAmountDueSMValue
            // 
            this.lblTotalAmountDueSMValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalAmountDueSMValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountDueSMValue.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmountDueSMValue.Location = new System.Drawing.Point(128, 58);
            this.lblTotalAmountDueSMValue.Name = "lblTotalAmountDueSMValue";
            this.lblTotalAmountDueSMValue.Size = new System.Drawing.Size(286, 29);
            this.lblTotalAmountDueSMValue.TabIndex = 7;
            this.lblTotalAmountDueSMValue.Text = "0.00";
            this.lblTotalAmountDueSMValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotalAmountDueSMValue.TextChanged += new System.EventHandler(this.lblTotalAmountDueSMValue_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(3, 29);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(119, 29);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "LESS Discounts:";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.White;
            this.lblSubTotal.Location = new System.Drawing.Point(3, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(119, 29);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Sub Total:";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTotalValue
            // 
            this.lblSubTotalValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubTotalValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalValue.ForeColor = System.Drawing.Color.White;
            this.lblSubTotalValue.Location = new System.Drawing.Point(128, 0);
            this.lblSubTotalValue.Name = "lblSubTotalValue";
            this.lblSubTotalValue.Size = new System.Drawing.Size(286, 29);
            this.lblSubTotalValue.TabIndex = 1;
            this.lblSubTotalValue.Text = "0.00";
            this.lblSubTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpDiscount
            // 
            this.tlpDiscount.ColumnCount = 2;
            this.tlpDiscount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiscount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDiscount.Controls.Add(this.lblDiscountValue, 0, 0);
            this.tlpDiscount.Controls.Add(this.lblPDiscountValue, 0, 0);
            this.tlpDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDiscount.Location = new System.Drawing.Point(128, 32);
            this.tlpDiscount.Name = "tlpDiscount";
            this.tlpDiscount.RowCount = 1;
            this.tlpDiscount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDiscount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tlpDiscount.Size = new System.Drawing.Size(286, 23);
            this.tlpDiscount.TabIndex = 10;
            // 
            // lblDiscountValue
            // 
            this.lblDiscountValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDiscountValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountValue.ForeColor = System.Drawing.Color.White;
            this.lblDiscountValue.Location = new System.Drawing.Point(146, 0);
            this.lblDiscountValue.Name = "lblDiscountValue";
            this.lblDiscountValue.Size = new System.Drawing.Size(137, 23);
            this.lblDiscountValue.TabIndex = 3;
            this.lblDiscountValue.Text = "0.00";
            this.lblDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPDiscountValue
            // 
            this.lblPDiscountValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPDiscountValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDiscountValue.ForeColor = System.Drawing.Color.White;
            this.lblPDiscountValue.Location = new System.Drawing.Point(3, 0);
            this.lblPDiscountValue.Name = "lblPDiscountValue";
            this.lblPDiscountValue.Size = new System.Drawing.Size(137, 23);
            this.lblPDiscountValue.TabIndex = 2;
            this.lblPDiscountValue.Text = "0.00%";
            this.lblPDiscountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlpProcessMenu
            // 
            this.tlpProcessMenu.ColumnCount = 2;
            this.tlpProcessMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProcessMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpProcessMenu.Controls.Add(this.btnMenu, 0, 0);
            this.tlpProcessMenu.Controls.Add(this.btnProcess, 0, 0);
            this.tlpProcessMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProcessMenu.Location = new System.Drawing.Point(0, 595);
            this.tlpProcessMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tlpProcessMenu.Name = "tlpProcessMenu";
            this.tlpProcessMenu.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.tlpProcessMenu.RowCount = 1;
            this.tlpProcessMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProcessMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpProcessMenu.Size = new System.Drawing.Size(423, 56);
            this.tlpProcessMenu.TabIndex = 11;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.Location = new System.Drawing.Point(214, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(205, 49);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TabStop = false;
            this.btnMenu.Text = "&MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProcess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnProcess.Image")));
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcess.Location = new System.Drawing.Point(4, 3);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProcess.Size = new System.Drawing.Size(204, 49);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.TabStop = false;
            this.btnProcess.Text = "&PROCESS";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // tlpProductQuantity
            // 
            this.tlpProductQuantity.ColumnCount = 2;
            this.tlpProductQuantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpProductQuantity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpProductQuantity.Controls.Add(this.lblProduct, 0, 0);
            this.tlpProductQuantity.Controls.Add(this.tblPnlCenterTexbox, 1, 0);
            this.tlpProductQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProductQuantity.Location = new System.Drawing.Point(3, 323);
            this.tlpProductQuantity.Name = "tlpProductQuantity";
            this.tlpProductQuantity.RowCount = 1;
            this.tlpProductQuantity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProductQuantity.Size = new System.Drawing.Size(417, 58);
            this.tlpProductQuantity.TabIndex = 6;
            // 
            // lblProduct
            // 
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(3, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(119, 58);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Barcode:";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblPnlCenterTexbox
            // 
            this.tblPnlCenterTexbox.ColumnCount = 1;
            this.tblPnlCenterTexbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnlCenterTexbox.Controls.Add(this.txtProduct, 0, 1);
            this.tblPnlCenterTexbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnlCenterTexbox.Location = new System.Drawing.Point(128, 3);
            this.tblPnlCenterTexbox.Name = "tblPnlCenterTexbox";
            this.tblPnlCenterTexbox.RowCount = 3;
            this.tblPnlCenterTexbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnlCenterTexbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnlCenterTexbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPnlCenterTexbox.Size = new System.Drawing.Size(286, 52);
            this.tblPnlCenterTexbox.TabIndex = 1;
            // 
            // txtProduct
            // 
            this.txtProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(3, 20);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(280, 32);
            this.txtProduct.TabIndex = 1;
            this.txtProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tlpDetails
            // 
            this.tlpDetails.ColumnCount = 4;
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.0149F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.89199F));
            this.tlpDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDetails.Controls.Add(this.lblCurrDatetimeValue, 3, 0);
            this.tlpDetails.Controls.Add(this.lblCustomer, 1, 0);
            this.tlpDetails.Controls.Add(this.tblpnlDivider, 2, 0);
            this.tlpDetails.Controls.Add(this.btnTheme, 0, 0);
            this.tlpDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlpDetails.Location = new System.Drawing.Point(3, 668);
            this.tlpDetails.Name = "tlpDetails";
            this.tlpDetails.RowCount = 1;
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpDetails.Size = new System.Drawing.Size(1074, 29);
            this.tlpDetails.TabIndex = 5;
            // 
            // lblCurrDatetimeValue
            // 
            this.lblCurrDatetimeValue.AutoSize = true;
            this.lblCurrDatetimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrDatetimeValue.ForeColor = System.Drawing.Color.White;
            this.lblCurrDatetimeValue.Location = new System.Drawing.Point(807, 0);
            this.lblCurrDatetimeValue.Name = "lblCurrDatetimeValue";
            this.lblCurrDatetimeValue.Size = new System.Drawing.Size(264, 29);
            this.lblCurrDatetimeValue.TabIndex = 3;
            this.lblCurrDatetimeValue.Text = "01/01/2020";
            this.lblCurrDatetimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(271, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(166, 29);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Customer:";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblpnlDivider
            // 
            this.tblpnlDivider.ColumnCount = 2;
            this.tblpnlDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlDivider.Controls.Add(this.lblLoggedUserValue, 1, 0);
            this.tblpnlDivider.Controls.Add(this.lblCustomerValue, 0, 0);
            this.tblpnlDivider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlDivider.Location = new System.Drawing.Point(443, 3);
            this.tblpnlDivider.Name = "tblpnlDivider";
            this.tblpnlDivider.RowCount = 1;
            this.tblpnlDivider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlDivider.Size = new System.Drawing.Size(358, 23);
            this.tblpnlDivider.TabIndex = 6;
            // 
            // lblLoggedUserValue
            // 
            this.lblLoggedUserValue.AutoSize = true;
            this.lblLoggedUserValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoggedUserValue.ForeColor = System.Drawing.Color.White;
            this.lblLoggedUserValue.Location = new System.Drawing.Point(182, 0);
            this.lblLoggedUserValue.Name = "lblLoggedUserValue";
            this.lblLoggedUserValue.Size = new System.Drawing.Size(173, 23);
            this.lblLoggedUserValue.TabIndex = 2;
            this.lblLoggedUserValue.Text = "User";
            this.lblLoggedUserValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerValue
            // 
            this.lblCustomerValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerValue.ForeColor = System.Drawing.Color.White;
            this.lblCustomerValue.Location = new System.Drawing.Point(3, 0);
            this.lblCustomerValue.Name = "lblCustomerValue";
            this.lblCustomerValue.Size = new System.Drawing.Size(173, 23);
            this.lblCustomerValue.TabIndex = 5;
            this.lblCustomerValue.Text = "None";
            this.lblCustomerValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomerValue.Click += new System.EventHandler(this.lblCustomerValue_Click);
            this.lblCustomerValue.MouseEnter += new System.EventHandler(this.lblCustomerValue_MouseEnter);
            this.lblCustomerValue.MouseLeave += new System.EventHandler(this.lblCustomerValue_MouseLeave);
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.Location = new System.Drawing.Point(3, 3);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(151, 23);
            this.btnTheme.TabIndex = 7;
            this.btnTheme.Text = "Switch to: Light Theme";
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.BtnTheme_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // frmPOS
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1080, 700);
            this.Controls.Add(this.tlpPOS);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPOS_FormClosed);
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.tlpPOS.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.tlpData.ResumeLayout(false);
            this.tlpTransCommands.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.tlpTransactionInfo.ResumeLayout(false);
            this.tlpAmountDueItems.ResumeLayout(false);
            this.tlpAmountDueItems.PerformLayout();
            this.tlpItemCommands.ResumeLayout(false);
            this.tlpTransactionDue.ResumeLayout(false);
            this.tlpTransactionDue.PerformLayout();
            this.tlpDiscount.ResumeLayout(false);
            this.tlpProcessMenu.ResumeLayout(false);
            this.tlpProductQuantity.ResumeLayout(false);
            this.tblPnlCenterTexbox.ResumeLayout(false);
            this.tblPnlCenterTexbox.PerformLayout();
            this.tlpDetails.ResumeLayout(false);
            this.tlpDetails.PerformLayout();
            this.tblpnlDivider.ResumeLayout(false);
            this.tblpnlDivider.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPOS;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpData;
        private System.Windows.Forms.Panel pnlBreaker1;
        private System.Windows.Forms.TableLayoutPanel tlpTransCommands;
        private System.Windows.Forms.Button btnItemVoid;
        private System.Windows.Forms.Button btnTransVoid;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnEditQuantity;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.TableLayoutPanel tlpTransactionInfo;
        private System.Windows.Forms.Panel pnlBreaker5;
        private System.Windows.Forms.Panel pnlBreaker4;
        private System.Windows.Forms.Label lblTotalAmountDueLG;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlBreaker2;
        private System.Windows.Forms.TableLayoutPanel tlpAmountDueItems;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Panel pnlBreaker3;
        private System.Windows.Forms.TableLayoutPanel tlpProductQuantity;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TableLayoutPanel tlpItemCommands;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tlpTransactionDue;
        private System.Windows.Forms.TextBox txtAmountTendered;
        private System.Windows.Forms.Label lblChangeValue;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblTotalAmountDueSM;
        private System.Windows.Forms.Label lblTotalAmountDueSMValue;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblSubTotalValue;
        private System.Windows.Forms.TableLayoutPanel tlpDiscount;
        private System.Windows.Forms.Label lblDiscountValue;
        private System.Windows.Forms.Label lblPDiscountValue;
        private System.Windows.Forms.TableLayoutPanel tlpProcessMenu;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TableLayoutPanel tlpDetails;
        private System.Windows.Forms.Label lblLoggedUserValue;
        private System.Windows.Forms.Timer tmrClock;
        private System.Windows.Forms.Label lblCurrDatetimeValue;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCustomerValue;
        private System.Windows.Forms.TableLayoutPanel tblpnlDivider;
        private System.Windows.Forms.TableLayoutPanel tblPnlCenterTexbox;
        private System.Windows.Forms.Button btnTheme;
    }
}