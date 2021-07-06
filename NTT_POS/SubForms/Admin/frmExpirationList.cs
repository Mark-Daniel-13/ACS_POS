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
    public partial class frmExpirationList : Form
    {
        private int Product { get; set; }
        private double Quantity { get; set; }
        public frmExpirationList(int productId,double quantity)
        {
            InitializeComponent();
            Product = productId;
            Quantity = quantity;

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
                dgvExpirationList.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvExpirationList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvExpirationList.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
        
                //buttons
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvExpirationList.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvExpirationList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvExpirationList.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
             
                //Buttons
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }

        private void frmExpirationList_Load(object sender, EventArgs e)
        {
            var productOrderList = Business.Facades.ProductOrderDetails.GetByProductId(Product).OrderByDescending(o=>o.ExpirationDate).ToList();

            if (productOrderList.Count > 0 && productOrderList != null)
            {
                var detailVMList = ViewModels.ExpirationListVIewModel.ToViewModelList(productOrderList,Quantity);

                dgvExpirationList.AutoGenerateColumns = false;
                dgvExpirationList.DataSource = detailVMList;

            }
            else
            {
                dgvExpirationList.DataSource = null;
                dgvExpirationList.Rows.Clear();
            }
        }
    }
}
