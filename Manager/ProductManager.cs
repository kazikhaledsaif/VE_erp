using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Gateway;
using Model;

namespace Manager
{
    public class ProductManager
    {
       private  ProductGateway newProductGateway = new ProductGateway();
        //product id call 
        public string GetProductId()
        {

           String Id= newProductGateway.ProductIdGenerate();
            return Id;
        }
        // product insert call
        public int ProductInsert(ProductModel aProductModel)
        {
         
            int Isinsert = newProductGateway.ProductInsert(aProductModel);
            return Isinsert;
        }
        //product update call
        public int ProductUpdate(ProductModel aProductModel)
        {

            int IsUpdate = newProductGateway.UpdateProduct(aProductModel);
            return IsUpdate;
        }
        //product list call
        public List<ProductModel> GetProductList()
        {
            return newProductGateway.FillProductGrid();
        }
        //product delete call 
        public int DeleteProduct(ProductModel aProductModel)
        {
            return newProductGateway.DeleteProduct(aProductModel);
        }
    }
}
