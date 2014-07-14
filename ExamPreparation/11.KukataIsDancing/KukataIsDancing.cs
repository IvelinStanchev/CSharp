using System;
using System.Text;

class KukataIsDancing
{
    public static int currentRow = 1;
    public static int currentColumn = 1;

    static void Main()
    {
        int howManyRows = int.Parse(Console.ReadLine());
        string[,] matrixWithColors = new string[3, 3]
        { 
            {"RED", "BLUE", "RED"},
            {"BLUE", "GREEN", "BLUE"},
            {"RED", "BLUE", "RED"},
        };
        int currentDirection = 0;
        StringBuilder message = new StringBuilder();

        for (int i = 0; i < howManyRows; i++)
        {
            string commands = Console.ReadLine();

            for (int j = 0; j < commands.Length; j++)
            {
                if (commands[j] == 'R')
                {
                    currentDirection--;
                }
                if (commands[j] == 'L')
                {
                    currentDirection++;
                }
                if (currentDirection == 4 || currentDirection == -4)
                {
                    currentDirection = 0;
                }
                if (commands[j] == 'W')
                {
                    ProccesMoving(currentDirection);
                }
            }
            message.AppendLine(matrixWithColors[currentRow, currentColumn]);
            currentRow = 1;
            currentColumn = 1;
        }
        Console.WriteLine(message.ToString().Trim());
    }

    private static void ProccesMoving(int currentDirection)
    {
        switch (currentDirection)
        {
            case -3:
                if (currentColumn == 0)
                {
                    currentColumn = 3;
                }
                currentColumn--;
                break;
            case -2:
                if (currentRow == 2)
                {
                    currentRow = -1;
                }
                currentRow++;
                break;
            case -1:
                if (currentColumn == 2)
                {
                    currentColumn = -1;
                }
                currentColumn++;
                break;
            case 0:
                if (currentRow == 0)
                {
                    currentRow = 3;
                }
                currentRow--;
                break;
            case 1:
                if (currentColumn == 0)
                {
                    currentColumn = 3;
                }
                currentColumn--;
                break;
            case 2:
                if (currentRow == 2)
                {
                    currentRow = -1;
                }
                currentRow++;
                break;
            case 3:
                if (currentColumn == 2)
                {
                    currentColumn = -1;
                }
                currentColumn++;
                break;
            default: throw new ArgumentException();
        }
    }
}
