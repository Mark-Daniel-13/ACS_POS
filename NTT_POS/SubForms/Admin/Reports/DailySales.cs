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
    public partial class DailySales : UserControl
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
        public DailySales()
        {
            InitializeComponent();
            this.btnViewDaily.Height = cbDetailOrder.Height;
            SetTheme();
        }
        public void SetTheme()
        {
            //Set theme
            if (Business.Globals.LightTheme)
            {
                label1.ForeColor = Business.Globals.darkLabelcolor;
                label2.ForeColor = Business.Globals.darkLabelcolor;
                label3.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnViewDaily.BackColor = Business.Globals.lightButtoncolor;
                //font
                label1.ForeColor = Business.Globals.darkLabelcolor;
                label2.ForeColor = Business.Globals.darkLabelcolor;
                label3.ForeColor = Business.Globals.darkLabelcolor;
            }
            else
            {
                //font
                label1.ForeColor = Business.Globals.darkLabelcolor;
                label2.ForeColor = Business.Globals.darkLabelcolor;
                label3.ForeColor = Business.Globals.darkLabelcolor;
                //Buttons
                btnViewDaily.BackColor = Business.Globals.darkButtoncolor;
                //font
                label1.ForeColor = Business.Globals.lightLabelcolor;
                label2.ForeColor = Business.Globals.lightLabelcolor;
                label3.ForeColor = Business.Globals.lightLabelcolor;
            }
        }
        private void SetPageMargin(PageSettings settings) {
            settings.Margins.Top = 0;
            settings.Margins.Bottom = 0;
            settings.Margins.Left = 0;
            settings.Margins.Right = 0;
        }
        private void LoadDetailOrder()
        {
            cbDetailOrder.DataSource = Enum.GetValues(typeof(Business.Enums.ReportOrder));
        }
        private void SetDetailReportData()
        {
            PageSettings settings = new PageSettings();
            SetPageMargin(settings);

            var startDate = dtpDailyStartDate.Value;
            var endDate = dtpDailyEndDate.Value;
            var transactionData = Business.Facades.Transactions.GetTransactionsOnRange(startDate, endDate);
            if (transactionData != null && transactionData.Count>0)
            {
                var dailySalesModel = ViewModels.DailySalesViewModel.ToModelList(transactionData);
                if (cbDetailOrder.SelectedItem.ToString().ToUpper() == "ASCENDING")
                {
                    dailySalesModel = dailySalesModel.OrderBy(o => o.TransactionDate).ToList();
                }
                else
                {
                    dailySalesModel = dailySalesModel.OrderByDescending(o => o.TransactionDate).ToList();
                }
                dailySalesModel.First().StartDate = startDate;
                dailySalesModel.First().EndDate = endDate;
                this.DailySalesViewModelBindingSource.DataSource = dailySalesModel;
            }
            else
            {
                this.DailySalesViewModelBindingSource.DataSource = new List<ViewModels.DailySalesViewModel>();
            }
            this.rvDaily.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            rvDaily.SetPageSettings(settings);
            this.rvDaily.RefreshReport();
            
        }

        private void DailySales_Load(object sender, EventArgs e)
        {
            dtpDailyStartDate.Value = DateTime.Now;
            dtpDailyEndDate.Value = DateTime.Now;
            LoadDetailOrder();
            cbDetailOrder.SelectedItem = Business.Enums.ReportOrder.Ascending;
            SetDetailReportData();
        }
        private void btnViewDaily_Click(object sender, EventArgs e)
        {
            SetDetailReportData();
        }
    }
}
