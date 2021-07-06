namespace NTT_POS.SubForms.Main
{
    partial class frmEditQuantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditQuantity));
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnCancelInquiry = new System.Windows.Forms.Button();
            this.btnEditQuantity = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(12, 28);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(70, 21);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Quantity";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancelInquiry
            // 
            this.btnCancelInquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancelInquiry.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelInquiry.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(15)))));
            this.btnCancelInquiry.FlatAppearance.BorderSize = 0;
            this.btnCancelInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelInquiry.ForeColor = System.Drawing.Color.White;
            this.btnCancelInquiry.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelInquiry.Image")));
            this.btnCancelInquiry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelInquiry.Location = new System.Drawing.Point(219, 87);
            this.btnCancelInquiry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelInquiry.Name = "btnCancelInquiry";
            this.btnCancelInquiry.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancelInquiry.Size = new System.Drawing.Size(166, 40);
            this.btnCancelInquiry.TabIndex = 2;
            this.btnCancelInquiry.Text = "Cancel";
            this.btnCancelInquiry.UseVisualStyleBackColor = false;
            this.btnCancelInquiry.Click += new System.EventHandler(this.btnCancelInquiry_Click);
            // 
            // btnEditQuantity
            // 
            this.btnEditQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnEditQuantity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnEditQuantity.FlatAppearance.BorderSize = 0;
            this.btnEditQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditQuantity.ForeColor = System.Drawing.Color.White;
            this.btnEditQuantity.Image = ((System.Drawing.Image)(resources.GetObject("btnEditQuantity.Image")));
            this.btnEditQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditQuantity.Location = new System.Drawing.Point(16, 87);
            this.btnEditQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditQuantity.Size = new System.Drawing.Size(166, 40);
            this.btnEditQuantity.TabIndex = 1;
            this.btnEditQuantity.Text = "Submit";
            this.btnEditQuantity.UseVisualStyleBackColor = false;
            this.btnEditQuantity.Click += new System.EventHandler(this.btnEditQuantity_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(109, 25);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(276, 29);
            this.tbQuantity.TabIndex = 0;
            this.tbQuantity.Text = "1.00";
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            // 
            // frmEditQuantity
            // 
            this.AcceptButton = this.btnEditQuantity;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancelInquiry;
            this.ClientSize = new System.Drawing.Size(397, 149);
            this.ControlBox = false;
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.btnCancelInquiry);
            this.Controls.Add(this.btnEditQuantity);
            this.Controls.Add(this.lblPrice);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditQuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Quantity";
            this.Load += new System.EventHandler(this.frmEditQuantity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnCancelInquiry;
        private System.Windows.Forms.Button btnEditQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
    }
}