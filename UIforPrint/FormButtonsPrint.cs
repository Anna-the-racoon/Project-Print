using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using BusinessLogicForPrint;
using UIforPrint.FoxLean;
using UIforPrint.PrintFromDGV;
using Excel = Microsoft.Office.Interop.Excel;



namespace UIforPrint
{
    public partial class FormButtonsPrint : Form
    {
        public FormButtonsPrint()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //var printString = new ServicePrintString();
                //printString.PrintTheString();

                var printString = new PrintDocument();
                printString.PrintPage += PrintPageHandler;

                var printPrewiewDialog = new PrintPreviewDialog();
                var printDialog = new PrintDialog();
                printDialog.Document = printString;

                printDialog.Document = printString;


                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDialog.Document.Print();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show($"Произошла ошибка: {exception.Message}");
            }
        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            var text = new StringBuilder();
            text.AppendLine("Итак приступим к нашей пробе печати напрямую через Winforms.");
            text.AppendLine("Посмотрим, что из этого вообще получится....");


            e.Graphics.DrawString(text.ToString(), new Font("Arial", 14), Brushes.Black, 0, 0);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Произошла ошибка: {exception.Message}");
            }
        }

        private void buttonPrintOrders_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormDGFormExperimentalPrint();
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Произошла ошибка: {exception.Message}");
            }
        }

        private void buttonExcelInteropPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var excel = new Excel.Application();
                excel.Visible = true;
                excel.SheetsInNewWorkbook = 2;
                Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
                excel.DisplayAlerts = false;
                Excel.Worksheet sheet = (Excel.Worksheet)excel.Worksheets.get_Item(1);
                sheet.Name = $"Отчет за сегодня";
                for (int i = 1; i <= 9; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        sheet.Cells[i, j] = String.Format($"Boom {i} {j}");
                    }
                }

                sheet.PrintPreview(excel);

            }
            catch (Exception exception)
            { 
                MessageBox.Show($"Произошла ошибка: {exception.Message}");
            }
        }

        private void buttonOoInteropPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormFoxLean();
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Произошла ошибка: {exception.Message}");
            }
        }

        private void buttonPrintDoublePreview_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormFoxLean();
                form.MdiParent = this.MdiParent;
                form.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Произошла ошибка: {exception.Message}");
            }
        }
    }
}
