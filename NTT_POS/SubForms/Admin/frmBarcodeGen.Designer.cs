
namespace NTT_POS.SubForms.Admin
{
    partial class frmBarcodeGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBarcodeGen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbBarcode = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbBarcode = new System.Windows.Forms.MaskedTextBox();
            this.btnGetLatest = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barcode:";
            // 
            // pbBarcode
            // 
            this.pbBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBarcode.BackColor = System.Drawing.Color.Transparent;
            this.pbBarcode.Location = new System.Drawing.Point(75, 91);
            this.pbBarcode.MinimumSize = new System.Drawing.Size(331, 213);
            this.pbBarcode.Name = "pbBarcode";
            this.pbBarcode.Size = new System.Drawing.Size(437, 213);
            this.pbBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBarcode.TabIndex = 4;
            this.pbBarcode.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.tbBarcode);
            this.pnlMain.Controls.Add(this.btnGetLatest);
            this.pnlMain.Controls.Add(this.btnDownload);
            this.pnlMain.Controls.Add(this.btnGenerate);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.pbBarcode);
            this.pnlMain.Location = new System.Drawing.Point(14, 44);
            this.pnlMain.MinimumSize = new System.Drawing.Size(800, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlMain.Size = new System.Drawing.Size(802, 463);
            this.pnlMain.TabIndex = 5;
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(75, 38);
            this.tbBarcode.Mask = "IT00000000000";
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(449, 26);
            this.tbBarcode.TabIndex = 8;
            // 
            // btnGetLatest
            // 
            this.btnGetLatest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetLatest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnGetLatest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(107)))), ((int)(((byte)(108)))));
            this.btnGetLatest.FlatAppearance.BorderSize = 0;
            this.btnGetLatest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetLatest.ForeColor = System.Drawing.Color.White;
            this.btnGetLatest.Image = ((System.Drawing.Image)(resources.GetObject("btnGetLatest.Image")));
            this.btnGetLatest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetLatest.Location = new System.Drawing.Point(548, 91);
            this.btnGetLatest.Name = "btnGetLatest";
            this.btnGetLatest.Padding = new System.Windows.Forms.Padding(1, 0, 40, 0);
            this.btnGetLatest.Size = new System.Drawing.Size(233, 49);
            this.btnGetLatest.TabIndex = 7;
            this.btnGetLatest.Text = "Get Latest Barcode";
            this.btnGetLatest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetLatest.UseVisualStyleBackColor = false;
            this.btnGetLatest.Click += new System.EventHandler(this.btnGetLatest_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownload.Location = new System.Drawing.Point(548, 146);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDownload.Size = new System.Drawing.Size(233, 49);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(120)))), ((int)(((byte)(48)))));
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerate.Image")));
            this.btnGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.Location = new System.Drawing.Point(548, 36);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGenerate.Size = new System.Drawing.Size(233, 49);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // frmBarcodeGen
            // 
            this.AcceptButton = this.btnGenerate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBarcodeGen";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBarcodeGen";
            this.Load += new System.EventHandler(this.frmBarcodeGen_Load);
            this.Resize += new System.EventHandler(this.FrmBarcodeGen_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarcode)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbBarcode;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnGetLatest;
        private System.Windows.Forms.MaskedTextBox tbBarcode;
    }
}