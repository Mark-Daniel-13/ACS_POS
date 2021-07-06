
namespace NTT_POS.SubForms.Admin
{
    partial class frmPurchaseOrderView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProductOrderDeitalViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProductOrderViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvOrderDetails = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductOrderDeitalViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductOrderViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductOrderDeitalViewModelBindingSource
            // 
            this.ProductOrderDeitalViewModelBindingSource.DataSource = typeof(NTT_POS.ViewModels.ProductOrderDeitalViewModel);
            // 
            // ProductOrderViewModelBindingSource
            // 
            this.ProductOrderViewModelBindingSource.DataSource = typeof(NTT_POS.ViewModels.ProductOrderViewModel);
            // 
            // rvOrderDetails
            // 
            this.rvOrderDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "PurchaseOrderDetail";
            reportDataSource1.Value = this.ProductOrderDeitalViewModelBindingSource;
            reportDataSource2.Name = "PurchaseOrder";
            reportDataSource2.Value = this.ProductOrderViewModelBindingSource;
            this.rvOrderDetails.LocalReport.DataSources.Add(reportDataSource1);
            this.rvOrderDetails.LocalReport.DataSources.Add(reportDataSource2);
            this.rvOrderDetails.LocalReport.ReportEmbeddedResource = "NTT_POS.Reports.PurchaseOrder.rdlc";
            this.rvOrderDetails.Location = new System.Drawing.Point(12, 12);
            this.rvOrderDetails.Name = "rvOrderDetails";
            this.rvOrderDetails.ServerReport.BearerToken = null;
            this.rvOrderDetails.ShowBackButton = false;
            this.rvOrderDetails.ShowContextMenu = false;
            this.rvOrderDetails.ShowCredentialPrompts = false;
            this.rvOrderDetails.ShowDocumentMapButton = false;
            this.rvOrderDetails.ShowFindControls = false;
            this.rvOrderDetails.ShowParameterPrompts = false;
            this.rvOrderDetails.ShowProgress = false;
            this.rvOrderDetails.ShowPromptAreaButton = false;
            this.rvOrderDetails.ShowRefreshButton = false;
            this.rvOrderDetails.ShowStopButton = false;
            this.rvOrderDetails.Size = new System.Drawing.Size(787, 605);
            this.rvOrderDetails.TabIndex = 128;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(104)))), ((int)(((byte)(48)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(629, 633);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(170, 42);
            this.btnCancel.TabIndex = 129;
            this.btnCancel.Text = "Exit View";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmPurchaseOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(811, 687);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rvOrderDetails);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPurchaseOrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPurchaseOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductOrderDeitalViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductOrderViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvOrderDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource ProductOrderDeitalViewModelBindingSource;
        private System.Windows.Forms.BindingSource ProductOrderViewModelBindingSource;
    }
}