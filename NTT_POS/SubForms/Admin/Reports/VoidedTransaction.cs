using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace NTT_POS.SubForms.Admin.Reports
{
    public partial class VoidedTransaction : UserControl
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
        public VoidedTransaction()
        {
            InitializeComponent();
            this.btnViewVoided.Height = cbVoidedOrder.Height;
            SetTheme();
        }
        public void SetTheme()
        {
            //Set theme
            if (Business.Globals.LightTheme)
            {
                //buttons
                btnViewVoided.BackColor = Business.Globals.lightButtoncolor;
                //font
                label1.ForeColor = Business.Globals.darkLabelcolor;
                label2.ForeColor = Business.Globals.darkLabelcolor;
                label3.ForeColor = Business.Globals.darkLabelcolor;
            }
            else
            {
                //Buttons
                btnViewVoided.BackColor = Business.Globals.darkButtoncolor;
                //font
                label1.ForeColor = Business.Globals.lightLabelcolor;
                label2.ForeColor = Business.Globals.lightLabelcolor;
                label3.ForeColor = Business.Globals.lightLabelcolor;
            }
        }
        private void SetPageMargin(PageSettings settings)
        {
            settings.Margins.Top = 0;
            settings.Margins.Bottom = 0;
            settings.Margins.Left = 0;
            settings.Margins.Right = 0;
        }
        private void LoadVoidedOrder()
        {
            cbVoidedOrder.DataSource = Enum.GetValues(typeof(Business.Enums.ReportOrder));
        }
        private void btnViewVoided_Click(object sender, EventArgs e)
        {
            SetVoidedReportData();
        }
        private void VoidedTransaction_Load(object sender, EventArgs e)
        {
            dtpVoidedStartDate.Value = DateTime.Now.AddDays(-7);
            dtpVoidedEndDate.Value = DateTime.Now;
            LoadVoidedOrder();
            cbVoidedOrder.SelectedItem = Business.Enums.ReportOrder.Ascending;
            SetVoidedReportData();
        }
        private void SetVoidedReportData()
        {
            PageSettings settings = new PageSettings();
            SetPageMargin(settings);

            var startDate = dtpVoidedStartDate.Value;
            var endDate = dtpVoidedEndDate.Value;
            var transactionData = Business.Facades.Transactions.GetVoidedTransactionsOnRage(startDate, endDate);
            if (transactionData != null && transactionData.Count>0)
            {
                var dailySalesModel = ViewModels.DailySalesViewModel.ToModelList(transactionData);
                if (cbVoidedOrder.SelectedItem.ToString().ToUpper() == "ASCENDING")
                {
                    dailySalesModel = dailySalesModel.OrderBy(o => o.TransactionEndDate).ToList();
                }
                else
                {
                    dailySalesModel = dailySalesModel.OrderByDescending(o => o.TransactionEndDate).ToList();
                }
                dailySalesModel.First().StartDate = startDate;
                dailySalesModel.First().EndDate = endDate;
                this.DailySalesViewModelBindingSource.DataSource = dailySalesModel;
            }
            else
            {
                this.DailySalesViewModelBindingSource.DataSource = new List<ViewModels.DailySalesViewModel>();
            }
            this.rvVoided.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            rvVoided.SetPageSettings(settings);
            this.rvVoided.RefreshReport();
        }
    }
}
