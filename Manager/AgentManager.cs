using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gateway;
using Model;

namespace Manager
{
  public   class AgentManager
    {
        AgentGateway agentGateway = new AgentGateway();

        //Get agent id
        public string GetAgentId()
        {
           
            String Id = agentGateway.AgentIdGenerate();
            return Id;
        }


        //agent Insert call
        public int AgentInsert (AgentModel agentModel)
        {

            int Isinsert = agentGateway.AgentInsert(agentModel);
            return Isinsert;
        }


        //Agent list call
        public List<AgentModel> GetAgentModels()
        {
            return agentGateway.FillAgentGrid();
        }


        //agent update call

        public int AgentUpdate(AgentModel agentModel)
        {
            int IsUpdate = agentGateway.UpdateAgent(agentModel);
            return IsUpdate;
        }

        //agent delete call 
        public int DeleteAgent(AgentModel agentModel)
        {
            return agentGateway.DeleteAgent(agentModel);
        }





    }
}
