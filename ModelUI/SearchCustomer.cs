
using ModelBL;
using ModelGundam;

public class SearchCustomer : IMenu
{
    public static Customer foundedcustomer;
    private ICustomerBL _modelBL;
    public SearchCustomer(ICustomerBL m_modelBL)
    {
        _modelBL = m_modelBL;
    }

    public void Display()
    {
        Console.WriteLine("How would you like to search for a customer?");
        Console.WriteLine("[1] - Search by Name");
        Console.WriteLine("[2] - Search by Phone number");
        Console.WriteLine("[3] - Search by Email");
        Console.WriteLine("[0] - Exit");
    }

    public string Yourchoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            Console.WriteLine("Enter customer name: ");
            string customerName = Console.ReadLine();

            Customer foundedCustomer = _modelBL.SearchCustomerByName(customerName);

            if (foundedCustomer == null)
            {
                Console.WriteLine("Customer was not found!");
            }
            else
            {
                Console.WriteLine("===Customer Info===");
                Console.WriteLine("Name: " + foundedCustomer.Name);
                Console.WriteLine("Address: " + foundedCustomer.Address);
                Console.WriteLine("Phone: " + foundedCustomer.Phone);
                Console.WriteLine("Email: " + foundedCustomer.Email);
                Console.WriteLine("=============");
            }

            Console.ReadLine();

            return "SearchCustomer";
            
        }
        else if (userInput == "2")
        {
            Console.WriteLine("Enter customer phone number");
            string customerPhone = Console.ReadLine();

            Customer foundedCustomer = _modelBL.SearchCustomerByPhone(customerPhone);
            if (foundedCustomer == null)
            {
                Console.WriteLine("Customer was not found!");
            }
            else
            {
                Console.WriteLine("===Customer Info===");
                Console.WriteLine("Name: " + foundedCustomer.Name);
                Console.WriteLine("Address: " + foundedCustomer.Address);
                Console.WriteLine("Phone: " + foundedCustomer.Phone);
                Console.WriteLine("Email: " + foundedCustomer.Email);
                Console.WriteLine("=============");
            }

            Console.ReadLine();

            return "SearchCustomer";
        }
        else if (userInput == "3")
        {
            return "SearchCustomer";
        }
        else if (userInput == "0")
        {
            return "MainMenu";
        }
        else
        {
            Console.WriteLine("Please enter a valid response");
            return "SearchCustomer";
        }
    }
}