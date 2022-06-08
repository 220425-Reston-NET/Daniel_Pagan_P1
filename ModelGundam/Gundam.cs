namespace ModelGundam
{
    public class Gundam
    {
        public int gId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public Gundam()
        {
            gId = 0;
            Name = "Default";
            Quantity = 0;
        }
    }
}