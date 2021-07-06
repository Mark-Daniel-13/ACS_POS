using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class Customer
    {
        public static Models.Customer ToModel(Data.Customer customer)
        {
            return new Models.Customer()
            {
                CustomerId = customer.CustomerId,
                CustomerName = customer.CustomerName,
                Address = customer.Address,
                Contact = customer.Contact,
                CreationDate = customer.CreationDate,
                EndDate = customer.EndDate,
                EmailAdd = customer.EmailAdd,

            };
        }

        public static List<Models.Customer> ToModelList(List<Data.Customer> customers)
        {
            var customerLists = new List<Models.Customer>();
            customerLists = customers.Select(customer => new Models.Customer
            {
                CustomerId = customer.CustomerId,
                CustomerName = customer.CustomerName,
                Address = customer.Address,
                Contact = customer.Contact,
                CreationDate = customer.CreationDate,
                EndDate = customer.EndDate,
                EmailAdd = customer.EmailAdd,
            }).ToList();

            return customerLists;
        }

        public static List<Models.Customer> GetAll() {

            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var customers = db.Fetch<Data.Customer>("WHERE EndDate IS NULL ORDER BY CustomerId Desc");
                if (customers == null) return null;
                if (customers.Count == 0) return null;

                return ToModelList(customers);
            }
        }

        public static List<Models.Customer> Search(string searchString)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbCustomers = db.Fetch<Data.Customer>("WHERE (CustomerName LIKE @0 OR Address LIKE @0 OR Contact LIKE @0) AND EndDate IS NULL ORDER BY CustomerId Desc", "%" + searchString + "%");
                if (dbCustomers == null) return null;
                if (dbCustomers.Count == 0) return null;

                return ToModelList(dbCustomers);
            }
        }

        public static bool CheckIfExist(string customerName)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbCustomer = db.FirstOrDefault<Data.Customer>("WHERE CustomerName=@0 AND EndDate IS NULL", customerName);
                if (dbCustomer == null) return false;

                return true;
            }
        }

        public static Models.Customer GetById(int customerId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbCustomer = db.FirstOrDefault<Data.Customer>("WHERE CustomerId=@0", customerId);
                if (dbCustomer == null) return null;

                return ToModel(dbCustomer);
            }
        }
        public static Models.Customer GetByName(string customerName)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbCustomer = db.FirstOrDefault<Data.Customer>("WHERE CustomerName=@0 AND EndDate IS NULL", customerName);
                if (dbCustomer == null) return null;

                return ToModel(dbCustomer);
            }
        }

        public static List<Models.Customer> GetByIdList(List<int> custonerIdLists)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                if (custonerIdLists != null)
                {
                    if (custonerIdLists.Count > 0)
                    {
                        var dbCustomer = db.Fetch<Data.Customer>("WHERE CustomerId IN (@0)", custonerIdLists);
                        if (dbCustomer == null) return null;
                        if (dbCustomer.Count == 0) return null;

                        return ToModelList(dbCustomer);
                    }
                }
                return null;
            }
        }

        public static bool AddCustomer(Models.Customer customer)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbCustomer = new Data.Customer()
                        {
                            CustomerName = customer.CustomerName,
                            Contact = customer.Contact,
                            Address = customer.Address,
                            CreationDate = DateTime.Now,
                            EmailAdd = customer.EmailAdd,
                        };
                        db.Save(dbCustomer);

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

        public static bool UpdateCustomer(Models.Customer customer)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbCustomer = db.FirstOrDefault<Data.Customer>("WHERE CustomerId = @0 AND EndDate IS NULL", customer.CustomerId);

                        dbCustomer.CustomerName = customer.CustomerName;
                        dbCustomer.Contact = customer.Contact;
                        dbCustomer.Address = customer.Address;
                        dbCustomer.EmailAdd = customer.EmailAdd;
                        db.Update(dbCustomer);
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

        public static bool DeleteCustomer(int customerId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbCustomer = db.FirstOrDefault<Data.Customer>("WHERE CustomerId = @0", customerId);
                    dbCustomer.EndDate = DateTime.Now;
                    db.Update(dbCustomer);
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
