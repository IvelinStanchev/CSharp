/*http://bgcoder.com/Contest/Practice/14 */
using System;
using System.Linq;
using System.Collections.Generic;

class Stars
{
    public static int width, height, depth, starCount;
    public static char[, ,] cube;
    public static Dictionary<char, int> starType = new Dictionary<char, int>();

    static void Main()
    {
        EnteringData();
        FindingEachStar();
        PrintingTheResult();
    }

    private static void PrintingTheResult()
    {
        var sorted = starType.OrderBy(x => x.Key);

        Console.WriteLine(starCount);

        foreach (var star in sorted)
        {
            Console.WriteLine("{0} {1}", star.Key, star.Value);
        }
    }

    private static void FindingEachStar()
    {
        for (int w = 1; w < width - 1; w++)
        {
            for (int h = 1; h < height - 1; h++)
            {
                for (int d = 1; d < depth - 1; d++)
                {
                    FindingSingleStars(w, h, d);
                }
            }
        }
    }

    private static void FindingSingleStars(int width, int height, int depth)
    {
        char currentChar = cube[width, height, depth];

        bool isStar =
            currentChar == cube[width - 1, height, depth] &&
            currentChar == cube[width + 1, height, depth] &&
            currentChar == cube[width, height - 1, depth] &&
            currentChar == cube[width, height + 1, depth] &&
            currentChar == cube[width, height, depth - 1] &&
            currentChar == cube[width, height, depth + 1];

        if (isStar)
        {
            starCount++;

            if (starType.ContainsKey(currentChar))
            {
                starType[currentChar]++;
            }
            else
            {
                starType.Add(currentChar, 1);
            }
        }
    }

    private static void EnteringData()
    {
        //W H D
        string[] firstRowWithDimensions = Console.ReadLine().Split();
        width = int.Parse(firstRowWithDimensions[0]);
        height = int.Parse(firstRowWithDimensions[1]);
        depth = int.Parse(firstRowWithDimensions[2]);

        cube = new char[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string[] lineFragment = Console.ReadLine().Split();

            for (int d = 0; d < depth; d++)
            {
                string cubeContent = lineFragment[d];

                for (int w = 0; w < width; w++)
                {
                    cube[w, h, d] = cubeContent[w];
                }
            }
        }
    }
}
