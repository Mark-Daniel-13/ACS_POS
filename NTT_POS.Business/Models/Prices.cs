using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class Prices
    {
        public int PriceId { get; set; }
        public double? RetailPrice { get; set; }
        public double? WholesalePrice { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
