using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotheek_application
{
    public partial class HeaderBar : Form
    {
        MasterPage masterPage;
        ProductPage productPage;
        OrderPage orderPage;
        public HeaderBar(MasterPage MP)
        {
            InitializeComponent();
            masterPage = MP;
        }

        private void Header_Load(object sender, EventArgs e)
        {
            if(masterPage.CurrentUser != null)
            {
                if (masterPage.CurrentUser.IsLoginValid())
                {
                    Logout_btn.Text = "Uitloggen";
                }
                else
                {
                    Logout_btn.Text = "Inloggen";
                }
            }
            else if (masterPage.CurrentUser == null)
            {
                Logout_btn.Text = "Inloggen";
            }
        }

        private void OpenBestelPage(object sender, EventArgs e)
        {
            if (masterPage.CurrentUser.IsLoginValid())
            {
                if (orderPage == null)
                {
                    orderPage = new OrderPage();
                }

                masterPage.OpenChildForm(orderPage, orderPage.LoginRequired);
            }
        }

        private void OpenProductPage(object sender, EventArgs e)
        {

            if (masterPage.CurrentUser.IsLoginValid())
            {
                if (productPage == null)
                {
                    productPage = new ProductPage(masterPage);
                }

                masterPage.OpenChildForm(productPage, productPage.LoginRequired);
            } else
            {
                masterPage.LoginPage.SetLoginError("LoginRequired");
            }
        }

        private void DoLogout(object sender, EventArgs e)
        {
            orderPage = null;
            productPage = null;
            masterPage.CurrentUser = null;
            UpdateHeader();
        }

        private void OpenHelpPage(object sender, EventArgs e)
        {

        }

        private void OpenAPage(dynamic TargetPage)
        {
            if (masterPage.CurrentUser.IsLoginValid())
            {
                if (TargetPage == null)
                {
                    TargetPage = new ProductPage();
                }

                masterPage.OpenChildForm(TargetPage, TargetPage.LoginRequired);
            }
            else
            {

            }
        }

        private void OnLogInOutButton(object sender, EventArgs e)
        {
            if(Logout_btn.Text == "Uitloggen")
            {
                DoLogout(sender, e);
            }
            else if (Logout_btn.Text == "Inloggen")
            {
                if(masterPage.ActiveForm != masterPage.LoginPage)
                {
                    masterPage.OpenChildForm(masterPage.LoginPage, masterPage.LoginPage.LoginRequired);
                }
            }
            else 
            {
                
            }
        }

        public void UpdateHeader()
        {
            if (masterPage.CurrentUser.IsLoginValid())
            {
                Logout_btn.Text = "Uitloggen";
            }
            else
            {
                Logout_btn.Text = "Inloggen";
            }
        }

        public void SetLogInOutText(string NewButtonText)
        {
            Logout_btn.Text = NewButtonText;
        }
    }
}
