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
    public class LoginGateway
    {

        private string conString = ConfigurationManager.ConnectionStrings["ekhteearDB"].ConnectionString;

        public bool LoginInfo(LoginModel loginModel)
        {

            String query = "SELECT * FROM user WHERE Username ='" + loginModel.Username+ "' AND Password ='" + loginModel.Password+ "'";
                                                          

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    bool isDone = reader.HasRows;

                    reader.Close();
                    sqlConn.Close();
                
                    return isDone;
                }
            }
        }
    }
}
