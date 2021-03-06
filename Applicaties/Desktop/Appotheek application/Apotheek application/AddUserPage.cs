﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appotheekcl;

namespace Apotheek_application
{
    public partial class AddUserPage : Form
    {
        AddUser adduser = new AddUser();
        MasterPage masterpage;
        public bool LoginRequired { get; private set; }

        public AddUserPage(MasterPage masterPage)
        {
            masterpage = masterPage;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Email = Email_txt.Text;
            var Password = Password_txt.Text;
            var Voornaam = Voornaam_txt.Text;
            var Achternaam = Achternaam_txt.Text;

            adduser.InsertNewUser(Email, Password, Voornaam, Achternaam, masterpage.CurrentUser);
            Email_txt.Text = "";
            Password_txt.Text = "";
            Voornaam_txt.Text = "";
            Achternaam_txt.Text = "";
        }
    }
}
