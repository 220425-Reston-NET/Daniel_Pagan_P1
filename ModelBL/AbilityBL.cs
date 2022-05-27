
using ModelDL;
using ModelGundam;

namespace ModelBL
{
    public class AbilityBL : IAbilityBL
    {
        private IRepository<Ability> _abilityRepo;
        public AbilityBL(IRepository<Ability> m_abilityRepo)
        {
            _abilityRepo = m_abilityRepo;
        }
        public List<Ability> GetAllAbility()
        {
            return _abilityRepo.GetAll();
        }

        public Ability SearchAbilityByName(string m_abilityName)
        {
            List<Ability> currentListOfAbility = _abilityRepo.GetAll();
            foreach (Ability abilityObj in currentListOfAbility)
            {
                if (abilityObj.Name == m_abilityName)
                {
                    return abilityObj;                    
                }
            }

            return null;
        }

    }
}