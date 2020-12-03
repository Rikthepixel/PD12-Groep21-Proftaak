using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Appotheekcl
{
    public class Order : IPage
    {
        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        public ProductList Product { get; set; }

        public void InsertNewOrder(string Medicijn, string aantal, string Gewicht, string CurrentDate, string ExpiryDate)
        {
            DataAccess dataAccess = new DataAccess();
            dataAccess.SaveData(dataAccess.ProductConnStr, $"INSERT INTO {Medicijn}(Aantal, Gewicht, Datum_ontvangen, Uiterste_datum) VALUES('{aantal}', '{Gewicht}', '{CurrentDate}', '{ExpiryDate}')");
        }
    }
}
