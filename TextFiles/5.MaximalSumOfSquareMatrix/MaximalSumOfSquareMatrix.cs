/*Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 
 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. 
 Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4   ->   17
3 7 1 2
4 3 3 2 */
using System;
using System.IO;

class MaximalSumOfSquareMatrix
{
    static void Main()
    {
        //My file that contains the matrix is in the directory of the program

        using (StreamWriter fileWithTheBiggestSum = new StreamWriter(@"..\..\FileWithTheBiggestSum.txt"))
        {
            fileWithTheBiggestSum.Write(GetMax(GettingTheMatrixOutOfTheFile()));
        }
        Console.WriteLine("Done! You can see the result in the file FileWithTheBiggestSum.txt which is in the program directory");
    }

    private static int[,] GettingTheMatrixOutOfTheFile()
    {
        StreamReader readingTheMatrix = new StreamReader(@"..\..\Matrix.txt");

        using (readingTheMatrix)
        {
            int side;
            side = int.Parse(readingTheMatrix.ReadLine());

            int[,] matrix = new int[side, side];

            for (int row = 0; row < side; row++)
            {
                string[] numbers = readingTheMatrix.ReadLine().Split(' ');

                for (int col = 0; col < side; col++)
                {
                    matrix[row, col] = int.Parse(numbers[col]);
                }
            }
            return matrix;
        }
    }


    private static int GetMax(int[,] matrix)
    {
        int maxSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                maxSum = Math.Max(maxSum, matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1]);//Checking each 2x2 square and get the maximal one
            }
        }

        return maxSum;
    }
}
