/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/
using System;

class SquereOfMaximalSum
{
    static void Main()
    {
        Console.WriteLine("N and M must be bigger than 3. In case they are not, there wouldn't be a squere of size 3x3");
        Console.Write("Enter N (columns): ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter M(rows): ");
        int M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[M, N];

        /*int[,] matrix =
        {
            {1, 15, 4, 14, 5, 65},
            {4, 8, 2, 10, 14, 1},
            {4, 14, 21, 16, 17, 5},
            {12, 20, 56, 22, 12, 15},
            {6, 14, 12, 28, 9, 8},
        };*/

        EnteringTheArray(matrix);

        int sum = 0;//Here I will save the current sum of the squere
        int bestSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] +//We get the first squere as best 
                      matrix[1, 0] + matrix[1, 1] + matrix[1, 2] +
                      matrix[2, 0] + matrix[2, 1] + matrix[2, 2];

        int[,] bestSquere = new int[3, 3]
        {
            {matrix[0, 0], matrix[0, 1], matrix[0, 2]},
            {matrix[1, 0], matrix[1, 1], matrix[1, 2]},
            {matrix[2, 0], matrix[2, 1], matrix[2, 2]},
        };//Here I will collect the squere of the best sum

        CalculatingTheSquereWithBiggestSum(N, M, matrix, ref sum, bestSum, ref bestSquere);

        PrintingTheInputtedMatrix(matrix);

        PrintingTheSquereWithBiggestSum(bestSquere);

    }

    private static void PrintingTheInputtedMatrix(int[,] matrix)
    {
        Console.WriteLine("You matrix is: ");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

    private static void EnteringTheArray(int[,] matrix)
    {
        Console.WriteLine("Enter the matrix: ");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.WriteLine("{0} row", row);
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }

    private static void CalculatingTheSquereWithBiggestSum(int N, int M, int[,] matrix, ref int sum, int bestSum, ref int[,] bestSquere)
    {
        for (int row = 0; row < (M - 2); row++)
        {
            for (int col = 0; col < (N - 2); col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                      matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                      matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestSquere = new int[3, 3]
                    {
                        {matrix[row, col], matrix[row, col + 1], matrix[row, col + 2]},
                        {matrix[row + 1, col], matrix[row + 1, col + 1], matrix[row + 1, col + 2]},
                        {matrix[row + 2, col], matrix[row + 2, col + 1], matrix[row + 2, col + 2]},
                    };
                }
            }
        }
    }

    private static void PrintingTheSquereWithBiggestSum(int[,] bestSquere)
    {
        Console.WriteLine("The squere with biggest sum is: ");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0, 4}", bestSquere[i, j]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
