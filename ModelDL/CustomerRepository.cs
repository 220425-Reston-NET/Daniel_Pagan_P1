using System.Text.Json;
using ModelGundam;

namespace ModelDL
{
    public class CustomerRepository : IRepository<Customer>
    {
         private static string _filepath = "../ModelDL/Data/Customer.json";
        
        public void Add(Customer m_resource)
        {
            List<Customer> listOfCustomer = GetAll();
            listOfCustomer.Add(m_resource);

            string jsonstring = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonstring);
        }

        public List<Customer> GetAll()
        {
            string jsonstring = File.ReadAllText(_filepath);
            List<Customer> listOfCustomer = JsonSerializer.Deserialize<List<Customer>>(jsonstring);

            return listOfCustomer;
        }

        public void Update(Customer m_resource)
        {
            List<Customer> listOfCustomer = GetAll();

            foreach (Customer customerObj in listOfCustomer)
            {
                if (customerObj.Name == m_resource.Name)
                {
                    customerObj.Address = m_resource.Address;
                    customerObj.Phone = m_resource.Phone;
                    customerObj.Email = m_resource.Email;
                }
            }

            string jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }
    }
}