using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class ProductOrder
    {
        public static Models.ProductOrder ToModel(Data.ProductOrder order)
        {
            return new Models.ProductOrder()
            {
                ProductOrderId = order.ProductOrderId,
                SupplierId = order.SupplierId,
                OrderStatusId = (Enums.OrderStatus) order.OrderStatusId,
                CreationDate = order.CreationDate,
                EndDate = order.EndDate,
            };
        }
        public static Models.ProductOrder ToModel(Data.ProductOrder order, Models.Supplier supplier = null)
        {
            return new Models.ProductOrder()
            {
                ProductOrderId = order.ProductOrderId,
                SupplierId = order.SupplierId,
                Supplier = supplier != null ? supplier : null,
                OrderStatusId = (Enums.OrderStatus)order.OrderStatusId,
                CreationDate = order.CreationDate,
                EndDate = order.EndDate,
            };
        }

        public static List<Models.ProductOrder> ToModelList(List<Data.ProductOrder> orders)
        {
            var orderList = new List<Models.ProductOrder>();
            orderList = orders.Select(order => new Models.ProductOrder
            {
                ProductOrderId = order.ProductOrderId,
                SupplierId = order.SupplierId,
                OrderStatusId = (Enums.OrderStatus)order.OrderStatusId,
                CreationDate = order.CreationDate,
                EndDate = order.EndDate,
            }).ToList();

            return orderList;
        }
        public static List<Models.ProductOrder> ToModelList(List<Data.ProductOrder> orders, List<Models.Supplier> suppliers = null)
        {
            var orderList = new List<Models.ProductOrder>();
            orderList = orders.Select(order => new Models.ProductOrder
            {
                ProductOrderId = order.ProductOrderId,
                SupplierId = order.SupplierId,
                Supplier = suppliers != null ? suppliers.Where(s => s.SupplierId == order.SupplierId).FirstOrDefault() : null,
                OrderStatusId = (Enums.OrderStatus)order.OrderStatusId,
                CreationDate = order.CreationDate,
                EndDate = order.EndDate,
            }).ToList();

            return orderList;
        }

        public static List<Models.ProductOrder> GetBySupplierId(int supplierId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var orders = db.Fetch<Data.ProductOrder>("WHERE SupplierId = @0 And EndDate IS NULL Order By ProductOrderId DESC", supplierId);
                if (orders == null) return null;

                var suppliers = Facades.Supplier.GetAll();
                return ToModelList(orders,suppliers);
            }
        }
        public static Models.ProductOrder GetById(int orderId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var orders = db.FirstOrDefault<Data.ProductOrder>("WHERE ProductOrderId = @0 And EndDate IS NULL", orderId);
                if (orders == null) return null;

                var supplier = Facades.Supplier.GetById(orders.SupplierId);
                return ToModel(orders, supplier);
            }
        }
        public static List<Models.ProductOrder> GetAll()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var orders = db.Fetch<Data.ProductOrder>("WHERE EndDate IS NULL");
                if (orders == null) return null;

                var suppliers = Facades.Supplier.GetAll();
                return ToModelList(orders, suppliers);
            }
        }

        public static bool AddOrders(Models.ProductOrder orders)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {
                        var dbOrder = new Data.ProductOrder()
                        {
                            SupplierId = orders.SupplierId,
                            OrderStatusId = (int)orders.OrderStatusId,
                            CreationDate = DateTime.Now,
                        };
                        db.Save(dbOrder);
                        var orderDetails = orders.OrderDetails;

                        if (orderDetails != null)
                        {
                            orderDetails.ForEach(order =>
                            {
                                var dbOrderDetails = new Data.ProductOrderDetail()
                                {
                                    ProductOrderId = dbOrder.ProductOrderId,
                                    ProductId = order.ProductId,
                                    OrderQuantity = order.OrderQuantity,
                                    CreationDate = DateTime.Now
                                };
                                db.Save(dbOrderDetails);

                            });
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
        public static bool UpdateStatus(int orderId,Business.Enums.OrderStatus status)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {
                        var dbOrder = db.FirstOrDefault<Data.ProductOrder>("WHERE ProductOrderId = @0 AND EndDate IS NULL", orderId);
                        if (dbOrder == null) return false;
                        dbOrder.OrderStatusId = (int)status;
                        db.Update(dbOrder);

                        //update stocks if items was delivered
                        if (status == Enums.OrderStatus.Received) {
                            var orderDetails = ProductOrderDetails.GetByProductOrderId(orderId);
                            if (orderDetails.Count > 0) {
                                orderDetails.ForEach(order =>
                                {
                                    var inventory = db.FirstOrDefault<Data.Inventory>("WHERE ProductId = @0 AND EndDate IS NULL", order.ProductId);
                                    if (inventory != null) {
                                        if (inventory.Quantity != null)
                                        {
                                            inventory.Quantity += order.OrderQuantity;
                                        }
                                        else {
                                            inventory.Quantity = order.OrderQuantity;
                                        }
                                    }
                                    db.Update(inventory);
                                });
                            }
                        }

                        scope.Complete();
                        return true;
                    }
                }
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public static bool DeleteOrder(int orderId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbOrder = db.FirstOrDefault<Data.Category>("WHERE ProductOrderId = @0", orderId);
                    if (dbOrder != null)
                    {
                        dbOrder.EndDate = DateTime.Now;
                        db.Update(dbOrder);
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
