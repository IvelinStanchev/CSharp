using System;

class FloatOrDouble
{
    static void Main()
    {
        double number1 = 34.567839023;
        float number2 = 12.345f;
        double number3 = 8923.1234857;
        float number4 = 3456.091f;
        Console.WriteLine("The appropriate type for {0} is: double", number1);
        Console.WriteLine("The appropriate type for {0} is: float", number2);
        Console.WriteLine("The appropriate type for {0} is: double", number3);
        Console.WriteLine("The appropriate type for {0} is: float", number4);
    }
}

