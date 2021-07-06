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
    public partial class frmPurchaseOrderView : Form
    {
        private int currentId;
        public frmPurchaseOrderView(int orderId)
        {
            InitializeComponent();
            currentId = orderId;

            //Set theme
            this.BackColor = Business.Globals.LightTheme ?  Business.Globals.BackgroundThemeColorLight : Business.Globals.BackgroundThemeColor;
            btnCancel.BackColor = Business.Globals.LightTheme ? Business.Globals.lightButtoncolor : Business.Globals.darkButtoncolor;
        }

        private void SetOrderDetailsReport(int orderId)
        {
            var orderDetails = Business.Facades.ProductOrderDetails.GetByProductOrderId(orderId);
            var order = Business.Facades.ProductOrder.GetById(orderId);
            if (orderDetails.Count > 0 && orderDetails != null)
            {
                var detailVMList = ViewModels.ProductOrderDeitalViewModel.ToViewModelList(orderDetails);
                var orderVM = ViewModels.ProductOrderViewModel.ToViewModel(order);
                this.ProductOrderDeitalViewModelBindingSource.DataSource = detailVMList;
                this.ProductOrderViewModelBindingSource.DataSource = orderVM;


                this.rvOrderDetails.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            }
            else
            {
                this.ProductOrderViewModelBindingSource.DataSource = new ViewModels.ProductOrderViewModel();
                this.ProductOrderDeitalViewModelBindingSource.DataSource = new List<ViewModels.ProductOrderDeitalViewModel>();
            }

            this.rvOrderDetails.RefreshReport();
        }

        private void frmPurchaseOrderView_Load(object sender, EventArgs e)
        {
            SetOrderDetailsReport(currentId);
        }
    }
}
