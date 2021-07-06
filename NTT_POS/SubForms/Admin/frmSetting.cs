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
    public partial class frmSetting : Form
    {
        private int currentControl;
        private int? prevControl = null;
        public void SetTheme() {
            if (Business.Globals.LightTheme)
            {
                //Set theme
                this.BackColor = Business.Globals.BackgroundThemeColorLight;
            }
            else
            {
                //Set theme
                this.BackColor = Business.Globals.BackgroundThemeColor;
            }
        }
        public frmSetting()
        {
            InitializeComponent();
            currentControl = 0;
            LoadUser();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        private void DisposePrevControl() {
            switch (prevControl) {
                case 0:
                    pnlUser.Controls[0].Dispose();
                    break;
                case 1:
                    pnlSupplier.Controls[0].Dispose();
                    break;
                case 2:
                    pnlCustomer.Controls[0].Dispose();
                    break;
                case 3:
                    pnlCategory.Controls[0].Dispose();
                    break;
                case 4:
                    pnlImportExport.Controls[0].Dispose();
                    break;
                case 5:
                    pnlSales.Controls[0].Dispose();
                    break;
            }
        }

        private void LoadUser()
        {
            SubForms.Admin.frmUsers frmUsers = new SubForms.Admin.frmUsers
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlUser.Size.Width, pnlUser.Size.Height),

            };

            pnlUser.Controls.Add(frmUsers);
            frmUsers.Show();
        }
        private void LoadSupplier()
        {

            SubForms.Admin.frmSupplier frmSupplier = new SubForms.Admin.frmSupplier
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlSupplier.Size.Width, pnlSupplier.Size.Height),

            };

            pnlSupplier.Controls.Add(frmSupplier);
            frmSupplier.Show();
        }
        private void LoadCustomer()
        {

            SubForms.Admin.frmCustomer frmCustomer = new SubForms.Admin.frmCustomer
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlCustomer.Size.Width, pnlCustomer.Size.Height),

            };

            pnlCustomer.Controls.Add(frmCustomer);
            frmCustomer.Show();
        }
        private void LoadCategories()
        {

            SubForms.Admin.frmCategories frmCategories = new SubForms.Admin.frmCategories
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlCategory.Size.Width, pnlCategory.Size.Height),

            };

            pnlCategory.Controls.Add(frmCategories);
            frmCategories.Show();
        }
        private void LoadImportExport()
        {

            SubForms.Admin.frmImportExport frmImportExport = new SubForms.Admin.frmImportExport
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlImportExport.Size.Width, pnlImportExport.Size.Height),

            };
            pnlImportExport.Controls.Add(frmImportExport);
            frmImportExport.Show();
        }
        private void LoadTransactions()
        {

            SubForms.Admin.frmSales frmSales = new SubForms.Admin.frmSales
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlImportExport.Size.Width, pnlImportExport.Size.Height),

            };
            pnlSales.Controls.Add(frmSales);
            frmSales.Show();
        }
        private void LoadReturns()
        {

            SubForms.Admin.frmReturns frmReturns = new SubForms.Admin.frmReturns
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlImportExport.Size.Width, pnlImportExport.Size.Height),

            };
            pnlReturns.Controls.Add(frmReturns);
            frmReturns.Show();
        }
        private void LoadBranchInfo()
        {

            SubForms.Admin.frmReceiptTemplateControl frmReceiptTemplateControl = new SubForms.Admin.frmReceiptTemplateControl
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = new Size(pnlImportExport.Size.Width, pnlImportExport.Size.Height),

            };
            pnlBranchInfo.Controls.Add(frmReceiptTemplateControl);
            frmReceiptTemplateControl.Show();
        }

        private void tcSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prevControl != currentControl || prevControl == null)
            {
                prevControl = currentControl;
                DisposePrevControl();

                switch (tcSetting.SelectedIndex)
                {
                    case 0://user
                        LoadUser();
                        break;
                    case 1://Supplier
                        LoadSupplier();
                        break;
                    case 2://Customer
                        LoadCustomer();
                        break;
                    case 3://Category
                        LoadCategories();
                        break;
                    case 4://Import/Export
                        LoadImportExport();
                        break;
                    case 5://Transactions
                        LoadTransactions();
                        break;
                    case 6://BranchInfo
                        LoadBranchInfo();
                        break;
                    case 7://Returns
                        LoadReturns();
                        break;
                }
                currentControl = tcSetting.SelectedIndex;
            }
        }
    }
}
