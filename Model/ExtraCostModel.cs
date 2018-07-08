using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class ExtraCostModel
    {
        [System.ComponentModel.DisplayName("Expense ID")]
        public int  ExtraCostId { get; set; }
        [System.ComponentModel.DisplayName("Expense Type")]
        public string CostType { get; set; }
        [System.ComponentModel.DisplayName("Expense Amount")]
        public decimal Amount { get; set; }
        [System.ComponentModel.DisplayName("Date")]
        public DateTime CostDate { get; set; }

    }
}
