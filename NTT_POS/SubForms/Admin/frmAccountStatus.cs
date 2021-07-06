using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.SubForms.Admin
{
    public partial class frmAccountStatus : Form
    {
        private int userId {get;set;}
        private string tempPassword {
            get { return tbTempPass.Text; }
            set { tbTempPass.Text = value; }
        }
        private string accountStatus {
            get { return lblStat.Text; }
            set { lblStat.Text = value; }
        }
        public frmAccountStatus(int selectedUserId)
        {
            InitializeComponent();
            userId = selectedUserId;

            //Set theme
            SetTheme();
        }
        public void SetTheme()
        {
            //Set theme
            Color selectedColor;
            if (Business.Globals.LightTheme)
            {
                selectedColor = Business.Globals.BackgroundThemeColorLight;
                //Datagrid
                dgvAttempts.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvAttempts.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvAttempts.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //fonts
                label1.ForeColor = Business.Globals.darkLabelcolor;
                label2.ForeColor = Business.Globals.darkLabelcolor;
                lblUserSearch.ForeColor = Business.Globals.darkLabelcolor;
                lblStat.ForeColor = Business.Globals.darkLabelcolor;
               
                //buttons
                btnActivateAccount.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvAttempts.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvAttempts.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvAttempts.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //font
                label1.ForeColor = Business.Globals.lightLabelcolor;
                label2.ForeColor = Business.Globals.lightLabelcolor;
                lblUserSearch.ForeColor = Business.Globals.lightLabelcolor;
                lblStat.ForeColor = Business.Globals.lightLabelcolor;
                //Buttons
                btnActivateAccount.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }
        private void loadAttempts() {
            var attempts = Business.Facades.LoginAttempt.GetAllAttempts(userId);
            if (attempts != null)
            {
                dgvAttempts.DataSource = null;
                dgvAttempts.Rows.Clear();
                Helpers.DataGridViewHelper.ChangeDateFormat(dgvAttempts, 0);
                dgvAttempts.AutoGenerateColumns = false;
                dgvAttempts.DataSource = attempts;
            }

            var userModel = Business.Facades.Users.GetById(userId);
            if (userModel.Disabled)
            {
                btnActivateAccount.Enabled = true;
                accountStatus = "Disabled";
            }
            else
            {
                btnActivateAccount.Enabled = false;
                accountStatus = string.IsNullOrEmpty(userModel.TempPassword) ? "Active" : "Pending Password Reset";
            }
            tempPassword = userModel.TempPassword;
        }
        private void frmAccountStatus_Load(object sender, EventArgs e)
        {
            //load DGV
            loadAttempts();
        }

        private void btnActivateAccount_Click(object sender, EventArgs e)
        {
            if (Business.Facades.Users.ActivateUser(userId)) {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to activate current user?"))
                {
                    Helpers.MessageBoxHelper.ShowInformationDialog("Account successfully activated! Please use the temporary password to reset user password.");
                    loadAttempts();
                }
            }
        }
    }
}
