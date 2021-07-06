using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.Helpers
{
    public class ImportExport
    {
        private static ISheet ReadData(string fullpath, int sheetpage) {

            ISheet sheet = null;
            using (FileStream fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
            {
                IWorkbook wb = null;
                if (fullpath.IndexOf(".xlsx") > 0)
                {
                    wb = new XSSFWorkbook(fs);
                }
                else if (fullpath.IndexOf(".xls") > 0)
                {
                    wb = new HSSFWorkbook(fs);
                }

                sheet = wb.GetSheetAt(sheetpage);
            }
            return sheet;
        }

        private static string GetCellData(ICell cell) {
            string val = null;
            if (cell.CellType == CellType.String)
            {
                val = cell.StringCellValue;
            }
            else if (cell.CellType == CellType.Numeric) {
                val = cell.NumericCellValue.ToString();
            }
            return val;
        }

        private static string nullableImport(IRow row,int index) {
            if (row.GetCell(index) != null) {
                return row.GetCell(index).ToString();
            }
            return null;
        }
        private static bool checkCategory(string categoryName, out int? CategId) {
            CategId = null;
            var category = Business.Facades.Categories.GetByCategoryName(categoryName);
            try
            {
                if (category == null)
                {
                    var categoryModel = new Business.Models.Categories()
                    {
                        Name = categoryName
                    };
                    var insert = Business.Facades.Categories.AddCategory(categoryModel);
                    if (insert)
                    {
                        CategId = Business.Facades.Categories.GetAll().OrderByDescending(o => o.CategoryId).FirstOrDefault().CategoryId;
                        return true;
                    }
                    return false;
                }
                else
                {
                    CategId = category.CategoryId;
                    return true;
                }
                
            }
            catch
            {

                return false;
            }
        }
        private static bool checkSupplier(string supplierName, out int? SuppplierId)
        {
            SuppplierId = null;
            var supplier = Business.Facades.Supplier.GetByName(supplierName);
            try
            {
                if (supplier == null)
                {
                    var supplierModel = new Business.Models.Supplier()
                    {
                        SupplierName = supplierName
                    };
                    var insert = Business.Facades.Supplier.AddSupplier(supplierModel);
                    if (insert)
                    {
                        SuppplierId = Business.Facades.Supplier.GetAll().OrderByDescending(o => o.SupplierId).FirstOrDefault().SupplierId;
                        return true;
                    }
                    return false;
                }
                else
                {
                    SuppplierId = supplier.SupplierId;
                    return true;
                }
            }
            catch
            {

                return false;
            }
        }
        #region Inside Helper Methods
        private static bool AddingInventory(string barcode, IRow row, out string errorMsg, int? categoryId = null)
        {
            errorMsg = null;
            var inventory = new Business.Models.Inventories();
            inventory.Product = new Business.Models.Products();
            inventory.Product.Price = new Business.Models.Prices();
            inventory.Product.Category = new Business.Models.Categories();

            inventory.Product.Barcode = barcode;
            inventory.Product.Description = GetCellData(row.GetCell(1));
            inventory.Product.FullDescription = GetCellData(row.GetCell(2));
            //UNITCOST AND SUPPLIER TEMP
            inventory.Product.Price.RetailPrice = !string.IsNullOrEmpty(nullableImport(row, 4)) ? Convert.ToDouble(GetCellData(row.GetCell(4))) : (double?)null;
            inventory.Product.Price.WholesalePrice = !string.IsNullOrEmpty(nullableImport(row, 5)) ? Convert.ToDouble(GetCellData(row.GetCell(5))) : (double?)null;
            inventory.Product.CategoryId = categoryId != null ? categoryId : null;
            inventory.MinimumInventory = !string.IsNullOrEmpty(nullableImport(row, 8)) ? Convert.ToInt32(GetCellData(row.GetCell(8))) : (int?)null;
            inventory.MaximumInventory = !string.IsNullOrEmpty(nullableImport(row, 9)) ? Convert.ToInt32(GetCellData(row.GetCell(9))) : (int?)null;
            inventory.CriticalInventory = !string.IsNullOrEmpty(nullableImport(row, 10)) ? Convert.ToInt32(GetCellData(row.GetCell(10))) : (int?)null;
            inventory.Quantity = !string.IsNullOrEmpty(nullableImport(row, 11)) ? Convert.ToInt32(GetCellData(row.GetCell(11))) : (int?)null;

            inventory.Product.CreationDate = DateTime.Now;
            inventory.CreationDate = DateTime.Now;
            inventory.Product.Price.CreationDate = DateTime.Now;

            var inventoryInsert = Business.Facades.Inventories.AddInventory(inventory);
            if (!inventoryInsert)
            {
                errorMsg = string.Format("Error in adding new product: {0}. Please enter valid inputs, barcode should be less than or equal to 13 characters.", barcode);
                return false;
            }
            return true;
        }
        private static bool AddingXRef(string barcode,string supplierName,IRow row,int supplierId,int productId, out string errorMsg,bool isUpdate = false, double? newCost = null) {
            errorMsg = null;
            var supplierXproductNew = new Business.Models.SupplierProductRef();
            supplierXproductNew.UnitCost = !isUpdate ? (!string.IsNullOrEmpty(nullableImport(row, 3)) ? Convert.ToDouble(GetCellData(row.GetCell(3))) : (double?)null) : newCost;
            supplierXproductNew.SupplierId = supplierId;
            supplierXproductNew.ProductId = productId;
            supplierXproductNew.CreationDate = DateTime.Now;

            if (!isUpdate)
            {
                var insert = Business.Facades.SupplierProductRef.AddXref(supplierXproductNew);
                if (!insert)
                {
                    errorMsg = string.Format("Error in adding new productXRef on productBarcode: {0} with supplierName: {1}", barcode, supplierName);
                    return false;
                }
            }
            else {
                var update = Business.Facades.SupplierProductRef.UpdateXref(supplierXproductNew);
                if (!update)
                {
                    errorMsg = string.Format("Error in updating productXRef on productBarcode: {0} with supplierName: {1}", barcode, supplierName);
                    return false;
                }
            }
            return true;
        }

        private static bool completeInputsWithNoProduct(string barcode,IRow row,int supplierId,int categoryId, out string errorMsg) {
            //This entry means that there's Category, Supplier But No Product Record
            errorMsg = null;
            var inventoryInsert = AddingInventory(barcode, row, out errorMsg, categoryId); ;
            if (inventoryInsert)
            {
                var supplier = Business.Facades.Supplier.GetById(supplierId);
                var productId = Business.Facades.Inventories.GetAll().OrderByDescending(o => o.InventoryId).FirstOrDefault().Product.ProductId;
                AddingXRef(barcode, supplier.SupplierName, row, supplierId, productId, out errorMsg);
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool completeInputsWithProduct(string barcode,IRow row,int supplierId,string supplier,int categoriyId,out string errorMsg) {
            //This entry means that there's Category, Supplier WITH Product Record But have a change of different Unit Cost
            var product = Business.Facades.Products.GetByProductBarcodeProductOnly(barcode);
            errorMsg = null;
            //check if there's previous data for supplierxref
            var supplierXproduct = Business.Facades.SupplierProductRef.CheckIfExisting(supplier, product.ProductId);
            if (supplierXproduct == null)
            {
                var insert = AddingXRef(barcode, supplier, row, supplierId, product.ProductId, out errorMsg);
                if (!insert)
                { 
                    return false;
                }
            }
            else
            {
                //If there's previous/existing supplier,product data, or supplierxref update to the recent data base on import;
                var oldData = Business.Facades.SupplierProductRef.GetBySupplierAndProductId(Convert.ToInt32(supplierId), product.ProductId);
                var newCOST = !string.IsNullOrEmpty(nullableImport(row, 3)) ? Convert.ToDouble(GetCellData(row.GetCell(3))) : (double?)null;
                if (oldData.UnitCost != newCOST)
                {
                    var update = AddingXRef(barcode, supplier, row, supplierId, product.ProductId, out errorMsg, true, newCOST);
                    if (!update)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private static bool rowChecker(IRow row) {
            var barcode = row.GetCell(0) != null ? row.GetCell(0).ToString() : null;
            var Description = row.GetCell(1) != null ? row.GetCell(1).ToString() : null;
            var FullDescription = row.GetCell(2) != null ? row.GetCell(2).ToString() : null;
            if (string.IsNullOrEmpty(barcode) || string.IsNullOrWhiteSpace(barcode) || string.IsNullOrEmpty(Description) || string.IsNullOrWhiteSpace(Description) || string.IsNullOrEmpty(FullDescription) || string.IsNullOrWhiteSpace(FullDescription)) {
                return false;
            }
            return true;
        }

        private static bool updateCategoryIfChanged(int? newCategoryId,int productId,out string errorMsg) {
            errorMsg = null;
            var productModel= Business.Facades.Products.GetByProductId(productId);
            var currentCategoryId = productModel.CategoryId;
            if (newCategoryId != currentCategoryId) {
                var update = Business.Facades.Products.UpdateProductCategory(productId, newCategoryId);
                if (!update) {
                    errorMsg = string.Format("Error in updating new category on product barcode: {0}", productModel.Barcode);
                    return false;
                }
            }
            return true;
        }

        private static void updateLoadingScreen(HelperForms.LoadingScreen LoadingScreen,int rowCount,int index) {
            //Loading Screen Updates
            int totalVal = rowCount;
            int currentVal = index;
            if (totalVal != currentVal)
            {
                double divideRoundUp = Convert.ToDouble(currentVal) / Convert.ToDouble(totalVal);
                int valueInPercent = Convert.ToInt32(divideRoundUp * 100);
                string stat = string.Format("{0}/{1} Completed", currentVal, totalVal);
                LoadingScreen.updateValues(valueInPercent, stat);
            }
            else
            {
                LoadingScreen.Close();
            }
        }
        #endregion
        public static List<string> ReadDataInventory(string fullpath, out bool isSuccess,out string statusMsg) {
            int index = 0; //Used for debugging
            try
            {   //attributes: [Barcode] [Desc] [Full Desc]
                //Inventory should always be at sheet 0

                //"BARCODE","SHORT DESC","FULL DESC","COST", "RETAIL", "WHOLESALE","SUPPLIER","CATEGORY","MINIMUM","MAXIMUM","REORDER LEVEL","Quantity"

                var errorList = new  List<string>();
                isSuccess = false;
                statusMsg = "Success";
                ISheet sheet_val = ReadData(fullpath, 0);
                if (sheet_val != null) {
                    int rowCount = sheet_val.LastRowNum;
                    //Show loading Screen
                    var LoadingScreen = new HelperForms.LoadingScreen();
                    LoadingScreen.Show();

                    for (int s = 1; s <= rowCount; s++)
                    {
                        index = s; //Used for debugging

                        IRow row = sheet_val.GetRow(s); // get whole row on current sheet 
                        if (row != null && row.Cells.Count >= 3 && rowChecker(row))
                        {
                            var barcode = GetCellData(row.GetCell(0));
                            if (!string.IsNullOrEmpty(barcode) && !string.IsNullOrWhiteSpace(barcode))// check if barcode cell is not empty
                            {  //CHECK CATEGORY IF EXISTING
                                int? categoryId;
                                var category = row.GetCell(7) != null ? GetCellData(row.GetCell(7)) : null;
                                if (!string.IsNullOrEmpty(category) && !string.IsNullOrWhiteSpace(category) && checkCategory(category, out categoryId))
                                {   //Category Input is not null and Either New category created or old category Id is retrieved
                                    if (categoryId != null)
                                    {
                                        //CHECK FOR SUPPLIER
                                        var supplier = row.GetCell(6) != null ? GetCellData(row.GetCell(6)) : null;
                                        int? supplierId;
                                        if (!string.IsNullOrEmpty(supplier) && !string.IsNullOrWhiteSpace(supplier) && checkSupplier(supplier, out supplierId))
                                        {   //Supplier Input is not null and old Supplier Id is retrieved
                                            if (supplierId != null)
                                            {
                                                //CHECK FOR PRODUCT
                                                var ixBarcodeExist = Business.Facades.Products.isBarcodeExist(barcode);
                                                if (!ixBarcodeExist)
                                                {
                                                    string msg;
                                                    if (!completeInputsWithNoProduct(barcode, row, Convert.ToInt32(supplierId), Convert.ToInt32(categoryId), out msg))
                                                    {
                                                        errorList.Add(msg);
                                                    }
                                                }
                                                else
                                                {
                                                    string msg;
                                                    if (!completeInputsWithProduct(barcode, row, Convert.ToInt32(supplierId), supplier, Convert.ToInt32(categoryId), out msg))
                                                    {
                                                        errorList.Add(msg);
                                                    }

                                                    //Update category if it has been changed
                                                    var product = Business.Facades.Products.GetByProductBarcode(barcode);
                                                    if (!updateCategoryIfChanged(Convert.ToInt32(categoryId), product.ProductId, out msg))
                                                    {
                                                        errorList.Add(msg);
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {   //There's no supplier input but have category
                                            var isBarcodeExist = Business.Facades.Products.isBarcodeExist(barcode);
                                            if (!isBarcodeExist)
                                            {   //This entry means that there's a category with no Supplier input and new inventory data input
                                                string msg;
                                                if (!AddingInventory(barcode, row, out msg, Convert.ToInt32(categoryId)))
                                                {
                                                    errorList.Add(msg);
                                                }
                                            }
                                            else
                                            {
                                                string msg;
                                                //Update category if it has been changed
                                                var product = Business.Facades.Products.GetByProductBarcode(barcode);
                                                if (!updateCategoryIfChanged(Convert.ToInt32(categoryId), product.ProductId, out msg))
                                                {
                                                    errorList.Add(msg);
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {// NULL CATEGORY
                                    var supplier = row.GetCell(6) != null ? GetCellData(row.GetCell(6)) : null;
                                    int? supplierId;
                                    if (!string.IsNullOrWhiteSpace(supplier) && !string.IsNullOrEmpty(supplier) && checkSupplier(supplier, out supplierId))//Means there's Supplier Input
                                    {
                                        if (supplierId != null) //There's supplier but no category
                                        {//CHECK FOR PRODUCT
                                            var isBarcodeExist = Business.Facades.Products.isBarcodeExist(barcode);
                                            if (!isBarcodeExist)
                                            {   //New product added
                                                string msg = null;
                                                var inventoryInsert = AddingInventory(barcode, row, out msg, null);
                                                if (inventoryInsert)
                                                {
                                                    int productId = Business.Facades.Inventories.GetAll().OrderByDescending(o => o.InventoryId).FirstOrDefault().Product.ProductId;
                                                    if (!AddingXRef(barcode, supplier, row, Convert.ToInt32(supplierId), productId, out msg))
                                                    {
                                                        errorList.Add(msg);//add error to list
                                                    }
                                                }
                                                else
                                                {
                                                    errorList.Add(msg);//add error to list
                                                }
                                            }
                                            else
                                            {   //There's existing product
                                                var product = Business.Facades.Products.GetByProductBarcodeProductOnly(barcode);
                                                //check if there's previous data for supplierxref
                                                var supplierXproduct = Business.Facades.SupplierProductRef.CheckIfExisting(supplier, product.ProductId);
                                                if (supplierXproduct == null)
                                                {
                                                    string msg;
                                                    var insert = AddingXRef(barcode, supplier, row, Convert.ToInt32(supplierId), product.ProductId, out msg);
                                                    if (!insert)
                                                    {
                                                        errorList.Add(msg);//add error to list
                                                    }
                                                }
                                                else
                                                {
                                                    //If there's previous/existing supplier,product data, or supplierxref update to the recent data base on import;
                                                    var oldData = Business.Facades.SupplierProductRef.GetBySupplierAndProductId(Convert.ToInt32(supplierId), product.ProductId);
                                                    var newCOST = !string.IsNullOrEmpty(nullableImport(row, 3)) ? Convert.ToDouble(GetCellData(row.GetCell(3))) : (double?)null;
                                                    if (oldData.UnitCost != newCOST)
                                                    {
                                                        string msg;
                                                        var update = AddingXRef(barcode, supplier, row, Convert.ToInt32(supplierId), product.ProductId, out msg, true, newCOST);
                                                        if (!update)
                                                        {
                                                            errorList.Add(msg);//add error to list
                                                        }
                                                    }
                                                }
                                            }

                                        }

                                    }
                                    else
                                    {// NO SUPPLIER AND CATEGORY
                                        var isBarcodeExist = Business.Facades.Products.isBarcodeExist(barcode);
                                        string msg;
                                        if (!isBarcodeExist)
                                        {
                                            if (!AddingInventory(barcode, row, out msg))
                                            {
                                                errorList.Add(msg);
                                            }
                                        }
                                        else
                                        {
                                            //Update category if it has been changed
                                            var product = Business.Facades.Products.GetByProductBarcode(barcode);
                                            if (!updateCategoryIfChanged(null, product.ProductId, out msg))
                                            {
                                                errorList.Add(msg);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                string msg = string.Format("Barcode is missing on row number: {0}", s);
                                errorList.Add(msg);
                            }
                        }

                        //Loading Screen Updates
                        updateLoadingScreen(LoadingScreen, rowCount, s);
                    }
                }
                if (!errorList.Any()) {
                    isSuccess = true;
                }
                return errorList;
            }
            catch (Exception e) {
                int tryInt = index;
                statusMsg = e.Message;
                isSuccess = false;
                return null;
            }
        }

        public static List<Business.Models.Categories> ReadDataCategory(string fullpath)
        {
            try
            { 
                var categoryList = new List<Business.Models.Categories>();
                ISheet sheet_val = ReadData(fullpath, 0);
                if (sheet_val != null)
                {
                    int rowCount = sheet_val.LastRowNum;

                    for (int s = 1; s <= rowCount; s++)
                    {
                        var category = new Business.Models.Categories();
                        IRow row = sheet_val.GetRow(s); // get whole row on current sheet 
                        category.Name = GetCellData(row.GetCell(0));
                        category.Description = GetCellData(row.GetCell(1));

                        category.CreationDate = DateTime.Now;

                        categoryList.Add(category);//add inventory to list
                    }
                }
                return categoryList;
            }
            catch (Exception e)
            {
                var error = e.Message;
                return null;
            }
        }
        public static List<Business.Models.Customer> ReadDataCustomer(string fullpath)
        {
            try
            {   //attributes: [CustomerName]
                //Customer should always be at sheet 0
                var customerList = new List<Business.Models.Customer>();
                ISheet sheet_val = ReadData(fullpath, 0);
                if (sheet_val != null)
                {
                    int rowCount = sheet_val.LastRowNum;

                    for (int s = 1; s <= rowCount; s++)
                    {
                        var customer = new Business.Models.Customer();
                        IRow row = sheet_val.GetRow(s); // get whole row on current sheet 
                        customer.CustomerName = GetCellData(row.GetCell(0));
                        customer.Address = GetCellData(row.GetCell(1));
                        customer.Contact = GetCellData(row.GetCell(2));

                        customer.CreationDate = DateTime.Now;

                        customerList.Add(customer);//add inventory to list
                    }
                }
                return customerList;
            }
            catch (Exception e)
            {
                var error = e.Message;
                return null;
            }
        }
        public static List<Business.Models.Supplier> ReadDataSupplier(string fullpath)
        {
            try
            {   //attributes: [CustomerName] [Desc] [Full Desc]
                //Customer should always be at sheet 0
                var supplierList = new List<Business.Models.Supplier>();
                ISheet sheet_val = ReadData(fullpath, 0);
                if (sheet_val != null)
                {
                    int rowCount = sheet_val.LastRowNum;

                    for (int s = 1; s <= rowCount; s++)
                    {
                        var customer = new Business.Models.Supplier();
                        IRow row = sheet_val.GetRow(s); // get whole row on current sheet 
                        customer.SupplierName = GetCellData(row.GetCell(0));
                        customer.Address = GetCellData(row.GetCell(1));
                        customer.Contact = GetCellData(row.GetCell(2));

                        customer.CreationDate = DateTime.Now;

                        supplierList.Add(customer);//add inventory to list
                    }
                }
                return supplierList;
            }
            catch (Exception e)
            {
                var error = e.Message;
                return null;
            }
        }
        private static void nullableCellDouble(IRow row, int index, double? data)
        {
            if (data != null)
                row.CreateCell(index).SetCellValue((double)data);
        }

        public static bool ExportInventory(string fullpath)
        {
            var _i = 0;
            try
            {
                IWorkbook workbook = new XSSFWorkbook();

                ISheet invsheet = workbook.CreateSheet("Inventory");
                
                IRow header = invsheet.CreateRow(0);

                List<string> headerTitle = new List<string>() { "BARCODE", "SHORT DESCRIPTION", "FULL ITEM DESCRIPTION","COST", "RETAIL", "WHOLESALE","SUPPLIER","CATEGORY","MINIMUM","MAXIMUM","REORDER LEVEL","Quantity"};
               

                //create header
                for (int i = 0; i < headerTitle.Count(); i++)
                {
                    header.CreateCell(i).SetCellValue(headerTitle[i]);
                }

                //create the body to export
                DataFormatter formatter = new DataFormatter();
                var datas = Business.Facades.Inventories.GetAll();

                int prodCounter = 1;
                int rowCounter = 1;
                int totalData = datas.Count();

                //Show loading Screen
                var LoadingScreen = new HelperForms.LoadingScreen();
                LoadingScreen.Show();

                foreach (var product in datas)
                {
                    // Create row
                    IRow row = invsheet.CreateRow(rowCounter);
                    var suppliers = Business.Facades.SupplierProductRef.GetAllSupplierByProductId(datas[prodCounter - 1].ProductId);
                    
                    if (suppliers.Count >= 1)
                    {
                        for (int x = 0; x < suppliers.Count(); x++)
                        {
                            if (x > 0)
                            {
                                rowCounter++;
                                totalData++;
                                row = invsheet.CreateRow(rowCounter);
                            }
                            row.CreateCell(0).SetCellValue(datas[prodCounter - 1].Product.Barcode);
                            row.CreateCell(1).SetCellValue(datas[prodCounter - 1].Product.Description);
                            row.CreateCell(2).SetCellValue(datas[prodCounter - 1].Product.FullDescription);
                            nullableCellDouble(row, 3, suppliers[x].UnitCost); // for COST
                            nullableCellDouble(row, 4, datas[prodCounter - 1].Product.Price.RetailPrice);
                            nullableCellDouble(row, 5, datas[prodCounter - 1].Product.Price.WholesalePrice);
                            row.CreateCell(6).SetCellValue(suppliers[x].Supplier.SupplierName);//for supplier
                            if (datas[prodCounter - 1].Product.CategoryId != null)
                            {
                                row.CreateCell(7).SetCellValue(datas[prodCounter - 1].Product.Category.Name);
                            }
                            nullableCellDouble(row, 8, datas[prodCounter - 1].MinimumInventory);
                            nullableCellDouble(row, 9, datas[prodCounter - 1].MaximumInventory);
                            nullableCellDouble(row, 10, datas[prodCounter - 1].CriticalInventory);
                            nullableCellDouble(row, 11, datas[prodCounter - 1].Quantity);
                        }

                        prodCounter++;
                        rowCounter++;
                    }
                    else {

                        row.CreateCell(0).SetCellValue(datas[prodCounter - 1].Product.Barcode);
                        row.CreateCell(1).SetCellValue(datas[prodCounter - 1].Product.Description);
                        row.CreateCell(2).SetCellValue(datas[prodCounter - 1].Product.FullDescription);
                        nullableCellDouble(row, 4, datas[prodCounter - 1].Product.Price.RetailPrice);
                        nullableCellDouble(row, 5, datas[prodCounter - 1].Product.Price.WholesalePrice);
                        if (datas[prodCounter - 1].Product.CategoryId != null)
                            {
                                row.CreateCell(7).SetCellValue(datas[prodCounter - 1].Product.Category.Name);
                            }
                        nullableCellDouble(row, 8, datas[prodCounter - 1].MinimumInventory);
                        nullableCellDouble(row, 9, datas[prodCounter - 1].MaximumInventory);
                        nullableCellDouble(row, 10, datas[prodCounter - 1].CriticalInventory);
                        nullableCellDouble(row, 11, datas[prodCounter - 1].Quantity);

                        prodCounter++;
                        rowCounter++;
                    }

                    //Loading Screen Updates
                    updateLoadingScreen(LoadingScreen, totalData, rowCounter);
                }

                AutoSizeCols(9,invsheet);
                string _fullpath = string.Format("{0}\\Inventories.xlsx", fullpath);

                using (FileStream sw = File.Create(_fullpath))
                {
                    workbook.Write(sw);
                }
                return true;
            }
            catch  (Exception msg){
                return false;
                var error = msg;
            }
        }
        public static bool ExportCategory(string fullpath)
        {
            try
            {
                IWorkbook workbook = new XSSFWorkbook();

                ISheet invsheet = workbook.CreateSheet("Category");
                IRow header = invsheet.CreateRow(0);
                List<string> headerTitle = new List<string>() { "Category Name","Description" };

                //create header
                for (int i = 0; i < headerTitle.Count(); i++)
                {
                    header.CreateCell(i).SetCellValue(headerTitle[i]);
                }

                //Show loading Screen
                var LoadingScreen = new HelperForms.LoadingScreen();
                LoadingScreen.Show();

                //create the body to export
                var datas = Business.Facades.Categories.GetAll();
                for (int d = 1; d <= datas.Count(); d++)
                { //create row
                    IRow row = invsheet.CreateRow(d);

                    row.CreateCell(0).SetCellValue(datas[d - 1].Name);
                    row.CreateCell(1).SetCellValue(datas[d - 1].Description);

                    //Loading Screen Updates
                    updateLoadingScreen(LoadingScreen, datas.Count, d);
                }
                AutoSizeCols(1, invsheet);
                string _fullpath = string.Format("{0}\\Categories.xlsx", fullpath);

                using (FileStream sw = File.Create(_fullpath))
                {
                    workbook.Write(sw);
                }
                return true;
            }
            catch {
                return false;
            }
        }
        private static void AutoSizeCols(int colNums,ISheet sheet) {
            for (int i = 0; i <= colNums; i++)
            {
                sheet.AutoSizeColumn(i);
            }
        }
        public static bool ExportCustomer(string fullpath)
        {
            try
            {
                IWorkbook workbook = new XSSFWorkbook();

                ISheet invsheet = workbook.CreateSheet("Customer");
                IRow header = invsheet.CreateRow(0);
                List<string> headerTitle = new List<string>() { "Customer Name","Address","Contact" };

                //create header
                for (int i = 0; i < headerTitle.Count(); i++)
                {
                    header.CreateCell(i).SetCellValue(headerTitle[i]);
                }

                //Show loading Screen
                var LoadingScreen = new HelperForms.LoadingScreen();
                LoadingScreen.Show();

                //create the body to export
                var datas = Business.Facades.Customer.GetAll();
                for (int d = 1; d <= datas.Count(); d++)
                { //create row
                    IRow row = invsheet.CreateRow(d);

                    row.CreateCell(0).SetCellValue(datas[d - 1].CustomerName);
                    row.CreateCell(1).SetCellValue(datas[d - 1].Address);
                    row.CreateCell(2).SetCellValue(datas[d - 1].Contact);

                    //Loading Screen Updates
                    updateLoadingScreen(LoadingScreen, datas.Count, d);
                }

                AutoSizeCols(2,invsheet);

                string _fullpath = string.Format("{0}\\Customers.xlsx", fullpath);

                using (FileStream sw = File.Create(_fullpath))
                {
                    workbook.Write(sw);
                }
                return true;
            }
            catch(Exception e)
            {
                var msg = e.Message;
                return false;
            }
        }
        public static bool ExportSupplier(string fullpath)
        {
            try
            {
                IWorkbook workbook = new XSSFWorkbook();

                ISheet invsheet = workbook.CreateSheet("Supplier");
                IRow header = invsheet.CreateRow(0);
                List<string> headerTitle = new List<string>() { "Supplier Name","Address","Contact" };

                //create header
                for (int i = 0; i < headerTitle.Count(); i++)
                {
                    header.CreateCell(i).SetCellValue(headerTitle[i]);
                }

                //Show loading Screen
                var LoadingScreen = new HelperForms.LoadingScreen();
                LoadingScreen.Show();

                //create the body to export
                var datas = Business.Facades.Supplier.GetAll();
                for (int d = 1; d <= datas.Count(); d++)
                { //create row
                    IRow row = invsheet.CreateRow(d);

                    row.CreateCell(0).SetCellValue(datas[d - 1].SupplierName);
                    row.CreateCell(1).SetCellValue(datas[d - 1].Address);
                    row.CreateCell(2).SetCellValue(datas[d - 1].Contact);

                    //Loading Screen Updates
                    updateLoadingScreen(LoadingScreen, datas.Count, d);
                }

                AutoSizeCols(2, invsheet);
                string _fullpath = string.Format("{0}\\Suppliers.xlsx", fullpath);

                using (FileStream sw = File.Create(_fullpath))
                {
                    workbook.Write(sw);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
