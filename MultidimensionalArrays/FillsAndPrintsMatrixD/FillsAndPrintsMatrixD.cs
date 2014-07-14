using log4net;
using log4net.Config;
using log4net.Appender;
/*Write a program that fills and prints a matrix of size (n, n) as shown below: 
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7 */
using System;
using System.Text;
using log4net.Layout;
using log4net.Core;

class FillsAndPrintsMatrixD
{
    private static readonly ILog log =
    LogManager.GetLogger(typeof(FillsAndPrintsMatrixD));

    static void Main()
    {
        Console.Write("Enter a number for the side of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        string direction = "down";
        int row = 0;
        int col = 0;

        FillingTheMatrix(n, matrix, ref direction, ref row, ref col);
        string result = PrintingTheMatrix(matrix);

        BasicConfigurator.Configure();
        log.Info("Size: " + n + '\n' + "Matrix: " + '\n' + result);
    }

    private static string PrintingTheMatrix(int[,] matrix)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result.AppendFormat("{0, 4}", matrix[i, j]);
                //Console.Write("{0, 4}", matrix[i, j]);
            }
            result.AppendLine();
            result.AppendLine();
            //Console.WriteLine();
            //Console.WriteLine();
        }

        return result.ToString().TrimEnd();
    }

    private static void FillingTheMatrix(int n, int[,] matrix, ref string direction, ref int row, ref int col)
    {
        for (int i = 1; i <= n * n; i++)//Filling the matrix
        {
            if (direction == "down" && ((row > (n - 1)) || (matrix[row, col] != 0)))
            {
                direction = "right";
                row--;
                col++;
            }
            if (direction == "right" && ((col > (n - 1)) || (matrix[row, col] != 0)))
            {
                direction = "up";
                row--;
                col--;
            }
            if (direction == "up" && ((row < 0) || (matrix[row, col] != 0)))
            {
                direction = "left";
                row++;
                col--;
            }
            if (direction == "left" && ((col < 0) || (matrix[row, col] != 0)))
            {
                direction = "down";
                row++;
                col++;
            }

            matrix[row, col] = i;

            if (direction == "down")
            {
                row++;
            }
            if (direction == "right")
            {
                col++;
            }
            if (direction == "up")
            {
                row--;
            }
            if (direction == "left")
            {
                col--;
            }
        }
    }
}
