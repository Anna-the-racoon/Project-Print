using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIforPrint.my
{
    class Class1
    {
        using System.Drawing.Printing;
using System.Windows.Forms;

namespace GWM.MES.App.SRC.ProductPlanList
    {
        /// <summary>
        /// Include work with printer and paper
        /// </summary>
        public class PrintService
        {
            /// <summary>
            /// Return names of printers with which the computer is connected to
            /// </summary>
            /// <param name="comboBoxChoosePrinter"></param>
            public void SelectedPrinter(ComboBox comboBoxChoosePrinter)
            {
                try
                {
                    var defaultPrinter = (new PrinterSettings()).PrinterName;
                    foreach (var printer in PrinterSettings.InstalledPrinters)
                    {
                        comboBoxChoosePrinter.Items.Add(printer);
                        if (printer.Equals(defaultPrinter))
                        {
                            comboBoxChoosePrinter.SelectedItem = printer;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show($"{Properties.Resources.String1313}");
                }
            }

            //проверить, меняется ли размер бумаги 

            /// <summary>
            /// Return types of paper with names agree with printer settings 
            /// </summary>
            /// <param name="comboBoxPageSize"></param>
            public void PageSize(ComboBox comboBoxPageSize)
            {
                try
                {
                    var settings = new PrinterSettings();
                    var defaultPaper = settings.DefaultPageSettings.PaperSize.PaperName;

                    foreach (PaperSize size in settings.PaperSizes)
                    {
                        comboBoxPageSize.Items.Add(size.PaperName);
                        if (size.Equals(defaultPaper))
                        {
                            comboBoxPageSize.SelectedItem = size;
                        }
                    }
                    comboBoxPageSize.SelectedItem = defaultPaper;
                }
                catch
                {
                    MessageBox.Show($"{Properties.Resources.String1313}");
                }
            }

            /// <summary>
            /// Return height of page size. Can be used in services for drawing templates
            /// </summary>
            /// <param name="landscapeOrientation"></param>
            /// <returns></returns>
            public int HeightSize(bool landscapeOrientation)
            {
                var settings = new PrinterSettings();
                int height;
                if (landscapeOrientation == true)
                {
                    height = settings.DefaultPageSettings.PaperSize.Width;
                }
                else
                {
                    height = settings.DefaultPageSettings.PaperSize.Height;
                }
                return height;
            }
            /// <summary>
            /// Return width of page size. Can be used in services for drawing templates
            /// </summary>
            /// <param name="landscapeOrientation"></param>
            /// <returns></returns>
            public int WidthSize(bool landscapeOrientation)
            {
                var settings = new PrinterSettings();
                int width;
                if (landscapeOrientation == true)
                {
                    width = settings.DefaultPageSettings.PaperSize.Height;
                }
                else
                {
                    width = settings.DefaultPageSettings.PaperSize.Width;
                }
                return width;
            }


            /// <summary>
            /// Пока в стадии доработки, скорее всего не пригодится 
            /// </summary>
            public void DuplexPrint()
            {
                //if (printCapabilites.CollationCapability.Contains(Collation.Collated))
                //{
                //    printTicket.Collation = Collation.Collated;
                //}

                //if (printCapabilites.DuplexingCapability.Contains(
                //        Duplexing.TwoSidedLongEdge))
                //{
                //    printTicket.Duplexing = Duplexing.TwoSidedLongEdge;
                //}

                //if (printCapabilites.StaplingCapability.Contains(Stapling.StapleDualLeft))
                //{
                //    printTicket.Stapling = Stapling.StapleDualLeft;
                //}
            }

        }
    }

}
}
