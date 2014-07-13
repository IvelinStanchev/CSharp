/*Write a program that enters the coefficients a, b and c of a quadratic equation
        a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.*/
using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter a value for a: ");
        int variableA = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for b: ");
        int variableB = int.Parse(Console.ReadLine());
        Console.Write("Enter a value for c: ");
        int variableC = int.Parse(Console.ReadLine());

        if ((variableB < 0) && (variableC > 0))
            Console.WriteLine("The quadratic equation looks like that: {0}x*x {1}x + {2} = 0", variableA, variableB, variableC);
        if ((variableC < 0) && (variableB < 0))
            Console.WriteLine("The quadratic equation looks like that: {0}x*x {1}x {2} = 0", variableA, variableB, variableC);
        if ((variableB > 0) && (variableC < 0))
            Console.WriteLine("The quadratic equation looks like that: {0}x*x + {1}x {2} = 0", variableA, variableB, variableC);
        if ((variableB > 0) && (variableC > 0))
            Console.WriteLine("The quadratic equation looks like that: {0}x*x + {1}x + {2} = 0", variableA, variableB, variableC);

        double discriminant;
        double firstRoot, secondRoot;//These variables are the roots of the equation

        if (variableA == 0)
        {
            Console.WriteLine("The equation is not a quadratic!\nPlease re enter the values for the variables");
        }
        else if (variableB == 0)
        {
            Console.WriteLine("The equation is not a quadratic!\nPlease re enter the values for the variables");
        }
        else
        {
            discriminant = (variableB * variableB) + ((-4) * variableA * variableC);

            if (discriminant < 0)
            {
                Console.WriteLine();
                Console.WriteLine("The quadratic equation doesn't have real roots");
            }
            else
            {

                firstRoot = ((-1) * variableB + Math.Sqrt(discriminant)) / (2 * variableA);//Found the first root
                secondRoot = ((-1) * variableB - Math.Sqrt(discriminant)) / (2 * variableA);//Found the second root
                if (firstRoot == secondRoot)
                {
                    Console.WriteLine();
                    Console.WriteLine("First root = Second root");
                    Console.WriteLine("x1 = x2 = {0}", firstRoot);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("The first root (x1) is: {0}", firstRoot);
                    Console.WriteLine("The second root (x2) is: {0}", secondRoot);
                }
            }
        }
    }
}

