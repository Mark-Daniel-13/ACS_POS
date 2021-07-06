using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class Returns
    {
        public int ReturnId { get; set; }
        public int TransactionDetailId { get; set; }
        public TransactionDetails TransactionDetail { get; set; }
        public double Quantity { get; set; }
        public double ReturnedAmount { get; set; }
        public string Reason { get; set; }
        public int UserId { get; set; }
        public int ReturnStatusId {get;set;}
        public DateTime CreationDate { get; set; }
    }
}
