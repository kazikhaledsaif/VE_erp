using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class DebtorModel
    {
        [System.ComponentModel.DisplayName("Debtor ID")]
        public  int  DebtorId { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int CustomerId { get; set; }
        [System.ComponentModel.DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [System.ComponentModel.DisplayName("Debtor Due")]
        public decimal DebtorDue  { get; set; }
        [System.ComponentModel.DisplayName("Date")]
        public DateTime DebtorDate { get; set; }  

    }
}
