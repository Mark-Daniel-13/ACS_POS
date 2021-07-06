using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class PriceHistory
    {
        public int PriceHistoryId { get; set; }
        public int ProductId { get; set; }
        public int PriceId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
