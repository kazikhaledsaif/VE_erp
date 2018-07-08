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
   public  class UsersGateway
    {

        private string conString = ConfigurationManager.ConnectionStrings["ekhteearDB"].ConnectionString;

        //user  id generator
        public String UserIdGenerate()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conString))
            {
                string Id;
                MySqlCommand cmd1 = new MySqlCommand(@"SELECT `AUTO_INCREMENT`
                FROM  INFORMATION_SCHEMA.TABLES
                WHERE TABLE_SCHEMA = 'ekhteeardb'
                AND   TABLE_NAME = 'user'; ", sqlCon);
                sqlCon.Open();
                MySqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                Id = reader["AUTO_INCREMENT"].ToString();
                reader.Close();
                sqlCon.Close();
                return Id;
            }

        }

        //user insert 
        public int UserInsert(UsersModel usersModel )
        {
            string query = @"INSERT INTO user  (Username, UserType, Password, Date) VALUES(@UserName, @UserType, @PassWord, @Date);";

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@UserName", usersModel.Username);
                    cmd.Parameters.AddWithValue("@PassWord", usersModel.Password);
                    cmd.Parameters.AddWithValue("@UserType", usersModel.Usertype);
                    cmd.Parameters.AddWithValue("@Date", usersModel.Date);


                    int IsInserted = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return IsInserted;
                }
            }
        }


        //bind all users  in to a list 
        public List<UsersModel> FillUsersGrid()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = "SELECT * FROM user; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<UsersModel> usersModels = new List<UsersModel>();
                while (mySqlDataReader.Read())
                {
                      UsersModel usersModel =   new UsersModel();
                    usersModel.UserId = (int)mySqlDataReader["UserId"];
                    usersModel.Username = mySqlDataReader["Username"].ToString();
                    usersModel.Password = mySqlDataReader["Password"].ToString();
                    usersModel.Usertype = mySqlDataReader["UserType"].ToString();
                    usersModel.Date = Convert.ToDateTime(mySqlDataReader["Date"].ToString());
                    usersModels.Add(usersModel);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return usersModels;

            }

        }


        // users  update 
        public int UpdateUser(UsersModel usersModel )
        {


            String query = @"UPDATE user SET Username=  @UserName , UserType= @UserType, Password=  @PassWord , Date= @Date   Where UserId=" + usersModel.UserId + ";";


            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@UserName", usersModel.Username);
                    cmd.Parameters.AddWithValue("@PassWord", usersModel.Password);
                    cmd.Parameters.AddWithValue("@UserType", usersModel.Usertype);
                  //  cmd.Parameters.AddWithValue("@Date", usersModel.Date);

                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }

        //User Delete
        public int DeleteUser (UsersModel usersModel )
        {

            String query = "DELETE FROM user    WHERE `UserId` = " + usersModel.UserId + ";";


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
