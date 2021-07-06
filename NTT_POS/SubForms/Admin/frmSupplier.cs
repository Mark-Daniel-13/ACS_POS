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
    public partial class frmSupplier : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        #region Form Field Properties
        private string fUserId
        {
            get { return lblUserIdValue.Text; }
            set { lblUserIdValue.Text = value; }
        }

        private string fName
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        private string fAddress
        {
            get { return txtAddress.Text; }
            set { txtAddress.Text = value; }
        }

        private string fContact
        {
            get { return txtContact.Text; }
            set { txtContact.Text = value; }
        }

        private string fTinNo
        {
            get { return txtTinNo.Text; }
            set { txtTinNo.Text = value; }
        }
        
        private string fEmail
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        private string fRemarks
        {
            get { return txtRemarks.Text; }
            set { txtRemarks.Text = value; }
        }
      
        private string fSearchText
        {
            get { return txtUserSearch.Text; }
            set { txtUserSearch.Text = value; }
        }
        #endregion

        #region Helpers
        private void LoadSuppliers()
        {
            var supplierLists = Business.Facades.Supplier.GetAll();
            if (supplierLists != null)
            {
                dgvSuppliers.AutoGenerateColumns = false;
                dgvSuppliers.DataSource = supplierLists;
            }
        }

        private void SearchSuppliers()
        {
            var supplierLists = Business.Facades.Supplier.Search(fSearchText);
            if (supplierLists != null)
            {
                dgvSuppliers.AutoGenerateColumns = false;
                dgvSuppliers.DataSource = supplierLists;
            }
        }

        private void ClearFields()
        {
            fUserId = string.Empty;
            fName = string.Empty;
            fAddress = string.Empty;
            fTinNo = string.Empty;
            fContact = string.Empty;
            fEmail = string.Empty;
            fRemarks = string.Empty;
        }

        private bool CheckFields(bool checkId = false)
        {
            bool valid = false;
            if (!string.IsNullOrEmpty(fName))
                //&& !string.IsNullOrEmpty (fContact))
            {
                if (checkId)
                {
                    if (!string.IsNullOrEmpty(fUserId))
                    {
                        //if there's value
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(fUserId))
                    {
                        //if there's value
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                }
            }
            return valid;
        }
        #endregion

        #region Form Events
        public frmSupplier()
        {
            InitializeComponent();
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
                dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvSuppliers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvSuppliers.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //Panel
                infopnl.BackColor = Business.Globals.BackgroundThemeColorLight;
                panel1.BackColor = Business.Globals.lightDgvHeadercolor;
                //fonts
                lblUserSearch.ForeColor = Business.Globals.darkLabelcolor;
                grpSupplierInfo.ForeColor = Business.Globals.darkLabelcolor;
                grpUsersData.ForeColor = Business.Globals.darkLabelcolor;
                
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
                btnUpdateSupplier.BackColor = Business.Globals.lightButtoncolor;
                btnAddnewsupplier.BackColor = Business.Globals.lightButtoncolor;
                btnSaveSupplier.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvSuppliers.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvSuppliers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvSuppliers.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //Panel
                infopnl.BackColor = Color.DimGray;
                panel1.BackColor = Business.Globals.PanelThemeColorDark;
                //font
                lblUserSearch.ForeColor = Business.Globals.lightLabelcolor;
                grpSupplierInfo.ForeColor = Business.Globals.lightLabelcolor;
                grpUsersData.ForeColor = Business.Globals.lightLabelcolor;
                //Buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
                btnUpdateSupplier.BackColor = Business.Globals.darkButtoncolor;
                btnAddnewsupplier.BackColor = Business.Globals.darkButtoncolor;
                btnSaveSupplier.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
            dgvSuppliers.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
            btnSaveSupplier.Enabled = true;  //Enable add button
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            Helpers.DataGridViewHelper.ClearDatagrid(dgvSuppliers);
            if (!string.IsNullOrEmpty(fSearchText))
            {
                SearchSuppliers();
            }
            else
            {
                LoadSuppliers();
            }
        }
        #endregion
        private bool RunValidation() {
            //Check tin no. length
            if (!string.IsNullOrEmpty(txtTinNo.Text))
            {
                if (txtTinNo.Text.Length < 12)
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("TIN Number must be 12 digit combination.");

                    txtTinNo.Focus();
                    txtTinNo.SelectAll();
                    return false;
                }
            }
            //Check Email validation
            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                var isValid = Helpers.TextboxHelper.checkEmail(txtEmail.Text);
                if (!isValid)
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Invalid Email address");
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    return false;
                }
            }
            return true;
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            //break out of function if theres invalid validation
            if (!RunValidation()) {
                return;
            }
            bool valid = CheckFields();
            if (valid)
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to add the supplier?", "Confirmation"))
                {
                    var supplierExist = Business.Facades.Supplier.CheckIfExist(fName);
                    if (!supplierExist)
                    {
                        var supplier = new Business.Models.Supplier()
                        {
                            SupplierName = fName,
                            Address = fAddress,
                            Contact = fContact,
                            TinNo = fTinNo,
                            EmailAdd = fEmail,
                            Remarks = fRemarks,
                        };
                        bool success = Business.Facades.Supplier.AddSupplier(supplier);
                        if (success)
                        {
                            LoadSuppliers();
                            ClearFields();
                            Helpers.MessageBoxHelper.ShowInformationDialog("Supplier has been successfully added.", "Success");
                        }
                        else
                        {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Error adding supplier. Please contact your administrator.");
                        }
                    }
                    else {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Supplier named "+fName+" already exist.");
                    }
                }

            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input the complete and correct supplier information.");
            }
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            //break out of function if theres invalid validation
            if (!RunValidation())
            {
                return;
            }
            bool valid = CheckFields(true);
            if (valid)
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to update the supplier?", "Confirmation"))
                {
                    //check if supplier exist
                    var supplierExist = Business.Facades.Supplier.GetById(Convert.ToInt32(fUserId));
                    if (supplierExist != null)
                    {
                        var supplier = new Business.Models.Supplier()
                        {
                            SupplierId = Convert.ToInt32(fUserId),
                            SupplierName = fName,
                            Contact = fContact,
                            Address = fAddress,
                            TinNo =fTinNo,
                            EmailAdd =fEmail,
                            Remarks = fRemarks,
                        };
                        bool success = Business.Facades.Supplier.UpdateSupplier(supplier);
                        if (success)
                        {
                            LoadSuppliers();
                            ClearFields();
                            Helpers.MessageBoxHelper.ShowInformationDialog("Supplier has been successfully updated.", "Success");
                            //btnSaveSupplier.Enabled = true;  //Enable add button
                            btnAddnewsupplier.Visible = true;
                            infopnl.Visible = false;
                        }
                        else
                        {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Error updating supplier. Please contact your Administrator.");
                        }
                    }
                    else {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Cannot find supplier named "+fName+" . Please contact your Administrator.");
                    }
                }
                
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input the complete and correct supplier information.");
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fUserId))
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to delete supplier?", "Confirmation"))
                {
                    bool success = Business.Facades.Supplier.DeleteSupplier(Convert.ToInt32(fUserId));
                    if (success)
                    {
                        LoadSuppliers();
                        ClearFields();
                        Helpers.MessageBoxHelper.ShowInformationDialog("Supplier has been successfully deleted.", "Success");
                        btnSaveSupplier.Enabled = true;//enable add button
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Error deleting supplier. Please contact your administrator.");
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please select the supplier to delete.");
            }
        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnSaveSupplier.Enabled = false; //Disable add button
            if (e.RowIndex >= 0)
            {
                var selectedRow = this.dgvSuppliers.Rows[e.RowIndex];

                fUserId = selectedRow.Cells["SupplierId"].Value.ToString();
                fTinNo = selectedRow.Cells["TinNo"].Value != null ? selectedRow.Cells["TinNo"].Value.ToString() : null;
                fName = selectedRow.Cells["SupplierName"].Value.ToString();
                fContact = selectedRow.Cells["Contact"].Value != null ? selectedRow.Cells["Contact"].Value.ToString() : null;
                fAddress = selectedRow.Cells["Address"].Value != null ? selectedRow.Cells["Address"].Value.ToString() : null;
                fEmail = selectedRow.Cells["EmailAdd"].Value != null ? selectedRow.Cells["EmailAdd"].Value.ToString() : null;
                fRemarks = selectedRow.Cells["Remarks"].Value != null ? selectedRow.Cells["Remarks"].Value.ToString() : null;
            }
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            btnSaveSupplier.Visible = false;
            if (e.ColumnIndex == 7)
            {
         
                if (e.RowIndex >= 0)
                {
                    infopnl.Visible = true;
                    btnUpdateSupplier.Visible = true;
                    btnAddnewsupplier.Visible = false;
                    var selectedRow = this.dgvSuppliers.Rows[e.RowIndex];

                    fUserId = selectedRow.Cells["SupplierId"].Value.ToString();
                    fTinNo = selectedRow.Cells["TinNo"].Value != null ? selectedRow.Cells["TinNo"].Value.ToString() : null;
                    fName = selectedRow.Cells["SupplierName"].Value.ToString();
                    fContact = selectedRow.Cells["Contact"].Value != null ? selectedRow.Cells["Contact"].Value.ToString() : null;
                    fAddress = selectedRow.Cells["Address"].Value != null ? selectedRow.Cells["Address"].Value.ToString() : null;
                    fEmail = selectedRow.Cells["EmailAdd"].Value != null ? selectedRow.Cells["EmailAdd"].Value.ToString() : null;
                    fRemarks = selectedRow.Cells["Remarks"].Value != null ? selectedRow.Cells["Remarks"].Value.ToString() : null;
                }
            }
            else if (e.ColumnIndex == 8)
            {
                if (e.RowIndex >= 0)
                {
                  
                    var selectedRow = this.dgvSuppliers.Rows[e.RowIndex];

                    fUserId = selectedRow.Cells["SupplierId"].Value.ToString();
                    fTinNo = selectedRow.Cells["TinNo"].Value != null ? selectedRow.Cells["TinNo"].Value.ToString() : null;
                    fName = selectedRow.Cells["SupplierName"].Value.ToString();
                    fContact = selectedRow.Cells["Contact"].Value != null ? selectedRow.Cells["Contact"].Value.ToString() : null;
                    fAddress = selectedRow.Cells["Address"].Value != null ? selectedRow.Cells["Address"].Value.ToString() : null;
                    fEmail = selectedRow.Cells["EmailAdd"].Value != null ? selectedRow.Cells["EmailAdd"].Value.ToString() : null;
                    fRemarks = selectedRow.Cells["Remarks"].Value != null ? selectedRow.Cells["Remarks"].Value.ToString() : null;

                    if (!string.IsNullOrEmpty(fUserId))
                    {
                        if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to delete supplier?", "Confirmation"))
                        {
                            bool success = Business.Facades.Supplier.DeleteSupplier(Convert.ToInt32(fUserId));
                            if (success)
                            {
                                LoadSuppliers();
                                ClearFields();
                                Helpers.MessageBoxHelper.ShowInformationDialog("Supplier has been successfully deleted.", "Success");
                                btnSaveSupplier.Enabled = true;//enable add button
                            }
                            else
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Error deleting supplier. Please contact your administrator.");
                            }
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Please select the supplier to delete.");
                    }
                }

            }
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
            infopnl.Visible = false;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            //keypress
            if (Helpers.TextboxHelper.checkAlpha(txtName.Text))
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Numbers and Special Characters are not allowed in this tags.");
                txtName.Text = txtName.Text.Remove(txtName.Text.Length - 1);
            }
        }

        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }

        private void TxtTinNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }

        private void FrmSupplier_Resize(object sender, EventArgs e)
        {
            pnlSuppliers.Left = (this.Width - pnlSuppliers.Width) / 2;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddnewsupplier_Click(object sender, EventArgs e)
        {
            btnSaveSupplier.Visible = true;
            btnUpdateSupplier.Visible = false;
            infopnl.Visible = !infopnl.Visible;
            ClearFields();
            btnAddnewsupplier.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            infopnl.Visible = !infopnl.Visible;
            btnAddnewsupplier.Visible = true;
        }
    }
}
