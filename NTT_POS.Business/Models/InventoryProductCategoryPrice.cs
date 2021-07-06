using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class InventoryProductCategoryPrice
    {
        // Inventory
        public int InventoryId { get; set; }
        public int InventoryProductId { get; set; }
        public double Quantity { get; set; }
        public string UOM { get; set; }
        public int MaxInventory { get; set; }
        public int MinInventory { get; set; }
        public int CriticalInventory { get; set; }

        public DateTime InventoryCreationDate { get; set; }
        public DateTime? InventoryModificationDate { get; set; }
        public DateTime? InventoryEndDate { get; set; }

        // Product
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductPriceId { get; set; }
        public string Barcode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductFullDescription { get; set; }
        public DateTime ProductCreationDate { get; set; }
        public DateTime? ProductModificationDate { get; set; }
        public DateTime? ProductEndDate { get; set; }

        // Category
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public DateTime CategoryCreationDate { get; set; }
        public DateTime? CategoryModificationDate { get; set; }
        public DateTime? CategoryEndDate { get; set; }

        // Price
        public int PriceId { get; set; }
        public double UnitCost { get; set; }
        public double RetailPrice { get; set; }
        public double WholesalePrice { get; set; }
        public DateTime PriceCreationDate { get; set; }
        public DateTime? PriceEndDate { get; set; }

        //Supplier
        public int SupplierId { get; set; }
        public string Suppliername { get; set; }
        public DateTime? SupplierEndDate { get; set; }
    }
}
