using System;

class MyAge
{
    static void Main()
    {
        Console.Write("My age now is: ");
        int MyAge = int.Parse(Console.ReadLine());
        MyAge += 10;
        Console.WriteLine("My age after 10 years will be: "+MyAge);
    }
}

