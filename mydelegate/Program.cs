using System;

namespace mydelegate
{
    public delegate int Maths();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyMath mathObject = new MyMath(1,2);
            Maths myOperations;
            Maths af = new Maths(mathObject.Addition);
            Maths sf = new Maths(mathObject.Subtraction);
            Maths mf = new Maths(mathObject.Multiplication);
            Maths df = new Maths(mathObject.Division);
            myOperations = af;
            myOperations += sf;
            myOperations += mf;
            myOperations += df;

            System.Console.WriteLine(mathObject.result);
        }
    }
}
