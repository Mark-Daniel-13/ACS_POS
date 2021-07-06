using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class SupplierProductRef
    {
        public static Models.SupplierProductRef ToModel(Data.SupplierProductRef xref)
        {
            return new Models.SupplierProductRef()
            {
                XRefId = xref.XRefId,
                UnitCost = xref.UnitCost,
                SupplierId = xref.SupplierId,
                ProductId = xref.ProductId,
                CreationDate = xref.CreationDate,
                EndDate = xref.EndDate,

            };
        }
        public static Models.SupplierProductRef ToModel(Data.SupplierProductRef xref, Models.Supplier supplier , Models.Products product = null)
        {
            return new Models.SupplierProductRef()
            {
                XRefId = xref.XRefId,
                UnitCost = xref.UnitCost,
                SupplierId = xref.SupplierId,
                Supplier = supplier,
                ProductId = xref.ProductId,
                Product = product,
                CreationDate = xref.CreationDate,
                EndDate = xref.EndDate,

            };
        }

        public static List<Models.SupplierProductRef> ToModelList(List<Data.SupplierProductRef> xreflist)
        {
            var xrefListModel = new List<Models.SupplierProductRef>();
            xrefListModel = xreflist.Select(list => new Models.SupplierProductRef
            {
                XRefId = list.XRefId,
                UnitCost = list.UnitCost,
                SupplierId = list.SupplierId,
                ProductId = list.ProductId,
                CreationDate = list.CreationDate,
                EndDate = list.EndDate,
            }).ToList();

            return xrefListModel;
        }
        public static List<Models.SupplierProductRef> ToModelList(List<Data.SupplierProductRef> xreflist , List<Models.Supplier> suppliers, List<Models.Products> products)
        {
            var xrefListModel = new List<Models.SupplierProductRef>();
            xrefListModel = xreflist.Select(list => new Models.SupplierProductRef
            {
                XRefId = list.XRefId,
                UnitCost = list.UnitCost,
                SupplierId = list.SupplierId,
                Supplier = suppliers != null ? suppliers.Where(s => s.SupplierId == list.SupplierId).FirstOrDefault() : null,
                ProductId = list.ProductId,
                Product = products != null ? products.Where(s => s.ProductId == list.ProductId).FirstOrDefault() : null,
                CreationDate = list.CreationDate,
                EndDate = list.EndDate,
            }).ToList();

            return xrefListModel;
        }

        public static List<Models.SupplierProductRef> GetAll()
        {

            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var xrefLists = db.Fetch<Data.SupplierProductRef>("WHERE EndDate IS NULL ORDER BY XRefId Desc");
                if (xrefLists == null) return null;
                if (xrefLists.Count == 0) return null;

                return ToModelList(xrefLists);
            }
        }
        public static Models.SupplierProductRef CheckIfExisting(string supplierName,int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbSupplier = Supplier.GetByName(supplierName);
                var dbXRef = db.FirstOrDefault<Data.SupplierProductRef>("WHERE SupplierId = @0 AND ProductId = @1 AND EndDate IS NULL", dbSupplier.SupplierId , productId);
                if (dbXRef == null) return null;

                return ToModel(dbXRef);
            }
        }

        public static Models.SupplierProductRef GetById(int xrefId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbXRef = db.FirstOrDefault<Data.SupplierProductRef>("WHERE XRefId=@0 AND EndDate IS NULL", xrefId);
                if (dbXRef == null) return null;

                var supplier = Supplier.GetById(dbXRef.SupplierId);
                var product = Products.GetByProductId(dbXRef.ProductId);

                return ToModel(dbXRef,supplier,product);
            }
        }
        public static Models.SupplierProductRef GetBySupplierAndProductId(int supplierId,int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbXRef = db.FirstOrDefault<Data.SupplierProductRef>("WHERE SupplierId=@0 AND ProductId = @1 ORDER BY XRefId Desc", supplierId,productId);
                if (dbXRef == null) return null;

                return ToModel(dbXRef);
            }
        }
        public static List<Models.SupplierProductRef> GetAllSupplierByProductId(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbXRefList = db.Fetch<Data.SupplierProductRef>("WHERE ProductId=@0 AND EndDate IS NULL", productId);
                if (dbXRefList == null) return null;

                var dbsupplierList = Supplier.GetAll();

                return ToModelList(dbXRefList, dbsupplierList,null);
            }
        }
        public static string GetAllSupplierByProductIdString(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbXRefList = db.Fetch<Data.SupplierProductRef>("WHERE ProductId=@0 AND EndDate IS NULL", productId);
                if (dbXRefList == null || dbXRefList.Count == 0) return null;

                var dbsupplierList = Supplier.GetAll();
                var xRefListModel = ToModelList(dbXRefList, dbsupplierList,null);
                var allSupplierName = "";

                foreach (Models.SupplierProductRef supplier in xRefListModel)
                {
                    if(supplier.Supplier != null)
                        allSupplierName += string.Format("{0},", supplier.Supplier.SupplierName);
                }

                return dbXRefList.Count>=1 ? allSupplierName.Remove(allSupplierName.Length - 1) : allSupplierName;
            }
        }
        public static List<double?> GetAllSupplierUnitCostByProductId(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbXRefList = db.Fetch<Data.SupplierProductRef>("WHERE ProductId=@0 AND EndDate IS NULL", productId);
                if (dbXRefList == null || dbXRefList.Count == 0) return null;

                var xRefListModel = ToModelList(dbXRefList);
                List<double?> unitCostList = new List<double?>();

                foreach (Models.SupplierProductRef supplier in xRefListModel)
                {
                    unitCostList.Add(supplier.UnitCost);
                }

                //return dbXRefList.Count >= 1 ? allSupplierCost.Remove(allSupplierCost.Length - 1) : allSupplierCost;
                return unitCostList;
            }
        }
        public static int GetLatestInsert(int productId,int supplerId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbXRef = db.FirstOrDefault<Data.SupplierProductRef>("Select MAX(XRefId) As RefId WHERE ProductId=@0 AND SupplierId = @1 AND EndDate IS NULL", productId,supplerId);
                if (dbXRef == null) return 0;

                return dbXRef.XRefId;
            }
        }
        public static List<Models.SupplierProductRef> SearchBySupplierId(int supplierId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbXRef = db.Fetch<Data.SupplierProductRef>("Where SupplierId = @0 AND EndDate Is Null", supplierId);
                if (dbXRef == null) return null;

                var supplier = Facades.Supplier.GetAll();
                var products = Facades.Products.GetAll();
                return ToModelList(dbXRef,supplier,products);
            }
        }

        public static bool AddXref(Models.SupplierProductRef xref)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbXRef = new Data.SupplierProductRef()
                        {
                           UnitCost = xref.UnitCost,
                           SupplierId = xref.SupplierId,
                           ProductId = xref.ProductId,
                            CreationDate = DateTime.Now,
                        };
                        db.Save(dbXRef);

                        scope.Complete();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateXref(Models.SupplierProductRef xref)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbXref = db.FirstOrDefault<Data.SupplierProductRef>("WHERE ProductId= @0 AND SupplierId = @1 AND EndDate IS NULL", xref.ProductId,xref.SupplierId);

                        if (dbXref != null)
                        {
                            if (dbXref.UnitCost != xref.UnitCost) {
                                //create a new xref then remove the old one

                                var newXref = new Data.SupplierProductRef() {
                                    UnitCost = xref.UnitCost,
                                    SupplierId = dbXref.SupplierId,
                                    ProductId = dbXref.ProductId,
                                    CreationDate = DateTime.Now,
                                };
                                db.Save(newXref);

                                dbXref.EndDate = DateTime.Now;
                                db.Update(dbXref);

                            }
                            scope.Complete();
                        }
                        else {
                            return false;
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteXref(int xrefId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbXref = db.FirstOrDefault<Data.SupplierProductRef>("WHERE XRefId = @0", xrefId);
                    dbXref.EndDate = DateTime.Now;
                    db.Update(dbXref);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool RemoveAllXrefByDeleteProductId(int productId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbXref = db.Fetch<Data.SupplierProductRef>("WHERE ProductId = @0", productId);
                    if (dbXref == null) return true;
                    
                    dbXref.ForEach(xref=>{
                        xref.EndDate = DateTime.Now;
                        db.Update(xref);
                    });
                   
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
