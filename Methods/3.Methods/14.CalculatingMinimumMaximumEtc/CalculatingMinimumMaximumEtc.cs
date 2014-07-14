/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
 Use variable number of arguments.*/
using System;
using System.Linq;

class CalculatingMinimumMaximumEtc
{
    static int[] EnteringTheArrayOfNumbers(int[] inputNumbers)
    {
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            inputNumbers[i] = int.Parse(Console.ReadLine());
        }
        return inputNumbers;
    }

    static int CalculatingMinimumNumber(int[] inputNumbers)
    {
        int maximumNumber;
        maximumNumber = inputNumbers.Min();
        return maximumNumber;
    }

    static int CalculatingMaximumNumber(int[] inputNumbers)
    {
        int minimumNumber;
        minimumNumber = inputNumbers.Max();
        return minimumNumber;
    }

    static double CalculatingAverage(int[] inputNumbers)
    {
        double averageNumber;
        averageNumber = inputNumbers.Average();
        return averageNumber;
    }

    static int CalculatingSumOfTheArray(int[] inputNumbers)
    {
        int sum;
        sum = inputNumbers.Sum();
        return sum;
    }

    static int CalculatingProduct(int[] inputNumbers)
    {
        int product = 1;

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            product *= inputNumbers[i];
        }
        return product;
    }

    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] inputNumbers = new int[length];

        Console.WriteLine("Enter the numbers: ");
        EnteringTheArrayOfNumbers(inputNumbers);//Entering the array
        Console.WriteLine();

        Console.Write("The minimal number is: ");
        Console.WriteLine(CalculatingMinimumNumber(inputNumbers));
        Console.Write("The maximal number is: ");
        Console.WriteLine(CalculatingMaximumNumber(inputNumbers));
        Console.Write("The avarage is: ");
        Console.WriteLine(CalculatingAverage(inputNumbers));
        Console.Write("The sum is: ");
        Console.WriteLine(CalculatingSumOfTheArray(inputNumbers));
        Console.Write("The product is: ");
        Console.WriteLine(CalculatingProduct(inputNumbers));
    }
}
