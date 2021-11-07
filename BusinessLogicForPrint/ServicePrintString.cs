using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace BusinessLogicForPrint
{
    public class ServicePrintString
    {

        public void PrintTheString()
        {
            try
            {
                var printString = new PrintDocument();
                printString.PrintPage += PrintPageHandler;

                var printDialog = new PrintDialog();
                printDialog.Document = printString;
               

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDialog.Document.Print();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);            
            }
        }

        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            var text = new StringBuilder();
            text.AppendLine("Итак приступим к нашей пробе печати напрямую через Winforms.");
            text.AppendLine("Посмотрим, что из этого вообще получится....");


            e.Graphics.DrawString(text.ToString(), new Font("Arial", 14), Brushes.Black, 0, 0);
        }
    }
}
