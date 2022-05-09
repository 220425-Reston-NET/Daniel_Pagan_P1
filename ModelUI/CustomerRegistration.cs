using ModelDL;
using ModelGundam;

namespace ModelUI
{
    public class Registration : IMenu
    {
    private Customer customerobj = new Customer();
        

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
           
           try
           {
               customerobj.Phone = Convert.ToInt32(Console.ReadLine());
           }
           catch (System.Exception)
           {
               Console.WriteLine("Phone number must contain 10 digits!");
               
           }
        }

        public string Yourchoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "2")
            {
                Repository.AddCustomer(customerobj);
                return "AddCustomer";
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