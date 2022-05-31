using ModelDL;
using ModelGundam;

namespace ModelBL
{
    public class CustomersModelsJoinBL : ICustomersModelsJoinBL
    {
        private IRepository<CustomersModelsJoin> _customersModelsRepo;
        public CustomersModelsJoinBL(IRepository<CustomersModelsJoin> c_customersModelsRepo)
        {
            _customersModelsRepo = c_customersModelsRepo;
        }

        public void GetAll(int c_customerID, int m_modelID)
        {
            CustomersModelsJoin joinTable = new CustomersModelsJoin();
            joinTable.customerID = c_customerID;
            joinTable.modelID = m_modelID;

            _customersModelsRepo.Update(joinTable);
        }
    }
}