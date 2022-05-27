namespace ModelBL
{
    public interface IModelAbiJoinBL
    {
        void ReplenishAbilityAmmo(int  m_Ammo, int m_abilityID, int m_modelID);
        void ReplenishAbilityArmor(int m_Armor, int m_abilityID,int m_modelID);
    }    
}