namespace NTT_POS.SubForms.Main
{
    partial class frmDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiscount));
            this.btnApplyDiscount = new System.Windows.Forms.Button();
            this.btnCancelDiscount = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnApplyDiscount
            // 
            this.btnApplyDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnApplyDiscount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnApplyDiscount.FlatAppearance.BorderSize = 0;
            this.btnApplyDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyDiscount.ForeColor = System.Drawing.Color.White;
            this.btnApplyDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyDiscount.Image")));
            this.btnApplyDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplyDiscount.Location = new System.Drawing.Point(12, 87);
            this.btnApplyDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApplyDiscount.Name = "btnApplyDiscount";
            this.btnApplyDiscount.Size = new System.Drawing.Size(125, 40);
            this.btnApplyDiscount.TabIndex = 0;
            this.btnApplyDiscount.Text = "Apply";
            this.btnApplyDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplyDiscount.UseVisualStyleBackColor = false;
            this.btnApplyDiscount.Click += new System.EventHandler(this.btnApplyDiscount_Click);
            // 
            // btnCancelDiscount
            // 
            this.btnCancelDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancelDiscount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelDiscount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(15)))));
            this.btnCancelDiscount.FlatAppearance.BorderSize = 0;
            this.btnCancelDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDiscount.ForeColor = System.Drawing.Color.White;
            this.btnCancelDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelDiscount.Image")));
            this.btnCancelDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelDiscount.Location = new System.Drawing.Point(163, 87);
            this.btnCancelDiscount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelDiscount.Name = "btnCancelDiscount";
            this.btnCancelDiscount.Size = new System.Drawing.Size(125, 40);
            this.btnCancelDiscount.TabIndex = 1;
            this.btnCancelDiscount.Text = "Cancel";
            this.btnCancelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelDiscount.UseVisualStyleBackColor = false;
            this.btnCancelDiscount.Click += new System.EventHandler(this.btnCancelDiscount_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.BackColor = System.Drawing.Color.Transparent;
            this.lblDiscount.ForeColor = System.Drawing.Color.White;
            this.lblDiscount.Location = new System.Drawing.Point(7, 9);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(106, 21);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Discount Rate";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(12, 44);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(276, 29);
            this.txtDiscount.TabIndex = 1;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // frmDiscount
            // 
            this.AcceptButton = this.btnApplyDiscount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancelDiscount;
            this.ClientSize = new System.Drawing.Size(300, 141);
            this.ControlBox = false;
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnCancelDiscount);
            this.Controls.Add(this.btnApplyDiscount);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDiscount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount";
            this.Load += new System.EventHandler(this.frmDiscount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApplyDiscount;
        private System.Windows.Forms.Button btnCancelDiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
    }
}