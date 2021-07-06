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
    public partial class frmReturns : Form
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
                    dgvTransactions.AutoGenerateColumns = false;
                    dgvTransactions.DataSource = transactionDetailVMList;
                }
                else
                {
                    dgvTransactions.DataSource = null;
                    dgvTransactions.Rows.Clear();
                }
            }
        }
        #endregion

        #region Form Events
        public frmReturns()
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
                dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvTransactions.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvTransactions.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //fonts
                lblReceiptNumber.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnReturn.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvTransactions.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvTransactions.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //font
                lblReceiptNumber.ForeColor = Business.Globals.lightLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnReturn.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }
        private void frmReturns_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (fReceiptNumber.Length>1 && fReceiptNumber!="0")
            {
                LoadTransactionDetails();
            }
        }

        private void ReturnAction() {

            if (dgvTransactions.SelectedRows.Count > 0)
            {
                var selectedRow = dgvTransactions.SelectedRows[0];
                if (selectedRow != null)
                {
                    fProductQuantity = Convert.ToDouble(selectedRow.Cells["Quantity"].Value);
                    fReturnedQuantity = Convert.ToDouble(selectedRow.Cells["ReturnedQuantity"].Value);
                    if (fProductQuantity > fReturnedQuantity)
                    {
                        using (SubForms.Main.frmReturnDetails frmReturnDetails = new SubForms.Main.frmReturnDetails())
                        {
                            frmReturnDetails.fTransactionDetailId = Convert.ToInt32(selectedRow.Cells["TransactionDetailId"].Value);
                            frmReturnDetails.fProductId = Convert.ToInt32(selectedRow.Cells["ProductId"].Value);
                            frmReturnDetails.fProductName = selectedRow.Cells["ProductName"].Value.ToString();
                            frmReturnDetails.fQuantity = frmReturnDetails.fProductQuantity = this.fProductQuantity;
                            frmReturnDetails.fReturnedQuantity = this.fReturnedQuantity;
                            frmReturnDetails.fReturnedAmount = Convert.ToDouble(selectedRow.Cells["TotalPrice"].Value);
                            frmReturnDetails.fProductPrice = Convert.ToDouble(selectedRow.Cells["TotalPrice"].Value) / Convert.ToDouble(selectedRow.Cells["Quantity"].Value);

                            // Attach closing event
                            frmReturnDetails.FormClosed += new FormClosedEventHandler(frmReturnDetails_FormClosed);

                            frmReturnDetails.ShowDialog(this);
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog($"Return quantity can't be higher than the purchased quantity. Based from our records, the purchased quantity was {fProductQuantity} and {fReturnedQuantity} item/s has already been returned.");
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("No product selected.");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnAction();
        }

        // frmReturnDetails Closing event handler
        private void frmReturnDetails_FormClosed(object sender, EventArgs e)
        {
            LoadTransactionDetails();
            // Close all forms
            var formsList = Application.OpenForms.Cast<Form>().Where(w => w.Name != "frmPOS" && w.Name !="frmReturns" && w.Name != "frmLogin").ToList();
            formsList.ForEach(form =>
            {
                form.Close();
            });
        }

        #endregion

        #region EventHandlers

        private void txtReceiptNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvTransactions.Rows.Count > 0)
            {

                var currentIndex = dgvTransactions.CurrentCell.RowIndex;

                if (e.KeyCode == Keys.Down)
                {
                    dgvTransactions.CurrentCell = ((currentIndex + 1) == dgvTransactions.Rows.Count) ? dgvTransactions.Rows[currentIndex].Cells[4] : dgvTransactions.Rows[currentIndex + 1].Cells[4];
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dgvTransactions.CurrentCell = (currentIndex == 0) ? dgvTransactions.Rows[currentIndex].Cells[4] : dgvTransactions.Rows[currentIndex - 1].Cells[4];
                }
                else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Enter)
                { 
                    ReturnAction();
                }
            }
        }

        private void dgvTransactions_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvTransactions.Rows.Count > 0)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ReturnAction();
                }
            }
        }


        #endregion

        private void TxtReceiptNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }
    }
}
