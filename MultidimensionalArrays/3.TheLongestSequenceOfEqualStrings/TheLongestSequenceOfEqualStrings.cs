/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located 
 on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. Example:
ha	fifi ho	 hi                            
fo	ha	 hi	 xx -> ha, ha, ha
xxx	ho	 ha	 xx

s	qq	s
pp	pp	s -> s, s, s
pp	qq	s               */
using System;

class TheLongestSequenceOfEqualStrings
{
    static void Main()
    {
        int n = 3;
        int m = 4;
        string[,] matrix = new string[3, 4] 
        {
            {"ha",	"fifi",	"ho",	"hi"},
            {"fo",	"ha",	"hi",	"xx"},
            {"xxx",	"ho",	"ha",	"xx"},
        };

        //int n = 3;
        //int m = 3;
        //string[,] matrix = new string[3, 3] 
        //{
        //    {"s",	    "qq",	"s"},
        //    {"pp",	"pp",	"s"},
        //    {"pp",	"qq",	"s"},
        //};

        string bestString = matrix[0, 0];//The best number
        int bestLength = 1;// The best length
        int currentLength = 1;//The current length


        //Simply method which goes through the diagonals which are inclined to the right
        int counterRightDiagonal = -1;//Just to perambulate the diagonals as I want
        for (int i = 1; i < n; i++)
        {
            for (int j = i; j > 0; j--)
            {
                counterRightDiagonal++;
                bestString = matrix[counterRightDiagonal, j];
                if (matrix[counterRightDiagonal + 1, j - 1] == matrix[counterRightDiagonal, j])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestString = matrix[counterRightDiagonal + 1, j - 1];
                    }
                }
            }
            currentLength = 1;
            counterRightDiagonal = -1;
        }

        int secondCounterRightDiagonal = -1;//Just to perambulate the diagonals as I want
        if (n == m)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = m - 1; j > i; j--)
                {
                    secondCounterRightDiagonal++;
                    if (matrix[secondCounterRightDiagonal + 1, j - 1] == matrix[secondCounterRightDiagonal, j])
                    {
                        currentLength++;
                        if (currentLength > bestLength)
                        {
                            bestLength = currentLength;
                            bestString = matrix[secondCounterRightDiagonal + 1, j - 1];
                        }
                    }
                }
                currentLength = 1;
                secondCounterRightDiagonal = i;
            }
        }
        else
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = m - 1; j > i + 1; j--)
                {
                    secondCounterRightDiagonal++;
                    if (matrix[secondCounterRightDiagonal + 1, j - 1] == matrix[secondCounterRightDiagonal, j])
                    {
                        currentLength++;
                        if (currentLength > bestLength)
                        {
                            bestLength = currentLength;
                            bestString = matrix[secondCounterRightDiagonal + 1, j - 1];
                        }
                    }
                }
                currentLength = 1;
                secondCounterRightDiagonal = i;
            }
        }//Ends the logic for the diagonals which are inclined to the right

        //Simply method which goes through the diagonals which are inclined to the left
        int counterLeftDiagonal = 0;//Just to perambulate the diagonals as I want
        for (int h = 0; h < n; h++)
        {
            for (int j = 0; j < h; j++)
            {
                counterLeftDiagonal++;
                if (matrix[counterLeftDiagonal + 1, j + 1] == matrix[counterLeftDiagonal, j])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestString = matrix[counterLeftDiagonal + 1, j + 1];
                    }
                }
            }
            currentLength = 1;
            counterLeftDiagonal = n - 3 - h;
        }

        int secondCounterLeftDiagonal = -1;//Just to perambulate the diagonals as I want
        if (n == m)
        {
            for (int k = 0; k < n; k++)
            {
                secondCounterLeftDiagonal = -1;
                for (int j = k; j < n - 1; j++)
                {
                    secondCounterLeftDiagonal++;
                    if (matrix[secondCounterLeftDiagonal + 1, j + 1] == matrix[secondCounterLeftDiagonal, j])
                    {
                        currentLength++;
                        if (currentLength > bestLength)
                        {
                            bestLength = currentLength;
                            bestString = matrix[secondCounterLeftDiagonal + 1, j + 1];
                        }
                    }
                }
                currentLength = 1;
            }
        }
        else
        {
            for (int k = 0; k < n; k++)
            {
                secondCounterLeftDiagonal = -1;
                for (int j = k + 1; j < n; j++)
                {
                    secondCounterLeftDiagonal++;
                    if (matrix[secondCounterLeftDiagonal + 1, j + 1] == matrix[secondCounterLeftDiagonal, j])
                    {
                        currentLength++;
                        if (currentLength > bestLength)
                        {
                            bestLength = currentLength;
                            bestString = matrix[secondCounterLeftDiagonal + 1, j + 1];
                        }
                    }
                }
                currentLength = 1;
            }
        }//Ends the logic for the diagonals which are inclined to the left

        //Simply method that goes through the rows
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                if (matrix[row, col + 1] == matrix[row, col])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestString = matrix[row, col + 1];
                    }
                }
            }
            currentLength = 1;
        }//Ends the logic for the rows

        //Simply method that goes through the columns
        for (int cols = 0; cols < m; cols++)
        {
            for (int rows = 0; rows < n - 1; rows++)
            {
                if (matrix[rows + 1, cols] == matrix[rows, cols])
                {
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestString = matrix[rows + 1, cols];
                    }
                }
            }
            currentLength = 1;
        }//Ends the logic for the columns

        //Printing the matrix
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("{0, 8}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        //Printing the bestString bestLength times
        Console.Write("The best sequence is: ");
        for (int g = 0; g < bestLength; g++)
        {
            if (g == 0)
            {
                Console.Write(bestString);
            }
            else
            {
                Console.Write(", " + bestString);
            }
        }
        Console.WriteLine();
    }
}
