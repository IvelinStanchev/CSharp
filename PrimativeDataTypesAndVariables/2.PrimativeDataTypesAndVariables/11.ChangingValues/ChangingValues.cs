using System;

class ChangingValues
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstValue = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondValue = int.Parse(Console.ReadLine());
        Console.WriteLine(new string(' ',50));
        Console.WriteLine(new string('*',50));
        Console.WriteLine(new string(' ',50));
        Console.WriteLine("First number: {0}", firstValue);
        Console.WriteLine("Second number: {0}", secondValue);
        int thirdValue;
        thirdValue = firstValue;
        firstValue = secondValue;
        secondValue = thirdValue;
        Console.WriteLine(new string(' ',50));
        Console.WriteLine(new string(' ',50));
        Console.WriteLine("After exchanging, the values are: ");
        Console.WriteLine(new string(' ',50));
        Console.WriteLine("First number: {0}", firstValue);
        Console.WriteLine("Second number: {0}", secondValue);
    }
}

