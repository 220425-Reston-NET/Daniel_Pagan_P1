// using ModelDL;
// using ModelGundam;

// namespace ModelBL
// {
//     public class ModelAbiJoinBL : IModelAbiJoin
//     {
//         private IRepository<ModelAbilityJoin> _modelAbiRepo;
//         public ModelAbiJoinBL(IRepository<ModelAbilityJoin> m_modelAbiRepo)
//         {
//             _modelAbiRepo = m_modelAbiRepo;
//         }
//         public void ReplenishAbilityAmmo(int m_Ammo, int m_abilityID, int m_modelID)
//         {
//             ModelAbilityJoin joinTable = new ModelAbilityJoin();
//             joinTable.abilityID = m_abilityID;
//             joinTable.ammo = m_Ammo;
//             joinTable.armor = m_Armor;

//             _modelAbiRepo.Update(joinTable);
//         }
//     }

// }