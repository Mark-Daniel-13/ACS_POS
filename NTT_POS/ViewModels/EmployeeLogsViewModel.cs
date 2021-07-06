using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class EmployeeLogsViewModel
    {
        public string Date { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int TotalSales { get; set; }
        public string EmployeeName { get; set; }
        public DateTime StartRange { get; set; }
        public DateTime? EndRange { get; set; }
        public double TotalPrice { get; set; }
        public double CashSweep { get; set; }

        public static List<EmployeeLogsViewModel> ToModelList(List<Business.Models.LoginHistory> histories)
        {
            var summarizedDailyViewModelList = new List<EmployeeLogsViewModel>();
            histories.ForEach(history =>
            {   //check if there's sales on that time in
                DateTime endDate = history.EndDate != null ? (DateTime)history.EndDate : history.CreationDate;
                var sales = Business.Facades.Transactions.GetTransactionsOnRange(history.CreationDate, endDate,true);
                var summarizedDailyViewModel = new EmployeeLogsViewModel();
                summarizedDailyViewModel.CreationDate = history.CreationDate;
                summarizedDailyViewModel.TotalSales = sales!= null ? getTotalItemSold(sales) : 0;
                summarizedDailyViewModel.TotalPrice = sales!=null ? getTotalPrice(sales) : 0;
                summarizedDailyViewModel.OpeningTime = history.CreationDate.ToString("hh:mm tt");
                summarizedDailyViewModel.ClosingTime = endDate.ToString("hh:mm tt");
                summarizedDailyViewModel.Date = history.CreationDate.ToString("MM/dd/yyyy");
                var user = Business.Facades.Users.GetById(history.UserId);
                summarizedDailyViewModel.EmployeeName = string.Format("{0} {1}", user.FirstName, user.LastName);
                var cashSweep = Business.Facades.RegisterActivities.GetCashSweep(user.UserId, history.LoginHistoryId);
                summarizedDailyViewModel.CashSweep = cashSweep != null ? cashSweep.Sum(s=>s.TotalAmount) : 0;
                
                summarizedDailyViewModelList.Add(summarizedDailyViewModel);
                
            });

            return summarizedDailyViewModelList;
        }

        private static double getTotalPrice(List<Business.Models.Transactions> transactions)
        {
            double totalPrice = 0.00;
            transactions.ForEach(transaction =>
            {
                //for each transaction get total sales on transaction details
                transaction.TransactionDetails.ForEach(details =>
                {
                    totalPrice += details.TotalPrice;
                });
            });

            return totalPrice;
        }

        private static int getTotalItemSold(List<Business.Models.Transactions> transactions) {
            int totalItems = 0;
            transactions.ForEach(transaction =>
            {
                transaction.TransactionDetails.ForEach(details =>
                {
                    totalItems += Convert.ToInt32(details.Quantity);
                });
            });
            return totalItems;
        }
    }
}
