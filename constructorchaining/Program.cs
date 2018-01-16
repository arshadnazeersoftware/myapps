using System;

namespace constructorchaining
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            chain obj = new chain(25,"mylocation","myplanet");
            Console.WriteLine(
                "Rollnumber:{0}, Name:{1}, Location:{2}",
                obj.rollnumber, obj.name,obj.location);
            var myobj = obj.MyData(10,"myworld","Earth");
            Console.WriteLine(
                "Rollnumber:{0}, Name:{1}, Location:{2}",
                myobj.rollnumber, myobj.name,myobj.location);
        }
    }
}
