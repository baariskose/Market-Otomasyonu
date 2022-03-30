using MarketData;
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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        int sayi;
        int barkodNo;

        string imageLocation = "";
        string imageDestination = "";
        string path = @"C:\Users\Baris\source\repos\MarketUygulamasi\MarketDataForm\Properties\images\";


        private ProductDal productDal = new ProductDal();
        private CategoryDal categoryDal = new CategoryDal();
        public List<Product> products;
        private void Form1_Load(object sender, EventArgs e)
        {

            products = productDal.GetAll();
            LoadProducts();
            LoadCategories();
        }

        public void LoadProducts()
        {
            dgwProducts.DataSource = productDal.GetAll();

        }

        public void LoadCategories()
        {
            cbxCategory.DataSource = categoryDal.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";


            cbxCategoryAdd.DataSource = categoryDal.GetAll();
            cbxCategoryAdd.DisplayMember = "CategoryName";
            cbxCategoryAdd.ValueMember = "CategoryId";

            cbxCategoryUpdate.DataSource = categoryDal.GetAll();
            cbxCategoryUpdate.DisplayMember = "CategoryName";
            cbxCategoryUpdate.ValueMember = "CategoryId";



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RandomBarkod();
            productDal.Add(new Product
            {

                ProductName = tbxProductName.Text,
                CategoryId = Convert.ToInt32(cbxCategoryAdd.SelectedValue),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                UnitCost = Convert.ToDecimal(tbxUnitCostAdd.Text),
                BarkodNo = barkodNo,
            });

            ChooseImage();
            LoadProducts();
        }

        public void RandomBarkod()
        {
            Random randomBarkod = new Random();

            sayi = randomBarkod.Next(products.Count, products.Count + 10000);
            foreach (var item in products)
            {
                if (item.BarkodNo == sayi)
                {
                    RandomBarkod();
                }
                else
                {
                    barkodNo = sayi;
                }
            }
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductNameUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            cbxCategoryUpdate.SelectedValue = dgwProducts.CurrentRow.Cells[1].Value;
            tbxStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[4].Value.ToString();
            tbxUnitCostUpdate.Text = dgwProducts.CurrentRow.Cells[5].Value.ToString();
            pictureBox2.ImageLocation = path + dgwProducts.CurrentRow.Cells[6].Value.ToString() + ".jpg";


        }

        private void btdUpdate_Click(object sender, EventArgs e)
        {

            productDal.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                ProductName = tbxProductNameUpdate.Text,
                CategoryId = Convert.ToInt32(cbxCategoryUpdate.SelectedValue),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text),
                UnitCost = Convert.ToDecimal(tbxUnitCostUpdate.Text),
                BarkodNo = Convert.ToInt32(dgwProducts.CurrentRow.Cells[6].Value),
            });
            if(isClicked)
            {
                File.Delete(path + dgwProducts.CurrentRow.Cells[6].Value.ToString() + ".jpg");
                ChooseImage(dgwProducts.CurrentRow.Cells[6].Value.ToString());
            }
          
            LoadProducts();
        }
        public void ChooseImage(string imageName)
        {
            string name = imageName;
            imageDestination = path +
                               name + ".jpg";

            File.Copy(imageLocation, imageDestination);

        }
        public void ChooseImage()
        {
            string name = barkodNo.ToString();
            imageDestination = path +
                               name + ".jpg";

            File.Copy(imageLocation, imageDestination);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            productDal.Delete(new Product
            {
                ProductId = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
            });
            LoadProducts();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    picturbox1.ImageLocation = imageLocation;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool isClicked;
        private void btnUploadImageUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.JPG;)|*.JPG;";


                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox2.ImageLocation = imageLocation;
                    isClicked = true;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = productDal.GetAllById(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {

            }

        }

        private void tbxSearchName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProducts.DataSource = productDal.GetAllByName(tbxSearchName.Text);
            }
            catch (Exception)
            {

            }
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
