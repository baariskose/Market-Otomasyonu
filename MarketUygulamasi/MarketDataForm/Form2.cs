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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        PersonelDal personelDal = new PersonelDal();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        bool isCorrect;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            List<Personel> personels = personelDal.GetAllPersonel();
            string username = tbxUsername.Text;
            string password = tbxPassword.Text;

            foreach (var person in personels)
            {
                if (String.Equals(person.PersonelUserName.Trim(), username.Trim()) && String.Equals(person.PersonelPassword.Trim(), password.Trim()))
                {
                    MessageBox.Show("Yönetim Paneline Yönlendiriliyorsunuz");
                    form1 form1 = new form1();
                    this.Hide();
                    form1.Show();
                    isCorrect = true;
                    break;
                }
               
            }
            if(!isCorrect)
            {
                MessageBox.Show("Şifrre Yanlış");
            }
            isCorrect = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
