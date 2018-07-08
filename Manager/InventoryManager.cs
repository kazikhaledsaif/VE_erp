using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gateway;
using Model;

namespace Manager
{
    public class InventoryManager
    {
        private InventoryGateway inventoryGateway = new InventoryGateway();
        //Store Grid list call
        public List<StoreModel> GetAgentModels()
        {
            return inventoryGateway.FillStoreGrid();
        }
        

        //store Id call

        public string GetStoreId()
        {
            string id = inventoryGateway.StoreIdGenerate();
            return id;
        }


        //product list
        public List<ProductModel> GetProductlList()
        {
            return inventoryGateway.GetProductList();
        }
        //agent list
        public List<AgentModel> GetAgentList()
        {
            return inventoryGateway.GetAgentLists();
        }
        //product info 
        public ProductModel ProductInfo(ProductModel productModel)
        {
            return inventoryGateway.GetProductInfo(productModel);
        }
        //Agent info 
        public AgentModel AgentInfo(AgentModel agentModel)
        {
            return inventoryGateway.GetAgentInfo(agentModel);
        }

        //inventory details datagrid list 
        public List<InventoryDetailModel> GetInventoryDetailLists(int StoreId)
        {
            return inventoryGateway.FillInventoryDetailsGrid(StoreId);
        }

        //Delete Inventory
        public int DeleteInvetory(InventoryDetailModel inventoryDetailModel)
        {
            return inventoryGateway.DeleteInventoryDetails(inventoryDetailModel);
        }
        //add to inventory details grid viiew
        public int AddToInvetoryDetails(InventoryDetailModel inventoryDetailModel)
        {
            return inventoryGateway.AddToInventory(inventoryDetailModel);
        }

        //add to inventry grid view 
        public int Purchase(InventoryModel inventoryModel)
        {
            return inventoryGateway.AddToPurshase(inventoryModel);
        }


        //get inventory grid data
        public List<InventoryModel> getInventoryGrid()
        {
            return inventoryGateway.FillInventoryGrid();
        }
        // selected strore details view grid
        public List<InventoryDetailModel> GetInventoryDetailViewLists(InventoryModel inventoryModel)
        {
            return inventoryGateway.FillInventoryViewGrid(inventoryModel);
        }
        //product increase call 
        public int GetProductIncrease(InventoryDetailModel inventoryDetailModel)
        {
            return inventoryGateway.ProductIncrease(inventoryDetailModel);
        }
        //product Decrease call
        public int GetProductDecrease(InventoryDetailModel inventoryDetailModel)
        {
            return inventoryGateway.ProductDecrease(inventoryDetailModel);
        }
        //Inventory Decrease call
        public int InventoryDecreaseCall(InventoryDetailModel inventoryDetailModel)
        {
            return inventoryGateway.InventoryDecrease(inventoryDetailModel);
        }

    }
}
