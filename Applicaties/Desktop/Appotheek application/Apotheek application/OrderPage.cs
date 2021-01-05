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
    public partial class OrderPage : Form
    {
        Order order = new Order();

        public bool LoginRequired { get; private set; }

        public OrderPage()
        {
            InitializeComponent();
        }
        private void OrderPage_Load(object sender, EventArgs e)
        {
            foreach (var item in order.GetName().Result)
            {
                Medicijn_cB.Items.Add(item);
            }
            Type_medicijn_cb.Items.Add("Tabletten");
            Type_medicijn_cb.Items.Add("Dragees");
            Type_medicijn_cb.Items.Add("Capsules");
            Type_medicijn_cb.Items.Add("Drankjes");
            Type_medicijn_cb.Items.Add("Poeders");
            Type_medicijn_cb.Items.Add("Spray");
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
            OrderMessageBox CustomMB = new OrderMessageBox();
            CustomMB.StartPosition = FormStartPosition.CenterParent;
            SoundPlayer Popup = new SoundPlayer(Properties.Resources.Popup);
            Popup.Play();
            CustomMB.ShowDialog();
            if (CustomMB.DialogResult == DialogResult.Yes)
            {
                SoundPlayer correct = new SoundPlayer(Properties.Resources.correct);
                correct.Play();
                CustomMB.Dispose();
                var Medicijn = Medicijn_cB.Text;
                var Nummerof = Aantal_Medicijnen_UpDown.Value;
                var arryWeight = order.GetWeight(Medicijn);
                var Weight = arryWeight.Result[0];
                var arryType = order.GetType(Medicijn);
                var Type = arryType.Result[0];
                var arryLeverancier = order.GetLeverancier(Medicijn);
                var Leverancier = arryLeverancier.Result[0];
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
                order.InsertNewOrder(Medicijn, Convert.ToString(Nummerof), Weight, CurrentDate, ExpiryDate, Type, Leverancier);
            }
            if (CustomMB.DialogResult == DialogResult.No)
            {
                SoundPlayer Incorrect = new SoundPlayer(Properties.Resources.Error);
                Incorrect.Play();
                CustomMB.Dispose();
            }
        }

        private void Add_medicijn_btn_Click_1(object sender, EventArgs e)
        {
            SoundPlayer Popup = new SoundPlayer(Properties.Resources.Popup);
            Popup.Play();
            ToevoegenMessageBox CustomMB = new ToevoegenMessageBox();
            CustomMB.StartPosition = FormStartPosition.CenterParent;
            CustomMB.ShowDialog();
            if (CustomMB.DialogResult == DialogResult.Yes)
            {
                CustomMB.Dispose();
                string New_medical = Naam_Medicijn_txt.Text;
                string New_Aantal = Aantal_txt.Text;
                string New_Gewicht = Gewicht_txt.Text;
                string CurrentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string New_Type = Type_medicijn_cb.Text;
                var New_Leverancier = leverancier_txt.Text;
                int ExpiryMonth = Convert.ToInt32(DateTime.Now.ToString("MM")) + 2;
                int ExpiryYear = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                int Month = Convert.ToInt32(ExpiryMonth);
                if (Month > 12)
                {
                    ExpiryYear = ExpiryYear + 1;
                    Month = Month - 12;
                }
                string ExpiryDate = DateTime.Now.ToString($"{ExpiryYear}-{Month}-dd");

                order.InsertNewProduct(New_medical, New_Aantal, New_Gewicht, CurrentDate, ExpiryDate, New_Type, New_Leverancier);
                Medicijn_cB.Items.Clear();
                foreach (var item in order.GetName().Result)
                {
                    Medicijn_cB.Items.Add(item);
                }
            }
        }

        private void Type_medicijn_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
