using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class RandomNumbersGenerator
{
    static void Main()
    {
        Random rnd = new Random();
        int randomNumbersGenerator;
        ConsoleKeyInfo userInput = Console.ReadKey();
        for (int i = 0; i < int.MaxValue; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            randomNumbersGenerator = rnd.Next(int.MaxValue);
            Console.WriteLine(randomNumbersGenerator);
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
        }    
    }
}

