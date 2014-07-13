/*http://bgcoder.com/Contest/Practice/92 */
using System;
using System.Collections.Generic;

class KaspichanNumbers
{
    static void Main()
    {
        string[] kaspichanNumbers = new string[256];
        kaspichanNumbers = GettingKaspichanNumbersInStringArray(kaspichanNumbers);

        ulong decimalNumber = ulong.Parse(Console.ReadLine());

        if (decimalNumber == 0)
        {
            Console.WriteLine(kaspichanNumbers[0]);
        }
        else
        {
            List<int> remainders = new List<int>();
            remainders = GettingTheRemainders(remainders, decimalNumber);

            string kaspichanNumber = string.Empty;
            kaspichanNumber = GettingKaspichanNumber(kaspichanNumbers, remainders, kaspichanNumber);
            Console.WriteLine(kaspichanNumber);
        }
    }

    private static string GettingKaspichanNumber(string[] kaspichanNumbers, List<int> remainders, string kaspichanNumber)
    {
        for (int i = remainders.Count - 1; i >= 0; i --)
        {
            kaspichanNumber += kaspichanNumbers[remainders[i]];
        }

        return kaspichanNumber;
    }

    private static List<int> GettingTheRemainders(List<int> remainders, ulong decimalNumber)
    {
        int remainder = 0;

        while (decimalNumber > 0)
        {
            remainder = (int)(decimalNumber % 256);
            remainders.Add(remainder);
            decimalNumber /= 256;
        }

        return remainders;
    }

    private static string[] GettingKaspichanNumbersInStringArray(string[] kaspichanNumbers)
    {
        for (int i = 0; i < 256; i++)
        {
            if (i < 26)
            {
                kaspichanNumbers[i] = ((char)('A' + i)).ToString();
            }
            else if (i < 2 * 26)
            {
                kaspichanNumbers[i] = "a" + kaspichanNumbers[i - 26];
            }
            else if (i < 3 * 26)
            {
                kaspichanNumbers[i] = "b" + kaspichanNumbers[i - 2 * 26];
            }
            else if (i < 4 * 26)
            {
                kaspichanNumbers[i] = "c" + kaspichanNumbers[i - 3 * 26];
            }
            else if (i < 5 * 26)
            {
                kaspichanNumbers[i] = "d" + kaspichanNumbers[i - 4 * 26];
            }
            else if (i < 6 * 26)
            {
                kaspichanNumbers[i] = "e" + kaspichanNumbers[i - 5 * 26];
            }
            else if (i < 7 * 26)
            {
                kaspichanNumbers[i] = "f" + kaspichanNumbers[i - 6 * 26];
            }
            else if (i < 8 * 26)
            {
                kaspichanNumbers[i] = "g" + kaspichanNumbers[i - 7 * 26];
            }
            else if (i < 9 * 26)
            {
                kaspichanNumbers[i] = "h" + kaspichanNumbers[i - 8 * 26];
            }
            else
            {
                kaspichanNumbers[i] = "i" + kaspichanNumbers[i - 9 * 26];
            }
        }
        return kaspichanNumbers;
    }
}
