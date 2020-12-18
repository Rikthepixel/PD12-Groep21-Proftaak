using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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
            HttpClientHandler Handler = new HttpClientHandler();
            Client = new HttpClient(Handler);
            
            LoginError = string.Empty;
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

                    HttpResponseMessage LoginResponse = await Client.PostAsync("http://127.0.0.1/Users/Login/LoginMain.php", Content); //https://app-otheek.it-tutorial.info/Users/Login/LoginMain.php
                    
                    List<string> Prince = LoginResponse.Content.Headers.GetValues("Set-Cookie").ToList();
                    Console.WriteLine("COOKIES!!!");
                    foreach (var Cookies in Prince)
                    {
                        string CookieNaam = Cookies.Substring(0, Cookies.IndexOf('='));
                        if ("RequestingKey" == CookieNaam)
                        {
                            LoggedInUser = JsonConvert.DeserializeObject<User>(LoginResponse.Content.ToString());
                            LoggedInUser.RequestingKey = Cookies.Substring(Cookies.IndexOf('=') + 1, Cookies.IndexOf(';') - 1);
                        }
                        if ("PHPSESSID" == CookieNaam)
                        {
                            LoggedInUser.SessionID = Cookies.Substring(Cookies.IndexOf('=') + 1, Cookies.IndexOf(';') - 1);
                        }
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
