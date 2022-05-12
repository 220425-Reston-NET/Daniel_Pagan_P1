
using ModelBL;
using ModelGundam;

public class SearchCustomer : IMenu
{
    private IModelBL _modelBL;
    public SearchCustomer(IModelBL m_modelBL)
    {
        _modelBL = m_modelBL;
    }

    public void Display()
    {
        Console.WriteLine("How would you like to search for a customer?");
        Console.WriteLine("[1] - Search by Name");
        Console.WriteLine("[2] - Search by address");
        Console.WriteLine("[3] - Search by Phone number");
        Console.WriteLine("[4] - Search by email");
        Console.WriteLine("[0] - Exit");
    }

    public string Yourchoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            return "MainMenu";
        }
        else if (userInput == "2")
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
        else if (userInput == "3")
        {
            return "MainMenu";
        }
        else if (userInput == "4")
        {
            return "MainMenu";
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