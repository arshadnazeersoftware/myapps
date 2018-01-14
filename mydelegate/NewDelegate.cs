namespace mydelegate
{
    public class MyMath
    {
        public int number1 { get; set; }    
        public int number2 { get; set; }
        public int result { get; set; }
        public MyMath(int number1, int number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public int Addition()
        {
            result = number1 + number2;
            return result;
        }
        public int Subtraction()
        {
            result = number1 - number2;
            return result;
        }
        public int Multiplication()
        {
            result = number1 * number2;
            return result;
        }
        public int Division()
        {
            result = number1/number2;
            return result;
        }
    }
}