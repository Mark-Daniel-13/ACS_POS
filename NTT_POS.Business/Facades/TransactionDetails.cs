using NTT_POS.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class TransactionDetails
    {
        public static Models.TransactionDetails ToModel(Data.TransactionDetail transactionDetail, Models.Products product)
        {
            return new Models.TransactionDetails()
            {
                TransactionDetailId = transactionDetail.TransactionDetailId,
                TransactionId = transactionDetail.TransactionId,
                ProductId = transactionDetail.ProductId,
                Product = product,
                Quantity = transactionDetail.Quantity,
                TotalPrice = transactionDetail.TotalPrice,
                CreationDate = transactionDetail.CreationDate
            };
        }

        public static List<Models.TransactionDetails> ToModelList(List<Data.TransactionDetail> transactionDetails)
        {
            var transactionDetailList = new List<Models.TransactionDetails>();
            transactionDetailList = transactionDetails.Select(transactionDetail => new Models.TransactionDetails()
            {
                TransactionDetailId = transactionDetail.TransactionDetailId,
                TransactionId = transactionDetail.TransactionId,
                ProductId = transactionDetail.ProductId,
                Quantity = transactionDetail.Quantity,
                TotalPrice = transactionDetail.TotalPrice,
                CreationDate = transactionDetail.CreationDate
            }).ToList();

            return transactionDetailList;
        }

        public static List<Models.TransactionDetails> ToModelList(List<Data.TransactionDetail> transactionDetails, List<Models.Products> products)
        {
            var transactionDetailList = new List<Models.TransactionDetails>();
            transactionDetailList = transactionDetails.Select(transactionDetail => new Models.TransactionDetails()
            {
                TransactionDetailId = transactionDetail.TransactionDetailId,
                TransactionId = transactionDetail.TransactionId,
                ProductId = transactionDetail.ProductId,
                Product = products.Where(w => w.ProductId == transactionDetail.ProductId).FirstOrDefault(),
                Quantity = transactionDetail.Quantity,
                TotalPrice = transactionDetail.TotalPrice,
                CreationDate = transactionDetail.CreationDate

            }).ToList();

            return transactionDetailList;
        }

        public static List<Models.TransactionDetails> ToModelList(List<Data.TransactionDetail> transactionDetails, List<Models.Products> products, List<Models.Returns> returns)
        {
            var transactionDetailList = new List<Models.TransactionDetails>();
            transactionDetailList = transactionDetails.Select(transactionDetail => new Models.TransactionDetails()
            {
                TransactionDetailId = transactionDetail.TransactionDetailId,
                TransactionId = transactionDetail.TransactionId,
                ProductId = transactionDetail.ProductId,
                Product = products.Where(w => w.ProductId == transactionDetail.ProductId).FirstOrDefault(),
                Returns = returns.Where(r => r.TransactionDetailId == transactionDetail.TransactionDetailId).ToList(),
                Quantity = transactionDetail.Quantity,
                TotalPrice = transactionDetail.TotalPrice,
                CreationDate = transactionDetail.CreationDate
            }).ToList();

            return transactionDetailList;
        }

        public static List<Models.TransactionDetails> GetByReceiptNumber(string receiptNumber)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransaction = db.FirstOrDefault<Data.Transaction>("WHERE ReceiptNumber = @0 AND EndDate IS NULL", receiptNumber.Trim());
                if (dbTransaction == null) return null;

                var dbTransactionDetails = db.Fetch<Data.TransactionDetail>("WHERE TransactionId = @0", dbTransaction.TransactionId);
                if (dbTransactionDetails == null) return null;
                if (dbTransactionDetails.Count == 0) return null;

                var dbProducts = db.Fetch<Data.Product>("WHERE ProductId IN (@0)", dbTransactionDetails.Select(s => s.ProductId));
                var products = Business.Facades.Products.ToModelList(dbProducts);

                var dbReturns = db.Fetch<Data.Return>("WHERE TransactionDetailId IN (@0)", dbTransactionDetails.Select(s => s.TransactionDetailId));
                var returns = Business.Facades.Returns.ToModelList(dbReturns);

                return ToModelList(dbTransactionDetails, products, returns);
            }
        }

        public static Models.TransactionDetails GetByTransactionId(int transactionId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransactionDetail = db.FirstOrDefault<Data.TransactionDetail>("WHERE TransactionId = @0", transactionId);
                if (dbTransactionDetail == null) return null;

                var product = Business.Facades.Products.GetByProductId(dbTransactionDetail.ProductId);
                return ToModel(dbTransactionDetail, product);
            }
        }
        public static string GetReceiptByTransactionDetailId(int transactionDetailId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbtransactionDetail = db.FirstOrDefault<Data.TransactionDetail>("WHERE TransactionDetailId = @0", transactionDetailId);
                if (dbtransactionDetail == null) return null;
                var dbtransaction = db.FirstOrDefault<Data.Transaction>("Where TransactionId = @0", dbtransactionDetail.TransactionId);

                return dbtransaction.ReceiptNumber;
            }
        }

        public static List<Models.TransactionDetails> GetAllByTransactionId(int transactionId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransactionDetail = db.Fetch<Data.TransactionDetail>("WHERE TransactionId = @0", transactionId);
                if (dbTransactionDetail == null) return null;

              
                var dbPrices = Prices.ToModelList(db.Fetch<Data.Price>(""));
                var dbProducts = Products.ToModelList(db.Fetch<Data.Product>(""), dbPrices);

                return ToModelList(dbTransactionDetail,dbProducts);
            }
        }
        public static List<Models.TransactionDetails> GetAllByTransactionIdGrouped(int transactionId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransactionDetail = db.Fetch<Data.TransactionDetail>("WHERE TransactionId = @0", transactionId);
                if (dbTransactionDetail == null) return null;


                var dbPrices = Prices.ToModelList(db.Fetch<Data.Price>(""));
                var dbProducts = Products.ToModelList(db.Fetch<Data.Product>(""), dbPrices);

                return ToModelList(dbTransactionDetail, dbProducts);
            }
        }

        public static Models.TransactionDetails GetByTransactionDetailId(int transactionDetailId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransactionDetail = db.FirstOrDefault<Data.TransactionDetail>("WHERE TransactionDetailId = @0", transactionDetailId);
                if (dbTransactionDetail == null) return null;

                var product = Business.Facades.Products.GetByProductId(dbTransactionDetail.ProductId);
                return ToModel(dbTransactionDetail, product);
            }
        }
        public static double GetTotalSoldItemByTransactionDetail(Models.TransactionDetails transDetails)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var totalQuantity = 0.00;
                var dbTransactionDetail = db.Fetch<Data.TransactionDetail>("WHERE TransactionId = @0 AND ProductId = @1", transDetails.TransactionId,transDetails.ProductId);
                if (dbTransactionDetail == null) return totalQuantity;

                dbTransactionDetail.ForEach(detail=> {
                    totalQuantity += detail.Quantity;
                });
                return totalQuantity;
            }
        }
        public static bool RemoveTransactionDetailById(int transactionId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransactionDetail = db.Delete<Data.TransactionDetail>("WHERE TransactionId = @0", transactionId);
                if (dbTransactionDetail==1)
                { return true; }
                else
                { return false; }
            }
        }
        public static List<Models.TransactionDetails> GetSalesByDate(DateTime date)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var onlyDate = date.ToString("MM/dd/yyyy"); //11/25/2020 12:00:00:AM
                var addStartTime = string.Format("{0} 00:00:00 AM", onlyDate);
                var addEndTime = string.Format("{0} 11:59:59 PM", onlyDate);

                //var dbTransaction = db.Fetch<Data.TransactionDetail>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND EndDate IS NULL", addStartTime, addEndTime);
                //if (dbTransaction == null) return null;

                var sql = PetaPoco.Sql.Builder.Select("td.ProductId, " +
                                                        "SUM(td.Quantity) as Quantity, " +
                                                        "SUM(td.TotalPrice) as TotalPrice " 
                                                )
                                                .From("TransactionDetails td")
                                                .InnerJoin("Transactions t").On("td.TransactionId = t.TransactionId")
                                                .Where($"t.CreationDate >= '{addStartTime}' " +
                                                       $"AND t.CreationDate <= '{addEndTime}' AND t.EndDate IS NULL " 
                                                ).GroupBy("td.ProductId");
                var dbTransaction = db.Query<Models.TransactionDetails>(sql).ToList();
                
                return dbTransaction;
            }
        }
        public static int GetNumberOfSalesByDate(DateTime date)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var onlyDate = date.ToString("MM/dd/yyyy"); //11/25/2020 12:00:00:AM
                //DateTime addStartTime = DateTime.Parse(string.Format("{0} 00:00:00 AM", onlyDate), CultureInfo.InvariantCulture);
                //DateTime addEndTime = DateTime.Parse(string.Format("{0} 11:59:59 PM", onlyDate), CultureInfo.InvariantCulture);
                var addStartTime = DateTime.ParseExact(string.Format("{0} 00:00:00 AM", onlyDate),"MM/dd/yyyy hh:mm:ss tt",null);
                var addEndTime = DateTime.ParseExact(string.Format("{0} 11:59:59 PM", onlyDate), "MM/dd/yyyy hh:mm:ss tt",null);

                //var sql = PetaPoco.Sql.Builder.Select("SUM(t.Quantity) as Quantity ")
                //                                .From("TransactionDetails td")
                //                                .InnerJoin("Transactions t").On("td.TransactionId = t.TransactionId")
                //                                .Where($"td.CreationDate >= '{addStartTime}' " +
                //                                       $"AND td.CreationDate <= '{addEndTime}' ");
                //var dbTransaction = db.Query<Models.TransactionDetails>(sql).ToList();
                //if (dbTransaction == null) return 0;

                //return Convert.ToInt32(dbTransaction.First().Quantity);
                var transactions =Transactions.GetTransactionsOnRange(addStartTime, addEndTime);
                if (transactions != null) {
                    var totalItems = 0;
                    transactions.ForEach(transaction => {
                        transaction.TransactionDetails.ForEach(detail =>
                        {
                            totalItems += Convert.ToInt32(detail.Quantity);
                        });
                    });
                    return totalItems;
                }
                return 0;

            }
        }
        public static int GetNumberOfSalesOnRange(DateTime startDate, DateTime endDate)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var startDateToString = startDate.ToString("MM/dd/yyyy hh:mm:ss tt");
                var endDateToString = endDate.ToString("MM/dd/yyyy hh:mm:ss tt");
                var sql = PetaPoco.Sql.Builder.Select("SUM(t.Quantity) as Quantity ")
                                                .From("TransactionDetails t")
                                                .Where($"t.CreationDate >= '{startDateToString}' " +
                                                       $"AND t.CreationDate <= '{endDateToString}' ");

                var dbTransaction = db.Query<Models.TransactionDetails>(sql).ToList();
                if (dbTransaction == null) return 0;

                return Convert.ToInt32(dbTransaction.First().Quantity);

            }
        }
        public static int GetNumberOfSalesOnTransaction(int transactionId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransaction = db.Fetch<Data.TransactionDetail>("WHERE TransactionId = @0", transactionId);
                if (dbTransaction == null) return 0;

                var quantity = 0;
                dbTransaction.ForEach(data =>
                {
                    quantity += Convert.ToInt32(data.Quantity);
                });

                return quantity;
            }
        }
    }
}
