/*Extend the program to support also subtraction and multiplication of polynomials.*/
using System;

class SubstractingAddingAndMultiplyingTwoNominals
{
    static void AskingForCoeficents(int[] coeficentsOfFirstPolynomial, int[] coeficentsOfSecondPolynomial)
    {
        Console.WriteLine("Add coeficents for the first polynomial: ");
        Console.Write("a = ");
        coeficentsOfFirstPolynomial[0] = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        coeficentsOfFirstPolynomial[1] = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        coeficentsOfFirstPolynomial[2] = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Add coeficents for the second polynomial: ");
        Console.Write("a = ");
        coeficentsOfSecondPolynomial[0] = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        coeficentsOfSecondPolynomial[1] = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        coeficentsOfSecondPolynomial[2] = int.Parse(Console.ReadLine());
    }

    static void DoAddingTwoPolynomials(int[] coeficentsOfFirstPolynomial, int[] coeficentsOfSecondPolynomial, int[] arrayOfAddedCoeficents)
    {
        for (int i = 0; i < coeficentsOfFirstPolynomial.Length; i++)
        {
            arrayOfAddedCoeficents[i] = coeficentsOfFirstPolynomial[i] + coeficentsOfSecondPolynomial[i];
        }
    }

    static void DoSubstractingTwoNominals(int[] coeficentsOfFirstPolynomial, int[] coeficentsOfSecondPolynomial, int[] arrayOfSubstractedCoeficents)
    {
        for (int i = 0; i < coeficentsOfFirstPolynomial.Length; i++)
        {
            arrayOfSubstractedCoeficents[i] = coeficentsOfFirstPolynomial[i] - coeficentsOfSecondPolynomial[i];
        }
    }

    static void DoMultiplyingTwoNominals(int[] coeficentsOfFirstPolynomial, int[] coeficentsOfSecondPolynomial, int[,] matrixForMultiplying)
    {
        int counter = 0;
        for (int i = 0; i < 3; i++)
        {
            counter = i;
            for (int j = 0; j < 3; j++)
            {
                matrixForMultiplying[i, counter] = coeficentsOfFirstPolynomial[i] * coeficentsOfSecondPolynomial[j];
                counter++;
            }
        }
    }

    static void DoGettingMultipliedPolynomialsInArray(int[,] matrixForMultiplying, int[] arrayOfMultipliedCoeficents)
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arrayOfMultipliedCoeficents[i] += matrixForMultiplying[j, i];
            }
        }
    }

    static void PrintingTheFinalPolynomial(int[] arrayOfCoeficents)
    {
        for (int i = 0; i < arrayOfCoeficents.Length; i++)
        {
            if (i == 0)
            {
                Console.Write(arrayOfCoeficents[i] + "x^2 ");
            }
            if ((arrayOfCoeficents[i] < 0) && (i == 1))
            {
                Console.Write(" - " + (-1) * arrayOfCoeficents[i] + "x");
            }
            if ((arrayOfCoeficents[i] > 0) && (i == 1))
            {
                Console.Write(" + " + arrayOfCoeficents[i] + "x");
            }
            if ((arrayOfCoeficents[i] < 0) && (i == 2))
            {
                Console.Write(" - " + (-1) * arrayOfCoeficents[i]);
            }
            if ((arrayOfCoeficents[i] > 0) && (i == 2))
            {
                Console.Write(" + " + arrayOfCoeficents[i]);
            }
        }
        Console.WriteLine();
    }

    static void PrintingTheMultipliedPolynomials(int[] arrayOfMultipliedCoeficents)
    {
        for (int i = 0; i < arrayOfMultipliedCoeficents.Length; i++)
        {
            if ((i == 0) && (arrayOfMultipliedCoeficents[i] > 0))
            {
                Console.Write(arrayOfMultipliedCoeficents[i] + "x^4");
            }
            if ((i == 0) && (arrayOfMultipliedCoeficents[i] < 0))
            {
                Console.Write("- " + (-1) * arrayOfMultipliedCoeficents[i] + "x^4");
            }

            if ((i == 1) && (arrayOfMultipliedCoeficents[i] > 0))
            {
                Console.Write(" + " + arrayOfMultipliedCoeficents[i] + "x^3");
            }
            if ((i == 1) && (arrayOfMultipliedCoeficents[i] < 0))
            {
                Console.Write(" - " + (-1) * arrayOfMultipliedCoeficents[i] + "x^3");
            }

            if ((i == 2) && (arrayOfMultipliedCoeficents[i] > 0))
            {
                Console.Write(" + " + arrayOfMultipliedCoeficents[i] + "x^2");
            }
            if ((i == 2) && (arrayOfMultipliedCoeficents[i] < 0))
            {
                Console.Write(" - " + (-1) * arrayOfMultipliedCoeficents[i] + "x^2");
            }

            if ((i == 3) && (arrayOfMultipliedCoeficents[i] > 0))
            {
                Console.Write(" + " + arrayOfMultipliedCoeficents[i] + "x");
            }
            if ((i == 3) && (arrayOfMultipliedCoeficents[i] < 0))
            {
                Console.Write(" - " + (-1) * arrayOfMultipliedCoeficents[i] + "x");
            }

            if ((i == 4) && (arrayOfMultipliedCoeficents[i] > 0))
            {
                Console.Write(" + " + arrayOfMultipliedCoeficents[i]);
            }
            if ((i == 4) && (arrayOfMultipliedCoeficents[i] < 0))
            {
                Console.Write(" - " + (-1) * arrayOfMultipliedCoeficents[i]);
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] coeficentsOfFirstPolynomial = new int[3];
        int[] coeficentsOfSecondPolynomial = new int[3];
        int[] arrayOfAddedCoeficents = new int[3];
        int[] arrayOfSubstractedCoeficents = new int[3];
        int[] arrayOfMultipliedCoeficents = new int[5];
        int[,] matrixForMultiplying = new int[3, 5];

        AskingForCoeficents(coeficentsOfFirstPolynomial, coeficentsOfSecondPolynomial);
        DoAddingTwoPolynomials(coeficentsOfFirstPolynomial, coeficentsOfSecondPolynomial, arrayOfAddedCoeficents);
        DoSubstractingTwoNominals(coeficentsOfFirstPolynomial, coeficentsOfSecondPolynomial, arrayOfSubstractedCoeficents);

        Console.Write("After adding two polynomials: ");
        PrintingTheFinalPolynomial(arrayOfAddedCoeficents);

        Console.WriteLine();

        Console.Write("After substracting two polynomials: ");
        PrintingTheFinalPolynomial(arrayOfSubstractedCoeficents);

        Console.WriteLine();

        Console.Write("After multiplying two polynominals: ");
        DoMultiplyingTwoNominals(coeficentsOfFirstPolynomial, coeficentsOfSecondPolynomial, matrixForMultiplying);
        DoGettingMultipliedPolynomialsInArray(matrixForMultiplying, arrayOfMultipliedCoeficents);
        PrintingTheMultipliedPolynomials(arrayOfMultipliedCoeficents);
    }
}
