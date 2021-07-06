
namespace NTT_POS.SubForms.Admin
{
    partial class frmActivatePremium
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
            this.lblUserSearch = new System.Windows.Forms.Label();
            this.tbActivationKey = new System.Windows.Forms.TextBox();
            this.btnActivateAccount = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserSearch
            // 
            this.lblUserSearch.AutoSize = true;
            this.lblUserSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblUserSearch.ForeColor = System.Drawing.Color.Black;
            this.lblUserSearch.Location = new System.Drawing.Point(13, 21);
            this.lblUserSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserSearch.Name = "lblUserSearch";
            this.lblUserSearch.Size = new System.Drawing.Size(111, 21);
            this.lblUserSearch.TabIndex = 110;
            this.lblUserSearch.Text = "Activation Key:";
            // 
            // tbActivationKey
            // 
            this.tbActivationKey.Location = new System.Drawing.Point(131, 18);
            this.tbActivationKey.Name = "tbActivationKey";
            this.tbActivationKey.Size = new System.Drawing.Size(415, 29);
            this.tbActivationKey.TabIndex = 111;
            // 
            // btnActivateAccount
            // 
            this.btnActivateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnActivateAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnActivateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivateAccount.ForeColor = System.Drawing.Color.White;
            this.btnActivateAccount.Image = global::NTT_POS.Properties.Resources.icons8_verified_account_32;
            this.btnActivateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivateAccount.Location = new System.Drawing.Point(358, 56);
            this.btnActivateAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActivateAccount.Name = "btnActivateAccount";
            this.btnActivateAccount.Size = new System.Drawing.Size(187, 38);
            this.btnActivateAccount.TabIndex = 115;
            this.btnActivateAccount.Text = "Activate Premium";
            this.btnActivateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivateAccount.UseVisualStyleBackColor = false;
            this.btnActivateAccount.Click += new System.EventHandler(this.btnActivateAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::NTT_POS.Properties.Resources.icons8_return_30;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(131, 56);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(187, 38);
            this.btnCancel.TabIndex = 116;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmActivatePremium
            // 
            this.AcceptButton = this.btnActivateAccount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(558, 104);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnActivateAccount);
            this.Controls.Add(this.tbActivationKey);
            this.Controls.Add(this.lblUserSearch);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActivatePremium";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activate Premium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserSearch;
        private System.Windows.Forms.TextBox tbActivationKey;
        private System.Windows.Forms.Button btnActivateAccount;
        private System.Windows.Forms.Button btnCancel;
    }
}