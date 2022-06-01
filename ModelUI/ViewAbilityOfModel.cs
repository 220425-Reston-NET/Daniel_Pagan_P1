using ModelGundam;

namespace ModelUI
{
    public class ViewAbilityOfModel : IMenu
    {
        private IModelAbiJoin _modelAbiBL;
        public ViewAbilityOfModel(IModelAbiJoin m_modelAbiBL)
        {
            _modelAbiBL = m_modelAbiBL;
        }
        public void Display()
        {
           Console.WriteLine("===Current Ability of Model===");
           foreach (Ability abilityObj in SearchModel.foundedModel.Abilities)
           {
               Console.WriteLine(abilityObj);
           }
           Console.WriteLine("[1] - Replenish Ammo of a model");
           Console.WriteLine("[2] - Replenish armor of a model");
           Console.WriteLine("[0] - Go Back");
        }

        public string Yourchoice()
        {
            string userInput = Console.ReadLine();

            if (userInput == "0")
            {
                return "SearchModel";
            }
            else if (userInput == "1")
            {
                Console.WriteLine("Enter the ID of the ability you want to replenish");
                int abitilyID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much ammo do you want to add to this ability?");
                int Ammo = Convert.ToInt32(Console.ReadLine());

                _modelAbiBL.ReplenishAbilityAmmo(Ammo, abilityID, SearchModel.foundedModel.ModelID);

                Console.WriteLine("Successfully updated the Ammo");
                Console.ReadLine();

                return "SearchModel";
            }
            else if (userInput == "2")
            {
                Console.WriteLine("How much armor do you want to add to this ability?");
                int abilityID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Successfully updated the Armor");
                Console.ReadLine();

                return "SearchModel";
            }
            else
            {
                return "MainMenu";
            }
        }
    }
}