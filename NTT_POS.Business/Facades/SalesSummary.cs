using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class SalesSummary
    {
        public static List<Models.SalesSummary> ToModelList(List<Models.Products> products, List<Models.TransactionDetails> transactionDetails, List<Models.Inventories> inventories)
        {
            var salesList = new List<Models.SalesSummary>();
            salesList = products.Select(product => new Models.SalesSummary()
            {
                Product = product,
                Inventory = inventories.FirstOrDefault(i => i.ProductId == product.ProductId),
                TransactionDetails = transactionDetails.Where(td => td.ProductId == product.ProductId).ToList()
            }).ToList();

            return salesList;
        }

        public static List<Models.SalesSummary> GetAllSalesByDate(DateTime startDate, DateTime endDate)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var products = Facades.Products.GetAll();
                if (products == null) return null;
                if (products.Count() == 0) return null;
                var tdQuery = string.Format("SELECT * FROM TransactionDetails td INNER JOIN Products p ON td.ProductID = p.ProductId AND td.CreationDate >= '{0}' AND td.CreationDate <= '{1}'", string.Format("{0} 12:00 AM", startDate.ToString("MM/dd/yyyy")), string.Format("{0} 11:59 PM", endDate.ToString("MM/dd/yyyy")));

                var dbTransactionDetails = db.Fetch<Data.TransactionDetail>(tdQuery);
                var transactionDetails = Facades.TransactionDetails.ToModelList(dbTransactionDetails);

                var iQuery = string.Format("Select * FROM Inventories i INNER JOIN Products p ON i.ProductId=p.ProductId And i.EndDate Is NULL");
                var dbInventories = db.Fetch<Data.Inventory>(iQuery);
                var inventories = Facades.Inventories.ToModelList(dbInventories);

                return ToModelList(products, transactionDetails, inventories);
            }
        }
    }
}
