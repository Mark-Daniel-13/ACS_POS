namespace NTT_POS.SubForms.Main
{
    partial class frmCashRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashRegister));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlCashRegister = new System.Windows.Forms.Panel();
            this.dgvDenominations = new System.Windows.Forms.DataGridView();
            this.DenominationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denomination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCashRegister = new System.Windows.Forms.DataGridView();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCashRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenominations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(73)))), ((int)(((byte)(108)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(246, 329);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(177, 40);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.TabStop = false;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(72)))), ((int)(((byte)(15)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(429, 329);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(177, 40);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // pnlCashRegister
            // 
            this.pnlCashRegister.AutoScroll = true;
            this.pnlCashRegister.BackColor = System.Drawing.Color.Transparent;
            this.pnlCashRegister.Controls.Add(this.dgvDenominations);
            this.pnlCashRegister.Controls.Add(this.dgvCashRegister);
            this.pnlCashRegister.Controls.Add(this.btnCancel);
            this.pnlCashRegister.Controls.Add(this.btnRegister);
            this.pnlCashRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCashRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlCashRegister.Name = "pnlCashRegister";
            this.pnlCashRegister.Size = new System.Drawing.Size(830, 387);
            this.pnlCashRegister.TabIndex = 0;
            // 
            // dgvDenominations
            // 
            this.dgvDenominations.AllowUserToAddRows = false;
            this.dgvDenominations.AllowUserToDeleteRows = false;
            this.dgvDenominations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDenominations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDenominations.BackgroundColor = System.Drawing.Color.White;
            this.dgvDenominations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDenominations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDenominations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDenominations.ColumnHeadersHeight = 35;
            this.dgvDenominations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDenominations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DenominationId,
            this.Denomination,
            this.Quantity,
            this.TotalAmount});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDenominations.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDenominations.EnableHeadersVisualStyles = false;
            this.dgvDenominations.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvDenominations.Location = new System.Drawing.Point(12, 12);
            this.dgvDenominations.MultiSelect = false;
            this.dgvDenominations.Name = "dgvDenominations";
            this.dgvDenominations.RowHeadersVisible = false;
            this.dgvDenominations.RowTemplate.Height = 24;
            this.dgvDenominations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDenominations.Size = new System.Drawing.Size(320, 300);
            this.dgvDenominations.TabIndex = 102;
            this.dgvDenominations.TabStop = false;
            this.dgvDenominations.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDenominations_CellEndEdit);
            this.dgvDenominations.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDenominations_EditingControlShowing);
            // 
            // DenominationId
            // 
            this.DenominationId.DataPropertyName = "DenominationId";
            this.DenominationId.HeaderText = "DenominationId";
            this.DenominationId.Name = "DenominationId";
            this.DenominationId.ReadOnly = true;
            this.DenominationId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DenominationId.Visible = false;
            this.DenominationId.Width = 160;
            // 
            // Denomination
            // 
            this.Denomination.DataPropertyName = "Denomination";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Denomination.DefaultCellStyle = dataGridViewCellStyle13;
            this.Denomination.HeaderText = "Denomination";
            this.Denomination.MinimumWidth = 100;
            this.Denomination.Name = "Denomination";
            this.Denomination.ReadOnly = true;
            this.Denomination.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Denomination.Width = 113;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle14;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 100;
            this.Quantity.Name = "Quantity";
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalAmount
            // 
            this.TotalAmount.DataPropertyName = "TotalAmount";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalAmount.DefaultCellStyle = dataGridViewCellStyle15;
            this.TotalAmount.HeaderText = "Total";
            this.TotalAmount.MinimumWidth = 100;
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvCashRegister
            // 
            this.dgvCashRegister.AllowUserToAddRows = false;
            this.dgvCashRegister.AllowUserToDeleteRows = false;
            this.dgvCashRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCashRegister.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCashRegister.BackgroundColor = System.Drawing.Color.White;
            this.dgvCashRegister.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCashRegister.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvCashRegister.ColumnHeadersHeight = 35;
            this.dgvCashRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCashRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee,
            this.Activity,
            this.Total,
            this.ActivityDate});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(145)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCashRegister.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvCashRegister.EnableHeadersVisualStyles = false;
            this.dgvCashRegister.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvCashRegister.Location = new System.Drawing.Point(338, 12);
            this.dgvCashRegister.MultiSelect = false;
            this.dgvCashRegister.Name = "dgvCashRegister";
            this.dgvCashRegister.RowHeadersVisible = false;
            this.dgvCashRegister.RowTemplate.Height = 24;
            this.dgvCashRegister.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCashRegister.Size = new System.Drawing.Size(480, 300);
            this.dgvCashRegister.TabIndex = 101;
            this.dgvCashRegister.TabStop = false;
            // 
            // Employee
            // 
            this.Employee.DataPropertyName = "Employee";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Employee.DefaultCellStyle = dataGridViewCellStyle18;
            this.Employee.HeaderText = "Employee";
            this.Employee.MinimumWidth = 150;
            this.Employee.Name = "Employee";
            this.Employee.ReadOnly = true;
            this.Employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Employee.Width = 150;
            // 
            // Activity
            // 
            this.Activity.DataPropertyName = "Activity";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Activity.DefaultCellStyle = dataGridViewCellStyle19;
            this.Activity.HeaderText = "Activity";
            this.Activity.MinimumWidth = 100;
            this.Activity.Name = "Activity";
            this.Activity.ReadOnly = true;
            this.Activity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Total.DefaultCellStyle = dataGridViewCellStyle20;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 100;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ActivityDate
            // 
            this.ActivityDate.DataPropertyName = "ActivityDate";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ActivityDate.DefaultCellStyle = dataGridViewCellStyle21;
            this.ActivityDate.HeaderText = "ActivityDate";
            this.ActivityDate.MinimumWidth = 120;
            this.ActivityDate.Name = "ActivityDate";
            this.ActivityDate.ReadOnly = true;
            this.ActivityDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ActivityDate.Width = 120;
            // 
            // frmCashRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(830, 387);
            this.ControlBox = false;
            this.Controls.Add(this.pnlCashRegister);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCashRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Register";
            this.Load += new System.EventHandler(this.frmCashRegister_Load);
            this.pnlCashRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDenominations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashRegister)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlCashRegister;
        private System.Windows.Forms.DataGridView dgvCashRegister;
        private System.Windows.Forms.DataGridView dgvDenominations;
        private System.Windows.Forms.DataGridViewTextBoxColumn DenominationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denomination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityDate;
    }
}