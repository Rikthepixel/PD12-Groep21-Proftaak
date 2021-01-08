using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Appotheekcl
{
    public class AddUser : IPage
    {
        DataAccess dataAccess;
        public AddUser()
        {
            dataAccess = new DataAccess();
        }
        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        public void InsertNewUser(string Email, string Password, string Voornaam, string Achternaam)
        {
            string Statement = $"INSERT INTO User (Email, Password, Voornaam, Achternaam) VALUES('{Email}', '{Password}', '{Voornaam}', '{Achternaam}')";
            dataAccess.SaveData(dataAccess.LoginConnStr, Statement);
        }
    }
}
