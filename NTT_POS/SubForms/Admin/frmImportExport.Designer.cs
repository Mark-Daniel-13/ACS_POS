namespace NTT_POS.SubForms.Admin
{
    partial class frmImportExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportExport));
            this.tblpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpExport = new System.Windows.Forms.GroupBox();
            this.pnlExport = new System.Windows.Forms.Panel();
            this.btnBrowseExport = new System.Windows.Forms.Button();
            this.tbExportPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTableExport = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.grpImport = new System.Windows.Forms.GroupBox();
            this.pnlImport = new System.Windows.Forms.Panel();
            this.btnBrowseImport = new System.Windows.Forms.Button();
            this.tbImportPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTableImport = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.importFooter = new System.Windows.Forms.Panel();
            this.tbErrors = new System.Windows.Forms.TextBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.tblpnlMain.SuspendLayout();
            this.grpExport.SuspendLayout();
            this.pnlExport.SuspendLayout();
            this.grpImport.SuspendLayout();
            this.pnlImport.SuspendLayout();
            this.importFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnlMain
            // 
            this.tblpnlMain.ColumnCount = 1;
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlMain.Controls.Add(this.grpExport, 0, 1);
            this.tblpnlMain.Controls.Add(this.grpImport, 0, 0);
            this.tblpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tblpnlMain.Name = "tblpnlMain";
            this.tblpnlMain.RowCount = 2;
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblpnlMain.Size = new System.Drawing.Size(1370, 537);
            this.tblpnlMain.TabIndex = 0;
            // 
            // grpExport
            // 
            this.grpExport.Controls.Add(this.pnlExport);
            this.grpExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExport.ForeColor = System.Drawing.Color.White;
            this.grpExport.Location = new System.Drawing.Point(10, 278);
            this.grpExport.Margin = new System.Windows.Forms.Padding(10);
            this.grpExport.Name = "grpExport";
            this.grpExport.Size = new System.Drawing.Size(1350, 249);
            this.grpExport.TabIndex = 1;
            this.grpExport.TabStop = false;
            this.grpExport.Text = "Export Data";
            // 
            // pnlExport
            // 
            this.pnlExport.AutoScroll = true;
            this.pnlExport.Controls.Add(this.btnBrowseExport);
            this.pnlExport.Controls.Add(this.tbExportPath);
            this.pnlExport.Controls.Add(this.label6);
            this.pnlExport.Controls.Add(this.cbTableExport);
            this.pnlExport.Controls.Add(this.label7);
            this.pnlExport.Controls.Add(this.btnExport);
            this.pnlExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlExport.Location = new System.Drawing.Point(3, 21);
            this.pnlExport.Name = "pnlExport";
            this.pnlExport.Size = new System.Drawing.Size(1344, 225);
            this.pnlExport.TabIndex = 6;
            // 
            // btnBrowseExport
            // 
            this.btnBrowseExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnBrowseExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnBrowseExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseExport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseExport.ForeColor = System.Drawing.Color.White;
            this.btnBrowseExport.Image = global::NTT_POS.Properties.Resources.icons8_browse_folder_24;
            this.btnBrowseExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseExport.Location = new System.Drawing.Point(1191, 15);
            this.btnBrowseExport.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowseExport.MaximumSize = new System.Drawing.Size(118, 25);
            this.btnBrowseExport.Name = "btnBrowseExport";
            this.btnBrowseExport.Size = new System.Drawing.Size(118, 25);
            this.btnBrowseExport.TabIndex = 4;
            this.btnBrowseExport.Text = "Browse";
            this.btnBrowseExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseExport.UseVisualStyleBackColor = false;
            this.btnBrowseExport.Click += new System.EventHandler(this.btnBrowseExport_Click);
            // 
            // tbExportPath
            // 
            this.tbExportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExportPath.Location = new System.Drawing.Point(135, 15);
            this.tbExportPath.Margin = new System.Windows.Forms.Padding(0);
            this.tbExportPath.Name = "tbExportPath";
            this.tbExportPath.Size = new System.Drawing.Size(1056, 25);
            this.tbExportPath.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Export Table:";
            // 
            // cbTableExport
            // 
            this.cbTableExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTableExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableExport.FormattingEnabled = true;
            this.cbTableExport.Items.AddRange(new object[] {
            "Products",
            "Customer",
            "Supplier",
            "Categories"});
            this.cbTableExport.Location = new System.Drawing.Point(135, 57);
            this.cbTableExport.Name = "cbTableExport";
            this.cbTableExport.Size = new System.Drawing.Size(1174, 25);
            this.cbTableExport.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Export To:";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = global::NTT_POS.Properties.Resources.icons8_database_export_24;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(1191, 97);
            this.btnExport.MaximumSize = new System.Drawing.Size(118, 31);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(118, 25);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // grpImport
            // 
            this.grpImport.Controls.Add(this.pnlImport);
            this.grpImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpImport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpImport.ForeColor = System.Drawing.Color.White;
            this.grpImport.Location = new System.Drawing.Point(10, 10);
            this.grpImport.Margin = new System.Windows.Forms.Padding(10);
            this.grpImport.Name = "grpImport";
            this.grpImport.Size = new System.Drawing.Size(1350, 248);
            this.grpImport.TabIndex = 0;
            this.grpImport.TabStop = false;
            this.grpImport.Text = "Import Data";
            // 
            // pnlImport
            // 
            this.pnlImport.AutoScroll = true;
            this.pnlImport.Controls.Add(this.btnBrowseImport);
            this.pnlImport.Controls.Add(this.tbImportPath);
            this.pnlImport.Controls.Add(this.label2);
            this.pnlImport.Controls.Add(this.cbTableImport);
            this.pnlImport.Controls.Add(this.label1);
            this.pnlImport.Controls.Add(this.importFooter);
            this.pnlImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImport.Location = new System.Drawing.Point(3, 21);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(1344, 224);
            this.pnlImport.TabIndex = 6;
            // 
            // btnBrowseImport
            // 
            this.btnBrowseImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnBrowseImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnBrowseImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImport.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImport.ForeColor = System.Drawing.Color.White;
            this.btnBrowseImport.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowseImport.Image")));
            this.btnBrowseImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseImport.Location = new System.Drawing.Point(1191, 15);
            this.btnBrowseImport.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowseImport.MaximumSize = new System.Drawing.Size(118, 25);
            this.btnBrowseImport.Name = "btnBrowseImport";
            this.btnBrowseImport.Size = new System.Drawing.Size(118, 25);
            this.btnBrowseImport.TabIndex = 4;
            this.btnBrowseImport.Text = "Browse";
            this.btnBrowseImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseImport.UseVisualStyleBackColor = false;
            this.btnBrowseImport.Click += new System.EventHandler(this.btnBrowseImport_Click);
            // 
            // tbImportPath
            // 
            this.tbImportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImportPath.Location = new System.Drawing.Point(135, 15);
            this.tbImportPath.Margin = new System.Windows.Forms.Padding(0);
            this.tbImportPath.Name = "tbImportPath";
            this.tbImportPath.Size = new System.Drawing.Size(1056, 25);
            this.tbImportPath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Import Table:";
            // 
            // cbTableImport
            // 
            this.cbTableImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTableImport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTableImport.FormattingEnabled = true;
            this.cbTableImport.Items.AddRange(new object[] {
            "Products",
            "Customer",
            "Supplier",
            "Categories"});
            this.cbTableImport.Location = new System.Drawing.Point(135, 57);
            this.cbTableImport.Name = "cbTableImport";
            this.cbTableImport.Size = new System.Drawing.Size(1174, 25);
            this.cbTableImport.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import From:";
            // 
            // importFooter
            // 
            this.importFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importFooter.Controls.Add(this.tbErrors);
            this.importFooter.Controls.Add(this.btnImport);
            this.importFooter.Location = new System.Drawing.Point(135, 101);
            this.importFooter.Name = "importFooter";
            this.importFooter.Size = new System.Drawing.Size(1174, 78);
            this.importFooter.TabIndex = 10;
            // 
            // tbErrors
            // 
            this.tbErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbErrors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbErrors.ForeColor = System.Drawing.Color.Red;
            this.tbErrors.Location = new System.Drawing.Point(0, 1);
            this.tbErrors.MinimumSize = new System.Drawing.Size(190, 2);
            this.tbErrors.Multiline = true;
            this.tbErrors.Name = "tbErrors";
            this.tbErrors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbErrors.Size = new System.Drawing.Size(681, 77);
            this.tbErrors.TabIndex = 9;
            this.tbErrors.Visible = false;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Image = global::NTT_POS.Properties.Resources.icons8_import_file_24;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(1054, 2);
            this.btnImport.MaximumSize = new System.Drawing.Size(118, 31);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(118, 25);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // frmImportExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 537);
            this.Controls.Add(this.tblpnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImportExport";
            this.Text = "frmImportExport";
            this.Load += new System.EventHandler(this.frmImportExport_Load);
            this.tblpnlMain.ResumeLayout(false);
            this.grpExport.ResumeLayout(false);
            this.pnlExport.ResumeLayout(false);
            this.pnlExport.PerformLayout();
            this.grpImport.ResumeLayout(false);
            this.pnlImport.ResumeLayout(false);
            this.pnlImport.PerformLayout();
            this.importFooter.ResumeLayout(false);
            this.importFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnlMain;
        private System.Windows.Forms.GroupBox grpImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbImportPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTableImport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel pnlImport;
        private System.Windows.Forms.TextBox tbErrors;
        public System.Windows.Forms.Button btnBrowseImport;
        private System.Windows.Forms.GroupBox grpExport;
        private System.Windows.Forms.Panel pnlExport;
        public System.Windows.Forms.Button btnBrowseExport;
        private System.Windows.Forms.TextBox tbExportPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTableExport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel importFooter;
    }
}