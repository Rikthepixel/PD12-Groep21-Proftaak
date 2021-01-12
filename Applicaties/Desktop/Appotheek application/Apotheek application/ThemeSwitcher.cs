using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotheek_application
{
    public static class ThemeSwitcher
    {
        private static ColorScheme LightMode = new ColorScheme()
        {

            PanelBG = Color.FromArgb(88, 196, 160),
            PanelFG = Color.MediumSeaGreen,
            ButtonBG = Color.FromArgb(70, 170, 120),
            ButtonFG = Color.Black,
            ButtonBC = Color.FromArgb(88, 196, 160),
            LoginFG = Color.FromArgb(240, 240, 240),
            LoginBG = Color.FromArgb(240, 240, 240),
            TextboxFG = Color.DarkGray,
            TextboxBG = Color.White,
            Form = Color.White,
            BottomPanel = Color.White, //Color.FromArgb(88, 196, 160),
            HeaderPanel = Color.FromArgb(24, 119, 87),
            TextBorder = Color.FromArgb(88, 196, 160),
            HeaderBar = Color.FromArgb(24, 119, 87),
            ButtonHover = Color.FromArgb(20, 130, 90),
            LogoImage = Properties.Resources.LightModeHeaderLogo,
            DataGridViewColor = Color.FromArgb(255, 255, 255),
            Fiets = Color.White,
            LoginBottomPanel = Color.FromArgb(88, 196, 160),

        };

        private static ColorScheme DarkMode = new ColorScheme()
        {
            PanelBG = Color.FromArgb(84, 88, 94),
            PanelFG = Color.FromArgb(84, 88, 94),
            ButtonBG = Color.DarkGray,
            ButtonFG = Color.White,
            ButtonBC = Color.FromArgb(55, 58, 64),
            LoginFG = Color.FromArgb(95, 97, 98),
            LoginBG = Color.FromArgb(95, 97, 98), //Color.FromArgb(95, 97, 98),
            TextboxFG = Color.White,
            TextboxBG = Color.DarkGray,
            Form = Color.FromArgb(84, 88, 94),
            BottomPanel = Color.FromArgb(57, 128, 104),
            HeaderPanel = Color.FromArgb(15, 77, 56),
            TextBorder = Color.FromArgb(55, 58, 64),
            HeaderBar = Color.FromArgb(15, 77, 56),
            ButtonHover = Color.FromArgb(84, 88, 94),
            LogoImage = Properties.Resources.DarkModeHeaderLogo,
            DataGridViewColor = Color.FromArgb(95, 97, 98),
            Fiets = Color.FromArgb(57, 128, 104),
            LoginBottomPanel = Color.FromArgb(57, 128, 104),

        };


        public static void ChangeTheme(Control.ControlCollection container, bool IsLightMode)
        {
            if (IsLightMode == false)
            {
                SetTheme(LightMode, container);
            }
            else if (IsLightMode == true)
            {
                SetTheme(DarkMode, container);
            }

        }

        private static void SetTheme(ColorScheme scheme, Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                //Change to a different
                if (component is Form)
                {
                    component.BackColor = scheme.LoginBG;
                    component.ForeColor = scheme.LoginFG;
                    SetTheme(scheme, component.Controls);
                }
                if (component is LinkLabel)
                {
                    component.ForeColor = scheme.ButtonFG;
                    (component as LinkLabel).LinkColor = scheme.ButtonBC;
                    SetTheme(scheme, component.Controls);
                }
                if (component is Panel)
                {
                    if (component.BackColor != Color.Transparent)
                        component.BackColor = scheme.PanelBG;
                    if (component.ForeColor != Color.Transparent)
                        component.ForeColor = scheme.ButtonFG;
                    SetTheme(scheme, component.Controls);
                }
                if (component is Panel && component.Name == "WWVBorder")
                {
                    component.BackColor = scheme.ButtonBC;
                    SetTheme(scheme, component.Controls);
                }
                if (component is Panel && component.Name == "WWVInside")
                {
                    component.BackColor = scheme.ButtonBG;
                    component.ForeColor = scheme.ButtonFG;
                    SetTheme(scheme, component.Controls);
                }
                if (component.Name == "HeaderPanel")
                {
                    component.ForeColor = scheme.HeaderPanel;
                    component.ForeColor = scheme.HeaderPanel;
                    SetTheme(scheme, component.Controls);
                }
                if (component.Name == "BottomPanel")
                {
                    component.ForeColor = scheme.BottomPanel;
                    component.BackColor = scheme.BottomPanel;
                    SetTheme(scheme, component.Controls);
                }
                if (component.Name == "Fiets")
                {
                    component.BackColor = scheme.Fiets;
                    SetTheme(scheme, component.Controls);
                }
                if (component.Name.Contains("BorderColor"))
                {
                    component.BackColor = scheme.TextBorder;
                    component.ForeColor = scheme.TextBorder;
                    SetTheme(scheme, component.Controls);
                }
                if (component is Button)
                {
                    component.BackColor = scheme.ButtonBG;
                    component.ForeColor = scheme.ButtonFG;
                    (component as Button).FlatAppearance.MouseOverBackColor = scheme.ButtonHover;
                    (component as Button).FlatAppearance.BorderColor = scheme.ButtonBC;
                    SetTheme(scheme, component.Controls);
                }

                if (component is TextBox)
                {
                    component.BackColor = scheme.TextboxBG;
                    component.ForeColor = scheme.TextboxFG;
                    SetTheme(scheme, component.Controls);
                }

                if (component is Panel && component.Name.Contains("HeaderPanel"))
                {
                    component.BackColor = scheme.HeaderPanel;
                    component.ForeColor = scheme.HeaderPanel;
                    SetTheme(scheme, component.Controls);
                }


                if (component is PictureBox && component.Name == "Logo")
                {
                    component.BackgroundImage = scheme.LogoImage;
                    (component as PictureBox).Image = scheme.LogoImage;
                    SetTheme(scheme, component.Controls);
                }
                if (component is DataGridView)
                {
                    (component as DataGridView).BackgroundColor = scheme.DataGridViewColor;
                    SetTheme(scheme, component.Controls);
                }
                if (component is Label && component.Name == "SearchBar")
                {
                    component.ForeColor = scheme.ButtonFG;
                    component.BackColor = scheme.LoginBG;
                    SetTheme(scheme, component.Controls);
                }
                if (component is Form && component.Name == "AddUserPage")
                {
                    component.ForeColor = scheme.LoginFG;
                    component.BackColor = scheme.LoginBG;
                    SetTheme(scheme, component.Controls);
                }
                if (component is Form && component.Name == "RemovePage")
                {
                    component.ForeColor = scheme.LoginFG;
                    component.BackColor = scheme.LoginBG;
                    SetTheme(scheme, component.Controls);
                }
                if (component is Panel && component.Name == "LoginBottomPanel")
                {
                    component.ForeColor = scheme.LoginBottomPanel;
                    component.BackColor = scheme.LoginBottomPanel;
                    SetTheme(scheme, component.Controls);
                }
                if (component is NumericUpDown)
                {
                    component.BackColor = scheme.TextboxBG;
                    component.ForeColor = scheme.TextboxFG;
                    SetTheme(scheme, component.Controls);
                }
                if (component is ComboBox)
                {
                    component.BackColor = scheme.TextboxBG;
                    component.ForeColor = scheme.TextboxFG;
                    SetTheme(scheme, component.Controls);
                }
            }
        }
    }
}
