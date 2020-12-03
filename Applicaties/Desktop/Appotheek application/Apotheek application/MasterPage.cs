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
        public List<IPage> Pages { get; private set; }
        public MasterPage()
        {
            InitializeComponent();
        }

        private Form ActiveForm;
        private void OpenChildForm(IPage Page)
        {
            LoggedIn = true;
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveForm = Page.PageForm;
            Page.PageForm.TopLevel = false;
            Page.PageForm.FormBorderStyle = FormBorderStyle.None;
            Page.PageForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(Page.PageForm);
            ChildFormPanel.Tag = Page.PageForm;
            Page.PageForm.BringToFront();
            Page.PageForm.Show();
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
