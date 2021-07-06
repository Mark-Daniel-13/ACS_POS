using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class EmployeeSalesViewModel
    {
        public string EmployeeName { get; set; }
        public int TotalSales { get; set; }
        public int RankNumber { get; set; }
        public DateTime StartRange { get; set; }
        public DateTime EndRange { get; set; }

        public static List<EmployeeSalesViewModel> ToModelList(List<Business.Models.Users> cashiers,DateTime startDate, DateTime endDate)
        {
            var EmployeeSales = new List<EmployeeSalesViewModel>();
            cashiers.ForEach(cashier =>
            {
                var totalSales = Business.Facades.Transactions.GettNumberOfSalesPerTransactionByCashier(cashier.UserId, startDate, endDate);
                var model = new EmployeeSalesViewModel()
                {
                    EmployeeName = string.Format("{0} {1}", cashier.FirstName, cashier.LastName),
                    TotalSales = totalSales
                };
                EmployeeSales.Add(model);
            });

            EmployeeSales = EmployeeSales.OrderByDescending(o => o.TotalSales).ToList();
            //Enter Ranking after sorting
            var rank = 1;
            EmployeeSales.ForEach(employee =>
            {
                employee.RankNumber = rank;
                rank++;
            });

            return EmployeeSales;
        }
    }
}
