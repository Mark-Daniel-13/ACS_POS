
namespace NTT_POS.SubForms.Main
{
    partial class frmWholesaleReason
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
            this.grpWholeSale = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.grpWholeSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWholeSale
            // 
            this.grpWholeSale.BackColor = System.Drawing.Color.Transparent;
            this.grpWholeSale.Controls.Add(this.btnAdd);
            this.grpWholeSale.Controls.Add(this.btnCancel);
            this.grpWholeSale.Controls.Add(this.txtReason);
            this.grpWholeSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpWholeSale.Location = new System.Drawing.Point(0, 0);
            this.grpWholeSale.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpWholeSale.Name = "grpWholeSale";
            this.grpWholeSale.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpWholeSale.Size = new System.Drawing.Size(416, 294);
            this.grpWholeSale.TabIndex = 113;
            this.grpWholeSale.TabStop = false;
            this.grpWholeSale.Text = "Wholesale Reason:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(180)))), ((int)(((byte)(73)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(211, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(192, 31);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Reason";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(104)))), ((int)(((byte)(48)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(14, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 31);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Location = new System.Drawing.Point(14, 34);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtReason.MaxLength = 60;
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(389, 196);
            this.txtReason.TabIndex = 0;
            // 
            // frmWholesaleReason
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(416, 294);
            this.ControlBox = false;
            this.Controls.Add(this.grpWholeSale);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmWholesaleReason";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wholesale Reason:";
            this.grpWholeSale.ResumeLayout(false);
            this.grpWholeSale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWholeSale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtReason;
    }
}