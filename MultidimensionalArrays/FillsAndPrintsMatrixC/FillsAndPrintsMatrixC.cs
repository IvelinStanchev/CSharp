/*Write a program that fills and prints a matrix of size (n, n) as shown below: 
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10 */
using System;

class FillsAndPrintsMatrixC
{
    static void Main()
    {
        Console.Write("Enter the length of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        int counter = 0;//I will use this variable to increase the number in each row by it
        int counterForFillingNumber = -1;//This variable will be used because on each row the numbers are increased with different values
        //Example:
        //7            - here it starts from 7
        //4	 8	       - here it starts from 4
        //2	 5	9	   - here it starts from 2
        //1	 3	6  10  - here it starts from 1
        //    see the rows below and you will get the idea
        int firstFillingNumber = 1;//This variable will change not as I want 
        int realFillingNumber = 0;//This variable will abstract firstFillingNumber for taking the firstFillingNumber before it is changed

        FillingTheMatrixBeforeMainDigonal(n, matrix, ref counter, ref counterForFillingNumber, ref firstFillingNumber, ref realFillingNumber);

        int firstNumberFromTheMainDiagonal = realFillingNumber + counterForFillingNumber - n + 1;//The first number from the main diagonal

        firstNumberFromTheMainDiagonal = FillingTheMainDiagonalOfTheMatrix(n, matrix, firstNumberFromTheMainDiagonal);

        firstFillingNumber = firstNumberFromTheMainDiagonal - 1;
        FillingTheMatrixAfterMainDiagonal(n, matrix, ref counter, ref firstFillingNumber, ref realFillingNumber);

        PrintingTheMatrix(matrix);
    }

    private static void FillingTheMatrixAfterMainDiagonal(int n, int[,] matrix, ref int counter, ref int firstFillingNumber, ref int realFillingNumber)
    {
        for (int row = 0; row < n - 1; row++)//The same logic appears here but with different number and on each row the numbers are
        {//                                    decreasing with 4. Thats why I am not using counterForFillingNumber
            counter = n;
            firstFillingNumber++;
            realFillingNumber = firstFillingNumber;
            for (int col = row + 1; col < n; col++)
            {
                matrix[row, col] = realFillingNumber;
                counter--;
                realFillingNumber += counter;
            }
        }
    }

    private static int FillingTheMainDiagonalOfTheMatrix(int n, int[,] matrix, int firstNumberFromTheMainDiagonal)
    {
        for (int rowAndCol = 0; rowAndCol < n; rowAndCol++)
        {
            matrix[rowAndCol, rowAndCol] = firstNumberFromTheMainDiagonal;
            firstNumberFromTheMainDiagonal++;
        }
        return firstNumberFromTheMainDiagonal;
    }

    private static void FillingTheMatrixBeforeMainDigonal(int n, int[,] matrix, ref int counter, ref int counterForFillingNumber, ref int firstFillingNumber, ref int realFillingNumber)
    {
        for (int row = n - 1; row > 0; row--)//Filling the matrix before the main diagonal
        {
            counterForFillingNumber++;
            firstFillingNumber += counterForFillingNumber;
            realFillingNumber = firstFillingNumber;// I make this because firstFillingNumber number will change dramataically and
            counter = (n - row) + 1;//                I want to save the first got number from firstFillingNumber
            //The counter will be used because on each row the numbers increase differently
            //Example:
            //7
            //4	 8	       - here they increase with 4
            //2	 5	9	   - here they increase with 3, 4
            //1	 3	6  10  - here they increase with 2, 3, 4
            //    see the rows below and you will get the idea
            for (int col = 0; col < row; col++)
            {

                matrix[row, col] = realFillingNumber;
                realFillingNumber += counter;
                counter++;
            }
        }
    }

    private static void PrintingTheMatrix(int[,] matrix)
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
