namespace ModelGundam
{
    public class Models
    {
        public string Name{ get; set; }

        private int _PP;
        public int PP
        {
            get { return _PP; }
            set
            {
                if (value > 0)
                {
                    _PP = value;
                }
                else
                {
                    Console.WriteLine("PowerPoint cannot be negative");
                }
            }
        }
        public int Power { get; set; }
    }
}