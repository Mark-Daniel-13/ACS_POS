using NTT_POS.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class SupplierViewModel
    {
        public string Barcode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductFullDescription { get; set; }
        public double Quantity { get; set; }
        public double UnitCost { get; set; }
        public int XrefId { get; set; }
        public int OrderLevel { get; set; }

        public static SupplierViewModel ToViewModel(Business.Models.SupplierProductRef supplier)
        {
            var supplierVM = new SupplierViewModel();
            supplierVM.XrefId = supplier.XRefId;
            supplierVM.Barcode = supplier.Product.Barcode;
            supplierVM.ProductDescription = supplier.Product.Description;
            supplierVM.ProductFullDescription = supplier.Product.FullDescription;
            supplierVM.UnitCost = supplier.UnitCost != null ? (double)supplier.UnitCost : 0;

            var quantity = Business.Facades.Inventories.GetByProductId(supplier.Product.ProductId);
            supplierVM.Quantity = quantity.Quantity != null ? (double)quantity.Quantity : 0;

            return supplierVM;
        }

        public static List<SupplierViewModel> ToViewModelList(List<Business.Models.SupplierProductRef> suppliers)
        {
            var SupplierVMList = new List<SupplierViewModel>();
            suppliers.ForEach(supplier =>
            {
                var supplierVM = new SupplierViewModel();
                supplierVM.XrefId = supplier.XRefId;
                supplierVM.Barcode = supplier.Product.Barcode;
                supplierVM.ProductDescription = supplier.Product.Description;
                supplierVM.ProductFullDescription = supplier.Product.FullDescription;
                supplierVM.UnitCost = supplier.UnitCost != null ? (double)supplier.UnitCost : 0;

                var quantity = Business.Facades.Inventories.GetByProductId(supplier.Product.ProductId);
                supplierVM.Quantity = quantity.Quantity != null ? (double)quantity.Quantity : 0;

                int reOrderLevel = (quantity.CriticalInventory != null && quantity.Quantity != null) ? (int)quantity.CriticalInventory - Convert.ToInt32(quantity.Quantity) : Convert.ToInt32(quantity.CriticalInventory);
                supplierVM.OrderLevel = (reOrderLevel < 0) ? 0 : reOrderLevel;

                SupplierVMList.Add(supplierVM);
            });

            return SupplierVMList;
        }
    }
}
