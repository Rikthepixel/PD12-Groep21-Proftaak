using Appotheekcl;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;


namespace Apotheek_application
{
    public partial class ProductPage : Form
    {
        MasterPage masterPage;
        OrderPage orderPage;
        RemovePage removePage;
        DataTable data;
        private ProductList productList;

        public bool LoginRequired { get; private set; }

        public ProductPage(MasterPage  MP)
        {
            InitializeComponent();
            masterPage = MP;
            //productList = new ProductList(masterPage.CurrentUser);
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public void ProductPage_load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            RefreshButton_Click(sender, e);

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 140, 100);
            dataGridView1.DefaultCellStyle.Font = new Font("microsoft Sans Serif", 16f, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(19, 119, 87);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("microsoft Sans Serif", 16f, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(30, 140, 100);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
        }

        private void ExtraInfo_Click(object sender, DataGridViewCellEventArgs e)
        {
               panel1.BackColor = Color.FromArgb(19, 119, 87);
               panel1.Size = new Size(100, 100);
               panel1.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                SoundPlayer Popup2 = new SoundPlayer(Properties.Resources.Popup2);
                Popup2.Play();
                var RowData = productList.Products[e.RowIndex];

                TotaalGewicht.Text = $"Totaal gewicht: {RowData.Gewicht * RowData.aantal}";
                Naam.Text = $"Naam: {RowData.naam}";
                Type.Text = $"Type: {productList.ProductExtraInfo[e.RowIndex].Type}";
                Leverancier.Text = $"Leverancier: {productList.ProductExtraInfo[e.RowIndex].Leverancier}";

                string CurrentDate = DateTime.Now.ToString("yyyy-MM-dd");
                //string CurrentDate = "2024-01-01";
                //int MonthZero = int.Parse(Convert.ToString(CurrentDate[5]));
                //if (MonthZero == 0) CurrentDate = CurrentDate.Remove(5, 1);

                int Result = DateTime.Compare(DateTime.Parse(CurrentDate), DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()));
                //int Result2 = DateTime.Compare(DateTime.Now, DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()));

                if (Result == 0) panel1.BackColor = Color.FromArgb(138, 153, 24);
                if (Result > 0) panel1.BackColor = Color.FromArgb(153, 24, 24);

                if (!panel1.Visible)
                {
                    ToggleExtraInfoVisability(false);
                }
            }      
        }

        private void X_Click(object sender, EventArgs e)
        {
            SoundPlayer Popup = new SoundPlayer(Properties.Resources.Error);
            Popup.Play();
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
                    Verwijderen_btn.Visible = false;
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
                    Verwijderen_btn.Visible = true;
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
                Verwijderen_btn.Visible = false;
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
                    orderPage = new OrderPage(masterPage);
                }
                masterPage.OpenChildForm(orderPage, orderPage.LoginRequired);
                SoundPlayer Popup2 = new SoundPlayer(Properties.Resources.Popup2);
                Popup2.Play();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchBox = textBoxSearch.Text;
            
            if (textBoxSearch.Text.Length != 0 && char.IsDigit(textBoxSearch.Text[0]))
            {
                data.DefaultView.RowFilter = $"id LIKE '%{textBoxSearch.Text}%'";

                dataGridView1.DataSource = data;
            }
            if (textBoxSearch.Text.Length != 0 && char.IsLetter(textBoxSearch.Text[0]))
            {
                data.DefaultView.RowFilter = $"naam LIKE '%{textBoxSearch.Text}%'";

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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            SoundPlayer Popup2 = new SoundPlayer(Properties.Resources.Popup2);
            Popup2.Play();
            productList = new ProductList(masterPage.CurrentUser);
            productList.ProductInfoFetched += OnProductsRecieved;
        }

        private void OnProductsRecieved(object source, EventArgs e)
        {
            data = ConvertToDataTable(productList.Products);
            data.DefaultView.Sort = "Naam asc";
            dataGridView1.DataSource = data;

            // Deze code was bedoelt als waarschuwing dat iets over de datum is
            //DataGridViewCellStyle Style = new DataGridViewCellStyle();

            //foreach(DataGridViewRow row in dataGridView1.Rows)
            //{
            //    Console.WriteLine("Test");
            //    foreach (int Index in productList.OnDateIndexes)
            //    {
            //        //Console.WriteLine(Index);
            //        Console.WriteLine("test");
            //        Style.BackColor = Color.Yellow;
            //        dataGridView1.Rows[Index].DefaultCellStyle.BackColor = Color.Yellow;

            //        if (Convert.ToInt32(row) == Index)
            //        {
            //            row.DefaultCellStyle = Style;
            //        }
            //    }
            //}

            dataGridView1.Sort(dataGridView1.Columns["Naam"], ListSortDirection.Ascending);
        }

        private void Verwijderen_btn_Click(object sender, EventArgs e)
        {
            if (masterPage.CurrentUser.IsLoginValid())
            {
                //if (!masterPage.IsLightmode)
                //{
                //    CustomMB.ForeColor = Color.White;
                //    CustomMB.BackColor = Color.FromArgb(75, 79, 78);
                //    CustomMB.SetButtonColors(Color.White, Color.FromArgb(75, 79, 78), Color.FromArgb(55, 58, 64));
                //    CustomMB.SetWarningLabel(Properties.Resources.AlertDark3);
                //}
                if (removePage == null)
                {
                    removePage = new RemovePage(masterPage);

                }

                masterPage.OpenChildForm(removePage, removePage.LoginRequired);
            }
        }
    }
}

