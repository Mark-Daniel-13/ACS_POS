using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class TransactionDetails
    {
        public int TransactionDetailId { get; set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public Models.Products Product { get; set; }
        public List<Models.Returns> Returns { get; set; }
        public double Quantity { get; set; }
        public double TotalPrice { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
