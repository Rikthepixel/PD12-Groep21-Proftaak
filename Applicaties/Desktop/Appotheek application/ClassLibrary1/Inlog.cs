using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public User generateUserLogin(string Email, string Password)
        {
            User LoggedInUser = null;
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                LoggedInUser = null;
                setLoginError("EmptyBoxes");
            }
            else
            {

                try
                {
                    DataAccess LoginTest = new DataAccess();
                    Task<List<User>> Users = LoginTest.LoadData<User>(LoginTest.LoginConnStr, $"SELECT * FROM User WHERE LOWER(Email) = LOWER('{Email}') AND Password = '{Password}'");
                    if (Users.Result.Count == 1)
                    {
                        LoggedInUser = Users.Result[0];
                        LoggedInUser.Password = null;
                        LoggedInUser.loggedIn = true;
                        LoginError = string.Empty;
                    }
                    else
                    {
                        LoggedInUser = null;
                        setLoginError("InvalidDetails");
                    }
                }
                catch (Exception e)
                {
                    setLoginError(e);
                    throw;
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
                LoginError = "UnknowError";
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
