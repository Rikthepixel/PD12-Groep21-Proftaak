using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Appotheekcl.Internal;
namespace Appotheekcl
{
    public class DataAccess
    {
        public string LoginConnStr { get; private set; }
        public string ProductConnStr { get; private set; }

        public DataAccess()
        {
            
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
