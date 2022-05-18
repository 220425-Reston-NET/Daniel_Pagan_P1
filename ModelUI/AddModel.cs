using ModelBL;
using ModelGundam;

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
            
            Console.WriteLine("ModelID cannot be negative!");
            modelObj.ModelID = 1;
        }
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
                
                Console.WriteLine("Model name already exists!");
                Console.ReadLine();
            }

            return "MainMenu";
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