using System;

class NumbersRow
{
    static void Main()
    {
        for (int i = 2; i <= 15; i++)
        {
            if(i%2==0)
                Console.WriteLine(i);
            else
                Console.WriteLine(i*Math.Pow(-1,i));
        }
    }
}

