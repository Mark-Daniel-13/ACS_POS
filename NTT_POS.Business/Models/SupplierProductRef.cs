using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class SupplierProductRef
    {
        public int XRefId { get; set; }
        public double? UnitCost { get; set; }
        public int SupplierId { get; set; }
        public Models.Supplier Supplier { get; set; }
        public int ProductId { get; set; }
        public Models.Products Product { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
