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
    public partial class frmUsers : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        #region Form Field Properties
        private string fUserId
        {
            get { return lblUserIdValue.Text; }
            set { lblUserIdValue.Text = value; }
        }

        private string fFirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }

        private string fLastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        private string fUserRole
        {
            get { return cbRole.Text; }
            set { cbRole.Text = value; }
        }

        private string fUserName
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        private string fPassword
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        private string fConfirmPassword
        {
            get { return txtConfirmPassword.Text; }
            set { txtConfirmPassword.Text = value; }
        }

        private string fSearchText
        {
            get { return txtUserSearch.Text; }
            set { txtUserSearch.Text = value; }
        }
        #endregion

        #region Helpers
        private void LoadUsers()
        {
            var users = Business.Facades.Users.GetAll();
            if (users != null)
            {
                var userVMList = ViewModels.UserViewModel.ToViewModelList(users);
                dgvUsers.AutoGenerateColumns = false;
                dgvUsers.DataSource = userVMList;
            }
        }

        private void SearchUsers()
        {
            var users = Business.Facades.Users.Search(fSearchText);
            if (users != null)
            {
                var userVMList = ViewModels.UserViewModel.ToViewModelList(users);
                dgvUsers.AutoGenerateColumns = false;
                dgvUsers.DataSource = userVMList;
            }
        }

        private void LoadRoles()
        {
            cbRole.DataSource = Enum.GetValues(typeof(Business.Enums.Roles));
        }

        private void ClearFields()
        {
            fUserId = string.Empty;
            fFirstName = string.Empty;
            fLastName = string.Empty;
            fUserName = string.Empty;
            fPassword = string.Empty;
            fConfirmPassword = string.Empty;
            cbRole.SelectedIndex = -1;
            fUserRole = string.Empty;
        }

        private bool CheckFields(bool checkId = false)
        {
            bool valid = false;
            if (!string.IsNullOrEmpty(fFirstName) && !string.IsNullOrEmpty(fLastName) && !string.IsNullOrEmpty(fUserName) && cbRole.SelectedIndex != -1)
            {
                if (checkId)
                {
                    if (!string.IsNullOrEmpty(fUserId))
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(fUserId))
                    {
                        valid = false;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(fPassword))
                        {
                            valid = true;
                        }
                        else {
                            valid = false;
                        }
                    }
                }
            }
            return valid;
        }
        private bool CheckUsername(int? userId = null) {
            var isUserExist = (userId == null) ?  Business.Facades.Users.CheckUsernameExist(fUserName) : Business.Facades.Users.CheckUsernameExist(fUserName,Convert.ToInt32(userId));

            if (isUserExist != null) return false;
            return true;
        }
        private bool CheckPasswordComplexity() {
            //check if password have any numeric on string and if the lenght is >6
            if (fPassword.Any(char.IsDigit) && fPassword.Length>=6) {
                return true;
            }
            return false;
        }
        private bool CheckPassword()
        {
            
            if (fPassword == fConfirmPassword)
            {
                return true;
            }

            return false;
        }
        #endregion

        #region Form Events
        public frmUsers()
        {
            InitializeComponent();
            btnAccStat.Hide();

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
                dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvUsers.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //Panel
                userInfopnl.BackColor = Business.Globals.BackgroundThemeColorLight;
                panel1.BackColor = Business.Globals.lightDgvHeadercolor;
                //fonts
                lblUserSearch.ForeColor = Business.Globals.darkLabelcolor;
                grpUserInfo.ForeColor= Business.Globals.darkLabelcolor;
                grpUsersData.ForeColor = Business.Globals.darkLabelcolor;
                dgvUsers.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnAccStat.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
                btnUpdateUser.BackColor = Business.Globals.lightButtoncolor;
                btnAddnewuser.BackColor = Business.Globals.lightButtoncolor;
                btnSaveUser.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvUsers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvUsers.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //Panel
                userInfopnl.BackColor = Color.DimGray;
                panel1.BackColor = Business.Globals.PanelThemeColorDark;
                //font
                lblUserSearch.ForeColor = Business.Globals.lightLabelcolor;
                grpUserInfo.ForeColor = Business.Globals.lightLabelcolor;
                grpUsersData.ForeColor = Business.Globals.lightLabelcolor;
                dgvUsers.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
                //Buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnAccStat.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
                btnUpdateUser.BackColor = Business.Globals.darkButtoncolor;
                btnAddnewuser.BackColor = Business.Globals.darkButtoncolor;
                btnSaveUser.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadRoles();
            userInfopnl.Visible = false;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
           // btnSaveUser.Enabled = true; //Enable add button
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool valid = CheckFields();
            if (valid)
            {
                if (CheckUsername())
                {
                    if (CheckPassword())
                    {
                        if (CheckPasswordComplexity())
                        {
                            if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to add the User?", "Confirmation"))
                            {
                                var user = new Business.Models.Users()
                                {
                                    FirstName = fFirstName,
                                    LastName = fLastName,
                                    Username = fUserName,
                                    Password = fPassword,
                                    Role = (Business.Enums.Roles)cbRole.SelectedItem,
                                    AddedBy = Business.Globals.UserId
                                };
                                bool success = Business.Facades.Users.AddUser(user);
                                if (success)
                                {
                                    LoadUsers();
                                    ClearFields();
                                    Helpers.MessageBoxHelper.ShowInformationDialog("User has been successfully added.", "Success");
                                }
                                else
                                {
                                    Helpers.MessageBoxHelper.ShowErrorDialog("Error adding user. Please contact your administrator.");
                                }
                            }
                        }
                        else {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Password must be atleast 6 characters long and have numeric digit.");
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Password and password confirmation do not match.");
                    }
                }
                else {
                    string msg = string.Format("Username {0} is already used! Please try another username",fUserName);
                    Helpers.MessageBoxHelper.ShowErrorDialog(msg);
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input the complete and correct user information.");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            bool valid = CheckFields(true);
            if (valid)
            {
                if (CheckUsername(Convert.ToInt32(fUserId)))
                {
                    bool passwordValid = CheckPassword();
                    if (passwordValid)
                    {
                        if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to update the user?", "Confirmation"))
                        {
                            var user = new Business.Models.Users()
                            {
                                UserId = Convert.ToInt32(fUserId),
                                FirstName = fFirstName,
                                LastName = fLastName,
                                Username = fUserName,
                                Password = fPassword,
                                Role = (Business.Enums.Roles)cbRole.SelectedItem
                            };
                            bool success = Business.Facades.Users.UpdateUser(user);
                            if (success)
                            {
                                LoadUsers();
                                ClearFields();
                                Helpers.MessageBoxHelper.ShowInformationDialog("User has been successfully updated.", "Success");
                                //btnSaveUser.Enabled = true; //Enable add button
                                btnAddnewuser.Visible = true;
                                userInfopnl.Visible = false;
                            }
                            else
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Error updating user. Please contact your Administrator.");
                            }
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Password and password confirmation do not match.");
                    }
                }
                else {
                    string msg = string.Format("Username {0} is already used! Please try another username", fUserName);
                    Helpers.MessageBoxHelper.ShowErrorDialog(msg);
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input the complete and correct user information.");
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fUserId))
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to delete user?", "Confirmation"))
                {
                    bool success = Business.Facades.Users.DeleteUser(Convert.ToInt32(fUserId));
                    if (success)
                    {
                        LoadUsers();
                        ClearFields();
                        Helpers.MessageBoxHelper.ShowInformationDialog("User has been successfully deleted.", "Success");
                       // btnSaveUser.Enabled = true;//enable add button
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Error deleting User. Please contact your administrator.");
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please select the user to delete.");
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveUser.Visible = false;
            if (e.ColumnIndex == 7)
            {
                if (e.RowIndex >= 0)
                {
                    userInfopnl.Visible = true;
                    btnUpdateUser.Visible = true;
                    btnAddnewuser.Visible = false;
                    var selectedRow = this.dgvUsers.Rows[e.RowIndex];

                    fUserId = selectedRow.Cells["UserId"].Value.ToString();
                    fFirstName = selectedRow.Cells["FirstName"].Value.ToString();
                    fLastName = selectedRow.Cells["LastName"].Value.ToString();
                    fUserName = selectedRow.Cells["Username"].Value.ToString();
                    cbRole.SelectedItem = Business.Helpers.EnumHelper.ParseEnum<Business.Enums.Roles>(selectedRow.Cells["Role"].Value.ToString(), Business.Enums.Roles.Cashier);
                }
            }
            else if (e.ColumnIndex == 8)
            {
                if (e.RowIndex >= 0)
                {
                   
                    var selectedRow = this.dgvUsers.Rows[e.RowIndex];

                    fUserId = selectedRow.Cells["UserId"].Value.ToString();
                    fFirstName = selectedRow.Cells["FirstName"].Value.ToString();
                    fLastName = selectedRow.Cells["LastName"].Value.ToString();
                    fUserName = selectedRow.Cells["Username"].Value.ToString();
                    cbRole.SelectedItem = Business.Helpers.EnumHelper.ParseEnum<Business.Enums.Roles>(selectedRow.Cells["Role"].Value.ToString(), Business.Enums.Roles.Cashier);

                    if (!string.IsNullOrEmpty(fUserId))
                    {
                        if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to delete user?", "Confirmation"))
                        {
                            bool success = Business.Facades.Users.DeleteUser(Convert.ToInt32(fUserId));
                            if (success)
                            {
                                LoadUsers();
                                ClearFields();
                                Helpers.MessageBoxHelper.ShowInformationDialog("User has been successfully deleted.", "Success");
                                
                            }
                            else
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Error deleting User. Please contact your administrator.");
                            }
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Please select the user to delete.");
                    }
                }

            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnSaveUser.Enabled = false;//Disable add button
            if (e.RowIndex >= 0)
            {
                var selectedRow = this.dgvUsers.Rows[e.RowIndex];

                fUserId = selectedRow.Cells["UserId"].Value.ToString();
                fFirstName = selectedRow.Cells["FirstName"].Value.ToString();
                fLastName = selectedRow.Cells["LastName"].Value.ToString();
                fUserName = selectedRow.Cells["Username"].Value.ToString();
                cbRole.SelectedItem = Business.Helpers.EnumHelper.ParseEnum<Business.Enums.Roles>(selectedRow.Cells["Role"].Value.ToString(), Business.Enums.Roles.Cashier);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Helpers.DataGridViewHelper.ClearDatagrid(dgvUsers);
            if (!string.IsNullOrEmpty(fSearchText))
            {
                SearchUsers();
            }
            else
            {
                LoadUsers();
            }
        }
        #endregion

        private void btnAccStat_Click(object sender, EventArgs e)
        {
            using (frmAccountStatus accountStatus = new frmAccountStatus(Convert.ToInt32(fUserId))) {
                
                accountStatus.ShowDialog(this);
            }
        }

        private void lblUserIdValue_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fUserId) && string.IsNullOrWhiteSpace(fUserId))
            {
                btnAccStat.Hide();
            }
            else {
                btnAccStat.Show();
            }
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            //keypress
            if (Helpers.TextboxHelper.checkAlpha(txtFirstName.Text))
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Numbers and Special Characters are not allowed in this tags.");
                txtFirstName.Text = txtFirstName.Text.Remove(txtFirstName.Text.Length - 1);
            }
        }

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            //keypress
            if (Helpers.TextboxHelper.checkAlpha(txtLastName.Text))
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Numbers and Special Characters are not allowed in this tags.");
                txtLastName.Text = txtLastName.Text.Remove(txtLastName.Text.Length - 1);
            }
        }

        private void Btnhide1_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '\0')
            {
                btnshow1.BringToFront();
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        private void Btnshow1_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.PasswordChar == '•')
            {
                btnhide1.BringToFront();
                txtConfirmPassword.PasswordChar = '\0';
            }
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '•')
            {
                btnHide.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnHide_Click_1(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                btnShow.BringToFront();
                txtPassword.PasswordChar = '•';
            }
        }

        private void FrmUsers_Resize(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            //panel2.Left = (this.Width - panel2.Width) / 2;
            // userInfopnl.Left = (this.Width - userInfopnl.Width) / 2;



        }

        private void BtnAddnewuser_Click(object sender, EventArgs e)
        {
            btnSaveUser.Visible = true;
            btnUpdateUser.Visible = false;
            userInfopnl.Visible = !userInfopnl.Visible;
            ClearFields();
            btnAddnewuser.Visible = false;
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            userInfopnl.Visible = !userInfopnl.Visible;
            btnAddnewuser.Visible = true;
        }

      
    }
}
