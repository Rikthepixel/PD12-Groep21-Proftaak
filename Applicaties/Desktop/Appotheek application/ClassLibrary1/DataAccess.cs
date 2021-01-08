using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Appotheekcl.Internal;
namespace Appotheekcl
{
    public class DataAccess
    {
        MySqlConnection Connection;

        public string LoginConnStr { get; private set; }
        public string ProductConnStr { get; private set; }

        public DataAccess()
        {
            
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

        public async Task<KeyValuePair<string, bool>> SendSaveQueryAsync(string SQLQuery, User User)
        {
            if (User.loggedIn)
            {
                List<KeyValuePair<string, string>> FormData = new List<KeyValuePair<string, string>>();
                FormData.Add(new KeyValuePair<string, string>("SQLQuery", SQLQuery));

                var Content = new FormUrlEncodedContent(FormData);
                string CookieString = "";
                foreach (var Cookie in User.Cookies)
                {
                    CookieString += $"{Cookie};";
                }
                Content.Headers.Add("Cookie", CookieString);

                HttpResponseMessage RecievedData = await CentralClient.HttpClient.PostAsync(WebsiteLocations.QueryPage, Content);
                string RecievedDataString = await RecievedData.Content.ReadAsStringAsync();
                if (RecievedDataString.Length != 0)
                {
                    var Awnser = JsonConvert.DeserializeObject<QueryResponse>(RecievedDataString);
                    if (Awnser.succesful == "Query was succefully executed")
                        return new KeyValuePair<string, bool>("succesful", true);
                    else if (Awnser.succesful == "Unable to execute query")
                        return new KeyValuePair<string, bool>("succesful", false);
                    else
                        return new KeyValuePair<string, bool>("succesful", false);
                }
                else
                {
                    return new KeyValuePair<string, bool>("succesful", false);
                }
            }
            else
            {
                return new KeyValuePair<string, bool>("succesful", false);
            }
        }

        public async Task<T> SendQueryAsync<T>(string SQLQuery, User User)
        {
            if (User.loggedIn)
            {
                List<KeyValuePair<string, string>> FormData = new List<KeyValuePair<string, string>>();
                FormData.Add(new KeyValuePair<string, string>("SQLQuery", SQLQuery));

                var Content = new FormUrlEncodedContent(FormData);
                string CookieString = "";
                foreach (var Cookie in User.Cookies)
                {
                    CookieString += $"{Cookie};";
                }
                Content.Headers.Add("Cookie", CookieString);
                
                HttpResponseMessage RecievedData = await CentralClient.HttpClient.PostAsync(WebsiteLocations.QueryPage, Content);
                string RecievedDataString = await RecievedData.Content.ReadAsStringAsync();
                if (RecievedDataString.Length != 0)
                {
                    return JsonConvert.DeserializeObject<T>(RecievedDataString);
                }
                else
                {
                    return default(T);
                }
            }
            else
            {
                return default(T);
            }
        }

        internal class QueryResponse
        {
            public string succesful { get; set; }
        }
    }
}
