using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Appotheekcl.Models;

using System.Threading;

namespace Appotheekcl
{
    public class ProductList : IPage
    {
        DataAccess data;
        public ProductList(User user)
        {
            data = new DataAccess();
            FetchProductInfo(user);
        }

        public delegate void ProductInfoFetchedEventHandler(object source, EventArgs args);
        public event ProductInfoFetchedEventHandler ProductInfoFetched;

        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        public List<Product> Products { get; set; }
        public List<ExtraInfo> ProductExtraInfo { get; set; }
        public List<SQLTable> Tables { get; set; } 

        private async void FetchProductInfo(User user)
        {
            Products = new List<Product>();
            ProductExtraInfo = new List<ExtraInfo>();
            Tables = await GetTables(user);
            _ = GetProducts(user, Tables);
        }

        protected virtual void OnProductsFetched()
        {
            if (ProductExtraInfo != null)
                ProductInfoFetched(this, EventArgs.Empty);
        }

        private async Task<List<SQLTable>> GetTables(User user)
        {
            string TableQuery = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'Medical';";
            return await data.SendQueryAsync<List<SQLTable>>(TableQuery, user);
        }
        private async Task GetProducts(User user, List<SQLTable> Tables)
        {
            List<Task> DataFetchTasks = new List<Task>();
            List<Task> TaskCreators = new List<Task>();

            TaskCreators.Add(Task.Run(() => {
                for (int i = 0; i < Tables.Count; i++)
                {
                    var Table = Tables[i];
                    DataFetchTasks.Add(Task.Run(async () =>
                    {

                        string statement = $"SELECT * FROM {Table.TABLE_NAME}";
                        List<Product> results = await data.SendQueryAsync<List<Product>>(statement, user);

                        for (int j = 0; j < results.Count; j++)
                        {

                            results[j].naam = Table.TABLE_NAME.Replace('_', ' ');
                            Products.Add(results[j]);
                        }
                    }));
                }
            }));
            TaskCreators.Add(Task.Run(() => {
                for (int i = 0; i < Tables.Count; i++)
                {
                    var Table = Tables[i];
                    DataFetchTasks.Add(Task.Run(async () =>
                    {
                        string statement = $"SELECT * FROM {Table.TABLE_NAME}";
                        List<ExtraInfo> results = await data.SendQueryAsync<List<ExtraInfo>>(statement, user);

                        for (int j = 0; j < results.Count; j++)
                        {
                            ProductExtraInfo.Add(results[j]);
                        }
                    }));
                }
            }));

            await Task.WhenAll(TaskCreators);
            await Task.WhenAll(DataFetchTasks);
            OnProductsFetched();
        }
    }
}
