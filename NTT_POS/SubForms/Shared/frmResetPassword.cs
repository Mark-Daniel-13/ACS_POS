using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.SubForms.Shared
{
    public partial class frmResetPassword : Form
    {
        private int userId { get; set; } 
        private string fResetPass {
            get { return tbNewPass.Text; }
            set { tbNewPass.Text = value; }
        }
        private bool showPassword = false;
        public void SetTheme() {
            var lightTheme = Business.Globals.LightTheme;
            BackColor = lightTheme ? Business.Globals.BackgroundThemeColorLight : Business.Globals.BackgroundThemeColor;
            label1.ForeColor = lightTheme ? Business.Globals.darkLabelcolor : Business.Globals.lightLabelcolor;

            //Buttons
            btnCancel.BackColor = lightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;
            btnReset.BackColor = lightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;
        }
        public frmResetPassword(int currentUserId)
        {
            InitializeComponent();
            userId = currentUserId;

            //Set theme
            SetTheme();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fResetPass) && !string.IsNullOrWhiteSpace(fResetPass))
            {
                var resetPass = Business.Facades.Users.ResetUserPassword(userId, fResetPass);
                if (resetPass)
                {
                    Helpers.MessageBoxHelper.ShowInformationDialog("Password successfully reset! You can now log in using your new password.", "Password Reset Success");
                    this.DialogResult = DialogResult.OK;
                }
            }
            else {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please enter valid input!", "Invalid Input");
            }
        }

        private void btnShowToggle_Click(object sender, EventArgs e)
        {
            btnShowToggle.Image = showPassword ? Properties.Resources.btnshow1_Image : Properties.Resources.btnhide1_Image;
            tbNewPass.PasswordChar = tbNewPass.PasswordChar == '•' ? tbNewPass.PasswordChar = '\0' : tbNewPass.PasswordChar = '•';
            showPassword = !showPassword;
        }
    }
}
