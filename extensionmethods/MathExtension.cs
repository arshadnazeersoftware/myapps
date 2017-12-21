using System;

namespace extensionmethods
{
    public static class MathExtension
    {
        public static int Subtraction(this MathOperation obj, int firstnumber, int secondnumber)
        {
            return firstnumber - secondnumber;        
        }
    }
}