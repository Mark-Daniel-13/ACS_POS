namespace NTT_POS.SubForms.Admin.Reports
{
    partial class VoidedTransaction
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
            this.DailySalesViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbVoidedOrder = new System.Windows.Forms.ComboBox();
            this.btnViewVoided = new System.Windows.Forms.Button();
            this.dtpVoidedEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpVoidedStartDate = new System.Windows.Forms.DateTimePicker();
            this.rvVoided = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlSubcontrol = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DailySalesViewModelBindingSource)).BeginInit();
            this.pnlSubcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // DailySalesViewModelBindingSource
            // 
            this.DailySalesViewModelBindingSource.DataSource = typeof(NTT_POS.ViewModels.DailySalesViewModel);
            // 
            // cbVoidedOrder
            // 
            this.cbVoidedOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbVoidedOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoidedOrder.FormattingEnabled = true;
            this.cbVoidedOrder.Location = new System.Drawing.Point(564, 9);
            this.cbVoidedOrder.Name = "cbVoidedOrder";
            this.cbVoidedOrder.Size = new System.Drawing.Size(107, 21);
            this.cbVoidedOrder.TabIndex = 27;
            // 
            // btnViewVoided
            // 
            this.btnViewVoided.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewVoided.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnViewVoided.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnViewVoided.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewVoided.ForeColor = System.Drawing.Color.White;
            this.btnViewVoided.Location = new System.Drawing.Point(687, 6);
            this.btnViewVoided.Name = "btnViewVoided";
            this.btnViewVoided.Size = new System.Drawing.Size(107, 27);
            this.btnViewVoided.TabIndex = 25;
            this.btnViewVoided.Text = "View Report";
            this.btnViewVoided.UseVisualStyleBackColor = false;
            this.btnViewVoided.Click += new System.EventHandler(this.btnViewVoided_Click);
            // 
            // dtpVoidedEndDate
            // 
            this.dtpVoidedEndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpVoidedEndDate.Checked = false;
            this.dtpVoidedEndDate.CustomFormat = "MM/dd/yyyy";
            this.dtpVoidedEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoidedEndDate.Location = new System.Drawing.Point(345, 9);
            this.dtpVoidedEndDate.Name = "dtpVoidedEndDate";
            this.dtpVoidedEndDate.Size = new System.Drawing.Size(107, 20);
            this.dtpVoidedEndDate.TabIndex = 23;
            // 
            // dtpVoidedStartDate
            // 
            this.dtpVoidedStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpVoidedStartDate.Checked = false;
            this.dtpVoidedStartDate.CustomFormat = "MM/dd/yyyy";
            this.dtpVoidedStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVoidedStartDate.Location = new System.Drawing.Point(126, 9);
            this.dtpVoidedStartDate.Name = "dtpVoidedStartDate";
            this.dtpVoidedStartDate.Size = new System.Drawing.Size(107, 20);
            this.dtpVoidedStartDate.TabIndex = 21;
            // 
            // rvVoided
            // 
            this.rvVoided.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DailySales_DataSet";
            reportDataSource1.Value = this.DailySalesViewModelBindingSource;
            this.rvVoided.LocalReport.DataSources.Add(reportDataSource1);
            this.rvVoided.LocalReport.ReportEmbeddedResource = "NTT_POS.Reports.VoidedTransactionsReport.rdlc";
            this.rvVoided.Location = new System.Drawing.Point(0, 39);
            this.rvVoided.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rvVoided.Name = "rvVoided";
            this.rvVoided.ServerReport.BearerToken = null;
            this.rvVoided.ShowBackButton = false;
            this.rvVoided.ShowContextMenu = false;
            this.rvVoided.ShowCredentialPrompts = false;
            this.rvVoided.ShowDocumentMapButton = false;
            this.rvVoided.ShowFindControls = false;
            this.rvVoided.ShowParameterPrompts = false;
            this.rvVoided.ShowProgress = false;
            this.rvVoided.ShowPromptAreaButton = false;
            this.rvVoided.ShowRefreshButton = false;
            this.rvVoided.ShowStopButton = false;
            this.rvVoided.Size = new System.Drawing.Size(850, 531);
            this.rvVoided.TabIndex = 9;
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
            this.pnlSubcontrol.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.pnlSubcontrol.Controls.Add(this.cbVoidedOrder, 8, 0);
            this.pnlSubcontrol.Controls.Add(this.btnViewVoided, 10, 0);
            this.pnlSubcontrol.Controls.Add(this.label1, 7, 0);
            this.pnlSubcontrol.Controls.Add(this.dtpVoidedEndDate, 5, 0);
            this.pnlSubcontrol.Controls.Add(this.label2, 4, 0);
            this.pnlSubcontrol.Controls.Add(this.dtpVoidedStartDate, 2, 0);
            this.pnlSubcontrol.Controls.Add(this.label3, 1, 0);
            this.pnlSubcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubcontrol.Location = new System.Drawing.Point(0, 0);
            this.pnlSubcontrol.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSubcontrol.Name = "pnlSubcontrol";
            this.pnlSubcontrol.RowCount = 1;
            this.pnlSubcontrol.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSubcontrol.Size = new System.Drawing.Size(850, 39);
            this.pnlSubcontrol.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(515, 13);
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
            this.label2.Location = new System.Drawing.Point(277, 13);
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
            // VoidedTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rvVoided);
            this.Controls.Add(this.pnlSubcontrol);
            this.DoubleBuffered = true;
            this.Name = "VoidedTransaction";
            this.Size = new System.Drawing.Size(850, 570);
            this.Load += new System.EventHandler(this.VoidedTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailySalesViewModelBindingSource)).EndInit();
            this.pnlSubcontrol.ResumeLayout(false);
            this.pnlSubcontrol.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbVoidedOrder;
        private System.Windows.Forms.Button btnViewVoided;
        private System.Windows.Forms.DateTimePicker dtpVoidedEndDate;
        private System.Windows.Forms.DateTimePicker dtpVoidedStartDate;
        private Microsoft.Reporting.WinForms.ReportViewer rvVoided;
        private System.Windows.Forms.BindingSource DailySalesViewModelBindingSource;
        private System.Windows.Forms.TableLayoutPanel pnlSubcontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
