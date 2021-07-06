using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.SubForms.Admin
{
   
    public partial class frmInventories : Form
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

        #region Form Field Properties
        private string fInventoryId
        {
            get { return lblInventoryIdValue.Text; }
            set { lblInventoryIdValue.Text = value; }
        }
        private string PriceUpdate {
            get { return lblPriceUpdate.Text; }
            set { lblPriceUpdate.Text = value; }
        }

        private int fProductId { get; set; }

        private int fPriceId { get; set; }

        private string fBarcode
        {
            get { return txtBarcode.Text; }
            set { txtBarcode.Text = value; }
        }
        private string fCategoryName
        {
            get { return cmbCategory.Text; }
            set { cmbCategory.Text = value; }
        }

        private string fDescription
        {
            get { return txtDescription.Text; }
            set { txtDescription.Text = value; }
        }


        private string fFullDescription
        {
            get { return txtFullDescription.Text; }
            set { txtFullDescription.Text = value; }
        }

        private string fRetailPrice
        {
            get { return txtRetailPrice.Text; }
            set { txtRetailPrice.Text = value; }
        }

        private string fWholesalePrice
        {
            get { return txtWholesalePrice.Text; }
            set { txtWholesalePrice.Text = value; }
        }

        private int? fCategoryId
        {
            get { return (int?)cmbCategory.SelectedValue; }
            set { cmbCategory.SelectedValue = value; }
        }
        private string fQuantity
        {
            get { return txtQuantity.Text; }
            set { txtQuantity.Text = value; }
        }

        private string fUOM
        {
            get { return txtUOM.Text; }
            set { txtUOM.Text = value; }
        }
        private string fCriticalInv
        {
            get { return txtCriticalInv.Text; }
            set { txtCriticalInv.Text = value; }
        }
        private string fMinInv
        {
            get { return txtMinInv.Text; }
            set { txtMinInv.Text = value; }
        }
        private string fMaxInv
        {
            get { return txtMaxInv.Text; }
            set { txtMaxInv.Text = value; }
        }
        public string fSupplierList
        {
            get { return lblSupplierList.Text; }
            set { lblSupplierList.Text = value; }
        }
        public List<double?> UnitCostList { get; set; }
        private string fSearchText
        {
            get { return txtInventorySearch.Text; }
            set { txtInventorySearch.Text = value; }
        }
        private int currentPage { get; set; }
        private int maxPage { get; set; }
        private int itemPerPageCount { get; set; }
        private bool isSearching { get; set; }
        #endregion

        public frmInventories()
        {
            InitializeComponent();
            currentPage = 1;
            itemPerPageCount = 10;
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
                dgvInventories.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.lightDgvHeadercolor;
                dgvInventories.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvHeaderSelectioncolor;
                dgvInventories.DefaultCellStyle.SelectionBackColor = Business.Globals.lightDgvDefaultcellcolor;
                pnlHeader.BackColor = Business.Globals.lightDgvHeadercolor;
                pnlAEcontainer.BackColor = Business.Globals.BackgroundThemeColorLight;
                //fonts
                grpInventoryInfo.ForeColor = Business.Globals.darkLabelcolor;
                grpInventoryData.ForeColor = Business.Globals.darkLabelcolor;
                lblInventorySearch.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnAddnewitem.BackColor = Business.Globals.lightButtoncolor;
                btnUpdateInventory.BackColor = Business.Globals.lightButtoncolor;
                btnAddInventory.BackColor = Business.Globals.lightButtoncolor;
                btnInventorycancel.BackColor = Business.Globals.lightButtoncolor;
                btnSelectSupplier.BackColor = Business.Globals.lightButtoncolor;
                btnExpList.BackColor = Business.Globals.lightButtoncolor;
                btnPrev.BackColor = Business.Globals.lightButtoncolor;
                btnNext.BackColor = Business.Globals.lightButtoncolor;



            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //Datagrid
                dgvInventories.ColumnHeadersDefaultCellStyle.BackColor = Business.Globals.darkDgvHeadercolor;
                dgvInventories.ColumnHeadersDefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvHeaderSelectioncolor;
                dgvInventories.DefaultCellStyle.SelectionBackColor = Business.Globals.darkDgvDefaultcellcolor;
                pnlHeader.BackColor = Business.Globals.darkDgvHeadercolor;
                pnlAEcontainer.BackColor = Business.Globals.BackgroundThemeColor;
                //font
                grpInventoryInfo.ForeColor = Business.Globals.lightLabelcolor;
                grpInventoryData.ForeColor = Business.Globals.lightLabelcolor;
                lblInventorySearch.ForeColor = Business.Globals.lightLabelcolor;
                //Buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnAddnewitem.BackColor = Business.Globals.darkButtoncolor;
                btnUpdateInventory.BackColor = Business.Globals.darkButtoncolor;
                btnAddInventory.BackColor = Business.Globals.darkButtoncolor;
                btnInventorycancel.BackColor = Business.Globals.darkButtoncolor;
                btnSelectSupplier.BackColor = Business.Globals.darkButtoncolor;
                btnExpList.BackColor = Business.Globals.darkButtoncolor;
                btnPrev.BackColor = Business.Globals.darkButtoncolor;
                btnNext.BackColor = Business.Globals.darkButtoncolor;

            }
            //Background Color
            BackColor = selectedColor;
        }

        #region Helpers
        private void LoadInventories()
        {
            maxPage = Helpers.Paging.GetTotalPage(Business.Facades.Inventories.GetTotalItems(), itemPerPageCount);
            var inventories = Business.Facades.Inventories.GetAll(itemPerPageCount,currentPage);
            if (inventories != null)
            {
                dgvInventories.DataSource = null;
                dgvInventories.Rows.Clear();

                dgvInventories.AutoGenerateColumns = false;
                inventories.ForEach(inventory =>
                {
                    CreateRow(inventory);
                });

                isSearching = false;
                lblPage.Text = string.Format("/{0}", maxPage == 0 ? 0 : maxPage);
                tbCurrentPage.Text = maxPage != 0 ? currentPage.ToString() : maxPage.ToString();
            }
        }
        private void SearchInventories()
        {
            maxPage = Helpers.Paging.GetTotalPage(Business.Facades.Inventories.GetTotalSearchedItems(fSearchText), itemPerPageCount);
            var inventories = Business.Facades.Inventories.Search(fSearchText,itemPerPageCount,currentPage);
            if (inventories != null)
            {
                dgvInventories.DataSource = null;
                dgvInventories.Rows.Clear();

                dgvInventories.AutoGenerateColumns = false;
                inventories.ForEach(inventory =>
                {
                    CreateRow(inventory);
                });

                isSearching = true;
                lblPage.Text = string.Format("/{0}", maxPage);
                tbCurrentPage.Text = maxPage != 0 ? currentPage.ToString() : maxPage.ToString();
            }
        }
        private void CreateRow(Business.Models.Inventories inventory) {
            string AllSupplierString = Business.Facades.SupplierProductRef.GetAllSupplierByProductIdString(inventory.Product.ProductId);
            var suppliers = AllSupplierString != null ? AllSupplierString : "";
            var categoryname = inventory.Product.Category != null ? inventory.Product.Category.Name : null;
            dgvInventories.Rows.Add(inventory.InventoryId, inventory.ProductId, inventory.Product.CategoryId, inventory.Product.PriceId, inventory.Product.Barcode, inventory.Product.Description, inventory.Product.FullDescription, categoryname, inventory.Product.Price.RetailPrice, inventory.Product.Price.WholesalePrice, suppliers, inventory.MinimumInventory, inventory.CriticalInventory, inventory.MaximumInventory, inventory.Quantity, inventory.UOM); 

            //if low in inventory change highlight color
            var rowIndex = dgvInventories.Rows.Count - 1;
            if (inventory.Quantity <= inventory.CriticalInventory)
            {
                dgvInventories.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(241, 148, 170);
                dgvInventories.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

                //move the current row to top
                var currentRow = dgvInventories.Rows[rowIndex];
                dgvInventories.Rows.Remove(currentRow);
                dgvInventories.Rows.Insert(0, currentRow);
            }
            else
            {
                dgvInventories.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvInventories.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }

        }
        private void CreateRow(Business.Models.InventoryProductCategoryPrice inventory)
        {
            string AllSupplierString = Business.Facades.SupplierProductRef.GetAllSupplierByProductIdString(inventory.ProductId);
            var suppliers = AllSupplierString != null ? AllSupplierString : "";
            var categoryname = inventory.CategoryName != null ? inventory.CategoryName : null;
            dgvInventories.Rows.Add(inventory.InventoryId, inventory.ProductId, inventory.CategoryId, inventory.PriceId, inventory.Barcode, inventory.ProductDescription, inventory.ProductFullDescription, categoryname, inventory.RetailPrice, inventory.WholesalePrice, suppliers, inventory.MinInventory, inventory.CriticalInventory, inventory.MaxInventory, inventory.Quantity, inventory.UOM); ;

            //if low in inventory change highlight color
            var rowIndex = dgvInventories.Rows.Count - 1;
            if (inventory.Quantity <= inventory.CriticalInventory)
            {
                dgvInventories.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(241, 148, 170);
                dgvInventories.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;

                //move the current row to top
                var currentRow = dgvInventories.Rows[rowIndex];
                dgvInventories.Rows.Remove(currentRow);
                dgvInventories.Rows.Insert(0, currentRow);
            }
            else
            {
                dgvInventories.Rows[rowIndex].DefaultCellStyle.BackColor = Color.White;
                dgvInventories.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.Black;
            }

        }
        private void cmbCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            cmbCategory.DroppedDown = true;
        }
        private void LoadCategories(int categoryId = 0)
        {
            var categories = Business.Facades.Categories.GetAll();
            if (categories != null)
            {
                cmbCategory.DataSource = categories.Select(c => new { c.CategoryId, c.Name }).OrderBy(o => o.Name).ToList();
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.SelectedIndex = -1;
                if (categoryId > 0)
                {
                    cmbCategory.SelectedIndex = categoryId;
                }
            }
        }

        private bool CheckFields(bool checkId = false)
        {
            bool valid = false;
            if (!string.IsNullOrEmpty(fDescription)
                && !string.IsNullOrEmpty(fFullDescription)
                //&& fExpirationDate != null
                    )
            {
                if (!string.IsNullOrEmpty(fRetailPrice)
                    && !string.IsNullOrEmpty(fWholesalePrice)
                    && !string.IsNullOrEmpty(fQuantity)
                    && !string.IsNullOrEmpty(fMinInv)
                    && !string.IsNullOrEmpty(fMaxInv)
                    && !string.IsNullOrEmpty(fCriticalInv)
                    )
                {
                    if (IsDouble(fRetailPrice) && IsDouble(fWholesalePrice) && IsDouble(fQuantity) && IsDouble(fMinInv) && IsDouble(fMaxInv) && IsDouble(fCriticalInv))
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                }

                if (checkId)
                {
                    if (!string.IsNullOrEmpty(fInventoryId) && (fProductId > 0) && (fPriceId > 0) && !string.IsNullOrEmpty(fBarcode))
                    {
                        valid = true;
                    }
                    else
                    {
                        valid = false;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(fInventoryId) && (fProductId > 0) && (fPriceId > 0))
                    {
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }
            return valid;
        }

        private void ClearFields()
        {
            fInventoryId = string.Empty;
            fProductId = 0;
            fPriceId = 0;
            fCategoryId = 0;
            fBarcode = string.Empty;
            fDescription = string.Empty;
            fFullDescription = string.Empty;
            fRetailPrice = string.Empty;
            fWholesalePrice = string.Empty;
            //fExpirationDate = SetDefaultDateValue();
            fQuantity = string.Empty;
            fUOM = string.Empty;
            fMaxInv = string.Empty;
            fMinInv = string.Empty;
            fCriticalInv = string.Empty;
            fSupplierList = string.Empty;
            lblPriceUpdate.Text = string.Empty;
            errorProvider.Clear();
        }

        private bool IsDouble(string value)
        {
            try
            {
                double result = 0;
                return (double.TryParse(value, System.Globalization.NumberStyles.Float,
                        System.Globalization.NumberFormatInfo.CurrentInfo, out result));
            }
            catch
            {
                return false;
            }
        }
        #endregion
        

        #region Form Events


        private void frmInventories_Load(object sender, EventArgs e)
        {
            txtInventorySearch.Focus();
            LoadInventories();
            LoadCategories();
            //fExpirationDate = SetDefaultDateValue();
            //dgvInventories.AllowUserToResizeColumns = false;
            //dgvInventories.AllowUserToResizeRows = false;
            
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
        
            ClearFields();
            btnAddInventory.Enabled = true;

        }
        private bool CheckRequired(List<TextBox> textboxList) {
            bool hasErrors = false;
            textboxList.ForEach(textbox =>
            {
                var Result = Helpers.TextboxHelper.ValidateTextBox(textbox, errorProvider);
                if (hasErrors == false && Result == false) {
                    hasErrors = true;
                }
            });

            return hasErrors;
        }
        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxList = new List<TextBox>();
            textBoxList.Add(txtDescription);
            textBoxList.Add(txtFullDescription);
            bool valid = CheckFields();
            if (!CheckRequired(textBoxList) && valid)
            {
               
                if (Business.Facades.Products.GetByProductBarcode(fBarcode) == null)
                {
                    //check if the value of min inventory is lower than max inventory
                    var minInv = !string.IsNullOrEmpty(fMinInv) ? Convert.ToInt32(fMinInv) : 0;
                    var maxInv = !string.IsNullOrEmpty(fMaxInv) ? Convert.ToInt32(fMaxInv) : 0;
                    if (minInv <= maxInv)
                    {

                        if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to add the inventory?", "Confirmation"))
                        {
                            if (Business.Facades.Products.IsExists(fBarcode))
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Product already exsists.");
                                return;
                            }

                            var price = new Business.Models.Prices()
                            {
                                RetailPrice = !string.IsNullOrEmpty(fRetailPrice) ? Convert.ToDouble(fRetailPrice) : (double?)null,
                                WholesalePrice = !string.IsNullOrEmpty(fWholesalePrice) ? Convert.ToDouble(fWholesalePrice) : (double?)null,
                            };

                            var product = new Business.Models.Products()
                            {
                                CategoryId = fCategoryId > 0 ? Convert.ToInt32(fCategoryId) : (int?)null,
                                Price = price,
                                Barcode = string.IsNullOrEmpty(fBarcode) ? Business.Helpers.BarcodeHelper.GenerateNewBarcode() : fBarcode,
                                Description = fDescription,
                                FullDescription = fFullDescription,
                                //ExpirationDate = fExpirationDate,
                            };

                            var inventory = new Business.Models.Inventories()
                            {
                                Quantity = !string.IsNullOrEmpty(fQuantity) ? Convert.ToDouble(fQuantity) : (double?)null,
                                Product = product,
                                UOM = fUOM,
                                MaximumInventory = !string.IsNullOrEmpty(fMaxInv) ? Convert.ToInt32(fMaxInv) : (int?)null,
                                MinimumInventory = !string.IsNullOrEmpty(fMinInv) ? Convert.ToInt32(fMinInv) : (int?)null,
                                CriticalInventory = !string.IsNullOrEmpty(fCriticalInv) ? Convert.ToInt32(fCriticalInv) : (int?)null,
                            };

                            //Add to log the new generated barcode
                            //if (string.IsNullOrEmpty(fBarcode)) {
                            //    var barcodeModel = new Business.Models.Barcode()
                            //    {
                            //        BarcodeText = Business.Helpers.BarcodeHelper.GenerateNewBarcode(),
                            //    };

                            //    Business.Facades.Barcode.AddBarcode(barcodeModel);
                            //}

                            var newSupplierLists = !string.IsNullOrEmpty(fSupplierList) ? fSupplierList.Split(',') : null;
                            bool success = Business.Facades.Inventories.AddInventory(inventory, newSupplierLists,UnitCostList);
                            if (success)
                            {
                                LoadInventories();
                                LoadCategories();
                                ClearFields();
                                Helpers.MessageBoxHelper.ShowInformationDialog("Inventory has been successfully added.", "Success");
                            }
                            else
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Error adding inventory. Please contact your administrator.");
                            }
                        }
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Please check your inputs,Minimum inventory should not be higher than Maximum inventory.");
                    }
                }else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog(string.Format("Barcode: {0} is already existing. Please check your inputs.", fBarcode));
                }
            }
            else
            {
                
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Please input the complete and correct inventory information.");
                }
            }
        }

        private void btnUpdateInventory_Click(object sender, EventArgs e)
        {
            bool valid = CheckFields(true);
            if (valid)
            {
                if (Business.Facades.Products.GetByProductBarcode(fBarcode,fProductId) == null)
                {
                    //check if the value of min inventory is lower than max inventory
                    var minInv = !string.IsNullOrEmpty(fMinInv) ? Convert.ToInt32(fMinInv) : 0;
                    var maxInv = !string.IsNullOrEmpty(fMaxInv) ? Convert.ToInt32(fMaxInv) : 0;
                    if (minInv <= maxInv)
                    {

                        if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to update the inventory?", "Confirmation"))
                        {
                            if (Business.Facades.Products.IsExists(fProductId, fBarcode))
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Product already exsists.");
                                return;
                            }

                            var price = new Business.Models.Prices()
                            {
                                PriceId = fPriceId > 0 ? Convert.ToInt32(fPriceId) : 0,
                                RetailPrice = !string.IsNullOrEmpty(fRetailPrice) ? Convert.ToDouble(fRetailPrice) : (double?)null,
                                WholesalePrice = !string.IsNullOrEmpty(fWholesalePrice) ? Convert.ToDouble(fWholesalePrice) : (double?)null
                            };

                            var product = new Business.Models.Products()
                            {
                                ProductId = fProductId > 0 ? Convert.ToInt32(fProductId) : 0,
                                CategoryId = fCategoryId > 0 ? Convert.ToInt32(fCategoryId) : (int?)null,
                                PriceId = fPriceId > 0 ? Convert.ToInt32(fPriceId) : 0,
                                Price = price,
                                Barcode = fBarcode,
                                Description = fDescription,
                                FullDescription = fFullDescription,
                                //ExpirationDate = fExpirationDate
                            };

                            var inventory = new Business.Models.Inventories()
                            {
                                InventoryId = Convert.ToInt32(fInventoryId),
                                ProductId = fProductId > 0 ? Convert.ToInt32(fProductId) : 0,
                                Product = product,
                                Quantity = !string.IsNullOrEmpty(fQuantity) ? Convert.ToDouble(fQuantity) : (double?)null,
                                UOM = fUOM,
                                MaximumInventory = !string.IsNullOrEmpty(fMaxInv) ? Convert.ToInt32(fMaxInv) : (int?)null,
                                MinimumInventory = !string.IsNullOrEmpty(fMinInv) ? Convert.ToInt32(fMinInv) : (int?)null,
                                CriticalInventory = !string.IsNullOrEmpty(fCriticalInv) ? Convert.ToInt32(fCriticalInv) : (int?)null,
                            };

                            var newSupplierLists = !string.IsNullOrEmpty(fSupplierList) ? fSupplierList.Split(',') : null;

                            bool success = Business.Facades.Inventories.UpdateInventory(inventory, newSupplierLists,UnitCostList);
                            if (success)
                            {
                                LoadInventories();
                                LoadCategories();
                                ClearFields();
                                Helpers.MessageBoxHelper.ShowInformationDialog("Inventory has been successfully updated.", "Success");
                                pnlAEcontainer.Visible = false;
                                btnAddnewitem.Enabled = true;
                                btnPrev.Enabled = true;
                                btnNext.Enabled = true;
                            }
                            else
                            {
                                Helpers.MessageBoxHelper.ShowErrorDialog("Error updating inventory. Please contact your Administrator.");
                            }
                        }

                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Please check your inputs,Minimum inventory should not be higher than Maximum inventory.");
                    }
                }
                else {
                    Helpers.MessageBoxHelper.ShowErrorDialog(string.Format("Barcode: {0} is already existing. Please check your inputs.",fBarcode));
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please input the complete and correct inventory information.");
            }
        }

        private void btnDeleteInventory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fInventoryId) && (fProductId > 0) && (fPriceId > 0))
            {
                if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to delete the inventory?", "Confirmation"))
                {
                    bool success = Business.Facades.Inventories.DeleteInventory(Convert.ToInt32(fInventoryId));
                    if (success)
                    {
                        LoadInventories();
                        LoadCategories();
                        ClearFields();
                        Helpers.MessageBoxHelper.ShowInformationDialog("Inventory has been successfully deleted.", "Success");
                        btnAddInventory.Enabled = true;
                    }
                    else
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Error deleting inventory. Please contact your administrator.");
                    }
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please select the inventory to delete.");
            }
        }

        private void dgvInventories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            errorProvider.Clear();
            btnAddInventory.Visible = false;
            //btnUpdateInventory.Visible = false;
            if (e.ColumnIndex == 16)
            {
                pnlAEcontainer.Visible = true;
                btnUpdateInventory.Visible = true;
                ToggleBottomMenu(false);
                if (e.RowIndex >= 0)
                {
                    var selectedRow = this.dgvInventories.Rows[e.RowIndex];

                    fInventoryId = selectedRow.Cells["InventoryId"].Value.ToString();
                    fProductId = (int)selectedRow.Cells["ProductId"].Value;
                    fPriceId = (int)selectedRow.Cells["PriceId"].Value;
                    fCategoryId = selectedRow.Cells["CategoryId"].Value != null ? (int)selectedRow.Cells["CategoryId"].Value : 0;
                    fBarcode = selectedRow.Cells["Barcode"].Value.ToString();
                    fDescription = selectedRow.Cells["Description"].Value.ToString();
                    fFullDescription = selectedRow.Cells["FullDescription"].Value != null ? selectedRow.Cells["FullDescription"].Value.ToString() : null;
                    fRetailPrice = selectedRow.Cells["RetailPrice"].Value != null ? selectedRow.Cells["RetailPrice"].Value.ToString() : null;
                    fWholesalePrice = selectedRow.Cells["WholesalePrice"].Value != null ? selectedRow.Cells["WholesalePrice"].Value.ToString() : null;
                    fMinInv = selectedRow.Cells["MinInventory"].Value != null ? selectedRow.Cells["MinInventory"].Value.ToString() : null;
                    fMaxInv = selectedRow.Cells["MaxInventory"].Value != null ? selectedRow.Cells["MaxInventory"].Value.ToString() : null;
                    fCriticalInv = selectedRow.Cells["CriticalInventory"].Value != null ? selectedRow.Cells["CriticalInventory"].Value.ToString() : null;
                    fSupplierList = selectedRow.Cells["SupplierName"].Value != null ? selectedRow.Cells["SupplierName"].Value.ToString() : null;
                    UnitCostList = Business.Facades.SupplierProductRef.GetAllSupplierUnitCostByProductId(fProductId);
                    fQuantity = selectedRow.Cells["Quantity"].Value != null ? selectedRow.Cells["Quantity"].Value.ToString() : null;
                    fUOM = selectedRow.Cells["UOM"].Value != null ? selectedRow.Cells["UOM"].Value.ToString() : null;

                    var lastPriceModel = Business.Facades.PriceHistory.GetLastPrice(fProductId);
                    if (lastPriceModel != null)
                    {
                        var price = Business.Facades.Prices.GetByPriceId(lastPriceModel.PriceId);
                        PriceUpdate = string.Format("{0} @{1}", lastPriceModel.CreationDate, price.RetailPrice);
                    }
                    else
                    {
                        PriceUpdate = "";
                    }
                }
            }
            else if(e.ColumnIndex == 17)

            {
                var selectedRow = this.dgvInventories.Rows[e.RowIndex];

                fInventoryId = selectedRow.Cells["InventoryId"].Value.ToString();
                fProductId = (int)selectedRow.Cells["ProductId"].Value;
                fPriceId = (int)selectedRow.Cells["PriceId"].Value;
                fCategoryId = selectedRow.Cells["CategoryId"].Value != null ? (int)selectedRow.Cells["CategoryId"].Value : 0;
                fBarcode = selectedRow.Cells["Barcode"].Value.ToString();
                fDescription = selectedRow.Cells["Description"].Value.ToString();
                fFullDescription = selectedRow.Cells["FullDescription"].Value != null ? selectedRow.Cells["FullDescription"].Value.ToString() : null;
                fRetailPrice = selectedRow.Cells["RetailPrice"].Value != null ? selectedRow.Cells["RetailPrice"].Value.ToString() : null;
                fWholesalePrice = selectedRow.Cells["WholesalePrice"].Value != null ? selectedRow.Cells["WholesalePrice"].Value.ToString() : null;
                fMinInv = selectedRow.Cells["MinInventory"].Value != null ? selectedRow.Cells["MinInventory"].Value.ToString() : null;
                fMaxInv = selectedRow.Cells["MaxInventory"].Value != null ? selectedRow.Cells["MaxInventory"].Value.ToString() : null;
                fCriticalInv = selectedRow.Cells["CriticalInventory"].Value != null ? selectedRow.Cells["CriticalInventory"].Value.ToString() : null;
                fSupplierList = selectedRow.Cells["SupplierName"].Value != null ? selectedRow.Cells["SupplierName"].Value.ToString() : null;
                UnitCostList = Business.Facades.SupplierProductRef.GetAllSupplierUnitCostByProductId(fProductId);
                fQuantity = selectedRow.Cells["Quantity"].Value != null ? selectedRow.Cells["Quantity"].Value.ToString() : null;
                fUOM = selectedRow.Cells["UOM"].Value != null ? selectedRow.Cells["UOM"].Value.ToString() : null;

                var lastPriceModel = Business.Facades.PriceHistory.GetLastPrice(fProductId);
                if (lastPriceModel != null)
                {
                    var price = Business.Facades.Prices.GetByPriceId(lastPriceModel.PriceId);
                    PriceUpdate = string.Format("{0} @{1}", lastPriceModel.CreationDate, price.RetailPrice);
                }
                else
                {
                    PriceUpdate = "";
                }
                if (!string.IsNullOrEmpty(fInventoryId) && (fProductId > 0) && (fPriceId > 0))
                {
                    if (Helpers.MessageBoxHelper.ShowYesNoDialog("Are you sure you want to delete the inventory?", "Confirmation"))
                    {
                        bool success = Business.Facades.Inventories.DeleteInventory(Convert.ToInt32(fInventoryId));
                        if (success)
                        {
                            LoadInventories();
                            LoadCategories();
                            ClearFields();
                            Helpers.MessageBoxHelper.ShowInformationDialog("Inventory has been successfully deleted.", "Success");
                            btnAddInventory.Enabled = true;
                        }
                        else
                        {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Error deleting inventory. Please contact your administrator.");
                        }
                    }
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Please select the inventory to delete.");
                }

            }
        }

        private void dgvInventories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            btnAddInventory.Visible = false;
            btnUpdateInventory.Visible = false;

            if (e.ColumnIndex == 16)
            {
                pnlAEcontainer.Visible = true;
                btnUpdateInventory.Visible = true;
                if (e.RowIndex >= 0)
                {

                    var selectedRow = this.dgvInventories.Rows[e.RowIndex];

                    fInventoryId = selectedRow.Cells["InventoryId"].Value.ToString();
                    fProductId = (int)selectedRow.Cells["ProductId"].Value;
                    fPriceId = (int)selectedRow.Cells["PriceId"].Value;
                    fCategoryId = selectedRow.Cells["CategoryId"].Value != null ? (int)selectedRow.Cells["CategoryId"].Value : 0;
                    fBarcode = selectedRow.Cells["Barcode"].Value.ToString();
                    fDescription = selectedRow.Cells["Description"].Value.ToString();
                    fFullDescription = selectedRow.Cells["FullDescription"].Value != null ? selectedRow.Cells["FullDescription"].Value.ToString() : null;
                    fRetailPrice = selectedRow.Cells["RetailPrice"].Value != null ? selectedRow.Cells["RetailPrice"].Value.ToString() : null;
                    fWholesalePrice = selectedRow.Cells["WholesalePrice"].Value != null ? selectedRow.Cells["WholesalePrice"].Value.ToString() : null;
                    fMinInv = selectedRow.Cells["MinInventory"].Value != null ? selectedRow.Cells["MinInventory"].Value.ToString() : null;
                    fMaxInv = selectedRow.Cells["MaxInventory"].Value != null ? selectedRow.Cells["MaxInventory"].Value.ToString() : null;
                    fCriticalInv = selectedRow.Cells["CriticalInventory"].Value != null ? selectedRow.Cells["CriticalInventory"].Value.ToString() : null;
                    fSupplierList = selectedRow.Cells["SupplierName"].Value != null ? selectedRow.Cells["SupplierName"].Value.ToString() : null;
                    UnitCostList = Business.Facades.SupplierProductRef.GetAllSupplierUnitCostByProductId(fProductId);
                    fQuantity = selectedRow.Cells["Quantity"].Value != null ? selectedRow.Cells["Quantity"].Value.ToString() : null;
                    fUOM = selectedRow.Cells["UOM"].Value != null ? selectedRow.Cells["UOM"].Value.ToString() : null;

                    var lastPriceModel = Business.Facades.PriceHistory.GetLastPrice(fProductId);
                    if (lastPriceModel != null)
                    {
                        var price = Business.Facades.Prices.GetByPriceId(lastPriceModel.PriceId);
                        PriceUpdate = string.Format("{0} @{1}", lastPriceModel.CreationDate, price.RetailPrice);
                    }
                    else
                    {
                        PriceUpdate = "";
                    }
                }
            }
            
        }
        

        private void Search() {
            Helpers.DataGridViewHelper.ClearDatagrid(dgvInventories);
            if (!string.IsNullOrEmpty(fSearchText))
            {
                SearchInventories();
            }
            else
            {
                LoadInventories();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            Search();
        }
        #endregion

        #region KeyTrapping
        private void txtUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }

        private void txtRetailPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }

        private void txtWholesalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }
        private void txtMinInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }

        private void txtMaxInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }

        private void txtCriticalInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHypen(sender, e);
        }
        #endregion

        private void btnSelectSupplier_Click(object sender, EventArgs e)
        {
           //if (!string.IsNullOrEmpty(fInventoryId))
            //{
                var supplierCount = Business.Facades.Supplier.GetAll();
                if (supplierCount != null)
                {
                    frmSupplierXRefPopUp frmXref = new frmSupplierXRefPopUp();
                    frmXref.ProductId = fProductId;
                    frmXref.Text = string.Format("Supplier: {0}", fDescription);

                    frmXref.ShowDialog();
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("There's no supplier on the list");
                }
            //}
            //else
            //{
                //Helpers.MessageBoxHelper.ShowErrorDialog("Please select inventory first");
            //}
            
        }

        #region Paging methods
        private void ChangeDgvPage(bool isNext = true)
        {
            if (isSearching)
            {
                if (isNext)
                {
                    currentPage++;
                    SearchInventories();
                }
                else
                {
                    currentPage--;
                    SearchInventories();
                }

            }
            else
            {
                if (isNext)
                {
                    currentPage++;
                    LoadInventories();
                }
                else
                {
                    currentPage--;
                    LoadInventories();
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            
            var prePage = currentPage - 1;
            if (prePage-- > 0) {
                
                ChangeDgvPage(false);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < maxPage) {
                ChangeDgvPage(true);
            }
        }
        private void moveToPage(int pageNumber) {
            currentPage = pageNumber;
            if (isSearching)
            {
                SearchInventories();
            }
            else
            {
                LoadInventories();
            }
        }

        private void tbCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHandler(sender, e);
        }

        private void tbCurrentPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int inputPage;
                    inputPage = Convert.ToInt32(tbCurrentPage.Text);
                    if (inputPage > 0)
                    {
                        moveToPage(inputPage);
                    }
                    else {
                        Helpers.MessageBoxHelper.ShowErrorDialog("Please enter valid page number");
                    }
                }
                catch {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Please enter valid page number");
                }

                
            }
        }

        #endregion
        private DateTime SetDefaultDateValue() {
            return DateTime.Now.Date.AddDays(1); //got error on this code when clicking datagrid view for edit
        }

        private void DtpExpDate_ValueChanged(object sender, EventArgs e)
        {
            //dtpExpDate.MinDate = DateTime.Now.Date.AddDays(1);
        }

        private void btnExpList_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fInventoryId)) {

                if (!string.IsNullOrEmpty(fQuantity))
                {
                    using (frmExpirationList ExpList = new frmExpirationList(fProductId, Convert.ToDouble(fQuantity)))
                    {
                        ExpList.ShowDialog();
                    }
                }
                else{
                    Helpers.MessageBoxHelper.ShowErrorDialog("Please enter product quantity first!");
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please select inventory first!");
            }
        }

        private void FrmInventories_Resize(object sender, EventArgs e)
        {
            pnlInventory.Left = (this.Width - pnlInventory.Width) / 2;
            //pnlAEcontainer.Left = (this.Width - pnlAEcontainer.Width) / 2;
        }

        private void ToggleBottomMenu(bool toggle) {
            btnAddnewitem.Visible = toggle;
            tblPnlPaging.Visible = toggle;

        }

        private void BtnAddnewitem_Click(object sender, EventArgs e)
        {
            pnlAEcontainer.Visible = !pnlAEcontainer.Visible;
            ClearFields();
            btnUpdateInventory.SendToBack();
            btnAddInventory.Visible = true;
            ToggleBottomMenu(false);
        }

      

        private void BtnInventorycancel_Click(object sender, EventArgs e)
        {
            pnlAEcontainer.Visible = !pnlAEcontainer.Visible;
            ToggleBottomMenu(true);
        }

        private void TxtDescription_Leave(object sender, EventArgs e)
        {
            var isValid = Helpers.TextboxHelper.ValidateTextBox(txtDescription, errorProvider);
        }

        private void TxtFullDescription_Leave(object sender, EventArgs e)
        {
            var isValid = Helpers.TextboxHelper.ValidateTextBox(txtFullDescription, errorProvider);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
