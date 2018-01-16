using System;

namespace NewClass
{
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Constructor\n");
        }
        
        ~MyClass()
        {
            Console.WriteLine("Destructor\n");
        }
        public void MyNewMethod()
        {
            Console.WriteLine("Executing MyNewMethod()\n");
        }
    }
}