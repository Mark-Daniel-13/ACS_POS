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
    public partial class frmSupplierXRefPopUp : Form
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
        public int ProductId
        {   get;    set;    }
        private string fSearch
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        private string fUnitCost
        {
            get { return txtUnitCost.Text; }
            set { txtUnitCost.Text = value; }
        }
        private string lbSupplierId
        {
            get { return lblSupplierIdValue.Text; }
            set { lblSupplierIdValue.Text = value; }
        }
        private string lbSupplierName
        {
            get { return lblNameValue.Text; }
            set { lblNameValue.Text = value; }
        }
        private string fSupplierName
        {
            get { return txtSupplierName.Text; }
            set { txtSupplierName.Text = value; }
        }
        private List<string> CheckedItems { get; set; }
        private List<double?> UnitCostItems { get; set; }
        private int? prevIndex { get; set; }

        #endregion
        public frmSupplierXRefPopUp()
        {
            InitializeComponent();
            CheckedItems = new List<string>();
            UnitCostItems = new List<double?>();

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
                
                //fonts
                lbSearch.ForeColor = Business.Globals.darkLabelcolor;
                grpSupplierList.ForeColor = Business.Globals.darkLabelcolor;
                groupBox1.ForeColor = Business.Globals.darkLabelcolor;
                grpProductRef.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnSearch.BackColor = Business.Globals.lightButtoncolor;
                btnAdd.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
                btnAddSupplier.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;

                //font
                lbSearch.ForeColor = Business.Globals.lightLabelcolor;
                grpSupplierList.ForeColor = Business.Globals.lightLabelcolor;
                groupBox1.ForeColor = Business.Globals.lightLabelcolor;
                grpProductRef.ForeColor = Business.Globals.lightLabelcolor;
                //Buttons
                btnSearch.BackColor = Business.Globals.darkButtoncolor;
                btnAdd.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
                btnAddSupplier.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }
        private void LoadSupplierList(bool newData = false) {
            clbSuppliers.Items.Clear();
            var supplierList = Business.Facades.Supplier.GetAll();
            
            supplierList.ForEach(supplier=>{
                var dbSupplierRef = Business.Facades.SupplierProductRef.CheckIfExisting(supplier.SupplierName, ProductId);
                if (dbSupplierRef != null || isChecked(CheckedItems, supplier.SupplierName))
                {
                    clbSuppliers.Items.Add(supplier.SupplierName, CheckState.Checked);
                    if (!newData)
                    {
                        CheckedItems.Add(supplier.SupplierName);
                        UnitCostItems.Add(dbSupplierRef.UnitCost);
                    }
                }
                else {
                    clbSuppliers.Items.Add(supplier.SupplierName, CheckState.Unchecked);
                }
            });
        }
       
        private bool isChecked(List<string> items, string checkName)
        {
            foreach (string name in items)
            {
                if (name == checkName)
                {
                    return true;
                }
            }
            return false;
        }
        private void FormClose() {
            var frmInventories = (frmInventories)Application.OpenForms["frmInventories"];

            string stringConcat = "";
            foreach (string name in CheckedItems)
            {
                stringConcat += string.Format("{0},", name);

            }
            
            //Get current selected item unitcost and save it to list
            var supplierName = clbSuppliers.SelectedItem != null ? clbSuppliers.SelectedItem.ToString() : null;
            var index = CheckedItems.IndexOf(supplierName);
            if (index != -1)
            {
                UnitCostItems[index] = string.IsNullOrEmpty(fUnitCost) ? (double?)null : Convert.ToDouble(fUnitCost);
            }

            frmInventories.fSupplierList = CheckedItems.Count>=1 ? stringConcat.Remove(stringConcat.Length - 1) : stringConcat;
            frmInventories.UnitCostList = UnitCostItems;
            this.Close();
        }

        #region Form Events
        private void fromSupplierXRefPopUp_Load(object sender, EventArgs e)
        {
            LoadSupplierList();
        }

        private void clbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prevIndex == 0  || prevIndex != clbSuppliers.SelectedIndex && clbSuppliers.SelectedItem != null)
            {

                #region Select Leave
                //check if there's unitcost value and if item is checked
                int _index = prevIndex != null ? (int)prevIndex : 0;
                if (clbSuppliers.GetItemChecked(_index) && prevIndex != null)
                {
                    var prevSupplier = clbSuppliers.Items[_index].ToString();
                    var prevUnitIndex = CheckedItems.IndexOf(prevSupplier);
                    UnitCostItems[prevUnitIndex] = string.IsNullOrEmpty(fUnitCost) ? (double?)null : Convert.ToDouble(fUnitCost);
                }
                #endregion

                #region Select Enter
                var supplierName = clbSuppliers.SelectedItem.ToString();
                var index = CheckedItems.IndexOf(supplierName);
                //get supplier Info
                var supplier = Business.Facades.Supplier.GetByName(supplierName);
                if (supplier != null)
                {
                    fUnitCost = index != -1 ? UnitCostItems[index].ToString() : null;
                    lbSupplierId = supplier.SupplierId.ToString();
                    lbSupplierName = supplier.SupplierName;
                }

                prevIndex = clbSuppliers.SelectedIndex;
                #endregion
            }
        }
        private bool CheckUnitCostValues(List<double?> unitCostList,out List<int>noValueList) {
            noValueList = new List<int>();
            for (int x = 0; x < unitCostList.Count; x++) {
                if (unitCostList[x] == null || unitCostList[x] <= 0) {
                    noValueList.Add(x);
                }
            }

            if (noValueList.Count==0) {
                return true;
            }
            else{ return false; }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<int> noValues = null;
            if (!CheckUnitCostValues(UnitCostItems, out noValues))
            {
                var noValueStrings = "";
                noValues.ForEach(item =>
                {
                    noValueStrings += CheckedItems[item] + ",";
                });

                var msg = string.Format("Please enter Unit Cost value greater than 0 for selected item: {0}", noValueStrings.Remove(noValueStrings.Length-1));
                Helpers.MessageBoxHelper.ShowErrorDialog(msg);
            }
            else
            {
                FormClose();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            prevIndex = null;
            if (!string.IsNullOrEmpty(fSearch))
            {
                var searchList = Business.Facades.Supplier.Search(fSearch);
                clbSuppliers.Items.Clear();
                if (searchList != null)
                {
                    searchList.ForEach(supplier =>
                    {
                        var itemIsCheck = isChecked(CheckedItems, supplier.SupplierName);
                        if (itemIsCheck)
                        {
                            clbSuppliers.Items.Add(supplier.SupplierName, CheckState.Checked);
                        }
                        else
                        {
                            clbSuppliers.Items.Add(supplier.SupplierName, CheckState.Unchecked);
                        }
                    });
                }
            }
            else {
                LoadSupplierList(true);
            }
        }

        private void clbSuppliers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var itemName = clbSuppliers.SelectedItem != null ? clbSuppliers.SelectedItem.ToString() : null;
            if (itemName != null)
            {
                var itemIsCheck = isChecked(CheckedItems, itemName);//used for validation to only insert to list if it's not existing yet
                if (e.NewValue.ToString() == "Checked" && !itemIsCheck)
                {
                    CheckedItems.Add(itemName);
                    var unitCost = string.IsNullOrEmpty(fUnitCost) ? (double?)null : Convert.ToDouble(fUnitCost);
                    UnitCostItems.Add(unitCost);
                    txtUnitCost.Focus();
                }
                else
                {
                    var index = CheckedItems.IndexOf(itemName);
                    UnitCostItems.RemoveAt(index);
                    CheckedItems.RemoveAt(index);
                }
            }
        }
        #endregion

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fSupplierName))
            {
                var supplierModel = new Business.Models.Supplier() {
                       SupplierName = fSupplierName,
                       CreationDate = DateTime.Now,
                };
                var instantInsert = Business.Facades.Supplier.AddSupplier(supplierModel);
                if (instantInsert)
                {
                    Helpers.MessageBoxHelper.ShowInformationDialog("Supplier has been successfully added.", "Success");
                    fSupplierName = string.Empty;
                    LoadSupplierList(true);
                }
                else {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Error on instant adding supplier, Please contact the administrator.");
                }
            }
            else {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please enter supplier name first");
            }
        }

        private void txtUnitCost_Leave(object sender, EventArgs e)
        {
            if (CheckedItems.Count > 0)
            {
                //Get current selected item unitcost and save it to list
                var supplierName = clbSuppliers.SelectedItem != null ? clbSuppliers.SelectedItem.ToString() : null;
                var index = CheckedItems.IndexOf(supplierName);
                if (index != -1)
                {
                    UnitCostItems[index] = string.IsNullOrEmpty(fUnitCost) ? (double?)null : Convert.ToDouble(fUnitCost);
                }
            }

            
        }

        private void txtUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            Helpers.TextboxHelper.NumericKeypressHandler(sender, e);
        }
    }
}
