using ModelGundam;

namespace ModelBL
{
    public interface ICustomerBL
    {
        void AddCustomer(Customer c_customer);

        Customer SearchCustomerByName(string c_customer);
        Customer SearchCustomerByPhone(string c_customer);
        Customer SearchCustomerByEmail(string c_customer);
        Customer SearchCustomerByEmail(object customerEmail);
    }
}