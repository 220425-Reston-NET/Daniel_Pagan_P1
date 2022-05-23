using ModelBL;
using ModelGundam;
using Serilog;

public class AddModel : IMenu
{
    private Model modelObj = new Model();
    private IModelBL _modelBL;
    public AddModel(IModelBL m_modelBL)
    {
        _modelBL = m_modelBL;
    }

    public void Display()
    {
        Console.WriteLine("Please enter the model details by following the questions");
        Console.WriteLine("What is the model name?");
        modelObj.Name = Console.ReadLine();
        Console.WriteLine("What is the model type?");
        modelObj.Type = Console.ReadLine();
        Console.WriteLine("What is the modelID");

        try
        {
            modelObj.ModelID = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.Exception)
        {
            
            Log.Warning("User tried to add a negative number!");
            Console.WriteLine("ModelID cannot be negative!");
            modelObj.ModelID = 1;
        }
        Console.WriteLine("[1] - Add a model");
        Console.WriteLine("[2] - Search a model");
        Console.WriteLine("[0] - Exit");
    }

    public string Yourchoice()
    {
        string userInput = Console.ReadLine();

        if (userInput == "1")
        {
            try
            {
                _modelBL.AddModel(modelObj);
            }
            catch (System.Exception)
            {
                Log.Warning("User tried to add a negative number!");
                Log.Information(modelObj.ToString());
                Console.WriteLine("Model name already exists!");
                Console.ReadLine();
            }
           
            return "MainMenu";
        }
        else if (userInput == "2")
        {
            return "SearchModel";
        }
        else if (userInput == "0")
        {
            return "Exit";
        }
        else
        {
            Console.WriteLine("Please enter a valid response");
            return "AddModel";
        }
    }

}