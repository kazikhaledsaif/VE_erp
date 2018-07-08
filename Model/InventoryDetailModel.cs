using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class InventoryDetailModel
    {
        [System.ComponentModel.Browsable(false)]
        public int  InventorydeatilsId { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int  InventoryId { get; set; }
        [System.ComponentModel.Browsable(false)]
        public int ProductId  { get; set; }
        [System.ComponentModel.DisplayName("Product Name")]
        public string ProductName { get; set; }

        [System.ComponentModel.Browsable(false)]
        public string ProductType { get; set; }
        [System.ComponentModel.DisplayName("Product Quantity")]
        public decimal Quantity { get; set; }
        [System.ComponentModel.DisplayName("Cost")]
        public decimal Cost { get; set; }
        [System.ComponentModel.DisplayName("Selling Rate")]
        public  decimal SellingRate { get; set; }
        [System.ComponentModel.DisplayName("Buying Rate")]
        public decimal BuyingRate { get; set; }

    }
}
