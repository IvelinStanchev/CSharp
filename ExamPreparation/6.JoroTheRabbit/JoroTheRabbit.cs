/*http://bgcoder.com/Contest/Practice/94 */
using System;

class JoroTheRabbit
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);


        int[] terrain = new int[input.Length];

        for (int i = 0; i < terrain.Length; i++)
        {
            terrain[i] = int.Parse(input[i]);
        }

        int maximalPathNumber = 0;

        for (int startingIndex = 0; startingIndex < terrain.Length; startingIndex++)
        {
            for (int step = 1; step < terrain.Length; step++)
            {
                int index = startingIndex;
                int currentPath = 1;
                int nextIndex = (index + step);

                if (nextIndex >= terrain.Length)
                {
                    nextIndex = nextIndex - terrain.Length;
                }

                while (terrain[index] < terrain[nextIndex])
                {
                    currentPath++;
                    index = nextIndex;
                    nextIndex += step;

                    if (nextIndex >= terrain.Length)
                    {
                        nextIndex = nextIndex - terrain.Length;
                    }
                }

                if (maximalPathNumber < currentPath)
                {
                    maximalPathNumber = currentPath;
                }
            }
        }
        Console.WriteLine(maximalPathNumber);
    }
}
