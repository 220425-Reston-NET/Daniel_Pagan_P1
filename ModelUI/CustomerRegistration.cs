namespace ModelUI
{
    public class Registration : IMenu
    {
        private Customer regObj = new Customer();

        public void Display()
        {
            Console.WriteLine("Please enter the details for the following questions");
            Console.WriteLine("What is your name?");
            regObj.Name = Console.ReadLine();
            Console.WriteLine("What is your address?");
            regObj.Address = Console.ReadLine();
            Console.WriteLine("What is you phone number?");
            regObj.Phone = Console.ReadLine();
           
        }

        public string Yourchoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                return "MainMenu";
            }
        }
    }
}