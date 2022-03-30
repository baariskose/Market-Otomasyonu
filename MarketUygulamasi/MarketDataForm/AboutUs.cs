using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketDataForm
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            if(rtbxAboutUs.Enabled == false)
            {
                rtbxAboutUs.ForeColor = Color.Black;
                rtbxAboutUs.BackColor = Color.White;
            }

            string path = @"C:\Users\Baris\source\repos\MarketUygulamasi\MarketDataForm\Properties\texts\AboutUs.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (true)
                {
                    string row = reader.ReadLine();
                    rtbxAboutUs.Text += row + "\n"; // satır  ve yeni satır(\n)
                    if (row == null) break;
                }
                reader.Close();
            }
            fileStream.Close();
        }

        private void rtbxAboutUs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
