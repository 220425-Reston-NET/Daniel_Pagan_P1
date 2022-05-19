using System.Text.Json;
using ModelGundam;

namespace ModelDL
{
    public class ModelRepository : IRepository<Model>
    {
        private static string _filepath = "../ModelDL/Data/Model.json";    
        public void Add(Model m_resource)
        {
            List<Model> listOfModel = GetAll();
            listOfModel.Add(m_resource);

            string jsonstring = JsonSerializer.Serialize(listOfModel, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonstring);
        }

        public List<Model> GetAll()
        {
            string jsonstring = File.ReadAllText(_filepath);
            List<Model> listOfModel = JsonSerializer.Deserialize<List<Model>>(jsonstring);

            return listOfModel;
        }

        public void Update(Model m_resource)
        {
            List<Model> listOfModel = GetAll();

            foreach (Model modelObj in listOfModel)
            {
                if (modelObj.Name == m_resource.Name)
                {
                    modelObj.Abilities = m_resource.Abilities;
                }
            }

            string jsonString = JsonSerializer.Serialize(listOfModel, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonString);
        }
    }

}
