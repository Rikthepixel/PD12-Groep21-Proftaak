using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appotheekcl
{
    public class Inlog : IPage
    {
        HttpClient Client;
        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        private string LoginError;
        public Inlog()
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = (DecompressionMethods)(-1)
            };
            Client = new HttpClient(handler);
            SetHeaders(Client);

            LoginError = string.Empty;
        }
        private static void SetHeaders(HttpClient Client)
        {
            Client.DefaultRequestHeaders.Add("Accept", "*/*");

            Client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip");
            Client.DefaultRequestHeaders.Add("Accept-Encoding", "deflate");
            Client.DefaultRequestHeaders.Add("Accept-Encoding", "br");

            Client.DefaultRequestHeaders.Add("Accept-Language", "nl");
            Client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            Client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.88 Safari/537.36 Edg/87.0.664.57");
            Client.DefaultRequestHeaders.Add("X-Requested-With", "XMLHttpRequest");

            //Client.DefaultRequestHeaders.Add("Host", "steamcommunity.com");
            //Client.DefaultRequestHeaders.Add("Origin", "https://steamcommunity.com");
            //Client.DefaultRequestHeaders.Add("Referer", "https://steamcommunity.com/login/home/?goto=");

            //Client.DefaultRequestHeaders.Add("Sec-Fetch-Dest", "empty");
            //Client.DefaultRequestHeaders.Add("Sec-Fetch-Mode", "cors");
            //Client.DefaultRequestHeaders.Add("Sec-Fetch-Site", "same-origin");
        }

        public async Task<User> generateUserLoginAsync(string Email, string Password)
        {

            User LoggedInUser = null;
            if (string.IsNullOrEmpty(Email) || Email == "Email..." || string.IsNullOrEmpty(Password) || Password == "Wachtwoord...")
            {
                LoggedInUser = null;
                setLoginError("EmptyBoxes");
            }
            else
            {
                try
                {
                    List<KeyValuePair<string, string>> Data = new List<KeyValuePair<string, string>>();
                    Data.Add(new KeyValuePair<string, string>("EML", Email));
                    Data.Add(new KeyValuePair<string, string>("PSWD", Password));
                    Data.Add(new KeyValuePair<string, string>("Login", "AUserWantsToLogin"));
                    Data.Add(new KeyValuePair<string, string>("IsApplication", "IAMTHEAPPLICATION"));
                    var Content = new FormUrlEncodedContent(Data);

                    HttpResponseMessage LoginResponse = await Client.PostAsync("http://127.0.0.1/Users/Login/LoginMain.php", Content).ConfigureAwait(false); //https://app-otheek.it-tutorial.info/Users/Login/LoginMain.php
                    var Prince = LoginResponse.Headers.ToList();
                    string JSONData = await LoginResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    LoggedInUser = JsonConvert.DeserializeObject<User>(JSONData);
                    if (LoggedInUser.loggedIn == true)
                    {
                        foreach (var item in Prince)
                        {
                            if (item.Key == "Set-Cookie")
                            {
                                var Cookies = item.Value.ToList<string>();
                                foreach (var Cookie in Cookies)
                                {
                                    string CookieNaam = Cookie.Substring(0, Cookie.IndexOf('='));
                                    int StartIndex = Cookie.IndexOf('=') + 1;
                                    int Length = Cookie.Length - StartIndex;
                                    if (Cookie.IndexOf(';') != -1)
                                    {
                                        Length = Cookie.IndexOf(';') - 1 - StartIndex;
                                    }
                                    if ("RequestingKey" == CookieNaam)
                                    {
                                        LoggedInUser.RequestingKey = Cookie.Substring(StartIndex, Length);
                                    }
                                    if ("PHPSESSID" == CookieNaam)
                                    {
                                        LoggedInUser.SessionID = Cookie.Substring(StartIndex, Length);
                                    }
                                }
                                break;
                            }
                        }

                    }
                    else
                    {
                        setLoginError(LoggedInUser.LoginError);
                        LoggedInUser = null;
                    }
                    
                    
                }
                catch (Exception e)
                {
                    throw e;
                    setLoginError(e);
                }
            }
            return LoggedInUser;
        }

        private void setLoginError(Exception e) 
        {
            Console.WriteLine(e.HResult); //-2146233088 for No connection
            if(e.HResult == -2146233088)
            {
                LoginError = "NoDBConnection";
            } else
            {
                LoginError = "UnknownError";
            }
        }
        private void setLoginError(string Error)
        {
            LoginError = Error;
        }
        
        public string GetLoginError()
        {
            return LoginError;
        }
        public void setUserNametag()
        {

        }
    }
}
