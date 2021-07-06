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
    public partial class frmTransactionVoid : Form
    {
        #region Form Field Properties
        private string fReceiptNumber
        {
            get { return txtReceiptNumber.Text; }
            set { txtReceiptNumber.Text = value; }
        }

        public int fProductId { get; set; }
        public string fProductName { get; set; }
        public double fProductQuantity { get; set; }
        public double fReturnedQuantity { get; set; }
        public double fProductPrice { get; set; }
        #endregion

        #region Helpers
        private void LoadTransactionDetails()
        {
            if (!string.IsNullOrEmpty(fReceiptNumber))
            {
                var transactionDetails = Business.Facades.TransactionDetails.GetByReceiptNumber(fReceiptNumber);
                if (transactionDetails != null)
                {
                    var transactionDetailVMList = ViewModels.TransactionDetailsViewModel.ToViewModelList(transactionDetails);
                    dgvReturns.AutoGenerateColumns = false;
                    dgvReturns.DataSource = transactionDetailVMList;
                }
                else
                {
                    dgvReturns.DataSource = null;
                    dgvReturns.Rows.Clear();
                }
            }
        }
        #endregion

        #region Form Events
        public frmTransactionVoid()
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
                dgvReturns.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvReturns.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvReturns.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //fonts
                lblReceiptNumber.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnVoid.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvReturns.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvReturns.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvReturns.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //font
                lblReceiptNumber.ForeColor = Business.Globals.lightLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnVoid.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (fReceiptNumber.Length > 1 && fReceiptNumber != "0")
            {
                LoadTransactionDetails();
            }
        }
        private void VoidTransaction() {
            if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to void the selected transaction?", "Confirmation"))
            {
                if (!string.IsNullOrEmpty(fReceiptNumber))
                {
                    var success = Business.Facades.Transactions.VoidTransaction(fReceiptNumber, Business.Globals.UserId);
                    if (success)
                    {
                        // Close all forms
                        var formsList = Application.OpenForms.Cast<Form>().Where(w => w.Name != "frmPOS").ToList();
                        formsList.ForEach(form =>
                        {
                            form.Hide();
                        });
                        Helpers.MessageBoxHelper.ShowInformationDialog($"Transaction for receipt number {fReceiptNumber} has been voided.");
                    }
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Please input the receipt number.");
                }
            }
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            VoidTransaction();
        }

        private void txtReceiptNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvReturns.Rows.Count > 0)
            {

                var currentIndex = dgvReturns.CurrentCell.RowIndex;

                if (e.KeyCode == Keys.Down)
                {
                    dgvReturns.CurrentCell = ((currentIndex + 1) == dgvReturns.Rows.Count) ? dgvReturns.Rows[currentIndex].Cells[4] : dgvReturns.Rows[currentIndex + 1].Cells[4];
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dgvReturns.CurrentCell = (currentIndex == 0) ? dgvReturns.Rows[currentIndex].Cells[4] : dgvReturns.Rows[currentIndex - 1].Cells[4];
                }
                else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Enter)
                {
                    VoidTransaction();
                }
            }
        }
    }
}
