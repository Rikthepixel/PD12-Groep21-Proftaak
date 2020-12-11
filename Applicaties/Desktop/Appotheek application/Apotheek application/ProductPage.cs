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
        MasterPage masterPage;
        OrderPage orderPage;
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

        private void dataGridView1_load(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        public void ProductPage_load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            var productlist = productList.Products;
            var source = new BindingSource();
            source.DataSource = productlist;
            dataGridView1.DataSource = source;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


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


        //    //Parent table  
        //    DataTable dtstudent = new DataTable();
        //    // add column to datatable  
        //    dtstudent.Columns.Add("Student_ID", typeof(int));
        //    dtstudent.Columns.Add("Student_Name", typeof(string));
        //    dtstudent.Columns.Add("Student_RollNo", typeof(string));

        //    //Child table  
        //    DataTable dtstudentMarks = new DataTable();
        //    dtstudentMarks.Columns.Add("Student_ID", typeof(int));
        //    dtstudentMarks.Columns.Add("Subject_ID", typeof(int));
        //    dtstudentMarks.Columns.Add("Subject_Name", typeof(string));
        //    dtstudentMarks.Columns.Add("Marks", typeof(int));

        //    //Adding Rows  
        //    dtstudent.Rows.Add(111, "Devesh", "03021013014");
        //    dtstudent.Rows.Add(222, "ROLI", "0302101444");
        //    dtstudent.Rows.Add(333, "ROLI Ji", "030212222");
        //    dtstudent.Rows.Add(444, "NIKHIL", "KANPUR");

        //    // data for devesh ID=111  
        //    dtstudentMarks.Rows.Add(111, "01", "Physics", 99);
        //    dtstudentMarks.Rows.Add(111, "02", "Maths", 77);
        //    dtstudentMarks.Rows.Add(111, "03", "C#", 100);
        //    dtstudentMarks.Rows.Add(111, "01", "Physics", 99);


        //    //data for ROLI ID=222  
        //    dtstudentMarks.Rows.Add(222, "01", "Physics", 80);
        //    dtstudentMarks.Rows.Add(222, "02", "English", 95);
        //    dtstudentMarks.Rows.Add(222, "03", "Commerce", 95);
        //    dtstudentMarks.Rows.Add(222, "01", "BankPO", 99);

        //    DataSet dsDataset = new DataSet();
        //    //Add two DataTables in Dataset  
        //    dsDataset.Tables.Add(dtstudent);
        //    dsDataset.Tables.Add(dtstudentMarks);

        //    DataRelation Datatablerelation = new DataRelation("DetailsMarks", dsDataset.Tables[0].Columns[0], dsDataset.Tables[1].Columns[0], true);
        //    dsDataset.Relations.Add(Datatablerelation);
        //    dataGridView1.DataSource = dsDataset.Tables[0];
        //}

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
                //productList.ProductExtraInfo[e.RowIndex].Leverancier;
               // productList.ProductExtraInfo[e.RowIndex].Type;


                if (RowData.naam == "Xanac")
                {

                    Type.Text = $"Type: Xanac";
                }

                else if (RowData.naam == "oxazepam")
                {
                    Type.Text = $"Type: Spuiten";
                }

                else if (RowData.naam == "ibuprofen")
                {
                    Type.Text = $"Type: Pillen";
                }

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
    }
}

