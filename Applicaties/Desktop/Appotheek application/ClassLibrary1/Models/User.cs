using System;
using System.Collections.Generic;
using System.Text;

namespace Appotheekcl
{
    public class User
    {
        //knows
        public int ID { get; set; }
        public string email { get; set; } 
        public string Password { get; set; }
        public string Created_At { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public bool loggedIn { get; set; }
           
        public List<string> Cookies { get; set; }
        public string loginerror { get; set; }
        //does
        public void HidePassword()
        {
            Password = null;
        }
        public bool IsLoginValid()
        {
            bool Result = true;
            if (email == null || Voornaam == null || Achternaam == null)
            {
                Result = false;
            }

            if (loggedIn == false)
            {
                Result = false;
            }

            return Result;
        }

        public void Login(User LoggedInUser)
        {

        }


        public void setNametag()
        {

        }
    }
}
