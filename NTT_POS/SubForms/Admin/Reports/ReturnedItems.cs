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
    public partial class ReturnedItems : UserControl
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
        private int fSelectedFilter { 
            get { return cbFilter.SelectedIndex; }
            set { cbFilter.SelectedIndex = value; }
        }
        public void SetTheme() {
            var lightTheme = Business.Globals.LightTheme;

            //Fonts
            pnlSubcontrol.ForeColor = lightTheme ? Business.Globals.darkLabelcolor : Business.Globals.lightLabelcolor;

            //Buttons
            btnView.BackColor = lightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;
        }
        public ReturnedItems()
        {
            InitializeComponent();
            this.btnView.Height = cbOrder.Height;
            SetTheme();
        }

        private void SetPageMargin(PageSettings settings)
        {
            settings.Margins.Top = 0;
            settings.Margins.Bottom = 0;
            settings.Margins.Left = 0;
            settings.Margins.Right = 0;
        }
        private void LoadComboBox()
        {
            cbOrder.DataSource = Enum.GetValues(typeof(Business.Enums.ReportOrder));
        }
        private void SetReturnsData()
        {
            PageSettings settings = new PageSettings();
            SetPageMargin(settings);

            var startDate = dtpStartDate.Value;
            var endDate = dtpEndDate.Value;
            var returnsData = Business.Facades.Returns.GetAllByReturnStatusFilterByDate(fSelectedFilter,startDate, endDate);
            if (returnsData != null && returnsData.Count > 0)
            {
                //Filter data
                var returnModel = ViewModels.ReturnsReportViewModel.ToModelList(returnsData);

                //SortData
                if (cbOrder.SelectedItem.ToString().ToUpper() == "ASCENDING")
                {
                    returnModel = returnModel.OrderBy(o => o.ReceiptNumber).ToList();
                }
                else
                {
                    returnModel = returnModel.OrderByDescending(o => o.ReceiptNumber).ToList();
                }
                returnModel.First().StartDate = startDate;
                returnModel.First().EndDate = endDate;
                this.returnsReportViewModelBindingSource.DataSource = returnModel;
            }
            else
            {
                this.returnsReportViewModelBindingSource.DataSource = new List<ViewModels.ReturnsReportViewModel>();
            }
            this.rvReturns.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            rvReturns.SetPageSettings(settings);
            this.rvReturns.RefreshReport();
        }

        private void ReturnedItems_Load(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Now.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadComboBox();

            cbFilter.SelectedIndex = 0;
            cbOrder.SelectedIndex = 0;

            cbOrder.SelectedItem = Business.Enums.ReportOrder.Descending;
            SetReturnsData();

            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SetReturnsData();
        }
    }
}
