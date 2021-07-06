using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class Security
    {
        public int SecurityId { get; set; }
        public string SecurityToken { get; set; }
        public string UnitAddress { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime LastOpen { get; set; }
        public string KeyValue { get; set; }//nkK2zea$s5 = nkeass 
        public bool Activate { get; set; }
    }
}
