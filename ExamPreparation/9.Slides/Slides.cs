/*http://bgcoder.com/Contest/Practice/92 */
using System;
using System.IO;

class Slides
{
    public static string[, ,] cube;
    public static int widthOfCube, heightOfCube, depthOfCube, ballsWidth, ballsHeight, ballsDepth, oldBallsWidth, oldBallsHeight, oldBallsDepth;
    public static int[] dimensionsOfTheCube;
    public static string command;

    static void Main()
    {
        dimensionsOfTheCube = EnteringDimensionsForCube();
        widthOfCube = dimensionsOfTheCube[0];
        heightOfCube = dimensionsOfTheCube[1];
        depthOfCube = dimensionsOfTheCube[2];

        cube = new string[widthOfCube, heightOfCube, depthOfCube];
        cube = EnteringDataForTheCube(cube);
        int[] ballsLocation = EnteringBallsDimensions();
        ballsWidth = ballsLocation[0];
        ballsDepth = ballsLocation[1];
        ballsHeight = 0;

        oldBallsWidth = ballsWidth;
        oldBallsHeight = ballsHeight;
        oldBallsDepth = ballsDepth;

        while (true)
        {
            if (!IsPassable())
            {
                Console.WriteLine("Yes");
                Console.WriteLine("{0} {1} {2}", oldBallsWidth, oldBallsHeight, oldBallsDepth);
                Environment.Exit(0);
            }

            oldBallsWidth = ballsWidth;
            oldBallsHeight = ballsHeight;
            oldBallsDepth = ballsDepth;

            string currentCell = cube[ballsWidth, ballsHeight, ballsDepth];

            string[] commandAndDirection = currentCell.Split();
            command = commandAndDirection[0];

            switch (command)
            {
                case "S":
                    ballsHeight++;
                    if ((ballsHeight == dimensionsOfTheCube[1]) || ballsHeight < 0)
                    {
                        Console.WriteLine("Yes");
                        Console.WriteLine("{0} {1} {2}", oldBallsWidth, oldBallsHeight, oldBallsDepth);
                        return;
                    }
                    SlidingTheBall(commandAndDirection[1]);
                    break;
                case "T":
                    ballsWidth = int.Parse(commandAndDirection[1]);
                    ballsDepth = int.Parse(commandAndDirection[2]);
                    break;
                case "E":
                    if (ballsHeight == dimensionsOfTheCube[1] || ballsHeight < 0)
                    {
                        Console.WriteLine("Yes");
                        Console.WriteLine("{0} {1} {2}", oldBallsWidth, oldBallsHeight, oldBallsDepth);
                        return;
                    }
                    else
                    {
                        ballsHeight++;
                    }
                    break;
                case "B":
                    Console.WriteLine("No");
                    Console.WriteLine("{0} {1} {2}", ballsWidth, ballsHeight, ballsDepth);
                    return;

                default: throw new ArgumentException();
            }
        }
    }

    private static void SlidingTheBall(string direction)
    {
        switch (direction)
        {
            case "L":
                ballsWidth--;
                break;
            case "R":
                ballsWidth++;
                break;
            case "F":
                ballsDepth--;
                break;
            case "B":
                ballsDepth++;
                break;
            case "FL":
                ballsDepth--;
                ballsWidth--;
                break;
            case "FR":
                ballsDepth--;
                ballsWidth++;
                break;
            case "BL":
                ballsDepth++;
                ballsWidth--;
                break;
            case "BR":
                ballsDepth++;
                ballsWidth++;
                break;

            default: throw new ArgumentException();
        }

        if (!IsPassable())
        {
            Console.WriteLine("No");
            Console.WriteLine("{0} {1} {2}", oldBallsWidth, oldBallsHeight, oldBallsDepth);
            Environment.Exit(0);
        }
    }

    private static bool IsPassable()
    {
        if (ballsWidth >= 0 &&
            ballsHeight >= 0 &&
            ballsDepth >= 0 &&
            ballsWidth < dimensionsOfTheCube[0] &&
            ballsHeight < dimensionsOfTheCube[1] &&
            ballsDepth < dimensionsOfTheCube[2])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static int[] EnteringBallsDimensions()
    {
        string[] entersBallsDimensions = Console.ReadLine().Split();
        int[] ballsLocation = new int[2];
        for (int i = 0; i < 2; i++)
        {
            ballsLocation[i] = int.Parse(entersBallsDimensions[i]);
        }
        return ballsLocation;
    }

    private static string[, ,] EnteringDataForTheCube(string[, ,] cube)
    {
        //StreamReader file = new StreamReader(@"..\..\text.txt");

        for (int h = 0; h < cube.GetLength(1); h++)
        {
            //string eachLine = file.ReadLine();
            //string[] lineFragment = eachLine.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
            string[] lineFragment = Console.ReadLine().Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

            for (int d = 0; d < cube.GetLength(2); d++)
            {
                string[] cubeContent = lineFragment[d].Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                for (int w = 0; w < cube.GetLength(0); w++)
                {
                    cube[w, h, d] = cubeContent[w];
                }
            }
        }
        return cube;
    }

    private static int[] EnteringDimensionsForCube()
    {
        string[] data = Console.ReadLine().Split();
        int[] dimensions = new int[3];

        for (int i = 0; i < 3; i++)
        {
            dimensions[i] = int.Parse(data[i]);
        }
        return dimensions;
    }
}
