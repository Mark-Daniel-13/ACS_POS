using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class LoginHistory
    {
        public int LoginHistoryId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public bool IsLoggedOut { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string UnitName { get; set; }
        public string MachineName { get; set; }
    }
}
