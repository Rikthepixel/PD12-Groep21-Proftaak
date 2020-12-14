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
    public partial class HelpPage : Form
    {
        public bool LoginRequired { get; private set; }
        public HelpPage(MasterPage MP)
        {
            InitializeComponent();
            LoginRequired = true;
        }
    }
}
