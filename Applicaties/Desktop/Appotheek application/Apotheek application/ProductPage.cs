using Appotheekcl;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;

namespace Apotheek_application
{
    public partial class ProductPage : Form
    {
        MasterPage masterPage;
        OrderPage orderPage;
        DataTable data;
        private ProductList productList;

        public bool LoginRequired { get; private set; }

        public ProductPage(MasterPage  MP)
        {
            productList = new ProductList();
            InitializeComponent();
            masterPage = MP;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void ProductPage_load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            var productlist = productList.Products;
            var source = new BindingSource();
            source.DataSource = productlist;
            data = ConvertToDataTable<Product>(productList.Products);
            data.DefaultView.Sort = "Naam asc";
            dataGridView1.DataSource = data;


            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //    //for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            //    //{

            //    //    int colw = dataGridView1.Columns[i].Width;
            //    //}


            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 140, 100);
            dataGridView1.DefaultCellStyle.Font = new Font("microsoft Sans Serif", 16f, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 119, 87);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("microsoft Sans Serif", 16f, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 140, 100);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 140, 100);
            //dataGridView1.RowHeadersVisible = false;
        }

        private void ExtraInfo_Click(object sender, DataGridViewCellEventArgs e)
        {
               
               panel1.BackColor = Color.FromArgb(19, 119, 87);
               panel1.Size = new Size(100, 100);
               panel1.Visible = true;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var RowData = productList.Products[e.RowIndex];
                TotaalGewicht.Text = $"Gewicht: {RowData.Gewicht * RowData.aantal}";
                Naam.Text = $"Naam: {RowData.naam}";
                Type.Text = $"Type: {productList.ProductExtraInfo[e.RowIndex].Type}";
                Leverancier.Text = $"Leverancier: {productList.ProductExtraInfo[e.RowIndex].Leverancier}";

                if (!panel1.Visible) 
                {
                    ToggleExtraInfoVisability(false);
                }
            }
                
        }

        private void X_Click(object sender, EventArgs e)
        {
            ToggleExtraInfoVisability(true);
        }

        private void ToggleExtraInfoVisability(bool NeedsClosing)
        {
            if (!NeedsClosing)
            {
                if (panel1.Visible == true)
                {
                    panel1.Visible = false;
                    TotaalGewicht.Visible = false;
                    Type.Visible = false;
                    Leverancier.Visible = false;
                    Bestellen.Visible = false;
                    Naam.Visible = false;
                    EersteLevering.Visible = false;
                    X.Visible = false;
                }
                else
                {
                    panel1.Visible = true;
                    TotaalGewicht.Visible = true;
                    Type.Visible = true;
                    Leverancier.Visible = true;
                    Bestellen.Visible = true;
                    Naam.Visible = true;
                    EersteLevering.Visible = true;
                    X.Visible = true;
                }
            }
            else
            {
                panel1.Visible = false;
                TotaalGewicht.Visible = false;
                Type.Visible = false;
                Leverancier.Visible = false;
                Bestellen.Visible = false;
                Naam.Visible = false;
                EersteLevering.Visible = false;
                X.Visible = false;
            }

        }

        private void Bestellen_Click(object sender, EventArgs e)
        {
            if (masterPage.CurrentUser.IsLoginValid())
            {
                if (orderPage == null)
                {
                    orderPage = new OrderPage();
                }

                masterPage.OpenChildForm(orderPage, orderPage.LoginRequired);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchBox = textBoxSearch.Text;
            
            if (textBoxSearch.Text.Length != 0)
            {

                data.DefaultView.RowFilter = $"id = '{textBoxSearch.Text}'";

                dataGridView1.DataSource = data;
            }
            if (textBoxSearch.Text.Length == 0)
            {
                data.DefaultView.RowFilter = string.Empty;
            }
        }
        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }


    }
}

