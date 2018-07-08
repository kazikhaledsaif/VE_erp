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
   public class CreditorGateway
    {
        private string conString = ConfigurationManager.ConnectionStrings["ekhteearDB"].ConnectionString;
        //bind all  Creditors in to a list 
        public List<CreditorModel> FillCreditorGrid()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = @"SELECT CreditorId , AgentName, CreditorDue, Date,
                    CompanyName, 
                    PhoneNumber  FROM  creditor JOIN agent On creditor.AgentId = agent.AgentId ; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<CreditorModel> creditorModels = new List<CreditorModel>();
                while (mySqlDataReader.Read())
                {
                    CreditorModel creditorModel = new CreditorModel();
                    creditorModel.CreditorId = (int) mySqlDataReader["CreditorId"];
                    creditorModel.AgentName = mySqlDataReader["AgentName"].ToString();
                    creditorModel.CreditorDue = Convert.ToDecimal(mySqlDataReader["CreditorDue"]);
                    creditorModel.Date = Convert.ToDateTime(mySqlDataReader["Date"].ToString());
                    creditorModel.CompanyName = mySqlDataReader["CompanyName"].ToString();
                    creditorModel.PhoneNumber = mySqlDataReader["PhoneNumber"].ToString();
                    creditorModels.Add(creditorModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return creditorModels;


            }




        }
        //Update creditor 
        public int UpdateCreditor(CreditorModel creditorModel)
        {


            String query = "UPDATE creditor SET CreditorDue = CreditorDue - @due   WHERE CreditorId = @creditorId; "; 
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@due", creditorModel.CreditorDue);
                    cmd.Parameters.AddWithValue("@creditorId", creditorModel.CreditorId);
                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }
        //Delete creditor 
        public int DeleteCreditor(CreditorModel creditorModel)
        {


            String query = "DELETE FROM creditor  WHERE CreditorId = @creditorId; ";
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
              
                    cmd.Parameters.AddWithValue("@creditorId", creditorModel.CreditorId);
                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }


        //creditor insert 
        public int CreditorInsert( CreditorModel creditorModel)
        {
            string query = @"INSERT INTO creditor (CreditorDue,Date,AgentId) VALUES (@CreditorDue , @Date , @AgentId);";

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@CreditorDue", creditorModel.CreditorDue);
                    cmd.Parameters.AddWithValue("@Date", creditorModel.Date);
                    cmd.Parameters.AddWithValue("@AgentId", creditorModel.AgentId);

                    int IsInserted = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return IsInserted;
                }
            }




        }

    }
}
