using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class Prices
    {
        public static Models.Prices ToModel(Data.Price price)
        {
            return new Models.Prices()
            {
                PriceId = price.PriceId,
                RetailPrice = price.RetailPrice,
                WholesalePrice = price.WholesalePrice,
                CreationDate = price.CreationDate,
                EndDate = price.EndDate

            };
        }

        public static List<Models.Prices> ToModelList(List<Data.Price> prices)
        {
            var priceList = new List<Models.Prices>();

            priceList = prices.Select(price => new Models.Prices()
            {
                PriceId = price.PriceId,
                RetailPrice = price.RetailPrice,
                WholesalePrice = price.WholesalePrice,
                CreationDate = price.CreationDate,
                EndDate = price.EndDate
            }).ToList();

            return priceList;
        }

        public static List<Models.Prices> GetAll()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var prices = db.Fetch<Data.Price>("");
                if (prices == null) return null;
                if (prices.Count == 0) return null;


                return ToModelList(prices);
            }
        }


        public static Models.Prices GetByPriceId(int priceId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var price = db.FirstOrDefault<Data.Price>("WHERE PriceId = @0", priceId);
                if (price == null) return null;

                return ToModel(price);
            }
        }

        public static List<Models.Prices> GetByPriceIdList(List<int> priceIdList)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbPrices = db.Fetch<Data.Price>("WHERE PriceId IN (@0)", priceIdList);
                if (dbPrices == null) return null;
                if (dbPrices.Count == 0) return null;

                return ToModelList(dbPrices);
            }
        }


        public static bool AddPrice(Models.Prices price)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbPrice = new Data.Price()
                    {
                        RetailPrice = price.RetailPrice,
                        WholesalePrice = price.WholesalePrice,
                        CreationDate = DateTime.Now
                        
                    };
                    db.Save(dbPrice);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool DeletePrice(int priceId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbPrice = db.FirstOrDefault<Data.Price>("WHERE PriceId = @0", priceId);
                    var product = Business.Facades.Products.GetByPriceId(dbPrice.PriceId);

                    var historyModel = new Business.Models.PriceHistory()
                    {
                        PriceId = dbPrice.PriceId,
                        ProductId = product.ProductId,
                    };
                    var insertToHistory = PriceHistory.AddPriceToHistory(historyModel);

                    dbPrice.EndDate = DateTime.Now;
                    db.Update(dbPrice);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool IsSame(Models.Prices price)
        {
            var priceModel = GetByPriceId(price.PriceId);

            if (priceModel.RetailPrice != price.RetailPrice)
            {
                return false;
            }

            if (priceModel.WholesalePrice != price.WholesalePrice)
            {
                return false;
            }

            return true;
        }
    }
}
