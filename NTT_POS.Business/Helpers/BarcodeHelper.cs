using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NTT_POS.Business.Helpers
{
    public class BarcodeHelper
    {
        public static string ConvertBarcodeToString(long? barcode) {
            var barcodeLength = barcode.ToString().Length;
            var leadingZero = 11 - barcodeLength;
            var barcodeText = "IT";
            for (var x = 0; x < leadingZero; x++) {
                barcodeText += "0"; 
            }
            
            return barcodeText += barcode.ToString();
        }

        public static long ConvertStringToLong(string barcodeText)
        {
            var removedTag = barcodeText.Trim(new Char[] { 'I', 'T' });
            return Convert.ToInt64(removedTag);
          
        }
        public static string RemoveTagJustLeadingZero(string barcodeText)
        {
            return barcodeText.Trim(new Char[] { 'I', 'T' });
        }

        public static bool CheckFormat(string barcodeText, out string msg ){
            msg = null;
            var removedTag = barcodeText.Trim(new Char[] {'I','T'});
            try {
                if (removedTag.Length == 11)
                {

                    Convert.ToInt64(removedTag);
                }
                else {
                    msg = "Barcode only accepts 13 digit characters, Please check your inputs.";
                    return false;
                }
               
            }
            catch {
                msg = "Barcode has invalid format, Please check your inputs.";
                return false;
            }
            return true;
        }
        public static string GenerateNewBarcode(bool stringValue = true) {
            var newBarcode = Business.Facades.Products.GetHighestUnusedBarcode();
            if (newBarcode != null)
            {
                return stringValue ? ConvertBarcodeToString(newBarcode + 1) : (newBarcode + 1).ToString();
            }
            else
            {
                 return stringValue ? "IT00000000001" : "00000000001";
            }
        }

    }
}
