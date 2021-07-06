using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class SalesSummary
    {
        public Products Product { get; set; }
        public Inventories Inventory { get; set; }
        public List<TransactionDetails> TransactionDetails { get; set; }
    }
}
