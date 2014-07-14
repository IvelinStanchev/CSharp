/*Write a class Matrix, to holds a matrix of integers. 
 Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().*/
using System;

class ClassMatrix
{
    static void Main()
    {
        Console.Write("Enter a number for the side of the two matrices: ");
        int side = int.Parse(Console.ReadLine());
        Matrix matrix1 = new Matrix(side, side);

        EnteringFirstMatrix(side, matrix1);

        Console.Clear();

        Console.WriteLine();

        Matrix matrix2 = new Matrix(side, side);

        EnteringSecondMatrix(side, matrix2);

        Console.Clear();

        PrintingFirstMatrix(side, matrix1);
        PrintingSecondMatrix(side, matrix2);
        PrintingTheResult(matrix1, matrix2);
    }

    private static void PrintingSecondMatrix(int side, Matrix matrix2)
    {
        Console.WriteLine("Second matrix: ");
        for (int row = 0; row < side; row++)
        {
            for (int col = 0; col < side; col++)
            {
                Console.Write("{0, 4}", matrix2[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void PrintingFirstMatrix(int side, Matrix matrix1)
    {
        Console.WriteLine("First matrix: ");
        for (int row = 0; row < side; row++)
        {
            for (int col = 0; col < side; col++)
            {
                Console.Write("{0, 4}", matrix1[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void PrintingTheResult(Matrix matrix1, Matrix matrix2)
    {
        Matrix addition = matrix1 + matrix2;
        Matrix substraction = matrix1 - matrix2;
        Matrix multiplication = matrix1 * matrix2;
        Console.WriteLine("After adding the two matrices: \n{0}", addition.ToString());
        Console.WriteLine("After subtracting the two matrices: \n{0}", substraction.ToString());
        Console.WriteLine("After multiplying the two matrices: \n{0}", multiplication.ToString());
    }

    private static void EnteringSecondMatrix(int side, Matrix matrix2)
    {
        Console.WriteLine("Second matrix: ");
        for (int row = 0; row < side; row++)
        {
            Console.WriteLine("{0} row", row);
            for (int col = 0; col < side; col++)
            {
                matrix2[row, col] = int.Parse(Console.ReadLine());
            }
        }
    }

    private static void EnteringFirstMatrix(int side, Matrix matrix1)
    {
        Console.WriteLine("First matrix: ");
        for (int row = 0; row < side; row++)
        {
            Console.WriteLine("{0} row", row);
            for (int col = 0; col < side; col++)
            {
                matrix1[row, col] = int.Parse(Console.ReadLine());
            }
        }
    }
}
