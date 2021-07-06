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
    public partial class frmAddCustomer : Form
    {
        public string fName { 
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
        public frmAddCustomer()
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

                //fonts
                grpCustomerInfo.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnAdd.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;

                //font
                grpCustomerInfo.ForeColor = Business.Globals.lightLabelcolor;
                //buttons
                btnAdd.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fName)) {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    var isCustomerExist = Business.Facades.Customer.GetByName(fName);
                    if (isCustomerExist == null)
                    {
                        if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to create new customer?", "Confirmation"))
                        {
                            var customerModel = new Business.Models.Customer()
                            {
                                CustomerName = fName,
                                Address = fAddress,
                                Contact = fContact,
                                EmailAdd = fEmail,
                            };

                            var addNewCustoemr = Business.Facades.Customer.AddCustomer(customerModel);
                            if (addNewCustoemr)
                            {
                                Helpers.MessageBoxHelper.ShowInformationDialog(string.Format("Customer {0} has been successfully created.", fName), "Success");
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Error on adding new customer. Please contact the administrator");
                            }
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog(string.Format("Customer named {0} already exist!", "Customer Exist.", fName));
                    }
                }
            } else {
                Helpers.MessageBoxHelper.ShowInformationDialog("Please enter customer name!","Invalid Input.");
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

            var isValid = Helpers.TextboxHelper.checkEmail(txtEmail.Text);
            if (!isValid)
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Invalid Email address");
                txtEmail.SelectAll();
                e.Cancel = true;
                return;
            }
            e.Cancel = false;
            
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }
    }
}
