
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class InventoryModel
    {
        [System.ComponentModel.DisplayName("Strore Id")]
        public int InventoryId { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int  AgentId { get; set; }
        [System.ComponentModel.DisplayName("Agent Name")]
        public string AgentName { get; set; }
        [System.ComponentModel.DisplayName("Company Name")]
        public string CompanyName{ get; set; }
        [System.ComponentModel.DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [System.ComponentModel.DisplayName("Total Bill")]
        public decimal TotalBill { get; set; }
        [System.ComponentModel.DisplayName("Cash Paid")]
        public decimal CashPaid { get; set; }
        [System.ComponentModel.DisplayName("Due")]
        public decimal Due { get; set; }
        [System.ComponentModel.DisplayName("Date")]
        public DateTime Date { get; set; }


    }
}
