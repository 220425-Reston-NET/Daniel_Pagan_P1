using ModelGundam;

namespace ModelBL
{
    public interface IModelBL
    {
        void AddCustomer(Customer c_customer);

        Customer SearchCustomerByName(string c_customer);
    }
}
