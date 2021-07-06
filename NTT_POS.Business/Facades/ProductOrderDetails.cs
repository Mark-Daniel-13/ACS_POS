using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class ProductOrderDetails
    {
        public static Models.ProductOrderDetails ToModel(Data.ProductOrderDetail orderDetails)
        {
            return new Models.ProductOrderDetails()
            {
                OrderDetailsId = orderDetails.OrderDetailsId,
                ProductOrderId = orderDetails.ProductOrderId,
                ProductId = orderDetails.ProductId,
                OrderQuantity = orderDetails.OrderQuantity,
                CreationDate = orderDetails.CreationDate,
                EndDate = orderDetails.EndDate,
                FinalUnitCost = orderDetails.FinalUnitCost,
                ExpirationDate = orderDetails.ExpirationDate,
            };
        }
        public static Models.ProductOrderDetails ToModel(Data.ProductOrderDetail orderDetails, Models.Products product = null)
        {
            return new Models.ProductOrderDetails()
            {
                OrderDetailsId = orderDetails.OrderDetailsId,
                ProductOrderId = orderDetails.ProductOrderId,
                ProductId = orderDetails.ProductId,
                Product = product,
                OrderQuantity = orderDetails.OrderQuantity,
                CreationDate = orderDetails.CreationDate,
                EndDate = orderDetails.EndDate,
                FinalUnitCost = orderDetails.FinalUnitCost,
                ExpirationDate = orderDetails.ExpirationDate,
            };
        }

        public static List<Models.ProductOrderDetails> ToModelList(List<Data.ProductOrderDetail> ordersDetail)
        {
            var ordersDetailList = new List<Models.ProductOrderDetails>();
            ordersDetailList = ordersDetail.Select(order => new Models.ProductOrderDetails
            {
                OrderDetailsId = order.OrderDetailsId,
                ProductOrderId = order.ProductOrderId,
                ProductId = order.ProductId,
                OrderQuantity = order.OrderQuantity,
                CreationDate = order.CreationDate,
                EndDate = order.EndDate,
                FinalUnitCost = order.FinalUnitCost,
                ExpirationDate = order.ExpirationDate,
            }).ToList();

            return ordersDetailList;
        }
        public static List<Models.ProductOrderDetails> ToModelList(List<Data.ProductOrderDetail> ordersDetail, List<Models.Products> products = null)
        {
            var ordersDetailList = new List<Models.ProductOrderDetails>();
            ordersDetailList = ordersDetail.Select(order => new Models.ProductOrderDetails
            {
                OrderDetailsId = order.OrderDetailsId,
                ProductOrderId = order.ProductOrderId,
                ProductId = order.ProductId,
                Product = products != null ? products.Where(s => s.ProductId == order.ProductId).FirstOrDefault() : null,
                OrderQuantity = order.OrderQuantity,
                CreationDate = order.CreationDate,
                EndDate = order.EndDate,
                FinalUnitCost = order.FinalUnitCost,
                ExpirationDate = order.ExpirationDate,

            }).ToList();

            return ordersDetailList;
        }

        public static List<Models.ProductOrderDetails> GetByProductOrderId(int productOrderId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var orders = db.Fetch<Data.ProductOrderDetail>("WHERE ProductOrderId = @0 And EndDate IS NULL", productOrderId);
                if (orders == null) return null;

                var products = Facades.Products.GetAll();
                return ToModelList(orders, products);
            }
        }
        public static List<Models.ProductOrderDetails> GetByProductId(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var orders = db.Fetch<Data.ProductOrderDetail>("WHERE ProductId = @0 And EndDate IS NULL", productId);
                if (orders == null) return null;

                return ToModelList(orders);
            }
        }
        public static bool OrderDeliveredUpdateFinalUnitCost(int orderId,List<int> idList,List<DateTime> expDateList)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {
                        var supplierId = Business.Facades.ProductOrder.GetById(orderId).SupplierId;
                        var dbOrderDetail = db.Fetch<Data.ProductOrderDetail>("WHERE ProductOrderId = @0 AND EndDate IS NULL", orderId);
                        if (dbOrderDetail == null) return false;

                        dbOrderDetail.ForEach(detail =>
                        {
                            var supplierUnitCost = db.FirstOrDefault<Data.SupplierProductRef>("Where SupplierId = @0 And ProductId = @1 And EndDate IS NULL", supplierId, detail.ProductId).UnitCost;
                            detail.FinalUnitCost = supplierUnitCost;

                            //update expiration date 
                            var currIndex = idList.IndexOf(detail.OrderDetailsId);
                            detail.ExpirationDate = expDateList[currIndex];
                            db.Update(detail);
                        });

                        scope.Complete();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool AddOrderDetails(Models.ProductOrderDetails orderDetails)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbOrderDetails = new Data.ProductOrderDetail()
                        {
                            ProductOrderId = orderDetails.ProductOrderId,
                            ProductId = orderDetails.ProductId,
                            OrderQuantity = orderDetails.OrderQuantity,
                            ExpirationDate = orderDetails.ExpirationDate,
                            CreationDate = DateTime.Now,
                        };
                        db.Save(dbOrderDetails);

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

        public static bool ModifyOrderDetail(Models.ProductOrderDetails newOrderDetails,int oldOrderDetailId,double unitCost,int supplierId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        //End the previous order detail
                        var dbOrderDetail = db.FirstOrDefault<Data.ProductOrderDetail>("WHERE OrderDetailsId = @0 AND EndDate IS NULL", oldOrderDetailId);
                        if (dbOrderDetail.OrderQuantity != newOrderDetails.OrderQuantity)
                        {
                            dbOrderDetail.EndDate = DateTime.Now;

                            db.Update(dbOrderDetail);
                            newOrderDetails.ExpirationDate = dbOrderDetail.ExpirationDate;
                            AddOrderDetails(newOrderDetails);

                            //Update inventory quantity if order type is already delivered to match/sync inventory list quantity
                            var orderModel = db.FirstOrDefault<Data.ProductOrder>("Where ProductOrderId = @0", newOrderDetails.ProductOrderId);
                            if(orderModel.OrderStatusId == (int)Enums.OrderStatus.Received) {
                                var sum = newOrderDetails.OrderQuantity - dbOrderDetail.OrderQuantity;
                               Business.Facades.Inventories.UpdateInventoryStocks(dbOrderDetail.ProductId,sum);
                            }
                        }

                        var oldUnitCost = db.FirstOrDefault<Data.SupplierProductRef>("Where SupplierId = @0 AND ProductId = @1 AND EndDate IS NULL", supplierId,dbOrderDetail.ProductId);
                        if (oldUnitCost != null) {
                            if (oldUnitCost.UnitCost != unitCost)
                            {
                                oldUnitCost.EndDate = DateTime.Now;

                                db.Update(oldUnitCost);

                                var newUnitCost = new Models.SupplierProductRef()
                                {
                                    UnitCost = unitCost,
                                    SupplierId = supplierId,
                                    ProductId = newOrderDetails.ProductId,
                                    CreationDate = DateTime.Now,
                                };

                              SupplierProductRef.AddXref(newUnitCost);
                            }
                        }
                        
                        scope.Complete();
                    }
                }
                return true;
            }
            catch(Exception e)
            {
                var msg = e.Message;
                return false;
            }
        }
    }
}
