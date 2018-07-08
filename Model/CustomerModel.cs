using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class CustomerModel
    {
        [System.ComponentModel.DisplayName("Customer ID")]
        public int CustomerId { get; set; }
        [System.ComponentModel.DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [System.ComponentModel.DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [System.ComponentModel.DisplayName("Phone Number")]
        public string PhoneNumber{ get; set; }
        [System.ComponentModel.DisplayName("Customer Type")]
        public string CustomerType { get; set; }
        [System.ComponentModel.DisplayName("Date")]
        public DateTime Date { get; set; }

    }
}
