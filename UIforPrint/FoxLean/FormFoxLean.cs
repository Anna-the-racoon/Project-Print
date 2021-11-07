using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using PagedList;
using System.Windows.Media.Media3D;
//using System.Windows.Media.Media3D;

namespace UIforPrint.FoxLean
{
    public partial class FormFoxLean : Form
    {
        public FormFoxLean()
        {
            InitializeComponent();
        }
        int currentPage = 1;
        int pageSize = 40;
        private void FormFoxLean_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersDataSet.Materials' table. You can move, or remove it, as needed.
            //this.materialsTableAdapter.Fill(this.ordersDataSet.Materials);

            
            //using(OrdersDataSet bd = new OrdersDataSet())
            //{
            //    IPagedList<Material> materials = bd.Materials.OrderBy(p => p.Id).ToPagedList(currentPage, pageSize);
            //    buttonNextPage.Enabled = materials.IsFirstPage;
            //    buttonPrewPage.Enabled = materials.IsLastPage;
            //    labelNumberOfPage.Text = string.Format($"Page {materials.PageNumber}/{materials.PageCount}");
            //    ordersDataSetBindingSource.DataSource = materials.ToList();
            //}

        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            if (buttonNextPage.Enabled)
            {
                using (var bd = new OrdersDataSet())
                {
                    currentPage++;
                    IPagedList<Material> materials = (IPagedList<Material>)bd.Materials.OrderBy(p => p.OrderId).ToPagedList(currentPage, pageSize);
                    buttonNextPage.Enabled = materials.IsFirstPage;
                    buttonPrewPage.Enabled = materials.IsLastPage;
                    labelNumberOfPage.Text = string.Format($"Page {materials.PageNumber}/{materials.PageCount}");
                    ordersDataSetBindingSource.DataSource = materials.ToList();
                }
            }
        }

        private void buttonPrewPage_Click(object sender, EventArgs e)
        {
            if (buttonPrewPage.Enabled)
            {
                using (var bd = new OrdersDataSet())
                {
                    currentPage--;
                    IPagedList<Material> materials = (IPagedList<Material>)bd.Materials.OrderBy(p => p.OrderId).ToPagedList(currentPage, pageSize);
                    buttonNextPage.Enabled = materials.IsFirstPage;
                    buttonPrewPage.Enabled = materials.IsLastPage;
                    labelNumberOfPage.Text = string.Format($"Page {materials.PageNumber}/{materials.PageCount}");
                    ordersDataSetBindingSource.DataSource = materials.ToList();
                }
            }
        }

        Bitmap bitmap;

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
