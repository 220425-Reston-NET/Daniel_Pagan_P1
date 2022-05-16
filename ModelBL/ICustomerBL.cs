using ModelGundam;

namespace ModelBL
{
    public class ICustomerBL
    {
        void AddCustomer(Customer c_customer);

        Customer SearchCustomerByName(string c_customer);
    }
}