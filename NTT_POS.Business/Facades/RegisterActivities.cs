using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class RegisterActivities
    {
        public static Models.RegisterActivities ToModel(Data.RegisterActivity activity, Models.Denominations denomination)
        {
            return new Models.RegisterActivities()
            {
                RegisterActivityId = activity.RegisterActivityId,
                UserId = activity.UserId,
                LoginHistoryId = activity.LoginHistoryId,
                RegisterActivityTypeId = (Enums.RegisterActivityTypes)activity.RegisterActivityTypeId,
                DenominationId = activity.DenominationId,
                Denomination = denomination,
                TotalAmount = activity.TotalAmount,
                RegisterGUID = new Guid(activity.RegisterGUID),
                CreationDate = activity.CreationDate
            };
        }

        public static List<Models.RegisterActivities> ToModelList(List<Data.RegisterActivity> activities, List<Models.Denominations> denominations)
        {
            var activityList = new List<Models.RegisterActivities>();
            activityList = activities.Select(activity => new Models.RegisterActivities()
            {
                RegisterActivityId = activity.RegisterActivityId,
                UserId = activity.UserId,
                LoginHistoryId = activity.LoginHistoryId,
                RegisterActivityTypeId = (Enums.RegisterActivityTypes)activity.RegisterActivityTypeId,
                DenominationId = activity.DenominationId,
                Denomination = denominations.Where(w => w.DenominationId == activity.DenominationId).FirstOrDefault(),
                TotalAmount = activity.TotalAmount,
                RegisterGUID = new Guid(activity.RegisterGUID),
                CreationDate = activity.CreationDate
            }).ToList();

            return activityList;
        }

        public static bool AddRegisterActivity(Models.RegisterActivities activity)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbActivity = new Data.RegisterActivity()
                    {
                        UserId = activity.UserId,
                        LoginHistoryId = activity.LoginHistoryId,
                        RegisterActivityTypeId = (int)activity.RegisterActivityTypeId,
                        DenominationId = activity.DenominationId,
                        TotalAmount = activity.TotalAmount,
                        RegisterGUID = activity.RegisterGUID.ToString(),
                        CreationDate = DateTime.Now
                    };
                    db.Save(dbActivity);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static Models.RegisterActivities GetRegisterInByUser(int userId, int loginHistoryId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbRegisterActivity = db.FirstOrDefault<Data.RegisterActivity>("WHERE UserId = @0 AND LoginHistoryId = @1 AND RegisterActivityTypeId = @2", userId, loginHistoryId, (int)Business.Enums.RegisterActivityTypes.RegisterIn);
                if (dbRegisterActivity == null) return null;

                return ToModel(dbRegisterActivity, null);
            }
        }
        public static List<Models.RegisterActivities> GetCashSweep(int userId, int loginHistoryId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbRegisterActivity = db.Fetch<Data.RegisterActivity>("WHERE UserId = @0 AND LoginHistoryId = @1 AND RegisterActivityTypeId = @2", userId, loginHistoryId, (int)Business.Enums.RegisterActivityTypes.CashSweep);
                if (dbRegisterActivity == null) return null;

                var denomination = Business.Facades.Denominations.GetAll();
                return ToModelList(dbRegisterActivity, denomination);
            }
        }

        public static List<Models.RegisterActivities> GetAllByUser(int userId, int loginHistoryId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbRegisterActivities = db.Fetch<Data.RegisterActivity>("WHERE UserId = @0 AND LoginHistoryId = @1", userId, loginHistoryId);
                if (dbRegisterActivities == null) return null;
                if (dbRegisterActivities.Count == 0) return null;

                var denominations = Business.Facades.Denominations.GetAll();

                return ToModelList(dbRegisterActivities, denominations);
            }
        }
    }
}
