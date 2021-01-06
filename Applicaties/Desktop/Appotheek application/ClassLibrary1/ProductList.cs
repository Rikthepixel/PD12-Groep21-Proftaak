using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Appotheekcl
{
    public class ProductList : IPage
    {
        DataAccess data;
        public ProductList()
        {
            OnDateIndexes = new List<int>();
            OverDateIndexes = new List<int>();
            data = new DataAccess();
            Products = GetProduct().Result;
            ProductExtraInfo = GetExtraInfo().Result;
        }



        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        public List<int> OnDateIndexes { get; set; }
        public List<int> OverDateIndexes { get; set; }

        public List<Product> Products { get; set; }
        public List<ExtraInfo> ProductExtraInfo { get; set; }

        private async Task<List<Product>> GetProduct()
        {
            List<Product> prodsResult = new List<Product>();
            List<string> tables = await data.LoadData<string>(data.ProductConnStr, "SELECT table_name FROM information_schema.tables WHERE table_schema = 'Medical';");
            for (int i = 0; i < tables.Count; i++)
            {
                string statement = $"SELECT * FROM {tables[i]}";
                List<Product> results = await data.LoadData<Product>(data.ProductConnStr, statement);

                for (int j = 0; j < results.Count; j++)
                {
                    results[j].naam = tables[i];
                    prodsResult.Add(results[j]);

                    /*string CurrentDate = DateTime.Now.ToString("yyyy-MM-dd")*/;
                    string CurrentDate = "2021-2-16";
                    Console.WriteLine(CurrentDate == results[j].Uiterste_Datum);
                    if (CurrentDate == results[j].Uiterste_Datum)
                    {
                        OnDateIndexes.Add(j);
                        //dataGridView1.Row(j).DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    ////void dataCheck()
                    //{

                    //}
                }
            }
            return prodsResult;
        }

        private async Task<List<ExtraInfo>> GetExtraInfo()
        {
            List<ExtraInfo> prodsResult = new List<ExtraInfo>();
            List<string> tables = await data.LoadData<string>(data.ProductConnStr, "SELECT table_name FROM information_schema.tables WHERE table_schema = 'Medical';");
            for (int i = 0; i < tables.Count; i++)
            {
                string statement = $"SELECT * FROM {tables[i]}";
                List<ExtraInfo> results = await data.LoadData<ExtraInfo>(data.ProductConnStr, statement);

                for (int j = 0; j < results.Count; j++)
                {
                    prodsResult.Add(results[j]);
                }
            }
            return prodsResult;
        }
    }
}
