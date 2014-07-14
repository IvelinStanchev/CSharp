/*Write a program to calculate the Nth Catalan number by given N.
 The program has the same task like the exercise 9*/
using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        int numberN;

        do//Entering number till it is bigger than 0
        {
            Console.Write("Enter a N number bigger than 0: ");
            numberN = int.Parse(Console.ReadLine());
        } while (numberN < 0);

        BigInteger nAndTwoFactorial = 1;
        BigInteger nFactorial = 1;
        BigInteger catalanNumber = 1;

        for (int i = numberN + 2; i < (2 * numberN) + 1; i++)
        {
            nAndTwoFactorial *= i;
        }
        for (int j = 1; j < numberN + 1; j++)
        {
            nFactorial *= j;
        }

        catalanNumber = nAndTwoFactorial / nFactorial;

        Console.WriteLine();
        Console.WriteLine("The catalan number is: {0}", catalanNumber);
    }
}
/* My formula for catalan number is: Example: If the inputted N number is 5:
 The original formula is:         (5 * 2)!
                               ------------- ;
                               (5 + 1)! * 5!

 After making the needed actions:    1*2*3*4*5*6*7*8*9*10
                                   -------------------------
                                   (1*2*3*4*5*6)*(1*2*3*4*5)

 After making the needed actions:    7*8*9*10
                                     ---------
                                     1*2*3*4*5

 The new abbreviated formula is:     The sum of the multiplication of (N + 2) to 2 * N
                                     -------------------------------------------------
                                                             N!
 */

