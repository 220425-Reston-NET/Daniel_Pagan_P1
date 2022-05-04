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
                     Console.WriteLine("Model ID can only hold positive numbers! { value > 0 }");
                 }
            }
        }

        public string Name { get; set; }

        public List<Models> models { get; set; }

        public Model()
        {
            ModelID = 1;
            Name = "DeathScythe";
            models = new List<Models>();
        }
    }
}