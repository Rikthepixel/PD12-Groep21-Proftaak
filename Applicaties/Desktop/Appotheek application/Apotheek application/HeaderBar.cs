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
using System.Media;

namespace Apotheek_application
{
    public partial class HeaderBar : Form
    {
        MasterPage masterPage;
        ProductPage productPage;
        OrderPage orderPage;
        HelpPage helpPage;
        AddUserPage addUserPage;
        RemovePage removePage;
        public HeaderBar(MasterPage MP)
        {
            InitializeComponent();
            masterPage = MP;
        }

        public delegate void SwitchColorEventHandler(object Source, EventArgs args);
        public event SwitchColorEventHandler ThemeSwitcherBtnClicked;
        private void Header_Load(object sender, EventArgs e)
        {
            ResetAllButtonColors();
            if (masterPage.CurrentUser != null)
            {
                if (masterPage.CurrentUser.IsLoginValid())
                {
                    Logout_btn.Text = "Uitloggen";
                    Producten_Overzicht_btn.Visible = true;
                    Bestellen_btn.Visible = true;
                    Help_btn.Visible = true;
                    NameTag_label.Visible = true;
                }
                else
                {
                    Logout_btn.Text = "Inloggen";
                    Producten_Overzicht_btn.Visible = false;
                    Bestellen_btn.Visible = false;
                    Help_btn.Visible = false;
                    NameTag_label.Visible = false;
                }
            }
            else if (masterPage.CurrentUser == null)
            {
                Logout_btn.Text = "Inloggen";
                Producten_Overzicht_btn.Visible = false;
                Bestellen_btn.Visible = false;
                Help_btn.Visible = false;
                NameTag_label.Visible = false;
            }
        }

        private void OpenBestelPage(object sender, EventArgs e)
        {
            if (masterPage.CurrentUser.IsLoginValid())
            {
                SoundPlayer Popup2 = new SoundPlayer(Properties.Resources.Popup2);
                Popup2.Play();
                if (orderPage == null)
                {
                    orderPage = new OrderPage(masterPage);
                }

                masterPage.OpenChildForm(orderPage, orderPage.LoginRequired);
                ThemeSwitcher.ChangeTheme(masterPage.Controls, !masterPage.IsLightmode);
                UpdateHeader();
            }
        }

        public void OpenProductPage(object sender, EventArgs e)
        {
            if (masterPage.CurrentUser.IsLoginValid())
            {
                if (productPage == null)
                {
                    productPage = new ProductPage(masterPage);
                }
                else
                {
                    SoundPlayer Popup2 = new SoundPlayer(Properties.Resources.Popup2);
                    Popup2.Play();
                }

                masterPage.OpenChildForm(productPage, productPage.LoginRequired);
                ThemeSwitcher.ChangeTheme(masterPage.Controls, !masterPage.IsLightmode);
                UpdateHeader();
            } else
            {
                masterPage.LoginPage.SetLoginError("LoginRequired");
            }
        }

        private void DoLogout(object sender, EventArgs e)
        {
            orderPage = null;
            productPage = null;
            masterPage.CurrentUser = new User();
            masterPage.OpenChildForm(masterPage.LoginPage, false);
            ThemeSwitcher.ChangeTheme(masterPage.ActiveForm.Controls, !masterPage.IsLightmode);
            UpdateHeader();
        }

        private void OpenHelpPage(object sender, EventArgs e)
        {
            if (masterPage.CurrentUser.IsLoginValid())
            {
                SoundPlayer Popup2 = new SoundPlayer(Properties.Resources.Popup2);
                Popup2.Play();
                if (helpPage == null)
                {
                    helpPage = new HelpPage(masterPage);
                }

                masterPage.OpenChildForm(helpPage, helpPage.LoginRequired);
                ThemeSwitcher.ChangeTheme(masterPage.Controls, !masterPage.IsLightmode);
                UpdateHeader();
            }
            else
            {
                masterPage.LoginPage.SetLoginError("LoginRequired");
            }
        }

        private void OnLogInOutButton(object sender, EventArgs e)
        {
            if(Logout_btn.Text == "Uitloggen")
            {
                SoundPlayer Boo = new SoundPlayer(Properties.Resources.Boo);
                Boo.Play();
                DoLogout(sender, e);
                ResetAllButtonColors();
            }
            else if (Logout_btn.Text == "Inloggen")
            {
                if(masterPage.ActiveForm != masterPage.LoginPage)
                {
                    masterPage.OpenChildForm(masterPage.LoginPage, masterPage.LoginPage.LoginRequired);
                    ThemeSwitcher.ChangeTheme(masterPage.Controls, !masterPage.IsLightmode);
                }
            }
            else 
            {
                
            }
            UpdateHeader();
        }

        public void UpdateHeader()
        {
            if (masterPage.CurrentUser.IsLoginValid())
            {
                Logout_btn.Visible = true;
                Logout_btn.Text = "Uitloggen";
                Producten_Overzicht_btn.Visible = true;
                Bestellen_btn.Visible = true;
                Help_btn.Visible = true;
                NameTag_label.Visible = true;
                Add_user_btn.Visible = true;
                Verwijderen_btn.Visible = true;
                Logout_btn.Text = "Uitloggen";
            }
            else
            {
                Logout_btn.Visible = false;
                Logout_btn.Text = "Inloggen";
                Producten_Overzicht_btn.Visible = false;
                Bestellen_btn.Visible = false;
                Help_btn.Visible = false;
                NameTag_label.Visible = false;
                Add_user_btn.Visible = false;
                Verwijderen_btn.Visible = false;
            }

            ResetAllButtonColors();
            Color ActiveColor = Color.FromArgb(13, 91, 65);
            ThemeSwitcher_btn.Text = "Donker Modus";
            if (!masterPage.IsLightmode)
            {
                ActiveColor = Color.FromArgb(84, 88, 94);
                ThemeSwitcher_btn.Text = "Lichte Modus";
            }

            if (masterPage.ActiveForm == orderPage) Bestellen_btn.BackColor = ActiveColor;
            else if (masterPage.ActiveForm == productPage) Producten_Overzicht_btn.BackColor = ActiveColor;
            else if (masterPage.ActiveForm == masterPage.LoginPage) Logout_btn.BackColor = ActiveColor;
            else if (masterPage.ActiveForm == helpPage) Help_btn.BackColor = ActiveColor;
            else if (masterPage.ActiveForm == addUserPage) Add_user_btn.BackColor = ActiveColor;
            else if (masterPage.ActiveForm == removePage) Verwijderen_btn.BackColor = ActiveColor;
        }

        public void SetLogInOutText(string NewButtonText)
        {
            Logout_btn.Text = NewButtonText;
        }

        public void SetNameTag(string NewNameTag)
        {
            NameTag_label.Text = NewNameTag;
        }

        private void ResetAllButtonColors()
        {
            if (masterPage.IsLightmode)
            {
                Producten_Overzicht_btn.BackColor = Color.FromArgb(70, 170, 120);
                Bestellen_btn.BackColor = Color.FromArgb(70, 170, 120);
                Help_btn.BackColor = Color.FromArgb(70, 170, 120);
                Logout_btn.BackColor = Color.FromArgb(70, 170, 120);

            }
            else
            {
                Producten_Overzicht_btn.BackColor = Color.DarkGray;
                Bestellen_btn.BackColor = Color.DarkGray;
                Help_btn.BackColor = Color.DarkGray;
                Logout_btn.BackColor = Color.DarkGray;
            }

        }

        private void ThemeSwitcher_btn_Click(object sender, EventArgs e)
        {
            OnThemeSwitched();
        }
        protected virtual void OnThemeSwitched()
        {
            if (ThemeSwitcherBtnClicked != null)
                ThemeSwitcherBtnClicked(this, EventArgs.Empty);
        }

        private void Add_user_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer Popup2 = new SoundPlayer(Properties.Resources.Popup2);
            Popup2.Play();
            if (masterPage.CurrentUser.IsLoginValid())
            {
                if (addUserPage == null)
                {
                    addUserPage = new AddUserPage(masterPage);
                }

                masterPage.OpenChildForm(addUserPage, addUserPage.LoginRequired);
                ThemeSwitcher.ChangeTheme(masterPage.Controls, !masterPage.IsLightmode);
                UpdateHeader();

            }
        }

        private void Verwijderen_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer Popup2 = new SoundPlayer(Properties.Resources.Popup2);
            Popup2.Play();
            if (masterPage.CurrentUser.IsLoginValid())
            {
                if (removePage == null)
                {
                    removePage = new RemovePage(masterPage);
                }

                masterPage.OpenChildForm(removePage, removePage.LoginRequired);
                ThemeSwitcher.ChangeTheme(masterPage.Controls, !masterPage.IsLightmode);
                UpdateHeader();
            }
        }
    }
}
