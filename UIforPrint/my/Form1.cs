using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIforPrint.my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using FlexCell;
            using System;
            using System.Collections.Generic;
            using System.ComponentModel;
            using System.Data;
            using System.Drawing;
            using System.Drawing.Imaging;
            using System.Drawing.Printing;
            using System.Linq;
            using System.Printing;
            using System.Text;
            using System.Web.UI.WebControls;
            using System.Windows.Forms;
            using static System.Math;


namespace GWM.MES.App.SRC.ProductPlanList
    {
        public partial class PrintForm : Form
        {
            public DataGridView dataGridView;
            private string planNumber;
            private string workshop;

            PrintService printService;
            int pageHeight;
            int pageWeight;
            private int pageNumber;
            private DataGridViewRow rowTextNumber;

            public PrintForm(DataGridView dataGridView, string planNumber, string workshop)
            {
                InitializeComponent();
                this.dataGridView = dataGridView;
                this.planNumber = planNumber;
                this.workshop = workshop;

                //printService = new PrintService();
                //pageHeight = printService.HeightSize(radioButtonLandscapeOrientation.Checked);
                //pageWeight = printService.WidthSize(radioButtonLandscapeOrientation.Checked);
            }

            //done
            private void PrintForm_Load(object sender, EventArgs e)
            {
                if (Statics.language != "")
                {
                    MultiLanguage.LoadLanguage(Statics.language, this);
                }
                var print = new PrintService();
                print.SelectedPrinter(comboBoxChoosePrinter);
                print.PageSize(comboBoxPageSize);
                if (workshop == "Цех сборки")
                {
                    radioButtonLandscapeOrientation.Checked = true;
                }
                this.printPreviewControlPrintDetail.Zoom = 0.75;
                pageNumber = 1;
            }

            //done
            private void buttonClose_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            //done
            private void numericUpDownCopies_ValueChanged(object sender, EventArgs e)
            {
                if (numericUpDownCopies.Value > 1)
                {
                    checkBoxCollateCopies.Enabled = true;
                }
                else
                {
                    checkBoxCollateCopies.Enabled = false;
                    checkBoxCollateCopies.Checked = false;
                }
            }

            //
            private void comboBoxPageSize_SelectedIndexChanged(object sender, EventArgs e)
            {
                this.printPreviewControlPrintDetail.InvalidatePreview();
            }
            //done
            private void trackBarZoom_MouseUp(object sender, MouseEventArgs e)
            {
                try
                {
                    this.printPreviewControlPrintDetail.Zoom = (float)trackBarZoom.Value / 100;
                    this.printPreviewControlPrintDetail.InvalidatePreview();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"{Properties.Resources.String1313}\n" + exception.Message);
                }
            }

            //done
            #region Orientation
            //done
            private void radioButtonPortraitOrientation_CheckedChanged(object sender, EventArgs e)
            {
                this.printDocumentPlanDetail.DefaultPageSettings.Landscape = false;
                this.printPreviewControlPrintDetail.InvalidatePreview();
            }
            //done
            private void radioButtonLandscapeOrientation_CheckedChanged(object sender, EventArgs e)
            {
                this.printDocumentPlanDetail.DefaultPageSettings.Landscape = true;
                this.printPreviewControlPrintDetail.InvalidatePreview();
            }
            #endregion
            //done
            #region Page fields
            //done
            private void radioButtonCustomizable_CheckedChanged(object sender, EventArgs e)
            {
                if (radioButtonCustomizable.Checked)
                {
                    groupBoxCustomizeField.Enabled = true;
                }
                else
                {
                    groupBoxCustomizeField.Enabled = false;
                }
            }
            //done
            private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
            {
                if (radioButtonRegular.Checked)
                {
                    textBoxTop.Text = "2";
                    textBoxBottom.Text = "2";
                    textBoxLeft.Text = "3";
                    textBoxRight.Text = "2";
                    this.printPreviewControlPrintDetail.InvalidatePreview();
                }
            }
            //done
            private void radioButtonNarrow_CheckedChanged(object sender, EventArgs e)
            {
                if (radioButtonNarrow.Checked)
                {
                    textBoxTop.Text = "1";
                    textBoxBottom.Text = "1";
                    textBoxLeft.Text = "1";
                    textBoxRight.Text = "1";
                    this.printPreviewControlPrintDetail.InvalidatePreview();
                }
            }
            //done
            private void radioButtonWide_CheckedChanged(object sender, EventArgs e)
            {
                if (radioButtonWide.Checked)
                {
                    textBoxTop.Text = "2";
                    textBoxBottom.Text = "2";
                    textBoxLeft.Text = "5";
                    textBoxRight.Text = "5";
                    this.printPreviewControlPrintDetail.InvalidatePreview();
                }
            }
            //done
            private void buttonApply_Click(object sender, EventArgs e)
            {
                try
                {
                    this.printPreviewControlPrintDetail.InvalidatePreview();
                }
                catch
                {
                    MessageBox.Show($"{Properties.Resources.String1313}");
                }
            }
            #endregion

            //двусторонняя печать и несколько страниц
            //сделать функционал печати постранично
            private void buttonPrint_Click(object sender, EventArgs e)
            {
                try
                {
                    //ориентация
                    if (radioButtonLandscapeOrientation.Checked)
                    {
                        this.printDocumentPlanDetail.DefaultPageSettings.Landscape = radioButtonLandscapeOrientation.Checked;
                    }

                    //копии
                    if (numericUpDownCopies.Value > 1)
                    {
                        for (int copie = 0; copie < numericUpDownCopies.Value; copie++)
                        {
                            this.printDocumentPlanDetail.PrinterSettings.PrinterName = comboBoxChoosePrinter.SelectedItem.ToString();
                            this.printDocumentPlanDetail.PrinterSettings.DefaultPageSettings.PaperSize.PaperName = comboBoxPageSize.SelectedItem.ToString();
                            var printPage = new PrintDocument();
                            printPage.PrintPage += new PrintPageEventHandler(printDocumentPlanDetail_PrintPage);
                            printDocumentPlanDetail.Print();
                        }
                    }
                    else
                    {
                        this.printDocumentPlanDetail.PrinterSettings.PrinterName = comboBoxChoosePrinter.SelectedItem.ToString();
                        this.printDocumentPlanDetail.PrinterSettings.DefaultPageSettings.PaperSize.PaperName = comboBoxPageSize.SelectedItem.ToString();
                        var printPage = new PrintDocument();
                        printPage.PrintPage += new PrintPageEventHandler(printDocumentPlanDetail_PrintPage);
                        printDocumentPlanDetail.Print();
                    }
                }
                catch
                {
                    MessageBox.Show($"{Properties.Resources.String1313}");
                }
            }

            public void printDocumentPlanDetail_PrintPage(object sender, PrintPageEventArgs e)
            {
                //PrintPageHandler(sender, e);
                //считываем размеры поля 
                int fieldTop = (int)Round(float.Parse(textBoxTop.Text) * 37.938);
                int fieldBottom = (int)Round(pageHeight - fieldTop - (float.Parse(textBoxBottom.Text) * 37.938));
                int fieldLeft = (int)Round(float.Parse(textBoxTop.Text) * 37.938);
                int fieldRight = (int)Round(pageWeight - fieldLeft - (float.Parse(textBoxTop.Text) * 37.938));

                var textTop = fieldTop;
                var textLeft = fieldLeft;

                var fieldPen = new Pen(Color.White);

                try
                {
                    e.Graphics.DrawRectangle(fieldPen, new Rectangle(fieldLeft, fieldTop, fieldRight, fieldBottom));

                    var text = $"План {workshop} {planNumber}/ Welding {workshop} {planNumber}";
                    var fontForString = new Font("Calibri", 12, FontStyle.Bold);
                    e.Graphics.DrawString(text.ToString(), fontForString, Brushes.Black, textTop, textLeft);

                    switch (workshop)
                    {
                        case "Цех сварки F7":
                            /*tepmlate.*/
                            SwFShopPlanTemplate(sender, e, fieldTop, fieldBottom, fieldLeft, fieldRight);
                            e.HasMorePages = false;
                            break;
                        case "Цех сварки H9":
                            //tepmlate.
                            SwHShopPlanTemplate(sender, e, fieldTop, fieldBottom, fieldLeft, fieldRight);
                            e.HasMorePages = false;
                            break;
                        case "Цех окраски":
                            //tepmlate.
                            PaintShopPlanTemplate(sender, e, fieldTop, fieldBottom, fieldLeft, fieldRight);
                            e.HasMorePages = false;
                            break;
                        case "Цех сборки":
                            //tepmlate.
                            AssamblyShopPlanTemplate(sender, e, fieldTop, fieldBottom, fieldLeft, fieldRight);
                            e.HasMorePages = false;
                            break;

                        default:
                            break;
                    }
                }
                catch
                {
                    MessageBox.Show($"{Properties.Resources.String1313}");
                }

            }


            /// <summary>
            /// Draw template for SW for F7 and F7x
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// <param name="top"></param>
            /// <param name="botom"></param>
            /// <param name="left"></param>
            /// <param name="right"></param>
            public void SwFShopPlanTemplate(object sender, PrintPageEventArgs e, int top, int botom, int left, int right)
            {
                //string[] coloumnName = new string[] { ($"  Номер\n  по порядку\n  /Sequence\n number"),//0
                //($"  Номер\n  кузова\n  /Car number"), // 1
                //($"VIN"),   //2
                //($"Конфигурация\n/Configuration"),   //3
                //($"Тип крыши\n/Roof type"),  //4
                //($"Тип привода\n/Drive type"),   //5
                //($"Номер заказа\n/Batch"),   //6
                //($"Бренд\n/Model")}; //7

                //var coloumnNumber = coloumnName.Count();
                //var headerTop = top + 40;
                //var headerBottom = 70;
                //var headerLeft = left;
                //var headerRight = right / coloumnNumber;
                //var increase = right / coloumnNumber;
                //var headerTextLeft = left;

                //var pen = new Pen(Color.Black);

                //try
                //{

                //    for (int rectangle = 0; rectangle < coloumnNumber; rectangle++)
                //    {
                //        e.Graphics.DrawRectangle(pen, headerLeft, headerTop, headerRight, headerBottom);
                //        headerLeft += increase;
                //    }


                //    var fontForString = new Font("Calibri", 10, FontStyle.Bold);
                //    for (int headerText = 0; headerText < coloumnNumber; headerText++)
                //    {
                //        e.Graphics.DrawString(coloumnName[headerText].ToString(), fontForString, Brushes.Black, headerTextLeft, headerTop);
                //        headerTextLeft += increase;
                //    }


                //    var tableTop = headerTop + headerBottom;
                //    var tableBottom = dataGridView.CurrentRow.Height;
                //    var tableLeft = left;
                //    var tableRight = right / coloumnNumber;
                //    var increaseHeight = dataGridView.CurrentRow.Height;


                //    if (pageNumber == 1)
                //    {
                //        rowNumber = 0;
                //    }

                //    for (int row = rowNumber; row < dataGridView.Rows.Count; row++)
                //    {
                //        if (tableTop > botom)
                //        {
                //            e.HasMorePages = true;
                //            tableTop = top;
                //            rowNumber = row;
                //            pageNumber++;
                //            this.printDocumentPlanDetail.PrintPage += new PrintPageEventHandler(printDocumentPlanDetail_PrintPage);

                //        }
                //        for (int coloumn = 0; coloumn < coloumnNumber; coloumn++)
                //        {
                //            e.Graphics.DrawRectangle(pen, tableLeft, tableTop, tableRight, tableBottom);
                //            tableLeft += increase;
                //        }
                //        tableTop += increaseHeight;
                //        tableLeft = left;
                //        e.HasMorePages = false;
                //    }

                //    var rows = dataGridView.Rows.Cast<DataGridViewRow>().ToList();
                //    var tableTextTop = headerTop + headerBottom;
                //    var tableTextLeft = left;
                //    var fontText = new Font("Calibri", 8, FontStyle.Bold);
                //    var fontLongText = new Font("Calibri", 6, FontStyle.Bold);

                //    foreach (var row in rows)
                //    {

                //        var serialNumber = row.Cells["pDAYSEQUENCEDataGridViewTextBoxColumn"].Value.ToString();
                //        var carNumber = row.Cells["cCARNODataGridViewTextBoxColumn"].Value.ToString();
                //        var vin = row.Cells["cVINNODataGridViewTextBoxColumn"].Value.ToString();
                //        var configuration = row.Cells["cCONFIGURATIONDataGridViewTextBoxColumn"].Value.ToString();
                //        var skylight = row.Cells["cSKYLIGHTDataGridViewTextBoxColumn"].Value.ToString();
                //        var drive = row.Cells["cDRIVEDataGridViewTextBoxColumn"].Value.ToString();
                //        var orderNumber = row.Cells["pORDERIDDataGridViewTextBoxColumn"].Value.ToString();
                //        var brand = row.Cells["cBRANDDataGridViewTextBoxColumn"].Value.ToString();

                //        e.Graphics.DrawString(serialNumber, fontText, Brushes.Black, tableTextLeft, tableTextTop);
                //        e.Graphics.DrawString(carNumber, fontText, Brushes.Black, tableTextLeft + increase, tableTextTop);
                //        e.Graphics.DrawString(vin, fontLongText, Brushes.Black, tableTextLeft + increase * 2, tableTextTop);
                //        e.Graphics.DrawString(configuration, fontText, Brushes.Black, tableTextLeft + increase * 3, tableTextTop);
                //        e.Graphics.DrawString(skylight, fontText, Brushes.Black, tableTextLeft + increase * 4, tableTextTop);
                //        e.Graphics.DrawString(drive, fontText, Brushes.Black, tableTextLeft + increase * 5, tableTextTop);
                //        e.Graphics.DrawString(orderNumber, fontText, Brushes.Black, tableTextLeft + increase * 6, tableTextTop);
                //        e.Graphics.DrawString(brand, fontText, Brushes.Black, tableTextLeft + increase * 7, tableTextTop);

                //        tableTextTop += increaseHeight;

                //    }
                //}
                //catch (Exception exception)
                //{
                //    MessageBox.Show(exception.Message);
                //}
            }
            public void SwHShopPlanTemplate(object sender, PrintPageEventArgs e, int top, int botom, int left, int right)
            {
                //string[] coloumnName = new string[] { ($"  Номер\n  по порядку\n  /Sequence\n number"),//0
                //($"  Номер\n  кузова\n  /Car number"), // 1
                //($"VIN"),   //2
                //($"Конфигурация\n/Configuration"),   //3
                //($"Тип крыши\n/Roof type"),  //4
                //($"Тип двигателя\n/Engine type"),   //5
                //($"Номер заказа\n/Batch"),   //6
                //($"Бренд\n/Model")}; //7

                //var coloumnNumber = coloumnName.Count();
                //var headerTop = top + 40;
                //var headerBottom = 70;
                //var headerLeft = left;
                //var headerRight = right / coloumnNumber;
                //var increase = right / coloumnNumber;
                //var headerTextLeft = left;

                //var pen = new Pen(Color.Black);


                //for (int rectangle = 0; rectangle < coloumnNumber; rectangle++)
                //{
                //    e.Graphics.DrawRectangle(pen, headerLeft, headerTop, headerRight, headerBottom);
                //    headerLeft += increase;
                //}

                //try
                //{
                //    var fontForString = new Font("Calibri", 10, FontStyle.Bold);
                //    for (int headerText = 0; headerText < coloumnNumber; headerText++)
                //    {
                //        e.Graphics.DrawString(coloumnName[headerText].ToString(), fontForString, Brushes.Black, headerTextLeft, headerTop);
                //        headerTextLeft += increase;
                //    }

                //    var tableTop = headerTop + headerBottom;
                //    var tableBottom = dataGridView.CurrentRow.Height;
                //    var tableLeft = left;
                //    var tableRight = right / coloumnNumber;
                //    var increaseHeight = dataGridView.CurrentRow.Height;


                //    for (int row = rowNumber; row < dataGridView.Rows.Count; row++)
                //    {
                //        if (tableTop > botom)
                //        {
                //            e.HasMorePages = true;
                //            tableTop = top;
                //            printDocumentPlanDetail_PrintPage(sender, e);
                //        }
                //        for (int coloumn = 0; coloumn < coloumnNumber; coloumn++)
                //        {
                //            e.Graphics.DrawRectangle(pen, tableLeft, tableTop, tableRight, tableBottom);
                //            tableLeft += increase;
                //        }
                //        tableTop += increaseHeight;
                //        tableLeft = left;
                //    }

                //    var rows = dataGridView.Rows.Cast<DataGridViewRow>().ToList();
                //    var tableTextTop = headerTop + headerBottom;
                //    var tableTextLeft = left;
                //    var fontText = new Font("Calibri", 8, FontStyle.Bold);
                //    var fontLongText = new Font("Calibri", 6, FontStyle.Bold);
                //    foreach (var row in rows)
                //    {
                //        var serialNumber = row.Cells["pDAYSEQUENCEDataGridViewTextBoxColumn"].Value.ToString();
                //        var carNumber = row.Cells["cCARNODataGridViewTextBoxColumn"].Value.ToString();
                //        var vin = row.Cells["cVINNODataGridViewTextBoxColumn"].Value.ToString();
                //        var configuration = row.Cells["cCONFIGURATIONDataGridViewTextBoxColumn"].Value.ToString();
                //        var skylight = row.Cells["cSKYLIGHTDataGridViewTextBoxColumn"].Value.ToString();
                //        var engineType = row.Cells["cENGINETYPEDataGridViewTextBoxColumn"].Value.ToString();
                //        var orderNumber = row.Cells["pORDERIDDataGridViewTextBoxColumn"].Value.ToString();
                //        var brand = row.Cells["cBRANDDataGridViewTextBoxColumn"].Value.ToString();

                //        e.Graphics.DrawString(serialNumber, fontText, Brushes.Black, tableTextLeft, tableTextTop);
                //        e.Graphics.DrawString(carNumber, fontText, Brushes.Black, tableTextLeft + increase, tableTextTop);
                //        e.Graphics.DrawString(vin, fontLongText, Brushes.Black, tableTextLeft + increase * 2, tableTextTop);
                //        e.Graphics.DrawString(configuration, fontText, Brushes.Black, tableTextLeft + increase * 3, tableTextTop);
                //        e.Graphics.DrawString(skylight, fontText, Brushes.Black, tableTextLeft + increase * 4, tableTextTop);
                //        e.Graphics.DrawString(engineType, fontText, Brushes.Black, tableTextLeft + increase * 5, tableTextTop);
                //        e.Graphics.DrawString(orderNumber, fontText, Brushes.Black, tableTextLeft + increase * 6, tableTextTop);
                //        e.Graphics.DrawString(brand, fontText, Brushes.Black, tableTextLeft + increase * 7, tableTextTop);

                //        tableTextTop += increaseHeight;
                //    }
                //}
                //catch (Exception exception)
                //{
                //    MessageBox.Show(exception.Message);
                //}
            }
            public void PaintShopPlanTemplate(object sender, PrintPageEventArgs e, int top, int botom, int left, int right)
            {
                //string[] coloumnName = new string[] { ($"  Номер\n  по порядку\n  /Sequence\n number"),//0
                //($"  Номер\n  кузова\n  /Car number"), // 1
                //($"VIN"),   //2
                //($"Код конфигурация\n/PPC"),    //3
                //($"Конфигурация\n/Configuration"),   //4
                //($"Цвет\n/Color"),   //5
                //($"Крыша\n/Roof"),  //6
                //($"Бренд\n/Model"), //7
                //($"Партия\n/Batch"), };   //8

                //var coloumnNumber = coloumnName.Count();
                //var headerTop = top + 40;
                //var headerBottom = 70;
                //var headerLeft = left;
                //var headerRight = right / coloumnNumber;
                //var increase = right / coloumnNumber;
                //var headerTextLeft = left;

                //var pen = new Pen(Color.Black);

                //try
                //{
                //    for (int rectangle = 0; rectangle < coloumnNumber; rectangle++)
                //    {
                //        e.Graphics.DrawRectangle(pen, headerLeft, headerTop, headerRight, headerBottom);
                //        headerLeft += increase;
                //    }


                //    var fontForString = new Font("Calibri", 10, FontStyle.Bold);
                //    for (int headerText = 0; headerText < coloumnNumber; headerText++)
                //    {
                //        e.Graphics.DrawString(coloumnName[headerText].ToString(), fontForString, Brushes.Black, headerTextLeft, headerTop);
                //        headerTextLeft += increase;
                //    }

                //    var tableTop = headerTop + headerBottom;
                //    var tableBottom = dataGridView.CurrentRow.Height;
                //    var tableLeft = left;
                //    var tableRight = right / coloumnNumber;
                //    var increaseHeight = dataGridView.CurrentRow.Height;

                //    for (int row = rowNumber; row < dataGridView.Rows.Count; row++)
                //    {
                //        if (tableTop > botom)
                //        {
                //            e.HasMorePages = true;
                //            tableTop = top;
                //            printDocumentPlanDetail_PrintPage(sender, e);
                //        }
                //        for (int coloumn = 0; coloumn < coloumnNumber; coloumn++)
                //        {
                //            e.Graphics.DrawRectangle(pen, tableLeft, tableTop, tableRight, tableBottom);
                //            tableLeft += increase;
                //        }
                //        tableTop += increaseHeight;
                //        tableLeft = left;
                //    }

                //    var rows = dataGridView.Rows.Cast<DataGridViewRow>().ToList();
                //    var tableTextTop = headerTop + headerBottom;
                //    var tableTextLeft = left;
                //    var fontText = new Font("Calibri", 8, FontStyle.Bold);
                //    var fontLongText = new Font("Calibri", 6, FontStyle.Bold);
                //    foreach (var row in rows)
                //    {
                //        var serialNumber = row.Cells["pDAYSEQUENCEDataGridViewTextBoxColumn"].Value.ToString();
                //        var carNumber = row.Cells["cCARNODataGridViewTextBoxColumn"].Value.ToString();
                //        var vin = row.Cells["cVINNODataGridViewTextBoxColumn"].Value.ToString();
                //        var productionConfiguration = row.Cells["cPRODUCTKINDIDDataGridViewTextBoxColumn"].Value.ToString();
                //        var configuration = row.Cells["cCONFIGURATIONDataGridViewTextBoxColumn"].Value.ToString();
                //        var color = row.Cells["cCARCOLORDataGridViewTextBoxColumn"].Value.ToString();
                //        var skylight = row.Cells["cSKYLIGHTDataGridViewTextBoxColumn"].Value.ToString();
                //        var brand = row.Cells["cBRANDDataGridViewTextBoxColumn"].Value.ToString();
                //        var orderNumber = row.Cells["pORDERIDDataGridViewTextBoxColumn"].Value.ToString();


                //        e.Graphics.DrawString(serialNumber, fontText, Brushes.Black, tableTextLeft, tableTextTop);
                //        e.Graphics.DrawString(carNumber, fontText, Brushes.Black, tableTextLeft + increase, tableTextTop);
                //        e.Graphics.DrawString(vin, fontLongText, Brushes.Black, tableTextLeft + increase * 2, tableTextTop);
                //        e.Graphics.DrawString(productionConfiguration, fontText, Brushes.Black, tableTextLeft + increase * 3, tableTextTop);
                //        e.Graphics.DrawString(configuration, fontText, Brushes.Black, tableTextLeft + increase * 4, tableTextTop);
                //        e.Graphics.DrawString(color, fontText, Brushes.Black, tableTextLeft + increase * 5, tableTextTop);
                //        e.Graphics.DrawString(skylight, fontText, Brushes.Black, tableTextLeft + increase * 6, tableTextTop);
                //        e.Graphics.DrawString(brand, fontText, Brushes.Black, tableTextLeft + increase * 7, tableTextTop);
                //        e.Graphics.DrawString(orderNumber, fontText, Brushes.Black, tableTextLeft + increase * 8, tableTextTop);

                //        tableTextTop += increaseHeight;

                //    }
                //}
                //catch (Exception exception)
                //{
                //    MessageBox.Show(exception.Message);
                //}
            }
            public void AssamblyShopPlanTemplate(object sender, PrintPageEventArgs e, int top, int botom, int left, int right)
            {
                //string[] coloumnName = new string[] { ($"Номер\n по порядку\n/Sequence\n number"),//0
                //($"Номер\n кузова\n/Car number"), // 1
                //($"VIN"),   //2
                //($"Производст\nвенный\n код \nконфигу\nрация\n/PPC"),   //3
                //($"Бренд\n/Model"), //4
                //($"Конфигу\nрация\n/Configuration"),   //5
                //($"Цвет\n/Color"),   //6
                //($"Тип крыши\n/Roof type"),  //7
                //($"Выбор\n конфигу\nрации\n/Configuration\n choice"), //8
                //($"Модель\n двигателя\n/Engine"),   //9
                //($"Номер заказа\n/Batch"),  //10
                //($"Бренд\n/Model"), //11
                //($"Тип привода\n/Drive tipe"),  //12
                //($"Норма\n эмиссии\n/Exhaust\n emission\n rate"),  //13
                //($"Номер \nматериала ТС\n/Material\n number"),  //14
                //($"Цвет \nинтерьера/\n Interior\n color")};   //15

                //var coloumnNumber = coloumnName.Count();
                //var headerTop = top + 40;
                //var headerBottom = 80;
                //var headerLeft = left;
                //var headerRight = right / coloumnNumber;
                //var increase = right / coloumnNumber;
                //var headerTextLeft = left;

                //var pen = new Pen(Color.Black);

                //try
                //{
                //    for (int rectangle = 0; rectangle < coloumnNumber; rectangle++)
                //    {
                //        if (rectangle == 13)
                //        {
                //            headerRight -= 13;
                //        }
                //        if (rectangle == 14)
                //        {
                //            headerLeft -= 13;
                //            headerRight += 26;
                //        }
                //        if (rectangle == 15)
                //        {
                //            headerLeft += 13;
                //            headerRight = increase;
                //        }
                //        e.Graphics.DrawRectangle(pen, headerLeft, headerTop, headerRight, headerBottom);
                //        headerLeft += increase;
                //    }


                //    var fontForString = new Font("Calibri", 8, FontStyle.Bold);
                //    for (int headerText = 0; headerText < coloumnNumber; headerText++)
                //    {
                //        if (headerText == 14)
                //        {
                //            headerTextLeft -= 13;
                //        }
                //        if (headerText == 15)
                //        {
                //            headerTextLeft += 13;
                //        }
                //        e.Graphics.DrawString(coloumnName[headerText].ToString(), fontForString, Brushes.Black, headerTextLeft, headerTop);
                //        headerTextLeft += increase;
                //    }

                //    var tableTop = headerTop + headerBottom;
                //    var tableBottom = dataGridView.CurrentRow.Height;
                //    var tableLeft = left;
                //    var tableRight = right / coloumnNumber;
                //    var increaseHeight = dataGridView.CurrentRow.Height;

                //    for (int row = rowNumber; row < dataGridView.Rows.Count; row++)
                //    {
                //        if (tableTop > botom)
                //        {
                //            e.HasMorePages = true;
                //            tableTop = top;
                //            printDocumentPlanDetail_PrintPage(sender, e);
                //        }
                //        for (int coloumn = 0; coloumn < coloumnNumber; coloumn++)
                //        {
                //            if (coloumn == 13)
                //            {
                //                tableRight -= 13;
                //            }
                //            if (coloumn == 14)
                //            {
                //                tableLeft -= 13;
                //                tableRight += 26;
                //            }
                //            if (coloumn == 15)
                //            {
                //                tableLeft += 13;
                //                tableRight = increase;
                //            }
                //            e.Graphics.DrawRectangle(pen, tableLeft, tableTop, tableRight, tableBottom);
                //            tableLeft += increase;
                //        }
                //        tableTop += increaseHeight;
                //        tableLeft = left;
                //    }

                //    var rows = dataGridView.Rows.Cast<DataGridViewRow>().ToList();
                //    var tableTextTop = headerTop + headerBottom;
                //    var tableTextLeft = left;
                //    var tableTextFont = new Font("Calibri", 8, FontStyle.Bold);
                //    var tableLongTextFont = new Font("Calibri", 5, FontStyle.Bold);


                //    foreach (var row in rows)
                //    {
                //        var serialNumber = row.Cells["pDAYSEQUENCEDataGridViewTextBoxColumn"].Value.ToString();
                //        var carNumber = row.Cells["cCARNODataGridViewTextBoxColumn"].Value.ToString();
                //        var vin = row.Cells["cVINNODataGridViewTextBoxColumn"].Value.ToString();
                //        var productionConfiguration = row.Cells["cPRODUCTKINDIDDataGridViewTextBoxColumn"].Value.ToString();
                //        var brand = row.Cells["cBRANDDataGridViewTextBoxColumn"].Value.ToString();
                //        var configuration = row.Cells["cCONFIGURATIONDataGridViewTextBoxColumn"].Value.ToString();
                //        var color = row.Cells["cCARCOLORDataGridViewTextBoxColumn"].Value.ToString();
                //        var skylight = row.Cells["cSKYLIGHTDataGridViewTextBoxColumn"].Value.ToString();
                //        var configurationChoice = row.Cells["cSKYLIGHTDataGridViewTextBoxColumn"].Value.ToString();
                //        var engineType = row.Cells["cENGINETYPEDataGridViewTextBoxColumn"].Value.ToString();
                //        var orderNumber = row.Cells["pORDERIDDataGridViewTextBoxColumn"].Value.ToString();
                //        var drive = row.Cells["cDRIVEDataGridViewTextBoxColumn"].Value.ToString();
                //        var exhaustEmissionRate = row.Cells["cEXHAUSTDataGridViewTextBoxColumn"].Value.ToString();
                //        var materialNumber = row.Cells["cCOMMONIDDataGridViewTextBoxColumn"].Value.ToString();
                //        var interiorColor = row.Cells["cINCOLORDataGridViewTextBoxColumn"].Value.ToString();



                //        e.Graphics.DrawString(serialNumber, tableTextFont, Brushes.Black, tableTextLeft, tableTextTop);
                //        e.Graphics.DrawString(carNumber, tableTextFont, Brushes.Black, tableTextLeft + increase, tableTextTop);
                //        e.Graphics.DrawString(vin, tableLongTextFont, Brushes.Black, tableTextLeft + increase * 2, tableTextTop);
                //        e.Graphics.DrawString(productionConfiguration, tableTextFont, Brushes.Black, tableTextLeft + increase * 3, tableTextTop);
                //        e.Graphics.DrawString(brand, tableTextFont, Brushes.Black, tableTextLeft + increase * 4, tableTextTop);
                //        e.Graphics.DrawString(configuration, tableTextFont, Brushes.Black, tableTextLeft + increase * 5, tableTextTop);
                //        e.Graphics.DrawString(color, tableTextFont, Brushes.Black, tableTextLeft + increase * 6, tableTextTop);
                //        e.Graphics.DrawString(skylight, tableLongTextFont, Brushes.Black, tableTextLeft + increase * 7, tableTextTop);
                //        e.Graphics.DrawString(configurationChoice, tableLongTextFont, Brushes.Black, tableTextLeft + increase * 8, tableTextTop);
                //        e.Graphics.DrawString(engineType, tableTextFont, Brushes.Black, tableTextLeft + increase * 9, tableTextTop);
                //        e.Graphics.DrawString(orderNumber, tableTextFont, Brushes.Black, tableTextLeft + increase * 10, tableTextTop);
                //        e.Graphics.DrawString(brand, tableTextFont, Brushes.Black, tableTextLeft + increase * 11, tableTextTop);
                //        e.Graphics.DrawString(drive, tableLongTextFont, Brushes.Black, tableTextLeft + increase * 12, tableTextTop);
                //        e.Graphics.DrawString(exhaustEmissionRate, tableTextFont, Brushes.Black, tableTextLeft + increase * 13, tableTextTop);
                //        e.Graphics.DrawString(materialNumber, tableLongTextFont, Brushes.Black, tableTextLeft + (increase * 14) - 13, tableTextTop);
                //        e.Graphics.DrawString(interiorColor, tableLongTextFont, Brushes.Black, tableTextLeft + (increase * 15) + 13, tableTextTop);

                //        tableTextTop += increaseHeight;

                //    }
                //}
                //catch (Exception exception)
                //{
                //    MessageBox.Show(exception.Message);
                //}
            }
        }
    }

}
    }
}
