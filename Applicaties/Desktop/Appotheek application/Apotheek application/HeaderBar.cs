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

        private void MainMenu_Load(object sender, EventArgs e)
        {

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
                    productPage = new ProductPage();
                }

                masterPage.OpenChildForm(productPage, productPage.LoginRequired);
            }
        }

        private void DoLogout(object sender, EventArgs e)
        {
            orderPage = null;
            productPage = null;
            masterPage.CurrentUser.Logout();
        }

        private void OpenHelpPage(object sender, EventArgs e)
        {

        }
    }
}
