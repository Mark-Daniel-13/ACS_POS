using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    class ProductOrderDeitalViewModel
    {
        public int OrderDetailsId { get; set; }

        public int ProductOrderId { get; set; }
        public Business.Models.ProductOrder ProductOrder { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double OrderQuantity { get; set; }
        public double? ProductUnitCost { get; set; }
        public double? ProductTotalUnitCost { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? CreationDate { get; set; }

        public DateTime? EndDate { get; set; }




        public static List<ProductOrderDeitalViewModel> ToViewModelList(List<Business.Models.ProductOrderDetails> orderdetails)
        {
            var detailsVMList = new List<ProductOrderDeitalViewModel>();
            var supplier = Business.Facades.ProductOrder.GetById(orderdetails[0].ProductOrderId);
            orderdetails.ForEach(datarow =>
            {
                double? unitCost;
                if (datarow.FinalUnitCost == null)
                {
                    var dbSupplierxRef = Business.Facades.SupplierProductRef.GetBySupplierAndProductId(supplier.SupplierId, datarow.ProductId);
                    if (dbSupplierxRef == null) {
                        unitCost = 0;
                    }
                    else {
                        unitCost = dbSupplierxRef.UnitCost != null ? dbSupplierxRef.UnitCost : 0;
                    }
                    
                }
                else {
                     unitCost = datarow.FinalUnitCost;
                }
                var detailVM = new ProductOrderDeitalViewModel();
                detailVM.OrderDetailsId = datarow.OrderDetailsId;
                detailVM.ProductName = Business.Facades.Products.GetByProductId(datarow.ProductId).Description;
                detailVM.ProductUnitCost = unitCost != null ? unitCost : 0;
                detailVM.ProductTotalUnitCost = Math.Round(Convert.ToDouble((unitCost != null ? unitCost : 0) * datarow.OrderQuantity), 2);
                detailVM.ProductOrderId = datarow.ProductOrderId;
                detailVM.ProductId = datarow.ProductId;
                detailVM.OrderQuantity = datarow.OrderQuantity;
                detailVM.CreationDate = datarow.CreationDate;
                detailVM.ExpirationDate = datarow.ExpirationDate != null ? datarow.ExpirationDate : null;
                detailsVMList.Add(detailVM);
            });
           

            return detailsVMList;
        }


    }
    
}
