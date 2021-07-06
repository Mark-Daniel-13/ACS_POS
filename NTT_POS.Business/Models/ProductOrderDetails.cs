using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class ProductOrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int ProductOrderId { get; set; }
        public int ProductId { get; set; }
        public Models.Products Product { get; set; }
        public double OrderQuantity { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double? FinalUnitCost { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
