using System;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
//using Microsoft

namespace UIforPrint.ExcelInteriorPrint
{
    public partial class FormInteropExcelPrint : Form
    {
        public FormInteropExcelPrint()
        {
            InitializeComponent();
        }

        private void FormInteropExcelPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersdbDSOrders.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.usersdbDSOrders.Orders);
        }

        private void toolStripButtonCancel_Click(object sender, EventArgs e)
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

        private void dataGridViewOrders_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.P)
            {
                toolStripButtonPrint_Click(this.toolStripButtonPrint, EventArgs.Empty);
            }
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
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
    }
}
