namespace constructorchaining
{
    public class chain
    {
        public int rollnumber { get; set; } 
        public string name { get; set; }
        public string location { get; set; }
        public chain()
        {
            
        }
        public chain(string name)
        {
            this.name = name;

        }
        public chain(int rollnumber, string name):this(name)
        {
            this.rollnumber = rollnumber;
        }
        public chain(int rollnumber, string name, string location)
        :this(rollnumber,name)
        {
            this.location = location;
        }
        public chain MyData(int rollnumber, string name, string location)
        {
            return new chain(rollnumber, name, location);
        }
    }
}