using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductModel
    {
        [System.ComponentModel.DisplayName("Product ID")]
        public int ProductId { get; set; }
        [System.ComponentModel.DisplayName("Product Name")]
        public  string ProductName { get; set; }
        [System.ComponentModel.DisplayName("Product Type")]
        public string ProductType { get; set; }
        [System.ComponentModel.DisplayName("Buy Rate")]
        public decimal ProductBuyingRate { get; set; }
        [System.ComponentModel.DisplayName("Sale Rate")]
        public decimal ProductSellingRate { get; set; }
        [System.ComponentModel.Browsable(false)]
        public decimal ProductQuantity { get; set; }
        [System.ComponentModel.DisplayName("Vat")]
        public decimal Vat { get; set; }
        [System.ComponentModel.DisplayName("Sale With Vat")]
        public decimal ProductSaleRateWithVat { get; set; }
        [System.ComponentModel.DisplayName("Barcode")]
        public  string Barcode { get; set; }
        [System.ComponentModel.DisplayName("Unit")]
        public string ProductUnit { get; set; }
        [System.ComponentModel.DisplayName("Minimum Quantity")]
        public decimal ProductMinimumQuantity { get; set; }
        [System.ComponentModel.DisplayName("Photo")]
        public byte[] ProductImage { get; set; }



        public ProductModel()
        {
            this.ProductQuantity = 0;       
        }
    }
}
