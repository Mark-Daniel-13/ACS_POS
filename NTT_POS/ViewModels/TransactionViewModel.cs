using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    public class TransactionViewModel
    {
        public int TransactionId { get; set; }

        public int UserId { get; set; }

        public string ReceiptNumber { get; set; }

        public int TransactionTypeID { get; set; }
        public string TransactionType { get; set; }

        public float DiscountPercent { get; set; }

        public float DiscountAmount { get; set; }

        public float PaymentAmount { get; set; }

        public DateTime? CreationDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? VoidedBy { get; set; }

        public string UserName { get; set; }
        public string CustomerName { get; set; }
        public string WholesaleReason { get; set; }
        public bool isRetail { get; set; }


        public static List<TransactionViewModel> ToViewModelList(List<Business.Models.Transactions> trans)
        {
            var transVMList = new List<TransactionViewModel>();
            trans.ForEach(datarow =>
            {
                var transVM = new TransactionViewModel();
                transVM.TransactionId = datarow.TransactionId;
                transVM.UserId = datarow.UserId;
                transVM.ReceiptNumber = datarow.ReceiptNumber;
                transVM.TransactionTypeID = (int)datarow.TransactionTypeId;
                transVM.TransactionType = datarow.isRetail ? "Retail" : "Wholesale";
                transVM.DiscountPercent = (float)datarow.DiscountPercentage;
                transVM.DiscountAmount = (float)datarow.DiscountAmount;
                transVM.PaymentAmount = (float)datarow.PaymentAmount;
                transVM.CreationDate = datarow.CreationDate;
                transVM.EndDate = datarow.EndDate;
                transVM.VoidedBy = datarow.VoidedBy.HasValue ? datarow.VoidedBy : null;
                transVM.CustomerName = datarow.CustomerId != null ? Business.Facades.Customer.GetById(Convert.ToInt32(datarow.CustomerId)).CustomerName : null;
                var fullname = Business.Facades.Users.GetById(datarow.UserId);
                transVM.UserName = string.Format("{0} {1}", fullname.FirstName,fullname.LastName);
                transVM.WholesaleReason = datarow.WholesaleReason;
                transVM.isRetail = datarow.isRetail;

                transVMList.Add(transVM);
            });

            return transVMList;
        }

        public static TransactionViewModel ToViewModel(Business.Models.Transactions trans)
        {
            var transVM = new TransactionViewModel();
            transVM.TransactionId = trans.TransactionId;
            transVM.UserId = trans.UserId;
            transVM.ReceiptNumber = trans.ReceiptNumber;
            transVM.TransactionTypeID = (int)trans.TransactionTypeId;
            transVM.DiscountPercent = (float)trans.DiscountPercentage;
            transVM.DiscountAmount = (float)trans.DiscountAmount;
            transVM.PaymentAmount = (float)trans.PaymentAmount;
            transVM.CreationDate = trans.CreationDate;
            transVM.EndDate = trans.EndDate;
            transVM.VoidedBy = trans.VoidedBy.HasValue ? trans.VoidedBy : null;
            transVM.CustomerName = trans.CustomerId != null ? Business.Facades.Customer.GetById(Convert.ToInt32(trans.CustomerId)).CustomerName : null;
            var fullname = Business.Facades.Users.GetById(trans.UserId);
            transVM.UserName = string.Format("{0} {1}", fullname.FirstName, fullname.LastName);
            transVM.WholesaleReason = trans.WholesaleReason;
            transVM.isRetail = trans.isRetail;

            return transVM;
        }


    }
}
