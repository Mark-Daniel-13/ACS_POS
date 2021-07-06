using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Enums
{
    public enum ReturnStatus : int
    {
        ToBeReviewed = 1,
        ReturnToShelf = 2,
        DiscardItem = 3
    }
}
