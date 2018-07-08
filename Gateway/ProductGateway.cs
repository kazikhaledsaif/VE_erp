using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Gateway
{


    public class ProductGateway
    {

        private string conString = ConfigurationManager.ConnectionStrings["ekhteearDB"].ConnectionString;


        //product insert 
        public int ProductInsert(ProductModel aProductModel)
        {
            string query = @"INSERT INTO `ekhteeardb`.`product` (`ProductName`, `ProductType`, `BuyingRate`, `SellingRate`, `Quantity`, `SKU`, `Unit`, `MinimumQuantity`, `Vat`, `SaleWithVat`,`ProductImage`)
                                                                    VALUES (@productName, @productType, @buyingRate, @saleRate,@quantity,@sku,@unit,@minQuantity,@vat,@salewithvat,@image);";

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@productName", aProductModel.ProductName);
                    cmd.Parameters.AddWithValue("@productType", aProductModel.ProductType);
                    cmd.Parameters.AddWithValue("@buyingRate", aProductModel.ProductBuyingRate);
                    cmd.Parameters.AddWithValue("@saleRate", aProductModel.ProductSellingRate);
                   cmd.Parameters.AddWithValue("@quantity", aProductModel.ProductQuantity);
                    cmd.Parameters.AddWithValue("@sku", aProductModel.Barcode);
                    cmd.Parameters.AddWithValue("@Unit", aProductModel.ProductUnit);
                    cmd.Parameters.AddWithValue("@minQuantity", aProductModel.ProductMinimumQuantity);
                    cmd.Parameters.AddWithValue("@vat", aProductModel.Vat);
                    cmd.Parameters.AddWithValue("@salewithvat", aProductModel.ProductSaleRateWithVat);

                    if (aProductModel.ProductImage != null)
                    {

                        cmd.Parameters.AddWithValue("@image", aProductModel.ProductImage);
                    }
                    else
                    {
                        MySqlParameter imageParameter = new MySqlParameter("@image", MySqlDbType.MediumBlob);
                        imageParameter.Value = DBNull.Value;
                        cmd.Parameters.Add(imageParameter);
                    }

                    int IsInserted = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return IsInserted;
                }
            }




        }
        // product update 
        public int UpdateProduct(ProductModel aProductModel)
        {


            String query = "UPDATE `ekhteeardb`.`product` SET `ProductName` = @productName , `ProductType` = @productType ,`BuyingRate` = @buyingRate ,  `SellingRate`=  @saleRate ,  `Quantity` = @quantity , `SKU` = @sku, `Unit`= @unit, `MinimumQuantity` = @minQuantity, `Vat` = @vat, `SaleWithVat`= @salewithvat,`ProductImage`= @image WHERE `ProductId` =  " + aProductModel.ProductId + "; ";

           // string query = @"UPDATE INTO `ekhteeardb`.`product` (`ProductName`, `ProductType`, `BuyingRate`, `SellingRate`, `Quantity`, `SKU`, `Unit`, `MinimumQuantity`, `Vat`, `SaleWithVat`,`ProductImage`)
             //                                                       VALUES (@productName, @productType, @buyingRate, @saleRate,@quantity,@sku,@unit,@minQuantity,@vat,@salewithvat,@image);";

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@productName", aProductModel.ProductName);
                    cmd.Parameters.AddWithValue("@productType", aProductModel.ProductType);
                    cmd.Parameters.AddWithValue("@buyingRate", aProductModel.ProductBuyingRate);
                    cmd.Parameters.AddWithValue("@saleRate", aProductModel.ProductSellingRate);
                    cmd.Parameters.AddWithValue("@quantity", aProductModel.ProductQuantity);
                    cmd.Parameters.AddWithValue("@sku", aProductModel.Barcode);
                    cmd.Parameters.AddWithValue("@Unit", aProductModel.ProductUnit);
                    cmd.Parameters.AddWithValue("@minQuantity", aProductModel.ProductMinimumQuantity);
                    cmd.Parameters.AddWithValue("@vat", aProductModel.Vat);
                    cmd.Parameters.AddWithValue("@salewithvat", aProductModel.ProductSaleRateWithVat);

                    if (aProductModel.ProductImage != null)
                    {

                        cmd.Parameters.AddWithValue("@image", aProductModel.ProductImage);

                    }
                    else
                    {
                        MySqlParameter imageParameter = new MySqlParameter("@image", MySqlDbType.MediumBlob);
                        imageParameter.Value = DBNull.Value;
                        cmd.Parameters.Add(imageParameter);
                    }

                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }




        }
            //product id generator
        public String ProductIdGenerate()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conString))
            {
                string Id;
                //MySqlCommand cmd = new MySqlCommand("SELECT IDENT_CURRENT('product') + IDENT_INCR('product') AS ProductId;", sqlCon);
                MySqlCommand cmd1 = new MySqlCommand(@"SELECT `AUTO_INCREMENT`
                FROM  INFORMATION_SCHEMA.TABLES
                WHERE TABLE_SCHEMA = 'ekhteeardb'
                AND   TABLE_NAME = 'product'; ", sqlCon);
                sqlCon.Open();
                MySqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                Id = reader["AUTO_INCREMENT"].ToString();
                reader.Close();
                sqlCon.Close();
                return Id;
            }



        }

        //bind all  product in to a list 
        public List<ProductModel> FillProductGrid()
        {
            using ( MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = "SELECT ProductId AS 'Product ID', ProductName AS 'Product Name', ProductType AS 'Product Type',Vat, BuyingRate AS 'Buying Rate', SellingRate AS 'Selling Rate' , SaleWithVat AS 'Sale With Vat', SKU as 'Barcode', Unit as 'Unit' , MinimumQuantity as  'Minimum Quantity' , ProductImage As 'Product Image' FROM product; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<ProductModel> product =  new List<ProductModel>();
                while (mySqlDataReader.Read())
                {
                    ProductModel aProductModel = new ProductModel();
                    aProductModel.ProductId = (int) mySqlDataReader["Product ID"];
                    aProductModel.ProductName = mySqlDataReader["Product Name"].ToString();
                    aProductModel.ProductType = mySqlDataReader["Product Type"].ToString();
                    aProductModel.ProductBuyingRate = Convert.ToDecimal(mySqlDataReader["Buying Rate"].ToString());
                    aProductModel.ProductSellingRate = Convert.ToDecimal(mySqlDataReader["Selling Rate"].ToString());
                 aProductModel.Vat = Convert.ToDecimal(mySqlDataReader["Vat"].ToString());
                    aProductModel.ProductSaleRateWithVat = Convert.ToDecimal(mySqlDataReader["Sale With Vat"].ToString());
                    aProductModel.Barcode = mySqlDataReader["Barcode"].ToString();
                 aProductModel.ProductUnit = mySqlDataReader["Unit"].ToString();
                    aProductModel.ProductMinimumQuantity = Convert.ToDecimal(mySqlDataReader["Minimum Quantity"].ToString());
                    aProductModel.ProductImage = mySqlDataReader["Product Image"] as byte[];

                    product.Add(aProductModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return product;


            }

        }


        // delete a product
        public int DeleteProduct(ProductModel aProductModel)
        {

            String query = "DELETE FROM product WHERE `ProductId` = " + aProductModel.ProductId + ";";


            using (MySqlConnection sqlCon = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                {
                    sqlCon.Open();
                    int k = cmd.ExecuteNonQuery();
                    sqlCon.Close();
                    return k;
                }
            }

           

        }










    }
}
