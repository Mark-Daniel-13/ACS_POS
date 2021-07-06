namespace NTT_POS.SubForms.Admin
{
    partial class frmDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.tblChart = new System.Windows.Forms.TableLayoutPanel();
            this.pcDays = new LiveCharts.WinForms.PieChart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbweekofDay = new System.Windows.Forms.Label();
            this.dgvSoldDays = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbRefresh = new System.Windows.Forms.Label();
            this.tblChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldDays)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.White;
            this.lblDashboard.Location = new System.Drawing.Point(12, 9);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(154, 30);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Visual Reports";
            // 
            // tblChart
            // 
            this.tblChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblChart.BackColor = System.Drawing.Color.Transparent;
            this.tblChart.ColumnCount = 1;
            this.tblChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChart.Controls.Add(this.pcDays, 0, 1);
            this.tblChart.Controls.Add(this.label1, 0, 0);
            this.tblChart.Location = new System.Drawing.Point(12, 63);
            this.tblChart.Name = "tblChart";
            this.tblChart.RowCount = 2;
            this.tblChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tblChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
            this.tblChart.Size = new System.Drawing.Size(964, 372);
            this.tblChart.TabIndex = 2;
            // 
            // pcDays
            // 
            this.pcDays.BackColor = System.Drawing.Color.Transparent;
            this.pcDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcDays.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcDays.Location = new System.Drawing.Point(0, 22);
            this.pcDays.Margin = new System.Windows.Forms.Padding(0);
            this.pcDays.Name = "pcDays";
            this.pcDays.Size = new System.Drawing.Size(964, 350);
            this.pcDays.TabIndex = 2;
            this.pcDays.Text = "PieChartDays";
            this.pcDays.DataHover += new LiveCharts.Events.DataHoverHandler(this.pcDays_DataHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(65, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(205, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weekly Purchase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 462);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sold Day:";
            // 
            // lbweekofDay
            // 
            this.lbweekofDay.AutoSize = true;
            this.lbweekofDay.BackColor = System.Drawing.Color.Transparent;
            this.lbweekofDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbweekofDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.lbweekofDay.Location = new System.Drawing.Point(179, 462);
            this.lbweekofDay.Margin = new System.Windows.Forms.Padding(0);
            this.lbweekofDay.Name = "lbweekofDay";
            this.lbweekofDay.Size = new System.Drawing.Size(0, 21);
            this.lbweekofDay.TabIndex = 5;
            this.lbweekofDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvSoldDays
            // 
            this.dgvSoldDays.AllowUserToAddRows = false;
            this.dgvSoldDays.AllowUserToDeleteRows = false;
            this.dgvSoldDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSoldDays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoldDays.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoldDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSoldDays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoldDays.ColumnHeadersHeight = 35;
            this.dgvSoldDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSoldDays.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.TotalQuantity,
            this.TotalPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoldDays.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSoldDays.EnableHeadersVisualStyles = false;
            this.dgvSoldDays.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvSoldDays.Location = new System.Drawing.Point(101, 488);
            this.dgvSoldDays.Margin = new System.Windows.Forms.Padding(0);
            this.dgvSoldDays.MultiSelect = false;
            this.dgvSoldDays.Name = "dgvSoldDays";
            this.dgvSoldDays.ReadOnly = true;
            this.dgvSoldDays.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSoldDays.RowHeadersVisible = false;
            this.dgvSoldDays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSoldDays.Size = new System.Drawing.Size(791, 261);
            this.dgvSoldDays.TabIndex = 5;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Product Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 228.8972F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.DataPropertyName = "TotalQuantity";
            this.TotalQuantity.FillWeight = 40.64596F;
            this.TotalQuantity.HeaderText = "Total Quantity";
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.FillWeight = 30.45685F;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // lbRefresh
            // 
            this.lbRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRefresh.AutoSize = true;
            this.lbRefresh.BackColor = System.Drawing.Color.Transparent;
            this.lbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRefresh.ForeColor = System.Drawing.Color.White;
            this.lbRefresh.Location = new System.Drawing.Point(900, 24);
            this.lbRefresh.Name = "lbRefresh";
            this.lbRefresh.Size = new System.Drawing.Size(76, 15);
            this.lbRefresh.TabIndex = 3;
            this.lbRefresh.Text = "Refresh Data";
            this.lbRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbRefresh.Click += new System.EventHandler(this.lbRefresh_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(993, 779);
            this.Controls.Add(this.lbweekofDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRefresh);
            this.Controls.Add(this.dgvSoldDays);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.tblChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.tblChart.ResumeLayout(false);
            this.tblChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoldDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.TableLayoutPanel tblChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSoldDays;
        private System.Windows.Forms.Label lbweekofDay;
        private System.Windows.Forms.Label lbRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        public LiveCharts.WinForms.PieChart pcDays;
    }
}