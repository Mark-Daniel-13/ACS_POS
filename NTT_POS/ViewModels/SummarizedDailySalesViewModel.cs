using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    class SummarizedDailySalesViewModel
    {
        public string Date { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double TotalSales { get; set; }
        public int TotalTransactions { get; set; }
        public TimeSpan? TotalHours { get; set; }
        public DateTime StartRange { get; set; }
        public DateTime? EndRange { get; set; }


        public static List<SummarizedDailySalesViewModel> ToModelList(List<Business.Models.LoginHistory> histories)
        {
            var summarizedDailyViewModelList = new List<SummarizedDailySalesViewModel>();
            histories.ForEach(history =>
            {   //check if there's sales on that time in
                DateTime endDate = history.EndDate != null ? (DateTime)history.EndDate : DateTime.Now;
                var trasactionCount = Business.Facades.Transactions.GetTransactionsOnRange(history.CreationDate, endDate,true);
                var hours = Business.Facades.LoginHistory.GetRenderedHours(history.LoginHistoryId);

                var summarizedDailyViewModel = new SummarizedDailySalesViewModel();
                summarizedDailyViewModel.CreationDate = history.CreationDate;
                summarizedDailyViewModel.TotalSales = trasactionCount != null? getTotalSales(trasactionCount) : 0;
                summarizedDailyViewModel.TotalTransactions = trasactionCount != null ? trasactionCount.Count() : 0;
                summarizedDailyViewModel.TotalHours = hours.Value;
                summarizedDailyViewModel.Date = history.CreationDate.ToString("MM/dd/yyyy");
                
                summarizedDailyViewModelList.Add(summarizedDailyViewModel);
                
            });

            return summarizedDailyViewModelList;
        }

        private static double getTotalSales(List<Business.Models.Transactions> transctions) {
            double totalSales = 0.00;
            transctions.ForEach(transction =>
            {
                transction.TransactionDetails.ForEach(detail =>
                {
                    totalSales += detail.TotalPrice;
                });
            });
            return totalSales;
        }
    }
}
