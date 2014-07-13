/*Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		x2 + 5 = 1x2 + 0x + 5 -> 5 0 1*/
using System;

class AddingTwoPolynomials
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

    static void Main()
    {
        int[] coeficentsOfFirstPolynomial = new int[3];
        int[] coeficentsOfSecondPolynomial = new int[3];
        int[] arrayOfAddedCoeficents = new int[3];

        AskingForCoeficents(coeficentsOfFirstPolynomial, coeficentsOfSecondPolynomial);
        DoAddingTwoPolynomials(coeficentsOfFirstPolynomial, coeficentsOfSecondPolynomial, arrayOfAddedCoeficents);

        Console.Write("After adding two polynomials: ");
        PrintingTheFinalPolynomial(arrayOfAddedCoeficents);
    }
}
