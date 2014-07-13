/*Write a program that reads an integer number and calculates and prints its square root. 
 If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.*/
using System;

class SquareRoot
{
    static void Main()
    {
        CalculatingSquareRoot();
    }

    private static void CalculatingSquareRoot()
    {
        try
        {
            Console.Write("Enter an integer number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new System.ArithmeticException();
            }

            double squareRoot = Math.Sqrt(number);
            Console.WriteLine("The square root is: {0}", squareRoot);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
