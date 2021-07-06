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
    public partial class frmActivatePremium : Form
    {
        public void SetTheme() {
            var lightTheme = Business.Globals.LightTheme;
            BackColor = lightTheme ? Business.Globals.BackgroundThemeColorLight : Business.Globals.BackgroundThemeColor;
            lblUserSearch.ForeColor = lightTheme ? Business.Globals.darkLabelcolor : Business.Globals.lightLabelcolor;

            //Buttons
            btnActivateAccount.BackColor = lightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;
            btnCancel.BackColor = lightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;
        }
        public frmActivatePremium()
        {
            InitializeComponent();
            //Set theme
            SetTheme();
        }

        private void btnActivateAccount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbActivationKey.Text))
            {
                if (Business.Facades.Security.CheckKey(Business.Globals.UnitName, tbActivationKey.Text))
                {
                    if (Business.Facades.Security.ActivateUnit(Business.Globals.UnitName))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Invalid Key! Please enter valid key to activate PREMIUM", "Invalid key");
                }
            }
            else {
                Helpers.MessageBoxHelper.ShowErrorDialog("Plese enter key value", "Missing key value");
            }
        }
    }
}
