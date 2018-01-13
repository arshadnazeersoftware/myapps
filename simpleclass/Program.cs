using System;

namespace simpleclass
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Number(5);
            Console.WriteLine(obj.ThisNumber());
            Console.WriteLine("Hello World!");
        }
    }
}
