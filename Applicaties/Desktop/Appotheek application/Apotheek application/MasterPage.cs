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
    public partial class MasterPage : Form
    {
        public bool LoggedIn { get; set; }
        public Form Header { get; set; }
        public List<Form> Pages { get; private set; }
        public MasterPage()
        {
            InitializeComponent();
            Pages = new List<Form>();
            Login login = new Login();
            Header = new MainMenu();
            Pages.Add(login);
        }

        private Form ActiveForm { get; set; }
        private Form Headr { get; set; }

        private void MasterPage_Load(object sender, EventArgs e)
        {
            OpenChildForm(Header, HeaderPanel, ActiveForm);
            OpenChildForm(Pages[0], ChildFormPanel, Headr);
        }

        private void OpenChildForm(Form Page, dynamic InPanel, Form ActiveForm)
        {
            LoggedIn = true;
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = Page;
            Page.TopLevel = false;
            Page.FormBorderStyle = FormBorderStyle.None;
            Page.Dock = DockStyle.Fill;
            InPanel.Controls.Add(Page);
            InPanel.Tag = Page;
            Page.BringToFront();
            Page.Show();
        }

        private bool GetLoggedIn(User CurrentUser)
        {
            string Error = null;
            if(CurrentUser.email == null || CurrentUser.firstName == null || CurrentUser.lastName == null)
            {
                Error = "InvalidCredentials";
            }
            if(CurrentUser.loggedIn == false)
            {
                Error = "InvalidLogin";
            }

            if(Error != null)
            {
                return false;
            } else if(Error == null){
                return true;
            } else
            {
                return false;
            }
        }
    }
}
