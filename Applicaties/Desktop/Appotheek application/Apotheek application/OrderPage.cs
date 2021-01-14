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
            _ = order.GetTablesAsync(masterPage.CurrentUser);

            Type_medicijn_cb.Items.Add("Tabletten");
            Type_medicijn_cb.Items.Add("Dragees");
            Type_medicijn_cb.Items.Add("Capsules");
            Type_medicijn_cb.Items.Add("Drankjes");
            Type_medicijn_cb.Items.Add("Poeders");
            Type_medicijn_cb.Items.Add("Spray");
            Aantal_Medicijnen_UpDown.Text = null;
        }

        private void Order_TablesRecieved(object source, TablesRecievedEventArgs args)
        {
            Medicijn_cB.Items.Clear();
            foreach (var item in args.Tables)
            {
                Medicijn_cB.Items.Add(item.TABLE_NAME);
            }
        }

        private async void Order_btn_Click(object sender, EventArgs e)
        {
            OrderMessageBox CustomMB = new OrderMessageBox();
            if (!masterPage.IsLightmode)
            {
                CustomMB.ForeColor = Color.White;
                CustomMB.BackColor = Color.FromArgb(75, 79, 78);
                CustomMB.SetButtonColors(Color.White, Color.FromArgb(75, 79, 78), Color.FromArgb(55, 58, 64));
                CustomMB.SetWarningLabel(Properties.Resources.AlertDark3);
            }
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

                var ProductInfo = await order.GetProductByIDAsync(Medicijn, 1, masterPage.CurrentUser);
                var product = ProductInfo.Item1;
                var extraInfo = ProductInfo.Item2;

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
                Medicijn_cB.SelectedIndex = -1;
                Aantal_Medicijnen_UpDown.Value = 0;
                Aantal_Medicijnen_UpDown.Text = null;
            }
            if (CustomMB.DialogResult == DialogResult.No)
            {
                SoundPlayer Incorrect = new SoundPlayer(Properties.Resources.Error);
                Incorrect.Play();
                CustomMB.Dispose();
            }
        }

        private async void Add_medicijn_btn_Click_1(object sender, EventArgs e)
        {
            SoundPlayer Popup = new SoundPlayer(Properties.Resources.Popup);
            Popup.Play();
            ToevoegenMessageBox CustomMB = new ToevoegenMessageBox();
            if (!masterPage.IsLightmode)
            {
                CustomMB.ForeColor = Color.White;
                CustomMB.BackColor = Color.FromArgb(75, 79, 78);
                CustomMB.SetButtonColors(Color.White, Color.FromArgb(75, 79, 78), Color.FromArgb(55, 58, 64));
                CustomMB.SetWarningLabel(Properties.Resources.AlertDark3);
            }
            CustomMB.StartPosition = FormStartPosition.CenterParent;
            CustomMB.ShowDialog();
            if (CustomMB.DialogResult == DialogResult.Yes)
            {
                CustomMB.Dispose();

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
                Naam_Medicijn_txt.Text = " ";
                Aantal_txt.Text = " ";
                Gewicht_txt.Text = " ";
                Type_medicijn_cb.SelectedIndex = -1;
                leverancier_txt.Text = " ";

                await Task.WhenAll(order.InsertNewProductAsync(NewProduct, NewExtraInfo, masterPage.CurrentUser));
                _ = order.GetTablesAsync(masterPage.CurrentUser);
            }
            
            if (CustomMB.DialogResult == DialogResult.No)
            {
                SoundPlayer Incorrect = new SoundPlayer(Properties.Resources.Error);
                Incorrect.Play();
                CustomMB.Dispose();
            }
        }

        private void Type_medicijn_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Gewicht_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Aantal_Medicijnen_UpDown_ValueChanged(object sender, EventArgs e)
        {
            int No_zero = Convert.ToInt32(Aantal_Medicijnen_UpDown.Value);
            if (No_zero == 0)
            {
                Aantal_Medicijnen_UpDown.Value = 1;
            }
        }
    }
}
