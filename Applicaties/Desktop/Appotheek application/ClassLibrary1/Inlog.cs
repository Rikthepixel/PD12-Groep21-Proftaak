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
using Appotheekcl.Internal;

namespace Appotheekcl
{
    public class Inlog : IPage
    {
        public bool LoginRequired { get; set; }
        public Form PageForm { get; set; }

        private string LoginError;
        public Inlog()
        {
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

                    HttpResponseMessage LoginResponse = await CentralClient.HttpClient.PostAsync(WebsiteLocations.LoginPage, Content).ConfigureAwait(false); //
                    var Prince = LoginResponse.Headers.ToList();
                    string JSONData = await LoginResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    LoggedInUser = JsonConvert.DeserializeObject<User>(JSONData);
                    if (LoggedInUser.loggedIn == true)
                    {
                        foreach (var item in Prince)
                        {
                            if (item.Key == "Set-Cookie")
                            {
                                LoggedInUser.Cookies = item.Value.ToList<string>();
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
