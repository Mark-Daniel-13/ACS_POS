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
    public partial class frmCashRegister : Form
    {
        #region Form Field Properties
        public Business.Enums.RegisterActivityTypes ActivityType { get; set; }
        private double TotalCashIn { get; set; }
        private double TotalSales { get; set; }
        private double TotalReturns { get; set; }
        private double TotalCashSweep { get; set; }
        private double TotalCashOut { get; set; }
        private double TotalRegisterCash { get; set; }
        #endregion

        #region Helpers
        private void LoadDenominations()
        {
            var denominations = Business.Facades.Denominations.GetAll();
            denominations.ForEach(d =>
            {
                var index = dgvDenominations.Rows.Add();
                var row = dgvDenominations.Rows[index];
                row.Cells["DenominationId"].Value = d.DenominationId;
                row.Cells["Denomination"].Value = d.Value;
                row.Cells["Quantity"].Value = 0;
                row.Cells["TotalAmount"].Value = 0;
            });
        }

        private void LoadRegisterActivities()
        {
            var registerActivities = Business.Facades.RegisterActivities.GetAllByUser(Business.Globals.UserId, Business.Globals.LoginHistoryId);
            if (registerActivities != null)
            {
                var activityGroup = from r in registerActivities
                                    group r by r.RegisterGUID into rg
                                    select new
                                    {
                                        UserId = rg.FirstOrDefault().UserId,
                                        LoginHistoryId = rg.FirstOrDefault().LoginHistoryId,
                                        RegisterActivityTypeId = rg.FirstOrDefault().RegisterActivityTypeId,
                                        TotalAmount = rg.Sum(s => s.TotalAmount),
                                        RegisterGUID = rg.FirstOrDefault().RegisterGUID,
                                        CreationDate = rg.FirstOrDefault().CreationDate
                                    };
                activityGroup.ToList().ForEach(r =>
                {
                    var index = dgvCashRegister.Rows.Add();
                    var row = dgvCashRegister.Rows[index];
                    row.Cells["Employee"].Value = $"{Business.Globals.UserFirstName} {Business.Globals.UserLastName}";
                    row.Cells["Activity"].Value = (Business.Enums.RegisterActivityTypes)r.RegisterActivityTypeId;
                    row.Cells["Total"].Value = r.TotalAmount;
                    row.Cells["ActivityDate"].Value = r.CreationDate.ToString("MM/dd/yyyy hh:mm tt");
                });
            }
        }

        private bool ValidateRegister()
        {
            if (ActivityType == Business.Enums.RegisterActivityTypes.RegisterOut || ActivityType == Business.Enums.RegisterActivityTypes.CashSweep)
            {
                TotalCashIn = 0.00;
                TotalSales = 0.00;
                TotalReturns = 0.00;
                TotalCashSweep = 0.00;
                TotalCashOut = 0.00;
                TotalRegisterCash = 0.00;

                // Total amount to Cash Out
                TotalCashOut = dgvDenominations.Rows.Cast<DataGridViewRow>()
                               .Sum(s => Convert.ToDouble(s.Cells["TotalAmount"].Value));

                // Get LoginHistory to determine the time of shift
                var loginHistory = Business.Facades.LoginHistory.GetLastLoginHistoryById(Business.Globals.LoginHistoryId);
                if (loginHistory != null)
                {
                    var loginTime = loginHistory.CreationDate;

                    // Get sales during the shift
                    var transactions = Business.Facades.Transactions.GetTransactionsOnShift(Business.Globals.UserId, loginTime);
                    if (transactions != null)
                    {

                        transactions.ForEach(transaction => {
                            var transactionDetails = Business.Facades.TransactionDetails.GetAllByTransactionId(transaction.TransactionId);
                            TotalSales += transactionDetails.Sum(s => s.TotalPrice);
                        });
                    }

                    // Get returns during the shift
                    var returns = Business.Facades.Returns.GetAllReturnsOnShift(Business.Globals.UserId, loginTime);
                    if (returns != null)
                    {
                        TotalReturns = returns.Sum(s => s.ReturnedAmount);
                    }

                    // Get total Cash IN within the shift
                    TotalCashIn = dgvCashRegister.Rows.Cast<DataGridViewRow>()
                                             .Where(w => w.Cells["Activity"].Value.ToString() == Business.Enums.RegisterActivityTypes.RegisterIn.ToString())
                                             .Sum(s => Convert.ToDouble(s.Cells["Total"].Value));

                    // Get total Cash Sweep within the shift
                    TotalCashSweep = dgvCashRegister.Rows.Cast<DataGridViewRow>()
                                             .Where(w => w.Cells["Activity"].Value.ToString() == Business.Enums.RegisterActivityTypes.CashSweep.ToString())
                                             .Sum(s => Convert.ToDouble(s.Cells["Total"].Value));
                }

                // Compute for total cash in registry
                TotalRegisterCash = (TotalCashIn + TotalSales) - (TotalReturns + TotalCashSweep);
                if (ActivityType == Business.Enums.RegisterActivityTypes.RegisterOut)
                {
                    return (TotalCashOut < TotalRegisterCash) ? false : true;
                }
                else {
                    //If it's on cashsweep check if the amount trying to sweep is less than the total amount on drawer
                    return (TotalCashOut > TotalRegisterCash) ? false : true;
                }
            }
            else
            {
                
                return true;
            }
        }
        #endregion

        #region Form Events
        public frmCashRegister()
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
                //Datagrid
                dgvDenominations.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvDenominations.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvDenominations.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                dgvCashRegister.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvCashRegister.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvCashRegister.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;

                //buttons
                btnRegister.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvCashRegister.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvCashRegister.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvCashRegister.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                dgvDenominations.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvDenominations.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvDenominations.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;

                //buttons
                btnRegister.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }

        private void frmCashRegister_Load(object sender, EventArgs e)
        {
            LoadDenominations();
            LoadRegisterActivities();
            if (ActivityType == Business.Enums.RegisterActivityTypes.RegisterIn)
            {
                btnCancel.Enabled = true;
                btnRegister.Text = "REGISTER IN";
            }
            else if (ActivityType == Business.Enums.RegisterActivityTypes.RegisterOut)
            {
                btnCancel.Enabled = true;
                btnRegister.Text = "REGISTER OUT";
            }
            else if (ActivityType == Business.Enums.RegisterActivityTypes.CashSweep)
            {
                btnCancel.Enabled = true;
                btnRegister.Text = "CASH SWEEP";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var total = dgvDenominations.Rows.Cast<DataGridViewRow>()
            .Sum(s => Convert.ToDouble(s.Cells["TotalAmount"].Value));
            //bool valid = true;
            bool valid = ValidateRegister();

            if (valid)
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog($"Are you sure you want to record a total of {total.ToString("n2")}?"))
                {
                    var registerGuid = Guid.NewGuid();
                    dgvDenominations.Rows.Cast<DataGridViewRow>().ToList().ForEach(row =>
                    {
                        var registerActivity = new Business.Models.RegisterActivities()
                        {
                            UserId = Business.Globals.UserId,
                            LoginHistoryId = Business.Globals.LoginHistoryId,
                            RegisterActivityTypeId = this.ActivityType,
                            DenominationId = (int)row.Cells["DenominationId"].Value,
                            TotalAmount = Convert.ToDouble(row.Cells["TotalAmount"].Value.ToString().Replace(",", "")),
                            RegisterGUID = registerGuid
                        };

                        Business.Facades.RegisterActivities.AddRegisterActivity(registerActivity);
                    });

                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                string errorMessage = (ActivityType == Business.Enums.RegisterActivityTypes.CashSweep) ? $"Total amount to Sweep should not be greater than {TotalRegisterCash}! Please see the breakdown below:" : $"Total amount to Cash Out should not be less than {TotalRegisterCash}! Please see the breakdown below:";
                errorMessage = errorMessage + Environment.NewLine + Environment.NewLine;
                errorMessage = errorMessage + $"Total Cash In: {TotalCashIn}" + Environment.NewLine;
                errorMessage = errorMessage + $"Total Sales: {TotalSales}" + Environment.NewLine;
                errorMessage = errorMessage + $"Total Returns: ({TotalReturns})" + Environment.NewLine;
                errorMessage = errorMessage + $"Total Cash Sweep: ({TotalCashSweep})" + Environment.NewLine;
                Helpers.MessageBoxHelper.ShowErrorDialog(errorMessage);
            }
        }

        private void dgvDenominations_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index >= 0)
            {
                var denomination = Convert.ToDouble(dgvDenominations.Rows[index].Cells["Denomination"].Value);
                var quantity = Convert.ToDouble(dgvDenominations.Rows[index].Cells["Quantity"].Value);
                dgvDenominations.Rows[index].Cells["TotalAmount"].Value = string.Format("{0:n2}",denomination * quantity);
            }
        }

        private void dgvDenominations_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var txtQuantity = e.Control as TextBox;
            if (txtQuantity != null)
            {
                txtQuantity.KeyPress += new KeyPressEventHandler(txtQuantity_Keypress);
            }
        }

        private void txtQuantity_Keypress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }
        #endregion

        private void frmCashRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            //If force closed without entering denominations
            var registerActivities = Business.Facades.RegisterActivities.GetRegisterInByUser(Business.Globals.UserId, Business.Globals.LoginHistoryId);
            if (ActivityType == Business.Enums.RegisterActivityTypes.RegisterIn && registerActivities == null) {
                Application.Exit();
            }
        }
    }
}
