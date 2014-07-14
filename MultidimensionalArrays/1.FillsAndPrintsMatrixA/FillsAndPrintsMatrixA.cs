/*Write a program that fills and prints a matrix of size (n, n) as shown below:
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16 */
using System;

class FillsAndPrintsMatrixA
{
    static void Main()
    {
        Console.Write("What will be the size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        int fillingNumber = 1;//The first number starts from 1

        fillingNumber = FillingTheMatrix(matrix, fillingNumber);

        PrintingTheMatrix(matrix);
    }

    private static void PrintingTheMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    private static int FillingTheMatrix(int[,] matrix, int fillingNumber)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = fillingNumber;
                fillingNumber++;//Each time the filling number will grow with 1
            }
        }
        return fillingNumber;
    }
}
