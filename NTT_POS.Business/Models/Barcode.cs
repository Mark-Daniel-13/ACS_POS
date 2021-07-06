using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Models
{
    public class Barcode
    {
        public int BarcodeId { get; set; }
        public string BarcodeText { get; set;}
        public DateTime CreationDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
