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
    public  class AgentGateway
    {
      
        private string conString = ConfigurationManager.ConnectionStrings["ekhteearDB"].ConnectionString;



        //agent id generator
        public String AgentIdGenerate()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conString))
            {
                string Id;
                MySqlCommand cmd1 = new MySqlCommand(@"SELECT `AUTO_INCREMENT`
                FROM  INFORMATION_SCHEMA.TABLES
                WHERE TABLE_SCHEMA = 'ekhteeardb'
                AND   TABLE_NAME = 'agent'; ", sqlCon);
                sqlCon.Open();
                MySqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                Id = reader["AUTO_INCREMENT"].ToString();
                reader.Close();
                sqlCon.Close();
                return Id;
            }

        }
        //agent insert 
        public int AgentInsert(AgentModel  agentModel)
        {
            string query = @"INSERT INTO `ekhteeardb`.`agent` (`AgentName`, `CompanyName`, `PhoneNumber`)
                                                                    VALUES (@AgentName, @CompanyName, @PhoneNumber);";

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@AgentName", agentModel.AgentName);
                    cmd.Parameters.AddWithValue("@CompanyName", agentModel.CompanyName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", agentModel.PhoneNumber);
                 

                    int IsInserted = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return IsInserted;
                }
            }
        }

        //bind all  agent in to a list 
        public List<AgentModel> FillAgentGrid()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = "SELECT * FROM agent; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<AgentModel> agentModels = new List<AgentModel>();
                while (mySqlDataReader.Read())
                {
                    AgentModel agentModel = new AgentModel();
                    agentModel.AgentId = (int) mySqlDataReader["AgentId"];
                    agentModel.AgentName = mySqlDataReader["AgentName"].ToString();
                    agentModel.CompanyName = mySqlDataReader["CompanyName"].ToString();
                    agentModel.PhoneNumber = mySqlDataReader["PhoneNumber"].ToString();
                    agentModels.Add(agentModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return agentModels;


            }

        }

        // agent update 
        public int UpdateAgent(AgentModel agentModel)
        {


            String query = "UPDATE `ekhteeardb`.`agent` SET `AgentName` = @AgentName , `CompanyName` = @CompanyName ,`PhoneNumber` = @PhoneNumber WHERE `AgentId` =  " + agentModel.AgentId + "; ";

          
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@AgentName", agentModel.AgentName);

                    cmd.Parameters.AddWithValue("@CompanyName", agentModel.CompanyName);

                    cmd.Parameters.AddWithValue("@PhoneNumber", agentModel.PhoneNumber);




                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }

        //agent Delete
        public int DeleteAgent(AgentModel agentModel)
        {

            String query = "DELETE FROM agent WHERE `AgentId` = " + agentModel.AgentId + ";";


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
