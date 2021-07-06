using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Helpers
{
    public class Receipt
    {
        public static string GenerateReceiptNumber()
        {
            string receiptNumber = string.Empty;
            var lastTransaction = Facades.Transactions.GetLastTransaction();
            if (lastTransaction == null)
            {
                receiptNumber = string.Format(Globals.ReceiptFormat, Convert.ToInt32(Globals.ReceiptNumberStart ?? "1"));
            }
            else
            {
                var lastReceiptNumber = new string(lastTransaction.ReceiptNumber.Where(char.IsDigit).ToArray());
                receiptNumber = string.Format(Globals.ReceiptFormat, Convert.ToInt32(lastReceiptNumber) + 1);
            }

            return receiptNumber;
        }
    }
}
