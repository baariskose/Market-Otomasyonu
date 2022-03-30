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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        ProductSellDal productSellDal = new ProductSellDal();
        List<ProductSell> products = new List<ProductSell>();
        decimal allTotalCost=0;
        decimal allTotalPrice = 0;
        decimal allProfit = 0;
        private void Balance_Load(object sender, EventArgs e)
        {
           
            products = productSellDal.GetAll();
            LoadProducts();
            
            tbxAllPrice.Text = CalculateAllTotalPrice().ToString();
            tbxAllCost.Text = CalculateAllTotalCost().ToString();
            allProfit = CalculateAllTotalPrice() - CalculateAllTotalCost();
            tbxAllProfit.Text = allProfit.ToString();
            
        }
        public void LoadProducts()
        {
            dgwProducts.AutoGenerateColumns = false;
            dgwProducts.ForeColor = Color.Black;
            dgwProducts.ColumnCount = 3;
            dgwProducts.Columns[0].HeaderText = "Sipariş No";
            dgwProducts.Columns[0].DataPropertyName = "OrderId";
            dgwProducts.Columns[1].HeaderText = "Toplam Kazanç";
            dgwProducts.Columns[1].DataPropertyName = "TotalPrice";
            dgwProducts.Columns[2].HeaderText = "Toplam Maliyet";
            dgwProducts.Columns[2].DataPropertyName = "TotalCostPrice";
            dgwProducts.DataSource = productSellDal.GetAll();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgwRow = dgwProducts.CurrentRow;
            tbxOrderId.Text = dgwRow.Cells[0].Value.ToString();
            tbxTotalPrice.Text = dgwRow.Cells[1].Value.ToString();
            tbxTotalCostPrice.Text = dgwRow.Cells[2].Value.ToString();
            tbxProfit.Text = (Convert.ToDecimal(dgwRow.Cells[1].Value) - Convert.ToDecimal(dgwRow.Cells[2].Value)).ToString();
        }
        public decimal CalculateProfit(decimal totalPrice , decimal totalCost)
        {
            return totalPrice - totalCost;
        }
        public decimal CalculateAllTotalCost()
        {
            allTotalCost = 0;
            foreach (var product in products)
            {
                allTotalCost += product.TotalCostPrice;
            }
            return allTotalCost;
        }
        public decimal CalculateAllTotalPrice()
        {
            allTotalPrice = 0;
            foreach (var product in products)
            {
                allTotalPrice += product.TotalPrice;
            }
            return allTotalPrice;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbxProfit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbxTotalCostPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxOrderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            form1 form1 = new form1();
            this.Hide();
            form1.Show();
        }
    }
}
