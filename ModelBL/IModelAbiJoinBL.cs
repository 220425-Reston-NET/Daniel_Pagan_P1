namespace ModelBL
{
    public interface IModelAbiJoinBL
    {
        void GetAll(int m_modelID, int m_abilityID);
        void ReplenishAbilityAmmo(int  m_Ammo, int m_abilityID, int m_modelID);
        void ReplenishAbilityArmor(int m_Armor, int m_abilityID,int m_modelID);
    }    
}