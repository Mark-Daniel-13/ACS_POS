
namespace NTT_POS.SubForms.Admin
{
    partial class frmReceiptTemplateControl
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
            this.grpUserInfo = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserIdValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTInNo = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUserInfo
            // 
            this.grpUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUserInfo.Controls.Add(this.txtTInNo);
            this.grpUserInfo.Controls.Add(this.btnUpdate);
            this.grpUserInfo.Controls.Add(this.label1);
            this.grpUserInfo.Controls.Add(this.txtAddress);
            this.grpUserInfo.Controls.Add(this.txtCompName);
            this.grpUserInfo.Controls.Add(this.lblAddress);
            this.grpUserInfo.Controls.Add(this.lblName);
            this.grpUserInfo.Controls.Add(this.lblUserIdValue);
            this.grpUserInfo.Location = new System.Drawing.Point(13, 15);
            this.grpUserInfo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpUserInfo.Name = "grpUserInfo";
            this.grpUserInfo.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpUserInfo.Size = new System.Drawing.Size(818, 203);
            this.grpUserInfo.TabIndex = 112;
            this.grpUserInfo.TabStop = false;
            this.grpUserInfo.Text = "Branch Info:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(174, 68);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtAddress.MaxLength = 200;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(636, 26);
            this.txtAddress.TabIndex = 1;
            // 
            // txtCompName
            // 
            this.txtCompName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompName.Location = new System.Drawing.Point(173, 30);
            this.txtCompName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCompName.MaxLength = 200;
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(636, 26);
            this.txtCompName.TabIndex = 0;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 71);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 19);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblUserIdValue
            // 
            this.lblUserIdValue.AutoSize = true;
            this.lblUserIdValue.Location = new System.Drawing.Point(169, 37);
            this.lblUserIdValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserIdValue.Name = "lblUserIdValue";
            this.lblUserIdValue.Size = new System.Drawing.Size(0, 19);
            this.lblUserIdValue.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "TinNo.";
            // 
            // txtTInNo
            // 
            this.txtTInNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTInNo.Location = new System.Drawing.Point(173, 106);
            this.txtTInNo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTInNo.MaxLength = 12;
            this.txtTInNo.Name = "txtTInNo";
            this.txtTInNo.Size = new System.Drawing.Size(636, 26);
            this.txtTInNo.TabIndex = 5;
            this.txtTInNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTInNo_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(144)))), ((int)(((byte)(205)))));
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(656, 144);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 47);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmReceiptTemplateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(844, 373);
            this.Controls.Add(this.grpUserInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReceiptTemplateControl";
            this.Load += new System.EventHandler(this.frmReceiptTemplateControl_Load);
            this.grpUserInfo.ResumeLayout(false);
            this.grpUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUserInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserIdValue;
        private System.Windows.Forms.TextBox txtTInNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
    }
}