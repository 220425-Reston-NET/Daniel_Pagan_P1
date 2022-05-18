// See https://aka.ms/new-console-template for more information
using ModelGundam;
using ModelUI;

Console.WriteLine("Hello, World!");

Model modelObj = new Model();


modelObj.ModelID = 100;
Console.WriteLine(modelObj.ModelID);

Ability abil1 = new Ability();
abil1.Name = "Slash";
Ability abil2 = new Ability();
abil2.Name = "Missiles";

modelObj.Abilities.Add(abil1);
modelObj.Abilities.Add(abil2);

foreach (Ability item in modelObj.Abilities)
{
    Console.WriteLine(item.Name);
}

MainMenu menu = new MainMenu();
bool repeat = true;

while (repeat)
{
    menu.Display();
    string ans = menu.Yourchoice();

    if (ans == "MainMenu")
    {
        
    }
    else if (ans == "AddModel")
    {
        
    }
    else if (ans == "Exit")
    {
        repeat = false;
    }
   
}