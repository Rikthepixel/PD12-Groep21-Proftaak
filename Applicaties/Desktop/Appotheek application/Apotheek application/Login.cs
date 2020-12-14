using System;
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
    public partial class Login : Form
    {
        Inlog Inlog = new Inlog();

        MasterPage masterPage;
        public bool LoginRequired { get; private set; }

        public Login(MasterPage MP)
        {
            InitializeComponent();
            masterPage = MP;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            User user = Inlog.generateUserLoginAsync(Email_txt.Text, Wachtwoord_txt.Text).Result;
            if(user != null)
            {
                if (user.IsLoginValid())
                {
                    ProductPage RedirectionPage = new ProductPage(masterPage);
                    masterPage.CurrentUser = user;
                    masterPage.Header.SetNameTag($"{user.Voornaam} {user.Achternaam}");
                    masterPage.OpenChildForm(RedirectionPage, RedirectionPage.LoginRequired);
                }
                else
                {
                    SetLoginError(Inlog.GetLoginError());
                }
            } else
            {
                SetLoginError(Inlog.GetLoginError());
            }
            masterPage.Header.UpdateHeader();
        }
        
        private void WachtwoordRemovePlaceHolder(object sender, EventArgs e)
        {
            if (Wachtwoord_txt.Text == "Wachtwoord...")
            {
                Wachtwoord_txt.Text = "";
                Console.WriteLine(Wachtwoord_txt.PasswordChar);
                Wachtwoord_txt.PasswordChar = '*';
            }
        }

        private void WachtwoordAddPlaceHolder(object sender, EventArgs e)
        {
            if (Wachtwoord_txt.Text.Trim() == null || Wachtwoord_txt.Text.Trim() == string.Empty)
            {
                Wachtwoord_txt.Text = "Wachtwoord...";
                Wachtwoord_txt.PasswordChar = '\0';
            }
        }

        private void EmailRemovePlaceHolder(object sender, EventArgs e)
        {
            if (Email_txt.Text == "Email...")
            {
                Email_txt.Text = "";
            }
        }

        private void EmailAddPlaceHolder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Email_txt.Text))
                Email_txt.Text = "Email...";
        }

        public void SetLoginError(string ErrorMessage)
        {
            label1.Text = ErrorMessage;
        }
    }
}
