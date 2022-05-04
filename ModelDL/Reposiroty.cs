using System.Text.Json;
using ModelGundam;

namespace ModelDL
{
    public class Repository
    {
        private static string _filepath = "../ModelDL/Data/Model.json";
        public static string AddModel(Model m_model)
        {
            List<Model> listOfModel = GetAllModel();
            listOfModel.Add(m_model);

            string jsonstring = JsonSerializer.Serialize(listOfModel, new JsonSerialierOptions{WriteIndented = true});
            File.WriteAllText(_filepath, jsonstring); 
        }

        public static List<Model> GetAllModel()
        {
            string jsonstring = _filepath.ReadAllText(_filepath);
            List<Model> listOfModel = JsonSerializer.Deserialize<list<Model>>(jsonstring);

            return listOfModel;
        }
    }

}
