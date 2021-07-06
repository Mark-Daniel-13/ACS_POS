using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class ReturnsViewmodel
    {
        public int ReturnId { get; set; }
        public int TransactionDetailId { get; set; }
        public string ProductName { get; set; }
        public double PurchaseQuantity { get; set; }
        public double ReturnedQuantity { get; set; }
        public double ReturnedAmount { get; set; }
        public string CashierName { get; set; }
        public int ReturnStatus { get; set; }
        public string Reason { get; set; }
        public static List<ReturnsViewmodel> ToViewModelList(List<Business.Models.Returns> returnList)
        {
            var returnVMList = new List<ReturnsViewmodel>();
            returnList.ForEach(returnItem =>
            {
                var returnVM = new ReturnsViewmodel();
                returnVM.ReturnId = returnItem.ReturnId;
                returnVM.TransactionDetailId = returnItem.TransactionDetailId;
                var transDetail = Business.Facades.TransactionDetails.GetByTransactionDetailId(returnItem.TransactionDetailId);
                returnVM.ProductName = transDetail.Product.Description;
                returnVM.PurchaseQuantity = transDetail.Quantity;
                returnVM.ReturnedQuantity = returnItem.Quantity;
                returnVM.ReturnedAmount = returnItem.ReturnedAmount;
                var cashier = Business.Facades.Users.GetById(returnItem.UserId);
                returnVM.CashierName = string.Format("{0} {1}", cashier.FirstName, cashier.LastName);
                returnVM.ReturnStatus = returnItem.ReturnStatusId;
                returnVM.Reason = returnItem.Reason;


                returnVMList.Add(returnVM);
            });

            return returnVMList;
        }
    }
}
