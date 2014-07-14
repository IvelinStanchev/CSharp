/*Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).*/
using System;
using System.Numerics;

class KBiggerThanNFactorial
{
    static void Main()
    {
        Console.Write("Enter a number for N: ");
        int numberN = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for K: ");
        int numberK = int.Parse(Console.ReadLine());

        BigInteger nFactorial = 1;
        BigInteger finalProduct = 1;

        if (numberK > numberN)
        {
            for (int i = 1; i <= numberN; i++)
            {
                nFactorial *= i;
            }
            for (int h = (numberK - numberN) + 1; h <= numberK; h++)
            {
                finalProduct *= h;
            }

            finalProduct *= nFactorial;
            Console.WriteLine("The final number is: {0}", finalProduct);
        }
        else
        {
            Console.WriteLine("Invalid input numbers!");
        }
    }
}
/* Example: N = 5, K = 15
 *We need to calculate N! * K! / (K - N)!
 *That means that we need to calculate:  1*2*3*4*5 * 1*2*3*4*5*6*7*8*9*10*11*12*13*14*15
 *                                       -----------------------------------------------
 *                                                   1*2*3*4*5*6*7*8*9*10     (15-5)= 10
 *                                                   
 *The final product is:                  1*2*3*4*5 * 11*12*13*14*15; My formula calculates N! * (The numbers from (K-N)+1 to K)*/      

