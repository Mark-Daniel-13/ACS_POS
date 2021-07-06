using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Facades
{
    public class Returns
    {
        public static Models.Returns ToModel(Data.Return _return, Models.TransactionDetails transactionDetail)
        {
            return new Models.Returns()
            {
                ReturnId = _return.ReturnId,
                TransactionDetailId = _return.TransactionDetailId,
                TransactionDetail = transactionDetail,
                Quantity = _return.Quantity,
                ReturnedAmount = _return.ReturnedAmount,
                Reason = _return.Reason,
                UserId = _return.UserId,
                CreationDate = _return.CreationDate,
                ReturnStatusId = _return.ReturnStatusId,
            };
        }

        public static List<Models.Returns> ToModelList(List<Data.Return> _returns, Models.TransactionDetails transactionDetail)
        {
            var returnList = new List<Models.Returns>();
            returnList = _returns.Select(_return => new Models.Returns()
            {
                ReturnId = _return.ReturnId,
                TransactionDetailId = _return.TransactionDetailId,
                TransactionDetail = transactionDetail,
                Quantity = _return.Quantity,
                ReturnedAmount = _return.ReturnedAmount,
                Reason = _return.Reason,
                UserId = _return.UserId,
                CreationDate = _return.CreationDate,
                ReturnStatusId = _return.ReturnStatusId,
            }).ToList();

            return returnList;
        }

        public static List<Models.Returns> ToModelList(List<Data.Return> _returns)
        {
            var returnList = new List<Models.Returns>();
            returnList = _returns.Select(_return => new Models.Returns()
            {
                ReturnId = _return.ReturnId,
                TransactionDetailId = _return.TransactionDetailId,
                Quantity = _return.Quantity,
                ReturnedAmount = _return.ReturnedAmount,
                Reason = _return.Reason,
                UserId = _return.UserId,
                CreationDate = _return.CreationDate,
                ReturnStatusId = _return.ReturnStatusId,
            }).ToList();

            return returnList;
        }

        public static List<Models.Returns> ToModelList(List<Data.Return> _returns, List<Models.TransactionDetails> transactionDetails)
        {
            var returnList = new List<Models.Returns>();
            returnList = _returns.Select(_return => new Models.Returns(){
                ReturnId = _return.ReturnId,
                TransactionDetailId = _return.TransactionDetailId,
                TransactionDetail = transactionDetails.Where(w => w.TransactionDetailId == _return.TransactionDetailId).FirstOrDefault(),
                Quantity = _return.Quantity,
                ReturnedAmount = _return.ReturnedAmount,
                Reason = _return.Reason,
                UserId = _return.UserId,
                CreationDate = _return.CreationDate,
                ReturnStatusId = _return.ReturnStatusId,
            }).ToList();

            return returnList;
        }
        public static List<Models.Returns> GetAllByReturnStatus(Enums.ReturnStatus status)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbReturn = db.Fetch<Data.Return>("WHERE ReturnStatusId = @0", (int)status);
                if (dbReturn == null) { return null; }

                return ToModelList(dbReturn);
            }
        }
        public static List<Models.Returns> GetAllByReturnStatusFilterByDate(int status,DateTime startDate,DateTime endDate)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var StartTime = string.Format("{0} 00:00:00 AM", startDate.ToString("MM/dd/yyyy"));
                var EndTime = string.Format("{0} 11:59:59 PM", endDate.ToString("MM/dd/yyyy"));
                List<Data.Return> dbReturn;
                if (status > 0)
                {
                    dbReturn = db.Fetch<Data.Return>("WHERE ReturnStatusId = @0 AND CreationDate >= @1 AND CreationDate <=@2", status, StartTime, EndTime);
                }
                else {
                    dbReturn = db.Fetch<Data.Return>("WHERE CreationDate >= @0 AND CreationDate <=@1", StartTime, EndTime);
                }
                if (dbReturn == null) { return null; }

                return ToModelList(dbReturn);
            }
        }
        public static List<Models.Returns> GetAllByTransactionDetailId(int transactionDetailId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbReturn = db.Fetch<Data.Return>("WHERE TransactionDetailId = @0", transactionDetailId);
                if (dbReturn == null) { return null; }

                var transactionDetail = Business.Facades.TransactionDetails.GetByTransactionDetailId(transactionDetailId);

                return ToModelList(dbReturn, transactionDetail);
            }
        }

        public static List<Models.Returns> GetAllReturnsOnShift(int userId, DateTime shift)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbReturn = db.Fetch<Data.Return>("WHERE UserId = @0 AND CreationDate >= @1", userId, shift.ToString("MM/dd/yyyy hh:mm tt"));
                if (dbReturn == null) { return null; }

                return ToModelList(dbReturn);
            }
        }

        public static bool AddReturn(Models.Returns _return)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {
                    var dbReturn = new Data.Return()
                    {
                        ReturnId = _return.ReturnId,
                        TransactionDetailId = _return.TransactionDetailId,
                        Quantity = _return.Quantity,
                        ReturnedAmount = _return.ReturnedAmount,
                        Reason = _return.Reason,
                        UserId = _return.UserId,
                        CreationDate = DateTime.Now,
                        ReturnStatusId = _return.ReturnStatusId,
                    };
                    db.Save(dbReturn);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool UpdateReturnStatus(int returnId,int status)
        {
            try
            {
                using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
                {

                    using (var scope = db.GetTransaction())
                    {
                        var dbReturn = db.FirstOrDefault<Data.Return>("WHERE ReturnId = @0", returnId);

                        dbReturn.ReturnStatusId = status;
                        db.Update(dbReturn);

                        //update inventory if return to shelf
                        if (status == (int)Enums.ReturnStatus.ReturnToShelf)
                        {
                            var productId = TransactionDetails.GetByTransactionDetailId(dbReturn.TransactionDetailId).ProductId;
                            var dbInventory = db.FirstOrDefault<Data.Inventory>("WHERE ProductId = @0 AND EndDate IS NULL", productId);

                            dbInventory.Quantity += dbReturn.Quantity;
                            db.Update(dbInventory);
                        }
                        scope.Complete();
                    }
                }
                return true;
            }
            catch(Exception e)
            {
                
                return false;
            }
        }
    }
}
