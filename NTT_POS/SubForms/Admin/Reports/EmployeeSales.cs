using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.SubForms.Admin.Reports
{
    public partial class EmployeeSales : UserControl
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

        public EmployeeSales()
        {
            InitializeComponent();
            this.btnViewDaily.Height = cbDetailOrder.Height;
            SetTheme();
        }
        public void SetTheme()
        {
            //Set theme
            Color selectedColor;
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
        private void SetPageMargin(PageSettings settings)
        {
            settings.Margins.Top = 0;
            settings.Margins.Bottom = 0;
            settings.Margins.Left = 0;
            settings.Margins.Right = 0;
        }

        private void SetEmployeeSalesData()
        {
            PageSettings settings = new PageSettings();
            SetPageMargin(settings);

            var startDate = dtpEmpSalesStartDate.Value;
            var endDate = dtpEmpSalesEndDate.Value;
            var EmployeeData = Business.Facades.Users.GetAllCashier();
            if (EmployeeData != null && EmployeeData.Count > 0)
            {
                var EmployeeSalesModel = ViewModels.EmployeeSalesViewModel.ToModelList(EmployeeData, startDate, endDate);
                if (cbDetailOrder.SelectedItem.ToString().ToUpper() == "ASCENDING")
                {
                    EmployeeSalesModel = EmployeeSalesModel.OrderBy(o => o.RankNumber).ToList();
                }
                else
                {
                    EmployeeSalesModel = EmployeeSalesModel.OrderByDescending(o => o.RankNumber).ToList();
                }
                EmployeeSalesModel.First().StartRange = startDate;
                EmployeeSalesModel.First().EndRange = endDate;
                this.EmployeeSalesViewModelBindingSource.DataSource = EmployeeSalesModel;
                

            }
            else
            {
                this.EmployeeSalesViewModelBindingSource.DataSource = new List<ViewModels.EmployeeLogsViewModel>();
            }
            this.rvEmpSales.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            rvEmpSales.SetPageSettings(settings);
            this.rvEmpSales.RefreshReport();
        }

        private void btnViewDaily_Click(object sender, EventArgs e)
        {
            SetEmployeeSalesData();
        }
        private void LoadEmployeeSalesOrder()
        {
            cbDetailOrder.DataSource = Enum.GetValues(typeof(Business.Enums.ReportOrder));
        }

        private void EmployeeSales_Load(object sender, EventArgs e)
        {
            dtpEmpSalesStartDate.Value = DateTime.Now.AddDays(-7);
            dtpEmpSalesEndDate.Value = DateTime.Now;
            LoadEmployeeSalesOrder();
            cbDetailOrder.SelectedItem = Business.Enums.ReportOrder.Ascending;
            SetEmployeeSalesData();
        }
    }
}
