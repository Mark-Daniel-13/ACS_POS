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
    public partial class SummarizedDailyReport : UserControl
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
        private void SetPageMargin(PageSettings settings)
        {
            settings.Margins.Top = 0;
            settings.Margins.Bottom = 0;
            settings.Margins.Left = 0;
            settings.Margins.Right = 0;
        }
        public SummarizedDailyReport()
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
        private void LoadSummarizedDailySalesOrder()
        {
            cbDetailOrder.DataSource = Enum.GetValues(typeof(Business.Enums.ReportOrder));
        }

        private void SummarizedDailyReport_Load(object sender, EventArgs e)
        {
            dtpDailyStartDate.Value = DateTime.Now.AddDays(-7);
            dtpDailyEndDate.Value = DateTime.Now;
            LoadSummarizedDailySalesOrder();
            cbDetailOrder.SelectedItem = Business.Enums.ReportOrder.Ascending;
            SetSummarizedDailySalesData();
        }
        private void SetSummarizedDailySalesData()
        {
            PageSettings settings = new PageSettings();
            SetPageMargin(settings);

            var startDate = dtpDailyStartDate.Value;
            var endDate = dtpDailyEndDate.Value;
            var historyData = (Business.Facades.LoginHistory.GetHistoryOnRange(startDate, endDate) != null) ? Business.Facades.LoginHistory.GetHistoryOnRange(startDate, endDate).Where(h => h.RoleId == (int)Business.Enums.Roles.Cashier).ToList() : null;
            if (historyData != null && historyData.Count>0)
            {
                var SalesSummaryModel = ViewModels.SummarizedDailySalesViewModel.ToModelList(historyData);
                if (cbDetailOrder.SelectedItem.ToString().ToUpper() == "ASCENDING")
                {
                    SalesSummaryModel = SalesSummaryModel.OrderBy(o => o.Date).ToList();
                }
                else
                {
                    SalesSummaryModel = SalesSummaryModel.OrderByDescending(o => o.Date).ToList();
                }
                SalesSummaryModel.First().StartRange = startDate;
                SalesSummaryModel.First().EndRange = endDate;
                this.SummarizedDailySalesViewModelBindingSource.DataSource = SalesSummaryModel;

            }
            else
            {
                this.SummarizedDailySalesViewModelBindingSource.DataSource = new List<ViewModels.EmployeeLogsViewModel>();
            }
            this.rvSummarized.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            rvSummarized.SetPageSettings(settings);
            this.rvSummarized.RefreshReport();
        }

        private void btnViewDaily_Click(object sender, EventArgs e)
        {
            SetSummarizedDailySalesData();
        }
    }
}
