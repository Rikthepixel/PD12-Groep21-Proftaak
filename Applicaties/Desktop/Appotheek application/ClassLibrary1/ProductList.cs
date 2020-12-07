using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appotheekcl
{
    public class ProductList : IPage
    {
        DataAccess data;
        public ProductList()
        {
            data = new DataAccess();
            Products = GetProduct().Result;
        }



        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        public List<Product> Products { get; set; }

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
                }
            }
            return prodsResult;
        }
    }
}
