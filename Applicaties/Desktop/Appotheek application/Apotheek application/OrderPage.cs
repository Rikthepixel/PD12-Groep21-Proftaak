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
using Syncfusion.Windows.Forms;

namespace Apotheek_application
{
    public partial class OrderPage : Form
    {
        Order order = new Order();

        public bool LoginRequired { get; private set; }

        public OrderPage()
        {
            InitializeComponent();
        }
        static void Main()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzYxOTk1QDMxMzgyZTMzMmUzME54V2U2ZXo3R3FsTVhmVjlEOTBYanpnc2JSOGQ4UkdrWllYY1ZTdEgwYXc9");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OrderPage());
        }
        private void OrderPage_Load(object sender, EventArgs e)
        {
            Medicijn_cB.Items.Add("Xanac");
            Medicijn_cB.Items.Add("ibuprofen");
            Medicijn_cB.Items.Add("oxazepam");
            Medicijn_cB.Items.Add("test");
            Medicijn_cB.Items.Add("test2");

        }

        private void Order_btn_MouseEnter_2(object sender, EventArgs e)
        {
            this.Order_btn.Image = Apotheek_application.Properties.Resources.Bestellensmalllight;
        }

        private void Order_btn_MouseLeave_2(object sender, EventArgs e)
        {
            this.Order_btn.Image = Apotheek_application.Properties.Resources.Bestellensmall;
        }

        private void Add_medicijn_btn_MouseEnter(object sender, EventArgs e)
        {
            this.Add_medicijn_btn.Image = Apotheek_application.Properties.Resources.Toevoegensmalllight;
        }

        private void Add_medicijn_btn_MouseLeave(object sender, EventArgs e)
        {
            this.Add_medicijn_btn.Image = Apotheek_application.Properties.Resources.Teovoegensmall;
        }

        private void Order_btn_Click(object sender, EventArgs e)
        {
            const string message = "Weet u zeker dat u dit wil bestellen?";
            const string caption = "Bestelling";
            MessageBoxAdv.MessageBoxStyle = MessageBoxAdv.Style.Metro;
            MessageBoxAdv.MetroColorTable.YesButtonBackColor = Color.FromArgb(255, 255, 255);
            MessageBoxAdv.MetroColorTable.NoButtonBackColor = Color.FromArgb(255, 255, 255);
            MessageBoxAdv.MetroColorTable.YesButtonForeColor = Color.FromArgb(0, 0, 0);
            MessageBoxAdv.MetroColorTable.NoButtonForeColor = Color.FromArgb(0, 0, 0);
            MessageBoxAdv.MetroColorTable.BackColor = Color.FromArgb(88, 196, 160);
            MessageBoxAdv.MetroColorTable.CaptionBarColor = Color.FromArgb(24, 119, 87);
            MessageBoxAdv.MetroColorTable.CaptionForeColor = Color.Black;
            MessageBoxAdv.MetroColorTable.ForeColor = Color.FromArgb(255, 255, 255);
            MessageBoxAdv.MetroColorTable.BorderColor = Color.FromArgb(24, 131, 215);

            var result = MessageBoxAdv.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the Yes button was pressed ...
            if (result == DialogResult.Yes)
            {
                var Medicijn = Medicijn_cB.Text;
                var Nummerof = Aantal_Medicijnen_UpDown.Value;
                var arryWeight = order.GetWeight(Medicijn);
                var Weight = arryWeight.Result[0];
                string CurrentDate = DateTime.Now.ToString("yyyy-MM-dd");
                int ExpiryMonth = Convert.ToInt32(DateTime.Now.ToString("MM")) + 2;
                int ExpiryYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                int Month = Convert.ToInt32(ExpiryMonth);
                if (Month > 12)
                {
                    ExpiryYear = ExpiryYear + 1;
                    Month = Month - 12;
                }
                string ExpiryDate = DateTime.Now.ToString($"{ExpiryYear}-{Month}-dd");
                order.InsertNewOrder(Medicijn, Convert.ToString(Nummerof), Weight, CurrentDate, ExpiryDate);
            }
        }

        private void Add_medicijn_btn_Click_1(object sender, EventArgs e)
        {
            string New_medical = Naam_Medicijn_txt.Text;
            string New_Aantal = Aantal_txt.Text;
            string New_Gewicht = Gewicht_txt.Text;
            string CurrentDate = DateTime.Now.ToString("yyyy-MM-dd");
            int ExpiryMonth = Convert.ToInt32(DateTime.Now.ToString("MM")) + 2;
            int ExpiryYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
            int Month = Convert.ToInt32(ExpiryMonth);
            if (Month > 12)
            {
                ExpiryYear = ExpiryYear + 1;
                Month = Month - 12;
            }
            string ExpiryDate = DateTime.Now.ToString($"{ExpiryYear}-{Month}-dd");
            Console.WriteLine(New_medical);
            Console.WriteLine(New_Aantal);
            Console.WriteLine(New_Gewicht);
            Console.WriteLine(CurrentDate);
            Console.WriteLine(ExpiryDate);
            order.InsertNewProduct(New_medical, New_Aantal, New_Gewicht, CurrentDate, ExpiryDate);
        }
    }
}
