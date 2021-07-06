namespace NTT_POS.SubForms.Admin
{
    partial class frmSetting
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
            this.tcSetting = new System.Windows.Forms.TabControl();
            this.tcUser = new System.Windows.Forms.TabPage();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.tcSupplier = new System.Windows.Forms.TabPage();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.tcCustomer = new System.Windows.Forms.TabPage();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.tcCategories = new System.Windows.Forms.TabPage();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.tcImportExport = new System.Windows.Forms.TabPage();
            this.pnlImportExport = new System.Windows.Forms.Panel();
            this.tcTransactions = new System.Windows.Forms.TabPage();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.tcBranchInfo = new System.Windows.Forms.TabPage();
            this.pnlBranchInfo = new System.Windows.Forms.Panel();
            this.tcReturns = new System.Windows.Forms.TabPage();
            this.pnlReturns = new System.Windows.Forms.Panel();
            this.tcSetting.SuspendLayout();
            this.tcUser.SuspendLayout();
            this.tcSupplier.SuspendLayout();
            this.tcCustomer.SuspendLayout();
            this.tcCategories.SuspendLayout();
            this.tcImportExport.SuspendLayout();
            this.tcTransactions.SuspendLayout();
            this.tcBranchInfo.SuspendLayout();
            this.tcReturns.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcSetting
            // 
            this.tcSetting.Controls.Add(this.tcUser);
            this.tcSetting.Controls.Add(this.tcSupplier);
            this.tcSetting.Controls.Add(this.tcCustomer);
            this.tcSetting.Controls.Add(this.tcCategories);
            this.tcSetting.Controls.Add(this.tcImportExport);
            this.tcSetting.Controls.Add(this.tcTransactions);
            this.tcSetting.Controls.Add(this.tcBranchInfo);
            this.tcSetting.Controls.Add(this.tcReturns);
            this.tcSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcSetting.ItemSize = new System.Drawing.Size(120, 25);
            this.tcSetting.Location = new System.Drawing.Point(0, 0);
            this.tcSetting.Name = "tcSetting";
            this.tcSetting.SelectedIndex = 0;
            this.tcSetting.Size = new System.Drawing.Size(1370, 537);
            this.tcSetting.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcSetting.TabIndex = 0;
            this.tcSetting.SelectedIndexChanged += new System.EventHandler(this.tcSetting_SelectedIndexChanged);
            // 
            // tcUser
            // 
            this.tcUser.Controls.Add(this.pnlUser);
            this.tcUser.Location = new System.Drawing.Point(4, 29);
            this.tcUser.Name = "tcUser";
            this.tcUser.Padding = new System.Windows.Forms.Padding(3);
            this.tcUser.Size = new System.Drawing.Size(1362, 504);
            this.tcUser.TabIndex = 0;
            this.tcUser.Text = "User";
            this.tcUser.UseVisualStyleBackColor = true;
            // 
            // pnlUser
            // 
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.Location = new System.Drawing.Point(3, 3);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(1356, 498);
            this.pnlUser.TabIndex = 0;
            // 
            // tcSupplier
            // 
            this.tcSupplier.Controls.Add(this.pnlSupplier);
            this.tcSupplier.Location = new System.Drawing.Point(4, 29);
            this.tcSupplier.Name = "tcSupplier";
            this.tcSupplier.Padding = new System.Windows.Forms.Padding(3);
            this.tcSupplier.Size = new System.Drawing.Size(1362, 504);
            this.tcSupplier.TabIndex = 1;
            this.tcSupplier.Text = "Supplier";
            this.tcSupplier.UseVisualStyleBackColor = true;
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSupplier.Location = new System.Drawing.Point(3, 3);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(1356, 498);
            this.pnlSupplier.TabIndex = 0;
            // 
            // tcCustomer
            // 
            this.tcCustomer.Controls.Add(this.pnlCustomer);
            this.tcCustomer.Location = new System.Drawing.Point(4, 29);
            this.tcCustomer.Name = "tcCustomer";
            this.tcCustomer.Size = new System.Drawing.Size(1362, 504);
            this.tcCustomer.TabIndex = 2;
            this.tcCustomer.Text = "Customer";
            this.tcCustomer.UseVisualStyleBackColor = true;
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 0);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(1362, 504);
            this.pnlCustomer.TabIndex = 0;
            // 
            // tcCategories
            // 
            this.tcCategories.Controls.Add(this.pnlCategory);
            this.tcCategories.Location = new System.Drawing.Point(4, 29);
            this.tcCategories.Name = "tcCategories";
            this.tcCategories.Size = new System.Drawing.Size(1362, 504);
            this.tcCategories.TabIndex = 3;
            this.tcCategories.Text = "Category";
            this.tcCategories.UseVisualStyleBackColor = true;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategory.Location = new System.Drawing.Point(0, 0);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(1362, 504);
            this.pnlCategory.TabIndex = 0;
            // 
            // tcImportExport
            // 
            this.tcImportExport.Controls.Add(this.pnlImportExport);
            this.tcImportExport.Location = new System.Drawing.Point(4, 29);
            this.tcImportExport.Name = "tcImportExport";
            this.tcImportExport.Size = new System.Drawing.Size(1362, 504);
            this.tcImportExport.TabIndex = 4;
            this.tcImportExport.Text = "Import / Export";
            this.tcImportExport.UseVisualStyleBackColor = true;
            // 
            // pnlImportExport
            // 
            this.pnlImportExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImportExport.Location = new System.Drawing.Point(0, 0);
            this.pnlImportExport.Name = "pnlImportExport";
            this.pnlImportExport.Size = new System.Drawing.Size(1362, 504);
            this.pnlImportExport.TabIndex = 0;
            // 
            // tcTransactions
            // 
            this.tcTransactions.Controls.Add(this.pnlSales);
            this.tcTransactions.Location = new System.Drawing.Point(4, 29);
            this.tcTransactions.Name = "tcTransactions";
            this.tcTransactions.Size = new System.Drawing.Size(1362, 504);
            this.tcTransactions.TabIndex = 5;
            this.tcTransactions.Text = "Sales Transaction";
            this.tcTransactions.UseVisualStyleBackColor = true;
            // 
            // pnlSales
            // 
            this.pnlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSales.Location = new System.Drawing.Point(0, 0);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(1362, 504);
            this.pnlSales.TabIndex = 1;
            // 
            // tcBranchInfo
            // 
            this.tcBranchInfo.Controls.Add(this.pnlBranchInfo);
            this.tcBranchInfo.Location = new System.Drawing.Point(4, 29);
            this.tcBranchInfo.Name = "tcBranchInfo";
            this.tcBranchInfo.Size = new System.Drawing.Size(1362, 504);
            this.tcBranchInfo.TabIndex = 6;
            this.tcBranchInfo.Text = "BranchInfo";
            this.tcBranchInfo.UseVisualStyleBackColor = true;
            // 
            // pnlBranchInfo
            // 
            this.pnlBranchInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBranchInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlBranchInfo.Name = "pnlBranchInfo";
            this.pnlBranchInfo.Size = new System.Drawing.Size(1362, 504);
            this.pnlBranchInfo.TabIndex = 2;
            // 
            // tcReturns
            // 
            this.tcReturns.Controls.Add(this.pnlReturns);
            this.tcReturns.Location = new System.Drawing.Point(4, 29);
            this.tcReturns.Name = "tcReturns";
            this.tcReturns.Size = new System.Drawing.Size(1362, 504);
            this.tcReturns.TabIndex = 7;
            this.tcReturns.Text = "Returned Items";
            this.tcReturns.UseVisualStyleBackColor = true;
            // 
            // pnlReturns
            // 
            this.pnlReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReturns.Location = new System.Drawing.Point(0, 0);
            this.pnlReturns.Name = "pnlReturns";
            this.pnlReturns.Size = new System.Drawing.Size(1362, 504);
            this.pnlReturns.TabIndex = 3;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 537);
            this.Controls.Add(this.tcSetting);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetting";
            this.tcSetting.ResumeLayout(false);
            this.tcUser.ResumeLayout(false);
            this.tcSupplier.ResumeLayout(false);
            this.tcCustomer.ResumeLayout(false);
            this.tcCategories.ResumeLayout(false);
            this.tcImportExport.ResumeLayout(false);
            this.tcTransactions.ResumeLayout(false);
            this.tcBranchInfo.ResumeLayout(false);
            this.tcReturns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcSetting;
        private System.Windows.Forms.TabPage tcUser;
        private System.Windows.Forms.TabPage tcSupplier;
        private System.Windows.Forms.TabPage tcCustomer;
        private System.Windows.Forms.TabPage tcCategories;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.TabPage tcImportExport;
        private System.Windows.Forms.Panel pnlImportExport;
        private System.Windows.Forms.TabPage tcTransactions;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.TabPage tcBranchInfo;
        private System.Windows.Forms.Panel pnlBranchInfo;
        private System.Windows.Forms.TabPage tcReturns;
        private System.Windows.Forms.Panel pnlReturns;
    }
}