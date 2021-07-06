using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;



namespace NTT_POS.Helpers
{
    public class TextboxHelper
    {
        public static void NumericKeypressHandler(object sender, KeyPressEventArgs e, bool allowPercent = false)
        {
            if (allowPercent)
            {
                if (!char.IsNumber(e.KeyChar) & e.KeyChar != '%' & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.' & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.' & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '-')
                {
                    e.Handled = true;
                }
            }
        }
        public static void NumericKeypressHypen(object sender, KeyPressEventArgs e, bool allowPercent = false,bool allowSlash=false)
        {
            if (allowPercent)
            {
                if (!char.IsNumber(e.KeyChar) & e.KeyChar != '%' & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
            else if(allowSlash){
                if (!char.IsNumber(e.KeyChar) & e.KeyChar != '/' & (Keys)e.KeyChar != Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        public static double ConvertToDouble(string num)
        {
            try
            {
                double ret = 0.00;
                var style = NumberStyles.Float | NumberStyles.AllowDecimalPoint | NumberStyles.Number;
                var culture = CultureInfo.InvariantCulture;
                double.TryParse(num, style, culture, out ret);
                return ret;
            }
            catch
            {
                return 0.00;
            }
        }

        public static List<string> WrapText(string text, double pixels, string fontFamily,float emSize)
        {
            string[] originalLines = text.Split(new string[] { " " },
                StringSplitOptions.None);

            List<string> wrappedLines = new List<string>();

            StringBuilder actualLine = new StringBuilder();
            double actualWidth = 0;

            foreach (var item in originalLines)
            {
                FormattedText formatted = new FormattedText(item,
                    CultureInfo.CurrentCulture,
                    System.Windows.FlowDirection.LeftToRight,
                    new Typeface(fontFamily), emSize, Brushes.Black);

                actualLine.Append(item + " ");
                actualWidth += formatted.Width;

                if (actualWidth > pixels)
                {
                    wrappedLines.Add(actualLine.ToString());
                    actualLine.Clear();
                    actualWidth = 0;
                }
            }

            if (actualLine.Length > 0)
                wrappedLines.Add(actualLine.ToString());

            return wrappedLines;
        }
        public static bool checkAlpha(string name)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(name, "[^a-zA-Z_  .]+"))
            {
                return true;
            }
            return false;
        }
        public static bool checkTin(string number)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(number, "[^0-9]"))
            {
                return true;
            }
            return false;
        }
        public static bool checkNumeric(string number)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(number, "[^0-9.]"))
            {
                return true;
            }
            return false;
        }

        public static bool ValidateTextBox(TextBox textbox,ErrorProvider errProvider) {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                //textbox.Focus();
                errProvider.SetError(textbox, "Required field");
                return false;
            }
            else
            {
                errProvider.SetError(textbox, null);
                return true;
            }
        }
        public static bool checkEmail(string name)
        {

            if (string.IsNullOrEmpty(name)) {
                //if empty string return true
                return true;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(name, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))

            {
                return true;
            }
            return false;
        }
        public static List<string> ConvertTINWithDash(string tin) {

            return Enumerable.Range(0, tin.Length/3).Select(t => tin.Substring(t*3, 3)).ToList();
        }
        public static string ConvertStringOfTinList(List<string> tinList) {
            var tinToString = "";
            tinList.ForEach(tin =>
            {
                string toAppend = tin + "-";
                tinToString += toAppend;
            });
            return tinToString.Remove(tinToString.Length - 1, 1);
        }
    }
   
}
