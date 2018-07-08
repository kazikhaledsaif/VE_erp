using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace Gateway
{
    public class ExtraCostGateway
    {
        private string conString = ConfigurationManager.ConnectionStrings["ekhteearDB"].ConnectionString;

        //Exrta Cost  id generator
        public String ExtraCostIdGenerate()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conString))
            {
                string Id;
                MySqlCommand cmd1 = new MySqlCommand(@"SELECT `AUTO_INCREMENT`
                FROM  INFORMATION_SCHEMA.TABLES
                WHERE TABLE_SCHEMA = 'ekhteeardb'
                AND   TABLE_NAME = 'extracost'; ", sqlCon);
                sqlCon.Open();
                MySqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                Id = reader["AUTO_INCREMENT"].ToString();
                reader.Close();
                sqlCon.Close();
                return Id;
            }

        }

        //Extra Cost insert 
        public int ExtraCostInsert(ExtraCostModel extraCostModel)
        {
            string query = @"INSERT INTO extracost  (CostType, Amount, Date) VALUES(@CostType, @Amount, @Date);";

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@CostType", extraCostModel.CostType);
                    cmd.Parameters.AddWithValue("@Amount",extraCostModel.Amount);
                    cmd.Parameters.AddWithValue("@Date",extraCostModel.CostDate);


                    int IsInserted = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return IsInserted;
                }
            }
        }


        //bind all Extracost  in to a list 
        public List<ExtraCostModel> FillExtraCostGrid()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = "SELECT * FROM extracost; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<ExtraCostModel> extraCostModels = new List<ExtraCostModel>();
                while (mySqlDataReader.Read())
                {
                    ExtraCostModel extraCostModel = new ExtraCostModel();
                    extraCostModel.ExtraCostId = (int)mySqlDataReader["CostId"];
                    extraCostModel.CostType = mySqlDataReader["CostType"].ToString();
                    extraCostModel.Amount = Convert.ToDecimal(mySqlDataReader["Amount"].ToString());
                    extraCostModel.CostDate = Convert.ToDateTime(mySqlDataReader["Date"].ToString());
                    extraCostModels.Add(extraCostModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return extraCostModels;

            }

        }


        // extracost  update 
        public int UpdateExtraCost(ExtraCostModel extraCostModel)
        {


            String query = @"UPDATE extracost SET CostType=  @CostType , Amount= @Amount Where CostId=" + extraCostModel.ExtraCostId + ";";


            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@CostType", extraCostModel.CostType);
                    cmd.Parameters.AddWithValue("@Amount", extraCostModel.Amount);
                   // cmd.Parameters.AddWithValue("@Date", extraCostModel.CostDate);

                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }

        //Extracost Delete
        public int DeleteExtraCost(ExtraCostModel extraCostModel)
        {

            String query = "DELETE FROM extracost    WHERE `CostId` = " + extraCostModel.ExtraCostId + ";";


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
