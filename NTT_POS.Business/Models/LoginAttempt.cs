using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class LoginAttempt
    {
        public int LoginAttemptId { get; set; }
        public int UserId { get; set; }
        public string UnitName { get; set; }
        public string MachineName { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
