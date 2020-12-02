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
    public partial class OrderPage : Form
    {
        Order order = new Order();
        public OrderPage()
        {
            InitializeComponent();
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Xanax");
            comboBox1.Items.Add("stfrhyuijko");
            comboBox1.Items.Add("p;lokiyjuhgtrfe");
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gewicht = "test";
            string CurrentDate = "test";
            string ExpiryDate = "test";
            order.InsertNewOrder(Convert.ToString(comboBox1.Items),Convert.ToString(numericUpDown1), Gewicht, CurrentDate, ExpiryDate);
        }
    }
}
