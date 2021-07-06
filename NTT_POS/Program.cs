using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace NTT_POS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()  
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Process.GetProcessesByName("NTT_POS").Length == 1)
            {
                //Check if product is activated
                var unitAddress = Business.Helpers.NetworkConnection.GetLANMACAddress() != null ? Business.Helpers.NetworkConnection.GetLANMACAddress() : Business.Helpers.NetworkConnection.GetWifiMACAddress();
                if (unitAddress == null) {
                    MessageBox.Show("Network adapter not found!", "Database Connection Failed", MessageBoxButtons.OK);
                    Application.Exit();
                }
                
                if (Business.Helpers.DBHelper.isDBConnected())
                {
                    var unit = Business.Facades.Security.GetUnitData(unitAddress);
                    if (unit != null)
                    {//check if retrieved data is tampered
                        if (Business.Facades.Security.CheckTokenValidity(unit))
                        {
                            //check if the unit date set is correct
                            if (DateTime.Now >= unit.LastOpen)
                            {
                                //check if product is still valid
                                if (unit.ExpirationDate > DateTime.Now)
                                {
                                    //Set Global value for Theming Based on last set value
                                    Business.Globals.LightTheme = Convert.ToBoolean(Business.Helpers.AppSettings.GetSetting("LightTheme"));
                                    //Check if the database is successfully connnected
                                
                                        //Update last login
                                        Business.Facades.Security.UpdateLastLogin(unitAddress);
                                        Business.Globals.UnitName = unitAddress;
                                        // Check if previous user logged out
                                        var loginHistory = Business.Facades.LoginHistory.GetLastLoginHistory();
                                        if (loginHistory != null)
                                        {
                                            if (!loginHistory.IsLoggedOut) //Did not log out
                                            {
                                                var user = Business.Facades.Users.GetById(loginHistory.UserId);
                                                if (user != null)
                                                {
                                                    Business.Globals.UserId = user.UserId;
                                                    Business.Globals.UserFirstName = user.FirstName;
                                                    Business.Globals.UserLastName = user.LastName;
                                                    Business.Globals.LoginHistoryId = loginHistory.LoginHistoryId;
                                                    Business.Globals.IsLoggedOut = false;

                                                    if (user.Role == Business.Enums.Roles.Admin)
                                                    {
                                                        Application.Run(new frmLogin(true, loginHistory.IsLoggedOut));
                                                    }
                                                    else
                                                    {
                                                        // Check if done with Register IN
                                                        var registerActivities = Business.Facades.RegisterActivities.GetRegisterInByUser(Business.Globals.UserId, Business.Globals.LoginHistoryId);
                                                        if (registerActivities == null)
                                                        {
                                                            Business.Globals.IsRegisterIn = false;
                                                        }
                                                        else
                                                        {
                                                            Business.Globals.IsRegisterIn = true;
                                                        }

                                                        //Application.Run(new frmPOS());
                                                        Application.Run(new frmLogin(false, loginHistory.IsLoggedOut));
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                Application.Run(new frmLogin(false, true, false));
                                            }
                                        }
                                        else
                                        {
                                            Application.Run(new frmLogin(false, false, true));
                                        }
                               
                                }
                                else
                                {
                                    if (Helpers.MessageBoxHelper.ShowYesNoDialog("Product Expired, Please enter the PREMIUM Activation key.","Product Expired"))
                                    {
                                        using (var frmActivate = new SubForms.Admin.frmActivatePremium()) {
                                            if (frmActivate.ShowDialog() == DialogResult.OK) {
                                                Helpers.MessageBoxHelper.ShowInformationDialog("You have successfully updated product to PREMIUM!, Please restart your application for the changes to take effect.", "Activation Success!");
                                            }
                                        }
                                    }
                                    //Update last login
                                    Business.Facades.Security.UpdateLastLogin(unitAddress);
                                    Application.Exit();
                                }
                            }else
                                {
                                    MessageBox.Show("The unit time and date are incorrect, please cheeck your unit date and time first before launching the application!", "Incorrect Date & Time", MessageBoxButtons.OK);
                                    Application.Exit();
                                }
                        }
                        else
                        {
                            MessageBox.Show("Data have been tampered!", "Tampered Info!", MessageBoxButtons.OK);
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product is not yet activated, Please contact the administrator!", "Product Activation Key Not Found!", MessageBoxButtons.OK);
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Database connection failed, Please contact the administrator!", "Database Connection Failed", MessageBoxButtons.OK);
                    Application.Exit();
                }
            }
            else {

                MessageBox.Show("The application is currently open. Please close the current application instance before opening a new one.", "Multiple Application Instance Error!", MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
