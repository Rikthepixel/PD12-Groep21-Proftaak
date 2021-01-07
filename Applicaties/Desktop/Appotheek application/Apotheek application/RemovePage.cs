using Appotheekcl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotheek_application
{
    public partial class RemovePage : Form
    {
        Order order = new Order();

        public bool LoginRequired { get; private set; }
        public RemovePage()
        {
            InitializeComponent();
        }
        private void RemovePage_Load(object sender, EventArgs e)
        {
            foreach (var item in order.GetName().Result)
            {
                Name_cb.Items.Add(item);
            }
            Aantal_Medicijnen_Verwijderen.Text = null;
        }

        private void Order_btn_Click(object sender, EventArgs e)
        {
            RemoveMessageBox CustomMB = new RemoveMessageBox();
            CustomMB.StartPosition = FormStartPosition.CenterParent;
            SoundPlayer Popup = new SoundPlayer(Properties.Resources.Popup);
            Popup.Play();
            CustomMB.ShowDialog();
            if (CustomMB.DialogResult == DialogResult.Yes)
            {
                SoundPlayer correct = new SoundPlayer(Properties.Resources.correct);
                correct.Play();
                CustomMB.Dispose();
                string Name_medical = Name_cb.Text;
                string Change_to_id = ID_cb.Text;
                var Remove_amount = Aantal_Medicijnen_Verwijderen.Value;
                var arryAantal = order.GetAantal(Name_medical, Change_to_id);
                var Aantal = arryAantal.Result[0];
                var New_Aantal = Convert.ToInt32(Aantal) - Remove_amount;

                order.UpdateOrder(Name_medical, Convert.ToString(New_Aantal), Change_to_id);
                if (Convert.ToInt32(New_Aantal) < 1)
                {
                    order.DeleteOrder(Name_medical, Change_to_id);
                    int count = ID_cb.Items.Count;
                    if (count == 0)
                    {
                        order.Drop_tabel_Order(Name_medical);
                    }
                }
                Name_cb.SelectedIndex = -1;
                ID_cb.SelectedIndex = -1;
                Aantal_Medicijnen_Verwijderen.Value = 1;
                Aantal_Medicijnen_Verwijderen.Text = null;
            }
            if (CustomMB.DialogResult == DialogResult.No)
            {
                SoundPlayer Incorrect = new SoundPlayer(Properties.Resources.Error);
                Incorrect.Play();
                CustomMB.Dispose();
            }
        }

        private void ID_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ID_cb.Items.Clear();
            if (String.IsNullOrEmpty(Name_cb.Text))
            {

            }
            else
            {
                string Change_medical = Name_cb.Text;
                foreach (var item in order.GetID(Change_medical).Result)
                {
                    ID_cb.Items.Add(item);
                }
            }
        }
    }
}
