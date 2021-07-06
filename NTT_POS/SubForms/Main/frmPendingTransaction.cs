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
    public partial class frmPendingTransaction : Form
    {
        public frmPendingTransaction()
        {
            InitializeComponent();
            ActiveControl = dgvTransactions;
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

                dgvTransDetails.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvTransDetails.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvTransDetails.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //buttons
                btnRemove.BackColor = Business.Globals.lightButtoncolor;
                btnProcess.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvTransactions.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvTransactions.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;

                dgvTransDetails.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvTransDetails.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvTransDetails.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;

                //buttons
                btnProcess.BackColor = Business.Globals.darkButtoncolor;
                btnRemove.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }

        private void frmPendingTransaction_Load(object sender, EventArgs e)
        {
            loadPendingTransactions();

        }

        private void loadPendingTransactions() {
            var trans = Business.Facades.Transactions.GetAllPendingTransactions();
            if (trans != null)
            {
                var transVMList = ViewModels.TransactionViewModel.ToViewModelList(trans);
                dgvTransactions.AutoGenerateColumns = false;
                dgvTransactions.DataSource = transVMList;

            }
        }


        private void loadPendingTransactionDetails(int transID)
        {
            var transdetails = Business.Facades.TransactionDetails.GetAllByTransactionId(transID);
            if (transdetails != null)
            {
                var transdetailsVMList = ViewModels.TransactionDetailsViewModel.ToViewModelList(transdetails);
                dgvTransDetails.AutoGenerateColumns = false;
                dgvTransDetails.DataSource = transdetailsVMList;

                dgvTransDetails.ClearSelection();
            }
        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var transID = (int)dgvTransactions.Rows[e.RowIndex].Cells["TransactionId"].Value;
                loadPendingTransactionDetails(transID);
            }
        }
        private void ProcessClick() {
            if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to process the selected pending transaction?", "Confirmation"))
            {
                var transID = (int)dgvTransactions.Rows[dgvTransactions.CurrentCell.RowIndex].Cells["TransactionId"].Value;

                //retrieve the pending data's using transactionID then place it on the current open form POS
                var POS = (frmPOS)Application.OpenForms["frmPOS"];
                var frmMenu = (frmMenu)Application.OpenForms["frmMenu"];

                //checks if form is open
                //bool formOpen = Application.OpenForms.Cast<Form>().Any(form => form.Name == "frmPOS");
                var transaction = Business.Facades.Transactions.GetTransactionsById(transID);
                var customer = transaction.CustomerId != null ? Business.Facades.Customer.GetById((int)transaction.CustomerId) : null;
                var transdetails = Business.Facades.TransactionDetails.GetAllByTransactionId(transID);
                var transdetailsVMList = ViewModels.TransactionDetailsViewModel.ToViewModelList(transdetails);

                POS.clearDatagridView();
                POS.pendingTransId = transID;
                POS.fCustomerValue = transaction.CustomerId != null ? customer.CustomerName : "None";

                transdetailsVMList.ForEach(datarow =>
                {
                    POS.AddNewRow(datarow.ProductId, datarow.Quantity, datarow.ProductName, datarow.RetailPrice);
                });

                //closes the form pending transaction and the menu then take the selected data to frmPOS for processing
                this.Close();
                frmMenu.Close();
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.Rows.Count > 0)
            {
                ProcessClick();
            }
            else {
                Helpers.MessageBoxHelper.ShowErrorDialog("The list is currently empty!", "Invalid item selection");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.Rows.Count > 0)
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to remove the selected pending transaction?", "Confirmation"))
                {
                    var transID = (int)dgvTransactions.Rows[dgvTransactions.CurrentCell.RowIndex].Cells["TransactionId"].Value;
                    var POS = (frmPOS)Application.OpenForms["frmPOS"];
                    if (transID != POS.pendingTransId)
                    {
                        if (Business.Facades.Transactions.RemovePendingTransactionByID(transID))
                        {
                            Helpers.DataGridViewHelper.ClearDatagrid(dgvTransDetails);
                            Helpers.DataGridViewHelper.ClearDatagrid(dgvTransactions);
                            loadPendingTransactions();

                        }
                    }
                    else {
                        Helpers.MessageBoxHelper.ShowErrorDialog("The selected item is currently used on the process!", "Invalid item selection");
                    }
                }
            }
            else {
                Helpers.MessageBoxHelper.ShowErrorDialog("The list is currently empty!", "Invalid item selection");
            }

        }

        private void dgvTransactions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProcessClick();
        }

        private void dgvTransactions_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var transID = (int)dgvTransactions.Rows[e.RowIndex].Cells["TransactionId"].Value;
                loadPendingTransactionDetails(transID);
            }
        }
    }
}
