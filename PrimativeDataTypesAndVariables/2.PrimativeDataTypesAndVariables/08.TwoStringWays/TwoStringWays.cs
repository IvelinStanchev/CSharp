using System;

class TwoStringWays
{
    static void Main()
    {
        Console.WriteLine("First way: ");
        string firstWay = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstWay);
        Console.WriteLine(new string(' ',50));
        Console.WriteLine(new string('*', 50));
        Console.WriteLine(new string(' ', 50));
        string secondWay = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("Second way: ");
        Console.WriteLine(secondWay);
    }
}

