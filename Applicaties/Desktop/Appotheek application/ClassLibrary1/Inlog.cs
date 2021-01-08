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

        public delegate void OnLoginRecievedEventHandler(object source, LoginRecievedArgs args);
        public event OnLoginRecievedEventHandler OnLoginRecieved;

        public Inlog()
        {
            LoginError = string.Empty;
        }

        public async Task DoLoginUserAsync(string Email, string Password)
        {

            User LoggedInUser = null;
            if (string.IsNullOrEmpty(Email) || Email == "Email..." || string.IsNullOrEmpty(Password) || Password == "Wachtwoord...")
            {
                LoggedInUser = null;
                setLoginError("Vul alstublieft alle inlog gegevens in");
            }
            else
            {
                try
                {
                    LoggedInUser = await DoLoginAsync(Email, Password);
                }
                catch (Exception e)
                {
                    setLoginError(e);
                }
            }

            LoginError = LoggedInUser.loginerror;
            LoginRecieved(LoggedInUser);
        }

        protected virtual void LoginRecieved(User LoggedInUser)
        {
            if (OnLoginRecieved != null)
                OnLoginRecieved(this, new LoginRecievedArgs(LoggedInUser));
        }

        private void setLoginError(Exception e)
        {
            Console.WriteLine(e.HResult); //-2146233088 for No connection
            if (e.HResult == -2146233088)
            {
                LoginError = "Er kon geen Connectie worden gemaakt met de LoginService";
            }
            else
            {
                LoginError = "Er is een onbekende fout opgetreden";
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

        /// <summary>
        /// Logs-in the user
        /// </summary>
        /// <param name="Email"></param>
        /// <param name="Password"></param>
        /// <returns>The loggedin user and a List of cookies</returns>
        public async Task<User> DoLoginAsync(string Email, string Password)
        {
            List<KeyValuePair<string, string>> PostData = new List<KeyValuePair<string, string>>();
            PostData.Add(new KeyValuePair<string, string>("EML", Email));
            PostData.Add(new KeyValuePair<string, string>("PSWD", Password));
            PostData.Add(new KeyValuePair<string, string>("Login", "AUserWantsToLogin"));
            PostData.Add(new KeyValuePair<string, string>("Login", "AUserWantsToLogin"));
            PostData.Add(new KeyValuePair<string, string>("IsApplication", "true"));
            var PostContent = new FormUrlEncodedContent(PostData);

            //TimeSpan DefaultTimeOut = CentralClient.HttpClient.Timeout;
            HttpResponseMessage LoginResponse = await CentralClient.HttpClient.PostAsync(WebsiteLocations.LoginPage, PostContent).ConfigureAwait(false);
            // ^ sends a LoginRequest to the website

            User LoggedInUser = null;
            //Reads the response which the website gave to us and puts that response into a new User class instance
            try
            {
                string JSONData = await LoginResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                Console.WriteLine(JSONData);
                LoggedInUser = JsonConvert.DeserializeObject<User>(JSONData);
                
                //This loop gets the cookies which the website gave as a response and saves that into the new User instance
                if (LoggedInUser.loggedIn == true)
                {
                    var Prince = LoginResponse.Headers.ToList();
                    foreach (var item in Prince)
                    {
                        _ = Task.Run(() =>
                        {
                            if (item.Key == "Set-Cookie")
                            {
                                LoggedInUser.Cookies = item.Value.ToList<string>();
                            }
                        });

                    }
                }
                
            }
            catch (Exception e)
            {

                if (e is TaskCanceledException)
                    LoginError = "Er kon geen verbinding gemaakt worden met de website want ";
                else
                    LoginError = "Er kon geen verbinding gemaakt worden met de website voor onbekende redenen";
            }

            return LoggedInUser;
        }
    }

    public class LoginRecievedArgs : EventArgs
    {
        public LoginRecievedArgs(User LoggedinUser)
        {
            LoggedInUser = LoggedinUser;
        }
        public User LoggedInUser { get; set; }
    }
}
