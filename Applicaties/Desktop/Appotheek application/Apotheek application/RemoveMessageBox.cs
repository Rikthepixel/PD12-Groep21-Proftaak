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
    public partial class RemoveMessageBox : Form
    {
        public RemoveMessageBox()
        {
            InitializeComponent();
        }
        public void SetButtonColors(Color ForeColor, Color BackColor, Color BorderColor)
        {
            button1.ForeColor = ForeColor;
            button2.ForeColor = ForeColor;
            button1.BackColor = BackColor;
            button2.BackColor = BackColor;
            button1.FlatAppearance.BorderColor = BorderColor;
            button2.FlatAppearance.BorderColor = BorderColor;
        }
        public void SetWarningLabel(Image img)
        {
            pictureBox1.Image = img;
        }
    }
}
