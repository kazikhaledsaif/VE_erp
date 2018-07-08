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
using Manager;
using Model;

namespace Ekhteear.UI
{
    public partial class ProductsAddForm : Form
    {
        ProductManager newProductManager = new ProductManager();
        private decimal minQuantity;
        private string barcode;
        String imageLoc;
        double num;
        decimal newCost;
        private byte[] image = null;
        public ProductsAddForm()
        {
            InitializeComponent();
        }
        // minimzebutton
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //cross button
        private void crossButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       //maximize button 
        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
         
        }
        //  save button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (productId.Text != "" && productName.Text != "" && buyingRate.Text != "" && saleRate.Text != "")
            {
                if (String.IsNullOrEmpty(MinimumQuantity.Text))
                {
                    minQuantity = 0.0m;
                }
                else
                {
                    if (Double.TryParse(MinimumQuantity.Text.Trim(), out num))
                    {
                        minQuantity = Convert.ToDecimal(this.MinimumQuantity.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Enter Number Only");
                        MinimumQuantity.Clear();
                    }
                }
                if (String.IsNullOrEmpty(SKUTextbox.Text))
                {
                    barcode = null;
                }
                else
                {
                    barcode = SKUTextbox.Text;
                }

                if (Double.TryParse(buyingRate.Text.Trim(), out num) && Double.TryParse(saleRate.Text.Trim(), out num) && UnitCombox.Text != "" && Double.TryParse(vat.Text.Trim(), out num))
                {
                    try
                    {
                        //creating  ProductModel class and Save All data to object
                        ProductModel aProductModel = new ProductModel();
                        aProductModel.ProductName = productName.Text;
                        aProductModel.ProductType = productType.Text;
                        aProductModel.ProductBuyingRate = Convert.ToDecimal(buyingRate.Text);
                        aProductModel.ProductSellingRate = Convert.ToDecimal(saleRate.Text);
                        aProductModel.Vat = Convert.ToDecimal(vat.Text);
                        aProductModel.ProductSaleRateWithVat = Convert.ToDecimal(vatsale.Text);
                        aProductModel.Barcode = barcode;
                        aProductModel.ProductUnit = UnitCombox.Text;
                        aProductModel.ProductMinimumQuantity = minQuantity;
                        aProductModel.ProductImage = image;
                        // calling manager to insert data

                        int isDone = newProductManager.ProductInsert(aProductModel);
                        if (isDone > 0)
                        {
                            MessageBox.Show("Inserted Sucessfully");
                            Reset();
                           
                        }
                        else
                        {
                            MessageBox.Show("Insert Unsucessful");
                            Reset();
                        }
                     

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Try Again");
                        Reset();
                    }



                }
                else
                {
                    MessageBox.Show("Please Enter Number Only");
                    buyingRate.Clear();
                    saleRate.Clear();
                    MinimumQuantity.Clear();
                }
            }


            else
            {
                MessageBox.Show("Please Fill The Data");
            }

        }
        // reset all the fields
        public void Reset()
        {

       
            GetProductId();
            productName.Clear();
            productType.Clear();
            buyingRate.Clear();
            saleRate.Clear();
            SKUTextbox.Clear();
            UnitCombox.SelectedIndex = -1;
            MinimumQuantity.Clear();
            vat.Clear();
            vatsale.Clear();
            logo.Image = null;
        }

        private void GetProductId()
        {
            //display product id
              
                string productID = newProductManager.GetProductId();
                productId.Text = productID;
        }

        private void ProductsAddForm_Load(object sender, EventArgs e)
        {
            GetProductId();
        }

        private void BarcodeGenerator_Click(object sender, EventArgs e)
        {
            // barcode generate
              int  generate = Convert.ToInt32(productId.Text.ToString()) + 1000000;

            SKUTextbox.Text = generate.ToString();
        }

        private void findLogo_Click(object sender, EventArgs e)
        {
            //picture save
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLoc = dialog.FileName.ToString();
                logo.ImageLocation = imageLoc;
                FileStream stream = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
                BinaryReader binary = new BinaryReader(stream);
                image = binary.ReadBytes((int)stream.Length);
            }
        }

        private void vat_TextChanged(object sender, EventArgs e)
        {
            //vat calculation
            try
            {
                if (vat.Text != "")
                {
                    decimal a = Convert.ToDecimal(saleRate.Text.ToString());
                    decimal b = Convert.ToDecimal(saleRate.Text.ToString());
                    decimal c = Convert.ToDecimal(vat.Text.ToString());
                    newCost =a + ((b * c) / 100);
                    vatsale.Text = newCost.ToString();
                }
                else
                {
                    vatsale.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Only Numbers");
             
                vat.Clear();

            }
        }

      
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // form close
            this.Close();
        }
    }
}
