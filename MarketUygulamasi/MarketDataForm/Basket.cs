using MarketData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketDataForm
{
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
        }
        float totalPrice;
        float totalCostPrice;
        float cargoPrice = 10;
        bool isEmpty = true;

        string coupon1 = "5NBK10";
        string coupon2 = "5NBK20";
        public List<ProductBasket> productBaskets = new List<ProductBasket>();
        public List<Product> allProducts = new List<Product>();
        public List<TextBox> textBoxes = new List<TextBox>();
        private void Basket_Load(object sender, EventArgs e)
        {
            textBoxes.Add(tbxName);
            textBoxes.Add(tbxSurname);
            textBoxes.Add(tbxCity);
            textBoxes.Add(tbxUnderCity);
            textBoxes.Add(tbxHood);
            textBoxes.Add(tbxStreet);
            textBoxes.Add(tbxUnderStreet);
            textBoxes.Add(tbxCardName);

            dgwProducts.DataSource = productBaskets;
            CalculatePrice();
            allProducts = productDal.GetAll();
            CargoCheck();
            //tbxCargo.Text = cargoPrice.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void CalculatePrice()
        {
            totalPrice = 0;
            foreach (var product in productBaskets)
            {
                totalPrice += (float)product.UnitPrice * (float)product.Piece;
            }
            tbxPrice.Text = totalPrice.ToString();
        }
        ProductSellDal productSellDal = new ProductSellDal();
        ProductDal productDal = new ProductDal();
        string productsString = "";
        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            textBoxIsNull();
            if (isValid_CardNumber(tbxCardNo.Text) && isValid_Security(tbxSecurityCode.Text) && isValid_Date() && isChecked_CheckBox() && aptNo_isDigit() && daireNo_isDigit() && postCode_isDigit() && isEmpty)
            {
                foreach (var product in productBaskets)
                {
                    foreach (var dbProduct in allProducts)
                    {
                        if (dbProduct.BarkodNo == product.BarkodNo)
                        {
                            productDal.Update(new Product
                            {
                                ProductId = dbProduct.ProductId,
                                BarkodNo = dbProduct.BarkodNo,
                                CategoryId = dbProduct.CategoryId,
                                StockAmount = dbProduct.StockAmount - product.Piece,
                                ProductName = dbProduct.ProductName,
                                UnitCost = dbProduct.UnitCost,
                                UnitPrice = dbProduct.UnitPrice

                            });
                                totalCostPrice += (float)dbProduct.UnitCost * (float)product.Piece;
                        }
                    }
                    productsString += product.ProductName.Trim() + "*" + product.Piece + ", ";
                }
                if (totalPrice >= 75)
                {
                    totalCostPrice += 10;

                }

                productSellDal.Add(new ProductSell
                {
                    Products = productsString,
                    Name = tbxName.Text,
                    Surname = tbxSurname.Text,
                    City = tbxCity.Text,
                    UnderCity = tbxUnderCity.Text,
                    Hood = tbxHood.Text,
                    Street = tbxStreet.Text,
                    UnderStreet = tbxUnderStreet.Text,
                    House = tbxHouse.Text,
                    HouseNo = tbxHouseNo.Text,
                    PostCode = tbxPostCode.Text,
                    CardName = tbxCardName.Text,
                    CardNo = tbxCardNo.Text,
                    Date = tbxDate.Text,
                    SecurityCode = tbxSecurityCode.Text,
                    TotalPrice = Convert.ToDecimal(tbxPrice.Text),
                    TotalCostPrice = Convert.ToDecimal(totalCostPrice),
                });
                totalCostPrice = 0;
                MessageBox.Show("Siparişiniz Alındı!");
            }
            else if(isEmpty == false)
            {
                MessageBox.Show("Tüm alanları doğru bir şekilde doldurduğunuzdan emin olunuz.");
            }
            else if (!isValid_Date())
            {
                MessageBox.Show("Kart Son Kullanma Tarihi Uygun Formatta Girilmedi.");
            }
            else if (!isChecked_CheckBox())
            {
                MessageBox.Show("Sözleşmeyi Kabul Ediniz");
            }
            else
            {
                MessageBox.Show("Sipariş Tamamlanamadı Lütfen Bilgileri Kontrol Ediniz.");
            }

        }
        int barkodNo;
        int count;
        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductName.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
            barkodNo = Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value);
            tbxCount.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            count = Convert.ToInt32(dgwProducts.CurrentRow.Cells[3].Value);
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            List<Product> productsD = productDal.GetAll();
            foreach (var item in productsD)
            {
                if (barkodNo == item.BarkodNo)
                {

                    if (item.StockAmount == Convert.ToInt32(tbxCount.Text))
                    {
                        MessageBox.Show("Maksimum Stok Adedine Ulaştı.");
                    }
                    else if (String.Equals(tbxCoupon.Text, coupon1))
                    {
                        count++;
                        dgwProducts.CurrentRow.Cells[3].Value = count;
                        tbxCount.Text = count.ToString();
                        CalculatePrice();
                        totalPrice = totalPrice * 0.9f;
                        tbxPrice.Text = totalPrice.ToString();

                    }
                    else if (String.Equals(tbxCoupon.Text, coupon2))
                    {
                        count++;
                        dgwProducts.CurrentRow.Cells[3].Value = count;
                        tbxCount.Text = count.ToString();
                        CalculatePrice();
                        totalPrice = totalPrice * 0.8f;
                        tbxPrice.Text = totalPrice.ToString();

                    }
                    else
                    {
                        count++;
                        dgwProducts.CurrentRow.Cells[3].Value = count;
                        tbxCount.Text = count.ToString();
                        CalculatePrice();
                    }

                }
            }
            CargoCheck();

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                MessageBox.Show("En az 1 Ürün Sepette Olmalı.");
            }
            else if (String.Equals(tbxCoupon.Text, coupon1))
            {
                count--;
                dgwProducts.CurrentRow.Cells[3].Value = count;
                tbxCount.Text = count.ToString();
                CalculatePrice();
                totalPrice = totalPrice * 0.9f;
                tbxPrice.Text = totalPrice.ToString();

            }
            else if (String.Equals(tbxCoupon.Text, coupon2))
            {
                count--;
                dgwProducts.CurrentRow.Cells[3].Value = count;
                tbxCount.Text = count.ToString();
                CalculatePrice();
                totalPrice = totalPrice * 0.8f;
                tbxPrice.Text = totalPrice.ToString();

            }
            else
            {
                count--;
                dgwProducts.CurrentRow.Cells[3].Value = count;
                tbxCount.Text = count.ToString();
                CalculatePrice();

            }
            CargoCheck();

        }
        public void textBoxIsNull()
        {
            foreach (var textBox in textBoxes)
            {
                if (Regex.Match(textBox.Text, @"\w+").Success)
                {
                }
                else
                {
                    isEmpty = false;
                }

            }
           
           
        }
        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int barkod = Convert.ToInt32(dgwProducts.CurrentRow.Cells[2].Value);
                List<ProductBasket> kopya = new List<ProductBasket>();
                foreach (ProductBasket product in productBaskets.ToList())
                {
                    if (barkod == product.BarkodNo)
                    {
                        productBaskets.Remove(product);
                    }
                    else
                    {
                        kopya.Add(product);
                    }
                }
                productBaskets = kopya;
                dgwProducts.DataSource = productBaskets;
                CargoCheck();
            }
            catch (Exception)
            {

                MessageBox.Show("Ürün Seçmediniz.");
            }

        }

        private void btnAddCoupon_Click(object sender, EventArgs e)
        {
            if (String.Equals(tbxCoupon.Text, coupon1))
            {
                totalPrice = totalPrice * 0.90f;
                tbxPrice.Text = totalPrice.ToString();
                btnAddCoupon.Enabled = false;
                tbxCoupon.Enabled = false;

            }
            else if (String.Equals(tbxCoupon.Text, coupon2))
            {
                totalPrice = totalPrice * 0.80f;
                tbxPrice.Text = totalPrice.ToString();
                btnAddCoupon.Enabled = false;
                tbxCoupon.Enabled = false;
            }
            else
            {
                MessageBox.Show("Hatalı İndirim Kodu.");
            }
            CargoCheck();
        }
        public void CargoCheck()
        {
            if (totalPrice >= 75)
            {
                tbxCargo.Text = "Ücretsiz";
            }
            else
            {
                tbxCargo.Text = 10 + "";
            }
        }
        private void tbxDate_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbxCardNo_TextChanged(object sender, EventArgs e)
        {

        }

        public bool isValid_CardNumber(string n)
        {
            Regex check = new Regex(@"^([0-9]{16})$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Kart Numarası Uygun Formatta Değil.");
                tbxCardNo.Text = "";
                return valid;
            }
        }
        public bool isChecked_CheckBox()
        {
            return cbContract.Checked;
        }
        public bool isValid_Security(string n)
        {
            Regex check = new Regex(@"^([0-9]{3})$");
            bool valid = false;
            valid = check.IsMatch(n);
            if (valid)
            {
                return valid;
            }
            else
            {
                MessageBox.Show("Kart Güvenlik Kodu Uygun Formatta Değil.");
                tbxCardNo.Text = "";
                return valid;
            }
        }
        public bool isValid_Date()
        {
            string[] date = Regex.Split(tbxDate.Text, "/");
            DateTime todaysDate = DateTime.Now.Date;
            int year = todaysDate.Year;
            int month = todaysDate.Month;


            if (Regex.Match(tbxDate.Text, @"^\d{2}/\d{4}$").Success)
            {
                if (Regex.Match(date[0], @"^[0][1-9]|[1][0-2]$").Success)
                {
                    if (int.Parse(date[1]) > year || (int.Parse(date[1]) == year && int.Parse(date[0]) >= month))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool aptNo_isDigit()
        {
            if (Regex.Match(tbxHouse.Text, @"\d+").Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Apt No uygun değil.");
                return false;
            }
        }
        public bool daireNo_isDigit()
        {
            if (Regex.Match(tbxHouse.Text, @"\d+").Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Daire No uygun değil.");
                return false;
            }
        }
        public bool postCode_isDigit()
        {
            if (Regex.Match(tbxPostCode.Text, @"(\d{5})").Success)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Posta Kodu uygun değil.");
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid_CardNumber(tbxCardNo.Text) && isValid_Security(tbxSecurityCode.Text) && isValid_Date())
            {
                MessageBox.Show("Uygun");
            }
            else
            {
                MessageBox.Show("Uygun Değil");
            }
        }

        private void tbxDate_Enter(object sender, EventArgs e)
        {
            if (tbxDate.Text == "__/____")
            {
                tbxDate.Text = "";
                tbxDate.ForeColor = Color.Black;
            }
        }

        private void tbxDate_Leave(object sender, EventArgs e)
        {
            if (tbxDate.Text == "")
            {
                tbxDate.Text = "__/____";
                tbxDate.ForeColor = Color.Silver;
            }
        }

        private void tbxCardNo_Enter(object sender, EventArgs e)
        {
            if (tbxCardNo.Text == "____  ____  ____  ____")
            {
                tbxCardNo.Text = "";
                tbxCardNo.ForeColor = Color.Black;
            }

        }

        private void tbxCardNo_Leave(object sender, EventArgs e)
        {
            if (tbxCardNo.Text == "")
            {
                tbxCardNo.Text = "____  ____  ____  ____";
                tbxCardNo.ForeColor = Color.Silver;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            aptNo_isDigit();
            daireNo_isDigit();
            postCode_isDigit();
        }
    }
}
