using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class Denominations
    {
        public static Models.Denominations ToModel(Data.Denomination denomination)
        {
            return new Models.Denominations()
            {
                DenominationId = denomination.DenominationId,
                Value = denomination.Value,
                Description = denomination.Description,
                CreationDate = denomination.CreationDate,
                ModificationDate = denomination.ModificationDate,
                EndDate = denomination.EndDate
            };
        }

        public static List<Models.Denominations> ToModelList(List<Data.Denomination> denominations)
        {
            var denominationList = new List<Models.Denominations>();
            denominationList = denominations.Select(denomination => new Models.Denominations()
            {
                DenominationId = denomination.DenominationId,
                Value = denomination.Value,
                Description = denomination.Description,
                CreationDate = denomination.CreationDate,
                ModificationDate = denomination.ModificationDate,
                EndDate = denomination.EndDate
            }).ToList();

            return denominationList;
        }

        public static bool AddDenomination(Models.Denominations denomination)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbDenomination = new Data.Denomination()
                    {
                        DenominationId = denomination.DenominationId,
                        Value = denomination.Value,
                        Description = denomination.Description
                    };
                    db.Save(dbDenomination);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsExists(double value)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbDenomination = db.FirstOrDefault<Data.Denomination>("WHERE Value = @0 AND EndDate IS NULL", value);
                if (dbDenomination == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static List<Models.Denominations> GetAll()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbDenomination = db.Fetch<Data.Denomination>("WHERE EndDate IS NULL ORDER BY Value DESC");
                if (dbDenomination == null) { return null; }

                return ToModelList(dbDenomination);
            }
        }
    }
}
