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

        public User loginUser(string Email, string Password)
        {
            User LoggedInUser;
            DataAccess LoginTest = new DataAccess();
            Task<List<User>> Users = LoginTest.LoadData<User>(LoginTest.LoginConnStr, $"SELECT * FROM User WHERE LOWER(Email) = LOWER('{Email}') AND Password = '{Password}'");
            if(Users.Result.Count == 1)
            {
                LoggedInUser = Users.Result[0];
                LoggedInUser.Password = null;
                LoggedInUser.loggedIn = true;
            } else
            {
                LoggedInUser = null;
            }
            return LoggedInUser;
        }

            public void generateUserLogin()
        {

        }
        public void setLoginError() 
        {

        }

        public void setUserNametag()
        {

        }

     }
}
