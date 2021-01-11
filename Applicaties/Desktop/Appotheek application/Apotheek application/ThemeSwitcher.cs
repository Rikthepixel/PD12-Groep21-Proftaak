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
            BottomPanel = Color.FromArgb(88, 196, 160),
            HeaderPanel = Color.FromArgb(24, 119, 87),
            TextBorder = Color.FromArgb(88, 196, 160),
            HeaderBar = Color.FromArgb(24, 119, 87),
            ButtonHover = Color.FromArgb(20, 130, 90),
            LogoImage = Properties.Resources.LightModeHeaderLogo,
            DataGridViewColor = Color.FromArgb(24, 229, 87),

        };

        private static ColorScheme DarkMode = new ColorScheme()
        {
            PanelBG = Color.FromArgb(84, 88, 94),
            PanelFG = Color.FromArgb(84, 88, 94),
            ButtonBG = Color.DarkGray,
            ButtonFG = Color.Gray,
            ButtonBC = Color.FromArgb(55, 58, 64),
            LoginFG = Color.FromArgb(95, 97, 98),
            LoginBG = Color.FromArgb(95, 97, 98),
            TextboxFG = Color.White,
            TextboxBG = Color.DarkGray,
            Form = Color.FromArgb(84, 88, 94),
            BottomPanel = Color.FromArgb(57, 128, 104),
            HeaderPanel = Color.FromArgb(15, 77, 56),
            TextBorder = Color.FromArgb(55, 58, 64),
            HeaderBar = Color.FromArgb(15, 77, 56),
            ButtonHover = Color.FromArgb(84, 88, 94),
            LogoImage = Properties.Resources.DarkModeHeaderLogo,
            DataGridViewColor = Color.FromArgb(40, 42, 46)

        };

        public static void ChangeTheme(Control.ControlCollection container, bool IsLightMode)
        {
            if (IsLightMode == false)
            {
                SetTheme(LightMode, container, IsLightMode);
            }
            else if (IsLightMode == true)
            {
                SetTheme(DarkMode, container, IsLightMode);
            }

        }

        private static void SetTheme(ColorScheme scheme, Control.ControlCollection container, bool IsLightMode)
        {
            foreach (Control component in container)
            {
                //Change to DarkMode
                if (component is Form)
                {
                    ChangeTheme(component.Controls, IsLightMode);
                    component.BackColor = scheme.LoginBG;
                    component.ForeColor = scheme.LoginFG;
                }
                if (component is LinkLabel)
                {
                    (component as LinkLabel).LinkColor = scheme.ButtonBC;
                    ChangeTheme(component.Controls, IsLightMode);
                    component.ForeColor = scheme.ButtonFG;
                }
                if (component is Panel)
                {
                    ChangeTheme(component.Controls, IsLightMode);
                    if (component.BackColor != Color.Transparent)
                        component.BackColor = scheme.PanelBG;
                    if (component.ForeColor != Color.Transparent)
                        component.ForeColor = scheme.ButtonFG;
                }
                if (component is Panel && component.Name == "WWVBorder")
                    component.BackColor = scheme.ButtonBC;
                if (component is Panel && component.Name == "WWVInside")
                    component.BackColor = scheme.ButtonBG;
                component.ForeColor = scheme.ButtonFG;
                if (component.Name == "HeaderPanel")
                {
                    ChangeTheme(component.Controls, IsLightMode);
                    component.ForeColor = scheme.HeaderPanel;
                    component.ForeColor = scheme.HeaderPanel;

                }
                if (component.Name == "BottomPanel")
                {
                    ChangeTheme(component.Controls, IsLightMode);
                    component.ForeColor = scheme.BottomPanel;
                    component.BackColor = scheme.BottomPanel;
                }
                if (component.Name.Contains("BorderColor"))
                {
                    ChangeTheme(component.Controls, IsLightMode);
                    component.BackColor = scheme.TextBorder;
                    component.ForeColor = scheme.TextBorder;
                }
                if (component is Button)
                {
                    (component as Button).FlatAppearance.BorderColor = scheme.ButtonBC;
                    ChangeTheme(component.Controls, IsLightMode);
                    component.BackColor = scheme.ButtonBG;
                    component.ForeColor = scheme.ButtonFG;
                    (component as Button).FlatAppearance.MouseOverBackColor = scheme.ButtonHover;
                }

                if (component is TextBox)
                {
                    ChangeTheme(component.Controls, IsLightMode);
                    component.BackColor = scheme.TextboxBG;
                    component.ForeColor = scheme.TextboxFG;
                }
                //if (component is Form && component.Name == ")
                //{
                //    ChangeTheme(component.Controls, IsLightMode);
                //    component.BackColor = DarkMode.HeaderBar;
                //    component.ForeColor = DarkMode.HeaderBar;
                //}
                if (component is Panel && component.Name.Contains("HeaderPanel"))
                {
                    ChangeTheme(component.Controls, IsLightMode);
                    component.BackColor = scheme.HeaderPanel;
                    component.ForeColor = scheme.HeaderPanel;
                }


                if (component is PictureBox && component.Name == "Logo")
                {
                    (component as PictureBox).Image = scheme.LogoImage;
                    ChangeTheme(component.Controls, IsLightMode);
                    component.BackgroundImage = scheme.LogoImage;

                }
                if (component is DataGridView)
                    (component as DataGridView).GridColor = scheme.DataGridViewColor;
                    ChangeTheme(component.Controls, IsLightMode);
            }
        }
    }
}
