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
    public partial class frmLookup : Form
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

        public string fBarcode { get; set; }

        public frmLookup()
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
                dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvInventory.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvInventory.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //fonts
                lblSearch.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnAdd.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvInventory.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvInventory.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvInventory.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //font
                lblSearch.ForeColor = Business.Globals.lightLabelcolor;
                //Buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnAdd.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
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
                var product = Business.Facades.Inventories.Search(fSearchString);
                dgvInventory.AutoGenerateColumns = false;
                dgvInventory.DataSource = product;

            }
        }

        private void AddAction() {
            if (dgvInventory.SelectedRows.Count > 0)
            {
                var selectedRow = dgvInventory.SelectedRows[0];
                if (selectedRow != null)
                {
                    if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to add the selected product?", "Confirmation"))
                    {
                        fBarcode = selectedRow.Cells["Barcode"].Value.ToString();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("No product selected.");
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
            if (dgvInventory.SelectedRows.Count > 0)
            {
                var selectedRow = dgvInventory.SelectedRows[0];
                if (selectedRow != null)
                {
                    if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to add the selected product?", "Confirmation"))
                    {
                        fBarcode = selectedRow.Cells["Barcode"].Value.ToString();
                        DialogResult = DialogResult.OK;
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("No product selected.");
            }
        }

        private void dgvInventory_KeyDown(object sender, KeyEventArgs e)
        {
            //only run if there's value on datagrid
            if (dgvInventory.Rows.Count > 0)
            {
                if ( e.KeyCode == Keys.Enter) {

                    AddAction();
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvInventory.Rows.Count > 0) {

                var currentIndex = dgvInventory.CurrentCell.RowIndex;

                if (e.KeyCode == Keys.Down)
                {
                    dgvInventory.CurrentCell = ((currentIndex + 1) == dgvInventory.Rows.Count) ? dgvInventory.Rows[currentIndex].Cells[4] : dgvInventory.Rows[currentIndex + 1].Cells[4];
                }
                else if (e.KeyCode == Keys.Up)
                {
                    dgvInventory.CurrentCell = (currentIndex == 0) ? dgvInventory.Rows[currentIndex].Cells[4] : dgvInventory.Rows[currentIndex - 1].Cells[4];
                }
                else if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Enter) {

                    AddAction();
                }
            }
        }
    }
}
