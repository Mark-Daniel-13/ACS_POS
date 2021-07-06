using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class Inventories
    {
        public int InventoryId { get; set; }
        public int ProductId { get; set; }
        public Models.Products Product { get; set; }
        public double? Quantity { get; set; }
        public string UOM { get; set; }
        public int? CriticalInventory { get; set; }
        public int? MinimumInventory { get; set; }
        public int? MaximumInventory { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
