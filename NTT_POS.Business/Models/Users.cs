using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Enums.Roles Role { get; set; }
        public int AddedBy { get; set; }
        public bool Disabled { get; set; }
        public string TempPassword { get; set; }
        public Models.Users AddedByUser { get; set; }
    }
}
