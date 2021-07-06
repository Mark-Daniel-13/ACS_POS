using NTT_POS.Business.Helpers;
using NTT_POS.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class Transactions
    {
        public static Models.Transactions ToModel(Data.Transaction transaction, List<Models.TransactionDetails> transactionDetails)
        {
            return new Models.Transactions()
            {
                TransactionId = transaction.TransactionId,
                TransactionDetails = transactionDetails,
                UserId = transaction.UserId,
                CustomerId = transaction.CustomerId,
                ReceiptNumber = transaction.ReceiptNumber,
                TransactionTypeId = (Enums.TransactionTypes)transaction.TransactionTypeId,
                DiscountPercentage = transaction.DiscountPercentage,
                DiscountAmount = transaction.DiscountAmount,
                PaymentAmount = transaction.PaymentAmount,
                CreationDate = transaction.CreationDate,
                EndDate = transaction.EndDate,
                WholesaleReason = transaction.WholesaleReason,
                isRetail = transaction.isRetail,
            };
        }

        public static Models.Transactions ToModel(Data.Transaction transaction)
        {
            return new Models.Transactions()
            {
                TransactionId = transaction.TransactionId,
                UserId = transaction.UserId,
                CustomerId = transaction.CustomerId,
                ReceiptNumber = transaction.ReceiptNumber,
                TransactionTypeId = (Enums.TransactionTypes)transaction.TransactionTypeId,
                DiscountPercentage = transaction.DiscountPercentage,
                DiscountAmount = transaction.DiscountAmount,
                PaymentAmount = transaction.PaymentAmount,
                CreationDate = transaction.CreationDate,
                EndDate = transaction.EndDate,
                WholesaleReason = transaction.WholesaleReason,
                isRetail = transaction.isRetail,
            };
        }

        public static List<Models.Transactions> ToModelList(List<Data.Transaction> transactions, List<Models.TransactionDetails> transactionDetails)
        {
            var transactionList = new List<Models.Transactions>();
            transactionList = transactions.Select(transaction => new Models.Transactions()
            {
                TransactionId = transaction.TransactionId,
                TransactionDetails = transactionDetails.Where(t => t.TransactionId == transaction.TransactionId).ToList(),
                UserId = transaction.UserId,
                CustomerId = transaction.CustomerId,
                ReceiptNumber = transaction.ReceiptNumber,
                TransactionTypeId = (Enums.TransactionTypes)transaction.TransactionTypeId,
                DiscountPercentage = transaction.DiscountPercentage,
                DiscountAmount = transaction.DiscountAmount,
                PaymentAmount = transaction.PaymentAmount,
                CreationDate = transaction.CreationDate,
                EndDate = transaction.EndDate,
                WholesaleReason = transaction.WholesaleReason,
                isRetail = transaction.isRetail,
            }).ToList();

            return transactionList;
        }

        public static List<Models.Transactions> ToModelList(List<Data.Transaction> transactions, List<Models.TransactionDetails> transactionDetails, List<Models.Users> users, List<Models.Users> voidUsers)
        {
            var transactionList = new List<Models.Transactions>();
            transactionList = transactions.Select(transaction => new Models.Transactions()
            {
                TransactionId = transaction.TransactionId,
                TransactionDetails = transactionDetails.Where(t => t.TransactionId == transaction.TransactionId).ToList(),
                UserId = transaction.UserId,
                CustomerId = transaction.CustomerId,
                User = users.Where(u => u.UserId == transaction.UserId).FirstOrDefault(),
                ReceiptNumber = transaction.ReceiptNumber,
                TransactionTypeId = (Enums.TransactionTypes)transaction.TransactionTypeId,
                DiscountPercentage = transaction.DiscountPercentage,
                DiscountAmount = transaction.DiscountAmount,
                PaymentAmount = transaction.PaymentAmount,
                CreationDate = transaction.CreationDate,
                EndDate = transaction.EndDate,
                VoidedBy = transaction.VoidedBy,
                VoidUser = voidUsers.Where(u => u.UserId == transaction.VoidedBy).FirstOrDefault(),
                WholesaleReason = transaction.WholesaleReason,
                isRetail = transaction.isRetail,
            }).ToList();

            return transactionList;
        }

        public static Models.Transactions GetLastTransaction()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransaction = db.FirstOrDefault<Data.Transaction>("SELECT TOP 1 * FROM Transactions WHERE TransactionTypeId != @0 ORDER BY TransactionId DESC",4);
                if (dbTransaction == null) return null;

                return ToModel(dbTransaction);
            }
        }

        public static Models.Transactions GetByReceiptNumber(string receiptNumber)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransaction = db.FirstOrDefault<Data.Transaction>("WHERE ReceiptNumber = @0 AND EndDate IS NULL", receiptNumber.Trim());
                if (dbTransaction == null) return null;

                return ToModel(dbTransaction);
            }
        }
       
        public static int GettNumberOfSalesPerTransactionByCashier(int cashierId, DateTime startDate, DateTime endDate)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransaction = db.Fetch<Data.Transaction>("WHERE UserId = @0 AND TransactionTypeId = @1 AND CreationDate >= @2 AND CreationDate <= @3 AND EndDate IS NULL", cashierId,(int)Enums.TransactionTypes.Sales, string.Format("{0} 12:00 AM", startDate.ToString("MM/dd/yyyy")), string.Format("{0} 11:59 PM", endDate.ToString("MM/dd/yyyy")));
                if (dbTransaction == null) return 0;

                var totalQuantity = 0;
                dbTransaction.ForEach(data =>
                {
                    totalQuantity += Business.Facades.TransactionDetails.GetNumberOfSalesOnTransaction(data.TransactionId);
                });

                return totalQuantity;
            }
        }
        //public static int GetNumberOfSalesByDate(DateTime date)
        //{
        //    using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
        //    {
        //        var onlyDate = date.ToString("MM/dd/yyyy"); //11/25/2020 12:00:00:AM
        //        DateTime addStartTime = DateTime.Parse(string.Format("{0} 00:00:00 AM",onlyDate),CultureInfo.InvariantCulture);
        //        DateTime addEndTime = DateTime.Parse(string.Format("{0} 11:59:59 PM",onlyDate), CultureInfo.InvariantCulture);

        //        var dbTransaction = db.Fetch<Data.Transaction>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND EndDate IS NULL", addStartTime, addEndTime);
        //        if (dbTransaction == null) return 0;

        //        return dbTransaction.Count();
        //    }
        //}
        public static Models.Transactions GetAllSalesLastSevenDays()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var lastSevenDays = Enumerable.Range(0, 7).Select(d => DateTime.Now.Date.AddDays(-d)).ToList();
                var dbTransaction = db.FirstOrDefault<Data.Transaction>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND EndDate IS NULL",lastSevenDays[6],lastSevenDays[0]);
                if (dbTransaction == null) return null;

                return ToModel(dbTransaction);
            }
        }
        public static List<Models.Transactions> GetTransactionsOnShift(int userId, DateTime shift)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTransactions = db.Fetch<Data.Transaction>("WHERE UserId = @0 AND CreationDate >= @1 AND EndDate IS NULL", userId, shift.ToString("MM/dd/yyyy hh:mm tt"));
                if (dbTransactions == null) return null;
                if (dbTransactions.Count == 0) return null;

                var dbTransactionDetails = db.Fetch<Data.TransactionDetail>("WHERE TransactionId IN (@0)", dbTransactions.Select(s => s.TransactionId));
                var transactionDetails = Business.Facades.TransactionDetails.ToModelList(dbTransactionDetails);

                return ToModelList(dbTransactions, transactionDetails);
            }
        }

        public static List<Models.Transactions> GetTransactionsOnRange(DateTime startDate, DateTime endDate,bool includeTime = false)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                string _startDate;
                string _endDate;
                if (includeTime)
                {
                     _startDate = startDate.ToString("MM/dd/yyyy hh:mm:ss:fff tt");
                     _endDate = endDate.ToString("MM/dd/yyyy hh:mm:ss:fff tt");
                }
                else
                {
                     _startDate = startDate.ToString("MM/dd/yyyy") + " 00:00:00";
                     _endDate = endDate.ToString("MM/dd/yyyy") + " 23:59:59";
                }
                // SALES Transactions
                var dbTransactions = db.Fetch<Data.Transaction>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND TransactionTypeId=@2 AND EndDate IS NULL", _startDate, _endDate, Enums.TransactionTypes.Sales);
                if (dbTransactions == null) return null;
                if (dbTransactions.Count == 0) return null;

                // User
                var dbUsers = db.Fetch<Data.User>("WHERE UserId IN (@0)", dbTransactions.Select(t => t.UserId));
                var users = Users.ToModelList(dbUsers);

                // Void User
                var voidUserIds = dbTransactions.Where(w => w.VoidedBy != null).Select(s => s.VoidedBy);
                var voidUsers = new List<Models.Users>();
                if (voidUserIds.Count() > 0)
                {
                    var dbVoidUsers = db.Fetch<Data.User>("WHERE UserId IN (@0)", voidUserIds);
                    voidUsers = Users.ToModelList(dbVoidUsers);
                }

                // Transaction Details
                var dbTransactionDetails = db.Fetch<Data.TransactionDetail>("WHERE TransactionId IN (@0)", dbTransactions.Select(s => s.TransactionId));

                // Products
                var dbProducts = db.Fetch<Data.Product>("WHERE ProductId IN (@0)", dbTransactionDetails.Select(s => s.ProductId));

                // Prices
                var prices = Facades.Prices.GetByPriceIdList(dbProducts.Select(s => s.PriceId).ToList());


                var products = Products.ToModelList(dbProducts, prices);
                var transactionDetails = Business.Facades.TransactionDetails.ToModelList(dbTransactionDetails, products);

                return ToModelList(dbTransactions, transactionDetails, users, voidUsers);
            }
        }
        public static int GetTransactionsOnRangeCount(string TransactionType, DateTime startDate, DateTime endDate, bool includeTime = false)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                if (TransactionType == "None") {
                    return 0;
                }
                string _startDate;
                string _endDate;
                if (includeTime)
                {
                    _startDate = startDate.ToString("MM/dd/yyyy hh:mm:ss:fff tt");
                    _endDate = endDate.ToString("MM/dd/yyyy hh:mm:ss:fff tt");
                }
                else
                {
                    _startDate = startDate.ToString("MM/dd/yyyy") + " 00:00:00";
                    _endDate = endDate.ToString("MM/dd/yyyy") + " 23:59:59";
                }
                // SALES Transactions
                List<Transaction> dbTransactions;
                if (TransactionType == "All" || TransactionType == null)
                {
                    dbTransactions = db.Fetch<Data.Transaction>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND TransactionTypeId=@2 AND EndDate IS NULL ORDER BY TransactionId Desc", _startDate, _endDate, Enums.TransactionTypes.Sales);
                }
                else if (TransactionType == "Retail")
                {
                    dbTransactions = db.Fetch<Data.Transaction>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND TransactionTypeId=@2 AND isRetail = @3 AND EndDate IS NULL ORDER BY TransactionId Desc", _startDate, _endDate, Enums.TransactionTypes.Sales, true);
                }
                else
                {
                    dbTransactions = db.Fetch<Data.Transaction>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND TransactionTypeId=@2 AND isRetail = @3 AND EndDate IS NULL ORDER BY TransactionId Desc", _startDate, _endDate, Enums.TransactionTypes.Sales, false);
                }

                if (dbTransactions == null) return 0;

                return dbTransactions.Count();
            }
        }
        public static List<Models.Transactions> GetTransactionsOnRange(string TransactionType,DateTime startDate, DateTime endDate, int itemPerPageCount, int currentPage, bool includeTime = false)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                if (TransactionType == "None")
                {
                    return null;
                }
                string _startDate;
                string _endDate;
                if (includeTime)
                {
                    _startDate = startDate.ToString("MM/dd/yyyy hh:mm:ss:fff tt");
                    _endDate = endDate.ToString("MM/dd/yyyy hh:mm:ss:fff tt");
                }
                else
                {
                    _startDate = startDate.ToString("MM/dd/yyyy") + " 00:00:00";
                    _endDate = endDate.ToString("MM/dd/yyyy") + " 23:59:59";
                }
                // SALES Transactions
                List<Transaction> dbTransactions;
                var offset = itemPerPageCount * (currentPage - 1);
                if (TransactionType == "All" || TransactionType == null)
                {
                    dbTransactions = db.Fetch<Data.Transaction>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND TransactionTypeId=@2 AND EndDate IS NULL ORDER BY TransactionId Desc OFFSET @3 ROWS FETCH NEXT @4 ROWS ONLY", _startDate, _endDate, Enums.TransactionTypes.Sales, offset, itemPerPageCount);
                }
                else if (TransactionType == "Retail") {
                    dbTransactions = db.Fetch<Data.Transaction>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND TransactionTypeId=@2 AND isRetail = @3 AND EndDate IS NULL ORDER BY TransactionId Desc OFFSET @4 ROWS FETCH NEXT @5 ROWS ONLY", _startDate, _endDate, Enums.TransactionTypes.Sales, true, offset, itemPerPageCount);
                }
                else {
                    dbTransactions = db.Fetch<Data.Transaction>("WHERE CreationDate >= @0 AND CreationDate <= @1 AND TransactionTypeId=@2 AND isRetail = @3 AND EndDate IS NULL ORDER BY TransactionId Desc OFFSET @4 ROWS FETCH NEXT @5 ROWS ONLY", _startDate, _endDate, Enums.TransactionTypes.Sales, false, offset, itemPerPageCount);
                }
                
                if (dbTransactions == null) return null;
                if (dbTransactions.Count == 0) return null;

                // User
                var dbUsers = db.Fetch<Data.User>("WHERE UserId IN (@0)", dbTransactions.Select(t => t.UserId));
                var users = Users.ToModelList(dbUsers);

                // Void User
                var voidUserIds = dbTransactions.Where(w => w.VoidedBy != null).Select(s => s.VoidedBy);
                var voidUsers = new List<Models.Users>();
                if (voidUserIds.Count() > 0)
                {
                    var dbVoidUsers = db.Fetch<Data.User>("WHERE UserId IN (@0)", voidUserIds);
                    voidUsers = Users.ToModelList(dbVoidUsers);
                }

                // Transaction Details
                var dbTransactionDetails = db.Fetch<Data.TransactionDetail>("WHERE TransactionId IN (@0)", dbTransactions.Select(s => s.TransactionId));

                // Products
                var dbProducts = db.Fetch<Data.Product>("WHERE ProductId IN (@0)", dbTransactionDetails.Select(s => s.ProductId));

                // Prices
                var prices = Facades.Prices.GetByPriceIdList(dbProducts.Select(s => s.PriceId).ToList());


                var products = Products.ToModelList(dbProducts, prices);
                var transactionDetails = Business.Facades.TransactionDetails.ToModelList(dbTransactionDetails, products);

                return ToModelList(dbTransactions, transactionDetails, users, voidUsers);
            }
        }

        public static List<Models.Transactions> GetVoidedTransactionsOnRage(DateTime startDate, DateTime endDate)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                // Transactions
                var dbTransactions = db.Fetch<Data.Transaction>("WHERE EndDate >= @0 AND EndDate <= @1 AND EndDate IS NOT NULL", string.Format("{0} 12:00 AM", startDate.ToString("MM/dd/yyyy")), string.Format("{0} 11:59 PM", endDate.ToString("MM/dd/yyyy")));
                if (dbTransactions == null) return null;
                if (dbTransactions.Count == 0) return null;

                // User
                var dbUsers = db.Fetch<Data.User>("WHERE UserId IN (@0)", dbTransactions.Select(t => t.UserId));
                var users = Users.ToModelList(dbUsers);

                // Void User
                var voidUserIds = dbTransactions.Where(w => w.VoidedBy != null).Select(s => s.VoidedBy);
                var voidUsers = new List<Models.Users>();
                if (voidUserIds.Count() > 0)
                {
                    var dbVoidUsers = db.Fetch<Data.User>("WHERE UserId IN (@0)", voidUserIds);
                    voidUsers = Users.ToModelList(dbVoidUsers);
                }

                // Transaction Details
                var dbTransactionDetails = db.Fetch<Data.TransactionDetail>("WHERE TransactionId IN (@0)", dbTransactions.Select(s => s.TransactionId));

                // Products
                var dbProducts = db.Fetch<Data.Product>("WHERE ProductId IN (@0)", dbTransactionDetails.Select(s => s.ProductId));

                // Categories
                var getCategory = dbProducts.Where(p => p.CategoryId != null).GroupBy(c => new { c.CategoryId }).Select(s => (int)s.Key.CategoryId).ToList();
                var categories = getCategory.Count>0 ? Facades.Categories.GetByCategoryIdList(getCategory) : null;

                // Prices
                var prices = Facades.Prices.GetByPriceIdList(dbProducts.Select(s => s.PriceId).ToList());

                var products = Products.ToModelList(dbProducts, categories, prices);
                var transactionDetails = Business.Facades.TransactionDetails.ToModelList(dbTransactionDetails, products);

                return ToModelList(dbTransactions, transactionDetails, users, voidUsers);
            }
        }

        public static bool AddTransaction(Models.Transactions transaction)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {
                        
                        var dbTransaction = new Data.Transaction()
                        {
                            TransactionId = transaction.TransactionId,
                            UserId = transaction.UserId,
                            CustomerId = transaction.CustomerId,
                            ReceiptNumber = transaction.ReceiptNumber,
                            TransactionTypeId = (int)transaction.TransactionTypeId,
                            DiscountPercentage = transaction.DiscountPercentage,
                            DiscountAmount = transaction.DiscountAmount,
                            PaymentAmount = transaction.PaymentAmount,
                            WholesaleReason = transaction.WholesaleReason,
                            isRetail = transaction.isRetail,
                            CreationDate = DateTime.Now
                        };
                        db.Save(dbTransaction);

                        transaction.TransactionDetails.ForEach(transactionDetail =>
                        {
                            var dbTransactionDetail = new Data.TransactionDetail()
                            {
                                TransactionDetailId = transactionDetail.TransactionDetailId,
                                TransactionId = dbTransaction.TransactionId,
                                ProductId = transactionDetail.ProductId,
                                Quantity = transactionDetail.Quantity,
                                TotalPrice = transactionDetail.TotalPrice,
                                CreationDate = DateTime.Now
                            };
                            db.Save(dbTransactionDetail);

                            //if pending transaction dont update invetory
                            if ((int)transaction.TransactionTypeId != 4)
                            {
                                // Update Inventory stocks
                                var dbInventory = db.FirstOrDefault<Data.Inventory>("WHERE ProductId = @0 AND EndDate IS NULL", transactionDetail.ProductId);
                                if (dbInventory != null)
                                {
                                    dbInventory.Quantity = dbInventory.Quantity - transactionDetail.Quantity;
                                    dbInventory.ModificationDate = DateTime.Now;
                                    dbInventory.Update();
                                }
                            }
                        });
                        
                        scope.Complete();
                    }
                    return true;
                }
            }
            catch(Exception msg)
            {
                return false;
            }
        }

        //for pending
        public static bool AddTransaction(Models.Transactions transaction,int transID)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    using (var scope = db.GetTransaction())
                    {

                        var dbTransaction = db.FirstOrDefault<Data.Transaction>("WHERE TransactionId = @0 AND EndDate IS NULL", transID);
                        dbTransaction.UserId = Globals.UserId;
                        dbTransaction.CustomerId = transaction.CustomerId;
                        dbTransaction.ReceiptNumber = transaction.ReceiptNumber;
                        dbTransaction.TransactionTypeId = (int)Enums.TransactionTypes.Sales;
                        dbTransaction.DiscountPercentage = transaction.DiscountPercentage;
                        dbTransaction.DiscountAmount = transaction.DiscountAmount;
                        dbTransaction.PaymentAmount = transaction.PaymentAmount;
                        dbTransaction.WholesaleReason = transaction.WholesaleReason;
                        dbTransaction.isRetail = transaction.isRetail;

                        db.Update(dbTransaction);

                        //remove old transactionDetails then replace the updated one
                        if (Business.Facades.TransactionDetails.RemoveTransactionDetailById(transID))
                        {
                            transaction.TransactionDetails.ForEach(transactionDetail =>
                            {
                                var dbTransactionDetail = new Data.TransactionDetail()
                                {
                                    TransactionDetailId = transactionDetail.TransactionDetailId,
                                    TransactionId = dbTransaction.TransactionId,
                                    ProductId = transactionDetail.ProductId,
                                    Quantity = transactionDetail.Quantity,
                                    TotalPrice = transactionDetail.TotalPrice,
                                    CreationDate = DateTime.Now
                                };
                                db.Save(dbTransactionDetail);

                                // Update Inventory stocks
                                var dbInventory = db.FirstOrDefault<Data.Inventory>("WHERE ProductId = @0 AND EndDate IS NULL", transactionDetail.ProductId);
                                if (dbInventory != null)
                                {
                                    dbInventory.Quantity = dbInventory.Quantity - transactionDetail.Quantity;
                                    dbInventory.ModificationDate = DateTime.Now;
                                    dbInventory.Update();
                                }
                            });
                        }

                        scope.Complete();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static Models.Transactions GetTransactionsById(int transID)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTrans = db.FirstOrDefault<Data.Transaction>("WHERE TransactionId = @0", transID);
                if (dbTrans == null) return null;

                return ToModel(dbTrans);
            }
        }

        public static List<Models.Transactions> GetAllPendingTransactions()
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbTrans = db.Fetch<Data.Transaction>("WHERE TransactionTypeId = @0 AND EndDate IS NULL ORDER BY TransactionId DESC",4);
                if (dbTrans == null) return null;
                if (dbTrans.Count == 0) return null;

                var pendingTransactionList = new List<Models.Transactions>();
                pendingTransactionList = dbTrans.Select(transaction => new Models.Transactions()
                {
                    TransactionId = transaction.TransactionId,
                    UserId = transaction.UserId,
                    ReceiptNumber = transaction.ReceiptNumber,
                    TransactionTypeId = (Enums.TransactionTypes)transaction.TransactionTypeId,
                    DiscountPercentage = transaction.DiscountPercentage,
                    DiscountAmount = transaction.DiscountAmount,
                    PaymentAmount = transaction.PaymentAmount,
                    isRetail = transaction.isRetail,
                    WholesaleReason = transaction.WholesaleReason,
                    CreationDate = transaction.CreationDate,
                    EndDate = transaction.EndDate
                }).ToList();

                return pendingTransactionList;
            }
        }

        public static bool VoidTransaction(string receiptNumber, int userId)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbTransaction = db.FirstOrDefault<Data.Transaction>("WHERE ReceiptNumber = @0 AND EndDate IS NULL", receiptNumber.Trim());
                    if (dbTransaction == null) return false;

                    dbTransaction.EndDate = DateTime.Now;
                    dbTransaction.VoidedBy = userId;
                    dbTransaction.Update();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool RemovePendingTransactionByID(int transID) {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    var dbTransaction = db.FirstOrDefault<Data.Transaction>("WHERE TransactionId = @0 AND EndDate IS NULL", transID);
                    if (dbTransaction != null)
                    {
                        dbTransaction.EndDate = DateTime.Now;
                        dbTransaction.VoidedBy=Globals.UserId;
                        dbTransaction.Update();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool RetrievePendingTransaction(int transID)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    var dbTransaction = db.FirstOrDefault<Data.Transaction>("WHERE TransactionId = @0", transID);
                    if (dbTransaction != null)
                    {
                        dbTransaction.EndDate = null;
                        dbTransaction.VoidedBy = null;
                        dbTransaction.Update();
                    }
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

    }
}
