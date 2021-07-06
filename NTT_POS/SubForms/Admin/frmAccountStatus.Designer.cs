
namespace NTT_POS.SubForms.Admin
{
    partial class frmAccountStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountStatus));
            this.dgvAttempts = new System.Windows.Forms.DataGridView();
            this.LoginAttemptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUserSearch = new System.Windows.Forms.Label();
            this.lblStat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTempPass = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnActivateAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttempts)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAttempts
            // 
            this.dgvAttempts.AllowUserToAddRows = false;
            this.dgvAttempts.AllowUserToDeleteRows = false;
            this.dgvAttempts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttempts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAttempts.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttempts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttempts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttempts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttempts.ColumnHeadersHeight = 35;
            this.dgvAttempts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttempts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginAttemptId,
            this.UnitName,
            this.MachineName,
            this.CreationDate});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttempts.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAttempts.EnableHeadersVisualStyles = false;
            this.dgvAttempts.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvAttempts.Location = new System.Drawing.Point(14, 42);
            this.dgvAttempts.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.dgvAttempts.MultiSelect = false;
            this.dgvAttempts.Name = "dgvAttempts";
            this.dgvAttempts.RowHeadersVisible = false;
            this.dgvAttempts.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6);
            this.dgvAttempts.RowTemplate.Height = 24;
            this.dgvAttempts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttempts.Size = new System.Drawing.Size(435, 501);
            this.dgvAttempts.TabIndex = 101;
            this.dgvAttempts.TabStop = false;
            // 
            // LoginAttemptId
            // 
            this.LoginAttemptId.DataPropertyName = "LoginAttemptId";
            this.LoginAttemptId.HeaderText = "AttemptId";
            this.LoginAttemptId.MinimumWidth = 100;
            this.LoginAttemptId.Name = "LoginAttemptId";
            this.LoginAttemptId.ReadOnly = true;
            this.LoginAttemptId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LoginAttemptId.Visible = false;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.UnitName.DefaultCellStyle = dataGridViewCellStyle2;
            this.UnitName.HeaderText = "Unit Name";
            this.UnitName.MinimumWidth = 100;
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            this.UnitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MachineName
            // 
            this.MachineName.DataPropertyName = "MachineName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.MachineName.DefaultCellStyle = dataGridViewCellStyle3;
            this.MachineName.HeaderText = "Machine Name";
            this.MachineName.MinimumWidth = 100;
            this.MachineName.Name = "MachineName";
            this.MachineName.ReadOnly = true;
            this.MachineName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CreationDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.CreationDate.HeaderText = "Date";
            this.CreationDate.MinimumWidth = 100;
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            this.CreationDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblUserSearch
            // 
            this.lblUserSearch.AutoSize = true;
            this.lblUserSearch.ForeColor = System.Drawing.Color.White;
            this.lblUserSearch.Location = new System.Drawing.Point(13, 552);
            this.lblUserSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserSearch.Name = "lblUserSearch";
            this.lblUserSearch.Size = new System.Drawing.Size(112, 19);
            this.lblUserSearch.TabIndex = 109;
            this.lblUserSearch.Text = "Account Status : ";
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.ForeColor = System.Drawing.Color.White;
            this.lblStat.Location = new System.Drawing.Point(133, 552);
            this.lblStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(46, 19);
            this.lblStat.TabIndex = 110;
            this.lblStat.Text = "Active";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 111;
            this.label1.Text = "Recent Login Attempts:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 582);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 112;
            this.label2.Text = "Temp Password:";
            // 
            // tbTempPass
            // 
            this.tbTempPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTempPass.Location = new System.Drawing.Point(137, 579);
            this.tbTempPass.Name = "tbTempPass";
            this.tbTempPass.ReadOnly = true;
            this.tbTempPass.Size = new System.Drawing.Size(312, 26);
            this.tbTempPass.TabIndex = 113;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnActivateAccount, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 611);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 55);
            this.tableLayoutPanel1.TabIndex = 115;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::NTT_POS.Properties.Resources.icons8_return_30;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(220, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(15, 0, 25, 0);
            this.btnCancel.Size = new System.Drawing.Size(208, 43);
            this.btnCancel.TabIndex = 115;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnActivateAccount
            // 
            this.btnActivateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnActivateAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActivateAccount.Enabled = false;
            this.btnActivateAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnActivateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivateAccount.ForeColor = System.Drawing.Color.White;
            this.btnActivateAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnActivateAccount.Image")));
            this.btnActivateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivateAccount.Location = new System.Drawing.Point(4, 6);
            this.btnActivateAccount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActivateAccount.Name = "btnActivateAccount";
            this.btnActivateAccount.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnActivateAccount.Size = new System.Drawing.Size(208, 43);
            this.btnActivateAccount.TabIndex = 114;
            this.btnActivateAccount.Text = "Activate Account";
            this.btnActivateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivateAccount.UseVisualStyleBackColor = false;
            this.btnActivateAccount.Click += new System.EventHandler(this.btnActivateAccount_Click);
            // 
            // frmAccountStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(463, 678);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tbTempPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStat);
            this.Controls.Add(this.lblUserSearch);
            this.Controls.Add(this.dgvAttempts);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccountStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Status";
            this.Load += new System.EventHandler(this.frmAccountStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttempts)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttempts;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginAttemptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.Label lblUserSearch;
        private System.Windows.Forms.Label lblStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTempPass;
        private System.Windows.Forms.Button btnActivateAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
    }
}