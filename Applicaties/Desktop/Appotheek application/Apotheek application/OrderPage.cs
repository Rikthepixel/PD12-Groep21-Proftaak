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
        MasterPage masterPage;
        public bool LoginRequired { get; private set; }

        public OrderPage(MasterPage mp)
        {
            masterPage = mp;
            InitializeComponent();
        }
        private void OrderPage_Load(object sender, EventArgs e)
        {
            order.TablesRecieved += Order_TablesRecieved;
            order.GetTablesAsync(masterPage.CurrentUser);

            Type_medicijn_cb.Items.Add("Tabletten");
            Type_medicijn_cb.Items.Add("Dragees");
            Type_medicijn_cb.Items.Add("Capsules");
            Type_medicijn_cb.Items.Add("Drankjes");
            Type_medicijn_cb.Items.Add("Poeders");
            Type_medicijn_cb.Items.Add("Spray");
        }

        private void Order_TablesRecieved(object source, TablesRecievedEventArgs args)
        {
            foreach (var item in args.Tables)
            {
                Medicijn_cB.Items.Add(item.TABLE_NAME);
            }
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
            CustomMB.ShowDialog();
            if (CustomMB.DialogResult == DialogResult.Yes)
            {
                CustomMB.Dispose();
                var Medicijn = Medicijn_cB.Text;
                var Nummerof = Aantal_Medicijnen_UpDown.Value;

                var ProductInfo = order.GetProductByIDAsync(Medicijn, 1, masterPage.CurrentUser);
                var product = ProductInfo.Result.Item1;
                var extraInfo = ProductInfo.Result.Item2;

                #region TimeCalculations
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
                #endregion

                var NewProduct = new Product(Medicijn, Convert.ToInt32(Math.Ceiling(Nummerof)), product.Gewicht, CurrentDate, ExpiryDate);
                _ = order.InsertNewOrderAsync(NewProduct, extraInfo, masterPage.CurrentUser);
            }
            if (CustomMB.DialogResult == DialogResult.No)
            {
                CustomMB.Dispose();
            }
        }

        private void Add_medicijn_btn_Click_1(object sender, EventArgs e)
        {
            string New_medical = Naam_Medicijn_txt.Text;
            int New_Aantal = Convert.ToInt32(Aantal_txt.Text);
            double New_Gewicht = Convert.ToDouble(Gewicht_txt.Text);
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

            var NewProduct = new Product(New_medical, New_Aantal, New_Gewicht, CurrentDate, ExpiryDate);
            var NewExtraInfo = new ExtraInfo(New_Type, New_Leverancier);

            _ = order.InsertNewProductAsync(NewProduct, NewExtraInfo, masterPage.CurrentUser);
        }

        private void Type_medicijn_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
