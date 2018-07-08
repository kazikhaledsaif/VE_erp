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
    public class DebtorGateway
    {

        private string conString = ConfigurationManager.ConnectionStrings["ekhteearDB"].ConnectionString;
        //bind all  Debotr in to a list 
        public List<DebtorModel> FillDebtorGrid()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = @" SELECT debtor.DebtorId,customer.CustomerName ,debtor.DebtorDue, debtor.Date FROM debtor INNER JOIN customer ON debtor.CustomerId = customer.CustomerId;";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<DebtorModel> debtorModels = new List<DebtorModel>();
                while (mySqlDataReader.Read())
                {
                    DebtorModel debtorModel =new DebtorModel();
                    debtorModel.DebtorId = (int) mySqlDataReader["DebtorId"];
                    debtorModel.CustomerName = mySqlDataReader["CustomerName"].ToString();
                    debtorModel.DebtorDue = Convert.ToDecimal(mySqlDataReader["DebtorDue"].ToString());
                    debtorModel.DebtorDate = Convert.ToDateTime(mySqlDataReader["Date"].ToString());
                 
                    debtorModels.Add(debtorModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return debtorModels;


            }

        }
        //Update debtor 
        public int UpdateDebtor(DebtorModel debtorModel)
        {


            String query = "UPDATE debtor SET DebtorDue = DebtorDue - @due   WHERE DebtorId = @debtorId; ";
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@due", debtorModel.DebtorDue);
                    cmd.Parameters.AddWithValue("@debtorId", debtorModel.DebtorId);
                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }
        //Delete debtor 
        public int DeleteDebtor(DebtorModel debtorModel)
        {


            String query = "DELETE FROM debtor  WHERE DebtorId = @DebtorId; ";
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();

                    cmd.Parameters.AddWithValue("@DebtorId", debtorModel.DebtorId);
                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }


        //debtor insert 
        public int DebtorInsert(DebtorModel debtorModel)
        {
            string query = @"INSERT INTO debtor " +
                           "(DebtorDue, CustomerId, Date) " +
                           "VALUES(@DebtorDue, @CustomerId, @Date);";

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@DebtorDue", debtorModel.DebtorDue);
                    cmd.Parameters.AddWithValue("@Date", debtorModel.DebtorDate);
                    cmd.Parameters.AddWithValue("@CustomerId", debtorModel.CustomerId);

                    int IsInserted = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return IsInserted;
                }
            }




        }









    }
}
