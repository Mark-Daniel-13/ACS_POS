using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.SubForms.Admin
{
    public partial class frmSales : Form
    {
        private string TransType { get; set; }
        //Paging
        private int currentPage { get; set; }
        private int maxPage { get; set; }
        private int itemPerPageCount { get; set; }
        public frmSales()
        {
            InitializeComponent();

            currentPage = 1;
            itemPerPageCount = 10;
            cbRetail.Checked = true;
            cbWholeSale.Checked = true;

            //Set theme
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
                //fonts
                label2.ForeColor = Business.Globals.darkLabelcolor;
                label3.ForeColor = Business.Globals.darkLabelcolor;
                tblpnlTransType.ForeColor = Business.Globals.darkLabelcolor;
                grpTransaction.ForeColor = Business.Globals.darkLabelcolor;
                grpDetails.ForeColor = Business.Globals.darkLabelcolor;
                lblrowcout.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnPrint.BackColor = Business.Globals.lightButtoncolor;
                btnRefresh.BackColor = Business.Globals.lightButtoncolor;
                btnNext.BackColor = Business.Globals.lightButtoncolor;
                btnPrev.BackColor = Business.Globals.lightButtoncolor;

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
                //font
                label2.ForeColor = Business.Globals.lightLabelcolor;
                label3.ForeColor = Business.Globals.lightLabelcolor;
                tblpnlTransType.ForeColor = Business.Globals.lightLabelcolor;
                grpTransaction.ForeColor = Business.Globals.lightLabelcolor;
                grpDetails.ForeColor = Business.Globals.lightLabelcolor;
                lblrowcout.ForeColor = Business.Globals.lightLabelcolor;
                dgvTransDetails.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
                dgvTransactions.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
                //Buttons
                btnPrint.BackColor = Business.Globals.darkButtoncolor;
                btnRefresh.BackColor = Business.Globals.darkButtoncolor;
                btnNext.BackColor = Business.Globals.darkButtoncolor;
                btnPrev.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            dtpDailyStartDate.Value = DateTime.Now.AddDays(-7);
            dtpDailyEndDate.Value = DateTime.Now;

            LoadSales();
        }
        private void loadTransactionDetails(int transID)
        {
            var transdetails = Business.Facades.TransactionDetails.GetAllByTransactionId(transID);
            if (transdetails != null)
            {
                var transdetailsVMList = ViewModels.TransactionDetailsViewModel.ToViewModelListGrouped(transdetails);
                dgvTransDetails.AutoGenerateColumns = false;
                dgvTransDetails.DataSource = transdetailsVMList;

                dgvTransDetails.ClearSelection();
            }
        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var transID = (int)dgvTransactions.Rows[e.RowIndex].Cells["TransactionId"].Value;
                loadTransactionDetails(transID);
            }
        }

        private void dgvTransactions_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var transID = (int)dgvTransactions.Rows[e.RowIndex].Cells["TransactionId"].Value;
                loadTransactionDetails(transID);
            }
        }
        private void LoadSales()
        {
  
            maxPage = Helpers.Paging.GetTotalPage(Business.Facades.Transactions.GetTransactionsOnRangeCount(TransType, dtpDailyStartDate.Value, dtpDailyEndDate.Value), itemPerPageCount);
            var trans = Business.Facades.Transactions.GetTransactionsOnRange(TransType,dtpDailyStartDate.Value, dtpDailyEndDate.Value, itemPerPageCount, currentPage);
            var rowCount = 0;
            if (trans != null)
            {
                var transVMList = ViewModels.TransactionViewModel.ToViewModelList(trans).OrderByDescending(o => o.CreationDate).ToList();
                rowCount = transVMList.Count;
                dgvTransactions.AutoGenerateColumns = false;
                dgvTransactions.DataSource = transVMList;
                lblPage.Text = string.Format("/{0}", maxPage);
                tbCurrentPage.Text = maxPage != 0 ? currentPage.ToString() : maxPage.ToString();
            }
            else {
                lblPage.Text = string.Format("/{0}", maxPage);
                tbCurrentPage.Text = maxPage != 0 ? currentPage.ToString() : maxPage.ToString();
                dgvTransactions.DataSource = null;
            }
            lblrowcout.Text = rowCount.ToString() + " record(s) found";
        }
        private void ChangeDgvPage(bool isNext = true)
        {
            if (isNext)
            {
                currentPage++;
                LoadSales();
            }
            else
            {
                currentPage--;
                LoadSales();
            }
        }
        private void dtpDailyStartDate_ValueChanged(object sender, EventArgs e)
        {
            Helpers.DataGridViewHelper.ClearDatagrid(dgvTransactions);
            Helpers.DataGridViewHelper.ClearDatagrid(dgvTransDetails);
            LoadSales();
        }

        private void dtpDailyEndDate_ValueChanged(object sender, EventArgs e)
        {
            Helpers.DataGridViewHelper.ClearDatagrid(dgvTransactions);
            Helpers.DataGridViewHelper.ClearDatagrid(dgvTransDetails);
            LoadSales();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvTransactions.SelectedRows[0];
            if (selectedRow != null)
            {
                var transID = (int)dgvTransactions.Rows[dgvTransactions.CurrentCell.RowIndex].Cells["TransactionId"].Value;
                var transModel = Business.Facades.Transactions.GetTransactionsById(transID);
                var transViewModel = ViewModels.TransactionViewModel.ToViewModel(transModel);
                var transDetailsModel = ViewModels.TransactionDetailsViewModel.ToViewModelListGrouped(Business.Facades.TransactionDetails.GetAllByTransactionId(transModel.TransactionId));

                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to print the receipt?"))
                {
                    var print = new Helpers.SilentPrint();
                    var branchDetail = Business.Facades.CompanyBranchDetails.GetAll().FirstOrDefault();
                    bool isPrint = print.Print(transViewModel, transDetailsModel,branchDetail,false);
                }
            }
        }
        private void setTransType() {
            if (cbRetail.CheckState == CheckState.Checked && cbWholeSale.CheckState == CheckState.Checked)
            {
                TransType = "All";
            }
            else if (cbRetail.CheckState == CheckState.Checked)
            {
                TransType = "Retail";
            }
            else if (cbWholeSale.CheckState == CheckState.Checked)
            {
                TransType = "Wholesale";
            }
            else {
                TransType = "None";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Helpers.DataGridViewHelper.ClearDatagrid(dgvTransactions);
            Helpers.DataGridViewHelper.ClearDatagrid(dgvTransDetails);
            setTransType();
            LoadSales();
        }

        private void cbRetail_CheckStateChanged(object sender, EventArgs e)
        {
            setTransType();
            LoadSales();
        }

        private void cbWholeSale_CheckedChanged(object sender, EventArgs e)
        {
            setTransType();
            LoadSales();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            var prePage = currentPage - 1;
            if (prePage-- > 0)
            {

                ChangeDgvPage(false);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPage)
            {
                ChangeDgvPage(true);
            }
        }
        private void moveToPage(int pageNumber)
        {
            currentPage = pageNumber;
            LoadSales();
        }

        private void tbCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHandler(sender, e);
        }

        private void tbCurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int inputPage;
                    inputPage = Convert.ToInt32(tbCurrentPage.Text);
                    if (inputPage > 0)
                    {
                        moveToPage(inputPage);
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Please enter valid page number");
                    }
                }
                catch
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Please enter valid page number");
                }


            }
        }
    }
}
