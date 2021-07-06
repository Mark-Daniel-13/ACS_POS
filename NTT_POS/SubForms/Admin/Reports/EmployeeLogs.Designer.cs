namespace NTT_POS.SubForms.Admin.Reports
{
    partial class EmployeeLogs
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
            this.employeeLogsViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSummarizedDaily = new System.Windows.Forms.ComboBox();
            this.btnViewSummarizedSales = new System.Windows.Forms.Button();
            this.dtpEndSummarizedSales = new System.Windows.Forms.DateTimePicker();
            this.dtpStartSummarizedSales = new System.Windows.Forms.DateTimePicker();
            this.rvSummarizeDailySales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlSubcontrol = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeLogsViewModelBindingSource)).BeginInit();
            this.pnlSubcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSummarizedDaily
            // 
            this.cbSummarizedDaily.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbSummarizedDaily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSummarizedDaily.FormattingEnabled = true;
            this.cbSummarizedDaily.Location = new System.Drawing.Point(566, 9);
            this.cbSummarizedDaily.Name = "cbSummarizedDaily";
            this.cbSummarizedDaily.Size = new System.Drawing.Size(108, 21);
            this.cbSummarizedDaily.TabIndex = 27;
            // 
            // btnViewSummarizedSales
            // 
            this.btnViewSummarizedSales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewSummarizedSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnViewSummarizedSales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnViewSummarizedSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSummarizedSales.ForeColor = System.Drawing.Color.White;
            this.btnViewSummarizedSales.Location = new System.Drawing.Point(690, 5);
            this.btnViewSummarizedSales.Name = "btnViewSummarizedSales";
            this.btnViewSummarizedSales.Size = new System.Drawing.Size(108, 28);
            this.btnViewSummarizedSales.TabIndex = 25;
            this.btnViewSummarizedSales.Text = "View Report";
            this.btnViewSummarizedSales.UseVisualStyleBackColor = false;
            this.btnViewSummarizedSales.Click += new System.EventHandler(this.btnViewSummarizedSales_Click);
            // 
            // dtpEndSummarizedSales
            // 
            this.dtpEndSummarizedSales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpEndSummarizedSales.Checked = false;
            this.dtpEndSummarizedSales.CustomFormat = "MM/dd/yyyy";
            this.dtpEndSummarizedSales.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndSummarizedSales.Location = new System.Drawing.Point(346, 9);
            this.dtpEndSummarizedSales.Name = "dtpEndSummarizedSales";
            this.dtpEndSummarizedSales.Size = new System.Drawing.Size(108, 20);
            this.dtpEndSummarizedSales.TabIndex = 23;
            // 
            // dtpStartSummarizedSales
            // 
            this.dtpStartSummarizedSales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpStartSummarizedSales.Checked = false;
            this.dtpStartSummarizedSales.CustomFormat = "MM/dd/yyyy";
            this.dtpStartSummarizedSales.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartSummarizedSales.Location = new System.Drawing.Point(126, 9);
            this.dtpStartSummarizedSales.Name = "dtpStartSummarizedSales";
            this.dtpStartSummarizedSales.Size = new System.Drawing.Size(108, 20);
            this.dtpStartSummarizedSales.TabIndex = 21;
            // 
            // rvSummarizeDailySales
            // 
            this.rvSummarizeDailySales.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportTable";
            reportDataSource1.Value = this.employeeLogsViewModelBindingSource;
            this.rvSummarizeDailySales.LocalReport.DataSources.Add(reportDataSource1);
            this.rvSummarizeDailySales.LocalReport.ReportEmbeddedResource = "NTT_POS.Reports.EmployeeLogsReport.rdlc";
            this.rvSummarizeDailySales.Location = new System.Drawing.Point(0, 39);
            this.rvSummarizeDailySales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rvSummarizeDailySales.Name = "rvSummarizeDailySales";
            this.rvSummarizeDailySales.ServerReport.BearerToken = null;
            this.rvSummarizeDailySales.ShowBackButton = false;
            this.rvSummarizeDailySales.ShowContextMenu = false;
            this.rvSummarizeDailySales.ShowCredentialPrompts = false;
            this.rvSummarizeDailySales.ShowDocumentMapButton = false;
            this.rvSummarizeDailySales.ShowFindControls = false;
            this.rvSummarizeDailySales.ShowParameterPrompts = false;
            this.rvSummarizeDailySales.ShowProgress = false;
            this.rvSummarizeDailySales.ShowPromptAreaButton = false;
            this.rvSummarizeDailySales.ShowRefreshButton = false;
            this.rvSummarizeDailySales.ShowStopButton = false;
            this.rvSummarizeDailySales.Size = new System.Drawing.Size(848, 272);
            this.rvSummarizeDailySales.TabIndex = 10;
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
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.pnlSubcontrol.Controls.Add(this.cbSummarizedDaily, 8, 0);
            this.pnlSubcontrol.Controls.Add(this.btnViewSummarizedSales, 10, 0);
            this.pnlSubcontrol.Controls.Add(this.label1, 7, 0);
            this.pnlSubcontrol.Controls.Add(this.dtpEndSummarizedSales, 5, 0);
            this.pnlSubcontrol.Controls.Add(this.label2, 4, 0);
            this.pnlSubcontrol.Controls.Add(this.dtpStartSummarizedSales, 2, 0);
            this.pnlSubcontrol.Controls.Add(this.label3, 1, 0);
            this.pnlSubcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubcontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlSubcontrol.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubcontrol.Name = "pnlSubcontrol";
            this.pnlSubcontrol.RowCount = 1;
            this.pnlSubcontrol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSubcontrol.Size = new System.Drawing.Size(848, 39);
            this.pnlSubcontrol.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(517, 13);
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
            this.label2.Location = new System.Drawing.Point(278, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Start Date:";
            // 
            // EmployeeLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rvSummarizeDailySales);
            this.Controls.Add(this.pnlSubcontrol);
            this.DoubleBuffered = true;
            this.Name = "EmployeeLogs";
            this.Size = new System.Drawing.Size(848, 311);
            this.Load += new System.EventHandler(this.SummarizeDailySales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeLogsViewModelBindingSource)).EndInit();
            this.pnlSubcontrol.ResumeLayout(false);
            this.pnlSubcontrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbSummarizedDaily;
        private System.Windows.Forms.Button btnViewSummarizedSales;
        private System.Windows.Forms.DateTimePicker dtpEndSummarizedSales;
        private System.Windows.Forms.DateTimePicker dtpStartSummarizedSales;
        private Microsoft.Reporting.WinForms.ReportViewer rvSummarizeDailySales;
        private System.Windows.Forms.TableLayoutPanel pnlSubcontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource employeeLogsViewModelBindingSource;
    }
}
