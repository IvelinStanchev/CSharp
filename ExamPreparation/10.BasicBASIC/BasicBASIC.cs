/*http://bgcoder.com/Contest/Practice/16 */
using System;
using System.Collections.Generic;
using System.Text;

class BasicBASIC
{
    public static int V = 0, W = 0, X = 0, Y = 0, Z = 0;

    static void Main()
    {
        List<string> allTextLines = new List<string>();
        List<string> allUniqueIdentifiers = new List<string>();
        StringBuilder buffer = new StringBuilder();

        string eachLine = Console.ReadLine();
        while (eachLine != "RUN")
        {
            allTextLines.Add(eachLine);
            eachLine = Console.ReadLine();
        }

        int counter = 0;
        while (counter != allTextLines.Count)
        {
            string[] splitted = allTextLines[counter].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            allUniqueIdentifiers.Add(splitted[0]);
            counter++;
        }

        int currentLine = 0;
        while (true)
        {
            string[] eachLineOfTheText = allTextLines[currentLine].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < eachLineOfTheText.Length; i++)//I start from 1 because I dont want to get the unique identifier which is at first position
            {
                buffer.Append(eachLineOfTheText[i]);
            }

            for (int i = 0; i < buffer.Length; i++)
            {
                //V, W, X, Y and Z
                if ((buffer[i] >= 'V') && (buffer[i] <= 'Z') && (buffer[i + 1] == '=') && ((buffer[i + 2] >= 'V') && (buffer[i + 2] <= 'Z')))
                {
                    IfXIsX(buffer[i], buffer[i + 2]);
                    break;
                }
            }
            
        }
    }

    private static void IfXIsX(char first, char second)
    {
        switch (first)
        {
            case 'V':
                if (second == 'W')
                {
                    V = W;
                }
                if (second == 'X')
                {
                    V = X;
                }
                if (second == 'Y')
                {
                    V = Y;
                }
                if (second == 'Z')
                {
                    V = Z;
                }
                break;
            case 'W':
                if (second == 'V')
                {
                    W = V;
                }
                if (second == 'X')
                {
                    W = X;
                }
                if (second == 'Y')
                {
                    W = Y;
                }
                if (second == 'Z')
                {
                    W = Z;
                }
                break;
            case 'X':
                if (second == 'V')
                {
                    X = V;
                }
                if (second == 'W')
                {
                    X = W;
                }
                if (second == 'Y')
                {
                    X = Y;
                }
                if (second == 'Z')
                {
                    X = Z;
                }
                break;
            case 'Y':
                if (second == 'V')
                {
                    Y = V;
                }
                if (second == 'W')
                {
                    Y = W;
                }
                if (second == 'X')
                {
                    Y = X;
                }
                if (second == 'Z')
                {
                    Y = Z;
                }
                break;
            case 'Z':
                if (second == 'V')
                {
                    Z = V;
                }
                if (second == 'W')
                {
                    Z = W;
                }
                if (second == 'Y')
                {
                    Z = Y;
                }
                if (second == 'X')
                {
                    Z = X;
                }
                break;
            default:
                break;
        }
    }
}
