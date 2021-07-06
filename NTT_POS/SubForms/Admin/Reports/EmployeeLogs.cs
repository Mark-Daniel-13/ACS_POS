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
    public partial class EmployeeLogs : UserControl
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
        public EmployeeLogs()
        {
            InitializeComponent();
            this.btnViewSummarizedSales.Height = cbSummarizedDaily.Height;
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
                btnViewSummarizedSales.BackColor = Business.Globals.lightButtoncolor;
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
                btnViewSummarizedSales.BackColor = Business.Globals.darkButtoncolor;
                //font
                label1.ForeColor = Business.Globals.lightLabelcolor;
                label2.ForeColor = Business.Globals.lightLabelcolor;
                label3.ForeColor = Business.Globals.lightLabelcolor;
            }
        }

        private void btnViewSummarizedSales_Click(object sender, EventArgs e)
        {
            SetSummarizedDailySalesData();
        }
        private void LoadSummarizedDailySalesOrder()
        {
            cbSummarizedDaily.DataSource = Enum.GetValues(typeof(Business.Enums.ReportOrder));
        }
        private void SummarizeDailySales_Load(object sender, EventArgs e)
        {
            dtpStartSummarizedSales.Value = DateTime.Now.AddDays(-7);
            dtpEndSummarizedSales.Value = DateTime.Now;
            LoadSummarizedDailySalesOrder();
            cbSummarizedDaily.SelectedItem = Business.Enums.ReportOrder.Ascending;
            SetSummarizedDailySalesData();
        }
        private void SetSummarizedDailySalesData()
        {
            PageSettings settings = new PageSettings();
            SetPageMargin(settings);

            var startDate = dtpStartSummarizedSales.Value;
            var endDate = dtpEndSummarizedSales.Value;
            var historyData = (Business.Facades.LoginHistory.GetHistoryOnRange(startDate, endDate) != null) ? Business.Facades.LoginHistory.GetHistoryOnRange(startDate, endDate).Where(h => h.RoleId == (int)Business.Enums.Roles.Cashier).ToList() : null;
            if (historyData != null && historyData.Count > 0)
            {
                var SalesSummaryModel = ViewModels.EmployeeLogsViewModel.ToModelList(historyData);
                if (cbSummarizedDaily.SelectedItem.ToString().ToUpper() == "ASCENDING")
                {
                    SalesSummaryModel = SalesSummaryModel.OrderBy(o => o.Date).ToList();
                }
                else
                {
                    SalesSummaryModel = SalesSummaryModel.OrderByDescending(o => o.Date).ToList();
                }
                SalesSummaryModel.First().StartRange = startDate;
                SalesSummaryModel.First().EndRange = endDate;
                this.employeeLogsViewModelBindingSource.DataSource = SalesSummaryModel;

            }
            else
            {
                this.employeeLogsViewModelBindingSource.DataSource = new List<ViewModels.EmployeeLogsViewModel>();
            }
            this.rvSummarizeDailySales.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            rvSummarizeDailySales.SetPageSettings(settings);
            this.rvSummarizeDailySales.RefreshReport();
        }
    }
}
