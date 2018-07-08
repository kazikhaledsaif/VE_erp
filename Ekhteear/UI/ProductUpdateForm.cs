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
    public partial class ProductUpdateForm : Form
    {
        private ProductModel aUpdateProductModel;
        private decimal minQuantity;
        private string barcode;
        String imageLoc;
        double num;
        decimal newCost;
        private byte[] image = null;
        public ProductUpdateForm(ProductModel aProductModel)
        {
            InitializeComponent();
          //  int a =  aProductModel.ProductId;
            aUpdateProductModel = aProductModel;
            FillData();
        }
        //all data show in UI 
        public void FillData()
        {
            productId.Text = aUpdateProductModel.ProductId.ToString();
            productName.Text = aUpdateProductModel.ProductName;
            productType.Text = aUpdateProductModel.ProductType;
            buyingRate.Text = aUpdateProductModel.ProductBuyingRate.ToString();
            saleRate.Text = aUpdateProductModel.ProductSellingRate.ToString();
            vat.Text = aUpdateProductModel.Vat.ToString();
            vatsale.Text = aUpdateProductModel.ProductSaleRateWithVat.ToString();
            SKUTextbox.Text = aUpdateProductModel.Barcode;
            UnitCombox.Text = aUpdateProductModel.ProductUnit;
            MinimumQuantity.Text = aUpdateProductModel.ProductMinimumQuantity.ToString();
            if (aUpdateProductModel.ProductImage != null)
            {
                MemoryStream memstr = new MemoryStream( aUpdateProductModel.ProductImage);
                Image img = Image.FromStream(memstr);
                logo.Image = img;
            }

        }
        //save button click 
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
                        // update the product using  aupdate model
                        aUpdateProductModel.ProductName = productName.Text;
                        aUpdateProductModel.ProductType = productType.Text;
                        aUpdateProductModel.ProductBuyingRate = Convert.ToDecimal(buyingRate.Text);
                        aUpdateProductModel.ProductSellingRate = Convert.ToDecimal(saleRate.Text);
                        aUpdateProductModel.Vat = Convert.ToDecimal(vat.Text);
                        aUpdateProductModel.ProductSaleRateWithVat = Convert.ToDecimal(vatsale.Text);
                        aUpdateProductModel.Barcode = barcode;
                        aUpdateProductModel.ProductUnit = UnitCombox.Text;
                        aUpdateProductModel.ProductMinimumQuantity = minQuantity;
 

                        ProductManager newProductManager = new ProductManager();
                        int isDone = newProductManager.ProductUpdate(aUpdateProductModel);
                        if (isDone > 0)
                        {
                            MessageBox.Show("Update Sucessfully");
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Update Unsucessful");
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Try Again");
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
        // minmize
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //close button
        private void crossButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            //maximize  button
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

        //barode genarate
        private void BarcodeGenerator_Click(object sender, EventArgs e)
        {
            int generate = Convert.ToInt32(productId.Text) + 1000000;

            SKUTextbox.Text = generate.ToString();
        }

        // image  save 
        private void findLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLoc = dialog.FileName.ToString();
                logo.ImageLocation = imageLoc;
                FileStream stream = new FileStream(imageLoc, FileMode.Open, FileAccess.Read);
                BinaryReader binary = new BinaryReader(stream);
                image = binary.ReadBytes((int)stream.Length);
                aUpdateProductModel.ProductImage = image;
            }
        }
        //vat calcualtion 
        private void vat_TextChanged(object sender, EventArgs e)
        {
            // bool isNum = Double.TryParse(buyingRate.Text.Trim(), out num);
            try
            {
                if (vat.Text != "")
                {
                    decimal a = Convert.ToDecimal(saleRate.Text.ToString());
                    decimal b = Convert.ToDecimal(saleRate.Text.ToString());
                    decimal c = Convert.ToDecimal(vat.Text.ToString());
                    newCost = a + ((b * c) / 100);
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

        // close form 
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
