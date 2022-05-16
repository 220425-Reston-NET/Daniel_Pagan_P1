

using ModelDL;
using ModelGundam;

namespace ModelBL
{
    public class ModelBusinessLayer : IModelBL
    {
        private IRepository<Model> _modelRepo;
        public ModelBusinessLayer(IRepository<Model> m_modelRepo)
        {
            _modelRepo = m_modelRepo;
        }
        
        public void AddAbilityToModel(Model m_model)
        {
            _modelRepo.Update(m_model);
        }

        public void AddModel(Model m_model)
        {
            Random rand = new Random();
            m_model.Armor = rand.Next(50);
            
            Model foundedmodel = SearchModelByName(m_model);
            if (foundedmodel == null)
            {
                _modelRepo.Add(m_model);
            }
            else
            {
                throw new Exception("Model name already exist");
            }
        }

        public Model SearchModelByName(string m_model)
        {
            List<Model> currentListOfModel = _modelRepo.GetAll();
            foreach (Model modelObj in currentListOfModel)
            {
                if (modelObj.Name == m_modelName)
                {
                    return modelObj;
                }
            }

            return null;            
        }
    }
}