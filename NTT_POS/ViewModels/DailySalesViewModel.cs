using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class DailySalesViewModel
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime TransactionTime { get; set; }
        public DateTime? TransactionEndDate { get; set; }
        public DateTime? TransactionEndTime { get; set; }
        public double? TransactionDiscount { get; set; }
        public double TransactionPrice { get; set; }
        public string ProductName { get; set; }
        public string ProductCategoryName { get; set; }
        public double ProductPrice { get; set; }
        public double TransactionDetailQuantity { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? VoidedBy { get; set; }
        public string VoidFirstName { get; set; }
        public string VoidLastName { get; set; }
        public string Date { get; set; }
        public double TotalPrice { get; set; }
        public double TotalDiscount { get; set; }
        public static List<DailySalesViewModel> ToModelList(List<Business.Models.Transactions> transactions)
        {
            var dailySalesViewModelList = new List<DailySalesViewModel>();
            var totalDiscount = 0.00;
            transactions.ForEach(transaction =>
            {
                totalDiscount += (double)transaction.DiscountAmount;
                if (transaction.TransactionDetails != null)
                {
                    transaction.TransactionDetails.ForEach(transactionDetail =>
                    {
                        var dailySalesViewModel = new DailySalesViewModel();
                        dailySalesViewModel.Date = transaction.CreationDate.ToString("MM/dd/yyyy");
                        dailySalesViewModel.TransactionId = transaction.TransactionId;
                        dailySalesViewModel.TransactionDate = transaction.CreationDate;
                        dailySalesViewModel.TransactionTime = transaction.CreationDate;
                        dailySalesViewModel.TransactionEndDate = transaction.EndDate;
                        dailySalesViewModel.TransactionEndTime = transaction.EndDate;
                        dailySalesViewModel.TransactionDiscount = transaction.DiscountAmount;
                        dailySalesViewModel.TransactionPrice = transaction.PaymentAmount;
                        dailySalesViewModel.TransactionDetailQuantity = transactionDetail.Quantity;
                        if (transaction.User != null)
                        {
                            dailySalesViewModel.UserFirstName = transaction.User.FirstName;
                            dailySalesViewModel.UserLastName = transaction.User.LastName;
                        }
                        if (transactionDetail.Product != null)
                        {
                            dailySalesViewModel.ProductName = transactionDetail.Product.Description;
                            if (transactionDetail.Product.Category != null)
                            {
                                dailySalesViewModel.ProductCategoryName = transactionDetail.Product.Category.Name;
                            }
                            if (transactionDetail.Product.Price != null)
                            {
                                //new
                                dailySalesViewModel.ProductPrice = (double)transactionDetail.TotalPrice / transactionDetail.Quantity;
                                dailySalesViewModel.TotalPrice = (double)transactionDetail.TotalPrice;
                            }
                        }
                        if (transaction.VoidUser != null)
                        {
                            dailySalesViewModel.VoidFirstName = transaction.VoidUser.FirstName;
                            dailySalesViewModel.VoidLastName = transaction.VoidUser.LastName;
                        }
                        

                        dailySalesViewModelList.Add(dailySalesViewModel);
                    });
                }
            });
            dailySalesViewModelList.FirstOrDefault().TotalDiscount = totalDiscount;

            return dailySalesViewModelList;
        }
    }
}
