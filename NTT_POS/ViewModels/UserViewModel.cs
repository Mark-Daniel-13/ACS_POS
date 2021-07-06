using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Business.Enums.Roles Role { get; set; }
        public int AddedBy { get; set; }
        public string AddedByUser { get; set; }

        public static UserViewModel ToViewModel(Business.Models.Users user)
        {
            var userVM = new UserViewModel();
            userVM.UserId = user.UserId;
            userVM.FirstName = user.FirstName;
            userVM.LastName = user.LastName;
            userVM.Username = user.Username;
            userVM.Password = user.Password;
            userVM.CreationDate = user.CreationDate;
            userVM.ModificationDate = user.ModificationDate;
            userVM.EndDate = user.EndDate;
            userVM.Role = user.Role;
            userVM.AddedBy = user.AddedBy;
            if (user.AddedByUser != null)
            {
                userVM.AddedByUser = string.Format("{0} {1}", user.AddedByUser.FirstName, user.AddedByUser.LastName);
            }

            return userVM;
        }

        public static List<UserViewModel> ToViewModelList(List<Business.Models.Users> users)
        {
            var userVMList = new List<UserViewModel>();
            users.ForEach(user =>
            {
                var userVM = new UserViewModel();
                userVM.UserId = user.UserId;
                userVM.FirstName = user.FirstName;
                userVM.LastName = user.LastName;
                userVM.Username = user.Username;
                userVM.Password = user.Password;
                userVM.CreationDate = user.CreationDate;
                userVM.ModificationDate = user.ModificationDate;
                userVM.EndDate = user.EndDate;
                userVM.Role = user.Role;
                userVM.AddedBy = user.AddedBy;
                if (user.AddedByUser != null)
                {
                    userVM.AddedByUser = string.Format("{0} {1}", user.AddedByUser.FirstName, user.AddedByUser.LastName);
                }

                userVMList.Add(userVM);
            });

            return userVMList;
        }
    }
}
