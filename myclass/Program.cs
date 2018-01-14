using System;
using OneClass;

namespace myclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyNewClass plusOne = new MyNewClass(4);
            Console.WriteLine("My number is: {0}",plusOne.ThisIsMyNumber());
        }
    }
}
