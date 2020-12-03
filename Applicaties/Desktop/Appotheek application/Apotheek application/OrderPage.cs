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
            Medicijn_cB.Items.Add("Xanac");
            Medicijn_cB.Items.Add("ibuprofen");
            Medicijn_cB.Items.Add("oxazepam");
            
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Medicijn = Medicijn_cB.Text;
            var Nummerof = Aantal_Medicijnen_UpDown.Value;
            var arryWeight = order.GetWeight(Medicijn);
            var Weight = arryWeight.Result[0];
            string CurrentDate = DateTime.Now.ToString("yyyy-MM-dd");
            int ExpiryMonth = Convert.ToInt32(DateTime.Now.ToString("MM")) +2;
            int ExpiryYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int Month = Convert.ToInt32(ExpiryMonth);
            if (Month > 12)
            {
                ExpiryYear = ExpiryYear + 1;
                Month = Month - 12;
            }
            string ExpiryDate = DateTime.Now.ToString($"{ExpiryYear}-{Month}-dd");
            Console.WriteLine(Medicijn);
            Console.WriteLine(Nummerof);
            Console.WriteLine(Weight);
            Console.WriteLine(CurrentDate);
            Console.WriteLine(ExpiryDate);
            order.InsertNewOrder(Medicijn, Convert.ToString(Nummerof), Weight, CurrentDate, ExpiryDate);
        }

        private void Bestel_image_Click(object sender, EventArgs e)
        {

        }
    }
}
