using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class LoginAttempt
    {
        public static List<Models.LoginAttempt> ToModelList(List<Data.LoginAttempt> attempts) {
            var attemptModelList = new List<Models.LoginAttempt>();

            attemptModelList = attempts.Select(attempt => new Models.LoginAttempt {
               LoginAttemptId = attempt.LoginAttemptId,
               UserId = attempt.UserId,
               CreationDate = attempt.CreationDate,
               UnitName = attempt.UnitName,
               MachineName = attempt.MachineName,
            }).ToList();

            return attemptModelList;
        }

        public static int GetAllAttemptsOnUnit(string unitName,int userId) {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName)) {
                var attemptsCount = db.Fetch<Data.LoginAttempt>("Where UnitName = @0 AND userId=@1 AND EndDate IS NULL",unitName,userId);
                if (attemptsCount == null) return 0;
                
                return attemptsCount.Count();
            }
        }
        public static List<Models.LoginAttempt> GetAllAttempts(int userId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var attemptsCount = db.Fetch<Data.LoginAttempt>("Where userId=@0 AND EndDate IS NULL", userId);
                if (attemptsCount == null) return null;

                return ToModelList(attemptsCount);
            }
        }
        public static bool ClearAttemptsOnUnit(string unitName,int userId) {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var attempts = db.Update<Data.LoginAttempt>("SET EndDate = @0 Where UnitName = @1 AND UserId = @2 AND EndDate IS NULL", DateTime.Now, unitName, userId);
                    return true;
                }
            }
            catch {
                return false;
            }
        }
        public static bool ClearAllLoginAttempt(int userId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var attempts = db.Update<Data.LoginAttempt>("SET EndDate = @0 Where UserId = @1 AND EndDate IS NULL", DateTime.Now, userId);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public static bool AddNewLoginAttempt(Models.LoginAttempt attempt) 
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbAttempt = new Data.LoginAttempt()
                    {
                        CreationDate = DateTime.Now,
                        UserId = attempt.UserId,
                        UnitName = attempt.UnitName,
                        MachineName = attempt.MachineName,
                    };
                    db.Save(dbAttempt);
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
