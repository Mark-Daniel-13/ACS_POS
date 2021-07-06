namespace NTT_POS.SubForms.Main
{
    partial class frmReturnDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturnDetails));
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductNameValue = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantityValue = new System.Windows.Forms.TextBox();
            this.lblReturnedAmount = new System.Windows.Forms.Label();
            this.lblReturnedAmountValue = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(12, 12);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(113, 21);
            this.lblProductName.TabIndex = 7;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductNameValue
            // 
            this.lblProductNameValue.AutoSize = true;
            this.lblProductNameValue.BackColor = System.Drawing.Color.Transparent;
            this.lblProductNameValue.ForeColor = System.Drawing.Color.White;
            this.lblProductNameValue.Location = new System.Drawing.Point(189, 12);
            this.lblProductNameValue.Name = "lblProductNameValue";
            this.lblProductNameValue.Size = new System.Drawing.Size(110, 21);
            this.lblProductNameValue.TabIndex = 8;
            this.lblProductNameValue.Text = "Product Name";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.ForeColor = System.Drawing.Color.White;
            this.lblQuantity.Location = new System.Drawing.Point(12, 46);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 21);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantityValue
            // 
            this.txtQuantityValue.Location = new System.Drawing.Point(194, 43);
            this.txtQuantityValue.Name = "txtQuantityValue";
            this.txtQuantityValue.Size = new System.Drawing.Size(250, 29);
            this.txtQuantityValue.TabIndex = 10;
            this.txtQuantityValue.Text = "0.00";
            this.txtQuantityValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantityValue.TextChanged += new System.EventHandler(this.txtQuantityValue_TextChanged);
            this.txtQuantityValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityValue_KeyPress);
            // 
            // lblReturnedAmount
            // 
            this.lblReturnedAmount.AutoSize = true;
            this.lblReturnedAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnedAmount.ForeColor = System.Drawing.Color.White;
            this.lblReturnedAmount.Location = new System.Drawing.Point(12, 80);
            this.lblReturnedAmount.Name = "lblReturnedAmount";
            this.lblReturnedAmount.Size = new System.Drawing.Size(137, 21);
            this.lblReturnedAmount.TabIndex = 11;
            this.lblReturnedAmount.Text = "Returned Amount:";
            // 
            // lblReturnedAmountValue
            // 
            this.lblReturnedAmountValue.AutoSize = true;
            this.lblReturnedAmountValue.BackColor = System.Drawing.Color.Transparent;
            this.lblReturnedAmountValue.ForeColor = System.Drawing.Color.White;
            this.lblReturnedAmountValue.Location = new System.Drawing.Point(189, 80);
            this.lblReturnedAmountValue.Name = "lblReturnedAmountValue";
            this.lblReturnedAmountValue.Size = new System.Drawing.Size(40, 21);
            this.lblReturnedAmountValue.TabIndex = 12;
            this.lblReturnedAmountValue.Text = "0.00";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.BackColor = System.Drawing.Color.Transparent;
            this.lblReason.ForeColor = System.Drawing.Color.White;
            this.lblReason.Location = new System.Drawing.Point(12, 114);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(64, 21);
            this.lblReason.TabIndex = 13;
            this.lblReason.Text = "Reason:";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(194, 111);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReason.Size = new System.Drawing.Size(250, 167);
            this.txtReason.TabIndex = 14;
            this.txtReason.TextChanged += new System.EventHandler(this.txtReason_TextChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(17, 293);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 40);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(15)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(244, 293);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmReturnDetails
            // 
            this.AcceptButton = this.btnReturn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(463, 347);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.lblReturnedAmountValue);
            this.Controls.Add(this.lblReturnedAmount);
            this.Controls.Add(this.txtQuantityValue);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblProductNameValue);
            this.Controls.Add(this.lblProductName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReturnDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductNameValue;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantityValue;
        private System.Windows.Forms.Label lblReturnedAmount;
        private System.Windows.Forms.Label lblReturnedAmountValue;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancel;
    }
}