using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.SubForms.Main
{
    public partial class frmEditQuantity : Form
    {
        #region Form Field Properties

        public double fQuantity
        {
            get { return string.IsNullOrEmpty(tbQuantity.Text) ? 0.00 : Helpers.TextboxHelper.ConvertToDouble(tbQuantity.Text); }
            set { tbQuantity.Text = value.ToString("n2", CultureInfo.InvariantCulture); }
        }
        public int productId;
        public double CurrentTotalQuantity;
        #endregion

        #region Form Events
        public frmEditQuantity(int id,double totalQuantity)
        {
            InitializeComponent();
            SetTheme();
            productId = id;
            CurrentTotalQuantity = totalQuantity;
        }
        public void SetTheme()
        {
            //Set theme
            Color selectedColor;
            if (Business.Globals.LightTheme)
            {
                selectedColor = Business.Globals.BackgroundThemeColorLight;

                //fonts
                lblPrice.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnEditQuantity.BackColor = Business.Globals.lightButtoncolor;
                btnCancelInquiry.BackColor = Business.Globals.lightButtoncolor;

            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
               
                //font
                lblPrice.ForeColor = Business.Globals.lightLabelcolor;
                //buttons
                btnEditQuantity.BackColor = Business.Globals.darkButtoncolor;
                btnCancelInquiry.BackColor = Business.Globals.darkButtoncolor;

            }
            //Background Color
            BackColor = selectedColor;
        }
        private void btnCancelInquiry_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion

        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            if (fQuantity > 0)
            {
                var quantity = Business.Facades.Inventories.GetCurrentStocks(productId);
                if (quantity != null && (quantity-(fQuantity+ CurrentTotalQuantity)) >= 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else {
                    Helpers.MessageBoxHelper.ShowErrorDialog(string.Format("The current available stock is {0}, Please enter quantity greater than the available stock.", quantity.ToString()));
                }
                
            }
            else {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please enter quantity greater than 0");
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }

        private void frmEditQuantity_Load(object sender, EventArgs e)
        {
            tbQuantity.Focus();
        }
    }
}
