using System.ComponentModel.DataAnnotations;

namespace ModelGundam
{
    public class Model
    {
        private int _modelID;

        public int ModelID
        {
            get { return _modelID; }
            set 
            {
                 if (value > 0)
                 {
                     _modelID = value;
                 }
                 else
                 {
                     throw new ValidationException("ModelID needs to be above 0");
                 }
            }
        }

        public string Name { get; set; }
        public int Armor { get; set; }
        public string Type { get; set;}
        public List<Ability> Abilities { get; set; }

        public Model()
        {
            ModelID = 1;
            Name = "DeathScythe";
            Type = "Neutral";
            Abilities = new List<Ability>();
        }
    }
}