using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appotheekcl.Models;

namespace Appotheekcl
{
    public class Order : IPage
    {
        DataAccess dataAccess;
        public Order()
        {
            dataAccess = new DataAccess();
        }
        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        public delegate void TableEventHandler(object source, TablesRecievedEventArgs args);
        public event TableEventHandler TablesRecieved;
        public async Task GetTablesAsync(User user)
        {
            string TableQuery = "SELECT table_name FROM information_schema.tables WHERE table_schema = 'Medical';";
            var Data = await dataAccess.SendQueryAsync<List<SQLTable>>(TableQuery, user);
            OnTablesRecieved(Data);
        }

        public async Task InsertNewOrderAsync(Product productInfo, ExtraInfo extraInfo, User user)
        {
            string ProductName = productInfo.naam.Replace(' ', '_');
            string Statement = $"INSERT INTO {ProductName}(Aantal, Gewicht, Datum_ontvangen, Uiterste_datum, Type, Leverancier) VALUES('{productInfo.aantal}', '{productInfo.Gewicht}', '{productInfo.Datum_Ontvangen}', '{productInfo.Uiterste_Datum}', '{extraInfo.Type}', '{extraInfo.Leverancier}')";
            await dataAccess.SendSaveQueryAsync(Statement, user);
            
        }
        public async Task InsertNewProductAsync(Product productInfo, ExtraInfo extraInfo, User user)
        {
            string ProductName = productInfo.naam.Replace(' ', '_');
            var commandStr = $"CREATE TABLE {ProductName}(ID INT(6) AUTO_INCREMENT PRIMARY KEY,Aantal INT(30) NOT NULL,Gewicht DOUBLE NOT NULL,Datum_ontvangen text NOT NULL, Uiterste_datum text NOT NULL, Type text NOT NULL, Leverancier text NOT NULL)";
            string Statement = $"INSERT INTO {ProductName}(Aantal, Gewicht, Datum_ontvangen, Uiterste_datum, Type, Leverancier) VALUES('{productInfo.aantal}', '{productInfo.Gewicht}', '{productInfo.Datum_Ontvangen}', '{productInfo.Uiterste_Datum}', '{extraInfo.Type}', '{extraInfo.Leverancier}')";

            await dataAccess.SendSaveQueryAsync(commandStr, user);
            await dataAccess.SendSaveQueryAsync(Statement, user);

        }

        protected virtual void OnTablesRecieved(List<SQLTable> RecievedTables)
        {
            if (TablesRecieved != null)
                TablesRecieved(this, new TablesRecievedEventArgs(RecievedTables));
        }

        public async Task<Tuple<Product, ExtraInfo>> GetProductByIDAsync(string Medicijn, int ID, User user)
        {
            List<Task> Tasks = new List<Task>();
            var Product = dataAccess.SendQueryAsync<List<Product>> ($"SELECT * FROM {Medicijn} WHERE ID = '{ID}'", user);
            Tasks.Add(Product);
            var ExtraInfo = dataAccess.SendQueryAsync<List<ExtraInfo>>($"SELECT * FROM {Medicijn} WHERE ID = '{ID}'", user);
            Tasks.Add(ExtraInfo);
            await Task.WhenAll(Tasks);
            return Tuple.Create(Product.Result[0], ExtraInfo.Result[0]);
        }


        public void UpdateOrder(string Medicijn, string aantal, string ID, User user)
        {
            string Statement = $"UPDATE {Medicijn} SET Aantal = '{aantal}' WHERE ID = '{ID}'";
            _ = dataAccess.SendSaveQueryAsync(Statement, user);
        }
        public void DeleteOrder(string Medicijn, string ID, User user)
        {
            string Statement = $"DELETE FROM {Medicijn} WHERE ID = '{ID}'";
            _ = dataAccess.SendSaveQueryAsync(Statement, user);
        }
        public void Drop_tabel_Order(string Medicijn, User user)
        {
            string Statement = $"DROP TABLE {Medicijn}";
            _ = dataAccess.SendSaveQueryAsync(Statement, user);
        }
        public async Task<List<Product>> GetIDsAsync(string Medicijn, User user)
        {
            string Statement = $"SELECT ID FROM {Medicijn} WHERE ID > 0";
            return await dataAccess.SendQueryAsync<List<Product>>(Statement, user);
        }
    }



    public class TablesRecievedEventArgs : EventArgs
    {
        public TablesRecievedEventArgs(List<SQLTable> RecievedTables)
        {
            Tables = RecievedTables;
        }
        public List<SQLTable> Tables { get; set; }
    }
}
