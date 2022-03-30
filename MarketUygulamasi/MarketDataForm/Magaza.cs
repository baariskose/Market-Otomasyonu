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
    public partial class Magaza : Form
    {
        public Magaza()
        {
            InitializeComponent();
        }
        string imageLocation = "";
        string imageDestination = "";
        public List<Product> productsD;
        string path = @"C:\Users\Baris\source\repos\MarketUygulamasi\MarketDataForm\Properties\images\";
        private void label1_Click(object sender, EventArgs e)
        {

        }
        ProductDal productdal = new ProductDal();
        CategoryDal categoryDal = new CategoryDal();
        private void Magaza_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();


        }
        int barkodNo;
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxName.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
            tbxPrice.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            pbProduct.ImageLocation = path + dgwProducts.CurrentRow.Cells[2].Value.ToString() + ".jpg";

            barkodNo = Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value);
            tbxCount.Text = "0";
            count = 0;

        }


        private void cbxKategoriSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cbxKategoriSearch.SelectedValue) == 1)
                {
                    dgwProducts.DataSource = productdal.GetAll();
                }
                else
                {
                    dgwProducts.DataSource = productdal.GetAllById(Convert.ToInt32(cbxKategoriSearch.SelectedValue));
                }
            }
            catch (Exception)
            {
            }
        }

        public void LoadCategories()
        {
            cbxKategoriSearch.DataSource = categoryDal.GetAll();
            cbxKategoriSearch.DisplayMember = "CategoryName";
            cbxKategoriSearch.ValueMember = "CategoryId";
        }
        public void LoadProducts()
        {
            dgwProducts.AutoGenerateColumns = false;
            dgwProducts.ForeColor = Color.Black;
            dgwProducts.ColumnCount = 3;
            dgwProducts.Columns[0].HeaderText = "İsim";
            dgwProducts.Columns[0].DataPropertyName = "ProductName";
            dgwProducts.Columns[1].HeaderText = "Fiyat";
            dgwProducts.Columns[1].DataPropertyName = "UnitPrice";
            dgwProducts.Columns[2].HeaderText = "Barkod No";
            dgwProducts.Columns[2].DataPropertyName = "BarkodNo";
            dgwProducts.DataSource = productdal.GetAll();
        }

        private void tbxSearchName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbxSearchName.Text == "")
                {
                    dgwProducts.DataSource = productdal.GetAll();
                }
                else
                {
                    dgwProducts.DataSource = productdal.GetAllByName(tbxSearchName.Text);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ProductBasket> products = new List<ProductBasket>();
        float totalPrice;
        private void btnAddBasket_Click(object sender, EventArgs e)
        {
            if(tbxCount.Text != "0" && Convert.ToInt32(tbxCount.Text) >0 )
            {
                totalPrice = 0;
                ProductBasket productBasket = new ProductBasket
                {
                    BarkodNo = Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value), 
                    ProductName = tbxName.Text,
                    UnitPrice = Convert.ToDecimal(tbxPrice.Text),
                    Piece = Convert.ToInt32(tbxCount.Text),
                };
                products.Add(productBasket);
                foreach (var product in products)
                {
                    totalPrice += (float)product.UnitPrice*product.Piece;
                }
                tbxShowPrice.Text = totalPrice.ToString();
            }
            else
            {
                MessageBox.Show("Ürün adedi seçiniz");
            }
          
        }
        int count = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            productsD = productdal.GetAll();

            foreach (var item in productsD)
            {
                if (barkodNo == item.BarkodNo)
                {
                    if (item.StockAmount == 0)
                    {
                        MessageBox.Show("Ürün Tükendi");
                    }
                    else if (item.StockAmount == Convert.ToInt32(tbxCount.Text))
                    {
                        MessageBox.Show("Maksimum Stok Adedine Ulaştı");
                    }
                    else
                    {
                        count++;
                        tbxCount.Text = count.ToString();
                    }

                }
            }
        }

        private void btnGoBasket_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            basket.productBaskets = products;
            basket.Show();
        
        }

        private void btnAddBasket_MouseHover(object sender, EventArgs e)
        {
        }

        private void btnAddBasket_MouseLeave(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(count == 0)
            {
                MessageBox.Show("Eksi Sayıda Ürün Giremezsin");
            }
            else
            {
                count--;
                tbxCount.Text = count.ToString();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusteriGiris musteriGiris = new MusteriGiris();
            this.Hide();
            musteriGiris.Show();
        }
    }
}
