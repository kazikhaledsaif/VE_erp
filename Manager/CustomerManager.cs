using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gateway;
using Model;

namespace Manager
{
   public  class CustomerManager
    {
        private CustomerGateway customerGateway = new CustomerGateway();

        //Customer id call
        public string GetCustomerId()
        {

            String Id = customerGateway.CustomerIdGenerate();
            return Id;
        }
        // Customer insert call
        public int CustomerInsert(CustomerModel customerModel)
        {

            int Isinsert = customerGateway.CustomerInsert(customerModel);
            return Isinsert;
        }
        //Customer update call
        public int CustomerUpdate(CustomerModel customerModel)
        {

            int IsUpdate = customerGateway.UpdateCustomer(customerModel);
            return IsUpdate;
        }
        //Customer list call
        public List<CustomerModel> GetCustomerList()
        {
            return customerGateway.FillCustomerGrid();
        }
        //Customer delete call 
        public int DeleteCustomert(CustomerModel customerModel)
        {
            return customerGateway.DeleteCustomer(customerModel);
        }




    }
}
