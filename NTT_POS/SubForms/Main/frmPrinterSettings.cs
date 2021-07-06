using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.SubForms.Main
{
    public partial class frmPrinterSettings : Form
    {
        public frmPrinterSettings()
        {
            InitializeComponent();
            SetTheme();
        }
        public void SetTheme()
        {
            //Set theme
            Color selectedColor;
            if (Business.Globals.LightTheme)
            {
                selectedColor = Business.Globals.BackgroundThemeColorLight;

                //fonts
                label1.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnSave.BackColor = Business.Globals.lightButtoncolor;
                btnCancel.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;

                //font
                label1.ForeColor = Business.Globals.lightLabelcolor;
                //buttons
                btnSave.BackColor = Business.Globals.darkButtoncolor;
                btnCancel.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }

        #region Form Field Properties
        private string fPrintingStatus
        {
            get { return lblPrintingStatus.Text; }
            set { lblPrintingStatus.Text = value; }
        }
        #endregion

        private void ToggleButton()
        {
            if (fPrintingStatus == "OFF")
            {
                btnToggle.BackColor = Color.LimeGreen;
                btnToggle.Text = "ON";
                fPrintingStatus = "ON";
            }
            else
            {
                btnToggle.BackColor = Color.Tomato;
                btnToggle.Text = "OFF";
                fPrintingStatus = "OFF";
            }
        }

        private void SetValue(bool value) {
            if (value) {
                btnToggle.BackColor = Color.LimeGreen;
                fPrintingStatus = "ON";
            } else {
                btnToggle.BackColor = Color.Tomato;
                btnToggle.Text = "OFF";
                fPrintingStatus = "OFF";
            }
        
        }
        private void frmPrinterSettings_Load(object sender, EventArgs e)
        {
            var printerStatus = Business.Helpers.AppSettings.GetSetting("PrintStatus");
            if (printerStatus == "ON")
            {
                SetValue(true);
            }
            else {
                SetValue(false);
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            ToggleButton();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Helpers.MessageBoxHelper.ShowYesNoDialog(string.Format("Are you sure you want to turn printer status to {0}?",fPrintingStatus), "Confirmation"))
            {
                if (fPrintingStatus == "ON")
                {
                    Business.Helpers.AppSettings.SetSetting("PrintStatus", "ON");
                }
                else
                {
                    Business.Helpers.AppSettings.SetSetting("PrintStatus", "OFF");
                }

                Helpers.MessageBoxHelper.ShowInformationDialog("Printer Settings have been successfully updated.", "Success");
                this.Close();
            }
        }
    }
}
