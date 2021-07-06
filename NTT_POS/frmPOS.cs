using NTT_POS.SubForms.Main;
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

namespace NTT_POS
{
    public partial class frmPOS : Form
    {
        #region Form Field Properties
        private string fLoggedUser
        {
            get { return lblLoggedUserValue.Text; }
            set { lblLoggedUserValue.Text = value; }
        }
        public string fCustomerValue
        {
            get { return lblCustomerValue.Text; }
            set { lblCustomerValue.Text = value; }
        }

        private string fCurrDatetime
        {
            get { return lblCurrDatetimeValue.Text; }
            set { lblCurrDatetimeValue.Text = value; }
        }

        private string fProductBarcode
        {
            get { return txtProduct.Text; }
            set { txtProduct.Text = value; }
        }

        private string fTotalItems
        {
            get { return lblTotalItems.Text; }
            set { lblTotalItems.Text = value; }
        }

        private double fSubTotalAmount
        {
            get { return string.IsNullOrEmpty(lblSubTotalValue.Text) ? 0.00 : Helpers.TextboxHelper.ConvertToDouble(lblSubTotalValue.Text); }
            set { lblSubTotalValue.Text = value.ToString("n2", CultureInfo.InvariantCulture); }
        }

        public string fPDiscount
        {
            get { return lblPDiscountValue.Text; }
            set { lblPDiscountValue.Text = value; }
        }

        public double fDiscount
        {
            get { return string.IsNullOrEmpty(lblDiscountValue.Text) ? 0.00 : Helpers.TextboxHelper.ConvertToDouble(lblDiscountValue.Text); }
            set { lblDiscountValue.Text = value.ToString("n2", CultureInfo.InvariantCulture); }
        }

        private double fTotalAmountSM
        {
            get { return string.IsNullOrEmpty(lblTotalAmountDueSMValue.Text) ? 0.00 : Helpers.TextboxHelper.ConvertToDouble(lblTotalAmountDueSMValue.Text); }
            set { lblTotalAmountDueSMValue.Text = value.ToString("n2", CultureInfo.InvariantCulture); }
        }

        private double fTotalAmountLG
        {
            get { return string.IsNullOrEmpty(lblTotalAmountDueLG.Text) ? 0.00 : Helpers.TextboxHelper.ConvertToDouble(lblTotalAmountDueLG.Text); }
            set { lblTotalAmountDueLG.Text = value.ToString("n2", CultureInfo.InvariantCulture); }
        }

        private double fAmountTendered
        {
            get { return string.IsNullOrEmpty(txtAmountTendered.Text) ? 0.00 : Helpers.TextboxHelper.ConvertToDouble(txtAmountTendered.Text); }
            set { txtAmountTendered.Text = value.ToString("n2", CultureInfo.InvariantCulture); }
        }

        private double fChange
        {
            get { return string.IsNullOrEmpty(lblChangeValue.Text) ? 0.00 : Helpers.TextboxHelper.ConvertToDouble(lblChangeValue.Text); }
            set { lblChangeValue.Text = value.ToString("n2", CultureInfo.InvariantCulture); }
        }

        public Business.Enums.TransactionTypes fTransactionType { get; set; }

        public int pendingTransId { get; set; }
        public string CustomerName
        {
            get { return lblCustomerValue.Text; }
            set { lblCustomerValue.Text = value; }
        }
        public bool isCustomerRetail { get; set; }
        public string customerWholesaleReason { get; set; }

        #endregion

        #region Helpers
        // Avoid screen flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        // Function key shortcuts
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F1:
                    btnEditQuantity.PerformClick();
                    return true;
                case Keys.F2:
                    btnLookup.PerformClick();
                    return true;
                case Keys.F3:
                    btnReturn.PerformClick();
                    return true;
                case Keys.F4:
                    btnDiscount.PerformClick();
                    return true;
                case Keys.F5:
                    btnTransVoid.PerformClick();
                    return true;
                case Keys.F6:
                    btnItemVoid.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }


        public void clearDatagridView() {
            if (dgvTransaction.DataSource != null)
            {
                dgvTransaction.DataSource = null;
            }
            else
            {
                dgvTransaction.Rows.Clear();
            }
        }
        public void AddNewRow(int productId, double quantity, string productName, double price)
        {
                double stocksLeft = 0;
                // Total quantity
                var totalQuantity = dgvTransaction.Rows.Cast<DataGridViewRow>().Where(s=>Convert.ToInt32(s.Cells["ProductId"].Value)==productId)
                .Sum(s => Convert.ToDouble(s.Cells["Quantity"].Value));
                if (IsEnoughQuantity(productId, totalQuantity+quantity, out stocksLeft))
                {
                    var index = dgvTransaction.Rows.Add();
                    var row = dgvTransaction.Rows[index];
                    row.Cells["Quantity"].Value = quantity;
                    row.Cells["ProductId"].Value = productId;
                    row.Cells["Product"].Value = productName;
                    row.Cells["Price"].Value = price;
                    row.Cells["Amount"].Value = quantity * price;
                }
                else
                {
                    
                    Helpers.MessageBoxHelper.ShowErrorDialog($"The are {stocksLeft} remaining stocks for Product: {productName}");
                }
            
            if (dgvTransaction.Rows.Count != 0)
            {
                dgvTransaction.CurrentCell = dgvTransaction.Rows[dgvTransaction.Rows.Count - 1].Cells[0];
            }

            ComputeAmountDue();
        }

        private bool IsEnoughQuantity(int productId, double quantity, out double stocks)
        { 
            bool iSEnough = true;
            var inventory = Business.Facades.Inventories.GetByProductId(productId);
            if (inventory.Quantity < quantity)
            {
                iSEnough = false;
            }
            stocks = (double)inventory.Quantity;
            return iSEnough;
        }

        private void ComputeAmountDue()
        {
            // Sub Total
            var subTotalAmount = dgvTransaction.Rows.Cast<DataGridViewRow>()
            .Sum(s => Convert.ToDouble(s.Cells["Amount"].Value));
            fSubTotalAmount = subTotalAmount;

            // Quantity
            var totalItems = dgvTransaction.Rows.Cast<DataGridViewRow>()
                        .Sum(s => Convert.ToDouble(s.Cells["Quantity"].Value));
            fTotalItems = string.Format("{0} Item(s)", totalItems.ToString());

            // Total Amount Due
            var totalAmount = 0.00;
            if (!string.IsNullOrEmpty(fPDiscount) && GetPercentageDouble(fPDiscount) > 0)
            {
                var discountValue = (GetPercentageDouble(fPDiscount) / 100) * fSubTotalAmount;
                if (!double.IsInfinity(discountValue) && !double.IsNaN(discountValue))
                {
                    fDiscount = discountValue;
                }
                
                totalAmount = fSubTotalAmount - ((GetPercentageDouble(fPDiscount) / 100) * fSubTotalAmount);
            }
            else
            {
                var percentageValue = fDiscount / fSubTotalAmount;
                if (!double.IsInfinity(percentageValue) && !double.IsNaN(percentageValue))
                {
                    fPDiscount = GetPercentageString(percentageValue);
                }
                totalAmount = fSubTotalAmount - Convert.ToDouble(fDiscount);
            }
            fTotalAmountSM = fTotalAmountLG = totalAmount;
        }

        public void ClearFields()
        {
            fProductBarcode = string.Empty;
            txtProduct.Focus();
        }
        
        public void ClearAmounts()
        {
            fTotalItems = "0 Item(s)";
            fSubTotalAmount = 0.00;
            fPDiscount = "0.00%";
            fDiscount = 0.00;
            fTotalAmountSM = 0.00;
            fTotalAmountLG = 0.00;
            fAmountTendered = 0.00;
            fChange = 0.00;

            fCustomerValue = "None";
            isCustomerRetail = true;
            customerWholesaleReason = null;
        }

        public bool checkIfDataGridHaveValue() {
            if (dgvTransaction.Rows.Count > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public List<Business.Models.TransactionDetails> getTransactionDetails() {

            var transactionDetails = new List<Business.Models.TransactionDetails>();
            dgvTransaction.Rows.Cast<DataGridViewRow>().ToList().ForEach(row =>
            {
                var tDetail = new Business.Models.TransactionDetails()
                {
                    ProductId = (int)row.Cells["ProductId"].Value,
                    Quantity = (double)row.Cells["Quantity"].Value,
                    TotalPrice = (double)row.Cells["Amount"].Value
                };
                transactionDetails.Add(tDetail);
            });

            return transactionDetails;
        }

        private static double GetPercentageDouble(string percentage)
        {
            var retVal = 0.00;
            try
            {
                if (percentage.EndsWith("%"))
                {
                    retVal = Convert.ToDouble(percentage.Trim().Replace("%", ""));
                }
                return retVal;
            }
            catch
            {
                return 0.00;
            }
        }

        private static string GetPercentageString(double num)
        {
            try
            {
                return num.ToString("0.00%");
            }
            catch
            {
                return "0.00%";
            }
        }

        private static string GetPercentageString(string num)
        {
            try
            {
                var retVal = "0.00%";
                var percentage = GetPercentageDouble(num);
                if (percentage > 0)
                {
                    retVal = string.Format("{0}%", percentage.ToString("n2", CultureInfo.InvariantCulture));
                }
                return retVal;
            }
            catch
            {
                return "0.00%";
            }
        }
        #endregion

        #region Form Events
        public frmPOS()
        {
            InitializeComponent();
            isCustomerRetail = true;
            SetTheme();
            customerWholesaleReason = null;
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            fLoggedUser = string.Format("Logged User: {0}, {1}", Business.Globals.UserLastName, Business.Globals.UserFirstName);
            txtProduct.Focus();
            txtProduct.Select();
            if (Business.Globals.IsLoggedOut || !Business.Globals.IsRegisterIn)
            {
                Helpers.MessageBoxHelper.ShowInformationDialog("Please Register IN.");
                using (SubForms.Main.frmCashRegister frmCashRegister = new SubForms.Main.frmCashRegister())
                {
                    frmCashRegister.ActivityType = Business.Enums.RegisterActivityTypes.RegisterIn;
                    if (frmCashRegister.ShowDialog(this) == DialogResult.OK)
                    {
                        if (Business.Globals.IsLoggedOut)
                        {
                            Business.Globals.IsLoggedOut = false;
                        }
                    }
                    else {
                        //Log Out
                        var loginHistory = Business.Facades.LoginHistory.UpdateLoginHistory(Business.Globals.LoginHistoryId, true);

                        // Open Login Form
                        if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "frmLogin"))
                        {
                            var frmLogin = (frmLogin)Application.OpenForms["frmLogin"];
                            frmLogin.clearFields();
                            frmLogin.Show();
                            frmLogin.txtUsername.Focus();
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
        }
        public void changeDataBasedOnCustomerType()
        {

            //Copy the current data to a container then remove the old data to replace the new one based on customer type changes
            var transactionDetails = new List<Business.Models.TransactionDetails>();
            // Get ProductId and Quantity from Gridview
            dgvTransaction.Rows.Cast<DataGridViewRow>().ToList().ForEach(row =>
            {
                var tDetail = new Business.Models.TransactionDetails()
                {
                    ProductId = (int)row.Cells["ProductId"].Value,
                    Quantity = (double)row.Cells["Quantity"].Value,
                };
                transactionDetails.Add(tDetail);
            });
            dgvTransaction.Rows.Clear();
            

            //Add the new items based on the new customer type
            transactionDetails.ForEach(transDetail =>
            {
                var product = Business.Facades.Products.GetByProductId(transDetail.ProductId);
                var price = isCustomerRetail ? (double)product.Price.RetailPrice : (double)product.Price.WholesalePrice;
                AddNewRow(product.ProductId, transDetail.Quantity, product.Description, price);
            });
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Retail Price, Quantity and category must be set to be used on POS
            var product = Business.Facades.Products.GetByProductBarcode(fProductBarcode);
            if (product != null)
            {
                if (Business.Facades.Inventories.CheckIfComplete(product.ProductId))
                {
                    if (product != null)
                    {
                        var price = isCustomerRetail ? (double)product.Price.RetailPrice : (double)product.Price.WholesalePrice;
                        AddNewRow(product.ProductId, 1, product.Description, price);
                        ClearFields();


                        //If there's cash entered already adjust change
                        if (fAmountTendered > 0)
                        {
                            ComputeChange();
                        }
                    }
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowInformationDialog("Product info isn't complete yet. Please contact the administrator for complete product information.");
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowInformationDialog("Product info isn't complete yet. Please contact the administrator for complete product information.");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        #endregion

        #region Form Commands
        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.SelectedRows.Count > 0)
            {
                var selectedRow = dgvTransaction.SelectedRows[0];
                var productId = Convert.ToInt32(dgvTransaction.Rows[selectedRow.Index].Cells["ProductId"].Value.ToString());
                var totalQuantity = dgvTransaction.Rows.Cast<DataGridViewRow>().Where(s => Convert.ToInt32(s.Cells["ProductId"].Value) == productId)
                .Sum(s => Convert.ToDouble(s.Cells["Quantity"].Value));
                using (SubForms.Main.frmEditQuantity frmEditQuantity = new SubForms.Main.frmEditQuantity(productId, totalQuantity-1))
                {
                    if (frmEditQuantity.ShowDialog(this) == DialogResult.OK)
                    {
                        dgvTransaction.Rows[selectedRow.Index].Cells["Quantity"].Value = frmEditQuantity.fQuantity;

                        //update selected product total amount
                        var price = Convert.ToDouble(dgvTransaction.Rows[selectedRow.Index].Cells["Price"].Value);
                        dgvTransaction.Rows[selectedRow.Index].Cells["Amount"].Value = frmEditQuantity.fQuantity * price;
                        ComputeAmountDue();
                        ComputeChange();
                    }
                }
            }
           
        }
        private void btnLookup_Click(object sender, EventArgs e)
        {
            using (SubForms.Main.frmLookup frmLookup = new SubForms.Main.frmLookup())
            {
                if (frmLookup.ShowDialog(this) == DialogResult.OK)
                {
                    fProductBarcode = frmLookup.fBarcode;
                }
                txtProduct.Focus();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            using (SubForms.Main.frmReturns frmReturns = new SubForms.Main.frmReturns())
            {
                frmReturns.ShowDialog(this);
            }
            txtProduct.Focus();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            using (SubForms.Main.frmDiscount frmDiscount = new SubForms.Main.frmDiscount())
            {
                if (frmDiscount.ShowDialog(this) == DialogResult.OK)
                {
                    // Clear discount values
                    fPDiscount = "0.00%";
                    fDiscount = 0.00;
                    
                    if (frmDiscount.fDiscount.Contains("%"))
                    {
                        if (frmDiscount.fDiscount.EndsWith("%"))
                        {
                            var discount = GetPercentageString(frmDiscount.fDiscount);
                            var discountPercentage = Convert.ToDouble(discount.Replace("%", ""));
                            if (discountPercentage > 0 && discountPercentage <= 100)
                            {
                                fPDiscount = discount;
                            }
                        }
                    }
                    else
                    {
                        fDiscount = string.IsNullOrEmpty(frmDiscount.fDiscount) ? 0.00 : Helpers.TextboxHelper.ConvertToDouble(frmDiscount.fDiscount);
                    }
                    ComputeAmountDue();           
                }
                txtAmountTendered.Focus();
               
            }
        }

        private void btnTransVoid_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.Rows.Count > 0)
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to void the current transaction?", "Confirmation"))
                {
                    dgvTransaction.Rows.Clear();
                    ClearFields();
                    ClearAmounts();
                    pendingTransId=0;
                }
                txtProduct.Focus();
            }
        }

        private void btnItemVoid_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.SelectedRows.Count > 0)
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to void the selected item?", "Confirmation"))
                {
                   
                    var selectedRow = dgvTransaction.SelectedRows[0];
                    dgvTransaction.Rows.RemoveAt(selectedRow.Index);
                    if (dgvTransaction.SelectedRows.Count == 0)
                    {
                        //resetting pending Id
                        pendingTransId = 0;
                    }
                    ComputeAmountDue();
                    ComputeChange();
                }
                txtProduct.Focus();
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (dgvTransaction.Rows.Count > 0)
            {
                if (fAmountTendered == 0)
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Please input the amount tendered.");
                    txtAmountTendered.Focus();
                    txtAmountTendered.Select();
                }
                else
                {
                    if (fAmountTendered < fTotalAmountLG)
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("The amount tendered is not enough for purchased items.");
                        txtAmountTendered.Focus();
                        txtAmountTendered.Select();
                    }
                    else
                    {
                        if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to process the current transaction?", "Confirmation"))
                        {
                            //check if the transaction is new or pending
                            if (pendingTransId != 0)
                            {
                                fTransactionType = Business.Enums.TransactionTypes.Pending;
                            }
                            else
                            {
                                fTransactionType = Business.Enums.TransactionTypes.Sales;
                            }
                           
                            var productIdQtyList = new List<KeyValuePair<int, double>>();

                            // Generate Receipt Number
                            var receiptNumber = Business.Helpers.Receipt.GenerateReceiptNumber();
                            var customer = fCustomerValue != "None" ? Business.Facades.Customer.GetByName(fCustomerValue) : null;

                            // Create Transaction model
                            var transaction = new Business.Models.Transactions()
                            {
                                UserId = Business.Globals.UserId,
                                ReceiptNumber = receiptNumber,
                                CustomerId = customer?.CustomerId,
                                TransactionTypeId = fTransactionType,
                                DiscountPercentage = !string.IsNullOrEmpty(fPDiscount) ? Convert.ToDouble(fPDiscount.Replace("%", "")) : 0.00,
                                DiscountAmount = fDiscount,
                                PaymentAmount = fAmountTendered,
                                isRetail = isCustomerRetail,
                                WholesaleReason = customerWholesaleReason,
                                CreationDate = DateTime.Now,
                               
                            };

                            var transactionDetails = new List<Business.Models.TransactionDetails>();

                            // Get ProductId and Quantity from Gridview
                            dgvTransaction.Rows.Cast<DataGridViewRow>().ToList().ForEach(row =>
                            {
                                //productIdQtyList.Add(new KeyValuePair<int, double>((int)row.Cells["ProductId"].Value, (double)row.Cells["Quantity"].Value));
                                var tDetail = new Business.Models.TransactionDetails()
                                {
                                    ProductId = (int)row.Cells["ProductId"].Value,
                                    Quantity = (double)row.Cells["Quantity"].Value,
                                    TotalPrice = (double)row.Cells["Amount"].Value
                                };
                                transactionDetails.Add(tDetail);
                            });

                            // Add to Transactions table and update Inventory stocks
                            transaction.TransactionDetails = transactionDetails;
                            //var success = true;
                            var success = false;
                            if (pendingTransId != 0)
                            {
                                success = Business.Facades.Transactions.AddTransaction(transaction, pendingTransId);
                            }
                            else
                            {
                                success = Business.Facades.Transactions.AddTransaction(transaction);
                            }


                            if (success)
                            {
                                dgvTransaction.Rows.Clear();
                                ClearFields();
                                ClearAmounts();
                                pendingTransId = 0;

                                if (Business.Helpers.AppSettings.GetSetting("PrintStatus") == "ON")
                                {
                                    // Print Receipt
                                    if (Helpers.MessageBoxHelper.ShowYesNoDialog("Transaction has been successfully processed. Print Receipt?", "Success"))
                                    {
                                        var transactionViewModel = ViewModels.TransactionViewModel.ToViewModel(transaction);
                                        var transactionDetailsViewModel = ViewModels.TransactionDetailsViewModel.ToViewModelListGrouped(transactionDetails);
                                        //bool isPrint = Helpers.PrintSilent.Print(transactionViewModel, transactionDetailsViewModel);
                                        var print = new Helpers.SilentPrint();
                                        var branchDetail = Business.Facades.CompanyBranchDetails.GetAll().FirstOrDefault();
                                        bool isPrint = print.Print(transactionViewModel, transactionDetailsViewModel,branchDetail,false);
                                    }
                                }
                                else {
                                    Helpers.MessageBoxHelper.ShowInformationDialog("Transaction has been successfully processed.", "Success");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("There is no transaction to process.");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            using (SubForms.Main.frmMenu frmMenu = new SubForms.Main.frmMenu())
            {
                frmMenu.ShowDialog(this);
            }
        }

        private void txtAmountTendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }
        public void ComputeChange() {
            fChange = fAmountTendered - fTotalAmountSM;
        }
        private void txtAmountTendered_TextChanged(object sender, EventArgs e)
        {
            ComputeChange();
        }
        #endregion

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            fCurrDatetime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
        }

        private void frmPOS_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Business.Globals.IsLoggedOut)
            {
                Application.Exit();
            }
        }

        private void lblCustomerValue_MouseEnter(object sender, EventArgs e)
        {
            lblCustomerValue.ForeColor = Color.FromArgb(0, 149, 255);
        }

        private void lblCustomerValue_MouseLeave(object sender, EventArgs e)
        {

            lblCustomerValue.ForeColor = Business.Globals.LightTheme ? Business.Globals.darkLabelcolor : Business.Globals.lightLabelcolor;

        }

        private void lblCustomerValue_Click(object sender, EventArgs e)
        {
            lblCustomerValue.Text = "None";
            isCustomerRetail = true;
            customerWholesaleReason = null;
        }


        private void txtAmountTendered_MouseClick(object sender, MouseEventArgs e)
        {
            txtAmountTendered.SelectAll();
        }

        private void SetTheme() {
            if (Business.Globals.LightTheme)
            {
                this.BackColor = Business.Globals.BackgroundThemeColorLight;
                btnTheme.BackColor = Business.Globals.lightButtoncolor;
                btnTheme.Text = "Switch to: Dark Theme";

                //Dgv
                dgvTransaction.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvTransaction.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvTransaction.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //Buttons
                btnEditQuantity.BackColor = Business.Globals.lightButtoncolor;
                btnLookup.BackColor = Business.Globals.lightButtoncolor;
                btnReturn.BackColor = Business.Globals.lightButtoncolor;
                btnDiscount.BackColor = Business.Globals.lightButtoncolor;
                btnTransVoid.BackColor = Business.Globals.lightButtoncolor;
                btnItemVoid.BackColor = Business.Globals.lightButtoncolor;
                btnAddItem.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
                btnProcess.BackColor = Business.Globals.lightButtoncolor;
                btnMenu.BackColor = Business.Globals.lightButtoncolor;
                //Label bg
                lblTotalAmountDueLG.BackColor = Business.Globals.lightLabelbackground;
          
                //fore color
                lblAmountDue.ForeColor = Business.Globals.darkLabelcolor;
                lblTotalItems.ForeColor = Business.Globals.darkLabelcolor;
                lblProduct.ForeColor = Business.Globals.darkLabelcolor;
                lblSubTotal.ForeColor = Business.Globals.darkLabelcolor;
                lblSubTotalValue.ForeColor = Business.Globals.darkLabelcolor;
                lblDiscount.ForeColor = Business.Globals.darkLabelcolor;
                lblPDiscountValue.ForeColor = Business.Globals.darkLabelcolor;
                lblDiscountValue.ForeColor = Business.Globals.darkLabelcolor;
                lblTotalAmountDueSM.ForeColor = Business.Globals.darkLabelcolor;
                lblTotalAmountDueSMValue.ForeColor = Business.Globals.darkLabelcolor;
                lblCash.ForeColor = Business.Globals.darkLabelcolor;
                lblChange.ForeColor = Business.Globals.darkLabelcolor;
                lblChangeValue.ForeColor = Business.Globals.darkLabelcolor;
                lblCustomer.ForeColor = Business.Globals.darkLabelcolor;
                lblCustomerValue.ForeColor = Business.Globals.darkLabelcolor;
                lblLoggedUserValue.ForeColor = Business.Globals.darkLabelcolor;
                lblCurrDatetimeValue.ForeColor = Business.Globals.darkLabelcolor;
                //lines
                pnlBreaker1.BackColor = Business.Globals.lightPanellines;
                pnlBreaker2.BackColor = Business.Globals.lightPanellines;
                pnlBreaker3.BackColor = Business.Globals.lightPanellines;
                pnlBreaker4.BackColor = Business.Globals.lightPanellines;
                pnlBreaker5.BackColor = Business.Globals.lightPanellines;
            }
            else
            {

                this.BackColor = Business.Globals.BackgroundThemeColor;
                btnTheme.BackColor = Business.Globals.darkButtoncolor;
                btnTheme.Text = "Switch to: Light Theme";

                //Dgv
                dgvTransaction.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvTransaction.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvTransaction.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //Buttons
                btnEditQuantity.BackColor = Business.Globals.darkButtoncolor;
                btnLookup.BackColor = Business.Globals.darkButtoncolor; ;
                btnReturn.BackColor = Business.Globals.darkButtoncolor;
                btnDiscount.BackColor = Business.Globals.darkButtoncolor;
                btnTransVoid.BackColor = Business.Globals.darkButtoncolor;
                btnItemVoid.BackColor = Business.Globals.darkButtoncolor;
                btnAddItem.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
                btnProcess.BackColor = Business.Globals.darkButtoncolor;
                btnMenu.BackColor = Business.Globals.darkButtoncolor;
                //Label bg
                lblTotalAmountDueLG.BackColor = Business.Globals.darkLabelbackground;
                //fore color
                lblAmountDue.ForeColor = Business.Globals.lightLabelcolor;
                lblTotalItems.ForeColor = Business.Globals.lightLabelcolor;
                lblProduct.ForeColor = Business.Globals.lightLabelcolor;
                lblSubTotal.ForeColor = Business.Globals.lightLabelcolor;
                lblSubTotalValue.ForeColor = Business.Globals.lightLabelcolor;
                lblDiscount.ForeColor = Business.Globals.lightLabelcolor;
                lblPDiscountValue.ForeColor = Business.Globals.lightLabelcolor;
                lblDiscountValue.ForeColor = Business.Globals.lightLabelcolor;
                lblTotalAmountDueSM.ForeColor = Business.Globals.lightLabelcolor;
                lblTotalAmountDueSMValue.ForeColor = Business.Globals.lightLabelcolor;
                lblCash.ForeColor = Business.Globals.lightLabelcolor;
                lblChange.ForeColor = Business.Globals.lightLabelcolor;
                lblChangeValue.ForeColor = Business.Globals.lightLabelcolor;
                lblCustomer.ForeColor = Business.Globals.lightLabelcolor;
                lblCustomerValue.ForeColor = Business.Globals.lightLabelcolor;
                lblLoggedUserValue.ForeColor = Business.Globals.lightLabelcolor;
                lblCurrDatetimeValue.ForeColor = Business.Globals.lightLabelcolor;
                //lines
                pnlBreaker1.BackColor = Business.Globals.darkPanellines;
                pnlBreaker2.BackColor = Business.Globals.darkPanellines;
                pnlBreaker3.BackColor = Business.Globals.darkPanellines;
                pnlBreaker4.BackColor = Business.Globals.darkPanellines;
                pnlBreaker5.BackColor = Business.Globals.darkPanellines;
            }
        }
        private void BtnTheme_Click(object sender, EventArgs e)
        {
            Business.Globals.LightTheme = !Business.Globals.LightTheme;
            //update app.config values LightTheme
            if (Business.Globals.LightTheme)
            {
                Business.Helpers.AppSettings.SetSetting("LightTheme", "true");
            }
            else
            {
                Business.Helpers.AppSettings.SetSetting("LightTheme", "false");
            }

            //reload child form and their siblings if any
            var subFormsList = Application.OpenForms.Cast<Form>().ToList();
            subFormsList.ForEach(form =>
            {
                RefreshChildForm(form.Name);
            });
        }
        private void RefreshChildForm(string formName)
        {
            switch (formName)
            {
                case "frmLogin":
                    ((frmLogin)Application.OpenForms[formName]).SetTheme();
                    break;
                case "frmPOS":
                    ((frmPOS)Application.OpenForms[formName]).SetTheme();
                    break;
                default:
                    break;
            }

        }

        private void lblTotalAmountDueSMValue_TextChanged(object sender, EventArgs e)
        {
            ComputeChange();
        }
    }
}
