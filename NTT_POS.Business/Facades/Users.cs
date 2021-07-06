using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class Users
    {
        public static Models.Users ToModel(Data.User user, Data.UserRole userRole)
        {
            return new Models.Users()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = user.Password,
                CreationDate = user.CreationDate,
                ModificationDate = user.ModificationDate,
                EndDate = user.EndDate,
                Role = (Enums.Roles)userRole.RoleId,
                AddedBy = user.AddedBy,
                TempPassword = user.TempPassword,
                Disabled = user.Disabled,
                
            };
        }

        public static List<Models.Users> ToModelList(List<Data.User> users, List<Data.UserRole> userRoles)
        {
            var userList = new List<Models.Users>();
            userList = users.Select(user => new Models.Users()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = user.Password,
                CreationDate = user.CreationDate,
                ModificationDate = user.ModificationDate,
                EndDate = user.EndDate,
                Role = userRoles.Where(u => u.UserId == user.UserId).Select(r => (Enums.Roles)r.RoleId).FirstOrDefault(),
                AddedBy = user.AddedBy,
                 TempPassword = user.TempPassword,
                Disabled = user.Disabled,
            }).ToList();

            return userList;
        }

        public static Models.Users ToModel(Data.User user, Data.UserRole userRole, List<Models.Users> userModels)
        {
            return new Models.Users()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = user.Password,
                CreationDate = user.CreationDate,
                ModificationDate = user.ModificationDate,
                EndDate = user.EndDate,
                Role = (Enums.Roles)userRole.RoleId,
                AddedBy = user.AddedBy,
                AddedByUser = userModels.FirstOrDefault(f => f.UserId == user.AddedBy),
                TempPassword = user.TempPassword,
                Disabled = user.Disabled,
            };
        }

        public static List<Models.Users> ToModelList(List<Data.User> users, List<Data.UserRole> userRoles, List<Models.Users> userModels)
        {
            var userList = new List<Models.Users>();
            userList = users.Select(user => new Models.Users()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = user.Password,
                CreationDate = user.CreationDate,
                ModificationDate = user.ModificationDate,
                EndDate = user.EndDate,
                Role = userRoles.Where(u => u.UserId == user.UserId).Select(r => (Enums.Roles)r.RoleId).FirstOrDefault(),
                AddedBy = user.AddedBy,
                AddedByUser = userModels.FirstOrDefault(f => f.UserId == user.AddedBy),
                TempPassword = user.TempPassword,
                Disabled = user.Disabled,
            }).ToList();

            return userList;
        }

        public static List<Models.Users> ToModelList(List<Data.User> users)
        {
            var userList = new List<Models.Users>();
            userList = users.Select(user => new Models.Users()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.Username,
                Password = user.Password,
                CreationDate = user.CreationDate,
                ModificationDate = user.ModificationDate,
                EndDate = user.EndDate,
                AddedBy = user.AddedBy,
                TempPassword = user.TempPassword,
                Disabled = user.Disabled,
            }).ToList();

            return userList;
        }

        public static List<Models.Users> GetAll()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbUsers = db.Fetch<Data.User>("WHERE EndDate IS NULL ORDER BY UserId Desc");
                if (dbUsers == null) return null;
                if (dbUsers.Count == 0) return null;

                var dbUserRoles = db.Fetch<Data.UserRole>("");

                var _dbUsers = db.Fetch<Data.User>("");
                var userModels = ToModelList(_dbUsers);

                return ToModelList(dbUsers, dbUserRoles, userModels);
            }
        }
        public static string GetUserFullName(int userId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbUser = db.FirstOrDefault<Data.User>("WHERE UserId = @0",userId);
                if (dbUser == null) return null;

                return string.Format("{0} {1}", dbUser.FirstName, dbUser.LastName);
            }
        }
        public static List<Models.Users> GetAllCashier()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbUsers = db.Fetch<Data.User>("WHERE EndDate IS NULL ORDER BY UserId Desc");
                if (dbUsers == null) return null;
                if (dbUsers.Count == 0) return null;

                var dbUserRoles = db.Fetch<Data.UserRole>("Where RoleId = @0",(int)Enums.Roles.Cashier).Join(dbUsers,
                                                                                                        role=>role.UserId,user=>user.UserId,
                                                                                                        (role,user)=>new Models.Users { 
                                                                                                            UserId = user.UserId,
                                                                                                            FirstName = user.FirstName,
                                                                                                            LastName = user.LastName,
                                                                                                            Username = user.Username,
                                                                                                        }).ToList();

                return dbUserRoles;
            }
        }

        public static Models.Users GetById(int userId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var user = db.FirstOrDefault<Data.User>("WHERE UserId = @0", userId);
                if (user == null) return null;

                var userRole = db.FirstOrDefault<Data.UserRole>("WHERE UserId = @0", user.UserId);

                return ToModel(user, userRole);
            }
        }

        public static Models.Users CheckUsernameExist(string userName,int? userId = null)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var user = userId == null ? db.FirstOrDefault<Data.User>("WHERE Username = @0 AND EndDate IS NULL", userName) : db.FirstOrDefault<Data.User>("Where Username = @0 AND EndDate IS NULL AND UserId !=@1",userName,userId);
                if (user == null) return null;

                var userRole = db.FirstOrDefault<Data.UserRole>("WHERE UserId = @0", user.UserId);
                return ToModel(user,userRole);
            }
        }

        public static Models.Users GetByUsernamePassword(string userName, string password,bool isTempPass = false)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var user = new Data.User();
                if (isTempPass)
                {
                    user = db.FirstOrDefault<Data.User>("WHERE Username = @0 AND TempPassword = @1 AND EndDate IS NULL", userName, password);
                }
                else
                {
                   password = Helpers.Encryption.EncryptMD5(password);
                   user = db.FirstOrDefault<Data.User>("WHERE Username = @0 AND Password = @1 AND EndDate IS NULL", userName, password);
                }
                if (user == null) return null;

                var userRole = db.FirstOrDefault<Data.UserRole>("WHERE UserId = @0", user.UserId);

                return ToModel(user, userRole);
            }
        }
        public static bool CheckUserTempPassword(string tempPW,int userId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var user = db.FirstOrDefault<Data.User>("WHERE userId = @0", userId);
                if (user == null) return false;

                if (user.TempPassword == tempPW) {
                    return true;
                }
                return false;
            }
        }
        public static List<Models.Users> Search(string searchString)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbUsers = db.Fetch<Data.User>("WHERE (FirstName LIKE @0 OR LastName LIKE @0 OR Username LIKE @0) AND EndDate IS NULL ORDER BY UserId Desc", "%"+searchString+"%");
                if (dbUsers == null) return null;
                if (dbUsers.Count == 0) return null;

                var dbUserRoles = db.Fetch<Data.UserRole>("");
                var _dbUsers = db.Fetch<Data.User>("");
                var userModels = ToModelList(_dbUsers);

                return ToModelList(dbUsers, dbUserRoles, userModels);
            }
        }

        public static bool AddUser(Models.Users user)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbUser = new Data.User()
                        {
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            Username = user.Username,
                            Password = Helpers.Encryption.EncryptMD5(user.Password),
                            CreationDate = DateTime.Now,
                            AddedBy = user.AddedBy,
                            Disabled = false, //initially the account is not disabled upon creation
                        };
                        db.Save(dbUser);

                        var dbUserRole = new Data.UserRole()
                        {

                            UserId = dbUser.UserId,
                            RoleId = (int)user.Role
                        };
                        db.Save(dbUserRole);

                        scope.Complete();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateUser(Models.Users user)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbUser = db.FirstOrDefault<Data.User>("WHERE UserId = @0 AND EndDate IS NULL", user.UserId);

                        dbUser.FirstName = user.FirstName;
                        dbUser.LastName = user.LastName;
                        dbUser.Username = user.Username;
                        if (!string.IsNullOrEmpty(user.Password))
                        {
                            dbUser.Password = Helpers.Encryption.EncryptMD5(user.Password);
                        }
                        dbUser.ModificationDate = DateTime.Now;
                        db.Update(dbUser);

                        var dbUserRole = db.FirstOrDefault<Data.UserRole>("WHERE UserId = @0", user.UserId);
                        dbUserRole.RoleId = (int)user.Role;
                        db.Update(dbUserRole);

                        scope.Complete();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteUser(int userId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbUser = db.FirstOrDefault<Data.User>("WHERE UserId = @0", userId);
                    dbUser.EndDate = DateTime.Now;
                    db.Update(dbUser);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        private  static string GenerateRandomPassword() {
            var rand = new Random();
            return Helpers.RandomGenerator.GenerateRandomString(rand, 16);
        }
        public static bool LockUser(int userId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbUser = db.FirstOrDefault<Data.User>("WHERE UserId = @0", userId);
                    dbUser.Disabled = true;
                    dbUser.TempPassword = GenerateRandomPassword();
                    db.Update(dbUser);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ActivateUser(int userId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbUser = db.FirstOrDefault<Data.User>("WHERE UserId = @0", userId);
                    dbUser.Disabled = false;
                    db.Update(dbUser);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ResetUserPassword(int userId,string userPW)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbUser = db.FirstOrDefault<Data.User>("WHERE UserId = @0", userId);
                    dbUser.TempPassword = null;
                    dbUser.Password = Helpers.Encryption.EncryptMD5(userPW);
                    db.Update(dbUser);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
