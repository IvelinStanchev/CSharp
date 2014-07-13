/*http://bgcoder.com/Contest/Practice/94 */
using System;

class Laser
{
    static void Main()
    {
        int[] dimensionsOfTheCube = EnteringEachRow();

        int[] startingPosition = EnteringEachRow();

        int[] direction = EnteringEachRow();

        bool[, ,] visited = new bool[dimensionsOfTheCube[0] + 1, dimensionsOfTheCube[1] + 1, dimensionsOfTheCube[2] + 2];

        while (true)
        {
            visited[startingPosition[0], startingPosition[1], startingPosition[2]] = true;

            int[] newPositions = new int[3];
            for (int i = 0; i < 3; i++)
			{
                newPositions[i] = startingPosition[i] + direction[i];
			}

            if ((visited[newPositions[0], newPositions[1], newPositions[2]]) || (CheckingIfOnEdge(dimensionsOfTheCube, newPositions) >= 2))
            {
                Console.WriteLine("{0} {1} {2}", startingPosition[0], startingPosition[1], startingPosition[2]);
                return;
            }

            if (CheckingIfOnEdge(dimensionsOfTheCube, newPositions) == 1)
            {
                //on a wall
                direction = Reflecting(newPositions, direction, dimensionsOfTheCube);
            }

            for (int i = 0; i < 3; i++)
            {
                startingPosition[i] = newPositions[i];
            }
        }
    }

    private static int[] Reflecting(int[] newPositions, int[] direction, int[] dimensionsOfTheCube)
    {
        for (int i = 0; i < 3; i++)
        {
            if ((newPositions[i] == dimensionsOfTheCube[i]) && (direction[i] == 1))
            {
                direction[i] *= -1;
            }
            else if ((newPositions[i] == 1) && (direction[i] == -1))
            {
                direction[i] *= -1;
            }
        }
        return direction;
    }

    private static int CheckingIfOnEdge(int[] dimensionsOfTheCube, int[] newPositions)
    {
        int counter = 0;

        for (int i = 0; i < 3; i++)
        {
            if ((newPositions[i] == 1) || (newPositions[i] == dimensionsOfTheCube[i]))
            {
                counter++;
            }
        }
        return counter;
    }

    private static int[] EnteringEachRow()
    {
        string[] enteringThreeNumbers = Console.ReadLine().Split(' ');

        int[] threeNumbers = new int[3];

        for (int i = 0; i < 3; i++)
        {
            threeNumbers[i] = int.Parse(enteringThreeNumbers[i]);
        }
        return threeNumbers;
    }
}
