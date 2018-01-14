namespace simpledelegate
{
    public delegate int Operation(int number1, int number2);
    public class MyDelegate
    {
        int i;
        string[] operationarray = new string[4];
        public MyDelegate()
        {
            operationarray[0] = myoperations.addition.ToString();
            operationarray[1] = myoperations.subtraction.ToString();
            operationarray[2] = myoperations.multiplication.ToString();
            operationarray[3] = myoperations.division.ToString();
        }
        public static int addition(int number1, int number2)
        {
            return number1 + number2;
        }

        Operation del = new Operation(addition);
    }
}