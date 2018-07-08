using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class AgentModel
    {
        [System.ComponentModel.DisplayName("Agent ID")]
        public int AgentId { get; set; }
        [System.ComponentModel.DisplayName("Agent Name")]
        public string AgentName { get; set; }
        [System.ComponentModel.DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [System.ComponentModel.DisplayName("Phone Name")]
        public string PhoneNumber { get; set; }

    }
}
