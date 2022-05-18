
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
                // Console.Clear();
                // Console.WriteLine("What is the name of the model?");
                // modelobj.Name = Console.ReadLine();
                // Console.WriteLine("What is the type of model?");
                // modelobj.Type = Console.ReadLine();
                // Console.WriteLine("What is the model ID?");
                // modelobj.ModelID = Convert.ToInt32(Console.ReadLine());

                //Repository.AddModel(modelobj);
                return "AddModel";
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