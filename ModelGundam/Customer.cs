namespace ModelGundam
{
    public class Customer
    {
        private string _name;
        public string Name
        {
            get{ return _name; }
            set{ _name = value; }  
        } 

        private string _address;
        public string Address
        {
            get{ return _address; }
            set{ _address = value; }
        }
        
        private int _phonenumber;
        public int Phone
        {
            get { return _phonenumber; }
            set { _phonenumber = value; }
        }
        
        private string _email;
        public string Email
        {
            get{ return _email; }
            set{ _email = value; }
        }
        
    
    }


}