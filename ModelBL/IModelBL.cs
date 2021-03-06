using ModelGundam;

namespace ModelBL
{
    public interface IModelBL
    {     
        void AddModel(Model m_model);

        Model SearchModelByName(string m_model);
        
        void AddAbilityToModel(Model m_model);
        List<Model> GetAllModel();
        Model SearchModelByID(int m_modelID);
    }
}
