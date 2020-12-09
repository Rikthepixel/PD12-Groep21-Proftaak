using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appotheekcl;

namespace Apotheek_application
{
    public partial class ProductPage : Form 
    {
        private ProductList productList;

        public ProductPage()
        {
            productList = new ProductList();
            InitializeComponent();
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        //private void searchTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("naam LIKE '{0}%'", textBoxSearch.Text.Trim().Replace("'", "''"));
        //}

        //private void dataGridView1_Load()
        //{
        //    string[] Columnnames = { "id", "Aantal", "Gewicht", "Datum_Ontvangen", "Uiterste_Datum" };
        //    DataTable Data = new DataTable();
        //    foreach (var item in Columnnames)
        //    {
        //        Data.Columns.Add(item);
        //    }

        //    foreach (var item in productList.Products)
        //    {
        //        Data.Rows.Add(productList.Products);
        //    }
        //    var bindingList = new BindingList<Product>(productList.Products);
        //    var source = new BindingSource(bindingList, null);
        //    dataGridView1.DataSource = Data;
        //}

        private void dataGridView1_load(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void ProductPage_load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            var productlist = productList.Products;
            var source = new BindingSource();
            source.DataSource = productlist;
            dataGridView1.DataSource = source;
            //source.Add.[0] = "Barcode";

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
 
                int colw = dataGridView1.Columns[i].Width;
                // dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //dataGridView1.Columns[i].Width = colw;
            }

            
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 140, 100);
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.FromArgb(19, 119, 87);
            dataGridView1.DefaultCellStyle.Font = new Font("microsoft Sans Serif", 16f, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 119, 87);
            //dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("microsoft Sans Serif", 16f, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor =  Color.FromArgb(30, 140, 100);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            //dataGridView1.DefaultCellStyle.

            //if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            //{
            //    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected == true)
            //    {
            //        e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.Border);
            //        using (Pen p = new Pen(Color.Red, 1))
            //        {
            //            Rectangle rect = e.CellBounds;
            //            rect.Width -= 2;
            //            rect.Height -= 2;
            //            e.Graphics.DrawRectangle(p, rect);
            //        }
            //        e.Handled = true;
            //    }
            //}
        }



        //public void HandleAutoSize(this DataGridView dataGridView1)
        //{
        //    dataGridView1.DataBindingComplete += (s, e) =>
        //    {
        //        var dg = (DataGridView)s;
        //        var width = dg.Columns.GetColumnsWidth(DataGridViewElementStates.None);
        //        var height = dg.Rows.GetRowsHeight(DataGridViewElementStates.None);

        //        dg.ClientSize = new Size(width, height);
        //    };
        //}
    }
}
