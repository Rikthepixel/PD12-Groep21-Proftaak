﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

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

        public void InsertNewOrder(string Medicijn, string aantal, string Gewicht, string CurrentDate, string ExpiryDate, string Type, string Leverancier)
        {
            string Statement = $"INSERT INTO {Medicijn}(Aantal, Gewicht, Datum_ontvangen, Uiterste_datum, Type, Leverancier) VALUES('{aantal}', '{Gewicht}', '{CurrentDate}', '{ExpiryDate}', '{Type}', '{Leverancier}')";
            dataAccess.SaveData(dataAccess.ProductConnStr, Statement);
        }
        public void InsertNewProduct(string Medicijn, string Aantal, string Gewicht, string CurrentDate, string ExpiryDate, string Type, string Leverancier)
        {
            var commandStr = $"CREATE TABLE {Medicijn}(ID INT(6) AUTO_INCREMENT PRIMARY KEY,Aantal INT(30) NOT NULL,Gewicht DOUBLE NOT NULL,Datum_ontvangen text NOT NULL, Uiterste_datum text NOT NULL, Type text NOT NULL, Leverancier text NOT NULL)";
            string Statement = $"INSERT INTO {Medicijn}(Aantal, Gewicht, Datum_ontvangen, Uiterste_datum, Type, Leverancier) VALUES('{Aantal}', '{Gewicht}', '{CurrentDate}', '{ExpiryDate}', '{Type}', '{Leverancier}')";
            dataAccess.SaveData(dataAccess.ProductConnStr, commandStr);
            dataAccess.SaveData(dataAccess.ProductConnStr, Statement);
        }
        public void UpdateOrder(string Medicijn, string aantal, string ID)
        {
            string Statement = $"UPDATE {Medicijn} SET Aantal = '{aantal}' WHERE ID = '{ID}'";
            dataAccess.SaveData(dataAccess.ProductConnStr, Statement);
        }
        public void DeleteOrder(string Medicijn,string ID)
        {
            string Statement = $"DELETE FROM {Medicijn} WHERE ID = '{ID}'";
            dataAccess.SaveData(dataAccess.ProductConnStr, Statement);
        }
        public async Task<List<string>> GetName()
        {
            List<string> tables = await dataAccess.LoadData<string>(dataAccess.ProductConnStr, $"SELECT table_name FROM information_schema.tables WHERE table_schema = 'Medical';");
            return tables;
        }
        public async Task<List<string>> GetID(string Medicijn)
        {
            List<string> tables = await dataAccess.LoadData<string>(dataAccess.ProductConnStr, $"SELECT ID FROM {Medicijn} WHERE ID > '0'");
            return tables;
        }
        public async Task<List<string>> GetWeight(string Medicijn)
        {
            Task<List<string>> Weights = dataAccess.LoadData<string>(dataAccess.ProductConnStr, $"SELECT Gewicht FROM {Medicijn} WHERE ID = '1'");
            return Weights.Result;
        }
        public async Task<List<string>> GetType(string Medicijn)
        {
            Task<List<string>> Type = dataAccess.LoadData<string>(dataAccess.ProductConnStr, $"SELECT Type FROM {Medicijn} WHERE ID = '1'");
            return Type.Result;
        }
        public async Task<List<string>> GetLeverancier(string Medicijn)
        {
            Task<List<string>> Leverancier = dataAccess.LoadData<string>(dataAccess.ProductConnStr, $"SELECT Leverancier FROM {Medicijn} WHERE ID = '1'");
            return Leverancier.Result;
        }
        public async Task<List<string>> GetAantal(string Medicijn, string ID)
        {
            Task<List<string>> Aantal = dataAccess.LoadData<string>(dataAccess.ProductConnStr, $"SELECT Aantal FROM {Medicijn} WHERE ID = '{ID}'");
            return Aantal.Result;
        }
    }
}
