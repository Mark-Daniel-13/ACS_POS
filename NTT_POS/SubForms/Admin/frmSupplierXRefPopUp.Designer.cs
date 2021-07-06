namespace NTT_POS.SubForms.Admin
{
    partial class frmSupplierXRefPopUp
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
            this.grpSupplierList = new System.Windows.Forms.GroupBox();
            this.clbSuppliers = new System.Windows.Forms.CheckedListBox();
            this.grpProductRef = new System.Windows.Forms.GroupBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.lbSupplierNameAdd = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNameValue = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSupplierIdValue = new System.Windows.Forms.Label();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSupplierList.SuspendLayout();
            this.grpProductRef.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSupplierList
            // 
            this.grpSupplierList.BackColor = System.Drawing.Color.Transparent;
            this.grpSupplierList.Controls.Add(this.clbSuppliers);
            this.grpSupplierList.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grpSupplierList.Location = new System.Drawing.Point(12, 59);
            this.grpSupplierList.Name = "grpSupplierList";
            this.grpSupplierList.Size = new System.Drawing.Size(225, 296);
            this.grpSupplierList.TabIndex = 1;
            this.grpSupplierList.TabStop = false;
            this.grpSupplierList.Text = "Suppliers";
            // 
            // clbSuppliers
            // 
            this.clbSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSuppliers.FormattingEnabled = true;
            this.clbSuppliers.Location = new System.Drawing.Point(3, 22);
            this.clbSuppliers.Name = "clbSuppliers";
            this.clbSuppliers.Size = new System.Drawing.Size(219, 271);
            this.clbSuppliers.TabIndex = 0;
            this.clbSuppliers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbSuppliers_ItemCheck);
            this.clbSuppliers.SelectedIndexChanged += new System.EventHandler(this.clbSuppliers_SelectedIndexChanged);
            // 
            // grpProductRef
            // 
            this.grpProductRef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProductRef.BackColor = System.Drawing.Color.Transparent;
            this.grpProductRef.Controls.Add(this.btnAddSupplier);
            this.grpProductRef.Controls.Add(this.txtSupplierName);
            this.grpProductRef.Controls.Add(this.lbSupplierNameAdd);
            this.grpProductRef.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.grpProductRef.Location = new System.Drawing.Point(243, 220);
            this.grpProductRef.Name = "grpProductRef";
            this.grpProductRef.Size = new System.Drawing.Size(514, 88);
            this.grpProductRef.TabIndex = 6;
            this.grpProductRef.TabStop = false;
            this.grpProductRef.Text = "Instant Create Supplier";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(205)))));
            this.btnAddSupplier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.ForeColor = System.Drawing.Color.White;
            this.btnAddSupplier.Image = global::NTT_POS.Properties.Resources.icons8_add_user_male_24__1_;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(374, 37);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(133, 25);
            this.btnAddSupplier.TabIndex = 115;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(125, 36);
            this.txtSupplierName.MaxLength = 60;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(242, 26);
            this.txtSupplierName.TabIndex = 7;
            // 
            // lbSupplierNameAdd
            // 
            this.lbSupplierNameAdd.AutoSize = true;
            this.lbSupplierNameAdd.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbSupplierNameAdd.Location = new System.Drawing.Point(22, 39);
            this.lbSupplierNameAdd.Name = "lbSupplierNameAdd";
            this.lbSupplierNameAdd.Size = new System.Drawing.Size(101, 19);
            this.lbSupplierNameAdd.TabIndex = 6;
            this.lbSupplierNameAdd.Text = "Supplier Name:";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lbSearch.Location = new System.Drawing.Point(21, 18);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(52, 19);
            this.lbSearch.TabIndex = 22;
            this.lbSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(83, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(373, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblNameValue);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblSupplierIdValue);
            this.groupBox1.Controls.Add(this.lblSupplierId);
            this.groupBox1.Controls.Add(this.txtUnitCost);
            this.groupBox1.Controls.Add(this.lblUnitCost);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(243, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 156);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit Cost On Selected Supplier";
            // 
            // lblNameValue
            // 
            this.lblNameValue.AutoSize = true;
            this.lblNameValue.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblNameValue.Location = new System.Drawing.Point(121, 73);
            this.lblNameValue.Name = "lblNameValue";
            this.lblNameValue.Size = new System.Drawing.Size(0, 19);
            this.lblNameValue.TabIndex = 119;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblName.Location = new System.Drawing.Point(18, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 19);
            this.lblName.TabIndex = 118;
            this.lblName.Text = "Name:";
            // 
            // lblSupplierIdValue
            // 
            this.lblSupplierIdValue.AutoSize = true;
            this.lblSupplierIdValue.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblSupplierIdValue.Location = new System.Drawing.Point(121, 43);
            this.lblSupplierIdValue.Name = "lblSupplierIdValue";
            this.lblSupplierIdValue.Size = new System.Drawing.Size(0, 19);
            this.lblSupplierIdValue.TabIndex = 117;
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblSupplierId.Location = new System.Drawing.Point(18, 43);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(77, 19);
            this.lblSupplierId.TabIndex = 116;
            this.lblSupplierId.Text = "Supplier Id:";
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Location = new System.Drawing.Point(125, 102);
            this.txtUnitCost.MaxLength = 6;
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(242, 26);
            this.txtUnitCost.TabIndex = 7;
            this.txtUnitCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitCost_KeyPress);
            this.txtUnitCost.Leave += new System.EventHandler(this.txtUnitCost_Leave);
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.AutoSize = true;
            this.lblUnitCost.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.lblUnitCost.Location = new System.Drawing.Point(18, 105);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Size = new System.Drawing.Size(70, 19);
            this.lblUnitCost.TabIndex = 6;
            this.lblUnitCost.Text = "Unit Cost:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(205)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::NTT_POS.Properties.Resources.icons8_search_24__2_;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(463, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 24);
            this.btnSearch.TabIndex = 114;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(104)))), ((int)(((byte)(48)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::NTT_POS.Properties.Resources.icons8_cancel_24__1_;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(341, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 41);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(205)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::NTT_POS.Properties.Resources.icons8_plus_24__1_;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(557, 314);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 41);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Select Suppliers";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSupplierXRefPopUp
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(769, 373);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpProductRef);
            this.Controls.Add(this.grpSupplierList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSupplierXRefPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supplier:";
            this.Load += new System.EventHandler(this.fromSupplierXRefPopUp_Load);
            this.grpSupplierList.ResumeLayout(false);
            this.grpProductRef.ResumeLayout(false);
            this.grpProductRef.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSupplierList;
        private System.Windows.Forms.CheckedListBox clbSuppliers;
        private System.Windows.Forms.GroupBox grpProductRef;
        private System.Windows.Forms.Label lbSupplierNameAdd;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.Label lblNameValue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSupplierIdValue;
        private System.Windows.Forms.Label lblSupplierId;
    }
}