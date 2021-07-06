using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class CompanyBranchDetails
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string Address { get; set; }
        public string TinNo { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
