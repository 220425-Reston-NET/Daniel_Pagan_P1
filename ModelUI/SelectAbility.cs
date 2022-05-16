using ModelBL;
using ModelGundam;

namespace PokeUI
{
    public class SelectAbility : IMenu
    {
        private IAbilityBL _abilityBL;
        private IModelBL _modelBL;
        public SelectAbility(IAbilityBL m_abilityBL, IModelBL m_modelBL)
        {
            _abilityBL = m_abilityBL;
            _modelBL = m_modelBL;
        }

        public void Display()
        {
           List<Ability> listOfAbility = _abilityBL.GetAllAbility();
           foreach (Ability abilityObj in listOfAbility)
           {
               Console.WriteLine(abilityObj.Name);
           }
        }

        public string Yourchoice()
        {
            Console.WriteLine("Give me the ability name listed above to choose an ability?");
            string userInput = Console.ReadLine();

            Ability foundedAbility = _abilityBL.SearchAbilityByName(userInput);

            if (foundedAbility != null)
            {
                SearchModel.foundedModel.Abilities.Add(foundedAbility);
                _modelBL.AddAbilityToModel(SearchModel.foundedModel);
                Console.WriteLine("Successfully added ability!");
            }
            else
            {
                Console.WriteLine("Ability was unable to be found! Please enter the exact name (case sensitive)");
                Console.ReadLine();
                return "SelectAbility";
            }

            Console.ReadLine();
            return "MainMenu";
        }
    }
}