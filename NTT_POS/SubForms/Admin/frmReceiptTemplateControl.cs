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
    public partial class frmReceiptTemplateControl : Form
    {
        private string fCompanyName { get { return  txtCompName.Text; } set { txtCompName.Text = value; } }
        private string fAddress { get { return txtAddress.Text; } set { txtAddress.Text = value; } }
        private string fTinNo { get { return txtTInNo.Text; } set { txtTInNo.Text = value; } }
        private int branchId { get; set; }
        private Business.Models.CompanyBranchDetails compInfo;
        public void SetTheme() {
            var lightTheme = Business.Globals.LightTheme;
            BackColor = lightTheme ? Business.Globals.BackgroundThemeColorLight : Business.Globals.BackgroundThemeColor;
            //Fonts
            grpUserInfo.ForeColor = lightTheme ?  Business.Globals.darkLabelcolor : Business.Globals.lightLabelcolor;

            //Buttons
            btnUpdate.BackColor = lightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;
        }
        public frmReceiptTemplateControl()
        {
            InitializeComponent();
            SetTheme();
        }

        private void txtTInNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }
        private void LoadDetail() {
            compInfo = Business.Facades.CompanyBranchDetails.GetAll().FirstOrDefault();
            if (compInfo != null)
            {
                branchId = compInfo.BranchId;
                fCompanyName = compInfo.BranchName;
                fAddress = compInfo.Address;
                fTinNo = compInfo.TinNo;
            }
        }
        private void frmReceiptTemplateControl_Load(object sender, EventArgs e)
        {
            LoadDetail();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fTinNo))
            {
                if (fTinNo.Length < 12)
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("TIN Number must be 12 digit combination.");

                    txtTInNo.Focus();
                    return;
                }
            }

            
            //check if companyInfo is new or have previous data add column to database else update the column
            bool success;
            if (compInfo == null)
            {
                var branchDetail = new Business.Models.CompanyBranchDetails()
                {
                    BranchName = fCompanyName,
                    Address = fAddress,
                    TinNo = fTinNo,
                };
                success = Business.Facades.CompanyBranchDetails.AddBranch(branchDetail);
            }
            else
            {
                compInfo.BranchId = branchId;
                compInfo.BranchName = fCompanyName;
                compInfo.Address = fAddress;
                compInfo.TinNo = fTinNo;
                success = Business.Facades.CompanyBranchDetails.UpdateBranch(compInfo);
            }

            if (success)
            {
                LoadDetail();
                Helpers.MessageBoxHelper.ShowInformationDialog("Branch detail has been successfully updated.", "Success");
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Error updating branch detail. Please contact your administrator.");
            }
            
        }
    }
}
