using Dapper;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SQLDataLibrary
{
    public class DataAccess
    {
        /// <summary>
        /// Creates a connectionstring for connecting to a MySql server.
        /// </summary>
        /// <remarks>
        /// Database User:<br></br>
        /// UserID and password are required variables.<br></br>
        /// <br></br>
        /// Server information:<br></br>
        /// ServerAdress defaults to LocalHost, but should be set to your target IP.<br></br>
        /// Port is not required and defaults to 3306 (default MySql port), can be set if required.<br></br>
        /// <br></br>
        /// Database:<br></br>
        /// Database Doesnt have to be set.
        /// </remarks>
        /// <param name="ServerAdress">should be set to the IP-Adress of your target server (not required) (Default is Localhost)</param>
        /// <param name="Port">can be set to the Port which the SQL server is listening to (not required) (Default is 3306)</param>
        /// <param name="UserID">should be set to the Username of the MySQL user (required)</param>
        /// <param name="Password">should be set to the Password of the MySQL user (required)</param>
        /// <param name="Database">can be set to the target Database you want to connect to (not required)</param>
        /// <returns>Returns a connectionstring based on the inserted values</returns>
        public string GetConnectionString(string UserID, string Password, string ServerAdress="Localhost", string Port="3306",  string Database="")
        {
            var builder = new MySqlConnectionStringBuilder();

            //If the inserted data is null dont include it in the construction string
            builder.UserID = UserID;
            builder.Server = ServerAdress;

            if (Password != null)
            {
                builder.Password = Password;
            }
            else if(Password.Length == 0 || Password == string.Empty)
            {
                builder.Password = " ";
            }

            if (Database != null && Database.Length != 0 && Database != string.Empty)
            {
                builder.Database = Database;
            }

            if (Port != null && Port.Length != 0 && Port != string.Empty)
            {
                builder.Port = Convert.ToUInt32(Port);
            }

            string ConnectionString = builder.ToString();

            return ConnectionString; 
        }

        /// <summary>
        /// Sends a query to a new connection
        /// </summary>
        /// <typeparam name="T">Format the data should be fed into (like a class) </typeparam>
        /// <typeparam name="U">Set it to dynamic</typeparam>
        /// <param name="ConnectionString">The connectionstring to the server</param>
        /// <param name="sql">Should be set to a SQL statement</param>
        /// <param name="parameters"></param>
        /// <returns>Returns a List which adhears to the format of T</returns>
        public async Task<List<T>> LoadData<T, U>(string ConnectionString, string sql, U parameters)
        {
            //Make a connection to the database
            using (IDbConnection connection = new MySqlConnection(ConnectionString))
            {
                //Send a query to the given connection
                var rows = await connection.QueryAsync<T>(sql, parameters);

                //return the data
                return rows.ToList();
            }
        }

        /// <summary>
        /// Sends a query to a new connection
        /// </summary>
        /// <typeparam name="T">Format the data should be fed into (like a class) </typeparam>
        /// <param name="ConnectionString">The connectionstring to the server</param>
        /// <param name="SQLstatement">Should be set to a SQL statement</param>
        /// <returns>Returns a List which adhears to the format of T</returns>
        public async Task<List<T>> LoadData<T>(string ConnectionString, string SQLstatement)
        {
            //Make a connection to a database
            using (IDbConnection connection = new MySqlConnection(ConnectionString))
            {
                //Send a query to the given connection
                var rows = await connection.QueryAsync<T>(SQLstatement);

                return rows.ToList();
            }
        }

        /// <summary>
        /// Sends a query to a pre-existing connection
        /// </summary>
        /// <typeparam name="T">Format the data should be fed into (like a class) </typeparam>
        /// <param name="Connection">A pre-existing connection</param>
        /// <param name="SQLstatement">Should be set to a SQL statement</param>
        /// <returns>Returns a List which adhears to the format of T</returns>
        public async Task<List<T>> LoadData<T>(MySqlConnection Connection, string SQLstatement)
        {
            using (Connection)
            {
                var rows = await Connection.QueryAsync<T>(SQLstatement);
                return rows.ToList();
            }
        }


        public Task SaveData<T>(string ConnectionString, string sql, T parameters)
        {
            //Make a connection to a database
            using (IDbConnection connection = new MySqlConnection(ConnectionString))
            {
                //Send a query to the given connection
                return connection.ExecuteAsync(sql, parameters);
            }
        }
        public Task SaveData<T>(MySqlConnection Connection, string sql, T parameters)
        {
            //Make a connection to a database
            using (Connection)
            {
                //Send a query to the given connection
                return Connection.ExecuteAsync(sql, parameters);
            }
        }



        /// <summary>
        /// Opens an asynchronous connection to the specified server
        /// </summary>
        /// <param name="ConnectionString"></param>
        /// <returns></returns>
        public async Task<MySqlConnection> OpenAsyncConnection(string ConnectionString)
        {
            MySqlConnection Connection = new MySqlConnection(ConnectionString);
            await Connection.OpenAsync();
            return Connection;
        }
        public MySqlConnection OpenConnection(string ConnectionString)
        {
            MySqlConnection Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
            return Connection;
        }
        public bool PingConnection(MySqlConnection Connection)
        {
            try
            {
                bool result = Connection.Ping();
                return result;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool CloseConnection(MySqlConnection Connection)
        {
            bool Result = false;
            Connection.Close();
            switch (Connection.State)
            {
                case ConnectionState.Broken:
                    Result = false;
                    break;
                case ConnectionState.Closed:
                    Result = true;
                    break;
                case ConnectionState.Connecting:
                    Result = false;
                    break;
                case ConnectionState.Executing:
                    Result = false;
                    break;
                case ConnectionState.Fetching:
                    Result = false;
                    break;
                case ConnectionState.Open:
                    Result = false;
                    break;
            }
            return Result;
        }
        public async Task<bool> CloseAsyncConnection(MySqlConnection Connection)
        {
            bool Result = false;
            await Connection.CloseAsync();
            switch (Connection.State)
            {
                case ConnectionState.Broken:
                    Result = false;
                    break;
                case ConnectionState.Closed:
                    Result = true;
                    break;
                case ConnectionState.Connecting:
                    Result = false;
                    break;
                case ConnectionState.Executing:
                    Result = false;
                    break;
                case ConnectionState.Fetching:
                    Result = false;
                    break;
                case ConnectionState.Open:
                    Result = false;
                    break;
            }
            return Result;
        }
    }
}
