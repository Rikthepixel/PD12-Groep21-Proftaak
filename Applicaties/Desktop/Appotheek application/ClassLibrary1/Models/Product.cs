using System;
using System.Collections.Generic;
using System.Text;

namespace Appotheekcl
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string nm, int Antl, double gewicht, string datum, string uitersteDatum)
        {
            naam = nm;
            aantal = Antl;
            Gewicht = gewicht;
            Datum_Ontvangen = datum;
            Uiterste_Datum = uitersteDatum;
        }
        public string id { get; set; }
        public string naam { get; set; }
        public int aantal { get; set; }
        public double Gewicht { get; set; }
        public string Datum_Ontvangen { get; set; }
        public string Uiterste_Datum { get; set; }
        //public string ReceptionDate { get; set; }
        //public string Supplier { get; set; }
        //public string Type { get; set; }
        //public string Name { get; set; }
    }

    public class ExtraInfo
    {
        public ExtraInfo()
        {

        }
        public ExtraInfo(string type, string leverancier)
        {
            Type = type;
            Leverancier = leverancier;
        }
        public string Type { get; set; }
        public string Leverancier { get; set; }
    }
}
