/*Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...*/
using System;

class CalculatingSum
{
    static void Main()
    {
        double firstSum = 1.0;//The first member of the sequence is 1
        for (double i = 2; i < 1000; i++)
        {
            if (i % 2 == 0)//Checking if 'i' is even to add it to the sum; Example: 1/4 -> 4 is even
            {
                firstSum += (1.0 / i);
            }
            else//Checking if 'i' is odd to take it out of the sum; Example: 1/5 -> 5 is odd
            {
                firstSum -= (1.0 / i);
            }
        }
        decimal secondSum = (decimal)firstSum;
        secondSum = Math.Round(secondSum, 3);//Makes it with accuracy 0.001
        Console.WriteLine("The sum is: {0}", secondSum);
    }
}

