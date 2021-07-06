using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class Products
    {
        public static Models.Products ToModel(Data.Product product, Models.Categories category, Models.Prices price)
        {
            return new Models.Products()
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                Category = category,
                PriceId = product.PriceId,
                Price = price,
                Barcode = product.Barcode,
                Description = product.Description,
                FullDescription = product.FullDescription,
                CreationDate = product.CreationDate,
                ModificationDate = product.ModificationDate,
                EndDate = product.EndDate
            };
        }
        public static Models.Products ToModel(Data.Product product)
        {
            return new Models.Products()
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                PriceId = product.PriceId,
                Barcode = product.Barcode,
                Description = product.Description,
                FullDescription = product.FullDescription,
                CreationDate = product.CreationDate,
                ModificationDate = product.ModificationDate,
                EndDate = product.EndDate
            };
        }

        public static List<Models.Products> ToModelList(List<Data.Product> products)
        {
            var productList = new List<Models.Products>();
            productList = products.Select(product => new Models.Products()
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                PriceId = product.PriceId,
                Barcode = product.Barcode,
                Description = product.Description,
                FullDescription = product.FullDescription,
                CreationDate = product.CreationDate,
                ModificationDate = product.ModificationDate,
                EndDate = product.EndDate
            }).ToList();

            return productList;
        }

        public static List<Models.Products> ToModelList(List<Data.Product> products, List<Models.Prices> prices)
        {
            var productList = new List<Models.Products>();
            productList = products.Select(product => new Models.Products()
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                PriceId = product.PriceId,
                Price = prices != null ? prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault() : null,
                Barcode = product.Barcode,
                Description = product.Description,
                FullDescription = product.FullDescription,
                CreationDate = product.CreationDate,
                ModificationDate = product.ModificationDate,
                EndDate = product.EndDate
            }).ToList();

            return productList;
        }

        public static List<Models.Products> ToModelList(List<Data.Product> products, List<Models.Categories> categories, List<Models.Prices> prices)
        {
            var productList = new List<Models.Products>();
            productList = products.Select(product => new Models.Products()
            {
                ProductId = product.ProductId,
                CategoryId = product.CategoryId,
                Category = categories != null ? categories.Where(c => c.CategoryId == product.CategoryId).FirstOrDefault() : null,
                PriceId = product.PriceId,
                Price = prices != null ? prices.Where(p => p.PriceId == product.PriceId).FirstOrDefault() : null,
                Barcode = product.Barcode,
                Description = product.Description,
                FullDescription = product.FullDescription,
                CreationDate = product.CreationDate,
                ModificationDate = product.ModificationDate,
                EndDate = product.EndDate
            }).ToList();

            return productList;
        }

        public static List<Models.Products> GetAll()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProducts = db.Fetch<Data.Product>("WHERE EndDate IS NULL");
                if (dbProducts == null) return null;
                if (dbProducts.Count == 0) return null;

                var dbCategories = db.Fetch<Data.Category>("WHERE EndDate IS NULL");
                var dbPrices = db.Fetch<Data.Price>("");
                var dbSuppliers = db.Fetch<Data.Supplier>("Where EndDate IS NULL");

                var categories = dbCategories != null ? Categories.ToModelList(dbCategories) : null;
                var prices = Business.Facades.Prices.ToModelList(dbPrices);
                var suppliers = dbSuppliers != null ? Supplier.ToModelList(dbSuppliers) : null;

                return ToModelList(dbProducts, categories, prices);
            }
        }

        public static Models.Products GetByProductId(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProduct = db.FirstOrDefault<Data.Product>("WHERE ProductId = @0", productId);
                if (dbProduct == null) return null;
                
                
                var category =dbProduct.CategoryId != null ? Categories.GetByCategoryId((int)dbProduct.CategoryId) : null;
                var price =Prices.GetByPriceId(dbProduct.PriceId);

                return ToModel(dbProduct, category, price);
            }
        }
        public static Models.Products GetByPriceId(int priceId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProduct = db.FirstOrDefault<Data.Product>("WHERE PriceId = @0 AND EndDate IS NULL", priceId);
                if (dbProduct == null) return null;
                return ToModel(dbProduct);
            }
        }
        public static string GetProductNameById(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProduct = db.FirstOrDefault<Data.Product>("WHERE ProductId = @0", productId);
                if (dbProduct == null) return null;

                return dbProduct.FullDescription;
            }
        }

        public static List<Models.Products> GetByProductIdList(List<int> productIdList)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProducts = db.Fetch<Data.Product>("WHERE ProductId IN (@0)", productIdList);
                if (dbProducts == null) return null;
                if (dbProducts.Count == 0) return null;

                var categories = Business.Facades.Categories.GetByCategoryIdList(dbProducts.Select(s =>(int) s.CategoryId).ToList());
                var prices = Business.Facades.Prices.GetByPriceIdList(dbProducts.Select(s => s.PriceId).ToList());

                return ToModelList(dbProducts, categories, prices);
            }
        }

        public static Models.Products GetByProductBarcode(string barcode,int? productId = null)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProduct = productId != null ? db.FirstOrDefault<Data.Product>("WHERE Barcode = @0 AND ProductId != @1 AND EndDate IS NULL", barcode, productId) : db.FirstOrDefault<Data.Product>("WHERE Barcode = @0 AND EndDate IS NULL", barcode);
                if (dbProduct == null) return null;

                var category = (dbProduct.CategoryId == null) ? null : Business.Facades.Categories.GetByCategoryId((int)dbProduct.CategoryId);
                var price = Business.Facades.Prices.GetByPriceId(dbProduct.PriceId);

                return ToModel(dbProduct, category, price);
            }
        }
        public static Models.Products GetByProductBarcodeProductOnly(string barcode)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProduct = db.FirstOrDefault<Data.Product>("WHERE Barcode = @0 AND EndDate IS NULL", barcode);
                if (dbProduct == null) return null;

                return ToModel(dbProduct);
            }
        }
        public static bool isBarcodeExist(string barcode, int? productId = null)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProduct = productId != null ? db.FirstOrDefault<Data.Product>("WHERE Barcode = @0 AND ProductId != @1 AND EndDate IS NULL", barcode, productId) : db.FirstOrDefault<Data.Product>("WHERE Barcode = @0 AND EndDate IS NULL", barcode);
                if (dbProduct == null) return false;

                return true;
            }
        }

        public static List<Models.InventoryProductCategoryPrice> Search(string searchString)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var sql = PetaPoco.Sql.Builder.Select("p.ProductId, " +
                                                      "p.CategoryId AS ProductCategoryId, " +
                                                      "p.PriceId AS ProductPriceId, " +
                                                      "p.Barcode, " +
                                                      "p.Description AS ProductDescription, " +
                                                      "p.FullDescription AS ProductFullDescription, " +
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
                                              .From("Products p")
                                              .InnerJoin("Categories c").On("p.CategoryId = c.CategoryId")
                                              .InnerJoin("Prices pr").On("p.PriceId = pr.PriceId")
                                              .Where($"(p.Barcode LIKE '%{searchString}%' " +
                                                  $"OR p.Description LIKE '%{searchString}%' " +
                                                  $"OR p.FullDescription LIKE '%{searchString}%' " +
                                                  $"OR c.Name LIKE '%{searchString}%' " +
                                                  $"OR c.Description LIKE '%{searchString}%' " +
                                                  $"OR pr.RetailPrice LIKE '%{searchString}%') " +
                                                  $"AND p.EndDate IS NULL " +
                                                  $"AND c.EndDate IS NULL " +
                                                  $"AND pr.EndDate IS NULL"
                                              );
                var dbProducts = db.Query<Models.InventoryProductCategoryPrice>(sql);
                return dbProducts.ToList();
            }
        }

        public static bool AddProduct(Models.Products product)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbProduct = new Data.Product()
                        {
                            CategoryId = product.CategoryId,
                            PriceId = product.PriceId,
                            Barcode = product.Barcode,
                            Description = product.Description,
                            FullDescription = product.FullDescription,
                            CreationDate = DateTime.Now,
                        };
                        db.Save(dbProduct);

                        var price = product.Price;
                        var dbPrice = new Data.Price()
                        {
                            RetailPrice = price.RetailPrice,
                            WholesalePrice = price.WholesalePrice,
                            CreationDate = DateTime.Now

                        };
                        db.Save(dbPrice);

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

        public static bool UpdateProduct(Models.Products product)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var productId = 0;                  
                        var newPriceId = 0;
                        if (product.Price != null)
                            {
                                var price = product.Price;
                                var priceModel = Business.Facades.Prices.GetByPriceId(price.PriceId);
                                if (priceModel != null)
                                {
                                    var priceIsSame = Business.Facades.Prices.IsSame(price);
                                    if (!priceIsSame)
                                    {
                                        Business.Facades.Prices.DeletePrice(price.PriceId);

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
        public static bool UpdateProductCategory(int productId, int? categoryId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbProduct = db.FirstOrDefault<Data.Product>("WHERE ProductId = @0", productId);
                        if (dbProduct == null) return false;

                        dbProduct.CategoryId = categoryId;
                        dbProduct.ModificationDate = DateTime.Now;
                        db.Update(dbProduct);

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

        public static bool IsExists(string barcode)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProduct = db.FirstOrDefault<Data.Product>("WHERE Barcode = @0 AND EndDate IS NULL", barcode);
                if (dbProduct == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static bool IsExists(int productId, string barcode)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProduct = db.FirstOrDefault<Data.Product>("WHERE Barcode = @0 AND EndDate IS NULL", barcode);
                if (dbProduct == null)
                {
                    return false;
                }
                else
                {
                    if (dbProduct.ProductId == productId)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
        public static bool RemoveProductRelation(int categoryId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbProduct = db.Update<Data.Product>("SET CategoryId = @0 WHERE CategoryId = @1 AND EndDate IS NULL", null,categoryId);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static long? GetHighestUnusedBarcode()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {

                //var sql = PetaPoco.Sql.Builder.Select("Max(Cast(RIGHT(Barcode,11) as int))")
                //                              .From("BarcodeLog")
                //                              .Where("EndDate IS NULL");
                var sql = PetaPoco.Sql.Builder.Select("MAX(Cast(Right(Barcode,11) as int))") // Get maximum unused custom barcode
                                              .From("Products")
                                              .Where("Left(Barcode,2) = 'IT' AND EndDate IS NULL");
                var barcode = db.Query<long?>(sql).FirstOrDefault();
                if (barcode == null) return null;
                return barcode;
            }
        }
    }
}
