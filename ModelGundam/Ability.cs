namespace ModelGundam
{
    public class Ability
    {
        public string Name{ get; set; }

        private int _abilityID;
        public int abilityID
        {
            get { return _abilityID; }
            set
            {
                if (value > 0)
                {
                    _abilityID = value;
                }
                else
                {
                    Console.WriteLine("Ability cannot be negative");
                }
            }
        }
        
    }
}