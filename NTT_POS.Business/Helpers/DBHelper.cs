using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Helpers
{
    public class DBHelper
    {
        public static bool isDBConnected()
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    db.FirstOrDefault<Data.User>("");
                }
                return true;
            }
            catch {
                return false;
            }  
        }
    }
}
