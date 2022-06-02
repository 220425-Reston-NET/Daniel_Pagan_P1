using ModelDL;
using ModelGundam;

namespace ModelBL
{
    public class ModelAbiJoinBL : IModelAbiJoinBL
    {
        private IRepository<ModelAbilityJoin> _modelAbiRepo;
        public ModelAbiJoinBL(IRepository<ModelAbilityJoin> m_modelAbiRepo)
        {
            _modelAbiRepo = m_modelAbiRepo;
        }
        public void ReplenishAbilityAmmo(int m_Ammo, int m_abilityID, int m_modelID)
        {
            ModelAbilityJoin joinTable = new ModelAbilityJoin();
            joinTable.abilityID = m_abilityID;
            joinTable.Ammo = m_Ammo;
            
            _modelAbiRepo.Update(joinTable);
        }

        public void ReplenishAbilityArmor(int m_Armor, int m_abilityID, int m_modelID)
        {
            ModelAbilityJoin joinTable = new ModelAbilityJoin();
            joinTable.abilityID = m_abilityID;
            joinTable.Armor = m_Armor;

            _modelAbiRepo.Update(joinTable);
        }
    }

}