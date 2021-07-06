using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace NTT_POS.Helpers
{
    public class SilentPrint
    {
        private ViewModels.TransactionViewModel transaction { get; set; }
        private List<ViewModels.TransactionDetailsViewModel> transactionDetails { get; set; }
        private Business.Models.CompanyBranchDetails compDetails;
        private bool includeProvider;
        public  bool Print(ViewModels.TransactionViewModel trans,List<ViewModels.TransactionDetailsViewModel> transDetail, Business.Models.CompanyBranchDetails comp = null,bool includePOSProvider = true) {
            try
            {
                transaction = trans;
                transactionDetails = transDetail;
                includeProvider = includePOSProvider;
                var receipt = new PrintDocument();
                //size is equal to inch
                //Rawkind of values int 49 || 49 is set to custom
                //2.68 inch = 68mm

                receipt.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.Custom;
                PaperSize ps = new PaperSize();
                ps.Width = 2; //set papersize on inches
                receipt.DefaultPageSettings.PaperSize = ps;
                if (comp == null)
                {
                    compDetails = null;
                }
                else {
                    compDetails = comp;
                    
                }
                receipt.PrintPage += new PrintPageEventHandler(PrintPageWithDetails);
                receipt.Print();

                return true;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void PrintPageWithDetails(object sender, PrintPageEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            StringFormat sf = new StringFormat();
            //sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            int startX = 20;
            int startY = 0;
            int Offset = 20;
            
            string mainFont = "Courier New";
            string underlineFont = "Courier New";
            string newstring;
           

            int pixelSize = 140;
            int dynamicStringYaxis = 150;
            //Company Name HEADER
            if (compDetails != null)
            {
                var compName = TextboxHelper.WrapText(compDetails.BranchName, pixelSize, mainFont,10);
                newstring = string.Join("\n", compName);
                graphics.DrawString(newstring,
                            new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), dynamicStringYaxis, startY + Offset,sf);
                compName.ForEach(c => {
                    Offset = Offset + 15;
                });
                var compAddress = TextboxHelper.WrapText(compDetails.Address, pixelSize, mainFont, 10);
                newstring = string.Join("\n", compAddress);
                graphics.DrawString(newstring,
                            new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), dynamicStringYaxis, startY + Offset,sf);

                compAddress.ForEach(c => {
                    Offset = Offset + 15;
                });
                if (!string.IsNullOrEmpty(compDetails.TinNo) && compDetails.TinNo != null)
                {
                    var TinList = TextboxHelper.ConvertStringOfTinList(TextboxHelper.ConvertTINWithDash(compDetails.TinNo));
                    var Tin = TextboxHelper.WrapText("TIN# "+ TinList, pixelSize, mainFont, 10);
                    newstring = string.Join("\n", Tin);
                    graphics.DrawString(newstring,
                                new Font(mainFont, 9),
                                new SolidBrush(System.Drawing.Color.Black), dynamicStringYaxis, startY + Offset, sf);
                    Tin.ForEach(c =>
                    {
                        Offset = Offset + 15;
                    });
                }
            }
            Offset = Offset + 20;
            graphics.DrawString("Cashier Name:" + transaction.UserName,
                        new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            Offset = Offset + 15;

            graphics.DrawString("Bill Date :" + transaction.CreationDate.ToString(),
                        new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            Offset = Offset + 15;

            graphics.DrawString("Receipt Number:" + transaction.ReceiptNumber,
                        new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            Offset = Offset + 15;

            graphics.DrawString("Customer Name:" + transaction.CustomerName,
            new Font(mainFont, 9),
            new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            Offset = Offset + 20;

            String underLine = "---------------------------";
            graphics.DrawString(underLine, new Font(underlineFont, 14),
                        new SolidBrush(System.Drawing.Color.Black), 0, startY + Offset);

            Offset = Offset + 10;
            graphics.DrawString(underLine, new Font(underlineFont, 14),
                       new SolidBrush(System.Drawing.Color.Black), 0, startY + Offset);

            var totalPrice = 0.00;
            var totalItems = 0.00;
            foreach (ViewModels.TransactionDetailsViewModel trans in transactionDetails)
            {
                Offset = Offset + 30;
                var itemName = TextboxHelper.WrapText(trans.ProductName.ToString(), 50, mainFont, 8);
                newstring = string.Join("\n", itemName);
                graphics.DrawString(newstring, new Font(mainFont, 8),
                         new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
                itemName.ForEach(item => {
                    Offset = Offset + 20;
                });
                
                graphics.DrawString(trans.Quantity.ToString(), new Font(mainFont, 8), //QUANTITY
                         new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
                graphics.DrawString(string.Format("@{0}", trans.RetailPrice.ToString()), new Font(mainFont, 8),
                         new SolidBrush(System.Drawing.Color.Black), 130, startY + Offset); //RETAIL PRICE
                graphics.DrawString(trans.TotalPrice.ToString(), new Font(mainFont, 8),
                         new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset); // TOTAL PRICE

                totalPrice += trans.TotalPrice;
                totalItems += trans.Quantity;
            }
            var amountDue = totalPrice - transaction.DiscountAmount;

            Offset = Offset + 20;

            underLine = "---------------------------";
            graphics.DrawString(underLine, new Font(underlineFont, 14),
                        new SolidBrush(System.Drawing.Color.Black), 0, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Total Items: ", new Font(mainFont, 11),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
            graphics.DrawString(string.Format("{0} Items", totalItems.ToString()), new Font(mainFont, 11),
                        new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("SubTotal: ", new Font(mainFont, 11),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
            graphics.DrawString(totalPrice.ToString(), new Font(mainFont, 11),
                        new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);

            if (transaction.DiscountAmount != 0)
            {
                var discountText = string.Format("{0}", transaction.DiscountAmount);
                Offset = Offset + 20;
                graphics.DrawString("Discount: ", new Font(mainFont, 11),
                            new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
                graphics.DrawString(discountText, new Font(mainFont, 11),
                            new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);
            }

            Offset = Offset + 10;

            graphics.DrawString(underLine, new Font("Courier New", 14),
                        new SolidBrush(System.Drawing.Color.Black), 0, startY + Offset);


            Offset = Offset + 20;
            graphics.DrawString("Amount Due: ", new Font(mainFont, 12, FontStyle.Bold),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
            graphics.DrawString(amountDue.ToString("0.00"), new Font(mainFont, 12, FontStyle.Bold),
                            new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Cash Peso: ", new Font(mainFont, 11),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
            graphics.DrawString(transaction.PaymentAmount.ToString(), new Font(mainFont, 11),
                            new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);

            var change = transaction.PaymentAmount - amountDue;
            Offset = Offset + 20;
            graphics.DrawString("Change: ", new Font(mainFont, 12,FontStyle.Bold),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
            graphics.DrawString(change.ToString("0.00"), new Font(mainFont, 12, FontStyle.Bold),
                            new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);

            Offset = Offset + 20;


            graphics.DrawString(underLine, new Font(underlineFont, 14),
                        new SolidBrush(System.Drawing.Color.Black), 0, startY + Offset);
            Offset = Offset + 10;
            graphics.DrawString(underLine, new Font(underlineFont, 14),
                       new SolidBrush(System.Drawing.Color.Black), 0, startY + Offset);
            Offset = Offset + 30;


            //FOOTER POS dev details
            if (includeProvider)
            {
                graphics.DrawString("POS Provider: ", new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
                Offset = Offset + 15;

                graphics.DrawString("NORTH TRIAM TECH CORPORATION",
                            new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

                Offset = Offset + 15;
                graphics.DrawString("Tuguegarao City Cagayan",
                            new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("TIN: 000-000-000-000",
                            new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
                Offset = Offset + 15;
                graphics.DrawString("Accred No: 000-000000-000000",
                            new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

                Offset = Offset + 30;


                var validityString = TextboxHelper.WrapText("THIS INVOICE/RECEIPT SHALL BE VALID FOR FIVE (5) YEARS FROM THE DATE OF PERMIT TO USE.", pixelSize, mainFont, 10);
                newstring = string.Join("\n", validityString);
                graphics.DrawString(newstring,
                            new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), dynamicStringYaxis, startY + Offset, sf);
                validityString.ForEach(s =>
                {
                    Offset = Offset + 15;
                });

                graphics.DrawString("OFFICIAL RECEIPT",
                            new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), dynamicStringYaxis, startY + Offset, sf);
                Offset = Offset + 15;
            }
            graphics.DrawString("THANK YOU COME AGAIN!!!",
                        new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), dynamicStringYaxis, startY + Offset,sf);

        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {

            Graphics graphics = e.Graphics;
            Font font = new Font("Arial Bold", 10);

            int startX = 0;
            int startY = 0;
            int Offset = 0;
            string mainFont = "Arial Bold";
            string underlineFont = "Courier New";

            graphics.DrawString("Customer Name:" + transaction.CustomerName,
                        new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
            
            Offset = Offset + 20;

            graphics.DrawString("Receipt Number:" + transaction.ReceiptNumber,
                        new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            Offset = Offset + 20;

            graphics.DrawString("Bill Date :" + transaction.CreationDate.ToString(),
                        new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            Offset = Offset + 20;

            graphics.DrawString("Cashier Name:" + transaction.UserName,
                        new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            String underLine = "---------------------------";
            graphics.DrawString(underLine, new Font(underlineFont, 14),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            Offset = Offset + 10;
            graphics.DrawString(underLine, new Font(underlineFont, 14),
                       new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            var totalPrice = 0.00;
            var totalItems = 0.00;
            foreach (ViewModels.TransactionDetailsViewModel trans in transactionDetails)
            {
                Offset = Offset + 30;
                var itemName = TextboxHelper.WrapText(trans.ProductName.ToString(),50, mainFont,8);
                var newstring = string.Join("\n", itemName);
                graphics.DrawString(newstring, new Font(mainFont, 8),
                         new SolidBrush(System.Drawing.Color.Black), 20, startY + Offset);

                Offset = Offset + 40;
                graphics.DrawString(trans.Quantity.ToString(), new Font(mainFont, 8), //QUANTITY
                         new SolidBrush(System.Drawing.Color.Black), 20, startY + Offset);
                graphics.DrawString(string.Format("@{0}", trans.RetailPrice.ToString()), new Font(mainFont, 8),
                         new SolidBrush(System.Drawing.Color.Black), 130, startY + Offset); //RETAIL PRICE
                graphics.DrawString(trans.TotalPrice.ToString(), new Font(mainFont, 8),
                         new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset); // TOTAL PRICE
                
                totalPrice += trans.TotalPrice;
                totalItems += trans.Quantity;
            }
            var amountDue = totalPrice - transaction.DiscountAmount;

            Offset = Offset + 20;

            underLine = "---------------------------";
            graphics.DrawString(underLine, new Font(underlineFont, 14),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Total Items: ", new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), 20, startY + Offset);
            graphics.DrawString(string.Format("{0} Items", totalItems.ToString()), new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("SubTotal: ", new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), 20, startY + Offset);
            graphics.DrawString(totalPrice.ToString(), new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);

            if (transaction.DiscountAmount != 0)
            {
                var discountText = string.Format("{0}",transaction.DiscountAmount);
                Offset = Offset + 20;
                graphics.DrawString("Discount: ", new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), 20, startY + Offset);
                graphics.DrawString(discountText, new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);
            }

            Offset = Offset + 10;

            graphics.DrawString(underLine, new Font("Courier New", 14),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);


            Offset = Offset + 20;
            graphics.DrawString("Amount Due: ", new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), 20, startY + Offset);
            graphics.DrawString(amountDue.ToString("0.00"), new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Cash Peso: ", new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), 20, startY + Offset);
            graphics.DrawString(transaction.PaymentAmount.ToString(), new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);

            var change = transaction.PaymentAmount - amountDue;
            Offset = Offset + 20;
            graphics.DrawString("Change: ", new Font(mainFont, 9),
                        new SolidBrush(System.Drawing.Color.Black), 20, startY + Offset);
            graphics.DrawString(change.ToString("0.00"), new Font(mainFont, 9),
                            new SolidBrush(System.Drawing.Color.Black), 200, startY + Offset);

            Offset = Offset + 20;

            //underLine = "---------THANK YOU---------";
            //graphics.DrawString(underLine, new Font(mainFont, 14),
            //            new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);


            graphics.DrawString(underLine, new Font(underlineFont, 14),
                        new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
            Offset = Offset + 10;
            graphics.DrawString(underLine, new Font(underlineFont, 14),
                       new SolidBrush(System.Drawing.Color.Black), startX, startY + Offset);
        }
    }
}
