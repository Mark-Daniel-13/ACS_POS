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
    public partial class ProductTraffic : UserControl
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
        public ProductTraffic()
        {
            InitializeComponent();
            this.btnViewSummary.Height = cbSummaryOrder.Height;
            cbFilter.SelectedIndex = 0;
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
                btnViewSummary.BackColor = Business.Globals.lightButtoncolor;
                //font
                label1.ForeColor = Business.Globals.darkLabelcolor;
                label2.ForeColor = Business.Globals.darkLabelcolor;
                label3.ForeColor = Business.Globals.darkLabelcolor;
                label4.ForeColor = Business.Globals.darkLabelcolor;
            }
            else
            {
                //font
                label1.ForeColor = Business.Globals.darkLabelcolor;
                label2.ForeColor = Business.Globals.darkLabelcolor;
                label3.ForeColor = Business.Globals.darkLabelcolor;
                //Buttons
                btnViewSummary.BackColor = Business.Globals.darkButtoncolor;
                //font
                label1.ForeColor = Business.Globals.lightLabelcolor;
                label2.ForeColor = Business.Globals.lightLabelcolor;
                label3.ForeColor = Business.Globals.lightLabelcolor;
                label4.ForeColor = Business.Globals.lightLabelcolor;
            }
        }
        private void SetPageMargin(PageSettings settings)
        {
            settings.Margins.Top = 0;
            settings.Margins.Bottom = 0;
            settings.Margins.Left = 60;
            settings.Margins.Right = 0;
        }
        private void LoadSummaryOrder()
        {
            cbSummaryOrder.DataSource = Enum.GetValues(typeof(Business.Enums.ReportOrder));
        }
        private void SetSummaryReportData()
        {
            PageSettings settings = new PageSettings();
            SetPageMargin(settings);

            var startDate = dtpSummaryStartDate.Value;
            var endDate = dtpSummaryEndDate.Value;
            var filter = cbFilter.SelectedIndex;
            var salesData = Business.Facades.SalesSummary.GetAllSalesByDate(startDate, endDate);
            if (salesData != null && salesData.Count>0)
            {
                //Filter data
                var salesModel = ViewModels.SalesSummaryViewModel.ToModelList(salesData);
                if (cbFilter.SelectedIndex == 1)
                {
                    salesModel = salesModel.Where(s => s.SoldQuantity > 0).ToList();
                }
                else if (cbFilter.SelectedIndex == 2)
                {
                    salesModel = salesModel.Where(s => s.SoldQuantity == 0).ToList();
                }

                //SortData
                if (cbSummaryOrder.SelectedItem.ToString().ToUpper() == "ASCENDING")
                {
                    salesModel = salesModel.OrderBy(o => o.SoldQuantity).ToList();
                }
                else
                {
                    salesModel = salesModel.OrderByDescending(o => o.SoldQuantity).ToList();
                }

                if (salesModel.Count > 0)
                {
                    salesModel.First().StartDate = startDate;
                    salesModel.First().EndDate = endDate;
                }
                this.SalesSummaryViewModelBindingSource.DataSource = salesModel;
            }
            else
            {
                this.SalesSummaryViewModelBindingSource.DataSource = new List<ViewModels.SalesSummaryViewModel>();
            }
            
            rvSummary.SetPageSettings(settings);
            //this.rvSummary.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.rvSummary.ZoomPercent = 140;
            //rvSummary.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.rvSummary.RefreshReport();
        }

        private void ProductTraffic_Load(object sender, EventArgs e)
        {
            dtpSummaryStartDate.Value = DateTime.Now.AddDays(-7);
            dtpSummaryEndDate.Value = DateTime.Now;
            LoadSummaryOrder();
            cbSummaryOrder.SelectedItem = Business.Enums.ReportOrder.Descending;
            SetSummaryReportData();
        }

        private void btnViewSummary_Click(object sender, EventArgs e)
        {
            SetSummaryReportData();
        }
    }
}
