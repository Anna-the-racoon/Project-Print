using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIforPrint.PrintFromDGV
{
    public partial class FormDGFormExperimentalPrint : Form
    {
        public FormDGFormExperimentalPrint()
        {
            InitializeComponent();
        }

        private void FormDGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersDataSet1.Materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.ordersDataSetMaterials.Materials);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                var form = new FormPreviewPrintPage(dataGridViewMaterials);
                form.MdiParent = this.MdiParent;
                form.Show();


            }
            catch (Exception exception)
            {
                MessageBox.Show($"Произошла ошибка: {exception.Message}");
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

        private void dataGridViewMaterials_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.P)
            {
                buttonPrint_Click(this.buttonPrint, EventArgs.Empty);
            }
        }

        //public void bitmapDocumentMaterials()
        //{
            //Bitmap bitmap = new Bitmap(dataGridViewMaterials.Size.Width + 10, dataGridViewMaterials.Size.Height + 10);
            //dataGridViewMaterials.DrawToBitmap(bitmap, dataGridViewMaterials.Bounds);
            

            //var graphic = dataGridViewMaterials.CreateGraphics();
            //var width = dataGridViewMaterials.Width;
            //var height = dataGridViewMaterials.Height;
            //var bitmap = new Bitmap(width, height, graphic); 
        //}



    }
}
