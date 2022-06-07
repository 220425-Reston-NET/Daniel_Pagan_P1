using ModelDL;
using ModelGundam;

namespace ModelBL
{
    public class ModelAbiJoinBL : IModelAbiJoinBL
    {
        private IRepository<ModelAbiJoin> _modelAbiRepo;
        public ModelAbiJoinBL(IRepository<ModelAbiJoin> m_modelAbiRepo)
        {
            _modelAbiRepo = m_modelAbiRepo;
        }

        public void GetAll(int m_modelID, int m_abilityID)
        {
           ModelAbiJoin joinTable = new ModelAbiJoin();
           joinTable.abilityID = m_abilityID;
           joinTable.modelID = m_modelID;

           _modelAbiRepo.Update(joinTable);
        }

        public void ReplenishAbilityAmmo(int m_Ammo, int m_abilityID, int m_modelID)
        {
            ModelAbiJoin joinTable = new ModelAbiJoin();
            joinTable.abilityID = m_abilityID;
            joinTable.Ammo = m_Ammo;
            
            _modelAbiRepo.Update(joinTable);
        }

        public void ReplenishAbilityArmor(int m_Armor, int m_abilityID, int m_modelID)
        {
            ModelAbiJoin joinTable = new ModelAbiJoin();
            joinTable.abilityID = m_abilityID;
            joinTable.Armor = m_Armor;

            _modelAbiRepo.Update(joinTable);
        }
    }

}