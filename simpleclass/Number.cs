namespace simpleclass
{
    public class Number
    {
        private int number { get; }
        public Number(int mynumber)
        {
            number = mynumber;
        }
        public int ThisNumber()
        {
            return number;
        }
    }
}