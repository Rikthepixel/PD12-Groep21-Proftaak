using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public ProductList Product { get; set; }

        public void InsertNewOrder(string Medicijn, string aantal, string Gewicht, string CurrentDate, string ExpiryDate)
        {
            string Statement = $"INSERT INTO {Medicijn}(Aantal, Gewicht, Datum_ontvangen, Uiterste_datum) VALUES('{aantal}', '{Gewicht}', '{CurrentDate}', '{ExpiryDate}')";
            dataAccess.SaveData(dataAccess.ProductConnStr, Statement);
        }

        public async Task<List<string>> GetWeight(string Medicijn)
        {
            Task<List<string>> Weights = dataAccess.LoadData<string>(dataAccess.ProductConnStr, $"SELECT Gewicht FROM {Medicijn} WHERE ID = '1'");
            return Weights.Result;
        }
    }
}
