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
    public partial class frmCustomer : Form
    {
        private string fSearchString
        {
            get
            {
                return txtSearch.Text;
            }
            set
            {
                txtSearch.Text = value;
            }
        }
        public bool isCustomerRetail { get; set; }

        public string fCustomerName { get; set; }

        public frmCustomer()
        {
            InitializeComponent();
            rBtnRetail.Checked = true;
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
                dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvCustomer.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvCustomer.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //fonts
                lblSearch.ForeColor = Business.Globals.darkLabelcolor;
                rBtnWholesale.ForeColor = Business.Globals.darkLabelcolor;
                rBtnRetail.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnAdd.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
                btnCreate.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvCustomer.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvCustomer.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //font
                lblSearch.ForeColor = Business.Globals.lightLabelcolor;
                rBtnWholesale.ForeColor = Business.Globals.lightLabelcolor;
                rBtnRetail.ForeColor = Business.Globals.lightLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnAdd.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
                btnCreate.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }

        private void frmLookup_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Select();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fSearchString))
            {
                var customerList = Business.Facades.Customer.Search(fSearchString);
                dgvCustomer.AutoGenerateColumns = false;
                dgvCustomer.DataSource = customerList;
            }
        }

        private void AddAction() {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCustomer.SelectedRows[0];
                if (selectedRow != null)
                {
                    if (!isCustomerRetail)
                    {
                        using (frmWholesaleReason frmReason = new frmWholesaleReason())
                        {
                            if (frmReason.ShowDialog() == DialogResult.OK)
                            {
                                fCustomerName = selectedRow.Cells["CustomerName"].Value.ToString();
                                DialogResult = DialogResult.OK;
                            }
                        }
                    }
                    else {
                        if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to add the selected customer?", "Confirmation"))
                        {
                            fCustomerName = selectedRow.Cells["CustomerName"].Value.ToString();
                            DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("No customer selected.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAction();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void dgvInventory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCustomer.SelectedRows[0];
                if (selectedRow != null)
                {
                    AddAction();
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("No customer selected.");
            }
        }

        private void dgvInventory_KeyDown(object sender, KeyEventArgs e)
        {
            //only run if there's value on datagrid
            if (dgvCustomer.Rows.Count > 0)
            {
                if ( e.KeyCode == Keys.Enter) {

                    AddAction();
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvCustomer.Rows.Count > 0) {

                var currentIndex = dgvCustomer.CurrentCell.RowIndex;

                if (e.KeyCode == Keys.Down)
                {
                    dgvCustomer.CurrentCell = ((currentIndex + 1) == dgvCustomer.Rows.Count) ? dgvCustomer.Rows[currentIndex].Cells[1] : dgvCustomer.Rows[currentIndex + 1].Cells[1];
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dgvCustomer.CurrentCell = (currentIndex == 0) ? dgvCustomer.Rows[currentIndex].Cells[1] : dgvCustomer.Rows[currentIndex - 1].Cells[1];
                }
                else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Enter) {

                    AddAction();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (frmAddCustomer frmAddCustomer = new frmAddCustomer()) {

                if (frmAddCustomer.ShowDialog(this) == DialogResult.OK)
                {
                    fSearchString = frmAddCustomer.fName;
                    txtSearch.Focus();

                    btnSearch_Click(sender, e);
                }
            }
            
        }

        private void rBtnRetail_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnRetail.Checked)
            {
                isCustomerRetail = true;
            }
            else
            {
                isCustomerRetail = false;
            }
        }
    }
}
