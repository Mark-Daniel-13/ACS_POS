using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class Security
    {
        public static List<Models.Security> ToModelList(List<Data.Security> security)
        {
            var securityList = new List<Models.Security>();
            securityList = security.Select(sec => new Models.Security
            {
                SecurityId = sec.SecurityId,
                SecurityToken = sec.SecurityToken,
                UnitAddress = sec.UnitAddress,
                CreationDate = sec.CreationDate,
                EndDate = sec.EndDate,
                ExpirationDate = sec.ExpirationDate,
                LastOpen = sec.LastOpen,
                KeyValue = sec.KeyValue,
                Activate = sec.Activate,
            }).ToList();

            return securityList;
        }

        public static Models.Security ToModel(Data.Security security)
        {
            return new Models.Security
            {
                SecurityId = security.SecurityId,
                SecurityToken = security.SecurityToken,
                UnitAddress = security.UnitAddress,
                CreationDate = security.CreationDate,
                ExpirationDate = security.ExpirationDate,
                EndDate = security.EndDate,
                LastOpen = security.LastOpen,
                KeyValue = security.KeyValue,
                Activate = security.Activate,
            };
        }
        private static string GetHashedToken(Models.Security security)
        {
            var token = string.Format("Th3{0}G0d{1}0f{2}tH3{3}s3@{4}N+T{5}iNc.", security.CreationDate, security.UnitAddress, security.KeyValue, security.ExpirationDate, security.LastOpen, security.Activate);

            return Helpers.Encryption.EncryptMD5(token);
        }
        public static Models.Security GetUnitData(string UnitName)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var unit = db.FirstOrDefault<Data.Security>("Where UnitAddress = @0 AND EndDate IS NULL", UnitName);
                if (unit == null) return null;
                return ToModel(unit);
            }
        }
        public static string GetRemainingDays(string UnitName)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var unit = db.FirstOrDefault<Data.Security>("Where UnitAddress = @0 AND EndDate IS NULL", UnitName);
                if (unit == null) return null;

                return Math.Round((unit.ExpirationDate - DateTime.Now).TotalDays).ToString();
            }
        }
        public static bool CheckKey(string UnitName,string key)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var unit = db.FirstOrDefault<Data.Security>("Where UnitAddress = @0 AND EndDate IS NULL", UnitName);
                if (unit == null) return false;

                return Helpers.Encryption.CheckMD5(key, unit.KeyValue);
            }
        }
        public static bool CheckTokenValidity(Models.Security security)
        {
            if (GetHashedToken(security) == security.SecurityToken)
            {
                return true;
            }
            return false;
        }
        public static bool UpdateLastLogin(string unitName) {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var unit = db.FirstOrDefault<Data.Security>("Where UnitAddress = @0 AND EndDate IS NULL", unitName);
                    if (unit == null) return false;
                    unit.LastOpen = DateTime.Now;
                    unit.SecurityToken = GetHashedToken(ToModel(unit));
                    db.Update(unit);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool ActivateUnit(string unitName)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {
                        var security = db.FirstOrDefault<Data.Security>("Where UnitAddress = @0 AND EndDate IS NULL", unitName);
                        if (security == null) return false;
                        security.EndDate = DateTime.Now;
                        db.Update(security);

                        DateTime expirationDate = DateTime.Now.AddYears(1);

                        //modify model to update based on upgrading to premium
                        var dbUnit = new Data.Security()
                        {
                            CreationDate = DateTime.Now,
                            UnitAddress = security.UnitAddress,
                            KeyValue = security.KeyValue,
                            ExpirationDate = expirationDate,
                            LastOpen = DateTime.Now,
                            Activate = true,

                        };

                        dbUnit.SecurityToken = GetHashedToken(ToModel(dbUnit));
                        db.Save(dbUnit);

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
    }
}
