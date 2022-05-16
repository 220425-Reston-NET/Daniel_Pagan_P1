using ModelGundam;

namespace ModelBL
{
    public interface IAbilityBL
    {
        List<Ability> GetAllAbility();

        Ability SearchAbilityByName(string m_abilityName);
    }
}