using System;

class NullValues
{
    static void Main()
    {
        int? firstValue = null;
        double? secondValue = null;
        Console.WriteLine("Int variable as null - > {0}\nDouble variable as null - > {1}", firstValue, secondValue);
        Console.WriteLine(new string(' ',50));
        firstValue += 10;
        secondValue += 10;
        Console.WriteLine("After adding a value to null: ");
        Console.WriteLine("Int variable - > {0}\nDouble variable - > {1}", firstValue, secondValue);
    }
}

