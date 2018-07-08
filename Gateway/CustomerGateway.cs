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
    public class CustomerGateway
    {



        private string conString = ConfigurationManager.ConnectionStrings["ekhteearDB"].ConnectionString;


        //Customer insert 
        public int CustomerInsert(CustomerModel customerModel)
        {
            string query = @"INSERT INTO `ekhteeardb`.`customer` (`CustomerName`,`CompanyName`, `PhoneNumber`,`CustomerType`,`Date`)
                 VALUES (@CustomerName,@CompanyName,@PhoneNumber,@CustomerType,@Date);";

            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@CustomerName", customerModel.CustomerName);
                    cmd.Parameters.AddWithValue("@CompanyName", customerModel.CompanyName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", customerModel.PhoneNumber);
                    cmd.Parameters.AddWithValue("@CustomerType", customerModel.CustomerType);
                    cmd.Parameters.AddWithValue("@Date", customerModel.Date);


                    int IsInserted = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return IsInserted;
                }
            }




        }
        // customers update 
        public int UpdateCustomer(CustomerModel customerModel)
        {


            String query = "UPDATE `ekhteeardb`.`customer` SET `CustomerName` = @CustomerName , " +
                           "`CompanyName` = @CompanyName ,`PhoneNumber` = @PhoneNumber ,`CustomerType` = @CustomerType WHERE `CustomerId` =  " + customerModel.CustomerId + "; ";
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, sqlConn))
                {
                    sqlConn.Open();
                    cmd.Parameters.AddWithValue("@CustomerName", customerModel.CustomerName);
                    cmd.Parameters.AddWithValue("@CompanyName", customerModel.CompanyName);
                    cmd.Parameters.AddWithValue("@PhoneNumber", customerModel.PhoneNumber);

                    cmd.Parameters.AddWithValue("@CustomerType", customerModel.CustomerType);

                    int isUpdate = cmd.ExecuteNonQuery();
                    sqlConn.Close();
                    return isUpdate;
                }
            }

        }
        //customers id generator
        public String CustomerIdGenerate()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(conString))
            {
                string Id;
                //MySqlCommand cmd = new MySqlCommand("SELECT IDENT_CURRENT('product') + IDENT_INCR('product') AS ProductId;", sqlCon);
                MySqlCommand cmd1 = new MySqlCommand(@"SELECT `AUTO_INCREMENT`
                FROM  INFORMATION_SCHEMA.TABLES
                WHERE TABLE_SCHEMA = 'ekhteeardb'
                AND   TABLE_NAME = 'customer'; ", sqlCon);
                sqlCon.Open();
                MySqlDataReader reader = cmd1.ExecuteReader();
                reader.Read();
                Id = reader["AUTO_INCREMENT"].ToString();
                reader.Close();
                sqlCon.Close();
                return Id;
            }



        }

        //bind all  customers in to a list 
        public List<CustomerModel> FillCustomerGrid()
        {
            using (MySqlConnection sqlConn = new MySqlConnection(conString))
            {
                sqlConn.Open();
                String query = "Select * FROM customer; ";
                MySqlCommand cmd = new MySqlCommand(query, sqlConn);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
                List<CustomerModel> customers = new List<CustomerModel>();
                while (mySqlDataReader.Read())
                {
                    CustomerModel customer = new CustomerModel();

                    customer.CustomerId = (int)mySqlDataReader["CustomerId"];
                    customer.CustomerName = mySqlDataReader["CustomerName"].ToString();

                    customer.CompanyName = mySqlDataReader["CompanyName"].ToString();
                    customer.CustomerType = mySqlDataReader["CustomerType"].ToString();
                    customer.PhoneNumber = mySqlDataReader["PhoneNumber"].ToString();

                    customer.Date = Convert.ToDateTime(mySqlDataReader["Date"].ToString());

                    customers.Add(customer);

                }
                mySqlDataReader.Close();
                sqlConn.Close();
                return customers;


            }




        }


        // delete a Customer
        public int DeleteCustomer(CustomerModel customerModel)
        {

            String query = "DELETE FROM customer WHERE `CustomerId` = " + customerModel.CustomerId + ";";


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
