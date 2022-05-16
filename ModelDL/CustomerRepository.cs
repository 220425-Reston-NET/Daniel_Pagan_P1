using System.Text.Json;
using ModelGundam;

namespace ModelDL
{
    public class CustomerRepository
    {
         private static string _filepath = "../ModelDL/Data/Model.json";
        public static void AddCustomer(Customer c_customer)
        {
            List<Customer> listOfCustomer = GetAllCustomer();
            listOfCustomer.Add(c_customer);

            string jsonstring = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonstring);
        }


        private static List<Customer> GetAllCustomer()
        {
            string jsonstring = File.ReadAllText(_filepath);
            List<Customer> listOfCustomer = JsonSerializer.Deserialize<List<Customer>>(jsonstring);

            return listOfCustomer;
        }
    }
}