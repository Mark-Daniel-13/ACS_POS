using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    class ProductOrderViewModel
    {
        public int ProductOrderId { get; set; }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public Business.Enums.OrderStatus OrderStatusId { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public string TIN { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? EndDate { get; set; }



        public static ProductOrderViewModel ToViewModel(Business.Models.ProductOrder order)
        {
            var supplier = Business.Facades.Supplier.GetAll();
            var orderVM = new ProductOrderViewModel();
            orderVM.ProductOrderId = order.ProductOrderId;
            orderVM.SupplierId = order.SupplierId;
            orderVM.SupplierName = supplier.Where(s => s.SupplierId == order.SupplierId).FirstOrDefault().SupplierName;
            orderVM.OrderStatusId = (Business.Enums.OrderStatus)order.OrderStatusId;
            orderVM.CreationDate = order.CreationDate;

            var branch = Business.Facades.CompanyBranchDetails.GetAll().FirstOrDefault();
            orderVM.BranchName = branch.BranchName;
            orderVM.BranchAddress = branch.Address;
           
            orderVM.TIN = !string.IsNullOrEmpty(branch.TinNo) ? Helpers.TextboxHelper.ConvertStringOfTinList(Helpers.TextboxHelper.ConvertTINWithDash(branch.TinNo)) : "";

            return orderVM;
        }

        public static List<ProductOrderViewModel> ToViewModelList(List<Business.Models.ProductOrder> orders)
        {
            var orderVMList = new List<ProductOrderViewModel>();
            var supplier = Business.Facades.Supplier.GetAll();
            orders.ForEach(datarow =>
            {
                var orderVM = new ProductOrderViewModel();
                orderVM.ProductOrderId = datarow.ProductOrderId;
                orderVM.SupplierId = datarow.SupplierId;
                orderVM.SupplierName = supplier.Where(s => s.SupplierId == datarow.SupplierId).FirstOrDefault().SupplierName;
                orderVM.OrderStatusId = (Business.Enums.OrderStatus)datarow.OrderStatusId;
                orderVM.CreationDate = datarow.CreationDate;
                orderVMList.Add(orderVM);
            });

            return orderVMList;
        }


    }
}
