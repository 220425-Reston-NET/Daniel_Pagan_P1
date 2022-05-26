// See https://aka.ms/new-console-template for more information
global using Serilog;
using Microsoft.Extensions.Configuration;
using ModelBL;
using ModelDL;
using ModelGundam;
using ModelUI;
using PokeDL;
using PokeUI;


//Initialize my logger
Log.Logger = new LoggerConfiguration() //LoggerConfiguration used to configure your logger and create it
    .WriteTo.File("./Logs/User.txt") //Configureing the logger to save information to a file called User.txt iside of the Logs folder
    .CreateLogger(); //A method to create the logger

//Initializing my configuration object
var configuration = new ConfigurationBuilder() //Builder class used to create my configuration object
    .SetBasePath(Directory.GetCurrentDirectory()) //Sets the base path to the current directory
    .AddJsonFile("appsettings.json") //Grabs the specific json file on where the information is from
    .Build(); //Creates the object

// Console.WriteLine("Hello, World!");

Model modelObj = new Model();


// modelObj.ModelID = 100;
// Console.WriteLine(modelObj.ModelID);

// Ability abil1 = new Ability();
// abil1.Name = "Slash";
// Ability abil2 = new Ability();
// abil2.Name = "Missiles";

// modelObj.Abilities.Add(abil1);
// modelObj.Abilities.Add(abil2);

// foreach (Ability item in modelObj.Abilities)
// {
//     Console.WriteLine(item.Name);
// }

IMenu menu = new MainMenu();
bool repeat = true;

while (repeat)
{
    menu.Display();
    string ans = menu.Yourchoice();

    if (ans == "MainMenu")
    {
        Log.Information("User going to MainMenu");
        menu = new MainMenu();
    }
    else if (ans == "AddModel")
    {
        Log.Information("User going to AddModel Menu");
        menu = new AddModel(new ModelBusinessLayer(new ModelRepository()));
    }
    else if (ans == "SelectAbility")
    {
        Log.Information("User going to SelectAbility Menu");
        menu = new SelectAbility(new AbilityBL(new AbilityRepository()), new ModelBusinessLayer(new ModelRepository()));
    }
    else if (ans == "AddCustomer")
    {
        Log.Information("User is adding a customer");
        menu = new AddCustomer(new CustomerBL(new SQLCustomerRepository(configuration.GetConnectionString("Daniel Pagan"))));
    }
    else if (ans == "SearchCustomer")
    {
        Log.Information("User is searching a cutomer");
    menu = new SearchCustomer(new CustomerBL(new SQLCustomerRepository(configuration.GetConnectionString("Daniel Pagan"))));
    }
    else if (ans == "Exit")
    {
        repeat = false;
    }
   
}