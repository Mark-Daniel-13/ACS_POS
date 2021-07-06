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
    public partial class frmMenu : Form
    {
        public frmMenu()
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
               
                //buttons
                btnAddCustomer.BackColor = Business.Globals.lightButtoncolor;
                btnPending.BackColor = Business.Globals.lightButtoncolor;
                btnTransPendingShow.BackColor = Business.Globals.lightButtoncolor;
                btnTransVoid.BackColor = Business.Globals.lightButtoncolor;
                btnCashSweep.BackColor = Business.Globals.lightButtoncolor;
                btnPrinterSettings.BackColor = Business.Globals.lightButtoncolor;
                btnLogout.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;

                //buttons
                btnAddCustomer.BackColor = Business.Globals.darkButtoncolor;
                btnPending.BackColor = Business.Globals.darkButtoncolor;
                btnTransPendingShow.BackColor = Business.Globals.darkButtoncolor;
                btnTransVoid.BackColor = Business.Globals.darkButtoncolor;
                btnCashSweep.BackColor = Business.Globals.darkButtoncolor;
                btnPrinterSettings.BackColor = Business.Globals.darkButtoncolor;
                btnLogout.BackColor = Business.Globals.darkButtoncolor;

            }
            //Background Color
            BackColor = selectedColor;
        }
        private void btnPrinterSettings_Click(object sender, EventArgs e)
        {
            using (SubForms.Main.frmPrinterSettings frmPrinterSettings = new SubForms.Main.frmPrinterSettings())
            {
                frmPrinterSettings.ShowDialog(this);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            using (SubForms.Main.frmCashRegister frmCashRegister = new SubForms.Main.frmCashRegister())
            {
                frmCashRegister.ActivityType = Business.Enums.RegisterActivityTypes.RegisterOut;
                if (frmCashRegister.ShowDialog(this) == DialogResult.OK)
                {
                    // Save Login activity
                    var loginHistory = Business.Facades.LoginHistory.UpdateLoginHistory(Business.Globals.LoginHistoryId, true);

                    // Open Login Form
                    if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "frmLogin"))
                    {
                        var frmLogin = (frmLogin)Application.OpenForms["frmLogin"];
                        frmLogin.clearFields();
                        frmLogin.txtUsername.Focus();
                        frmLogin.Show();
                    }

                    //setting is logged out to true
                    Business.Globals.IsLoggedOut = true;
                    Business.Globals.IsRegisterIn = false;

                    //Close all forms
                    var formsList = Application.OpenForms.Cast<Form>().Where(w => w.Name != "frmLogin").ToList();
                    formsList.ForEach(form =>
                    {
                        form.Close();
                    });

                }
            }
        }

        private void btnCashSweep_Click(object sender, EventArgs e)
        {
            using (SubForms.Main.frmCashRegister frmCashRegister = new SubForms.Main.frmCashRegister())
            {
                frmCashRegister.ActivityType = Business.Enums.RegisterActivityTypes.CashSweep;
                frmCashRegister.ShowDialog(this);
            }
        }

        private void btnTransVoid_Click(object sender, EventArgs e)
        {
            using (SubForms.Main.frmTransactionVoid frmTransactionVoid = new SubForms.Main.frmTransactionVoid())
            {
                frmTransactionVoid.ShowDialog(this);
            }
        }

        private void btnTransPendingShow_Click(object sender, EventArgs e)
        {
            using (SubForms.Main.frmPendingTransaction frmPendingTransaction = new SubForms.Main.frmPendingTransaction())
            {
                frmPendingTransaction.ShowDialog(this);
            }
        }
        private void btnPending_Click(object sender, EventArgs e)
        {
            var POS = (frmPOS)Application.OpenForms["frmPOS"]; //get the current open form POS
            if (POS.pendingTransId == 0)
            {
                if (POS.checkIfDataGridHaveValue())
                {
                    if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to move the current transaction to pending?", "Confirmation"))
                    {
                        POS.fTransactionType = Business.Enums.TransactionTypes.Pending;
                        var productIdQtyList = new List<KeyValuePair<int, double>>();

                        var customer = POS.fCustomerValue != "None" ? Business.Facades.Customer.GetByName(POS.fCustomerValue) : null;
                        // Create Transaction model
                        var transaction = new Business.Models.Transactions()
                        {
                            UserId = Business.Globals.UserId,
                            ReceiptNumber = "0",
                            CustomerId = customer?.CustomerId,
                            TransactionTypeId = POS.fTransactionType,
                            DiscountPercentage = !string.IsNullOrEmpty(POS.fPDiscount) ? Convert.ToDouble(POS.fPDiscount.Replace("%", "")) : 0.00,
                            DiscountAmount = POS.fDiscount,
                            PaymentAmount = 0
                        };

                        // Add to Transactions table and update Inventory stocks
                        transaction.TransactionDetails = POS.getTransactionDetails();
                        var success = Business.Facades.Transactions.AddTransaction(transaction);
                        if (success)
                        {
                            POS.clearDatagridView();
                            POS.ClearFields();
                            POS.ClearAmounts();
                            Helpers.MessageBoxHelper.ShowInformationDialog("Transaction has been successfully moved to pending.", "Success");
                        }
                    }
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("There is no transaction to process.");
                }
            }
            else {
                   Helpers.MessageBoxHelper.ShowErrorDialog("The current transaction is already on pending list.");
            }
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        #region Highlighter
        private void Highlight(string button) {
            var color = Color.FromArgb(93, 181, 252);
            //var color= Color.Red;
            switch (button) {
                case "Pending":
                    btnPending.BackColor = color;
                    break;
                case "PendingShow":
                    btnTransPendingShow.BackColor = color;
                    break;
                case "TransVoid":
                    btnTransVoid.BackColor = color;
                    break;
                case "CashSweep":
                    btnCashSweep.BackColor = color;
                    break;
                case "Logout":
                    btnLogout.BackColor = color;
                    break;
            }
        }
        private void ReturnColor(string button) {
            var color = Color.FromArgb(69, 144, 205);
            switch (button)
            {
                case "Pending":
                    btnPending.BackColor = color;
                    break;
                case "PendingShow":
                    btnTransPendingShow.BackColor = color;
                    break;
                case "TransVoid":
                    btnTransVoid.BackColor = color;
                    break;
                case "CashSweep":
                    btnCashSweep.BackColor = color;
                    break;
                case "Logout":
                    btnLogout.BackColor = color;
                    break;

            }
        }
            #region KeyEvent
            private void btnPending_Enter(object sender, EventArgs e)
            {
                //Highlight("Pending");
            }

            private void btnPending_Leave(object sender, EventArgs e)
            {
                //ReturnColor("Pending");

            }
            private void btnTransPendingShow_Enter(object sender, EventArgs e)
            {
                //Highlight("PendingShow");
            }

            private void btnTransPendingShow_Leave(object sender, EventArgs e)
            {
                //ReturnColor("PendingShow");
            }
            private void btnTransVoid_Enter(object sender, EventArgs e)
            {
                //Highlight("TransVoid");
            }

            private void btnTransVoid_Leave(object sender, EventArgs e)
            {
               // ReturnColor("TransVoid");
            }

            private void btnCashSweep_Enter(object sender, EventArgs e)
            {
                //Highlight("CashSweep");
            }

            private void btnCashSweep_Leave(object sender, EventArgs e)
            {
                //ReturnColor("CashSweep");
            }

            private void btnLogout_Enter(object sender, EventArgs e)
            {
                //Highlight("Logout");
            }

            private void btnLogout_Leave(object sender, EventArgs e)
            {
                //ReturnColor("Logout");
            }


        #endregion

        #endregion

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (SubForms.Main.frmCustomer frmCustomer = new SubForms.Main.frmCustomer())
            {
                if (frmCustomer.ShowDialog(this) == DialogResult.OK)
                {
                    var POS = (frmPOS)Application.OpenForms["frmPOS"];
                    POS.CustomerName = frmCustomer.fCustomerName;
                    if (POS.isCustomerRetail != frmCustomer.isCustomerRetail) {
                        POS.isCustomerRetail = frmCustomer.isCustomerRetail;
                        POS.changeDataBasedOnCustomerType();
                    }

                    this.Close();
                }
            }
        }
    }
}
