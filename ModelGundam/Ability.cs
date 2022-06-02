namespace ModelGundam
{
    public class Ability
    {
        public int ID{ get; set; }
        public string Name{ get; set; }
        public string Type{ get; set; }
        public int Ammo{ get; set; }
        public int Armor{ get; set; }

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