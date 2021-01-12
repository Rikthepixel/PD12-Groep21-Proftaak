using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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

        public void InsertNewUser(string Email, string Password, string Voornaam, string Achternaam, User CurrentUser)
        {
            var PostData = new List<KeyValuePair<string, string>>();
            PostData.Add(new KeyValuePair<string, string>("REGISTER", "RegisterNewUser"));
            string Statement = $"INSERT INTO User (Email, Password, Voornaam, Achternaam) VALUES('{Email}', '{Password}', '{Voornaam}', '{Achternaam}')";
            _ = dataAccess.SendSaveQueryAsync(Statement, CurrentUser, PostData);
        }
    }
}
