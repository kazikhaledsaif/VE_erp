using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StoreModel
    {
        [System.ComponentModel.DisplayName("Product Name")]
        public string ProductName { get; set; }
        [System.ComponentModel.DisplayName("Product Type")]
        public string ProductType { get; set; }
        [System.ComponentModel.DisplayName("Available Quantity")]
        public decimal Quantity { get; set; }

    }
}
