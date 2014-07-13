/*Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm 
 (find it in Internet).*/
using System;

class TheGreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int maxCommonDivisor = 1;
        int firstCounter = 0;
        int secondCounter = 0;

        int[] firstMaxDivisor = new int[firstNumber];
        int[] secondMaxDivisor = new int[secondNumber];

        int[] firstPositionCounter = new int[firstNumber];
        int[] secondPositionCounter = new int[secondNumber];

        int[] firstNumberInPosition = new int[firstNumber];
        int[] secondNumberInPosition = new int[secondNumber];

        bool checking = false;

        Console.WriteLine();

        Console.Write("The numbers in color ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("magenta ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("are the common divisors of the numbers");

        Console.WriteLine();

        for (int i = 1; i < firstNumber; i++)//Finding the divisors of the first number
        {
            if (firstNumber % i == 0)
            {
                firstMaxDivisor[firstCounter] = i;
                firstCounter++;
            }
        }

        for (int h = 1; h < secondNumber; h++)//Finding the divisors of the second number
        {
            if (secondNumber % h == 0)
            {
                secondMaxDivisor[secondCounter] = h;
                secondCounter++;
            }
        }

        for (int j = 0; j < firstCounter + 1; j++)//Position and number at position for the first member
        {
            for (int l = 0; l < secondCounter + 1; l++)
            {
                if (firstMaxDivisor[j] == secondMaxDivisor[l])
                {
                    firstPositionCounter[j] = j;
                    firstNumberInPosition[j] = firstMaxDivisor[j];
                }
                if (firstMaxDivisor[j] == secondNumber)
                {
                    firstPositionCounter[j] = j;
                    firstNumberInPosition[j] = secondNumber;
                }
            }
        }

        for (int u = 0; u < secondCounter + 1; u++)//Position and number at position for the second number
        {
            for (int g = 0; g < firstCounter + 1; g++)
            {
                if (secondMaxDivisor[u] == firstMaxDivisor[g])
                {
                    secondPositionCounter[u] = u;
                    secondNumberInPosition[u] = secondMaxDivisor[u];
                }
            }
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Divisors of first number: ");
        Console.ForegroundColor = ConsoleColor.Gray;

        for (int f = 0; f < firstCounter; f++)//Now with these sequence of code rows I find if there are common divisors and if yes I color them in magenta
        {
            if (firstPositionCounter[f] == f)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(firstNumberInPosition[f] + " ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(firstMaxDivisor[f] + " ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        if (firstNumber == secondNumber)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(firstNumber);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(firstNumber);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Divisors of second number: ");
        Console.ForegroundColor = ConsoleColor.Gray;

        for (int a = 0; a < secondCounter; a++)
        {
            if (secondPositionCounter[a] == a)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(secondNumberInPosition[a] + " ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(secondMaxDivisor[a] + " ");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        for (int n = 0; n < firstCounter; n++)
        {
            if (secondNumber == firstMaxDivisor[n])
            {
                checking = true;
            }
        }
        if (secondNumber == firstNumber)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(secondNumber);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else if (checking == true)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(secondNumber);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(secondNumber);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        for (int k = 1; k < firstNumber; k++)//Finding the greatest common divisor
        {
            if ((firstNumber % k == 0) && (secondNumber % k == 0))
            {
                maxCommonDivisor = k;
            }
        }
        if (firstNumber == secondNumber)
        {
            Console.WriteLine();
            Console.Write("The greatest common divisor of the numbers {0}, {1} is: ", firstNumber, secondNumber);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(firstNumber);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        else
        {
            Console.WriteLine();
            Console.Write("The greatest common divisor of the numbers {0}, {1} is: ", firstNumber, secondNumber);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(maxCommonDivisor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

