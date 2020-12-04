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
        private new List<Product> products;

        public ProductPage()
        {
            InitializeComponent();
            productList = new ProductList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Load() 
        {
            string[] Columnnames = {"id", "Aantal", "Gewicht", "Datum_Ontvangen", "Uiterste_Datum" };
            DataTable Data = new DataTable();
            foreach (var item in Columnnames)
            {
                Data.Columns.Add(item);
            }
            
            foreach (var item in productList.Products)
            {
                Data.Rows.Add(productList.Products);
            }
            var bindingList = new BindingList<Product>(productList.Products);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = Data;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
