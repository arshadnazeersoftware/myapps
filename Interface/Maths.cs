namespace Interface
{
    public class Maths : IAddition, ISubtraction, IMultiplication, IDivision
    {
        public int number1 { get; set; }
        public int number2 { get; set; }
        public Maths()
        {
        }

        public int Addition(int number1, int number)
        {
            throw new System.NotImplementedException();
        }

        public int Division(int number1, int number2)
        {
            throw new System.NotImplementedException();
        }

        public int Multiplication(int number1, int number2)
        {
            throw new System.NotImplementedException();
        }

        public int Subtraction(int number1, int number2)
        {
            throw new System.NotImplementedException();
        }
    }
}