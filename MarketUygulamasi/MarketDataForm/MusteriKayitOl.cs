using MarketData;
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
    public partial class MusteriKayitOl : Form
    {
        public MusteriKayitOl()
        {
            InitializeComponent();
        }
        private CustomerDal customerDal = new CustomerDal();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            customerDal.Add(new Customer
            {

                CustomerUserName = tbxUsername.Text,
                CustomerPassword = tbxPassword.Text,
                GuvenlikSorusu = tbxAnswer.Text,
            });
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Kaydınız Başarıyla Gerçekleştirildi. Mağazaya Yönlendiriliyorsunuz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK);

            if (dialog  == DialogResult.OK)
            {
                Magaza magaza = new Magaza();
                this.Hide();
                magaza.Show();

            }
            
            
        }

        private void MusteriKayitOl_Load(object sender, EventArgs e)
        {

        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "Kullanıcı Adı")
            {
                tbxUsername.Text = "";
                tbxUsername.ForeColor = Color.Black;
            }
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "")
            {
                tbxUsername.Text = "Kullanıcı Adı";
                tbxUsername.ForeColor = Color.Silver;
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "********")
            {
                tbxPassword.Text = "";
                tbxPassword.ForeColor = Color.Black;
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
            {
                tbxPassword.Text = "********";
                tbxPassword.ForeColor = Color.Silver;
            }
        }

        private void tbxAnswer_Enter(object sender, EventArgs e)
        {
            if (tbxAnswer.Text == "Sevdiğiniz Hayvan")
            {
                tbxAnswer.Text = "";
                tbxAnswer.ForeColor = Color.Black;
            }
        }

        private void tbxAnswer_Leave(object sender, EventArgs e)
        {
            if (tbxAnswer.Text == "")
            {
                tbxAnswer.Text = "Sevdiğiniz Hayvan";
                tbxAnswer.ForeColor = Color.Silver;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
