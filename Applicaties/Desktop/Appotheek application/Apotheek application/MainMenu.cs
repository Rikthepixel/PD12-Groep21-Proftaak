﻿using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new ProductPage();
            m.Show();
            this.Hide();
        }

        private void Help_btn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Uitloggen_btn_Click(object sender, EventArgs e)
        {
            var m = new Login();
            m.Show();
            this.Hide();
        }

        private void Bestellen_btn_Click(object sender, EventArgs e)
        {
            var m = new OrderPage();
            m.Show();
            this.Hide();
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void Bestellen_btn_Click_1(object sender, EventArgs e)
        {
            var m = new OrderPage();
            m.Show();
            this.Hide();
        }

        private void Producten_Overzicht_btn_Click(object sender, EventArgs e)
        {
            var m = new ProductPage();
            m.Show();
            this.Hide();
        }

        private void Uitloggen_btn_Click_1(object sender, EventArgs e)
        {
            var m = new Login();
            m.Show();
            this.Hide();
        }
    }
}
