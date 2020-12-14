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
        Panel WachtwoordPanel;
        Panel WachtwoordBorder;
        MasterPage masterPage;
        public bool LoginRequired { get; private set; }

        public Login(MasterPage MP)
        {
            InitializeComponent();
            masterPage = MP;
            masterPage.Header.UpdateHeader();
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
                    masterPage.CurrentUser = user;
                    masterPage.Header.OpenProductPage(sender, e);
                    masterPage.Header.SetNameTag($"{user.Voornaam} {user.Achternaam}");
                    masterPage.Header.UpdateHeader();
                }
                else
                {
                    SetLoginError(Inlog.GetLoginError());
                }
            } else
            {
                SetLoginError(Inlog.GetLoginError());
            }
            label1.Text = Inlog.GetLoginError();
            Email_txt.Text = "";
            Wachtwoord_txt.Text = "";
            WachtwoordAddPlaceHolder(sender, e);
            EmailAddPlaceHolder(sender, e);
            masterPage.Header.UpdateHeader();
        }
        
        private void WachtwoordRemovePlaceHolder(object sender, EventArgs e)
        {
            if (Wachtwoord_txt.Text == "Wachtwoord...")
            {
                Wachtwoord_txt.Text = "";
                Console.WriteLine(Wachtwoord_txt.PasswordChar);
                Wachtwoord_txt.PasswordChar = '*';
                this.AcceptButton = Login_btn;
            }
        }

        private void WachtwoordAddPlaceHolder(object sender, EventArgs e)
        {
            if (Wachtwoord_txt.Text.Trim() == null || Wachtwoord_txt.Text.Trim() == string.Empty)
            {
                Wachtwoord_txt.Text = "Wachtwoord...";
                Wachtwoord_txt.PasswordChar = '\0';
                this.AcceptButton = null;
            }
        }

        private void EmailRemovePlaceHolder(object sender, EventArgs e)
        {
            if (Email_txt.Text == "Email...")
                Email_txt.Text = "";
            this.AcceptButton = Login_btn;
        }

        private void EmailAddPlaceHolder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Email_txt.Text))
                Email_txt.Text = "Email...";
            this.AcceptButton = null;
        }

        public void SetLoginError(string ErrorMessage)
        {
            label1.Text = ErrorMessage;
        }

        bool Wachtwoord = false;
        private void Wacht_vergeten_Link_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Wachtwoord)
            {
                if (WachtwoordPanel == null)
                {
                    Size InsideSize = new Size(500, 180);
                    int BorderSize = 4;
                    WachtwoordBorder = new Panel();
                    WachtwoordBorder.BackColor = Color.Blue;
                    WachtwoordBorder.Size = new Size(InsideSize.Width + 8, InsideSize.Height + 8);
                    Point newBorderLocation = new Point((Size.Width / 2) - (WachtwoordBorder.Size.Width / 2), (Wacht_vergeten_Link_Label.Location.Y - WachtwoordBorder.Size.Height) - 5);
                    WachtwoordBorder.Location = newBorderLocation;
                    Controls.Add(WachtwoordPanel);
                    WachtwoordBorder.Anchor = AnchorStyles.Top;
                    WachtwoordBorder.BringToFront();

                    WachtwoordPanel = new Panel();
                    WachtwoordPanel.BackColor = Color.Black;
                    WachtwoordPanel.Size = new Size(InsideSize.Width - 8, InsideSize.Height - 8); ;
                    Point newLocation = new Point((Size.Width / 2) - (WachtwoordPanel.Size.Width / 2), (Wacht_vergeten_Link_Label.Location.Y - WachtwoordPanel.Size.Height) - 5);
                    WachtwoordPanel.Location = newLocation;
                    Controls.Add(WachtwoordPanel);
                    WachtwoordPanel.Anchor = AnchorStyles.Top;
                    WachtwoordPanel.BringToFront();
                }
                else
                {
                    WachtwoordBorder.Visible = true;
                    WachtwoordPanel.Visible = true;
                }
                Wachtwoord = true;
            }
            else
            {
                WachtwoordBorder.Visible = false;
                WachtwoordPanel.Visible = false;
                Wachtwoord = false;
            }

        }
    }
}
