using System;

namespace extensionmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation myOperation = new MathOperation();
            Console.WriteLine("Hello World!");
            System.Console.WriteLine("The addition of 1 and 2 is: " +myOperation.Addition(1,2));
            System.Console.WriteLine("The subtraction of 1 and 2 is: "+myOperation.Subtraction(1,2));
        }
    }
}
