using NTT_POS.SubForms.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS
{
    public partial class frmLogin : Form
    {
        private bool frmShow = false;
        bool drag = false;
        Point start = new Point(0, 0);

        public void SetTheme() {
            if (Business.Globals.LightTheme) { 
                pnlNav.BackColor = Business.Globals.PanelThemeColorLight;
                pictureBox1.Image = Properties.Resources.bolt_101_login_Light;
                btnLogin.BackgroundImage = Properties.Resources.btnloginlight;
            } else { 
                pnlNav.BackColor = Business.Globals.PanelThemeColorDark;
                pictureBox1.Image = Properties.Resources.bolt_101_login;
                btnLogin.BackgroundImage = Properties.Resources.btnlogin;
            }
        }

        public frmLogin(bool isAdmin=false,bool isLoggedOut=true, bool emptyDB = false)
        {
            InitializeComponent();
            //Hide the form login initially then show POS/Admin but if POS/Admin is closed show the form login
            if (!emptyDB && !isLoggedOut)
            {
                if (isAdmin)
                {
                    var frmAdmin = new frmAdmin();
                    frmAdmin.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                    frmAdmin.Show();
                }
                else
                {
                    var frmPOS = new frmPOS();
                    frmPOS.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                    frmPOS.Show();
                }
            }
            else 
            {
                frmShow = true;
                SetVisibleCore(true);
                this.Show();
            }
            SetTheme();
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Once formPOS is closed we now allow the main form to
            // become visible.
            frmShow = true;
            this.Show();
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(frmShow && value);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
           // if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            if (txtUsername.Text=="Username" || txtPassword.Text== "Password")
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input username and password.");
            }
            else
            {
                var userModel = Business.Facades.Users.CheckUsernameExist(userName);
                var isUserExist = userModel != null ? true : false;
                if (isUserExist)
                {
                    //check if user account is not disabled
                    if (!userModel.Disabled)
                    {
                        var unitName = "";
                        if (Business.Helpers.NetworkConnection.GetLANMACAddress() != null)
                        {
                            unitName = Business.Helpers.NetworkConnection.GetLANMACAddress();
                        }
                        else if (Business.Helpers.NetworkConnection.GetWifiMACAddress() != null)
                        {
                            unitName = Business.Helpers.NetworkConnection.GetWifiMACAddress();
                        }

                        var user = string.IsNullOrEmpty(userModel.TempPassword) ? Business.Facades.Users.GetByUsernamePassword(userName, password) : Business.Facades.Users.GetByUsernamePassword(userName, password, true);
                        if (user != null)
                        {
                            #region Password Reset
                            if (!string.IsNullOrEmpty(userModel.TempPassword))
                            {
                                //there's temp pass but account is disabled means user havent reset password
                                using (SubForms.Shared.frmResetPassword resetPass = new SubForms.Shared.frmResetPassword(userModel.UserId))
                                {
                                    resetPass.ShowDialog(this);

                                    if (resetPass.DialogResult == DialogResult.OK)
                                    {
                                        //password successfully reset :: clear all failed login on all units
                                        if (!Business.Facades.LoginAttempt.ClearAllLoginAttempt(userModel.UserId))
                                        {
                                            Helpers.MessageBoxHelper.ShowInformationDialog("Something went wrong on clearing login attempts, Please contact the administrator.", "Clear LoginAttempts Failed");
                                        }
                                    }
                                    else
                                    {
                                        //exit out of method
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                //clear all attempts on the current unit
                                if (Business.Facades.LoginAttempt.GetAllAttemptsOnUnit(unitName, userModel.UserId) > 0)
                                {
                                    if (!Business.Facades.LoginAttempt.ClearAttemptsOnUnit(unitName, userModel.UserId))
                                    {
                                        Helpers.MessageBoxHelper.ShowInformationDialog("Something went wrong on clearing login attempts, Please contact the administrator.", "Clear LoginAttempts Failed");
                                    }
                                }
                            }
                            #endregion
                            
                            //Check if the user is currently logged in on other machine
                            var isCurrentlyLoggedIn = Business.Facades.LoginHistory.haveOtherLogIns(user.UserId, unitName);
                            if (isCurrentlyLoggedIn == null)
                            {
                                Business.Globals.UserId = user.UserId;
                                Business.Globals.UserFirstName = user.FirstName;
                                Business.Globals.UserLastName = user.LastName;
                                Business.Globals.IsLoggedOut = false;

                                // Add to LoginHistory table
                                var loginHistory = new Business.Models.LoginHistory()
                                {
                                    UserId = user.UserId,
                                    IsLoggedOut = false,
                                    UnitName = unitName,
                                    MachineName = Environment.MachineName,
                                };
                                Business.Globals.LoginHistoryId = Business.Facades.LoginHistory.AddLoginHistory(loginHistory);

                                this.Hide();
                                if (user.Role == Business.Enums.Roles.Admin)
                                {
                                    var frmAdmin = new frmAdmin();
                                    //frmAdmin.Closed += (s, args) => this.Close();
                                    frmAdmin.Show();
                                }
                                else
                                {
                                    var frmPOS = new frmPOS();
                                    //frmPOS.Closed += (s, args) => this.Close();  //when form POS is closed, close login form as well
                                    frmPOS.Show();

                                }
                            }
                            else{
                                Helpers.MessageBoxHelper.ShowInformationDialog(string.Format("User is currently logged in on PC unit: {0}, Please log out on the previous machine first before logging into the new one.", isCurrentlyLoggedIn.MachineName), "Multiple Log In Not Valid");
                            }
                        }
                        else
                        {
                            //This portion states that there's a user but entered invalid password
                            //Preview invalid password message - sir john task
                            MessageBox.Show("Username or password is incorrect"); // Changed this message box to your task or preference


                            if (string.IsNullOrEmpty(userModel.TempPassword)) // Only add fail attempt if the account status is active
                            {
                                //LOCK OUT FUNC
                                var attemptModel = new Business.Models.LoginAttempt()
                                {
                                    UserId = userModel.UserId,
                                    UnitName = unitName,
                                    MachineName = Environment.MachineName,
                                };

                                if (Business.Facades.LoginAttempt.AddNewLoginAttempt(attemptModel))
                                {
                                    var attemptCount = Business.Facades.LoginAttempt.GetAllAttemptsOnUnit(unitName, userModel.UserId);
                                    var allowedCount = Business.Helpers.AppSettings.GetSetting("LogInAttemptCount") != null ? Convert.ToInt32(Business.Helpers.AppSettings.GetSetting("LogInAttemptCount")) : 5;
                                    if (attemptCount >= allowedCount)
                                    {
                                        //if the attempt already reached max attempt disable account
                                        Business.Facades.Users.LockUser(userModel.UserId);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        //Preview account is locked - sir john task
                        MessageBox.Show("account is disabled"); // Changed this message box to your task or preference
                    }
                }
                else {
                    MessageBox.Show("Username or password is incorrect");
                }
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public  void clearFields() {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlNav_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void pnlNav_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start.X, p.Y - start.Y);
            }
        }

        private void pnlNav_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start = new Point(e.X, e.Y);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;

            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
                txtUsername.ForeColor = Color.Gray;

            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '•';

            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.PasswordChar = '\0';

            }
        }
    }
}
