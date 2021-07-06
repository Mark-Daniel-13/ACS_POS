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
    public partial class frmDiscount : Form
    {
        #region Form Field Properties
        public string fDiscount
        {
            get { return txtDiscount.Text; }
            set { txtDiscount.Text = value; }
        }
        #endregion

        #region Form Events
        public frmDiscount()
        {
            InitializeComponent();
            SetTheme();
        }
        public void SetTheme()
        {
            //Set theme
            Color selectedColor;
            if (Business.Globals.LightTheme)
            {
                selectedColor = Business.Globals.BackgroundThemeColorLight;
              
                //fonts
                lblDiscount.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnApplyDiscount.BackColor = Business.Globals.lightButtoncolor;
                btnCancelDiscount.BackColor = Business.Globals.lightButtoncolor;

            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;

                //font
                lblDiscount.ForeColor = Business.Globals.lightLabelcolor;
                //buttons
                btnApplyDiscount.BackColor = Business.Globals.darkButtoncolor;
                btnCancelDiscount.BackColor = Business.Globals.darkButtoncolor;

            }
            //Background Color
            BackColor = selectedColor;
        }
        private void frmDiscount_Load(object sender, EventArgs e)
        {
            txtDiscount.Focus();
            txtDiscount.Select();
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fDiscount))
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to apply the discount rate?", "Confirmation"))
                {
                    this.DialogResult = DialogResult.OK;
                    
                }
            }
        }

        private void btnCancelDiscount_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        #region KeyPress Handler
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e, true);
        }
        #endregion
    }
}
