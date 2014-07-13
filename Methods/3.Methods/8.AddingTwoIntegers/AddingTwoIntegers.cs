/*Write a method that adds two positive integer numbers represented as arrays of digits 
 (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
 Each of the numbers that will be added could have up to 10 000 digits.*/
using System;
using System.Collections.Generic;

class AddingTwoIntegers
{
    static List<int> Sum(int[] firstArray, int[] secondArray)
    {
        int oneInMind = 0;
        List<int> sum = new List<int>();
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] + secondArray[i] + oneInMind > 9)//If the sum is bigger than oneInMind goes to 1
            {
                sum.Add((firstArray[i] + secondArray[i] + oneInMind) % 10);//I get the remainder and add it to the sum (if the sum of the two array's numbers is 18 I get 8 to the sum and 1 in oneInMind)
                oneInMind = 1;
            }
            else
            {
                sum.Add((firstArray[i] + secondArray[i] + oneInMind));
                oneInMind = 0;
            }
        }
        sum.Reverse();
        if (sum[0] == 0)
        {
            sum.Remove(0);
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Please enter first number: ");
        string first = Console.ReadLine();
        Console.WriteLine("Please enter second number: ");
        string second = Console.ReadLine();
        int[] firstArray = new int[Math.Max(first.Length, second.Length) + 1];//Getting the biggest length
        int[] secondArray = new int[Math.Max(first.Length, second.Length) + 1];//Getting the biggest length

        for (int i = first.Length - 1; i >= 0; i--)
        {
            firstArray[first.Length - i - 1] = int.Parse(first[i].ToString());//I get each digit of the entered number into an array
        }

        for (int i = second.Length - 1; i >= 0; i--)
        {
            secondArray[second.Length - i - 1] = int.Parse(second[i].ToString());//I get each digit of the entered number into an array
        }

        foreach (int digit in Sum(firstArray, secondArray))
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }
}
