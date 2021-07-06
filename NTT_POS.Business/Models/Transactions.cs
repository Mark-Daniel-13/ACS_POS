using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class Transactions
    {
        public int TransactionId { get; set; }
        public List<TransactionDetails> TransactionDetails { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
        public string ReceiptNumber { get; set; }
        public Enums.TransactionTypes TransactionTypeId { get; set; }
        public double? DiscountPercentage { get; set; }
        public double? DiscountAmount { get; set; }
        public double PaymentAmount { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? VoidedBy { get; set; }
        public Users VoidUser { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string WholesaleReason { get; set; }
        public bool isRetail { get; set; }
    }
}
