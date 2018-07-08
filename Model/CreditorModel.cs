using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CreditorModel
    {
        [System.ComponentModel.DisplayName("Creditor ID")]
        public int CreditorId { get; set; }
        [System.ComponentModel.DisplayName("Agent Name")]
        public string AgentName { get; set; }
        [System.ComponentModel.DisplayName("Creditor's Due")]
        public decimal CreditorDue { get; set; }
        [System.ComponentModel.DisplayName("Date")]
        public DateTime Date { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int AgentId { get; set; }
        [System.ComponentModel.DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [System.ComponentModel.DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

    }
}
