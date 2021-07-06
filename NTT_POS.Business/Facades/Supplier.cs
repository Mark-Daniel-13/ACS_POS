using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class Supplier
    {
        public static Models.Supplier ToModel(Data.Supplier supplier)
        {
            return new Models.Supplier()
            {
                SupplierId = supplier.SupplierId,
                SupplierName = supplier.SupplierName,
                Address = supplier.Address,
                Contact = supplier.Contact,
                TinNo=supplier.TinNo,
                CreationDate = supplier.CreationDate,
                EndDate = supplier.EndDate,
                EmailAdd = supplier.EmailAdd,
                Remarks = supplier.Remarks,

            };
        }

        public static List<Models.Supplier> ToModelList(List<Data.Supplier> suppliers)
        {
            var supplierList = new List<Models.Supplier>();
            supplierList = suppliers.Select(supplier => new Models.Supplier
            {
                SupplierId = supplier.SupplierId,
                SupplierName = supplier.SupplierName,
                Address = supplier.Address,
                Contact = supplier.Contact,
                TinNo = supplier.TinNo,
                CreationDate = supplier.CreationDate,
                EndDate = supplier.EndDate,
                EmailAdd = supplier.EmailAdd,
                Remarks = supplier.Remarks,
            }).ToList();

            return supplierList;
        }

        public static List<Models.Supplier> GetAll() {

            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var suppliers = db.Fetch<Data.Supplier>("WHERE EndDate IS NULL ORDER BY SupplierId Desc");
                if (suppliers == null) return null;
                if (suppliers.Count == 0) return null;

                return ToModelList(suppliers);
            }
        }

        public static List<Models.Supplier> Search(string searchString)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbSuppliers = db.Fetch<Data.Supplier>("WHERE (SupplierName LIKE @0 OR Address LIKE @0 OR Contact LIKE @0) AND EndDate IS NULL ORDER BY SupplierId Desc", "%" + searchString + "%");
                if (dbSuppliers == null) return null;
                if (dbSuppliers.Count == 0) return null;

                return ToModelList(dbSuppliers);
            }
        }

        public static bool CheckIfExist(string supplierName)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbSupplier = db.FirstOrDefault<Data.Supplier>("WHERE SupplierName=@0 AND EndDate IS NULL", supplierName);
                if (dbSupplier == null) return false;

                return true;
            }
        }

        public static Models.Supplier GetById(int supplierId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbSupplier = db.FirstOrDefault<Data.Supplier>("WHERE SupplierId=@0 AND EndDate IS NULL", supplierId);
                if (dbSupplier == null) return null;

                return ToModel(dbSupplier);
            }
        }

        public static Models.Supplier GetByName(string supplierName)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbSupplier = db.FirstOrDefault<Data.Supplier>("WHERE SupplierName=@0 AND EndDate IS NULL", supplierName);
                if (dbSupplier == null) return null;

                return ToModel(dbSupplier);
            }
        }

        public static List<Models.Supplier> GetByIdList(List<int> supplierIdLists)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                if (supplierIdLists != null)
                {
                    if (supplierIdLists.Count > 0)
                    {
                        var dbSupplier = db.Fetch<Data.Supplier>("WHERE SupplierId IN (@0)", supplierIdLists);
                        if (dbSupplier == null) return null;
                        if (dbSupplier.Count == 0) return null;

                        return ToModelList(dbSupplier);
                    }
                }
                return null;
            }
        }

        public static bool AddSupplier(Models.Supplier supplier)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbSupplier = new Data.Supplier()
                        {
                            SupplierName = supplier.SupplierName,
                            Contact = supplier.Contact,
                            Address = supplier.Address,
                            TinNo = supplier.TinNo,
                            CreationDate = DateTime.Now,
                            EmailAdd = supplier.EmailAdd,
                            Remarks = supplier.Remarks,
                        };
                        db.Save(dbSupplier);

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

        public static bool UpdateSupplier(Models.Supplier supplier)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbSupplier = db.FirstOrDefault<Data.Supplier>("WHERE SupplierId = @0 AND EndDate IS NULL", supplier.SupplierId);

                        dbSupplier.SupplierName = supplier.SupplierName;
                        dbSupplier.Contact = supplier.Contact;
                        dbSupplier.Address = supplier.Address;
                        dbSupplier.TinNo = supplier.TinNo;
                        dbSupplier.ModificationDate = DateTime.Now;
                        dbSupplier.EmailAdd = supplier.EmailAdd;
                        dbSupplier.Remarks = supplier.Remarks;
                        db.Update(dbSupplier);
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

        public static bool DeleteSupplier(int supplierId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {
                        var dbSupplier = db.FirstOrDefault<Data.Supplier>("WHERE SupplierId = @0", supplierId);
                        dbSupplier.EndDate = DateTime.Now;
                        db.Update(dbSupplier);

                        //remove all related supplier in xref
                       db.Update<Data.SupplierProductRef>("SET EndDate = @0 Where SupplierId = @1",DateTime.Now,dbSupplier.SupplierId);
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
    }
}
