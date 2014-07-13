/*Write a program that fills and prints a matrix of size (n, n) as shown below: 
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13 */
using System;

class FillsAndPrintsMatrixB
{
    static void Main()
    {
        Console.Write("Enter the length of the side of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        /*Example: 
         *    0  1   2   3
         *    
         *0   1  8	 9  16
         *1   2	 7	10	15
         *2   3	 6	11	14
         *3   4	 5	12	13
         * 
         * So at even index like 0, 2 etc. the starting number is (row * n) + 1 (If we have row = 2 and n = 4, then the starting number
         * at column 2 will be 2 * 4 + 1 which makes 9
         * The same logic is for odd indexes. The formula for them is (row + 1) * n (If we have row = 3 and n = 4, then the starting
         * number will be (3 + 1) * 4 which makes 16
         * 
         * Also if the index is even the numbers numbers in column increase by 1
         * If the index is odd the numbers in column decrease by 1
         */

        FillsTheMatrix(n, matrix);//Fills the matrix

        PrintsTheMatrix(matrix);//Prints the matrix
    }

    private static void FillsTheMatrix(int n, int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)//Fills the matrix
        {
            int fillingNumber;
            if ((row % 2) != 0)
            {
                fillingNumber = (row + 1) * n;//This will be the first number of the column where the colomn or row is odd
            }
            else
            {
                fillingNumber = (row * n) + 1;//This will be the first number of the column where the colomn or row is even
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[col, row] = fillingNumber;
                if ((row % 2) != 0)
                {
                    fillingNumber--;
                }
                else
                {
                    fillingNumber++;
                }
            }
        }
    }

    private static void PrintsTheMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)//Prints the matrix
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
