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
    public partial class frmReturnDetails : Form
    {
        #region Form Field Properties
        public int fTransactionDetailId { get; set; }
        public int fProductId { get; set; }
        public double fProductPrice { get; set; }
        public double fProductQuantity { get; set; }
        public double fReturnedQuantity { get; set; }
        public string fProductName
        {
            get { return lblProductNameValue.Text; }
            set { lblProductNameValue.Text = value; }
        }
        public double fQuantity
        {
            get { return string.IsNullOrEmpty(txtQuantityValue.Text) ? 0.00 : Helpers.TextboxHelper.ConvertToDouble(txtQuantityValue.Text); }
            set { txtQuantityValue.Text = value.ToString("n2", CultureInfo.InvariantCulture); }
        }
        public double fReturnedAmount
        {
            get { return string.IsNullOrEmpty(lblReturnedAmountValue.Text) ? 0.00 : Helpers.TextboxHelper.ConvertToDouble(lblReturnedAmountValue.Text); }
            set { lblReturnedAmountValue.Text = value.ToString("n2", CultureInfo.InvariantCulture); }
        }
        private string fReason
        {
            get { return txtReason.Text; }
            set { txtReason.Text = value; }
        }
        #endregion

        #region Form Events
        public frmReturnDetails()
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
                lblProductName.ForeColor = Business.Globals.darkLabelcolor;
                lblProductNameValue.ForeColor = Business.Globals.darkLabelcolor;
                lblQuantity.ForeColor = Business.Globals.darkLabelcolor;
                lblReason.ForeColor = Business.Globals.darkLabelcolor;
                lblReturnedAmount.ForeColor = Business.Globals.darkLabelcolor;
                lblReturnedAmountValue.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnReturn.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;

                lblProductName.ForeColor = Business.Globals.lightLabelcolor;
                lblProductNameValue.ForeColor = Business.Globals.lightLabelcolor;
                lblQuantity.ForeColor = Business.Globals.lightLabelcolor;
                lblReason.ForeColor = Business.Globals.lightLabelcolor;
                lblReturnedAmount.ForeColor = Business.Globals.lightLabelcolor;
                lblReturnedAmountValue.ForeColor = Business.Globals.lightLabelcolor;
                //buttons
                btnReturn.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(fQuantity > 0)
            {
                // Check if some items has already been returned
                var allowedQuantity = fProductQuantity - fReturnedQuantity; // Quantity allowed to be returned (maximum of purchased quantity)

                if (fQuantity <= allowedQuantity)
                {
                    if (!string.IsNullOrEmpty(fReason))
                    {
                        var _return = new Business.Models.Returns()
                        {
                            TransactionDetailId = fTransactionDetailId,
                            Quantity = fQuantity,
                            ReturnedAmount = fReturnedAmount,
                            Reason = fReason,
                            UserId = Business.Globals.UserId,
                            ReturnStatusId = (int)Business.Enums.ReturnStatus.ToBeReviewed,
                        };
                        var success = Business.Facades.Returns.AddReturn(_return);
                        if (success)
                        {
                            Helpers.MessageBoxHelper.ShowInformationDialog("Return items have been successfully saved.", "Success");
                            this.Close();
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Please specify the reason for returning.");
                    }
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog($"Return quantity can't be higher than the purchased quantity. Based from our records, the purchased quantity was {fProductQuantity} and {fReturnedQuantity} item/s has already been returned.");
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please specify the quantity to return.");
            }
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
            txtReason.SelectionStart = txtReason.Text.Length;
            txtReason.ScrollToCaret();
        }

        private void txtQuantityValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }

        private void txtQuantityValue_TextChanged(object sender, EventArgs e)
        {
            if (fQuantity <= fProductQuantity)
            {
                fReturnedAmount = fProductPrice * fQuantity;
            }
            else
            {
                fQuantity = fProductQuantity;
            }
        }
        #endregion

    }
}
