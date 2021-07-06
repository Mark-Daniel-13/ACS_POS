
namespace NTT_POS.SubForms.Admin.Reports
{
    partial class ReturnedItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.returnsReportViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvReturns = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlSubcontrol = new System.Windows.Forms.TableLayoutPanel();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.returnsReportViewModelBindingSource)).BeginInit();
            this.pnlSubcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnsReportViewModelBindingSource
            // 
            this.returnsReportViewModelBindingSource.DataSource = typeof(NTT_POS.ViewModels.ReturnsReportViewModel);
            // 
            // rvReturns
            // 
            this.rvReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReturnsReport";
            reportDataSource1.Value = this.returnsReportViewModelBindingSource;
            this.rvReturns.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReturns.LocalReport.ReportEmbeddedResource = "NTT_POS.Reports.ReturnReport.rdlc";
            this.rvReturns.Location = new System.Drawing.Point(0, 39);
            this.rvReturns.Name = "rvReturns";
            this.rvReturns.ServerReport.BearerToken = null;
            this.rvReturns.ShowBackButton = false;
            this.rvReturns.ShowContextMenu = false;
            this.rvReturns.ShowCredentialPrompts = false;
            this.rvReturns.ShowDocumentMapButton = false;
            this.rvReturns.ShowFindControls = false;
            this.rvReturns.ShowParameterPrompts = false;
            this.rvReturns.ShowProgress = false;
            this.rvReturns.ShowPromptAreaButton = false;
            this.rvReturns.ShowRefreshButton = false;
            this.rvReturns.ShowStopButton = false;
            this.rvReturns.Size = new System.Drawing.Size(794, 319);
            this.rvReturns.TabIndex = 9;
            // 
            // pnlSubcontrol
            // 
            this.pnlSubcontrol.ColumnCount = 15;
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.205786F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.30868F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.408368F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.205786F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.30868F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.408368F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.205786F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.30868F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.408368F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.205786F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.41157F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.408368F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.205786F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlSubcontrol.Controls.Add(this.cbOrder, 8, 0);
            this.pnlSubcontrol.Controls.Add(this.label1, 7, 0);
            this.pnlSubcontrol.Controls.Add(this.dtpEndDate, 5, 0);
            this.pnlSubcontrol.Controls.Add(this.label2, 4, 0);
            this.pnlSubcontrol.Controls.Add(this.dtpStartDate, 2, 0);
            this.pnlSubcontrol.Controls.Add(this.label3, 1, 0);
            this.pnlSubcontrol.Controls.Add(this.btnView, 13, 0);
            this.pnlSubcontrol.Controls.Add(this.label4, 10, 0);
            this.pnlSubcontrol.Controls.Add(this.cbFilter, 11, 0);
            this.pnlSubcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubcontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlSubcontrol.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubcontrol.Name = "pnlSubcontrol";
            this.pnlSubcontrol.RowCount = 1;
            this.pnlSubcontrol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSubcontrol.Size = new System.Drawing.Size(794, 39);
            this.pnlSubcontrol.TabIndex = 10;
            // 
            // cbOrder
            // 
            this.cbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Location = new System.Drawing.Point(413, 9);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(85, 21);
            this.cbOrder.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Order:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEndDate.Checked = false;
            this.dtpEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(251, 9);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(74, 20);
            this.dtpEndDate.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "End Date:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartDate.Checked = false;
            this.dtpStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(89, 9);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(74, 20);
            this.dtpStartDate.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Start Date:";
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(205)))));
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(707, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(55, 28);
            this.btnView.TabIndex = 25;
            this.btnView.Text = "View Report";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Filter:";
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "All",
            "To Be Reviewed",
            "Returned To Shelf",
            "Discarded Items"});
            this.cbFilter.Location = new System.Drawing.Point(575, 9);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(116, 21);
            this.cbFilter.TabIndex = 29;
            // 
            // ReturnedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rvReturns);
            this.Controls.Add(this.pnlSubcontrol);
            this.DoubleBuffered = true;
            this.Name = "ReturnedItems";
            this.Size = new System.Drawing.Size(794, 358);
            this.Load += new System.EventHandler(this.ReturnedItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.returnsReportViewModelBindingSource)).EndInit();
            this.pnlSubcontrol.ResumeLayout(false);
            this.pnlSubcontrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReturns;
        private System.Windows.Forms.TableLayoutPanel pnlSubcontrol;
        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.BindingSource returnsReportViewModelBindingSource;
    }
}
