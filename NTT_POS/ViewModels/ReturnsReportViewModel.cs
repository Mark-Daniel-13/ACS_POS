using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class ReturnsReportViewModel
    {
        public string ReceiptNumber { get; set; }
        public string CashierName { get; set; }
        public string ReturnDate { get; set; }
        public string ProductName { get; set; }
        public double PurchaseQuantity { get; set; }
        public double ReturnedQuantity { get; set; }
        public string ReturnReason { get; set; }
        public string ReturnAction { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public static List<ReturnsReportViewModel> ToModelList(List<Business.Models.Returns> returns)
        {
            var returnsViewModel = new List<ReturnsReportViewModel>();
            returns.ForEach(returnItem =>
            {
                var transactionDetail = Business.Facades.TransactionDetails.GetByTransactionDetailId(returnItem.TransactionDetailId);
                var item = new ReturnsReportViewModel()
                {
                    ReceiptNumber = Business.Facades.TransactionDetails.GetReceiptByTransactionDetailId(returnItem.TransactionDetailId),
                    CashierName = Business.Facades.Users.GetUserFullName(returnItem.UserId),
                    ReturnDate = returnItem.CreationDate.ToString("MM/dd/yyyy"),
                    ProductName = transactionDetail.Product.Description,
                    PurchaseQuantity = transactionDetail.Quantity,
                    ReturnedQuantity = returnItem.Quantity,
                    ReturnReason = returnItem.Reason,
                    ReturnAction = GetStatusString(returnItem.ReturnStatusId),
                };

                returnsViewModel.Add(item);
            });

            return returnsViewModel;
        }

        private static string GetStatusString(int statusId) {
            switch (statusId)
            {
                case 1:
                    return "To Be Reviewed";
                    break;
                case 2:
                    return "Return To Shelf";
                    break;
                case 3:
                    return "Discard Item";
                    break;
                default:
                    return "Undefined";
                    break;
            }
        }
    }
}
