namespace ModelGundam
{
    public class Store
    {
        public int sId { get; set; }
        public string Name { get; set; }
        public List<Gundam> Gundams { get; set; }
        public Store()
        {
            sId = 0;
            Name = "Default";
            Gundams = new List<Gundam>();
        }
    }
}