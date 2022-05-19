using ModelDL;
using ModelGundam;

namespace ModelBL
{
    public class CustomerBL : ICustomerBL
    {
        private IRepository<Customer> _customRepo;
        public CustomerBL(IRepository<Customer> c_customRepo)
        {
            _customRepo = c_customRepo;
        }
         public void AddCustomer(Customer c_customer)
        {
            Customer foundedcustomer = SearchCustomerByName(c_customer.Name);
            if (foundedcustomer == null)
            {
                _customRepo.Add(c_customer);
            }
            else
            {
                throw new Exception("Customer name already exist");
            }
        }
        public Customer SearchCustomerByName(string c_customerName)
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

        public Customer SearchCustomerByPhone(string c_customer)
        {
            throw new NotImplementedException();
        }
               
        public Customer SearchCustomerByEmail(string c_customer)
        {
            throw new NotImplementedException();
        }

        public Customer SearchCustomerByEmail(object customerEmail)
        {
            throw new NotImplementedException();
        }
    }
}