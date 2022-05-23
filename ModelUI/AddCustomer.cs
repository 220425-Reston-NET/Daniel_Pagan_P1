
using ModelBL;
using ModelGundam;
using Serilog;

public class AddCustomer : IMenu
{
    private Customer customerobj = new Customer();

    private ICustomerBL _mobelBL;

    public AddCustomer(ICustomerBL c_customerBL)
    {
        _mobelBL = c_customerBL;
    }
    public void Display()
    {
        Console.WriteLine("Please enter the details for the following questions");
        Console.WriteLine("What is your name?");
        customerobj.Name = Console.ReadLine();
        Console.WriteLine("What is your address?");
        customerobj.Address = Console.ReadLine();
        Console.WriteLine("What is you phone number?");
        customerobj.Phone = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What is your email address?");
        customerobj.Email = Console.ReadLine();
        
        // try
        // {
        //     customerobj.Phone = Convert.ToDouble(Console.ReadLine());
        // }
        // catch (System.Exception)
        // {
        //     Console.WriteLine("Phone number must contain 10 digits!");

        // }
        Console.WriteLine("[1] - Add a customer");
        Console.WriteLine("[2] - Search a customer");
        Console.WriteLine("[0] - Exit");
    }

    public string Yourchoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            //Repository.AddCustomer(customerobj);
            try
            {
                _mobelBL.AddCustomer(customerobj);

            }
            catch (System.Exception)
            {
                Log.Warning("Customer name already exist!");
                Log.Information(customerobj.ToString());
                Console.WriteLine("Customer name already exist!");
                Console.ReadLine();
            }

            return "MainMenu";
        }
        else if (userInput == "2")
        {
            return "SearchCustomer";
        }
        else if (userInput == "0")
        {
            return "Exit";
        }
        else
        {
            Console.WriteLine("Please enter a valid response");
            return "AddCustomer";
        }
    }
}
