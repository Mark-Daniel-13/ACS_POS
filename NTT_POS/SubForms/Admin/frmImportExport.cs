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
    public partial class frmImportExport : Form
    {
        private string ImportPath
        {
            get { return tbImportPath.Text; }
            set { tbImportPath.Text = value; }
        }
        private string importFileName { get; set; }
        private string ExportPath
        {
            get { return tbExportPath.Text; }
            set { tbExportPath.Text = value; }
        }
        private int ImportTable {
            get { return cbTableImport.SelectedIndex; }
            set { cbTableImport.SelectedIndex = value; }
            //0 - Product ; 1 - Customer ; 2 -  Supplier ; 3 - Categories
        }
        private int ExportTable
        {
            get { return cbTableExport.SelectedIndex; }
            set { cbTableExport.SelectedIndex = value; }
            //0 - Product ; 1 - Customer ; 2 -  Supplier ; 3 - Categories
        }
        private List<string> ErrorImportList{ get; set; }
        public frmImportExport()
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
                
                //fonts
                grpImport.ForeColor = Business.Globals.darkLabelcolor;
                grpExport.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnBrowseImport.BackColor = Business.Globals.lightButtoncolor;
                btnImport.BackColor = Business.Globals.lightButtoncolor;
                btnBrowseExport.BackColor = Business.Globals.lightButtoncolor;
                btnExport.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                //fonts
                grpImport.ForeColor = Business.Globals.lightLabelcolor;
                grpExport.ForeColor = Business.Globals.lightLabelcolor;
                //Buttons
                btnBrowseImport.BackColor = Business.Globals.darkButtoncolor;
                btnImport.BackColor = Business.Globals.darkButtoncolor;
                btnBrowseExport.BackColor = Business.Globals.darkButtoncolor;
                btnExport.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }

        private void btnBrowseImport_Click(object sender, EventArgs e)
        {
            using (var folderPath = new OpenFileDialog()) 
            {
                //folderPath.Filter = "*.xls | *.xlsx";
                folderPath.Filter = "excel files (*.xls;*xlsx)|*.xls;*.xlsx";
                if (folderPath.ShowDialog() == DialogResult.OK) {
                    ImportPath = folderPath.FileName;
                    importFileName = folderPath.SafeFileName.Split('.')[0];
                }
            }
        }
        private bool ImportInventories(string fullpath) { //sheet 0
            try
            {
                ErrorImportList = new List<string>();
                bool isSuccess;
                string msg;
                var errorList = Helpers.ImportExport.ReadDataInventory(fullpath,out isSuccess,out msg);
                if (!isSuccess)
                {
                    if (msg != "Success")
                    {
                        Helpers.MessageBoxHelper.ShowErrorDialog(msg);
                        return false;
                    }
                    else{
                        if (errorList.Count() > 0)
                        {
                            for (var x = 0; x < errorList.Count(); x++)
                            {
                                ErrorImportList.Add(errorList[x]);
                            }
                        }
                    }
                }
                return true;
            }
            catch {
                return false;
            }
        }
        private bool CheckFileNameWithSelectedTable()
        {
            bool check = false;
            switch (ImportTable)
            {
                case 0:
                    if (importFileName == "Inventories") {
                        check= true;
                    }
                    break;
                case 1:
                    if (importFileName == "Customers") {
                        check= true;
                    }
                    break;
                case 2:
                    if (importFileName == "Suppliers") {
                        check= true;
                    }
                    break;
                case 3:
                    if (importFileName == "Categories") {
                        check= true;
                    }
                    break;
            }
            return check;
            

        }
        private bool ImportCategory(string fullpath)
        { 
            try
            {
                ErrorImportList = new List<string>();
                var category_datas = Helpers.ImportExport.ReadDataCategory(fullpath);
                int index = 0;
                category_datas.ForEach(category =>
                {
                    index++;
                    if (!string.IsNullOrEmpty(category.Name))
                    {
                        if (Business.Facades.Categories.GetByCategoryName(category.Name) == null)
                        {
                                Business.Facades.Categories.AddCategory(category);
                        }
                        else
                        {
                            ErrorImportList.Add(string.Format("Category: {0} already exist on the database", category.Name));
                        }
                    }
                    else
                    {
                        ErrorImportList.Add(string.Format("Category on index: {0} doesn't have Name.", index));
                    }

                });
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool ImportSupplier(string fullpath)
        {
            try
            {
                ErrorImportList = new List<string>();
                var supplier_datas = Helpers.ImportExport.ReadDataSupplier(fullpath);
                int index = 0;
                supplier_datas.ForEach(supplier =>
                {
                    index++;
                    if (!string.IsNullOrEmpty(supplier.SupplierName))
                    {
                        if (Business.Facades.Supplier.GetByName(supplier.SupplierName) == null)
                        {
                            Business.Facades.Supplier.AddSupplier(supplier);
                        }
                        else
                        {
                            ErrorImportList.Add(string.Format("Supplier: {0} already exist on the database.", supplier.SupplierName));
                        }
                    }
                    else
                    {
                        ErrorImportList.Add(string.Format("Supplier on index: {0} doesn't have Name.", index));
                    }

                });
                return true;
            }
            catch
            {
                return false;
            }
        }
        private bool ImportCustomer(string fullpath)
        {
            try
            {
                ErrorImportList = new List<string>();
                var customer_datas = Helpers.ImportExport.ReadDataCustomer(fullpath);
                int index = 0;
                customer_datas.ForEach(customer =>
                {
                    index++;
                    if (!string.IsNullOrEmpty(customer.CustomerName))
                    {
                        if (Business.Facades.Customer.GetByName(customer.CustomerName) == null)
                        {
                            Business.Facades.Customer.AddCustomer(customer);
                        }
                        else
                        {
                            ErrorImportList.Add(string.Format("Customer: {0} already exist on the database.", customer.CustomerName));
                        }
                    }
                    else
                    {
                        ErrorImportList.Add(string.Format("Customer on index: {0} doesn't have Name.", index));
                    }

                });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void updateLoadingParams(int totalVal, int currentVal) {
            var loadingScreen = (Helpers.HelperForms.LoadingScreen)Application.OpenForms["LoadingScreen"];
            if (totalVal != currentVal)
            {
                int valueInPercent = (currentVal / totalVal) * 100;
                loadingScreen.loadingValue = valueInPercent;
                loadingScreen.statusValue = string.Format("{0}/{1} Completed", currentVal, totalVal);
            }
            else {
                loadingScreen.Close();
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            if (ImportTable != null && !string.IsNullOrEmpty(ImportPath))
            {
                if (CheckFileNameWithSelectedTable())
                {
                    var status = false;
                    //0 - Product ; 1 - Customer ; 2 -  Supplier ; 3 - Categories
                    switch (ImportTable)
                    {
                        case 0:
                            status = ImportInventories(ImportPath);
                            break;
                        case 1:
                            status = ImportCustomer(ImportPath);
                            break;
                        case 2:
                            status = ImportSupplier(ImportPath);
                            break;
                        case 3:
                            status = ImportCategory(ImportPath);
                            break;
                    }

                    if (ErrorImportList.Count > 0)
                    {
                        tbErrors.Visible = true;
                        string errors = "";
                        ErrorImportList.ForEach(error =>
                        {
                            errors += string.Format("{0}; ", error);
                        });
                        tbErrors.Text = errors.Replace(";", ";" + System.Environment.NewLine);
                        Helpers.MessageBoxHelper.ShowErrorDialog("Data imported successfully, but some data are not imported due to invalid format.");
                    }
                    else
                    {
                        if (status)
                        {
                            Helpers.MessageBoxHelper.ShowInformationDialog("Data have been imported successfully.", "Success");
                            tbErrors.Text = "";
                            tbErrors.Visible = false;
                        }
                    }
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("The selected file is invalid or have incorrect file name.");
                }
            }
            else
            {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please check if a file or data table has selected.");
            }
        }

        private void frmImportExport_Load(object sender, EventArgs e)
        {
            this.btnBrowseImport.Height = this.tbImportPath.Size.Height;
            this.btnBrowseExport.Height = this.tbExportPath.Size.Height;
            this.tbErrors.Height = 77;
            this.tbErrors.Width = 348;
        }

        private void btnBrowseExport_Click(object sender, EventArgs e)
        {
            using (var folderPath = new FolderBrowserDialog())
            {
                if (folderPath.ShowDialog() == DialogResult.OK)
                {
                    ExportPath = folderPath.SelectedPath;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if ( ExportTable >=0 && !string.IsNullOrEmpty(ExportPath))
            {
                //0 - Product ; 1 - Customer ; 2 -  Supplier ; 3 - Categories
                bool status = true;
                switch (ExportTable)
                {
                    case 0:
                        if (Business.Facades.Inventories.GetAll() != null)
                        {
                            status = Helpers.ImportExport.ExportInventory(ExportPath);
                        }
                        else {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Inventory list is empty!");
                            status = false;
                        }
                        break;
                    case 1:
                        if (Business.Facades.Customer.GetAll() != null)
                        {
                            status = Helpers.ImportExport.ExportCustomer(ExportPath);
                        }
                        else {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Customer list is empty!");
                            status = false;
                        }
                        break;
                    case 2:
                        if (Business.Facades.Supplier.GetAll() != null)
                        {
                            status = Helpers.ImportExport.ExportSupplier(ExportPath);
                        }
                        else {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Supplier list is empty!");
                            status = false;
                        }
                        break;
                    case 3:
                        if (Business.Facades.Categories.GetAll() != null)
                        {
                            status = Helpers.ImportExport.ExportCategory(ExportPath);
                        }
                        else {
                            Helpers.MessageBoxHelper.ShowErrorDialog("Category list iss empty!");
                            status = false;
                        }
                        break;
                }

                if (status)
                {
                    Helpers.MessageBoxHelper.ShowInformationDialog("Data exported successfully.", "Success");
                }
                else
                {
                    Helpers.MessageBoxHelper.ShowErrorDialog("Data Exporting Failed. Please check contact the administrator.");
                }
            }else {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please check if there's file or data table selected");
            }
        }
    }
}
