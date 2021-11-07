using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Printing;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
//using BusinessLogicForPrint;
//using PagedList;

namespace UIforPrint.PrintFromDGV
{
    public partial class FormPreviewPrintPage : Form
    {
        private int currentPage = 1;
        private readonly DataGridView dataGridView;

        public FormPreviewPrintPage(DataGridView dataGridView)
        {
            InitializeComponent();
            //InitializePrintPreviewControl();
            SelectedPrinter();
            this.dataGridView = dataGridView;
        }
        private void SelectedPrinter()
        {
            String defaultPrinter = (new System.Drawing.Printing.PrinterSettings()).PrinterName;
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                comboBoxChoosePrinter.Items.Add(printer);
                if (printer.Equals(defaultPrinter))
                {
                    comboBoxChoosePrinter.SelectedItem = printer;
                }
            }
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

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //ориентация
                if (radioButtonLandscapeOrientation.Checked)
                {
                    this.printDocumentMaterials.DefaultPageSettings.Landscape = radioButtonLandscapeOrientation.Checked;
                }
                //прописать 
                //количество копий
                for (int copie = 0; copie < numericUpDownCopies.Value; copie++)
                {
                    //печать с выбранного принтера
                    this.printDocumentMaterials.PrinterSettings.PrinterName = comboBoxChoosePrinter.SelectedItem.ToString();
                    //вывод на печать
                    printDocumentMaterials.Print();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //прописать подключение к grid-у
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            var pen = new Pen(Color.Black);
            //Graphics formGraphics = this.CreateGraphics();
            e.Graphics.DrawRectangle(pen, new Rectangle(50, 50, 720, 1050));



            //var printString = new PrintDocument();
            //printString.PrintPage += PrintPageHandler;


            //FormPreviewPrintPage_Load(sender, e);
            //this.printPreviewControl.InvalidatePreview();

            //var bitmapDgv = new FormDGFormExperimentalPrint();
            //bitmapDgv.bitmapDocumentMaterials();

            //временная заглушка со строкой
            var text = new StringBuilder();
            text.AppendLine("Итак приступим к нашей пробе печати напрямую через Winforms.\n Посмотрим, что из этого вообще получится....");

            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            Graphics graphics = e.Graphics;

            //graphics.DrawString("Page" + this.currentPage, font, Brushes.Black, 10, 20);
            //this.currentPage++;

            var fontForString = new Font("Arial", 14, FontStyle.Regular);
            e.Graphics.DrawString(text.ToString(), fontForString, Brushes.Black, 60, 80);

            //int height = dataGridViewMaterials.Height;
            //dataGridViewMaterials.Height = dataGridViewMaterials.RowCount * dataGridViewMaterials.RowTemplate.Height;
        }

        //пустое
        //private void FormPreviewPrintPage_Load(object sender, EventArgs e)
        //{
        //    var printString = new PrintDocument();
        //    printString.PrintPage += PrintPageHandler;

        //    //printString.PrintPage += PrintPageHandler(sender, e);
        //}

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(dataGridView.Size.Width + 10, dataGridView.Size.Height + 10);
            dataGridView.DrawToBitmap(bmp, dataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }


        //
        //private Bitmap PrintPageHandler(object sender, PrintPageEventArgs e)
        //{
        //    var graphic = dataGridView.CreateGraphics();
        //    var width = dataGridView.Width;
        //    var height = dataGridView.Height;
        //    var bitmap = new Bitmap(width, height, graphic);
        //    return bitmap;
        //}

        private void numericUpDownCopies_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownCopies.Value > 1)
            {
                checkBoxCollateCopies.Enabled = true;
            }
            else
            {
                checkBoxCollateCopies.Enabled = false;

            }
        }

        private void radioButtonPortraitOrientation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPortraitOrientation.Checked)
            {
                this.printDocumentMaterials.DefaultPageSettings.Landscape = false;
                this.printPreviewControl.InvalidatePreview();
                this.printPreviewControl.AutoZoom = true;                  
            }
        }

        private void radioButtonLandscapeOrientation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLandscapeOrientation.Checked)
            {
                this.printDocumentMaterials.DefaultPageSettings.Landscape = true;
                this.printPreviewControl.InvalidatePreview();
                this.printPreviewControl.AutoZoom = true;
            }
        }

        private void checkBoxDuplexPrint_CheckedChanged(object sender, EventArgs e)
        {

            //активирует варианты печати двусторонним вариантом
            if (checkBoxDuplexPrint.Checked)
            {
                comboBoxDuplexPrint.Enabled = true;
            }

        }

        private void comboBoxDuplexPrint_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrintQueue printQueue = null;
            // Get default PrintTicket from printer
            PrintTicket printTicket = printQueue.DefaultPrintTicket;

            PrintCapabilities printCapabilites = printQueue.GetPrintCapabilities();

            // Modify PrintTicket
            if (printCapabilites.CollationCapability.Contains(Collation.Collated))
            {
                printTicket.Collation = Collation.Collated;
            }

            if (printCapabilites.DuplexingCapability.Contains(Duplexing.TwoSidedLongEdge))
            {
                printTicket.Duplexing = Duplexing.TwoSidedLongEdge;
            }

            if (printCapabilites.StaplingCapability.Contains(Stapling.StapleDualLeft))
            {
                printTicket.Stapling = Stapling.StapleDualLeft;
            }
        }

        private void buttonPrintOptions_Click(object sender, EventArgs e)
        {
            printDialogMaretials.ShowDialog();
        }

    }
}
