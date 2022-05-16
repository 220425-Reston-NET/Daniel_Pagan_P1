// See https://aka.ms/new-console-template for more information
using ModelGundam;
using ModelUI;

Console.WriteLine("Hello, World!");

Model modelobj = new Model();


modelobj.ModelID = 100;
Console.WriteLine(modelobj.ModelID);

Ability abil1 = new Ability();
abil1.Name = "Slash";
Ability abil2 = new Ability();
abil2.Name = "Missiles";

modelobj.Abilities.Add(abil1);
modelobj.Abilities.Add(abil2);

foreach (Ability item in modelobj.Abilities)
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