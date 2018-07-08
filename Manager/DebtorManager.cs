using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gateway;
using Model;

namespace Manager
{
    public class DebtorManager
    {
       DebtorGateway debtorGateway = new DebtorGateway();

        // Get debtor Grid View list
        public List<DebtorModel> GetDebtorGridList()
        {
            return debtorGateway.FillDebtorGrid();
        }

        public int UpdateDebtor(DebtorModel debtorModel)
        {
            return debtorGateway.UpdateDebtor(debtorModel);
        }

        public int DeleteDebtor(DebtorModel debtorModel)
        {
            return debtorGateway.DeleteDebtor(debtorModel);
        }

        public int InsertDebtor(DebtorModel debtorModel)
        {
            return debtorGateway.DebtorInsert(debtorModel);
        }













    }
}
