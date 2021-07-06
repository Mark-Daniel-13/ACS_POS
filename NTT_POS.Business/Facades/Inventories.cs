using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NTT_POS.Business.Facades
{
    public class Inventories
    {
        public static Models.Inventories ToModel(Data.Inventory inventory, Models.Products product)
        {
            return new Models.Inventories()
            {
                InventoryId = inventory.InventoryId,
                ProductId = inventory.ProductId,
                Product = product,
                Quantity = inventory.Quantity,
                UOM = inventory.UOM,
                MaximumInventory=inventory.MaxInventory,
                MinimumInventory=inventory.MinInventory,
                CriticalInventory=inventory.CriticalInventory,
                CreationDate = inventory.CreationDate,
                ModificationDate = inventory.ModificationDate,
                EndDate = inventory.EndDate
            };
        }

        public static List<Models.Inventories> ToModelList(List<Data.Inventory> inventories, List<Models.Products> products)
        {
            var inventoryList = new List<Models.Inventories>();
            inventoryList = inventories.Select(inventory => new Models.Inventories()
            {
                InventoryId = inventory.InventoryId,
                ProductId = inventory.ProductId,
                Product = products.Where(p => p.ProductId == inventory.ProductId).FirstOrDefault(),
                Quantity = inventory.Quantity,
                UOM = inventory.UOM,
                MaximumInventory = inventory.MaxInventory,
                MinimumInventory = inventory.MinInventory,
                CriticalInventory = inventory.CriticalInventory,
                CreationDate = inventory.CreationDate,
                ModificationDate = inventory.ModificationDate,
                EndDate = inventory.EndDate
            }).ToList();

            return inventoryList;
        }

        public static List<Models.Inventories> ToModelList(List<Data.Inventory> inventories)
        {
            var inventoryList = new List<Models.Inventories>();
            inventoryList = inventories.Select(inventory => new Models.Inventories()
            {
                InventoryId = inventory.InventoryId,
                ProductId = inventory.ProductId,
                Quantity = inventory.Quantity,
                UOM = inventory.UOM,
                MaximumInventory = inventory.MaxInventory,
                MinimumInventory = inventory.MinInventory,
                CriticalInventory = inventory.CriticalInventory,
                CreationDate = inventory.CreationDate,
                ModificationDate = inventory.ModificationDate,
                EndDate = inventory.EndDate
            }).ToList();

            return inventoryList;
        }
        public static int GetTotalItems() {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbInventories = db.Fetch<Data.Inventory>("WHERE EndDate IS NULL ORDER BY InventoryId Desc");
                if (dbInventories == null) return 0;
                return dbInventories.Count();
            }
        }
        public static List<Models.Inventories> GetAll()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {;
                var dbInventories = db.Fetch<Data.Inventory>("WHERE EndDate IS NULL ORDER BY InventoryId Desc");
                if (dbInventories == null) return null;
                if (dbInventories.Count == 0) return null;

                var dbProducts = db.Fetch<Data.Product>("WHERE EndDate IS NULL");
                var dbCategories = db.Fetch<Data.Category>("WHERE EndDate IS NULL");
                var dbPrices = db.Fetch<Data.Price>("");

                var categories = Business.Facades.Categories.ToModelList(dbCategories);
                var prices = Business.Facades.Prices.ToModelList(dbPrices);
                var product = Business.Facades.Products.ToModelList(dbProducts, categories, prices);

                return ToModelList(dbInventories, product);
            }
        }
        public static List<Models.Inventories> GetAll(int pageSize,int pageNumber)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var offset = pageSize * (pageNumber - 1);
                var dbInventories = db.Fetch<Data.Inventory>("WHERE EndDate IS NULL ORDER BY InventoryId Desc,Quantity Asc OFFSET @0 ROWS FETCH NEXT @1 ROWS ONLY", offset, pageSize);
                if (dbInventories == null) return null;
                if (dbInventories.Count == 0) return null;

                var dbProducts = db.Fetch<Data.Product>("WHERE EndDate IS NULL");
                var dbCategories = db.Fetch<Data.Category>("WHERE EndDate IS NULL");
                var dbPrices = db.Fetch<Data.Price>("");

                var categories = Business.Facades.Categories.ToModelList(dbCategories);
                var prices = Business.Facades.Prices.ToModelList(dbPrices);
                var product = Business.Facades.Products.ToModelList(dbProducts, categories, prices);

                return ToModelList(dbInventories, product);
            }
        }
        public static bool CheckIfComplete(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbInventory = db.FirstOrDefault<Data.Inventory>("WHERE ProductId = @0 And EndDate IS NULL", productId);
                if (dbInventory == null) return false;

                var dbProduct = db.FirstOrDefault<Data.Product>("WHERE ProductId = @0", dbInventory.ProductId);
                var dbCategory = db.FirstOrDefault<Data.Category>("WHERE CategoryId = @0", dbProduct.CategoryId);
                var dbPrice = db.FirstOrDefault<Data.Price>("WHERE PriceId = @0", dbProduct.PriceId);

                var category = dbCategory == null ? null : Business.Facades.Categories.ToModel(dbCategory);
                var price = Business.Facades.Prices.ToModel(dbPrice);
                var product = Business.Facades.Products.ToModel(dbProduct, category, price);

                var inventoryVM = ToModel(dbInventory, product);

                if (inventoryVM.Quantity == null || inventoryVM.Product.Price.RetailPrice == null || inventoryVM.Product.Price.WholesalePrice == null) {
                    return false;
                }
                return true;
            }
        }

        public static Models.Inventories GetById(int inventoryId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbInventory = db.FirstOrDefault<Data.Inventory>("WHERE InventoryId = @0", inventoryId);
                if (dbInventory == null) return null;

                var dbProduct = db.FirstOrDefault<Data.Product>("WHERE ProductId = @0", dbInventory.ProductId);
                var dbCategory = db.FirstOrDefault<Data.Category>("WHERE CategoryId = @0", dbProduct.CategoryId);
                var dbPrice = db.FirstOrDefault<Data.Price>("WHERE PriceId = @0", dbProduct.PriceId);

                var category = Business.Facades.Categories.ToModel(dbCategory);
                var price = Business.Facades.Prices.ToModel(dbPrice);
                var product = Business.Facades.Products.ToModel(dbProduct, category, price);

                return ToModel(dbInventory, product);
            }
        }

        public static double? GetCurrentStocks(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbInventory = db.FirstOrDefault<Data.Inventory>("WHERE ProductId = @0 AND EndDate IS NULL", productId);
                if (dbInventory == null) return null;

                return dbInventory.Quantity;
            }
        }
        public static Models.Inventories GetByProductId(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbInventory = db.FirstOrDefault<Data.Inventory>("WHERE ProductId = @0 AND EndDate IS NULL", productId);
                if (dbInventory == null) return null;

                var dbProduct = db.FirstOrDefault<Data.Product>("WHERE ProductId = @0", dbInventory.ProductId);
                var dbCategory = dbProduct.CategoryId != null ? db.FirstOrDefault<Data.Category>("WHERE CategoryId = @0", dbProduct.CategoryId) : null;
                var dbPrice = db.FirstOrDefault<Data.Price>("WHERE PriceId = @0", dbProduct.PriceId);

                var category = dbCategory != null ? Categories.ToModel(dbCategory) : null;
                var price = Prices.ToModel(dbPrice);
                var product = Products.ToModel(dbProduct, category, price);

                return ToModel(dbInventory, product);
            }
        }
        public static int GetTotalSearchedItems(string searchString)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var sql = PetaPoco.Sql.Builder.Select("i.InventoryId, " +
                                                      "i.ProductId AS InventoryProductId, " +
                                                      "i.Quantity, " +
                                                      "i.UOM, " +
                                                      "i.MaxInventory, " +
                                                      "i.MinInventory, " +
                                                      "i.CriticalInventory, " +
                                                      "i.CreationDate AS InventoryCreationDate, " +
                                                      "i.ModificationDate AS InventoryModificationDate, " +
                                                      "i.EndDate AS InventoryEndDate, " +
                                                      "p.ProductId, " +
                                                      "p.CategoryId AS ProductCategoryId, " +
                                                      "p.PriceId AS ProductPriceId, " +
                                                      "p.FullDescription AS ProductFullDescription, " +
                                                      "p.Barcode, " +
                                                      "p.Description AS ProductDescription, " +
                                                      "p.CreationDate AS ProductCreationDate, " +
                                                      "p.ModificationDate AS ProductModificationDate, " +
                                                      "p.EndDate AS ProductEndDate, " +
                                                      "c.CategoryId, " +
                                                      "c.Name AS CategoryName, " +
                                                      "c.Description AS CategoryDescription, " +
                                                      "c.CreationDate AS CategoryCreationDate, " +
                                                      "c.ModificationDate AS CategoryModificationDate, " +
                                                      "c.EndDate AS CategoryEndDate, " +
                                                      "pr.PriceId, " +
                                                      "pr.RetailPrice, " +
                                                      "pr.WholesalePrice, " +
                                                      "pr.CreationDate AS PriceCreationDate, " +
                                                      "pr.EndDate AS PriceEndDate"
                                              )
                                              .From("Inventories i")
                                              .InnerJoin("Products p").On("i.ProductId = p.ProductId")
                                              .LeftJoin("Categories c").On("p.CategoryId = c.CategoryId")
                                              .InnerJoin("Prices pr").On("p.PriceId = pr.PriceId")
                                              .Where($"(p.Barcode LIKE '%{searchString}%' " +
                                                  $"OR p.Description LIKE '%{searchString}%' " +
                                                  $"OR p.FullDescription LIKE '%{searchString}%' " +
                                                  $"OR c.Name LIKE '%{searchString}%' " +
                                                  $"OR pr.RetailPrice LIKE '%{searchString}%') " +
                                                  "AND i.EndDate IS NULL " +
                                                  "AND p.EndDate IS NULL " +
                                                  "AND c.EndDate IS NULL " +
                                                  "AND pr.EndDate IS NULL"
                                              ).OrderBy("i.InventoryId Desc");
                var dbProducts = db.Query<Models.InventoryProductCategoryPrice>(sql);
                return dbProducts.Count();
            }
        }

        public static List<Models.InventoryProductCategoryPrice> Search(string searchString, int pageSize, int pageNumber)
        {
            var offset = pageSize * (pageNumber - 1);
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var sql = PetaPoco.Sql.Builder.Select("i.InventoryId, " +
                                                      "i.ProductId AS InventoryProductId, " +
                                                      "i.Quantity, " +
                                                      "i.UOM, " +
                                                      "i.MaxInventory, " +
                                                      "i.MinInventory, " +
                                                      "i.CriticalInventory, " +
                                                      "i.CreationDate AS InventoryCreationDate, " +
                                                      "i.ModificationDate AS InventoryModificationDate, " +
                                                      "i.EndDate AS InventoryEndDate, " +
                                                      "p.ProductId, " +
                                                      "p.CategoryId AS ProductCategoryId, " +
                                                      "p.PriceId AS ProductPriceId, " +
                                                      "p.FullDescription AS ProductFullDescription, " +
                                                      "p.Barcode, " +
                                                      "p.Description AS ProductDescription, " +

                                                      "p.CreationDate AS ProductCreationDate, " +
                                                      "p.ModificationDate AS ProductModificationDate, " +
                                                      "p.EndDate AS ProductEndDate, " +
                                                      "c.CategoryId, " +
                                                      "c.Name AS CategoryName, " +
                                                      "c.Description AS CategoryDescription, " +
                                                      "c.CreationDate AS CategoryCreationDate, " +
                                                      "c.ModificationDate AS CategoryModificationDate, " +
                                                      "c.EndDate AS CategoryEndDate, " +
                                                      "pr.PriceId, " +
                                                      "pr.RetailPrice, " +
                                                      "pr.WholesalePrice, " +
                                                      "pr.CreationDate AS PriceCreationDate, " +
                                                      "pr.EndDate AS PriceEndDate" 
                                              )
                                              .From("Inventories i")
                                              .InnerJoin("Products p").On("i.ProductId = p.ProductId")
                                              .LeftJoin("Categories c").On("p.CategoryId = c.CategoryId")
                                              .InnerJoin("Prices pr").On("p.PriceId = pr.PriceId")
                                              .Where($"(p.Barcode LIKE '%{searchString}%' " +
                                                  $"OR p.Description LIKE '%{searchString}%' " +
                                                  $"OR p.FullDescription LIKE '%{searchString}%' " +
                                                  $"OR c.Name LIKE '%{searchString}%' " +
                                                  $"OR pr.RetailPrice LIKE '%{searchString}%') " +
                                                  "AND i.EndDate IS NULL " +
                                                  "AND p.EndDate IS NULL " +
                                                  "AND pr.EndDate IS NULL"
                                              ).OrderBy($"i.InventoryId Desc,i.Quantity Asc OFFSET {offset} ROWS FETCH NEXT {pageSize} ROWS ONLY");
                var dbProducts = db.Query<Models.InventoryProductCategoryPrice>(sql);
                return dbProducts.ToList();
            }
        }

        public static List<Models.InventoryProductCategoryPrice> Search(string searchString)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var sql = PetaPoco.Sql.Builder.Select("i.InventoryId, " +
                                                      "i.ProductId AS InventoryProductId, " +
                                                      "i.Quantity, " +
                                                      "i.UOM, " +
                                                      "i.MaxInventory, " +
                                                      "i.MinInventory, " +
                                                      "i.CriticalInventory, " +
                                                      "i.CreationDate AS InventoryCreationDate, " +
                                                      "i.ModificationDate AS InventoryModificationDate, " +
                                                      "i.EndDate AS InventoryEndDate, " +
                                                      "p.ProductId, " +
                                                      "p.CategoryId AS ProductCategoryId, " +
                                                      "p.PriceId AS ProductPriceId, " +
                                                      "p.FullDescription AS ProductFullDescription, " +
                                                      "p.Barcode, " +
                                                      "p.Description AS ProductDescription, " +
                                                      "p.CreationDate AS ProductCreationDate, " +
                                                      "p.ModificationDate AS ProductModificationDate, " +
                                                      "p.EndDate AS ProductEndDate, " +
                                                      "c.CategoryId, " +
                                                      "c.Name AS CategoryName, " +
                                                      "c.Description AS CategoryDescription, " +
                                                      "c.CreationDate AS CategoryCreationDate, " +
                                                      "c.ModificationDate AS CategoryModificationDate, " +
                                                      "c.EndDate AS CategoryEndDate, " +
                                                      "pr.PriceId, " +
                                                      "pr.RetailPrice, " +
                                                      "pr.WholesalePrice, " +
                                                      "pr.CreationDate AS PriceCreationDate, " +
                                                      "pr.EndDate AS PriceEndDate"
                                              )
                                              .From("Inventories i")
                                              .InnerJoin("Products p").On("i.ProductId = p.ProductId")
                                              .LeftJoin("Categories c").On("p.CategoryId = c.CategoryId")
                                              .InnerJoin("Prices pr").On("p.PriceId = pr.PriceId")
                                              .Where($"(p.Barcode LIKE '%{searchString}%' " +
                                                  $"OR p.Description LIKE '%{searchString}%' " +
                                                  $"OR p.FullDescription LIKE '%{searchString}%' " +
                                                  $"OR c.Name LIKE '%{searchString}%' " +
                                                  $"OR pr.RetailPrice LIKE '%{searchString}%') " +
                                                  "AND i.EndDate IS NULL " +
                                                  "AND p.EndDate IS NULL " +
                                                  "AND c.EndDate IS NULL " +
                                                  "AND pr.EndDate IS NULL"
                                              ).OrderBy("i.InventoryId Desc");
                var dbProducts = db.Query<Models.InventoryProductCategoryPrice>(sql);
                return dbProducts.ToList();
            }
        }
        public static bool AddInventory(Models.Inventories inventory, string[] supplierList = null, List<double?> unitCostList = null)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var productId = 0;
                        if (inventory.Product != null)
                        {
                            var product = inventory.Product;
                            if (product.Price != null)
                            {
                                // Add the Price to Prices Table
                                var price = product.Price;
                                var dbPrice = new Data.Price()
                                {
                                    RetailPrice = price.RetailPrice,
                                    WholesalePrice = price.WholesalePrice,
                                    CreationDate = DateTime.Now
                                };
                                db.Save(dbPrice);

                                // Add the Product to Products table if it does not exist
                                var dbProduct = new Data.Product()
                                {
                                    CategoryId = product.CategoryId,
                                    PriceId = dbPrice.PriceId,
                                    Barcode = product.Barcode,
                                    Description = product.Description,
                                    FullDescription = product.FullDescription,
                                    CreationDate = DateTime.Now
                                };
                                db.Save(dbProduct);
                                productId = dbProduct.ProductId;
                                
                            }                            
                        }

                        //Add Supplier List
                        if (supplierList != null)
                        {
                            //check if the list are still the same
                            var counter = 0;
                            foreach (string name in supplierList)
                            {
                                var supplier = Supplier.GetByName(name);
                                var supplierXrefModel = new Models.SupplierProductRef()
                                {
                                    SupplierId = supplier.SupplierId,
                                    ProductId = productId,
                                    CreationDate = DateTime.Now,
                                    UnitCost = unitCostList[counter],
                                };
                                var addSupplier = SupplierProductRef.AddXref(supplierXrefModel);
                                counter++;
                            }
                        }

                        // Add the Inventory to Inventories table
                        var dbInventory = new Data.Inventory()
                        {
                            ProductId = productId,
                            Quantity = inventory.Quantity,
                            UOM = inventory.UOM,
                            MaxInventory = inventory.MaximumInventory,
                            CriticalInventory = inventory.CriticalInventory,
                            MinInventory = inventory.MinimumInventory,
                            CreationDate = DateTime.Now
                        };
                        db.Save(dbInventory);

                        scope.Complete();
                    }
                    return true;
                }
            }
            catch(Exception e)
            {
                var error = e.Message;
                return false;
            }
        }
        private static int IsOnIdex(List<Models.SupplierProductRef> supplierList, string supplierName)
        {
            var index = -1;
            for (int x = 0; x < supplierList.Count; x++) {
                if (supplierList[x].Supplier.SupplierName == supplierName) {
                    index = x;
                    break;
                }
            }
            return index;
        }

        public static bool UpdateInventory(Models.Inventories inventory,string[] supplierList = null, List<double?> unitCostList = null)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {
                        var productId = 0;
                        if (inventory.Product != null)
                        {
                            var product = inventory.Product;
                            var newPriceId = 0;
                            if (product.Price != null)
                            {
                                var price = product.Price;
                                var priceModel = Business.Facades.Prices.GetByPriceId(price.PriceId);
                                if (priceModel != null)
                                {
                                    // Compare the Prices between Price Input vs Price in Database
                                    var priceIsSame = Business.Facades.Prices.IsSame(price);
                                    if (!priceIsSame)
                                    {
                                        // Delete the old Price entry
                                        Business.Facades.Prices.DeletePrice(price.PriceId);

                                        // Add the new Price in Prices table
                                        var dbPrice = new Data.Price()
                                        {
                                            RetailPrice = price.RetailPrice,
                                            WholesalePrice = price.WholesalePrice,
                                            CreationDate = DateTime.Now
                                        };
                                        db.Save(dbPrice);
                                        newPriceId = dbPrice.PriceId;
                                    }
                                }

                                // Update the Product in Products table
                                productId = product.ProductId;
                                var dbProduct = db.FirstOrDefault<Data.Product>("WHERE ProductId = @0", product.ProductId);
                                dbProduct.CategoryId = product.CategoryId;
                                dbProduct.PriceId = newPriceId > 0 ? newPriceId : product.PriceId;
                                dbProduct.Barcode = product.Barcode;
                                dbProduct.Description = product.Description;
                                dbProduct.FullDescription = product.FullDescription;
                                dbProduct.ModificationDate = DateTime.Now;
                                db.Update(dbProduct);
                            }
                        }

                        //Update Supplier List
                        var existingList = SupplierProductRef.GetAllSupplierByProductId(productId);
                        if (supplierList != null && unitCostList != null)
                        {
                            //check if the list are still the same
                            var counter = 0;
                            foreach (string name in supplierList)
                            {
                                var supplier = Supplier.GetByName(name);
                                var supplierXrefModel = new Models.SupplierProductRef()
                                {
                                    SupplierId = supplier.SupplierId,
                                    ProductId = productId,
                                    CreationDate = DateTime.Now,
                                    UnitCost = unitCostList[counter] != 0 ? unitCostList[counter] : null,
                                };

                                //if there's a match remove it on the existing list
                                int index = IsOnIdex(existingList, name);
                                if (index != -1)
                                {
                                    existingList.RemoveAt(index);
                                    SupplierProductRef.UpdateXref(supplierXrefModel);
                                }
                                else
                                {
                                    //if there isn't a match add to database
                                   SupplierProductRef.AddXref(supplierXrefModel);
                                }
                                counter++;
                            }
                        }
                        if (existingList.Count > 0 || supplierList != null)
                        {
                            //remove the remaining supplier on existing list
                            foreach (Models.SupplierProductRef supplierRef in existingList)
                            {
                                SupplierProductRef.DeleteXref(supplierRef.XRefId);
                            }
                        }

                        // Update the Inventory to Inventories table
                        var dbInventory = db.FirstOrDefault<Data.Inventory>("WHERE InventoryId = @0", inventory.InventoryId);
                        dbInventory.ProductId = inventory.ProductId;
                        dbInventory.Quantity = inventory.Quantity;
                        dbInventory.UOM = inventory.UOM;
                        dbInventory.MinInventory = inventory.MinimumInventory;
                        dbInventory.MaxInventory = inventory.MaximumInventory;
                        dbInventory.CriticalInventory = inventory.CriticalInventory;
                        dbInventory.ModificationDate = DateTime.Now;
                        db.Update(dbInventory);

                        scope.Complete();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateInventoryStocks(int productId,double updateQuantity)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {
                            var dbInventory = db.FirstOrDefault<Data.Inventory>("WHERE ProductId = @0 AND EndDate IS NULL", productId);
                            if (dbInventory != null)
                            {
                                dbInventory.Quantity = dbInventory.Quantity + updateQuantity;
                                dbInventory.ModificationDate = DateTime.Now;
                                dbInventory.Update();
                            }
                        scope.Complete();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteInventory(int inventoryId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {
                        var dbInventory = db.FirstOrDefault<Data.Inventory>("WHERE InventoryId = @0", inventoryId);
                        if (dbInventory != null)
                        {
                            dbInventory.EndDate = DateTime.Now;
                            db.Update(dbInventory);

                            var dbProduct = db.FirstOrDefault<Data.Product>("WHERE ProductId = @0", dbInventory.ProductId);
                            if (dbProduct != null)
                            {
                                dbProduct.EndDate = DateTime.Now;
                                db.Update(dbProduct);

                                //Remove SupplierRefs
                                var dbSupplierRefs = SupplierProductRef.RemoveAllXrefByDeleteProductId(dbInventory.ProductId);

                                var dbPrice = db.FirstOrDefault<Data.Price>("WHERE PriceId = @0", dbProduct.PriceId);
                                if (dbPrice != null)
                                {
                                    var historyModel = new Business.Models.PriceHistory()
                                    {
                                        PriceId = dbPrice.PriceId,
                                        ProductId = dbProduct.ProductId,
                                    };
                                    var insertToHistory = PriceHistory.AddPriceToHistory(historyModel);

                                    dbPrice.EndDate = DateTime.Now;
                                    db.Update(dbPrice);

                                    scope.Complete();
                                }
                            }
                        }
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
