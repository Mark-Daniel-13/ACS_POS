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
   
    public partial class frmPurchaseHistory : Form
    {
        DateTimePicker dtp;
        Rectangle _Rectangle;

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
       
        private int? fSupplierId { get; set; }

        private List<int> ChangesListIndex = new List<int>();
        private int prevIndex { get; set; }
        #endregion
        
        public frmPurchaseHistory()
        {
            InitializeComponent();
            prevIndex = 0;

            //Set theme
            SetTheme();
            dtp = new DateTimePicker();
            dgvOrderDetails.Controls.Add(dtp);
            dtp.Visible = false;
            dtp.Format = DateTimePickerFormat.Custom;
            dtp.Leave += new EventHandler(dtp_Leave);
            dtp.MinDate = DateTime.Now.AddDays(1);
            cbSearch.SelectedIndex = -1;
        }
        public void SetTheme()
        {
            //Set theme
            Color selectedColor;
            if (Business.Globals.LightTheme)
            {
                selectedColor = Business.Globals.BackgroundThemeColorLight;
                //Datagrid
                dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvOrders.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvOrders.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;

                dgvOrderDetails.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvOrderDetails.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvOrderDetails.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
               
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnView.BackColor = Business.Globals.lightButtoncolor;
                btnModify.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
                btnDelivered.BackColor = Business.Globals.lightButtoncolor;

                //Fonts
                grpOrders.ForeColor = Business.Globals.darkLabelcolor;
                grpOrderDetails.ForeColor = Business.Globals.darkLabelcolor;
                lbSearch.ForeColor = Business.Globals.darkLabelcolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvOrders.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvOrders.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvOrders.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;

                dgvOrderDetails.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvOrderDetails.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvOrderDetails.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
              
                //Buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnView.BackColor = Business.Globals.darkButtoncolor;
                btnModify.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
                btnDelivered.BackColor = Business.Globals.darkButtoncolor;

                //Fonts
                grpOrders.ForeColor = Business.Globals.lightLabelcolor;
                grpOrderDetails.ForeColor = Business.Globals.lightLabelcolor;
                lbSearch.ForeColor = Business.Globals.lightLabelcolor;
            }
            //Background Color
            BackColor = selectedColor;
            dgvOrders.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
            dgvOrderDetails.DefaultCellStyle.ForeColor = Business.Globals.darkLabelcolor;
        }

        private void LoadOrders()
        {
            var supplier = Business.Facades.Supplier.GetByName(fSearchSupplier);
           
            if (supplier != null)
            {
                fSupplierId = supplier.SupplierId;
                var orderList = Business.Facades.ProductOrder.GetBySupplierId(supplier.SupplierId);
                if (orderList != null && orderList.Count>0)
                {
                    var orderVMList = ViewModels.ProductOrderViewModel.ToViewModelList(orderList);
                    dgvOrders.AutoGenerateColumns = false;
                    dgvOrders.DataSource = orderVMList;

                    loadDetails();
                }
                else {
                    Clear();
                }
            }
            else
            {
                Clear();
            }
        }
        private void Clear() {
            fSupplierId = null;
            dgvOrders.DataSource = null;
            dgvOrders.Rows.Clear();
            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.Rows.Clear();

        }
        private void ViewOrderDetail(int orderId)
        {
            frmPurchaseOrderView view = new frmPurchaseOrderView(orderId);
            view.ShowDialog();
        }
        private void LoadOrderDetails(int orderId)
        {
            var orderDetails = Business.Facades.ProductOrderDetails.GetByProductOrderId(orderId);
            if (orderDetails.Count > 0 && orderDetails != null)
            {
                var detailVMList = ViewModels.ProductOrderDeitalViewModel.ToViewModelList(orderDetails);

                dgvOrderDetails.AutoGenerateColumns = false;
                dgvOrderDetails.DataSource = detailVMList;

            }
            else
            {
                dgvOrderDetails.DataSource = null;
                dgvOrderDetails.Rows.Clear();
            }

            ChangesListIndex = new List<int>();
            prevIndex = 0;
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void cbSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSearch.Items.Count != 0)
            {
                LoadOrders();
            }
        }

        private void cbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            cbSearch.DroppedDown = true;
        }

        private void btnDelivered_Click(object sender, EventArgs e)
        {
            if (dgvOrders.Rows.Count > 0)
            {
                
                var selectedIndex = dgvOrders.CurrentCell.RowIndex;
                var status = dgvOrders.Rows[selectedIndex].Cells["OrderStatusId"].Value.ToString();
                if (status == "Pending")
                {
                    if (checkExpDateFields())
                    {
                        if (selectedIndex != -1)
                        {
                            if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to accept purchase order?", "Confirmation"))
                            {
                                var orderId = Convert.ToInt32(dgvOrders.Rows[selectedIndex].Cells["ProductOrderid"].Value.ToString());

                                var updateOrder = Business.Facades.ProductOrder.UpdateStatus(orderId, Business.Enums.OrderStatus.Received);
                                if (updateOrder)
                                {
                                    var orderDetailIdList = dgvOrderDetails.Rows.Cast<DataGridViewRow>().Select(s =>Convert.ToInt32(s.Cells["OrderDetailsId"].Value)).ToList();
                                    var expirationList = dgvOrderDetails.Rows.Cast<DataGridViewRow>().Select(s => Convert.ToDateTime(s.Cells["ExpirationDate"].Value)).ToList();
                                    var updateFinalUnitCost = Business.Facades.ProductOrderDetails.OrderDeliveredUpdateFinalUnitCost(orderId,orderDetailIdList,expirationList);
                                    if (updateFinalUnitCost)
                                    {
                                        LoadOrders();
                                        Helpers.MessageBoxHelper.ShowInformationDialog("Order successfully delivered! Stocks have been updated.", "Success");
                                        dtp.Visible = false;
                                        dtp.MinDate = DateTime.Now.AddDays(1);
                                    }
                                }
                                else
                                {
                                    Helpers.MessageBoxHelper.ShowErrorDialog("Error updating order. Please contact your administrator.");
                                }
                            }
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Please enter valid expiration date.");
                    }
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog(string.Format("Order status is already {0}.", status));
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvOrders.Rows.Count > 0)
            {
                var selectedIndex = dgvOrders.CurrentCell.RowIndex;
                var status = dgvOrders.Rows[selectedIndex].Cells["OrderStatusId"].Value.ToString();
                if (status == "Pending")
                {
                    if (Helpers.MessageBoxHelper.ShowYesNoDialog("Cancel the selected order?", "Confirmation"))
                    {
                        if (selectedIndex != -1)
                        {
                            var orderId = Convert.ToInt32(dgvOrders.Rows[selectedIndex].Cells["ProductOrderid"].Value.ToString());

                            var updateOrder = Business.Facades.ProductOrder.UpdateStatus(orderId, Business.Enums.OrderStatus.Cancelled);
                            if (updateOrder)
                            {
                                LoadOrders();
                                Helpers.MessageBoxHelper.ShowInformationDialog("Order successfully cancelled.", "Success");
                            }
                            else
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Error updating order. Please contact your administrator.");
                            }
                        }
                    }
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog(string.Format("Order status is already {0}", status));
                }
            }
        }
        private bool checkExpDateFields()
        {
            var emptyFields = dgvOrderDetails.Rows.Cast<DataGridViewRow>().Where(s => s.Cells["ExpirationDate"].Value == null).ToList();

            if (emptyFields.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvOrders.Rows.Count > 0)
            {
                var selectedIndex = dgvOrders.CurrentCell.RowIndex;

                if (selectedIndex != -1 && !string.IsNullOrEmpty(fSearchSupplier))
                {
                    var orderId = Convert.ToInt32(dgvOrders.Rows[selectedIndex].Cells["ProductOrderid"].Value.ToString());
                    ViewOrderDetail(orderId);

                }
            }
        }
        private void loadDetails() {
            var selectedIndex = dgvOrders.CurrentCell.RowIndex;
            if (selectedIndex != -1 && !string.IsNullOrEmpty(fSearchSupplier))
            {
                var orderId = Convert.ToInt32(dgvOrders.Rows[selectedIndex].Cells["ProductOrderid"].Value.ToString());
                LoadOrderDetails(orderId);

                var status = dgvOrders.Rows[selectedIndex].Cells["OrderStatusId"].Value.ToString();
                if (status == "Pending")
                {
                    dgvOrderDetails.Columns["ExpirationDate"].ReadOnly = false;
                }
                else {
                    dgvOrderDetails.Columns["ExpirationDate"].ReadOnly = true;
                }
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDetails();
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDetails();
        }
        private void recordChangesIndex(int rowIndex) {
            if (dgvOrderDetails.Rows.Count>0)
            {
                if (!ChangesListIndex.Contains(rowIndex))
                {
                    ChangesListIndex.Add(rowIndex);
                }

            }
        }

        private void dgvOrderDetails_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvOrderDetails_CellContentClick(sender, e);

            recordChangesIndex(prevIndex);
            
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderDetails.Rows.Count > 0)
            {
                prevIndex = dgvOrderDetails.CurrentCell.RowIndex;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (dgvOrders.Rows.Count > 0)
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to update order details?", "Confirmation"))
                {
                    ChangesListIndex.ForEach(index =>
                    {

                        var currentOrderDetailId = Convert.ToInt32(dgvOrderDetails.Rows[index].Cells["OrderDetailsId"].Value.ToString());

                        var productId = Convert.ToInt32(dgvOrderDetails.Rows[index].Cells["ProductId"].Value.ToString());
                        var newtOrderQuantity = Convert.ToInt32(dgvOrderDetails.Rows[index].Cells["OrderQuantity"].Value.ToString());
                        var selectedIndex = dgvOrders.CurrentCell.RowIndex;
                        var orderId = Convert.ToInt32(dgvOrders.Rows[selectedIndex].Cells["ProductOrderid"].Value.ToString());

                        var newUnitCost = Convert.ToDouble(dgvOrderDetails.Rows[index].Cells["ProductUnitCost"].Value);

                        var newOrderModel = new Business.Models.ProductOrderDetails()
                        {
                            ProductOrderId = orderId,
                            ProductId = productId,
                            OrderQuantity = newtOrderQuantity,
                        };

                        var update = Business.Facades.ProductOrderDetails.ModifyOrderDetail(newOrderModel, currentOrderDetailId, newUnitCost, Convert.ToInt32(fSupplierId));
                    });

                    Helpers.MessageBoxHelper.ShowInformationDialog("Order Details successfully updated.", "Success");
                    loadDetails();
                }
            }
        }

        private void DgvOrderDetails_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           
            var txtQuantity = e.Control as TextBox;
            if (txtQuantity != null)
            {
                if (dgvOrderDetails.CurrentCell.ColumnIndex == 6)
                {
                    //column index 6 is the expiration date. change the format validation for date formats
                    txtQuantity.KeyPress += new KeyPressEventHandler(txtExpDate_Keypress);
                }
                else
                {
                    txtQuantity.KeyPress += new KeyPressEventHandler(txtQuantity_Keypress);
                }
            }
        }
        private void txtExpDate_Keypress(object sender, KeyPressEventArgs e)  
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e,false,true);
        }
        private void txtQuantity_Keypress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }

        private void DgvOrderDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            if (index >= 0)
            {
                var quantity = Convert.ToDouble(dgvOrderDetails.Rows[index].Cells["OrderQuantity"].Value);
                var productunicost = Convert.ToDouble(dgvOrderDetails.Rows[index].Cells["ProductUnitCost"].Value);
                dgvOrderDetails.Rows[index].Cells["ProductTotalUnitCost"].Value = Convert.ToDouble(string.Format("{0:n2}", quantity * productunicost));
            }
        }
        private bool CheckDateFormat(int index,string date)
        {
            try {
                //var fullDate = string.Format("{0} {1}", dgvOrderDetails.Rows[index].Cells["ExpirationDate"].Value, DateTime.Now.ToString("hh:ss"));
                Convert.ToDateTime(date);
                return true;
            } catch {
                return false;
            }
        }

        private void dgvOrderDetails_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var validateText = e.FormattedValue.ToString();
            var index = e.RowIndex;
            if (dgvOrderDetails.CurrentCell.ColumnIndex == 6)
            {
                
                if (!string.IsNullOrEmpty(validateText))
                {
                    //check if the exp date is in correct format MM/dd/yyyy
                    if (!CheckDateFormat(index, validateText))
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Invalid Date format!", "Invalid Date Format");
                        e.Cancel = true;
                        return;
                    }
                }
                dtp.Visible = false;
            }
            else {
                if (string.IsNullOrEmpty(validateText)) {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Please enter a value greater than or equal to zero!", "Invalid Format");
                    e.Cancel = true;
                }
            }
        }

        private void DgvOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedIndex = dgvOrders.CurrentCell.RowIndex;
            var status = dgvOrders.Rows[selectedIndex].Cells["OrderStatusId"].Value.ToString();
            if (status == "Pending")
            {
                if (dgvOrderDetails.CurrentCell.ColumnIndex == 6)
                {
                    switch (dgvOrderDetails.Columns[e.ColumnIndex].Name)
                    {
                        case "ExpirationDate":

                            _Rectangle = dgvOrderDetails.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true); //  
                            dtp.Size = new Size(_Rectangle.Width, _Rectangle.Height); //  
                            dtp.Location = new Point(_Rectangle.X, _Rectangle.Y); //  
                            dtp.Visible = true;
                            break;

                    }
                }
            }
        }
        private void dtp_Leave(object sender, EventArgs e)
        {
            dgvOrderDetails.CurrentCell.Value = dtp.Text.ToString();
        }

        private void DgvOrderDetails_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (dtp != null)
            {
                dtp.Visible = false;
            }
        }

        private void DgvOrderDetails_Scroll(object sender, ScrollEventArgs e)
        {
            if (dtp != null)
            {
                dtp.Visible = false;
            }
        }
    }
}

