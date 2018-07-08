using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace Gateway
{
   public class InventoryGateway
    {
     
        private string conString = ConfigurationManager.ConnectionStrings["ekhteearDB"].ConnectionString;

        //bind all store product in to a list 
        public List<StoreModel> FillStoreGrid()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = "SELECT  ProductName, ProductType, Quantity FROM product; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<StoreModel> strModels = new List<StoreModel>();
                while (mySqlDataReader.Read())
                {
                    StoreModel storeModel = new StoreModel();
                    storeModel.ProductName = mySqlDataReader["ProductName"].ToString();
                    storeModel.ProductType = mySqlDataReader["ProductType"].ToString();
                    storeModel.Quantity = (decimal) mySqlDataReader["Quantity"];
                   
                    strModels.Add(storeModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return strModels;


            }

        }
        
        //store id generator
        public String StoreIdGenerate()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conString))
            {
                string Id;
               
                MySqlCommand cmd1 = new MySqlCommand(@"SELECT `AUTO_INCREMENT`
                FROM  INFORMATION_SCHEMA.TABLES
                WHERE TABLE_SCHEMA = 'ekhteeardb'
                AND   TABLE_NAME = 'inventory'; ", sqlCon);
                sqlCon.Open();
                MySqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                Id = reader["AUTO_INCREMENT"].ToString();
                reader.Close();
                sqlCon.Close();
                return Id;
            }



        }

        //get product name list

        public List<ProductModel> GetProductList()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = "SELECT ProductId , ProductName  FROM product; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<ProductModel> product = new List<ProductModel>();
                while (mySqlDataReader.Read())
                {
                    ProductModel aProductModel = new ProductModel();
                    aProductModel.ProductId = (int)mySqlDataReader["ProductId"];
                    aProductModel.ProductName = mySqlDataReader["ProductName"].ToString();
             

                    product.Add(aProductModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return product;


            }



        }


        //get Agent name list

        public List<AgentModel> GetAgentLists()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = "SELECT AgentId , AgentName  FROM agent; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<AgentModel> product = new List<AgentModel>();
                while (mySqlDataReader.Read())
                {
                    AgentModel agentModel = new AgentModel();
                    agentModel.AgentId = (int)mySqlDataReader["AgentId"];
                    agentModel.AgentName = mySqlDataReader["AgentName"].ToString();


                    product.Add(agentModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return product;


            }



        }


        //fetch buying rate and unit with product id 

        public ProductModel GetProductInfo(ProductModel productModel)
        {

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = "SELECT BuyingRate , Unit  FROM product WHERE ProductId ="+ productModel.ProductId+ "; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                ProductModel aProductModel = new ProductModel();
                if (mySqlDataReader.Read())
                {
                   
                    aProductModel.ProductBuyingRate = (decimal) mySqlDataReader["BuyingRate"];
                    aProductModel.ProductUnit = mySqlDataReader["Unit"].ToString();


                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return aProductModel;


            }


        }


        //fetch companyname with product id 
        public AgentModel GetAgentInfo(AgentModel agentModel)
        {

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = "SELECT CompanyName  FROM agent WHERE AgentId =" + agentModel.AgentId + "; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                AgentModel newAgentModel = new AgentModel();
                if (mySqlDataReader.Read())
                {
                    newAgentModel.CompanyName = mySqlDataReader["CompanyName"].ToString();
                

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return newAgentModel;


            }


        }


    
        //bind all  inventoryDetails lists in to a list   in add inventory
        public List<InventoryDetailModel> FillInventoryDetailsGrid(int StoreId)
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                int GetstoreId = StoreId;
                String query = "SELECT product.ProductId,ProductName,  InventoryQuantity ,Cost , SellingRate , BuyingRate  FROM inventorydetails Inner JOIN product On inventorydetails.ProductId = product.ProductId where  InventoryId= " + GetstoreId + " ;";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<InventoryDetailModel> inventoryDetailModels = new List<InventoryDetailModel>();
                while (mySqlDataReader.Read())
                {
                    InventoryDetailModel inventoryDetailModel = new InventoryDetailModel();
                    inventoryDetailModel.ProductId = (int)mySqlDataReader["ProductId"];
                   // inventoryDetailModel.InventorydeatilsId = (int) mySqlDataReader["InventoryDetailsId"];
                    inventoryDetailModel.ProductName = mySqlDataReader["ProductName"].ToString();
                    inventoryDetailModel.Quantity = (decimal) mySqlDataReader["InventoryQuantity"];
                    inventoryDetailModel.Cost = (decimal)mySqlDataReader["Cost"];
                    inventoryDetailModel.SellingRate = (decimal)mySqlDataReader["SellingRate"];
                    inventoryDetailModel.BuyingRate = (decimal)mySqlDataReader["BuyingRate"];
                    inventoryDetailModels.Add(inventoryDetailModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return inventoryDetailModels;


            }




        }


        // delete a Inventory item
        public int DeleteInventoryDetails(InventoryDetailModel inventoryDetailModel)
        {

            String query = "DELETE FROM inventorydetails WHERE `InventoryDetailsId` = " + inventoryDetailModel.InventorydeatilsId + ";";


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

        //add new data to inventory list
        public int AddToInventory(InventoryDetailModel inventoryDetailModel)
        {

            string query = "INSERT INTO inventorydetails (InventoryId,ProductId,InventoryQuantity,Cost) VALUES(@invetryId , @productid , @quantity ,@cost)";

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@invetryId", inventoryDetailModel.InventoryId);
                    cmd.Parameters.AddWithValue("@productid", inventoryDetailModel.ProductId);
                    cmd.Parameters.AddWithValue("@quantity", inventoryDetailModel.Quantity);
                    cmd.Parameters.AddWithValue("@cost", inventoryDetailModel.Cost);
              
                    int IsInserted = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return IsInserted;
                }
            }

        }

        //purchase
        //add new data 
        public int AddToPurshase(InventoryModel inventoryModel)
        {

            String query = "INSERT INTO inventory (AgentId,TotalBill,CashPaid,Due,Date) VALUES( @agentid , @totalbill ,@cashpaid,@due,@date)";

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@agentid",inventoryModel.AgentId);
                    cmd.Parameters.AddWithValue("@totalbill", inventoryModel.TotalBill);
                    cmd.Parameters.AddWithValue("@cashpaid",inventoryModel.CashPaid);
                    cmd.Parameters.AddWithValue("@due", inventoryModel.Due);
                    cmd.Parameters.AddWithValue("@date",inventoryModel.Date);
                    int IsInserted = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return IsInserted;
                }
            }

        }


        //bind all  inventorygrid lists in to a list 
        public List<InventoryModel> FillInventoryGrid()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();

                String query = @"SELECT InventoryId, AgentName, TotalBill, CashPaid,Due, Date ,CompanyName,  PhoneNumber FROM  inventory JOIN agent On inventory.AgentId = agent.AgentId ;";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<InventoryModel> inventoryModels = new List<InventoryModel>();
                while (mySqlDataReader.Read())
                {
                   InventoryModel inventoryModel = new InventoryModel();
                    inventoryModel.InventoryId = (int)mySqlDataReader["InventoryId"];
                    inventoryModel.AgentName = mySqlDataReader["AgentName"].ToString();
                    inventoryModel.TotalBill = Convert.ToDecimal(mySqlDataReader["TotalBill"].ToString());

                    inventoryModel.CashPaid = Convert.ToDecimal(mySqlDataReader["CashPaid"].ToString());
                    inventoryModel.CompanyName = mySqlDataReader["CompanyName"].ToString();
                    inventoryModel.PhoneNumber = mySqlDataReader["PhoneNumber"].ToString();
                    
                   // inventoryModel.Date = DateTime.ParseExact(mySqlDataReader["Date"].ToString("MM/dd/yy"), "dd/mm/yyyy",
                 //      CultureInfo.InvariantCulture);
                    inventoryModel.Date = (DateTime) mySqlDataReader["Date"];
                    inventoryModels.Add(inventoryModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return inventoryModels;


            }

        }


        //bind all  Inventory View lists in to a list 
        public List<InventoryDetailModel> FillInventoryViewGrid(InventoryModel Imodel)
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();

                String query = @"SELECT InventoryDetailsId, product.ProductId, ProductName,ProductType, InventoryQuantity, Cost, SellingRate,BuyingRate FROM inventoryDetails JOIN product On inventoryDetails.ProductId = product.ProductId  WHERE InventoryId= " + Imodel.InventoryId + "";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<InventoryDetailModel> inventoryViewModels = new List<InventoryDetailModel>();
                while (mySqlDataReader.Read())
                {
                    InventoryDetailModel inventoryModel = new InventoryDetailModel();
                    inventoryModel.InventorydeatilsId = (int) mySqlDataReader["InventoryDetailsId"];
                    inventoryModel.ProductId = (int) mySqlDataReader["ProductId"];
                    inventoryModel.ProductName = mySqlDataReader["ProductName"].ToString();
                    inventoryModel.ProductType = mySqlDataReader["ProductType"].ToString();
                    inventoryModel.Quantity = Convert.ToDecimal(mySqlDataReader["InventoryQuantity"].ToString());
                    inventoryModel.Cost = Convert.ToDecimal(mySqlDataReader["Cost"].ToString());
                    inventoryModel.SellingRate = Convert.ToDecimal(mySqlDataReader["SellingRate"].ToString());
                    inventoryModel.BuyingRate = Convert.ToDecimal(mySqlDataReader["BuyingRate"].ToString());
            
                    inventoryViewModels.Add(inventoryModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return inventoryViewModels;


            }

        }


        //Product Increase
        public int ProductIncrease(InventoryDetailModel inventoryDetailModel)
        {

            String query = @"UPDATE product SET  Quantity= Quantity +  @quantity   WHERE  ProductId =  @productId ";



            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@quantity", inventoryDetailModel.Quantity);
                    cmd.Parameters.AddWithValue("@productId", inventoryDetailModel.ProductId);
                

                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }

        //Product Decrease
        public int ProductDecrease(InventoryDetailModel inventoryDetailModel)
        {

            String query = @"UPDATE product SET  Quantity= Quantity -  @quantity   WHERE  ProductId =  @productId ";



            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@quantity", inventoryDetailModel.Quantity);
                    cmd.Parameters.AddWithValue("@productId", inventoryDetailModel.ProductId);


                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }


        //Inventory Decrease 

       
        public int InventoryDecrease(InventoryDetailModel inventoryDetailModel)
        {

            String query = @"UPDATE inventorydetails SET  InventoryQuantity= InventoryQuantity -  @quantity   WHERE  InventoryDetailsId =  @InventoryDetailsId ";



            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@InventoryDetailsId", inventoryDetailModel.InventorydeatilsId);
                    cmd.Parameters.AddWithValue("@quantity", inventoryDetailModel.Quantity);


                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }




    }
}
