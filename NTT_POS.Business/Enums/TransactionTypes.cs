using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Enums
{
    public enum TransactionTypes : int
    {
        Sales = 1,
        PurchaseOrder = 2,
        Returns = 3,
        Pending = 4
    }
}
