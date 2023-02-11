using BarcodeLib;
using RawDataPrint;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_BB.CodeFiles
{
    class ZabraPrinter
    {

        private string name;
        private string barcode;
        private string price;

        public ZabraPrinter(string na, string br, string pr)
        {
            name = na;
            barcode = br;
            price = pr;
        }
        public void print(string quantity)
        {
            int length = 0;
            length = barcode.Length;
            var sb = new StringBuilder();
            PrintDialog pd = new PrintDialog();
            pd.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
           // for (int i = 0; i < length; i++)
          //  {
                sb.AppendLine();
                sb.AppendLine("N");
                sb.AppendLine("q831"); //wirth of label
                sb.AppendLine("Q203,024"); //Length of label
            sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A140,10,0,4,1,1,N,\"{0}\"", "B&B Garments"));



            if (length == 13)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B85,40,0,1A,1,1,40,B,\"{0}\"", barcode));
            }
            else if (length == 12)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B90,40,0,1A,1,1,50,B,\"{0}\"", barcode));
            }
            else if (barcode.Length == 11)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B85,40,0,1A,1,1,50,B,\"{0}\"", barcode));
            }
            else if (barcode.Length == 10)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B85,40,0,1A,1,1,50,B,\"{0}\"", barcode));
            }
            else if (barcode.Length == 9)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B82,40,0,1A,2,2,50,B,\"{0}\"", barcode));
            }
            else if (barcode.Length == 8)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B85,40,0,1A,2,3,50,B,\"{0}\"", barcode));
            }
            else if (barcode.Length == 7)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B85,40,0,1A,2,3,50,B,\"{0}\"", barcode));
            }
            else if (barcode.Length == 6)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B85,40,0,1A,2,3,50,B,\"{0}\"", barcode));
            }
            else if (barcode.Length == 5)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B85,40,0,1A,2,3,50,B,\"{0}\"", barcode));
            }
            else if (barcode.Length == 4)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B85,40,0,1A,2,3,50,B,\"{0}\"", barcode));
            }
            else if (barcode.Length == 3)
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B85,40,0,1A,2,3,50,B,\"{0}\"", barcode));
            }
            else
            {
                sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "B85,40,0,1A,2,3,50,B,\"{0}\"", barcode));
            }

            sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A85,130,0,4,1,1,N,\"{0}\"", name));
            sb.AppendLine(string.Format(CultureInfo.InvariantCulture, "A220,160,0,4,1,1,N,\"{0}\"", "Rs: " + price));
            string print = "P" + quantity;
                sb.AppendLine(print);
                //RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, sb.ToString());

                RawPrinterHelper.SendStringToPrinter("ZDesigner LP 2824", sb.ToString());
            //}
        }
    }
}
