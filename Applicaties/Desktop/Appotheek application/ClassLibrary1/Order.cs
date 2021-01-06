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

        public async Task InsertNewOrderAsync(Product productInfo, ExtraInfo extraInfo, User user)
        {
            string Statement = $"INSERT INTO {productInfo.naam}(Aantal, Gewicht, Datum_ontvangen, Uiterste_datum, Type, Leverancier) VALUES('{productInfo.aantal}', '{productInfo.Gewicht}', '{productInfo.Datum_Ontvangen}', '{productInfo.Uiterste_Datum}', '{extraInfo.Type}', '{extraInfo.Leverancier}')";
            await dataAccess.SendSaveQueryAsync(Statement, user);
            
        }
        public async Task InsertNewProductAsync(Product productInfo, ExtraInfo extraInfo, User user)
        {
            var commandStr = $"CREATE TABLE {productInfo.naam}(ID INT(6) AUTO_INCREMENT PRIMARY KEY,Aantal INT(30) NOT NULL,Gewicht DOUBLE NOT NULL,Datum_ontvangen text NOT NULL, Uiterste_datum text NOT NULL, Type text NOT NULL, Leverancier text NOT NULL)";
            string Statement = $"INSERT INTO {productInfo.naam}(Aantal, Gewicht, Datum_ontvangen, Uiterste_datum, Type, Leverancier) VALUES('{productInfo.aantal}', '{productInfo.Gewicht}', '{productInfo.Datum_Ontvangen}', '{productInfo.Uiterste_Datum}', '{extraInfo.Type}', '{extraInfo.Leverancier}')";

            await dataAccess.SendSaveQueryAsync(commandStr, user);
            Console.WriteLine(commandStr);
            await dataAccess.SendSaveQueryAsync(Statement, user);
            Console.WriteLine(Statement);
        }
        public async Task GetTablesAsync(User user)
        {
            var tables = dataAccess.SendQueryAsync<List<SQLTable>>($"SELECT table_name FROM information_schema.tables WHERE table_schema = 'Medical';", user);
            OnTablesRecieved(await tables);
        }

        protected virtual void OnTablesRecieved(List<SQLTable> RecievedTables)
        {
            if (TablesRecieved != null)
                TablesRecieved(this, new TablesRecievedEventArgs(RecievedTables));
        }
            public async Task<Tuple<Product, ExtraInfo>> GetProductByIDAsync(string Medicijn, int ID, User user)
        {
            var Product = dataAccess.SendQueryAsync<Product>($"SELECT Gewicht FROM {Medicijn} WHERE ID = '{ID}'", user);
            var ExtraInfo = dataAccess.SendQueryAsync<ExtraInfo>($"SELECT Gewicht FROM {Medicijn} WHERE ID = '{ID}'", user);
            
            return Tuple.Create<Product, ExtraInfo>(await Product, await ExtraInfo);
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
