using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gateway;
using Model;

namespace Manager
{
   public class CreditorManager
    {
        CreditorGateway creditorGateway = new CreditorGateway();
      
        // Get Creditor Grid View list
        public List<CreditorModel> GetCreditorGridList()
        {
            return creditorGateway.FillCreditorGrid();
        }

        public int UpdateCreditor(CreditorModel creditorModel)
        {
            return creditorGateway.UpdateCreditor(creditorModel);
        }

        public int DeleteCreditor(CreditorModel creditorModel)
        {
            return creditorGateway.DeleteCreditor(creditorModel);
        }

        public int InsertCreditor(CreditorModel creditorModel)
        {
            return creditorGateway.CreditorInsert(creditorModel);
        }

    }
}
