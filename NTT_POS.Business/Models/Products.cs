using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public Models.Categories Category { get; set; }
        public int PriceId { get; set; }
        public Models.Prices Price { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
