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

                    HttpResponseMessage LoginResponse = await CentralClient.HttpClient.PostAsync("http://127.0.0.1/Users/Login/LoginMain.php", Content).ConfigureAwait(false); //
                    var Prince = LoginResponse.Headers.ToList();
                    string JSONData = await LoginResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Console.WriteLine(JSONData);
                    LoggedInUser = JsonConvert.DeserializeObject<User>(JSONData);
                    if (LoggedInUser.loggedIn == true)
                    {
                        foreach (var item in Prince)
                        {
                            
                            if (item.Key == "Set-Cookie")
                            {
                                var Cookies = item.Value.ToList<string>();
                                //foreach (var Bescuit in Cookies)
                                //{
                                //    string Name, Value, Path = string.Empty, Domain = string.Empty;

                                //    Name = Bescuit.Substring(0, Bescuit.IndexOf('='));

                                //    if (Bescuit.IndexOf(';') != -1)
                                //    {
                                //        Value = Bescuit.Substring(Bescuit.IndexOf('=') + 1, Bescuit.IndexOf(';'));
                                //    }
                                //    else
                                //    {
                                //        Value = Bescuit.Substring(Bescuit.IndexOf('=') + 1, Bescuit.Length);
                                //    }

                                //    if (Bescuit.Contains("path"))
                                //    {
                                //        int BeginIndex, EndIndex;
                                //        BeginIndex = Bescuit.IndexOf('=', Bescuit.IndexOf("path")) + 1;
                                //        if (Bescuit.IndexOf(';', Bescuit.IndexOf("path")) != -1)
                                //        {
                                //            EndIndex = Bescuit.IndexOf(';', Bescuit.IndexOf("path"));
                                //        }
                                //        else
                                //        {
                                //            EndIndex = Bescuit.Length;
                                //        }

                                //        Path = Bescuit.Substring(BeginIndex, EndIndex - BeginIndex);
                                //    }
                                    
                                //    Cookie Oreo = new Cookie(Name, Value);
                                //    if (Path != string.Empty)
                                //        Oreo.Path = Path;
                                //    Uri BaseAdress = new Uri(LoginResponse.RequestMessage.RequestUri.Host);
                                //    CentralClient.HttpHandler.CookieContainer.Add(BaseAdress, Oreo);
                                //}
                                LoggedInUser.Cookies = Cookies;
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
