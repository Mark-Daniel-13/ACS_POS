using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class LoginHistory
    {
        public static Models.LoginHistory ToModel(Data.LoginHistory loginHistory)
        {
            return new Models.LoginHistory()
            {
                LoginHistoryId = loginHistory.LoginHistoryId,
                UserId = loginHistory.UserId,
                IsLoggedOut = loginHistory.IsLoggedOut,
                CreationDate = loginHistory.CreationDate,
                UnitName = loginHistory.UnitName,
                MachineName = loginHistory.MachineName,
            };
        }
        public static List<Models.LoginHistory> ToModelList(List<Data.LoginHistory> loginHistory,List<Models.Users> users)
        {
            var historyList = new List<Models.LoginHistory>();
            historyList = loginHistory.Select(history => new Models.LoginHistory
            {
                LoginHistoryId = history.LoginHistoryId,
                UserId = history.UserId,
                RoleId = (int)users.Where(u=>u.UserId == history.UserId).FirstOrDefault().Role,
                IsLoggedOut = history.IsLoggedOut,
                CreationDate = history.CreationDate,
                EndDate = history.EndDate,
                UnitName = history.UnitName,
                MachineName = history.MachineName,

            }).ToList();
            return historyList;
        }

        public static Models.LoginHistory GetLastLoginHistory()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                //Get unitName
                var unitName = "";
                if (Helpers.NetworkConnection.GetLANMACAddress() != null)
                {
                    unitName = Helpers.NetworkConnection.GetLANMACAddress();
                }
                else if (Helpers.NetworkConnection.GetWifiMACAddress() != null)
                {
                    unitName = Helpers.NetworkConnection.GetWifiMACAddress();
                }

                var dbLoginHistory = db.FirstOrDefault<Data.LoginHistory>("SELECT TOP 1 * FROM LoginHistory Where UnitName = @0 AND EndDate IS NULL ORDER BY CreationDate DESC",unitName);
                if (dbLoginHistory == null) { return null; }

                return ToModel(dbLoginHistory);
            }
        }

        public static List<Models.LoginHistory> GetHistoryOnRange(DateTime startDate, DateTime endDate)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                // History
                var dbHistories = db.Fetch<Data.LoginHistory>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND EndDate IS NOT NULL", string.Format("{0} 12:00 AM" ,startDate.ToString("MM/dd/yyyy")), string.Format("{0} 11:59 PM", endDate.ToString("MM/dd/yyyy")));
                if (dbHistories == null) return null;
                if (dbHistories.Count == 0) return null;

                var users = Business.Facades.Users.GetAll();
                return ToModelList(dbHistories, users);
            }
        }

        public static Models.LoginHistory GetLastLoginHistoryById(int loginHistoryId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbLoginHistory = db.FirstOrDefault<Data.LoginHistory>("SELECT TOP 1 * FROM LoginHistory WHERE LoginHistoryId = @0 ORDER BY CreationDate DESC", loginHistoryId);
                if (dbLoginHistory == null) { return null; }

                return ToModel(dbLoginHistory);
            }
        }
        public static Models.LoginHistory haveOtherLogIns(int userId,string unitName)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbLoginHistory = db.FirstOrDefault<Data.LoginHistory>("SELECT * FROM LoginHistory WHERE UserId = @0 AND IsLoggedOut = @1 AND UnitName != @2", userId,0,unitName);
                if (dbLoginHistory == null) { return null; }

                return ToModel(dbLoginHistory);
            }
        }

        public static int AddLoginHistory(Models.LoginHistory loginHistory)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbLoginHistory = new Data.LoginHistory()
                    {
                        LoginHistoryId = loginHistory.LoginHistoryId,
                        UserId = loginHistory.UserId,
                        IsLoggedOut = loginHistory.IsLoggedOut,
                        UnitName = loginHistory.UnitName,
                        CreationDate = DateTime.Now,
                        MachineName = loginHistory.MachineName,
                    };
                    db.Save(dbLoginHistory);
                    return dbLoginHistory.LoginHistoryId;
                }
            }
            catch
            {
                return 0;
            }
        }

        public static bool UpdateLoginHistory(int loginHistoryId, bool isLoggedOut)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbLoginHistory = db.FirstOrDefault<Data.LoginHistory>("WHERE LoginHistoryId = @0", loginHistoryId);
                    if (dbLoginHistory == null) { return false; }

                    dbLoginHistory.IsLoggedOut = isLoggedOut;
                    if (isLoggedOut) {
                        dbLoginHistory.EndDate = DateTime.Now;
                    }
                    db.Update(dbLoginHistory);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static TimeSpan? GetRenderedHours(int loginId) {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbLoginHistory = db.FirstOrDefault<Data.LoginHistory>("WHERE LoginHistoryId = @0", loginId);
                    if (dbLoginHistory == null) { return null; }

                    return dbLoginHistory.EndDate - dbLoginHistory.CreationDate;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
