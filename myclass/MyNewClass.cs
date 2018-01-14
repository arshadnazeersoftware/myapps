namespace OneClass
{
    public class MyNewClass
    {
        public int number { get; set; }
        public MyNewClass(int number)
        {
            this.number = number;
        }
        public int ThisIsMyNumber(int addOne = 1)
        {
            return number + addOne;
        }
    }
}