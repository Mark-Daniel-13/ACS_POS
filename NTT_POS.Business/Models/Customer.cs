using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string EmailAdd { get; set; }
    }
}
