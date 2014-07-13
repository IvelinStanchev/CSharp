/*http://bgcoder.com/Contest/Practice/95 */
using System;

class SpecialValue
{
    static int[][] EnteringData(int[][] enteredData)
    {
        for (int i = 0; i < enteredData.GetLength(0); i++)
        {
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            enteredData[i] = new int[currentRow.Length];

            for (int j = 0; j < currentRow.Length; j++)
            {
                enteredData[i][j] = int.Parse(currentRow[j]);
            }
        }
        return enteredData;
    }

    static long EachSpecialValue(int[][] enteredData, bool[][] usedCells,int column)
    {
        long result = 0;
        int rowCounter = 0;

        for (int i = 0; i < usedCells.GetLength(0); i++)
        {
            for (int j = 0; j < usedCells[i].Length; j++)
            {
                usedCells[i][j] = false;
            }
        }

        while (true)
	    {
            result++;

            if (usedCells[rowCounter][column])
            {
                return long.MinValue;
            }

            if (enteredData[rowCounter][column] < 0)
            {
                result -= enteredData[rowCounter][column];
                return result;
            }

            int indexer = enteredData[rowCounter][column];
            usedCells[rowCounter][column] = true;
            column = indexer;
            rowCounter++;

            if (rowCounter == enteredData.GetLength(0))
            {
                rowCounter = 0;
            }
	    }
    }

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[][] enteredData = new int[N][];

        EnteringData(enteredData);

        bool[][] usedCells = new bool[N][];

        for (int i = 0; i < enteredData.GetLength(0); i++)
        {
            usedCells[i] = new bool[enteredData[i].Length];
        }

        long maxSpecialValue = long.MinValue;

        for (int i = 0; i < enteredData[0].Length; i++)
        {
            long currentSpecialValue = EachSpecialValue(enteredData, usedCells, i);

            if (maxSpecialValue < currentSpecialValue)
            {
                maxSpecialValue = currentSpecialValue;
            }
        }
        Console.WriteLine(maxSpecialValue);
    }
}
