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
    public partial class frmPurchaseOrder : Form
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
        #region FormFieldProperties
        private string fSearchSupplier {
            get { return cbSearch.Text; }
            set { cbSearch.Text = value; }
        }
        private string fQuantity
        {
            get { return txtQuantity.Text; }
            set { txtQuantity.Text = value; }
        }
        private int? fSupplierId { get; set; }
        private string TotalOrderCost {
            get { return lbTotalCostValue.Text; }
            set { lbTotalCostValue.Text = value; }
        }
        #endregion
        public frmPurchaseOrder()
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
                dgvSupplier.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvSupplier.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvSupplier.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;

                dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvCart.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvCart.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;

                //fonts
                lbSearch.ForeColor = Business.Globals.darkLabelcolor;
                lbQuantity.ForeColor = Business.Globals.darkLabelcolor;
                lbTotalCost.ForeColor = Business.Globals.darkLabelcolor;
                lbTotalCostValue.ForeColor = Business.Globals.darkLabelcolor;
                grpProducts.ForeColor = Business.Globals.darkLabelcolor;
                grpSelectedProducts.ForeColor = Business.Globals.darkLabelcolor;

                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnAddCart.BackColor = Business.Globals.lightButtoncolor;
                btnClear.BackColor = Business.Globals.lightButtoncolor;
                btnRemoveItem.BackColor = Business.Globals.lightButtoncolor;
                btnGenerate.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvSupplier.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvSupplier.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvSupplier.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;

                dgvCart.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvCart.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvCart.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;

                //font
                lbSearch.ForeColor = Business.Globals.lightLabelcolor;
                lbQuantity.ForeColor = Business.Globals.lightLabelcolor;
                lbTotalCost.ForeColor = Business.Globals.lightLabelcolor;
                lbTotalCostValue.ForeColor = Business.Globals.lightLabelcolor;
                grpProducts.ForeColor = Business.Globals.lightLabelcolor;
                grpSelectedProducts.ForeColor = Business.Globals.lightLabelcolor;
                //Buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnAddCart.BackColor = Business.Globals.darkButtoncolor;
                btnClear.BackColor = Business.Globals.darkButtoncolor;
                btnRemoveItem.BackColor = Business.Globals.darkButtoncolor;
                btnGenerate.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
            dgvSupplier.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
            dgvCart.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
        }
        private void LoadSupplier()
        {
            var supplier = Business.Facades.Supplier.GetByName(fSearchSupplier);
            
            if (supplier != null)
            {
                fSupplierId = supplier.SupplierId;
                var searchSupplier = Business.Facades.SupplierProductRef.SearchBySupplierId(supplier.SupplierId);
                if (searchSupplier != null)
                {
                    var supplierVMList = ViewModels.SupplierViewModel.ToViewModelList(searchSupplier);
                    dgvSupplier.AutoGenerateColumns = false;
                    dgvSupplier.DataSource = supplierVMList;

                }
            }
            else
            {
                Clear();
            }
        }
        private void Clear(bool all = false) {
            if (all) {
                dgvCart.DataSource = null;
                dgvCart.Rows.Clear();
                fQuantity = string.Empty;
                TotalOrderCost = string.Empty;
            }
            else
            {
                fSupplierId = null;
                dgvSupplier.DataSource = null;
                dgvSupplier.Rows.Clear();
                dgvCart.DataSource = null;
                dgvCart.Rows.Clear();
                fQuantity = string.Empty;
                TotalOrderCost = string.Empty;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadSupplier();
        }

        private void cbSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSearch.Items.Count != 0)
            {
                if (dgvCart.Rows.Count > 0)
                {
                    if (Helpers.MessageBoxHelper.ShowYesNoDialog("There are remaining item on cart, changing the supplier will empty your cart. Continue?", "Confirmation"))
                    {
                        Clear();
                        LoadSupplier();
                    }
                }
                else {
                    LoadSupplier();
                }
            }
        }
        private void CreateRow(Business.Models.SupplierProductRef xref , int orderQuantity)
        {
            var totalCost = xref.UnitCost != null ? xref.UnitCost * orderQuantity : 0;
            dgvCart.Rows.Add(xref.Product.ProductId,xref.Product.Description, orderQuantity,xref.UnitCost,totalCost);
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (dgvSupplier.Rows.Count > 0)
            {
                var selectedIndex = dgvSupplier.CurrentCell.RowIndex;
                if (selectedIndex != -1)
                {
                    if (!string.IsNullOrEmpty(fQuantity))
                    {
                        var xrefId = dgvSupplier.Rows[selectedIndex].Cells["XrefId"].Value.ToString();
                        var dbXref = Business.Facades.SupplierProductRef.GetById(Convert.ToInt32(xrefId));
                        var orderQuantity = Convert.ToInt32(fQuantity);
                        CreateRow(dbXref, orderQuantity);
                        fQuantity = string.Empty;

                        var thisCost = dbXref.UnitCost * orderQuantity;
                        var totalCost = string.IsNullOrEmpty(TotalOrderCost) ? 0 : Convert.ToDouble(TotalOrderCost);
                        //New total
                        TotalOrderCost = (thisCost + totalCost).ToString();
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Please enter quantity first.");
                    }
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Please select a product first.");
                }
            }

            if (dgvCart.Rows.Count != 0)
            {
                dgvCart.CurrentCell = dgvCart.Rows[dgvCart.Rows.Count - 1].Cells[1];
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
            TotalOrderCost = string.Empty;
        }

        private void cbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            cbSearch.DroppedDown = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
             if (dgvCart.Rows.Count > 0) {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Create purchase order?", "Confirmation")) {

                    var OrderDetailList = new List<Business.Models.ProductOrderDetails>();
                    for (int x = 0; x < dgvCart.Rows.Count; x++) {
                        var productId = dgvCart.Rows[x].Cells["ProductId"].Value.ToString();
                        var orderQuantity = dgvCart.Rows[x].Cells["OrderQuantity"].Value.ToString();

                        var orderDetails = new Business.Models.ProductOrderDetails {
                            ProductId = Convert.ToInt32(productId),
                            OrderQuantity = Convert.ToInt32(orderQuantity),
                            CreationDate = DateTime.Now,
                        };
                        OrderDetailList.Add(orderDetails);
                    }

                    var Orders = new Business.Models.ProductOrder()
                    {
                        SupplierId = fSupplierId != null ? (int)fSupplierId : 0,
                        OrderStatusId = Business.Enums.OrderStatus.Pending,
                        OrderDetails = OrderDetailList,
                    };

                    var AddOrders = Business.Facades.ProductOrder.AddOrders(Orders);
                    if (AddOrders)
                    {
                        Helpers.MessageBoxHelper.ShowInformationDialog("Orders successfully added.", "Success");
                        Clear(true);
                    }
                    else {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Error adding orders. Please contact your administrator.");
                    }
                }
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 0) {
                var selectedIndex = dgvCart.CurrentCell.RowIndex;

                //adjust totalcost
                var thisCost = Convert.ToDouble(dgvCart.Rows[selectedIndex].Cells["TotalCost"].Value.ToString());
                var totalCost = string.IsNullOrEmpty(TotalOrderCost) ? 0 : Convert.ToDouble(TotalOrderCost);
                //New total
                TotalOrderCost = (totalCost - thisCost).ToString();

                dgvCart.Rows.RemoveAt(selectedIndex);

                
            }
        }

        private void TxtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (Helpers.TextboxHelper.checkNumeric(txtQuantity.Text))
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input numbers only.");
                txtQuantity.Text = "";
            }
        }

        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            var suppliers = Business.Facades.Supplier.GetAll();
            if (suppliers != null)
            {
                cbSearch.DataSource = suppliers.Select(c => new { c.SupplierId, c.SupplierName }).ToList();
                cbSearch.DisplayMember = "SupplierName";
                cbSearch.ValueMember = "SupplierId";
                cbSearch.SelectedIndex = -1;
            }
        }

        private void DgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
