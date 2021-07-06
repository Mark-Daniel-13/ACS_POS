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
    public partial class frmCustomer : Form
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
        private string fCustomerId
        {
            get { return lblCustomerIdValue.Text; }
            set { lblCustomerIdValue.Text = value; }
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
        private string fEmail
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }


        private string fSearchText
        {
            get { return txtCustomer.Text; }
            set { txtCustomer.Text = value; }
        }
        #endregion

        #region Helpers
        private void LoadCustomer()
        {
            var customerLists = Business.Facades.Customer.GetAll();
            if (customerLists != null)
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = customerLists;
            }
        }

        private void SearchCustomer()
        {
            var customerLists = Business.Facades.Customer.Search(fSearchText);
            if (customerLists != null)
            {
                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = customerLists;
            }
        }

        private void ClearFields()
        {
            fCustomerId = string.Empty;
            fName = string.Empty;
            fAddress = string.Empty;
            fContact = string.Empty;
            fEmail = string.Empty;
        }

        private bool CheckFields(bool checkId = false)
        {
            bool valid = false;
            if (!string.IsNullOrEmpty(fName))
                //&& !string.IsNullOrEmpty(fContact))
            {
                if (checkId)
                {
                    if (!string.IsNullOrEmpty(fCustomerId))
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
                    if (!string.IsNullOrEmpty(fCustomerId))
                    {
                        //if there's value
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }
            return valid;
        }
        #endregion

        #region Form Events
        public frmCustomer()
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
                dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvCustomers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvCustomers.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                //Panel
                infopnl.BackColor = Business.Globals.BackgroundThemeColorLight;
                panel1.BackColor = Business.Globals.lightDgvHeadercolor;
                //fonts
                lblUserSearch.ForeColor = Business.Globals.darkLabelcolor;
                grpCustomerInfo.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
                btnUpdate.BackColor = Business.Globals.lightButtoncolor;
                btnAdd.BackColor = Business.Globals.lightButtoncolor;
                btnAddnewcustomer.BackColor = Business.Globals.lightButtoncolor;

                //Fonts
                grpCustomersData.ForeColor = Business.Globals.darkLabelcolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvCustomers.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvCustomers.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //Panel
                infopnl.BackColor = Color.DimGray;
                panel1.BackColor = Business.Globals.PanelThemeColorDark;
                //font
                lblUserSearch.ForeColor = Business.Globals.lightLabelcolor;
                grpCustomerInfo.ForeColor = Business.Globals.lightLabelcolor;
                //Buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
                btnUpdate.BackColor = Business.Globals.darkButtoncolor;
                btnAdd.BackColor = Business.Globals.darkButtoncolor;
                btnAddnewcustomer.BackColor = Business.Globals.darkButtoncolor;
                //Fonts
                grpCustomersData.ForeColor = Business.Globals.lightLabelcolor;
            }
            //Background Color
            BackColor = selectedColor;
            dgvCustomers.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
            btnAdd.Enabled = true;//Enable add button
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            Helpers.DataGridViewHelper.ClearDatagrid(dgvCustomers);
            if (!string.IsNullOrEmpty(fSearchText))
            {
                SearchCustomer();
            }
            else
            {
                LoadCustomer();
            }
        }
        #endregion
        private bool RunValidation()
        {
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //break out of function if theres invalid validation
            if (!RunValidation())
            {
                return;
            }
            bool valid = CheckFields();
            if (valid)
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to add the customer?", "Confirmation"))
                {
                    var customerExist = Business.Facades.Customer.CheckIfExist(fName);
                    if (!customerExist)
                    {
                        var customer = new Business.Models.Customer()
                        {
                            CustomerName = fName,
                            Address = fAddress,
                            Contact = fContact,
                            EmailAdd = fEmail,
                        };
                        bool success = Business.Facades.Customer.AddCustomer(customer);
                        if (success)
                        {
                            LoadCustomer();
                            ClearFields();
                            Helpers.MessageBoxHelper.ShowInformationDialog("Customer has been successfully added.", "Success");
                        }
                        else
                        {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Error adding customer. Please contact your administrator.");
                        }
                    }
                   
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Customer named " + fName + " already exist.");
                    }
                }

            }
            else

            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input the complete and correct customer information.");
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //break out of function if theres invalid validation
            if (!RunValidation())
            {
                return;
            }
            bool valid = CheckFields(true);
            if (valid)
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to update the customer?", "Confirmation"))
                {
                    //check if supplier exist
                    var customerExist = Business.Facades.Customer.GetById(Convert.ToInt32(fCustomerId));
                    if (customerExist != null)
                    {
                        var customer = new Business.Models.Customer()
                        {
                            CustomerId = Convert.ToInt32(fCustomerId),
                            CustomerName = fName,
                            Contact = fContact,
                            Address = fAddress,
                            EmailAdd = fEmail,
                        };
                        bool success = Business.Facades.Customer.UpdateCustomer(customer);
                        if (success)
                        {
                            LoadCustomer();
                            ClearFields();
                            Helpers.MessageBoxHelper.ShowInformationDialog("Customer has been successfully updated.", "Success");
                            //btnAdd.Enabled = true;//Enable add button
                            infopnl.Visible = false;
                            btnAddnewcustomer.Visible = true;
                        }
                        else
                        {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Error updating customer. Please contact your Administrator.");
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Cannot find customer named " + fName + " . Please contact your Administrator.");
                    }
                }

            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input the complete and correct customer information.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fCustomerId))
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to delete customer?", "Confirmation"))
                {
                    bool success = Business.Facades.Customer.DeleteCustomer(Convert.ToInt32(fCustomerId));
                    if (success)
                    {
                        LoadCustomer();
                        ClearFields();
                        Helpers.MessageBoxHelper.ShowInformationDialog("Customer has been successfully deleted.", "Success");
                       // btnAdd.Enabled = true;//enable add button
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Error deleting customer. Please contact your administrator.");
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please select the customer to delete.");
            }
        }


        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex >= 0)
                {
                    infopnl.Visible = true;
                    btnUpdate.Visible = true;
                    btnAddnewcustomer.Visible = false;
                    var selectedRow = this.dgvCustomers.Rows[e.RowIndex];

                    fCustomerId = selectedRow.Cells["CustomerId"].Value.ToString();
                    fName = selectedRow.Cells["CustomerName"].Value.ToString();
                    fContact = selectedRow.Cells["Contact"].Value != null ? selectedRow.Cells["Contact"].Value.ToString() : null;
                    fAddress = selectedRow.Cells["Address"].Value != null ? selectedRow.Cells["Address"].Value.ToString() : null;
                    fEmail = selectedRow.Cells["EmailAdd"].Value != null ? selectedRow.Cells["EmailAdd"].Value.ToString() : null;
                }
            }
            else if (e.ColumnIndex == 6)
            {
                if (e.RowIndex >= 0)
                {
                  
                    var selectedRow = this.dgvCustomers.Rows[e.RowIndex];

                    fCustomerId = selectedRow.Cells["CustomerId"].Value.ToString();
                    fName = selectedRow.Cells["CustomerName"].Value.ToString();
                    fContact = selectedRow.Cells["Contact"].Value != null ? selectedRow.Cells["Contact"].Value.ToString() : null;
                    fAddress = selectedRow.Cells["Address"].Value != null ? selectedRow.Cells["Address"].Value.ToString() : null;
                    fEmail = selectedRow.Cells["EmailAdd"].Value != null ? selectedRow.Cells["EmailAdd"].Value.ToString() : null;

                    if (!string.IsNullOrEmpty(fCustomerId))
                    {
                        if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to delete customer?", "Confirmation"))
                        {
                            bool success = Business.Facades.Customer.DeleteCustomer(Convert.ToInt32(fCustomerId));
                            if (success)
                            {
                                LoadCustomer();
                                ClearFields();
                                Helpers.MessageBoxHelper.ShowInformationDialog("Customer has been successfully deleted.", "Success");
                                // btnAdd.Enabled = true;//enable add button
                            }
                            else
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Error deleting customer. Please contact your administrator.");
                            }
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Please select the customer to delete.");
                    }
                }
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                var selectedRow = this.dgvCustomers.Rows[e.RowIndex];

                fCustomerId = selectedRow.Cells["CustomerId"].Value.ToString();
                fName = selectedRow.Cells["CustomerName"].Value.ToString();
                fContact = selectedRow.Cells["Contact"].Value != null ? selectedRow.Cells["Contact"].Value.ToString() : null;
                fAddress = selectedRow.Cells["Address"].Value != null ? selectedRow.Cells["Address"].Value.ToString() : null;
                fEmail = selectedRow.Cells["EmailAdd"].Value != null ? selectedRow.Cells["EmailAdd"].Value.ToString() : null;
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer();
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

        private void FrmCustomer_Resize(object sender, EventArgs e)
        {
            pnlCustomers.Left = (this.Width - pnlCustomers.Width) / 2;
        }

        private void BtnAddnewcustomer_Click(object sender, EventArgs e)
        {
            btnAddnewcustomer.Visible = true;
            btnUpdate.Visible = false;
            infopnl.Visible = !infopnl.Visible;
            ClearFields();
            btnAddnewcustomer.Visible = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            infopnl.Visible = !infopnl.Visible;
            btnAddnewcustomer.Visible = true;
        }
    }
}
