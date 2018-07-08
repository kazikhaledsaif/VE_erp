using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gateway;
using Model;

namespace Manager
{
    
    public class ExtraCostManager
    {
       
        ExtraCostGateway costGateway  = new ExtraCostGateway();
        //Get Extracost id
        public string GetExtraCostId()
        {

            String Id = costGateway.ExtraCostIdGenerate();
            return Id;
        }


        //Extracost Insert call
        public int ExtraCostInsert(ExtraCostModel extraCostModel)
        {

            int Isinsert = costGateway.ExtraCostInsert(extraCostModel);
            return Isinsert;
        }


        //Extracost list call
        public List<ExtraCostModel> GetExtraCostModels()
        {
            return costGateway.FillExtraCostGrid();
        }


        //Extracost update call

        public int ExtraCostUpdate(ExtraCostModel extraCostModel)
        {
            int IsUpdate = costGateway.UpdateExtraCost(extraCostModel);
            return IsUpdate;
        }

        //Extracost delete call 
        public int DeleteExtraCost(ExtraCostModel extraCostModel)
        {
            return costGateway.DeleteExtraCost(extraCostModel);
        }





    }
}
