using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;

namespace NTT_POS.SubForms.Admin
{
    public partial class frmDashboard : Form
    {
        private string frmDayOfWeek
        {
            get { return lbweekofDay.Text; }
            set { lbweekofDay.Text = value; }
        }
        private List<DateTime> sortedList;
       
            public void SetTheme()
            {
                //Set theme
                Color selectedColor;
                if (Business.Globals.LightTheme)
                {
                    selectedColor = Business.Globals.BackgroundThemeColorLight;
                    pcDays.BackColor = Business.Globals.BackgroundThemeColorLight;
                    //Datagrid
                    dgvSoldDays.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                    dgvSoldDays.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                    dgvSoldDays.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                    
                    //fonts
                    lblDashboard.ForeColor = Business.Globals.darkLabelcolor;
                    lbRefresh.ForeColor = Business.Globals.darkLabelcolor;
                    label1.ForeColor = Business.Globals.darkLabelcolor;
                    label2.ForeColor = Business.Globals.darkLabelcolor;
                    lbweekofDay.ForeColor = Business.Globals.darkLabelcolor;

            }
                else
                {
                    selectedColor = Business.Globals.BackgroundThemeColor;
                    pcDays.BackColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                    dgvSoldDays.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                    dgvSoldDays.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                    dgvSoldDays.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                //font
                    lblDashboard.ForeColor = Business.Globals.lightLabelcolor;
                    lbRefresh.ForeColor = Business.Globals.lightLabelcolor;
                    label1.ForeColor = Business.Globals.lightLabelcolor;
                    label2.ForeColor = Business.Globals.lightLabelcolor;
                    lbweekofDay.ForeColor = Business.Globals.lightLabelcolor;

            }
                //Background Color
                BackColor = selectedColor;
            }
       
        public frmDashboard()
        {
            InitializeComponent();
            LoadPieChartDays();

            SetTheme();
        }

        private void LoadPieChartDays()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                chartPoint.Y != 0 ? string.Format("{0} Sales ({1:P})", chartPoint.Y,chartPoint.Participation) : string.Format("");

            var lastSevenDays = SortDays(Enumerable.Range(0, 7).Select(d => DateTime.Now.Date.AddDays(-d)).ToList());
            var seriesBag = new SeriesCollection();
            for (var x = 0; x < lastSevenDays.Count; x++) {
                var insertData = new PieSeries
                {
                    Title = lastSevenDays[x].DayOfWeek.ToString(),
                    Values = new ChartValues<int> { Business.Facades.TransactionDetails.GetNumberOfSalesByDate(lastSevenDays[x]) },
                    DataLabels = true,
                    LabelPoint = labelPoint,
                };
                seriesBag.Add(insertData);
            }
            pcDays.Series = seriesBag;
            //pcDays.Series = new SeriesCollection
            //{
            //    new PieSeries 
            //    {
            //        Title = lastSevenDays[0].DayOfWeek.ToString(),
            //        Values = new ChartValues<int> {Business.Facades.TransactionDetails.GetNumberOfSalesByDate(lastSevenDays[0])},
            //        DataLabels = true,
            //        LabelPoint = labelPoint,
            //    },
            //    new PieSeries
            //    {
            //        Title = lastSevenDays[1].DayOfWeek.ToString(),
            //        Values = new ChartValues<int> {Business.Facades.TransactionDetails.GetNumberOfSalesByDate(lastSevenDays[1])},
            //        DataLabels = true,
            //        LabelPoint = labelPoint
            //    },
            //    new PieSeries 
            //    {
            //        Title = lastSevenDays[2].DayOfWeek.ToString(),
            //        Values = new ChartValues<int> {Business.Facades.TransactionDetails.GetNumberOfSalesByDate(lastSevenDays[2])},
            //        DataLabels = true,
            //        LabelPoint = labelPoint
            //    },
            //    new PieSeries 
            //    {
            //        Title = lastSevenDays[3].DayOfWeek.ToString(),
            //        Values = new ChartValues<int> {Business.Facades.TransactionDetails.GetNumberOfSalesByDate(lastSevenDays[3])},
            //        DataLabels = true,
            //        LabelPoint = labelPoint
            //    },
            //    new PieSeries 
            //    {
            //        Title = lastSevenDays[4].DayOfWeek.ToString(),
            //        Values = new ChartValues<double> {Business.Facades.TransactionDetails.GetNumberOfSalesByDate(lastSevenDays[4])},
            //        DataLabels = true,
            //        LabelPoint = labelPoint,
            //    },
            //    new PieSeries
            //    {
            //        Title = lastSevenDays[5].DayOfWeek.ToString(),
            //        Values = new ChartValues<double> {Business.Facades.TransactionDetails.GetNumberOfSalesByDate(lastSevenDays[5])},
            //        DataLabels = true,
            //        LabelPoint = labelPoint,
            //    },
            //    new PieSeries 
            //    {
            //        Title = lastSevenDays[6].DayOfWeek.ToString(),
            //        Values = new ChartValues<double> {Business.Facades.TransactionDetails.GetNumberOfSalesByDate(lastSevenDays[6])},
            //        DataLabels = true,
            //        LabelPoint = labelPoint,
            //    }
            //};
            pcDays.DataTooltip = null;
            pcDays.LegendLocation = LegendLocation.Bottom;

        }
        private int GetDateIndex(string dayOfWeek) {
            if (dayOfWeek == "Monday")
            {
                return 0;
            }
            else if (dayOfWeek == "Tuesday")
            {
                return 1;
            }
            else if (dayOfWeek == "Wednesday")
            {
                return 2;
            }
            else if (dayOfWeek == "Thursday") {
                return 3;
            }
            else if (dayOfWeek == "Friday")
            {
                return 4;
            }
            else if (dayOfWeek == "Saturday")
            {
                return 5;
            }
            else
            {
                return 6;
            }
        }

        private List<DateTime> SortDays(List<DateTime> dayList) {
            sortedList = dayList;

            foreach (DateTime day in dayList.ToList()) {
                if (day.DayOfWeek == DayOfWeek.Monday)
                {
                    sortedList[0] = day;
                }
                else if (day.DayOfWeek == DayOfWeek.Tuesday) {
                    sortedList[1] = day;
                }
                else if (day.DayOfWeek == DayOfWeek.Wednesday)
                {
                    sortedList[2] = day;
                }
                else if (day.DayOfWeek == DayOfWeek.Thursday)
                {
                    sortedList[3] = day;
                }
                else if (day.DayOfWeek == DayOfWeek.Friday)
                {
                    sortedList[4] = day;
                }
                else if (day.DayOfWeek == DayOfWeek.Saturday)
                {
                    sortedList[5] = day;
                }
                else if(day.DayOfWeek == DayOfWeek.Sunday)
                {
                    sortedList[6] = day;
                }
            }
            return sortedList;
        }
        private void pcDays_DataHover(object sender, ChartPoint chartPoint)
        {
            dgvSoldDays.DataSource = null;
            dgvSoldDays.Rows.Clear();

            frmDayOfWeek = chartPoint.SeriesView.Title;
            var _index = GetDateIndex(frmDayOfWeek);
            var data = Business.Facades.TransactionDetails.GetSalesByDate(sortedList[_index]);
            data.ForEach(t=>{
                dgvSoldDays.Rows.Add(t.ProductId, Business.Facades.Products.GetProductNameById(t.ProductId), t.Quantity, t.TotalPrice);
            });
        }

        private void lbRefresh_Click(object sender, EventArgs e)
        {
            LoadPieChartDays();
            dgvSoldDays.DataSource = null;
            dgvSoldDays.Rows.Clear();
            lbweekofDay.Text = "";
            
        }
    }
}
