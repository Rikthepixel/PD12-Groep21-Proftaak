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

        public User generateUserLogin(string Email, string Password, dynamic ThisForm, dynamic Redirection)
        {
            User LoggedInUser;
            DataAccess LoginTest = new DataAccess();
            Task<List<User>> Users = LoginTest.LoadData<User>(LoginTest.LoginConnStr, $"SELECT * FROM User WHERE LOWER(Email) = LOWER('{Email}') AND Password = '{Password}'");
            if(Users.Result.Count == 1)
            {
                LoggedInUser = Users.Result[0];
                LoggedInUser.Password = null;
                LoggedInUser.loggedIn = true;
                loginUser(ThisForm, Redirection);
            } else
            {
                LoggedInUser = null;
                setLoginError(Email, Password, ThisForm, Redirection);
            }
            return LoggedInUser;
        }

        public void loginUser(dynamic ThisForm, dynamic redirection)
        {
            redirection.Show();
            ThisForm.Hide();
        }

        public void setLoginError(string Email, string Password, dynamic ThisForm, dynamic Redirection) 
        {
            try
            {
                User ConnTestUser;
                DataAccess ConnTest = new DataAccess();
                Task<List<User>> Users = ConnTest.LoadData<User>(ConnTest.LoginConnStr, $"SELECT * FROM User WHERE LOWER(Email) = LOWER('{Email}') AND Password = '{Password}'");
                if(Users.Result.Count == 1)
                {
                    generateUserLogin(Email, Password, ThisForm, Redirection);
                }
            }
            catch
            {
                
            }
        }

        public void setUserNametag()
        {

        }
    }
}
