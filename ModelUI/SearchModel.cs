

using ModelBL;
using ModelGundam;

public class SearchModel : IMenu
{
    public static Model foundedModel;
    private IModelBL _modelBL;
    public SearchModel(IModelBL m_modelBL)
    {
        _modelBL = m_modelBL;
    }
    public void Display()
    {
        Console.WriteLine("How would you like to search your model?");
        Console.WriteLine("[1] - Search by ModelID");
        Console.WriteLine("[2] - Search by Name");
        Console.WriteLine("[3] - Search by Type");
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
            Console.WriteLine("Enter a model name: ");
            string modelName = Console.ReadLine();

            foundedModel = _modelBL.SearchModelByName(modelName);

            if (foundedModel == null)
            {
                Console.WriteLine("Model was not found!");
            }
            else
            {
                Console.WriteLine(foundedModel.ToString());

                Console.WriteLine("Do you want to add an ability to this model? (Y - Yes, N - No)");
                string addModelChoice = Console.ReadLine();
                if (addModelChoice == "Y")
                {
                    return "SelectAbility";
                }
                else
                {
                    return "SearchModel";
                }
            }

            Console.ReadLine();
            return "SearchModel";
        }
        else if (userInput == "3")
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
            return "SearchModel";
        }
    }
}