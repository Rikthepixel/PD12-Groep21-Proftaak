using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Appotheekcl
{
    class DataAccess
    {
        HttpClient Client;
        MySqlConnection Connection;

        public string LoginConnStr { get; private set; }
        public string ProductConnStr { get; private set; }

        public DataAccess()
        {
            Client = new HttpClient();
            LoginConnStr = GetConnectionString("Login", "LoginUser", "Users", "192.168.162.187");
            ProductConnStr = GetConnectionString("producten", "Doemaarwat1", "Medical", "192.168.162.187");
        }

        private string GetConnectionString(string UserID, string Password, string Database = "", string ServerAdress = "Localhost")
        {
            string ConnectionString;
            var builder = new MySqlConnectionStringBuilder();

            builder.UserID = UserID;
            builder.Server = ServerAdress;

            if (Password != null)
            {
                builder.Password = Password;
            }
            else if (Password.Length == 0 || Password == string.Empty)
            {
                builder.Password = " ";
            }

            if (Database != null && Database.Length != 0 && Database != string.Empty)
            {
                builder.Database = Database;
            }

            ConnectionString = builder.ConnectionString;

            return ConnectionString;
        }

        public async Task<List<T>> LoadData<T>(string ConnectionString, string SQLstatement)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionString))
            {
                //Send a query to the given connection
                var rows = connection.QueryAsync<T>(SQLstatement);

                return rows.Result.ToList();
            }
        }

        public async Task<int> SaveData(string ConnectionString, string SQLstatement)
        {
            //Make a connection to a database
            using (IDbConnection connection = new MySqlConnection(ConnectionString))
            {
                //Send a query to the given connection
                return connection.ExecuteAsync(SQLstatement).Result;
            }
        }

        public async Task<int> UpdateData(string ConnectionString, string SQLStatement)
        {
            using (IDbConnection connection = new MySqlConnection(ConnectionString))
            {
                return connection.ExecuteAsync(SQLStatement).Result;
            }
        }

        public async Task<List<T>> SendQuery<T>(string SQLQuery, string Method, User User)
        {
            List<string> Cookies = new List<string>();
            Cookies.Add($"PHPSESSID={User.SessionID}");
            Cookies.Add($"RequestingKey={User.RequestingKey}");

            List<KeyValuePair<string, string>> FormData = new List<KeyValuePair<string, string>>();
            FormData.Add(new KeyValuePair<string, string>("Method", Method));
            FormData.Add(new KeyValuePair<string, string>("SQLQuery", SQLQuery));
            FormData.Add(new KeyValuePair<string, string>("DBServer", "192.168.1.10"));
            FormData.Add(new KeyValuePair<string, string>("DBUser", "producten"));
            FormData.Add(new KeyValuePair<string, string>("DBPassword", "Doemaarwat1"));
            FormData.Add(new KeyValuePair<string, string>("DBName", "Medical"));

            var Content = new FormUrlEncodedContent(FormData);
            Content.Headers.Add("Cookie", Cookies);
            HttpResponseMessage RecievedData = await Client.PostAsync("https://app-otheek.it-tutorial.info/", Content);
            return JsonConvert.DeserializeObject<List<T>>(RecievedData.Content.ToString());
        }
    }
}
