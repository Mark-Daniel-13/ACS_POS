using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business
{
    public class Globals
    {
        // Database Name
        public const string DatabaseName = "NTT_POS";

        // Logged User
        public static int UserId = 0;
        public static string UserFirstName = string.Empty;
        public static string UserLastName = string.Empty;
        public static string UnitName = string.Empty;

        // Login History
        public static int LoginHistoryId = 0;
        public static bool IsLoggedOut = false;

        // Register Activity
        public static bool IsRegisterIn = false;
        public string RegisterGUID = string.Empty;
        

        // Receipt
        public static string ReceiptNumberStart
        {
            get
            {
                return ConfigurationManager.AppSettings["ReceiptNumberStart"];
            }
        }

        public static string ReceiptFormat
        {
            get
            {
                return ConfigurationManager.AppSettings["ReceiptFormat"];
            }
        }
        public static bool LightTheme = false;
        public static Color PrimaryThemeColor = Color.FromArgb(144, 145, 149);
        public static Color SecondaryThemeColor = Color.FromArgb(144, 145, 149);

        //Panel Admin Main form
        public static Color PanelThemeColorDark = Color.FromArgb(38, 40, 39);
        public static Color PanelThemeColorLight = Color.FromArgb(7, 158, 207);


        //=LIGHT THEME=//
        //Light Theme form backcolor
        public static Color BackgroundThemeColorLight = Color.FromArgb(238, 237, 235);

        //for Light Theme Dgv
        public static Color lightDgvHeadercolor = Color.FromArgb(20, 90, 189);
        public static Color lightDgvHeaderSelectioncolor = Color.FromArgb(20, 90, 189);
        public static Color lightDgvDefaultcellcolor = Color.FromArgb(65, 165, 238);

        //for label forecolor
        public static Color lightLabelcolor = Color.White;
        //for label background
        public static Color lightLabelbackground = Color.FromArgb(20, 90, 189);
        //for panel lines
        public static Color lightPanellines = Color.FromArgb(69, 144, 205);

        //for buttons
        public static Color lightButtoncolor = Color.FromArgb(7, 158, 207);

        //hover color
        public static Color lightHovercolor = Color.FromArgb(8, 189, 248);

        //=====================================================================//

        //=DARK THEME=//
        //Dark Theme form backcolor
        public static Color BackgroundThemeColor = Color.FromArgb(144, 145, 149);

        //for Dark Theme Dgv
        public static Color darkDgvHeadercolor = Color.FromArgb(38, 40, 39);
        public static Color darkDgvHeaderSelectioncolor = Color.FromArgb(38, 40, 39);
        public static Color darkDgvDefaultcellcolor = Color.FromArgb(144, 145, 149);

        //for label forecolor
        public static Color darkLabelcolor = Color.Black;
        //for label background
        public static Color darkLabelbackground = Color.FromArgb(38, 40, 39);
        //for panel lines
        public static Color darkPanellines = Color.FromArgb(38, 40, 39);


        //for buttons
        public static Color darkButtoncolor = Color.FromArgb(38, 40, 39);

    }
}
