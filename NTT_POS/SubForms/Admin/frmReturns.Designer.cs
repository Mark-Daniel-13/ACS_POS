
namespace NTT_POS.SubForms.Admin
{
    partial class frmReturns
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpReviewReturn = new System.Windows.Forms.GroupBox();
            this.dgvReturns = new System.Windows.Forms.DataGridView();
            this.ReturnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpDailyEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDailyStartDate = new System.Windows.Forms.DateTimePicker();
            this.cmbReturnStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpReviewReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturns)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReviewReturn
            // 
            this.grpReviewReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpReviewReturn.Controls.Add(this.dgvReturns);
            this.grpReviewReturn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReviewReturn.Location = new System.Drawing.Point(13, 64);
            this.grpReviewReturn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpReviewReturn.Name = "grpReviewReturn";
            this.grpReviewReturn.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpReviewReturn.Size = new System.Drawing.Size(656, 402);
            this.grpReviewReturn.TabIndex = 111;
            this.grpReviewReturn.TabStop = false;
            this.grpReviewReturn.Text = "Returns To Be Review:";
            // 
            // dgvReturns
            // 
            this.dgvReturns.AllowUserToAddRows = false;
            this.dgvReturns.AllowUserToDeleteRows = false;
            this.dgvReturns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReturns.BackgroundColor = System.Drawing.Color.White;
            this.dgvReturns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReturns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReturns.ColumnHeadersHeight = 35;
            this.dgvReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReturns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReturnId,
            this.TransactionDetailId,
            this.ProductName,
            this.PurchaseQuantity,
            this.ReturnedQuantity,
            this.ReturnedAmount,
            this.CashierName,
            this.ReturnStatus,
            this.Reason});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReturns.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReturns.EnableHeadersVisualStyles = false;
            this.dgvReturns.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvReturns.Location = new System.Drawing.Point(4, 25);
            this.dgvReturns.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgvReturns.MultiSelect = false;
            this.dgvReturns.Name = "dgvReturns";
            this.dgvReturns.RowHeadersVisible = false;
            this.dgvReturns.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            this.dgvReturns.RowTemplate.Height = 24;
            this.dgvReturns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReturns.Size = new System.Drawing.Size(648, 371);
            this.dgvReturns.TabIndex = 100;
            this.dgvReturns.TabStop = false;
            this.dgvReturns.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturns_CellClick);
            this.dgvReturns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturns_CellContentClick);
            // 
            // ReturnId
            // 
            this.ReturnId.DataPropertyName = "ReturnId";
            this.ReturnId.HeaderText = "ReturnId";
            this.ReturnId.Name = "ReturnId";
            this.ReturnId.ReadOnly = true;
            this.ReturnId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ReturnId.Visible = false;
            // 
            // TransactionDetailId
            // 
            this.TransactionDetailId.DataPropertyName = "TransactionDetailId";
            this.TransactionDetailId.HeaderText = "TransactionDetailId";
            this.TransactionDetailId.Name = "TransactionDetailId";
            this.TransactionDetailId.ReadOnly = true;
            this.TransactionDetailId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TransactionDetailId.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 100;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PurchaseQuantity
            // 
            this.PurchaseQuantity.DataPropertyName = "PurchaseQuantity";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PurchaseQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.PurchaseQuantity.HeaderText = "Purchase Quantity";
            this.PurchaseQuantity.MinimumWidth = 100;
            this.PurchaseQuantity.Name = "PurchaseQuantity";
            this.PurchaseQuantity.ReadOnly = true;
            this.PurchaseQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReturnedQuantity
            // 
            this.ReturnedQuantity.DataPropertyName = "ReturnedQuantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ReturnedQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.ReturnedQuantity.HeaderText = "Returned Quantity";
            this.ReturnedQuantity.MinimumWidth = 100;
            this.ReturnedQuantity.Name = "ReturnedQuantity";
            this.ReturnedQuantity.ReadOnly = true;
            this.ReturnedQuantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReturnedAmount
            // 
            this.ReturnedAmount.DataPropertyName = "ReturnedAmount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ReturnedAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.ReturnedAmount.HeaderText = "Returned Amount";
            this.ReturnedAmount.MinimumWidth = 100;
            this.ReturnedAmount.Name = "ReturnedAmount";
            this.ReturnedAmount.ReadOnly = true;
            this.ReturnedAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CashierName
            // 
            this.CashierName.DataPropertyName = "CashierName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CashierName.DefaultCellStyle = dataGridViewCellStyle6;
            this.CashierName.HeaderText = "Cashier Name";
            this.CashierName.Name = "CashierName";
            this.CashierName.ReadOnly = true;
            this.CashierName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CashierName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReturnStatus
            // 
            this.ReturnStatus.DataPropertyName = "ReturnStatus";
            this.ReturnStatus.HeaderText = "ReturnStatus";
            this.ReturnStatus.Name = "ReturnStatus";
            this.ReturnStatus.Visible = false;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.Visible = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.btnRefresh);
            this.pnlSearch.Controls.Add(this.dtpDailyEndDate);
            this.pnlSearch.Controls.Add(this.label2);
            this.pnlSearch.Controls.Add(this.label3);
            this.pnlSearch.Controls.Add(this.dtpDailyStartDate);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.MinimumSize = new System.Drawing.Size(1100, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1100, 55);
            this.pnlSearch.TabIndex = 113;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(205)))));
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(529, 15);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 26);
            this.btnRefresh.TabIndex = 115;
            this.btnRefresh.Text = "Refresh";
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
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 19);
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
            this.label3.Location = new System.Drawing.Point(38, 19);
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
            // 
            // cmbReturnStatus
            // 
            this.cmbReturnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReturnStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReturnStatus.Items.AddRange(new object[] {
            "To Be Reviewed",
            "Return To Shelf",
            "Discard Item"});
            this.cmbReturnStatus.Location = new System.Drawing.Point(146, 477);
            this.cmbReturnStatus.Name = "cmbReturnStatus";
            this.cmbReturnStatus.Size = new System.Drawing.Size(519, 27);
            this.cmbReturnStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 480);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 114;
            this.label1.Text = "Return Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 517);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 115;
            this.label4.Text = "Reason:";
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Location = new System.Drawing.Point(146, 517);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ReadOnly = true;
            this.txtReason.Size = new System.Drawing.Size(523, 95);
            this.txtReason.TabIndex = 116;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(205)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(536, 621);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 30);
            this.btnUpdate.TabIndex = 117;
            this.btnUpdate.Text = "Save";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmReturns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 670);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbReturnStatus);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.grpReviewReturn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReturns";
            this.Text = "frmReturns";
            this.Load += new System.EventHandler(this.frmReturns_Load);
            this.grpReviewReturn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturns)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReviewReturn;
        private System.Windows.Forms.DataGridView dgvReturns;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpDailyEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDailyStartDate;
        private System.Windows.Forms.ComboBox cmbReturnStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
    }
}