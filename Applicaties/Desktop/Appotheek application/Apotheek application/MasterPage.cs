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
    public partial class MasterPage : Form
    { 
        public bool IsLightmode { get; set; }
        public bool LoggedIn { get; set; }
        public HeaderBar Header { get; private set; }
        public User CurrentUser { get; set; }
        public Login LoginPage;
        public MasterPage()
        {
            InitializeComponent();
            CurrentUser = new User();
            Header = new HeaderBar(this);
            LoginPage = new Login(this);
            IsLightmode = true;
            Header.ThemeSwitcherBtnClicked += OnColorSwitch;
        }

        public Form ActiveForm { get; private set; }
        private Form Headr { get; set; }

        private void MasterPage_Load(object sender, EventArgs e)
        {
            OpenChildForm(Header, HeaderPanel, Headr);
            OpenChildForm(LoginPage, LoginPage.LoginRequired);
            Header.UpdateHeader();
        }

        public void OpenChildForm(Form Page, dynamic InPanel, Form ActiveForm)
        {
            LoggedIn = true;

            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }

            ActiveForm = Page;
            Page.TopLevel = false;
            Page.FormBorderStyle = FormBorderStyle.None;
            Page.Dock = DockStyle.Fill;
            InPanel.Controls.Add(Page);
            InPanel.Tag = Page;
            Page.BringToFront();
            Page.Show();
        }

        public void OpenChildForm(Form Page, bool LoginRequired)
        {
            bool IsLoggedIn;
            if (LoginRequired)
            {
                IsLoggedIn = CurrentUser.IsLoginValid();
                if (IsLoggedIn)
                {
                    if (ActiveForm != null)
                    {
                        ActiveForm.Hide();
                    }

                    ActiveForm = Page;
                    Page.TopLevel = false;
                    Page.FormBorderStyle = FormBorderStyle.None;
                    Page.Dock = DockStyle.Fill;
                    ChildFormPanel.Controls.Add(Page);
                    ChildFormPanel.Tag = Page;
                    Page.BringToFront();
                    Page.Show();
                }
                else
                {
                    
                }
            } 
            else
            {
                if (ActiveForm != null)
                {
                    ActiveForm.Hide();
                }

                ActiveForm = Page;
                Page.TopLevel = false;
                Page.FormBorderStyle = FormBorderStyle.None;
                Page.Dock = DockStyle.Fill;
                ChildFormPanel.Controls.Add(Page);
                ChildFormPanel.Tag = Page;
                Page.BringToFront();
                Page.Show();
            }
        }

        private bool GetLoggedIn(User CurrentUser)
        {
            string Error = null;
            if(CurrentUser.email == null || CurrentUser.Voornaam == null || CurrentUser.Achternaam == null)
            {
                Error = "InvalidCredentials";
            }
            if(CurrentUser.loggedIn == false)
            {
                Error = "InvalidLogin";
            }
            if(CurrentUser.Created_At == null)
            {
                Error = "InvalidCreation";
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

        private void OnColorSwitch(object source, EventArgs args)
        {
            ThemeSwitcher.ChangeTheme(this.Controls, IsLightmode);
            
            if (IsLightmode == true)
            {
                IsLightmode = false;
            }
            else
            {
                IsLightmode = true;
            }
            Header.UpdateHeader();
        }
    }
}
