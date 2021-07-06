using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.SubForms.Main
{
    public partial class frmWholesaleReason : Form
    {
        public void SetTheme() {
            var lightTheme = Business.Globals.LightTheme;
            BackColor = lightTheme ? Business.Globals.BackgroundThemeColorLight : Business.Globals.BackgroundThemeColor;
            grpWholeSale.ForeColor = lightTheme ? Business.Globals.darkLabelcolor : Business.Globals.lightLabelcolor;

            //Buttons
            btnAdd.BackColor = lightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;
            btnCancel.BackColor = lightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;
        }
        public frmWholesaleReason()
        {
            InitializeComponent();
            SetTheme();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReason.Text) && string.IsNullOrEmpty(txtReason.Text))
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please enter the reason for wholesale purchasing.");
            }
            else {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to add the selected customer?", "Confirmation"))
                {
                    var POS = (frmPOS)Application.OpenForms["frmPOS"];
                    POS.customerWholesaleReason = txtReason.Text;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
