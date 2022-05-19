
using ModelGundam;

namespace ModelUI
{
    public class MainMenu : IMenu
    {
        Model modelobj = new Model();
        public void Display()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What can I do for You?");
            Console.WriteLine("[1] - Add a new model");
            Console.WriteLine("[2] - Add a customer");
            Console.WriteLine("[3] - Search a customer");
            Console.WriteLine("[0] - Exit");
        }

        public string Yourchoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                return "AddModel";
            }
            else if (userInput == "2")
            {
                return "AddCustomer";
            }
            else if (userInput == "3")
            {
                return "SearchCustomer";
            }
            else if (userInput =="0")
            {
                return "Exit";
            }
            else
            {
                Console.WriteLine("Please input a valid response");
                return "MainMenu";
            }
        }
    }
}