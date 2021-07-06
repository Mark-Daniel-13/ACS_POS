namespace NTT_POS.SubForms.Admin
{
    partial class frmReports
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
            this.DailySalesViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesSummaryViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.pnlNavbarDivider = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSalesReport = new System.Windows.Forms.Panel();
            this.tblpnlDividerSales = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSalesIcon = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnReturns = new System.Windows.Forms.Button();
            this.subpnlSalesReport = new System.Windows.Forms.TableLayoutPanel();
            this.btnEmployeeSales = new System.Windows.Forms.Button();
            this.btnSummarizedDaily = new System.Windows.Forms.Button();
            this.btnSummarize = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.btnProductTraffic = new System.Windows.Forms.Button();
            this.pnlMainReports = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DailySalesViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesSummaryViewModelBindingSource)).BeginInit();
            this.pnlNavbar.SuspendLayout();
            this.pnlNavbarDivider.SuspendLayout();
            this.pnlSalesReport.SuspendLayout();
            this.tblpnlDividerSales.SuspendLayout();
            this.subpnlSalesReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.DarkGray;
            this.pnlNavbar.Controls.Add(this.pnlNavbarDivider);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(850, 30);
            this.pnlNavbar.TabIndex = 1;
            // 
            // pnlNavbarDivider
            // 
            this.pnlNavbarDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.pnlNavbarDivider.ColumnCount = 7;
            this.pnlNavbarDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.pnlNavbarDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlNavbarDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlNavbarDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlNavbarDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlNavbarDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlNavbarDivider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.pnlNavbarDivider.Controls.Add(this.pnlSalesReport, 1, 0);
            this.pnlNavbarDivider.Controls.Add(this.btnVoid, 2, 0);
            this.pnlNavbarDivider.Controls.Add(this.btnReturns, 3, 0);
            this.pnlNavbarDivider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavbarDivider.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbarDivider.Name = "pnlNavbarDivider";
            this.pnlNavbarDivider.RowCount = 1;
            this.pnlNavbarDivider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlNavbarDivider.Size = new System.Drawing.Size(850, 30);
            this.pnlNavbarDivider.TabIndex = 0;
            // 
            // pnlSalesReport
            // 
            this.pnlSalesReport.Controls.Add(this.tblpnlDividerSales);
            this.pnlSalesReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesReport.Location = new System.Drawing.Point(5, 0);
            this.pnlSalesReport.Margin = new System.Windows.Forms.Padding(0);
            this.pnlSalesReport.Name = "pnlSalesReport";
            this.pnlSalesReport.Size = new System.Drawing.Size(167, 30);
            this.pnlSalesReport.TabIndex = 4;
            // 
            // tblpnlDividerSales
            // 
            this.tblpnlDividerSales.ColumnCount = 2;
            this.tblpnlDividerSales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblpnlDividerSales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblpnlDividerSales.Controls.Add(this.pnlSalesIcon, 1, 0);
            this.tblpnlDividerSales.Controls.Add(this.btnSales, 0, 0);
            this.tblpnlDividerSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlDividerSales.Location = new System.Drawing.Point(0, 0);
            this.tblpnlDividerSales.Name = "tblpnlDividerSales";
            this.tblpnlDividerSales.RowCount = 1;
            this.tblpnlDividerSales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlDividerSales.Size = new System.Drawing.Size(167, 30);
            this.tblpnlDividerSales.TabIndex = 0;
            this.tblpnlDividerSales.Click += new System.EventHandler(this.tblpnlDividerSales_Click);
            this.tblpnlDividerSales.MouseEnter += new System.EventHandler(this.tblpnlDividerSales_MouseEnter);
            this.tblpnlDividerSales.MouseLeave += new System.EventHandler(this.tblpnlDividerSales_MouseLeave);
            // 
            // pnlSalesIcon
            // 
            this.pnlSalesIcon.BackgroundImage = global::NTT_POS.Properties.Resources.caret_down__white_;
            this.pnlSalesIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlSalesIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSalesIcon.Location = new System.Drawing.Point(139, 6);
            this.pnlSalesIcon.Margin = new System.Windows.Forms.Padding(6);
            this.pnlSalesIcon.Name = "pnlSalesIcon";
            this.pnlSalesIcon.Size = new System.Drawing.Size(22, 18);
            this.pnlSalesIcon.TabIndex = 0;
            this.pnlSalesIcon.Click += new System.EventHandler(this.pnlSalesIcon_Click);
            this.pnlSalesIcon.MouseEnter += new System.EventHandler(this.pnlSalesIcon_MouseEnter);
            this.pnlSalesIcon.MouseLeave += new System.EventHandler(this.pnlSalesIcon_MouseLeave);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Transparent;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Location = new System.Drawing.Point(0, 0);
            this.btnSales.Margin = new System.Windows.Forms.Padding(0);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(133, 30);
            this.btnSales.TabIndex = 5;
            this.btnSales.Text = "Sales Reports";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.SizeChanged += new System.EventHandler(this.btnSales_SizeChanged);
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            this.btnSales.MouseEnter += new System.EventHandler(this.btnSales_MouseEnter);
            this.btnSales.MouseLeave += new System.EventHandler(this.btnSales_MouseLeave);
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.Transparent;
            this.btnVoid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVoid.FlatAppearance.BorderSize = 0;
            this.btnVoid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVoid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoid.ForeColor = System.Drawing.Color.White;
            this.btnVoid.Location = new System.Drawing.Point(172, 0);
            this.btnVoid.Margin = new System.Windows.Forms.Padding(0);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(167, 30);
            this.btnVoid.TabIndex = 6;
            this.btnVoid.Text = "Voided Transaction";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            this.btnVoid.MouseEnter += new System.EventHandler(this.btnVoid_MouseEnter);
            this.btnVoid.MouseLeave += new System.EventHandler(this.btnVoid_MouseLeave);
            // 
            // btnReturns
            // 
            this.btnReturns.BackColor = System.Drawing.Color.Transparent;
            this.btnReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturns.FlatAppearance.BorderSize = 0;
            this.btnReturns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReturns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReturns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturns.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturns.ForeColor = System.Drawing.Color.White;
            this.btnReturns.Location = new System.Drawing.Point(339, 0);
            this.btnReturns.Margin = new System.Windows.Forms.Padding(0);
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new System.Drawing.Size(167, 30);
            this.btnReturns.TabIndex = 7;
            this.btnReturns.Text = "Returned Item";
            this.btnReturns.UseVisualStyleBackColor = false;
            this.btnReturns.Click += new System.EventHandler(this.btnReturns_Click);
            this.btnReturns.MouseEnter += new System.EventHandler(this.btnReturns_MouseEnter);
            this.btnReturns.MouseLeave += new System.EventHandler(this.btnReturns_MouseLeave);
            // 
            // subpnlSalesReport
            // 
            this.subpnlSalesReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subpnlSalesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(157)))), ((int)(((byte)(224)))));
            this.subpnlSalesReport.ColumnCount = 1;
            this.subpnlSalesReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.subpnlSalesReport.Controls.Add(this.btnEmployeeSales, 0, 4);
            this.subpnlSalesReport.Controls.Add(this.btnSummarizedDaily, 0, 3);
            this.subpnlSalesReport.Controls.Add(this.btnSummarize, 0, 2);
            this.subpnlSalesReport.Controls.Add(this.btnDailySales, 0, 1);
            this.subpnlSalesReport.Controls.Add(this.btnProductTraffic, 0, 0);
            this.subpnlSalesReport.Location = new System.Drawing.Point(7, 31);
            this.subpnlSalesReport.Name = "subpnlSalesReport";
            this.subpnlSalesReport.RowCount = 5;
            this.subpnlSalesReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.subpnlSalesReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.subpnlSalesReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.subpnlSalesReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.subpnlSalesReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.subpnlSalesReport.Size = new System.Drawing.Size(166, 161);
            this.subpnlSalesReport.TabIndex = 4;
            this.subpnlSalesReport.Visible = false;
            // 
            // btnEmployeeSales
            // 
            this.btnEmployeeSales.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeeSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmployeeSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEmployeeSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEmployeeSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeSales.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeSales.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeSales.Location = new System.Drawing.Point(0, 128);
            this.btnEmployeeSales.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployeeSales.Name = "btnEmployeeSales";
            this.btnEmployeeSales.Size = new System.Drawing.Size(166, 33);
            this.btnEmployeeSales.TabIndex = 10;
            this.btnEmployeeSales.Text = "Employee Sales";
            this.btnEmployeeSales.UseVisualStyleBackColor = false;
            this.btnEmployeeSales.Click += new System.EventHandler(this.btnEmployeeSales_Click);
            this.btnEmployeeSales.MouseEnter += new System.EventHandler(this.btnEmployeeSales_MouseEnter);
            this.btnEmployeeSales.MouseLeave += new System.EventHandler(this.btnEmployeeSales_MouseLeave);
            // 
            // btnSummarizedDaily
            // 
            this.btnSummarizedDaily.BackColor = System.Drawing.Color.Transparent;
            this.btnSummarizedDaily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSummarizedDaily.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSummarizedDaily.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSummarizedDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummarizedDaily.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummarizedDaily.ForeColor = System.Drawing.Color.White;
            this.btnSummarizedDaily.Location = new System.Drawing.Point(0, 96);
            this.btnSummarizedDaily.Margin = new System.Windows.Forms.Padding(0);
            this.btnSummarizedDaily.Name = "btnSummarizedDaily";
            this.btnSummarizedDaily.Size = new System.Drawing.Size(166, 32);
            this.btnSummarizedDaily.TabIndex = 9;
            this.btnSummarizedDaily.Text = "Summarized Daily Sales";
            this.btnSummarizedDaily.UseVisualStyleBackColor = false;
            this.btnSummarizedDaily.Click += new System.EventHandler(this.btnSummarizedDaily_Click);
            this.btnSummarizedDaily.MouseEnter += new System.EventHandler(this.btnSummarizedDaily_MouseEnter);
            this.btnSummarizedDaily.MouseLeave += new System.EventHandler(this.btnSummarizedDaily_MouseLeave);
            // 
            // btnSummarize
            // 
            this.btnSummarize.BackColor = System.Drawing.Color.Transparent;
            this.btnSummarize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSummarize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSummarize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSummarize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummarize.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSummarize.ForeColor = System.Drawing.Color.White;
            this.btnSummarize.Location = new System.Drawing.Point(0, 64);
            this.btnSummarize.Margin = new System.Windows.Forms.Padding(0);
            this.btnSummarize.Name = "btnSummarize";
            this.btnSummarize.Size = new System.Drawing.Size(166, 32);
            this.btnSummarize.TabIndex = 8;
            this.btnSummarize.Text = "Employee Logs";
            this.btnSummarize.UseVisualStyleBackColor = false;
            this.btnSummarize.Click += new System.EventHandler(this.btnSummarize_Click);
            this.btnSummarize.MouseEnter += new System.EventHandler(this.btnSummarize_MouseEnter);
            this.btnSummarize.MouseLeave += new System.EventHandler(this.btnSummarize_MouseLeave);
            // 
            // btnDailySales
            // 
            this.btnDailySales.BackColor = System.Drawing.Color.Transparent;
            this.btnDailySales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDailySales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnDailySales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailySales.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailySales.ForeColor = System.Drawing.Color.White;
            this.btnDailySales.Location = new System.Drawing.Point(0, 32);
            this.btnDailySales.Margin = new System.Windows.Forms.Padding(0);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Size = new System.Drawing.Size(166, 32);
            this.btnDailySales.TabIndex = 7;
            this.btnDailySales.Text = "Daily Sales";
            this.btnDailySales.UseVisualStyleBackColor = false;
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            this.btnDailySales.MouseEnter += new System.EventHandler(this.btnDailySales_MouseEnter);
            this.btnDailySales.MouseLeave += new System.EventHandler(this.btnDailySales_MouseLeave);
            // 
            // btnProductTraffic
            // 
            this.btnProductTraffic.BackColor = System.Drawing.Color.Transparent;
            this.btnProductTraffic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductTraffic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnProductTraffic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnProductTraffic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductTraffic.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductTraffic.ForeColor = System.Drawing.Color.White;
            this.btnProductTraffic.Location = new System.Drawing.Point(0, 0);
            this.btnProductTraffic.Margin = new System.Windows.Forms.Padding(0);
            this.btnProductTraffic.Name = "btnProductTraffic";
            this.btnProductTraffic.Size = new System.Drawing.Size(166, 32);
            this.btnProductTraffic.TabIndex = 6;
            this.btnProductTraffic.Text = "Product Traffic";
            this.btnProductTraffic.UseVisualStyleBackColor = false;
            this.btnProductTraffic.Click += new System.EventHandler(this.btnProductTraffic_Click);
            this.btnProductTraffic.MouseEnter += new System.EventHandler(this.btnProductTraffic_MouseEnter);
            this.btnProductTraffic.MouseLeave += new System.EventHandler(this.btnProductTraffic_MouseLeave);
            // 
            // pnlMainReports
            // 
            this.pnlMainReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainReports.Location = new System.Drawing.Point(0, 30);
            this.pnlMainReports.Name = "pnlMainReports";
            this.pnlMainReports.Size = new System.Drawing.Size(850, 570);
            this.pnlMainReports.TabIndex = 5;
            this.pnlMainReports.Enter += new System.EventHandler(this.pnlMainReports_Enter);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
           // this.BackgroundImage = global::NTT_POS.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.subpnlSalesReport);
            this.Controls.Add(this.pnlMainReports);
            this.Controls.Add(this.pnlNavbar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "W";
            this.Load += new System.EventHandler(this.frmReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailySalesViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesSummaryViewModelBindingSource)).EndInit();
            this.pnlNavbar.ResumeLayout(false);
            this.pnlNavbarDivider.ResumeLayout(false);
            this.pnlSalesReport.ResumeLayout(false);
            this.tblpnlDividerSales.ResumeLayout(false);
            this.subpnlSalesReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource SalesSummaryViewModelBindingSource;
        private System.Windows.Forms.BindingSource DailySalesViewModelBindingSource;
        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.TableLayoutPanel pnlNavbarDivider;
        private System.Windows.Forms.Panel pnlSalesReport;
        private System.Windows.Forms.TableLayoutPanel subpnlSalesReport;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnProductTraffic;
        private System.Windows.Forms.Button btnDailySales;
        private System.Windows.Forms.Button btnSummarize;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Panel pnlMainReports;
        private System.Windows.Forms.Button btnSummarizedDaily;
        private System.Windows.Forms.Button btnEmployeeSales;
        private System.Windows.Forms.TableLayoutPanel tblpnlDividerSales;
        private System.Windows.Forms.Panel pnlSalesIcon;
        private System.Windows.Forms.Button btnReturns;
    }
}