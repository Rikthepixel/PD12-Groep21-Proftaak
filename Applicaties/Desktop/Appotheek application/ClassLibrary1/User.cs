﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Appotheekcl
{
    public class User
    {
        //knows
        public int ID { get; private set; }
        public string email { get; private set; } 
        public string Password { get; private set; }
        public string CreatedAt { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public bool loggedIn { get; internal set; }

        //does
        public void HidePassword()
        {
            Password = null;
        }
        public bool IsLoginValid()
        {
            bool Result = true;
            if (email == null || firstName == null || lastName == null)
            {
                Result = false;
            }

            if (loggedIn == false)
            {
                Result = false;
            }

            return Result;
        }

        public void Logout()
        {

        }


        public void setNametag()
        {

        }
    }
}
