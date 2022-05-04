namespace ModelUI
{
    public class MainMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the Main Menu!");
            Console.WriteLine("What can I do for You?");
            Console.WriteLine("[1] - Add a new model");
            Console.WriteLine("[0] - Exit");
        }

        public string Yourchoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Clear();
                Model modelobj = new Model();
            }
        }
    }
}