using NTT_POS.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class InventoryViewModel
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public int PriceId { get; set; }
        public string Barcode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductFullDescription { get; set; }
        public string CategoryName { get; set; }
        public double? RetailPrice { get; set; }
        public double? WholesalePrice { get; set; }
        public double? Quantity { get; set; }
        public string UOM { get; set; }
        public int? MaxInventory { get; set; }
        public int? MinInventory { get; set; }
        public int? CriticalInventory { get; set; }
        public string SupplierName { get; set; }

        public static InventoryViewModel ToViewModel(Business.Models.Inventories inventory)
        {
            var inventoryVM = new InventoryViewModel();
            inventoryVM.InventoryId = inventory.InventoryId;
            inventoryVM.ProductId = inventory.ProductId;
            inventoryVM.Quantity = inventory.Quantity;
            inventoryVM.UOM = inventory.UOM;
            inventoryVM.MaxInventory = inventory.MaximumInventory;
            inventoryVM.MinInventory = inventory.MinimumInventory;
            inventoryVM.CriticalInventory = inventory.CriticalInventory;
            if (inventory.Product != null)
            {
                inventoryVM.CategoryId = inventory.Product.CategoryId;
                inventoryVM.PriceId = inventory.Product.PriceId;
                inventoryVM.Barcode = inventory.Product.Barcode;
                inventoryVM.ProductDescription = inventory.Product.Description;
                inventoryVM.ProductFullDescription = inventory.Product.FullDescription;
            }

            if (inventory.Product.Category != null)
            {
                inventoryVM.CategoryName = inventory.Product.Category.Name;
            }

            if (inventory.Product.Price != null)
            {
                inventoryVM.RetailPrice = inventory.Product.Price.RetailPrice;
                inventoryVM.WholesalePrice = inventory.Product.Price.WholesalePrice;
            }

            return inventoryVM;
        }

        public static List<InventoryViewModel> ToViewModelList(List<Business.Models.Inventories> inventories)
        {
            var inventoryVMList = new List<InventoryViewModel>();
            inventories.ForEach(inventory =>
            {
                var inventoryVM = new InventoryViewModel();
                inventoryVM.InventoryId = inventory.InventoryId;
                inventoryVM.ProductId = inventory.ProductId;
                inventoryVM.Quantity = inventory.Quantity;
                inventoryVM.UOM = inventory.UOM;
                inventoryVM.MaxInventory = inventory.MaximumInventory;
                inventoryVM.MinInventory = inventory.MinimumInventory;
                inventoryVM.CriticalInventory = inventory.CriticalInventory;
                if (inventory.Product != null)
                {
                    inventoryVM.CategoryId = inventory.Product.CategoryId;
                    inventoryVM.PriceId = inventory.Product.PriceId;
                    inventoryVM.Barcode = inventory.Product.Barcode;
                    inventoryVM.ProductDescription = inventory.Product.Description;
                    inventoryVM.ProductFullDescription = inventory.Product.FullDescription;

                    if (inventory.Product.Category != null)
                    {
                        inventoryVM.CategoryName = inventory.Product.Category.Name;
                    }

                    if (inventory.Product.Price != null)
                    {
                        inventoryVM.RetailPrice = inventory.Product.Price.RetailPrice;
                        inventoryVM.WholesalePrice = inventory.Product.Price.WholesalePrice;
                    }

                    string AllSupplierString = Business.Facades.SupplierProductRef.GetAllSupplierByProductIdString(inventory.Product.ProductId);
                    inventoryVM.SupplierName = AllSupplierString != null ? AllSupplierString : "";

                }

                inventoryVMList.Add(inventoryVM);
            });

            return inventoryVMList;
        }
    }
}
