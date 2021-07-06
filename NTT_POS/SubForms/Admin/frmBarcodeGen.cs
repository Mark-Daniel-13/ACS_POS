using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace NTT_POS.SubForms.Admin
{
    public partial class frmBarcodeGen : Form
    {
        private string fBarcode {
            get { return tbBarcode.Text; }
            set { tbBarcode.Text = value; }
        }

        public frmBarcodeGen()
        {
            InitializeComponent();

            //Set theme
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
                label2.ForeColor = Business.Globals.darkLabelcolor;
                //buttons
                btnGenerate.BackColor = Business.Globals.lightButtoncolor;
                btnGetLatest.BackColor = Business.Globals.lightButtoncolor;
                btnDownload.BackColor = Business.Globals.lightButtoncolor;
            }
            else
            {
                selectedColor = Business.Globals.BackgroundThemeColor;
                
                //font
                label1.ForeColor = Business.Globals.lightLabelcolor;
                label2.ForeColor = Business.Globals.lightLabelcolor;
                //Buttons
                btnGenerate.BackColor = Business.Globals.darkButtoncolor;
                btnGetLatest.BackColor = Business.Globals.darkButtoncolor;
                btnDownload.BackColor = Business.Globals.darkButtoncolor;
            }
            //Background Color
            BackColor = selectedColor;
        }
        private void LoadNewBarcode() {
            fBarcode= Business.Helpers.BarcodeHelper.GenerateNewBarcode();
            generateBarcodeImage();
        }

        private void frmBarcodeGen_Load(object sender, EventArgs e)
        {
            LoadNewBarcode();
        }
        private void generateBarcodeImage() {
            var writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.CODE_128;
            writer.Options = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 150,
            };

            Image img = writer.Write(fBarcode);
            pbBarcode.Image = img;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var msg = "";
            if (Business.Helpers.BarcodeHelper.CheckFormat(fBarcode, out msg))
            {
                generateBarcodeImage();
            }
            else {
                Helpers.MessageBoxHelper.ShowErrorDialog(msg);
            }
        }
        private void btnGetLatest_Click(object sender, EventArgs e)
        {
            LoadNewBarcode();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (pbBarcode.Image != null)
            {
                using (var folderPath = new SaveFileDialog())
                {
                    folderPath.Filter = "PNG File | *.png";
                    if (folderPath.ShowDialog() == DialogResult.OK)
                    {
                       pbBarcode.Image.Save(folderPath.FileName, System.Drawing.Imaging.ImageFormat.Png);

                        //If barcode is unused barcode add to barcode log table
                        //if (Business.Facades.Products.GetByBarcode(fBarcode) == null)
                        //{
                        //    var barcodeModel = new Business.Models.Barcode()
                        //    {
                        //        BarcodeText = fBarcode,
                        //    };
                        //    Business.Facades.Barcode.AddBarcode(barcodeModel);
                        //}
                        Helpers.MessageBoxHelper.ShowInformationDialog("Image successfully downloaded.", "Success");
                        LoadNewBarcode();
                    }

                }
            }
            else {
                Helpers.MessageBoxHelper.ShowErrorDialog("Please generate a barcode first.");
            }
        }

        private void FrmBarcodeGen_Resize(object sender, EventArgs e)
        {
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
        }
    }
}
