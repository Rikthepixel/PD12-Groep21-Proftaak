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
    public partial class Login : Form
    {
        Inlog Inlog = new Inlog();

        #region WachtWoord vergreten panel

        Panel WachtwoordPanel;
        Panel WachtwoordBorder;
        Label WWVTopLine;
        Label WWVMidLine;
        Label TelLine;

        #endregion

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
                    SoundPlayer Correct3 = new SoundPlayer(Properties.Resources.Correct3);
                    Correct3.Play();
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
            SoundPlayer Incorrect = new SoundPlayer(Properties.Resources.Incorrect);
            Incorrect.Play();
        }

        bool Wachtwoord = false;
        private void Wacht_vergeten_Link_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if (!Wachtwoord)
            {
                if (WachtwoordPanel == null)
                {
                    Size InsideSize = new Size(450, 100);
                    int BorderSize = 4;
                    int TextPaddingTop = 10;
                    int TextPaddingBottom = 10;

                    #region PassWord Forgotten Border
                    WachtwoordBorder = new Panel();
                    WachtwoordBorder.BackColor = Color.FromArgb(23, 115, 84);
                    WachtwoordBorder.Size = new Size(InsideSize.Width + BorderSize * 2, InsideSize.Height + BorderSize * 2);
                    Point newBorderLocation = new Point((Size.Width / 2) - (WachtwoordBorder.Size.Width / 2), (Wacht_vergeten_Link_Label.Location.Y - WachtwoordBorder.Size.Height) - 5);
                    WachtwoordBorder.Location = newBorderLocation;
                    Controls.Add(WachtwoordBorder);
                    WachtwoordBorder.Anchor = AnchorStyles.Top;
                    WachtwoordBorder.BringToFront();
                    #endregion

                    #region PassWord Forgotten Panel
                    WachtwoordPanel = new Panel();
                    WachtwoordBorder.Controls.Add(WachtwoordPanel);

                    WachtwoordPanel.BackColor = Color.FromArgb(235, 235, 235);
                    WachtwoordPanel.Size = InsideSize;
                    Point newLocation = new Point(BorderSize, BorderSize);
                    WachtwoordPanel.Location = newLocation;
                    WachtwoordPanel.Anchor = AnchorStyles.Top;
                    #endregion

                    #region PassWord Forgotten Text

                    Font LabelFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    #region TopLine
                    WWVTopLine = new Label();
                    Point TopLineLocation = new Point(0, TextPaddingTop);
                    WWVTopLine.Location = TopLineLocation;
                    WWVTopLine.AutoSize = false;
                    WWVTopLine.TextAlign = ContentAlignment.MiddleCenter;
                    WWVTopLine.Size = new Size(WachtwoordPanel.Size.Width, WWVTopLine.Size.Height);
                    WWVTopLine.Text = "Neem a.u.b. contact op met uw systeembeheer om";
                    WWVTopLine.Font = LabelFont;
                    #endregion

                    #region MidLine
                    WWVMidLine = new Label();
                    Point MidLineLocation = new Point(0, TopLineLocation.Y + WWVMidLine.Size.Height);
                    WWVMidLine.Location = MidLineLocation;
                    WWVMidLine.AutoSize = false;
                    WWVMidLine.TextAlign = ContentAlignment.MiddleCenter;
                    WWVMidLine.Size = new Size(WachtwoordPanel.Size.Width, WWVMidLine.Size.Height);
                    WWVMidLine.Text = "uw wachtwoord te veranderen";
                    WWVMidLine.Font = LabelFont;
                    #endregion

                    #region TelLine
                    TelLine = new Label();
                    Point TelLineLocation = new Point(0, MidLineLocation.Y + WWVMidLine.Size.Height + 30);
                    TelLine.Location = TelLineLocation;
                    TelLine.AutoSize = false;
                    TelLine.TextAlign = ContentAlignment.MiddleCenter;
                    TelLine.Size = new Size(WachtwoordPanel.Size.Width, TelLine.Size.Height);
                    TelLine.Text = "Tel:pl4c3h0ld3r";
                    TelLine.Font = LabelFont;
                    #endregion

                    WachtwoordPanel.Controls.Add(WWVTopLine);
                    WachtwoordPanel.Controls.Add(WWVMidLine);
                    WachtwoordPanel.Controls.Add(TelLine);

                    WachtwoordBorder.Location = new Point(WachtwoordBorder.Location.X, WachtwoordBorder.Location.Y - (TextPaddingBottom + TextPaddingTop));
                    WachtwoordBorder.Size = new Size(WachtwoordBorder.Size.Width, WachtwoordBorder.Size.Height + (TextPaddingBottom + TextPaddingTop));
                    WachtwoordPanel.Size = new Size(WachtwoordPanel.Size.Width, WachtwoordPanel.Size.Height + (TextPaddingBottom + TextPaddingTop));
                    #endregion
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
