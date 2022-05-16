using ModelGundam;

namespace ModelBL
{
    public class CustomerBL : ICustomerBL
    {
        private CustomerRepository<Model> _customRepo;
        public CustomerBL(CustomerRepository<Model> c_customRepo)
        {
            _customRepo = c_customRepo;
        }
         public void AddCustomer(Customer c_customer)
        {
            throw new NotImplementedException();
        }

        public Customer SearchCustomerByName(string c_customer)
        {
           List<Customer> currentListOfCustomers = _customRepo.GetAll();

           foreach (Customer customerObj in currentListOfCustomers)
           {
               if (customerObj.Name == c_customerName)
               {
                    return customerObj;                   
               }
           }

           return null;
        }
    }
}