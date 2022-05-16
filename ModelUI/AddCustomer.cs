
using ModelBL;
using ModelGundam;

namespace ModelUI
{
    public class AddCustomer : IMenu
    {
    private Customer customerobj = new Customer();
        
    private IModelBL _mobelBL;

    public AddCustomer(IModelBL m_modelBL)
    {
        _mobelBL = m_modelBL;
    }
        public void Display()
        {
            Console.WriteLine("Please enter the details for the following questions");
            Console.WriteLine("What is your name?");
            customerobj.Name = Console.ReadLine();
            Console.WriteLine("What is your address?");
            customerobj.Address = Console.ReadLine();
            Console.WriteLine("What is you phone number?");
            customerobj.Phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your email address?");
            customerobj.Email = Console.ReadLine();
            Console.WriteLine("[2] - Add a customer");
            Console.WriteLine("[3] - Search a customer");
            Console.WriteLine("[0] - Exit");
           
           try
           {
               customerobj.Phone = Convert.ToInt32(Console.ReadLine());
           }
           catch (System.Exception)
           {
               Console.WriteLine("Phone number must contain 10 digits!");
               
           }
           Console.WriteLine("[1] - Add a customer");
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
}