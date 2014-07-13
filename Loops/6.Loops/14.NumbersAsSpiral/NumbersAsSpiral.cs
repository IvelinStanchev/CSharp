/*Write a program that reads a positive integer number N (N < 20) from console and outputs 
 in the console the numbers 1 ... N numbers arranged as a spiral.
 Thanks to my colleague "nzhul" which video helped me to solve this task*/
using System;

class NumbersAsSpiral
{
    static void Main()
    {
        Console.Write("Enter a number for N: ");
        int numberN = int.Parse(Console.ReadLine());

        if (numberN <= 0)
        {
            Console.WriteLine("Enter a number bigger than 0");
        }
        else
        {
            int[,] matrix = new int[numberN, numberN];
            int row = 0;//Rows of the matrix
            int column = 0;//Columns of the matrix
            string direction = "right";
            int squareOfNumberN = numberN * numberN;

            for (int i = 1; i <= squareOfNumberN; i++)
            {
                if ((direction == "right") && (column > numberN - 1 || matrix[row, column] != 0))
                {
                    direction = "down";
                    column--;
                    row++;
                }
                if ((direction == "down") && (row > numberN - 1 || matrix[row, column] != 0))
                {
                    direction = "left";
                    row--;
                    column--;
                }
                if ((direction == "left") && (column < 0 || matrix[row, column] != 0))
                {
                    direction = "up";
                    column++;
                    row--;
                }
                if ((direction == "up") && (row < 0 || matrix[row, column] != 0))
                {
                    direction = "right";
                    row++;
                    column++;
                }

                matrix[row, column] = i;

                if (direction == "right")
                {
                    column++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    column--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }
            for (int w = 0; w < numberN; w++)//Brings out the matrix
            {
                for (int j = 0; j < numberN; j++)
                {
                    Console.Write("{0, 3} ", matrix[w, j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
