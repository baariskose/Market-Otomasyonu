using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketDataForm
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriGiris musteriGiris = new MusteriGiris();
            this.Hide();
            musteriGiris.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriKayitOl musteriKayitOl = new MusteriKayitOl();
            this.Hide();
            musteriKayitOl.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tekrar Görüşmek Üzere.");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            this.Hide();
            aboutUs.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Communication communication = new Communication();
            this.Hide();
            communication.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Career career = new Career();
            this.Hide();
            career.Show();
        }
    }
}
