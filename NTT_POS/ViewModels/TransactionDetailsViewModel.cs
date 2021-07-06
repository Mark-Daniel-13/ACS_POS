using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class TransactionDetailsViewModel
    {
        public int TransactionId { get; set; }
        public int TransactionDetailId { get; set; }
        public int ProductId { get; set; }
        public string Barcode { get; set; }
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public double ReturnedQuantity { get; set; }
        public double TotalPrice { get; set; }

        public double RetailPrice { get; set; }

        public static TransactionDetailsViewModel ToViewModel(Business.Models.TransactionDetails transactionDetail)
        {
            var transactionDetailVM = new TransactionDetailsViewModel();
            transactionDetailVM.TransactionId = transactionDetail.TransactionId;
            transactionDetailVM.TransactionDetailId = transactionDetail.TransactionDetailId;
            transactionDetailVM.ProductId = transactionDetail.ProductId;
            if (transactionDetail.Product != null)
            {
                transactionDetailVM.Barcode = transactionDetail.Product.Barcode;
                transactionDetailVM.ProductName = transactionDetail.Product.Description;
            }
            transactionDetailVM.Quantity = transactionDetail.Quantity;
            transactionDetailVM.TotalPrice = transactionDetail.TotalPrice;

            return transactionDetailVM;
        }

        public static List<TransactionDetailsViewModel> ToViewModelList(List<Business.Models.TransactionDetails> transactionDetails)
        {
            var transactionDetailVMList = new List<TransactionDetailsViewModel>();
            transactionDetails.ForEach(transactionDetail =>
            {
                var transactionDetailVM = new TransactionDetailsViewModel();
                transactionDetailVM.TransactionId = transactionDetail.TransactionId;
                transactionDetailVM.TransactionDetailId = transactionDetail.TransactionDetailId;
                transactionDetailVM.ProductId = transactionDetail.ProductId;
                var product = Business.Facades.Products.GetByProductId(transactionDetail.ProductId);
                if (transactionDetail.Product != null)
                {

                    transactionDetailVM.Barcode = transactionDetail.Product.Barcode;
                    transactionDetailVM.ProductName = transactionDetail.Product.Description;

                    if (transactionDetail.Product.Price != null)
                    {
                        transactionDetailVM.RetailPrice = (double)transactionDetail.Product.Price.RetailPrice;
                    }
                }
                else if(product != null){
                    transactionDetailVM.Barcode = product.Barcode;
                    transactionDetailVM.ProductName = product.Description;

                    if (product.Price != null)
                    {
                        transactionDetailVM.RetailPrice = (double)product.Price.RetailPrice;
                    }
                }

                transactionDetailVM.Quantity = transactionDetail.Quantity;
                if (transactionDetail.Returns != null)
                {
                    transactionDetailVM.ReturnedQuantity = transactionDetail.Returns.Sum(s => s.Quantity);
                }
                else
                {
                    transactionDetailVM.ReturnedQuantity = 0;
                }

                transactionDetailVM.TotalPrice = transactionDetail.TotalPrice;

                transactionDetailVMList.Add(transactionDetailVM);
            });

            return transactionDetailVMList;
        }

        public static List<TransactionDetailsViewModel> ToViewModelListGrouped(List<Business.Models.TransactionDetails> transactionDetails)
        {
            var groupedList = transactionDetails.GroupBy(g => g.ProductId)
                .Select(g => new Business.Models.TransactionDetails
                {
                    TransactionId = g.First().TransactionId,
                    ProductId = g.First().ProductId,
                    Quantity = g.Sum(s=>s.Quantity),
                    TotalPrice = g.Sum(t=>t.TotalPrice),
                }).ToList();

            var transactionDetailVMList = new List<TransactionDetailsViewModel>();
            groupedList.ForEach(transactionDetail =>
            {
                var transactionDetailVM = new TransactionDetailsViewModel();
                transactionDetailVM.TransactionId = transactionDetail.TransactionId;
                transactionDetailVM.TransactionDetailId = transactionDetail.TransactionDetailId;
                transactionDetailVM.ProductId = transactionDetail.ProductId;
                var product = Business.Facades.Products.GetByProductId(transactionDetail.ProductId);
                if (transactionDetail.Product != null)
                {

                    transactionDetailVM.Barcode = transactionDetail.Product.Barcode;
                    transactionDetailVM.ProductName = transactionDetail.Product.Description;

                    if (transactionDetail.Product.Price != null)
                    {
                        transactionDetailVM.RetailPrice = (double)transactionDetail.Product.Price.RetailPrice;
                    }
                }
                else if (product != null)
                {
                    transactionDetailVM.Barcode = product.Barcode;
                    transactionDetailVM.ProductName = product.Description;

                    if (product.Price != null)
                    {
                        transactionDetailVM.RetailPrice = (double)product.Price.RetailPrice;
                    }
                }

                transactionDetailVM.Quantity = transactionDetail.Quantity;
                if (transactionDetail.Returns != null)
                {
                    transactionDetailVM.ReturnedQuantity = transactionDetail.Returns.Sum(s => s.Quantity);
                }
                else
                {
                    transactionDetailVM.ReturnedQuantity = 0;
                }

                transactionDetailVM.TotalPrice = transactionDetail.TotalPrice;

                transactionDetailVMList.Add(transactionDetailVM);
            });

            return transactionDetailVMList;
        }

    }
}
