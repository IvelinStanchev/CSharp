/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0*/
using System;

class SolvingSeveralTasks
{
    static int ChoosingWhichTaskToSolve()
    {
        Console.WriteLine("Please choose what task to solve (1, 2, or 3): ");
        Console.WriteLine("1 - Reversing digits of a number");
        Console.WriteLine("2 - Calculating the average of a sequence of integers");
        Console.WriteLine("3 - Solving a linear equation (a * x + b = 0)");
        Console.WriteLine();
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int EnteringTheNumberForReversing()
    {
        int number = int.Parse(Console.ReadLine());

        while (true)
        {
            if (number > 0)
            {
                return number;
            }
            else
            {
                number = int.Parse(Console.ReadLine());
            }
        }
    }

    static int EnteringTheLengthOfASequenceOfIntegers()
    {
        Console.Write("How many numbers will have the sequence?: ");
        int length = int.Parse(Console.ReadLine());

        while (true)
        {
            if (length > 0)
            {
                return length;
            }
            else
            {
                Console.Write("How many numbers will have the sequence?: ");
                length = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[] EnteringTheSequenceOfIntegers(int[] arrayOfNumbers)
    {
        Console.WriteLine("Please enter the numbers to calculate the average: ");

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        return arrayOfNumbers;
    }

    static int ReversingTheDigitsOfANumber(int number)
    {
        int reversed = 0;
        while (number > 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
        return reversed;
    }

    static double CalculatingTheAvarageOfASequenceOfNumbers(int[] sequence)
    {
        int sum = 0;
        double averageSum = 0.0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        averageSum = sum / ((double)sequence.Length);
        return averageSum;
    }

    static int EnteringANumberForLinearEquation()
    {
        Console.Write("Enter a number for 'a': ");
        int coeficentA = int.Parse(Console.ReadLine());

        while (true)
        {
            if (coeficentA != 0)
            {
                return coeficentA;
            }
            else
            {
                coeficentA = int.Parse(Console.ReadLine());
            }
        }
    }

    static int EnteringBNumberForLinearEquation()
    {
        Console.Write("Enter a number for 'b': ");
        int coeficentB = int.Parse(Console.ReadLine());
        return coeficentB;
    }

    static double CalculatingLinearEquation(int coeficentA, int coeficentB)
    {
        double numberX = (double)((-1) * coeficentB) / coeficentA;
        return numberX;
    }

    static void Main()
    {
        int choosedTask = ChoosingWhichTaskToSolve();
        Console.WriteLine();

        if (choosedTask == 1)
        {
            Console.Write("Enter a number for reversing its digits: ");
            int digitsForReversing = EnteringTheNumberForReversing();
            Console.Write("The reversed number is: ");
            Console.WriteLine(ReversingTheDigitsOfANumber(digitsForReversing));
        }
        else if (choosedTask == 2)
        {
            int length = EnteringTheLengthOfASequenceOfIntegers();
            int[] sequenceOfIntegers = new int[length];
            EnteringTheSequenceOfIntegers(sequenceOfIntegers);
            Console.Write("The average is: ");
            Console.WriteLine(CalculatingTheAvarageOfASequenceOfNumbers(sequenceOfIntegers));
        }
        else if (choosedTask == 3)
        {
            int coeficentA = EnteringANumberForLinearEquation();
            int coeficentB = EnteringBNumberForLinearEquation();
            Console.WriteLine();
            Console.Write("{0} * x + {1} = 0", coeficentA, coeficentB);
            Console.WriteLine();
            Console.Write("x = ");
            Console.WriteLine(CalculatingLinearEquation(coeficentA, coeficentB));
        }
        else if (choosedTask > 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You have entered wrong number!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
