using System;
using System.Numerics;

class FactorialWithRecursion
{
    static BigInteger Recursion(int number)
    {
        if (number == 1)
        {
            return 1;
        }
        else
        {
            return number * Recursion(number - 1);
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Recursion(n));
    }
}
