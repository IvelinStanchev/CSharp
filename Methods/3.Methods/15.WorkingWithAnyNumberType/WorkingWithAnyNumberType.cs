/*Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.). 
 Use generic method (read in Internet about generic methods in C#).
*/
using System;
using System.Linq;
using System.Threading;
using System.Globalization;

class WorkingWithAnyNumberType
{
    static T CalculatingMinimumNumber<T>(T[] inputNumbers)
    {
        dynamic maximumNumber;
        maximumNumber = inputNumbers.Min();
        return maximumNumber;
    }

    static T CalculatingMaximumNumber<T>(T[] inputNumbers)
    {
        dynamic minimumNumber;
        minimumNumber = inputNumbers.Max();
        return minimumNumber;
    }

    static T CalculatingAverage<T>(T[] inputNumbers)
    {
        dynamic averageNumber;
        dynamic sum = inputNumbers[0];
        for (int i = 1; i < inputNumbers.Length; i++)
        {
            sum = sum + inputNumbers[i];
        }
        averageNumber = sum / inputNumbers.Length;
        return averageNumber;
    }

    static T CalculatingSumOfTheArray<T>(T[] inputNumbers)
    {
        dynamic sum = 0;
        for (int i = 0; i < inputNumbers.Length; i++)
        {
            sum = sum + inputNumbers[i];
        }
        return sum;
    }

    static T CalculatingProduct<T>(T[] inputNumbers)
    {
        dynamic product = 1;

        for (dynamic i = 0; i < inputNumbers.Length; i++)
        {
            product = product * inputNumbers[i];
        }
        return product;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter the length of the array: ");
        int length = int.Parse(Console.ReadLine());
        decimal[] arrayOfNumbers = new decimal[length];

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine("The array is: ");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write(arrayOfNumbers[i] + " ");
        }
        Console.WriteLine();
        Console.Write("The minimal number is: ");
        Console.WriteLine(CalculatingMinimumNumber(arrayOfNumbers));
        Console.Write("The maximal number is: ");
        Console.WriteLine(CalculatingMaximumNumber(arrayOfNumbers));
        Console.Write("The average is: ");
        Console.WriteLine(CalculatingAverage(arrayOfNumbers));
        Console.Write("The sum is: ");
        Console.WriteLine(CalculatingSumOfTheArray(arrayOfNumbers));
        Console.Write("The product is: ");
        Console.WriteLine(CalculatingProduct(arrayOfNumbers));
    }
}
