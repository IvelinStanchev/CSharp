/*http://bgcoder.com/Contest/Practice/92 */
using System;

class GreedyDwarf
{
    static long SumOfEachPattern(int[] valley)
    {
        string[] currentRow = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] pattern = new int[currentRow.Length];
        bool[] isVisited = new bool[valley.Length];
        isVisited[0] = true;

        for (int i = 0; i < pattern.Length; i++)
        {
            pattern[i] = int.Parse(currentRow[i]);
        }

        int currentIndex = 0;
        long coinSum = valley[0];
        int counter = -1;
        int allIndexes = 0;

        while (true)
        {
            if (counter == (pattern.Length - 1))
            {
                counter = -1;
            }

            counter++;
            currentIndex = pattern[counter];
            allIndexes += currentIndex;

            if (allIndexes >= 0 && allIndexes < valley.Length && isVisited[allIndexes] == false)
            {
                coinSum += valley[allIndexes];
                isVisited[allIndexes] = true;
            }
            else
            {
                return coinSum;
            }
        }
    }

    static int[] EnteringTheValley(int[] valley, string[] firstRow)
    {
        for (int i = 0; i < firstRow.Length; i++)
        {
            valley[i] = int.Parse(firstRow[i]);
        }
        return valley;
    }

    static void Main()
    {
        string[] firstRow = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] valley = new int[firstRow.Length];
        EnteringTheValley(valley, firstRow);

        int patterns = int.Parse(Console.ReadLine());
        long bestCoinsSum = long.MinValue;

        for (int i = 0; i < patterns; i++)
        {
            long currentCoinsSum = SumOfEachPattern(valley);

            if (bestCoinsSum < currentCoinsSum)
            {
                bestCoinsSum = currentCoinsSum;
            }
        }
        Console.WriteLine(bestCoinsSum);
    }
}


