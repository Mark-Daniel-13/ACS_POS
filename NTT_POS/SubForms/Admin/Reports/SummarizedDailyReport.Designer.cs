namespace NTT_POS.SubForms.Admin.Reports
{
    partial class SummarizedDailyReport
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
            this.btnViewDaily = new System.Windows.Forms.Button();
            this.cbDetailOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDailyEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDailyStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rvSummarized = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlSubcontrol = new System.Windows.Forms.TableLayoutPanel();
            this.SummarizedDailySalesViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlSubcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummarizedDailySalesViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewDaily
            // 
            this.btnViewDaily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewDaily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnViewDaily.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnViewDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDaily.ForeColor = System.Drawing.Color.White;
            this.btnViewDaily.Location = new System.Drawing.Point(621, 6);
            this.btnViewDaily.Name = "btnViewDaily";
            this.btnViewDaily.Size = new System.Drawing.Size(95, 27);
            this.btnViewDaily.TabIndex = 25;
            this.btnViewDaily.Text = "View Report";
            this.btnViewDaily.UseVisualStyleBackColor = false;
            this.btnViewDaily.Click += new System.EventHandler(this.btnViewDaily_Click);
            // 
            // cbDetailOrder
            // 
            this.cbDetailOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbDetailOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDetailOrder.FormattingEnabled = true;
            this.cbDetailOrder.Location = new System.Drawing.Point(510, 9);
            this.cbDetailOrder.Name = "cbDetailOrder";
            this.cbDetailOrder.Size = new System.Drawing.Size(95, 21);
            this.cbDetailOrder.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Order:";
            // 
            // dtpDailyEndDate
            // 
            this.dtpDailyEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDailyEndDate.Checked = false;
            this.dtpDailyEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDailyEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDailyEndDate.Location = new System.Drawing.Point(313, 9);
            this.dtpDailyEndDate.Name = "dtpDailyEndDate";
            this.dtpDailyEndDate.Size = new System.Drawing.Size(95, 20);
            this.dtpDailyEndDate.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(245, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "End Date:";
            // 
            // dtpDailyStartDate
            // 
            this.dtpDailyStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpDailyStartDate.Checked = false;
            this.dtpDailyStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpDailyStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDailyStartDate.Location = new System.Drawing.Point(116, 9);
            this.dtpDailyStartDate.Name = "dtpDailyStartDate";
            this.dtpDailyStartDate.Size = new System.Drawing.Size(95, 20);
            this.dtpDailyStartDate.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Start Date:";
            // 
            // rvSummarized
            // 
            this.rvSummarized.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "SummarizedDailyReport";
            reportDataSource1.Value = this.SummarizedDailySalesViewModelBindingSource;
            this.rvSummarized.LocalReport.DataSources.Add(reportDataSource1);
            this.rvSummarized.LocalReport.ReportEmbeddedResource = "NTT_POS.Reports.SummarizedDailySalesReport.rdlc";
            this.rvSummarized.Location = new System.Drawing.Point(0, 39);
            this.rvSummarized.Name = "rvSummarized";
            this.rvSummarized.ServerReport.BearerToken = null;
            this.rvSummarized.ShowBackButton = false;
            this.rvSummarized.ShowContextMenu = false;
            this.rvSummarized.ShowCredentialPrompts = false;
            this.rvSummarized.ShowDocumentMapButton = false;
            this.rvSummarized.ShowFindControls = false;
            this.rvSummarized.ShowParameterPrompts = false;
            this.rvSummarized.ShowProgress = false;
            this.rvSummarized.ShowPromptAreaButton = false;
            this.rvSummarized.ShowRefreshButton = false;
            this.rvSummarized.ShowStopButton = false;
            this.rvSummarized.Size = new System.Drawing.Size(794, 319);
            this.rvSummarized.TabIndex = 9;
            // 
            // pnlSubcontrol
            // 
            this.pnlSubcontrol.ColumnCount = 12;
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.20336F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.23465F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92902F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.23465F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.92903F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.23465F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.23465F));
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.pnlSubcontrol.Controls.Add(this.btnViewDaily, 10, 0);
            this.pnlSubcontrol.Controls.Add(this.cbDetailOrder, 8, 0);
            this.pnlSubcontrol.Controls.Add(this.label1, 7, 0);
            this.pnlSubcontrol.Controls.Add(this.dtpDailyEndDate, 5, 0);
            this.pnlSubcontrol.Controls.Add(this.label2, 4, 0);
            this.pnlSubcontrol.Controls.Add(this.dtpDailyStartDate, 2, 0);
            this.pnlSubcontrol.Controls.Add(this.label3, 1, 0);
            this.pnlSubcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubcontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlSubcontrol.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubcontrol.Name = "pnlSubcontrol";
            this.pnlSubcontrol.RowCount = 1;
            this.pnlSubcontrol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSubcontrol.Size = new System.Drawing.Size(794, 39);
            this.pnlSubcontrol.TabIndex = 10;
            // 
            // SummarizedDailySalesViewModelBindingSource
            // 
            this.SummarizedDailySalesViewModelBindingSource.DataSource = typeof(NTT_POS.ViewModels.SummarizedDailySalesViewModel);
            // 
            // SummarizedDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rvSummarized);
            this.Controls.Add(this.pnlSubcontrol);
            this.Name = "SummarizedDailyReport";
            this.Size = new System.Drawing.Size(794, 358);
            this.Load += new System.EventHandler(this.SummarizedDailyReport_Load);
            this.pnlSubcontrol.ResumeLayout(false);
            this.pnlSubcontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SummarizedDailySalesViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnViewDaily;
        private System.Windows.Forms.ComboBox cbDetailOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDailyEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDailyStartDate;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer rvSummarized;
        private System.Windows.Forms.TableLayoutPanel pnlSubcontrol;
        private System.Windows.Forms.BindingSource SummarizedDailySalesViewModelBindingSource;
    }
}
