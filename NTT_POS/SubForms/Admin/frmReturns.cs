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
    public partial class frmReturns : Form
    {
        private int? CurrentReturnSelectedId;
        private int fReturnStatus
        {
            get { return cmbReturnStatus.SelectedIndex+1; }
            set { cmbReturnStatus.SelectedIndex = value-1; }
        }
        //private int currentPage { get; set; }
        //private int maxPage { get; set; }
        //private int itemPerPageCount { get; set; }
        private string fReason { get { return txtReason.Text; } set { txtReason.Text = value; } }
        public void SetTheme() {
            var lightTheme = Business.Globals.LightTheme;
            BackColor = lightTheme ? Business.Globals.BackgroundThemeColorLight : Business.Globals.BackgroundThemeColor;
            //Fonts
            pnlSearch.ForeColor = lightTheme ? Business.Globals.darkLabelcolor : Business.Globals.lightLabelcolor;
            grpReviewReturn.ForeColor = lightTheme ? Business.Globals.darkLabelcolor : Business.Globals.lightLabelcolor;
            label1.ForeColor = lightTheme ? Business.Globals.darkLabelcolor : Business.Globals.lightLabelcolor;
            label4.ForeColor = lightTheme ? Business.Globals.darkLabelcolor : Business.Globals.lightLabelcolor;

            //DatagridView
            dgvReturns.ColumnHeadersDefaultCellStyle.BackColor = lightTheme ? Business.Globals.lightDgvHeadercolor : Business.Globals.darkDgvHeadercolor;
            dgvReturns.ColumnHeadersDefaultCellStyle.SelectionBackColor = lightTheme ?  Business.Globals.lightDgvHeaderSelectioncolor : Business.Globals.darkDgvHeaderSelectioncolor;
            dgvReturns.DefaultCellStyle.SelectionBackColor = lightTheme ? Business.Globals.lightDgvDefaultcellcolor : Business.Globals.darkDgvDefaultcellcolor;
            dgvReturns.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;

            //Buttons
            btnRefresh.BackColor = lightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;
            btnUpdate.BackColor = lightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;

        }
        public frmReturns()
        {
            InitializeComponent();

            //currentPage = 1;
            //itemPerPageCount = 10;

            //cmbReturnStatus.DataSource = Enum.GetValues(typeof(Business.Enums.ReturnStatus));
            cmbReturnStatus.SelectedIndex = -1;

            SetTheme();
        }
        private void LoadReturns() {
            var returns = Business.Facades.Returns.GetAllByReturnStatusFilterByDate((int)Business.Enums.ReturnStatus.ToBeReviewed,dtpDailyStartDate.Value,dtpDailyEndDate.Value);
            if (returns != null && returns.Count > 0)
            {
                var returnsVMlist = ViewModels.ReturnsViewmodel.ToViewModelList(returns);
                dgvReturns.AutoGenerateColumns = false;
                dgvReturns.DataSource = returnsVMlist;
                CurrentReturnSelectedId = returnsVMlist.FirstOrDefault().ReturnId;
                dgvReturns.ClearSelection();
            }
            else {
                dgvReturns.AutoGenerateColumns = false;
                dgvReturns.DataSource = null;
                CurrentReturnSelectedId = null;
                dgvReturns.ClearSelection();
            }
            
        }
        private void frmReturns_Load(object sender, EventArgs e)
        {
            LoadReturns();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbReturnStatus.SelectedValue.ToString());
            LoadReturns();
        }
        private void ShowMoreDetails(DataGridViewRow selectedRow) {
            CurrentReturnSelectedId = Convert.ToInt32(selectedRow.Cells["ReturnId"].Value);
            fReturnStatus = selectedRow.Cells["ReturnStatus"].Value != null ? (int)selectedRow.Cells["ReturnStatus"].Value : 0;
            fReason = selectedRow.Cells["Reason"].Value != null ? selectedRow.Cells["Reason"].Value.ToString() : "";

        }
        private void dgvReturns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = this.dgvReturns.Rows[e.RowIndex];
                ShowMoreDetails(selectedRow);
            }
        }

        private void dgvReturns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = this.dgvReturns.Rows[e.RowIndex];
                ShowMoreDetails(selectedRow);
            }
        }
        private void Clear() {
            cmbReturnStatus.SelectedIndex = -1;
            fReason = null;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvReturns.Rows.Count>0)
            {
                if (CurrentReturnSelectedId != null)
                {
                    if (fReturnStatus != (int)Business.Enums.ReturnStatus.ToBeReviewed)
                    {
                        if (Helpers.MessageBoxHelper.ShowYesNoDialog(string.Format("Are you sure you want to save selected item status to {0}?", cmbReturnStatus.SelectedItem), "Confirmation"))
                        {
                            if (Business.Facades.Returns.UpdateReturnStatus((int)CurrentReturnSelectedId, fReturnStatus))
                            {
                                Helpers.MessageBoxHelper.ShowInformationDialog("Successfully updated selected item!");

                                LoadReturns();
                                Clear();
                            }
                            else
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Something went wrong in updating selected item,Please contact the administrator!");
                            }
                        }
                    }
                    else {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Current selected action is still ToBeRevieweds, Please select an action to save!");
                    }
                }
                else{
                    Helpers.MessageBoxHelper.ShowErrorDialog("Please select an item first!");
                }
            }
        }
    }
}
