using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Helpers
{
    public class Paging
    {
        public static int GetTotalPage(int totalItems,int pageItemCount) { 
            return Convert.ToInt32(Math.Ceiling(totalItems / Convert.ToDouble(pageItemCount))); ;
        }
    }
}
