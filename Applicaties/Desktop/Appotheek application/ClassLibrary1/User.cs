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
        public string CreatedAt { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool loggedIn { get; set; }

        //does
        public void setLoggedIn()
        {

        }
        
        public void setNametag()
        {

        }
    }
}
