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
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }
        bool isCorrect;
        private CustomerDal customerDal = new CustomerDal();
        private void MusteriGiris_Load(object sender, EventArgs e)
        {

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            List<Customer> customers = customerDal.GetCustomers();
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            foreach (var customer in customers)
            {
                if (String.Equals(customer.CustomerUserName.Trim(), username.Trim()) && String.Equals(customer.CustomerPassword.Trim(), password.Trim()))
                {
                    MessageBox.Show("Mağazaya Yönlendiriliyorsunuz.");
                    isCorrect = true;
                    this.Hide();
                    Magaza magaza = new Magaza();
                    magaza.Show();

                    break;
                }
            }
            if(!isCorrect)
            {
                MessageBox.Show("Şifre Yanlış");
            }
            isCorrect = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            if(tbxUsername.Text == "Kullanıcı Adı")
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

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
            {
                tbxPassword.Text = "********";
                tbxPassword.ForeColor = Color.Silver;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            this.Hide();
            forgetPassword.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
