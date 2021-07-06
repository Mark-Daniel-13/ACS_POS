using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.ViewModels
{
    class ExpirationListVIewModel
    {
        public int OrderDetailsId { get; set; }
        public double OrderQuantity { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public double StocksLeft { get; set; }

        public static List<ExpirationListVIewModel> ToViewModelList(List<Business.Models.ProductOrderDetails> orderdetails,double quantity)
        {
            var detailsVMList = new List<ExpirationListVIewModel>();
            var reducedQuantity = quantity;
            orderdetails.ForEach(datarow =>
            {
                if (reducedQuantity > 0)
                {
                    var detailVM = new ExpirationListVIewModel();
                    detailVM.OrderDetailsId = datarow.OrderDetailsId;
                    detailVM.OrderQuantity = datarow.OrderQuantity;
                    detailVM.ExpirationDate = datarow.ExpirationDate != null ? datarow.ExpirationDate : null;

                    if (reducedQuantity - datarow.OrderQuantity >= 0)
                    {
                        detailVM.StocksLeft = datarow.OrderQuantity;
                    }
                    else
                    {
                        detailVM.StocksLeft = reducedQuantity;
                    }
                    reducedQuantity = reducedQuantity - datarow.OrderQuantity;
                    detailsVMList.Add(detailVM);
                }
            });


            return detailsVMList.Where(d=>Convert.ToDouble(d.StocksLeft)>0).ToList();
        }
    }
}
