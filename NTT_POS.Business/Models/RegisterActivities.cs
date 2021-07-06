using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class RegisterActivities
    {
        public int RegisterActivityId { get; set; }
        public int UserId { get; set; }
        public int LoginHistoryId { get; set; }
        public Enums.RegisterActivityTypes RegisterActivityTypeId { get; set; }
        public int DenominationId { get; set; }
        public Models.Denominations Denomination { get; set; }
        public double TotalAmount { get; set; }
        public Guid RegisterGUID { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
