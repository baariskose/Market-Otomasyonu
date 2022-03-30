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
    public partial class ForgetPassword : Form
    {
        CustomerDal customerDal = new CustomerDal();
        public ForgetPassword()
        {
            InitializeComponent();
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

        private void tbxSecurity_Enter(object sender, EventArgs e)
        {
            if (tbxSecurity.Text == "En Sevdiğin Hayvan")
            {
                tbxSecurity.Text = "";
                tbxSecurity.ForeColor = Color.Black;
            }
        }

        private void tbxSecurity_Leave(object sender, EventArgs e)
        {
            if (tbxSecurity.Text == "")
            {
                tbxSecurity.Text = "En Sevdiğin Hayvan";
                tbxSecurity.ForeColor = Color.Silver;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerDal.GetCustomers(); ;
          
            bool isFound = false;
            foreach (var customer in customers)
            {
                if(String.Equals(customer.GuvenlikSorusu.Trim(),tbxSecurity.Text.Trim()) && String.Equals(customer.CustomerUserName.Trim(), tbxUsername.Text.Trim()))
                {
                    customerDal.Update(new Customer
                    {
                        CustomerId = customer.CustomerId,
                        CustomerUserName = customer.CustomerUserName,
                        CustomerPassword = tbxPassword.Text,
                        GuvenlikSorusu = customer.GuvenlikSorusu,
                    });
                    isFound = true;
                    DialogResult dialog = new DialogResult();
                    dialog = MessageBox.Show("Şifreniz Başarıyla Değiştirildi.Giriş Sayfasına Yönlendiriliyorsunuz.", "Bilgilendirme Penceresi", MessageBoxButtons.OK);

                    if (dialog == DialogResult.OK)
                    {
                        MusteriGiris musteriGiris = new MusteriGiris();
                        this.Hide();
                        musteriGiris.Show();

                    }
                    break;
                }
            }
            if(!isFound)
            {
                MessageBox.Show("Kullanıcı Adı ya da Güvenlik Sorusu Yanlış.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriGiris musteriGiris = new MusteriGiris();
            this.Hide();
            musteriGiris.Show();
        }

        private void ForgetPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
