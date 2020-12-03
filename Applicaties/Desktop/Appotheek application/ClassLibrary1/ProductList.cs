using System;
using System.Collections.Generic;
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
            Products = GetProduct();
        }



        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        public List<Product> Products { get; set; }

        private List<Product> GetProduct()
        {
            List<Product> prodsResult = new List<Product>();
            Task<List<string>> tables = data.LoadData<string>(data.ProductConnStr, "SELECT table_name FROM information_schema.tables WHERE table_schema = 'Medical';");
            for (int i = 0; i < tables.Result.Count; i++)
            {
                string statement = $"SELECT * FROM {tables.Result[i]}";
                Task<List<Product>> results = data.LoadData<Product>(data.ProductConnStr, statement);

                for (int j = 0; j < results.Result.Count; j++)
                {
                    prodsResult.Add(results.Result[j]);
                }
            }
            return prodsResult;
        }
    }
}
