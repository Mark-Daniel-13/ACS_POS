using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class ProductOrder
    {
        public int ProductOrderId { get; set; }
        public int SupplierId { get; set; }
        public Models.Supplier Supplier { get; set; }
        public List<Models.ProductOrderDetails> OrderDetails { get; set; }
        public Business.Enums.OrderStatus OrderStatusId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
