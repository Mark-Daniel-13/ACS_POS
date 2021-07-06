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
    public partial class frmReports : Form
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
        #region Helpers
        private void ChangeForeColorHover(bool isHover,Button btn,Panel icon = null) {
            Color hoverInColor = pnlNavbarDivider.BackColor;
            Color hoverOutColor = Color.White;
            btn.ForeColor = (isHover) ? hoverInColor : hoverOutColor;

            if (icon != null) {
                tblpnlDividerSales.BackColor = (isHover) ? hoverOutColor : hoverInColor;
                pnlSalesIcon.BackColor = (isHover) ? hoverOutColor : hoverInColor;
                btn.BackColor = (isHover) ? hoverOutColor : hoverInColor;
                pnlSalesIcon.BackgroundImage = (isHover) ? (Business.Globals.LightTheme ? Properties.Resources.caret_down__Lightblue_ : Properties.Resources.caret_down__Brown_) : Properties.Resources.caret_down__white_;
            }
        }
        private void DisposeOtherControls()
        {
            foreach (Control ctrl in pnlMainReports.Controls)
            {
                if (ctrl.Name != "subpnlSalesReport")
                {
                    ctrl.Dispose();
                }
            }
        }
        private void LoadProductTraffic()
        {

            DisposeOtherControls();
            SubForms.Admin.Reports.ProductTraffic ProductTraffic = new SubForms.Admin.Reports.ProductTraffic
            {
                Dock = DockStyle.Fill,
                Size = new Size(pnlMainReports.Size.Width, pnlMainReports.Size.Height),

            };

            pnlMainReports.Controls.Add(ProductTraffic);
            ProductTraffic.Show();

        }
        private void LoadDailySales()
        {

            DisposeOtherControls();
            SubForms.Admin.Reports.DailySales DailySales = new SubForms.Admin.Reports.DailySales
            {
                Dock = DockStyle.Fill,
                Size = new Size(pnlMainReports.Size.Width, pnlMainReports.Size.Height),

            };

            pnlMainReports.Controls.Add(DailySales);
            DailySales.Show();
        }
        private void LoadEmployeeSales()
        {

            DisposeOtherControls();
            SubForms.Admin.Reports.EmployeeSales EmployeeSales = new SubForms.Admin.Reports.EmployeeSales
            {
                Dock = DockStyle.Fill,
                Size = new Size(pnlMainReports.Size.Width, pnlMainReports.Size.Height),

            };

            pnlMainReports.Controls.Add(EmployeeSales);
            EmployeeSales.Show();
        }
        private void LoadEmployeeLog()
        {
            DisposeOtherControls();
            SubForms.Admin.Reports.EmployeeLogs SummarizeDailySales = new SubForms.Admin.Reports.EmployeeLogs
            {
                Dock = DockStyle.Fill,
                Size = new Size(pnlMainReports.Size.Width, pnlMainReports.Size.Height),
            };

            pnlMainReports.Controls.Add(SummarizeDailySales);
            SummarizeDailySales.Show();
        }
        private void LoadVoidTransactions()
        {
            DisposeOtherControls();
            SubForms.Admin.Reports.VoidedTransaction VoidedTransaction = new SubForms.Admin.Reports.VoidedTransaction
            {
                Dock = DockStyle.Fill,
                Size = new Size(pnlMainReports.Size.Width, pnlMainReports.Size.Height),

            };

            pnlMainReports.Controls.Add(VoidedTransaction);
            VoidedTransaction.Show();
        }
        private void LoadReturnedItems()
        {
            DisposeOtherControls();
            SubForms.Admin.Reports.ReturnedItems ReturnedItems = new SubForms.Admin.Reports.ReturnedItems
            {
                Dock = DockStyle.Fill,
                Size = new Size(pnlMainReports.Size.Width, pnlMainReports.Size.Height),

            };

            pnlMainReports.Controls.Add(ReturnedItems);
            ReturnedItems.Show();
        }
        private void LoadSummarizedDaily()
        {
            DisposeOtherControls();
            SubForms.Admin.Reports.SummarizedDailyReport SummarizedDailyReport = new SubForms.Admin.Reports.SummarizedDailyReport
            {
                Dock = DockStyle.Fill,
                Size = new Size(pnlMainReports.Size.Width, pnlMainReports.Size.Height),

            };

            pnlMainReports.Controls.Add(SummarizedDailyReport);
            SummarizedDailyReport.Show();
        }
        private void ToggleSalesSubMenu(bool hide = false) {
            if (hide)
            {
                this.subpnlSalesReport.Visible = false;
            }
            else
            {
                if (this.subpnlSalesReport.Visible)
                    this.subpnlSalesReport.Visible = false;
                else
                    this.subpnlSalesReport.Visible = true;
            }
        }
        #endregion

        #region Form Events
        public frmReports()
        {
            InitializeComponent();

            //Set theme
            SetTheme();
        }
        public void SetTheme()
        {
            //Set theme
            Color selectedColor;
            if (Business.Globals.LightTheme)
            {
                selectedColor = Business.Globals.BackgroundThemeColorLight;
                //Datagrid
                pnlNavbar.BackColor = Business.Globals.lightButtoncolor;
                subpnlSalesReport.BackColor = Business.Globals.lightButtoncolor;
                pnlNavbarDivider.BackColor = Business.Globals.lightButtoncolor;

                //buttons
                btnSales.BackColor = Business.Globals.lightButtoncolor;
                btnVoid.BackColor = Business.Globals.lightButtoncolor;
                btnProductTraffic.BackColor = Business.Globals.lightButtoncolor;
                btnDailySales.BackColor = Business.Globals.lightButtoncolor;
                btnSummarize.BackColor = Business.Globals.lightButtoncolor;
                btnSummarizedDaily.BackColor = Business.Globals.lightButtoncolor;
                btnEmployeeSales.BackColor = Business.Globals.lightButtoncolor;
                pnlSalesIcon.BackColor = Business.Globals.lightButtoncolor;
                tblpnlDividerSales.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                pnlNavbar.BackColor = Business.Globals.darkDgvHeadercolor;
                subpnlSalesReport.BackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                pnlNavbarDivider.BackColor = Business.Globals.darkDgvHeaderSelectioncolor;

                //Buttons
                btnSales.BackColor = Business.Globals.darkButtoncolor;
                btnVoid.BackColor = Business.Globals.darkButtoncolor;
                btnProductTraffic.BackColor = Business.Globals.darkButtoncolor;
                btnDailySales.BackColor = Business.Globals.darkButtoncolor;
                btnSummarize.BackColor = Business.Globals.darkButtoncolor;
                btnSummarizedDaily.BackColor = Business.Globals.darkButtoncolor;
                btnEmployeeSales.BackColor = Business.Globals.darkButtoncolor;
                pnlSalesIcon.BackColor = Business.Globals.darkButtoncolor;
                tblpnlDividerSales.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
            //Update color of child userControls
            pnlMainReports.Controls.Cast<UserControl>().ToList().ForEach(control=> {
                RefreshChildForm(control);
            });
        }
        private void RefreshChildForm(UserControl control)
        {
            switch (control.Name)
            {
                case "DailySales":
                    pnlMainReports.Controls.Cast<SubForms.Admin.Reports.DailySales>().Where(c => c.Name == control.Name).FirstOrDefault().SetTheme();
                    break;
                case "EmployeeLogs":
                    pnlMainReports.Controls.Cast<SubForms.Admin.Reports.EmployeeLogs>().Where(c => c.Name == control.Name).FirstOrDefault().SetTheme();
                    break;
                case "EmployeeSales":
                    pnlMainReports.Controls.Cast<SubForms.Admin.Reports.EmployeeSales>().Where(c => c.Name == control.Name).FirstOrDefault().SetTheme();
                    break;
                case "ProductTraffic":
                    pnlMainReports.Controls.Cast<SubForms.Admin.Reports.ProductTraffic>().Where(c => c.Name == control.Name).FirstOrDefault().SetTheme();
                    break;
                case "ReturnedItems":
                    pnlMainReports.Controls.Cast<SubForms.Admin.Reports.ReturnedItems>().Where(c => c.Name == control.Name).FirstOrDefault().SetTheme();
                    break;
                case "SummarizedDailyReport":
                    pnlMainReports.Controls.Cast<SubForms.Admin.Reports.SummarizedDailyReport>().Where(c => c.Name == control.Name).FirstOrDefault().SetTheme();
                    break;
                case "VoidedTransaction":
                    pnlMainReports.Controls.Cast<SubForms.Admin.Reports.VoidedTransaction>().Where(c => c.Name == control.Name).FirstOrDefault().SetTheme();
                    break;
                default:
                    break;
            }

        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            LoadProductTraffic();
        }
        private void clickSales() {
            //set sub panel with the same with its parent
            if (this.subpnlSalesReport.Width != this.tblpnlDividerSales.Width)
                this.subpnlSalesReport.Width = this.tblpnlDividerSales.Width;
            this.tblpnlDividerSales.Focus();
            ToggleSalesSubMenu();
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            clickSales();
        }

        private void btnProductTraffic_Click(object sender, EventArgs e)
        {
            ToggleSalesSubMenu();
            LoadProductTraffic();
        }
        #endregion

        private void btnDailySales_Click(object sender, EventArgs e)
        {
            ToggleSalesSubMenu();
            LoadDailySales();
        }

        private void btnSummarize_Click(object sender, EventArgs e)
        {
            ToggleSalesSubMenu();
            LoadEmployeeLog();
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            ToggleSalesSubMenu(true);
            LoadVoidTransactions();
        }

        private void btnSales_SizeChanged(object sender, EventArgs e)
        {
            this.subpnlSalesReport.Visible = false;
        }

        #region CustomeSubNavHover
        private void btnSales_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColorHover(true, btnSales,pnlSalesIcon);
        }

        private void btnSales_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColorHover(false, btnSales,pnlSalesIcon);
        }
        private void pnlSalesIcon_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColorHover(true, btnSales, pnlSalesIcon);
        }

        private void pnlSalesIcon_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColorHover(false, btnSales, pnlSalesIcon);
        }
        private void pnlSalesIcon_Click(object sender, EventArgs e)
        {
            clickSales();
        }
        #region Sales Icon Gap
        private void tblpnlDividerSales_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColorHover(true, btnSales, pnlSalesIcon);
        }

        private void tblpnlDividerSales_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColorHover(false, btnSales, pnlSalesIcon);
        }

        private void tblpnlDividerSales_Click(object sender, EventArgs e)
        {
            clickSales();
        }
        #endregion
        private void btnProductTraffic_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColorHover(true, btnProductTraffic);
        }

        private void btnProductTraffic_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColorHover(false, btnProductTraffic);
        }

        private void btnDailySales_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColorHover(true, btnDailySales);
        }

        private void btnDailySales_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColorHover(false, btnDailySales);
        }

        private void btnSummarize_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColorHover(true, btnSummarize);
        }

        private void btnSummarize_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColorHover(false, btnSummarize);
        }

        private void btnVoid_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColorHover(true, btnVoid);
        }

        private void btnVoid_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColorHover(false, btnVoid);
        }
        private void btnSummarizedDaily_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColorHover(true, btnSummarizedDaily);
        }

        private void btnSummarizedDaily_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColorHover(false, btnSummarizedDaily);
        }
        private void btnReturns_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColorHover(true, btnReturns);
        }

        private void btnReturns_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColorHover(false, btnReturns);
        }
        #endregion

        private void btnSummarizedDaily_Click(object sender, EventArgs e)
        {
            ToggleSalesSubMenu();
            LoadSummarizedDaily();
        }

        private void btnEmployeeSales_MouseEnter(object sender, EventArgs e)
        {
            ChangeForeColorHover(true, btnEmployeeSales);
        }

        private void btnEmployeeSales_MouseLeave(object sender, EventArgs e)
        {
            ChangeForeColorHover(false, btnEmployeeSales);
        }

        private void btnEmployeeSales_Click(object sender, EventArgs e)
        {
            ToggleSalesSubMenu();
            LoadEmployeeSales();
        }

        private void pnlMainReports_Enter(object sender, EventArgs e)
        {
            ToggleSalesSubMenu(true);
        }

        private void btnReturns_Click(object sender, EventArgs e)
        {
            ToggleSalesSubMenu(true);
            LoadReturnedItems();
        }

        
    }
}
