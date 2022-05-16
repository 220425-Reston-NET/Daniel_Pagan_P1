using System.Text.Json;
using ModelDL;
using ModelGundam;

namespace PokeDL
{
    public class AbilityRepository : IRepository<Ability>
    {
        private string _filepath = "../ModelDL/Data/Ability.json";
        public void Add(Ability m_resource)
        {
            throw new NotImplementedException();
        }

        public List<Ability> GetAll()
        {
            string jsonString = File.ReadAllText(_filepath);
            List<Ability> listOfAbility = JsonSerializer.Deserialize<List<Ability>>(jsonString);

            return listOfAbility;
        }

        public void Update(Ability m_resource)
        {
            throw new NotImplementedException();
        }
    }
}