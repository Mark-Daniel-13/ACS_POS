namespace NTT_POS.SubForms.Admin.Reports
{
    partial class ProductTraffic
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
            this.SalesSummaryViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSummaryOrder = new System.Windows.Forms.ComboBox();
            this.btnViewSummary = new System.Windows.Forms.Button();
            this.dtpSummaryEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSummaryStartDate = new System.Windows.Forms.DateTimePicker();
            this.rvSummary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlSubcontrol = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SalesSummaryViewModelBindingSource)).BeginInit();
            this.pnlSubcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSummaryOrder
            // 
            this.cbSummaryOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSummaryOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSummaryOrder.FormattingEnabled = true;
            this.cbSummaryOrder.Location = new System.Drawing.Point(405, 9);
            this.cbSummaryOrder.Name = "cbSummaryOrder";
            this.cbSummaryOrder.Size = new System.Drawing.Size(78, 21);
            this.cbSummaryOrder.TabIndex = 27;
            // 
            // btnViewSummary
            // 
            this.btnViewSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnViewSummary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnViewSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSummary.ForeColor = System.Drawing.Color.White;
            this.btnViewSummary.Location = new System.Drawing.Point(658, 5);
            this.btnViewSummary.Name = "btnViewSummary";
            this.btnViewSummary.Size = new System.Drawing.Size(54, 28);
            this.btnViewSummary.TabIndex = 25;
            this.btnViewSummary.Text = "View Report";
            this.btnViewSummary.UseVisualStyleBackColor = false;
            this.btnViewSummary.Click += new System.EventHandler(this.btnViewSummary_Click);
            // 
            // dtpSummaryEndDate
            // 
            this.dtpSummaryEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSummaryEndDate.Checked = false;
            this.dtpSummaryEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpSummaryEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSummaryEndDate.Location = new System.Drawing.Point(248, 9);
            this.dtpSummaryEndDate.Name = "dtpSummaryEndDate";
            this.dtpSummaryEndDate.Size = new System.Drawing.Size(78, 20);
            this.dtpSummaryEndDate.TabIndex = 23;
            // 
            // dtpSummaryStartDate
            // 
            this.dtpSummaryStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSummaryStartDate.Checked = false;
            this.dtpSummaryStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpSummaryStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSummaryStartDate.Location = new System.Drawing.Point(91, 9);
            this.dtpSummaryStartDate.Name = "dtpSummaryStartDate";
            this.dtpSummaryStartDate.Size = new System.Drawing.Size(78, 20);
            this.dtpSummaryStartDate.TabIndex = 21;
            // 
            // rvSummary
            // 
            this.rvSummary.AutoSize = true;
            this.rvSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvSummary.KeepSessionAlive = false;
            reportDataSource1.Name = "SalesSummary_DataSet";
            reportDataSource1.Value = this.SalesSummaryViewModelBindingSource;
            this.rvSummary.LocalReport.DataSources.Add(reportDataSource1);
            this.rvSummary.LocalReport.ReportEmbeddedResource = "NTT_POS.Reports.SalesSummaryReport.rdlc";
            this.rvSummary.Location = new System.Drawing.Point(0, 39);
            this.rvSummary.Name = "rvSummary";
            this.rvSummary.ServerReport.BearerToken = null;
            this.rvSummary.ShowBackButton = false;
            this.rvSummary.ShowContextMenu = false;
            this.rvSummary.ShowCredentialPrompts = false;
            this.rvSummary.ShowDocumentMapButton = false;
            this.rvSummary.ShowFindControls = false;
            this.rvSummary.ShowParameterPrompts = false;
            this.rvSummary.ShowProgress = false;
            this.rvSummary.ShowPromptAreaButton = false;
            this.rvSummary.ShowRefreshButton = false;
            this.rvSummary.ShowStopButton = false;
            this.rvSummary.Size = new System.Drawing.Size(794, 346);
            this.rvSummary.TabIndex = 5;
            // 
            // pnlSubcontrol
            // 
            this.pnlSubcontrol.ColumnCount = 15;
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.024665F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.10275F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.837145F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.10275F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.837152F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.10275F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.837816F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.10275F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.851852F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.644819F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.pnlSubcontrol.Controls.Add(this.cbSummaryOrder, 8, 0);
            this.pnlSubcontrol.Controls.Add(this.label1, 7, 0);
            this.pnlSubcontrol.Controls.Add(this.dtpSummaryEndDate, 5, 0);
            this.pnlSubcontrol.Controls.Add(this.label2, 4, 0);
            this.pnlSubcontrol.Controls.Add(this.dtpSummaryStartDate, 2, 0);
            this.pnlSubcontrol.Controls.Add(this.label3, 1, 0);
            this.pnlSubcontrol.Controls.Add(this.btnViewSummary, 13, 0);
            this.pnlSubcontrol.Controls.Add(this.label4, 10, 0);
            this.pnlSubcontrol.Controls.Add(this.cbFilter, 11, 0);
            this.pnlSubcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubcontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlSubcontrol.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubcontrol.Name = "pnlSubcontrol";
            this.pnlSubcontrol.RowCount = 1;
            this.pnlSubcontrol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSubcontrol.Size = new System.Drawing.Size(794, 39);
            this.pnlSubcontrol.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Order:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(202, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 26);
            this.label2.TabIndex = 24;
            this.label2.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "Start Date:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(517, 13);
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
            "Moving",
            "Non-Moving"});
            this.cbFilter.Location = new System.Drawing.Point(562, 9);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(78, 21);
            this.cbFilter.TabIndex = 29;
            // 
            // ProductTraffic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rvSummary);
            this.Controls.Add(this.pnlSubcontrol);
            this.DoubleBuffered = true;
            this.Name = "ProductTraffic";
            this.Size = new System.Drawing.Size(794, 385);
            this.Load += new System.EventHandler(this.ProductTraffic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesSummaryViewModelBindingSource)).EndInit();
            this.pnlSubcontrol.ResumeLayout(false);
            this.pnlSubcontrol.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbSummaryOrder;
        private System.Windows.Forms.Button btnViewSummary;
        private System.Windows.Forms.DateTimePicker dtpSummaryEndDate;
        private System.Windows.Forms.DateTimePicker dtpSummaryStartDate;
        private Microsoft.Reporting.WinForms.ReportViewer rvSummary;
        private System.Windows.Forms.BindingSource SalesSummaryViewModelBindingSource;
        private System.Windows.Forms.TableLayoutPanel pnlSubcontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFilter;
    }
}
