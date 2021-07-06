using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class SalesSummaryViewModel
    {
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }
        public string CategoryName { get; set; }
        public string ProductFullDescription { get; set; }
        public double StockQuantity { get; set; }
        public double SoldQuantity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public static List<SalesSummaryViewModel> ToModelList(List<Business.Models.SalesSummary> sales)
        {
            var salesViewModelList = new List<SalesSummaryViewModel>();
            sales.ForEach(sale => 
            {
                var salesViewModel = new SalesSummaryViewModel();
                if (sale.Product != null)
                {
                    salesViewModel.ProductId = sale.Product.ProductId;
                    salesViewModel.ProductDescription = sale.Product.Description;
                    salesViewModel.ProductFullDescription = sale.Product.FullDescription;

                    if (sale.Product.Category != null)
                    {
                        salesViewModel.CategoryName = sale.Product.Category.Name;
                    }
                }
                if (sale.Inventory != null)
                {
                    salesViewModel.StockQuantity =sale.Inventory.Quantity != null ? (double)sale.Inventory.Quantity : 0;
                }
                if(sale.TransactionDetails != null)
                {
                    salesViewModel.SoldQuantity = sale.TransactionDetails.Sum(s => s.Quantity);
                }
                salesViewModelList.Add(salesViewModel);
            });

            return salesViewModelList;
        }
    }
}
