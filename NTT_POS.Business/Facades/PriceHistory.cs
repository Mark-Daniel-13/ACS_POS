using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class PriceHistory
    {
        public static Models.PriceHistory ToModel(Data.PriceHistory priceHistory)
        {
            return new Models.PriceHistory()
            {
                PriceHistoryId = priceHistory.PriceHistoryId,
                ProductId = priceHistory.ProductId,
                PriceId = priceHistory.PriceId,
                CreationDate = priceHistory.CreationDate,
            };
        }

        public static List<Models.PriceHistory> ToModelList(List<Data.PriceHistory> priceHistories)
        {
            var priceList = new List<Models.PriceHistory>();
            priceList = priceHistories.Select(price => new Models.PriceHistory
            {
                PriceHistoryId = price.PriceHistoryId,
                ProductId = price.ProductId,
                PriceId = price.PriceId,
                CreationDate = price.CreationDate,
            }).ToList();

            return priceList;
        }

        public static bool AddPriceToHistory(Models.PriceHistory history)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbPriceHistory = new Data.PriceHistory()
                    {
                        ProductId = history.ProductId,
                        PriceId = history.PriceId,
                        CreationDate = DateTime.Now,

                    };
                    db.Save(dbPriceHistory);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static Models.PriceHistory GetLastPrice(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbPrice = db.FirstOrDefault<Data.PriceHistory>("WHERE ProductId=@0 ORDER BY PriceHistoryId Desc ", productId);
                if (dbPrice == null) return null;

                return ToModel(dbPrice);
            }
        }


    }
}
