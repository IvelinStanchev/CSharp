/*http://bgcoder.com/Contest/Practice/94 */
using System;
using System.Collections.Generic;

class DurankulakNumbers
{
    static void Main()
    {
        string[] durankulakNumbers = new string[168];
        durankulakNumbers = GettingTheDurankulakNumbers(durankulakNumbers);

        string durankulakNumber = Console.ReadLine();

        List<string> eachDurankulakNumber = new List<string>();
        eachDurankulakNumber = GettingEachDurankulakNumber(durankulakNumber);

        List<string> numberInDurankulak;
        numberInDurankulak = numberInDurankulakNumeralSystem(eachDurankulakNumber, durankulakNumbers);

        ulong decimalNumber;
        decimalNumber = DurankulakToDecimalRepresentation(numberInDurankulak);
        Console.WriteLine(decimalNumber);
    }

    //private static ulong PowerBy168(int counter)
    //{
    //    ulong result = 1;
    //    for (int i = 0; i < counter; i++)
    //    {
    //        result *= 168;
    //    }
    //    return result;
    //}

    private static ulong DurankulakToDecimalRepresentation(List<string> numberInDurankulak)
    {
        ulong decimalNumber = 0;
        int counter = 0;

        for (int i = numberInDurankulak.Count - 1; i >= 0; i--)
        {
            decimalNumber += ulong.Parse(numberInDurankulak[i].ToString()) * (ulong)(Math.Pow(168, counter));
            counter++;
        }

        return decimalNumber;
    }

    private static List<string> numberInDurankulakNumeralSystem(List<string> eachDurankulakNumber, string[] durankulakNumbers)
    {
        List<string> numberInDurankulak = new List<string>();

        for (int i = 0; i < eachDurankulakNumber.Count; i++)
        {
            for (int j = 0; j < 168; j++)
            {
                if (eachDurankulakNumber[i] == durankulakNumbers[j])
                {
                    numberInDurankulak.Add(j.ToString());
                    break;
                }
            }
        }

        return numberInDurankulak;
    }

    private static List<string> GettingEachDurankulakNumber(string durankulakNumber)
    {
        List<string> durankulakNumbers = new List<string>();

        string currentDigit = string.Empty;
        int counter = 0;

        string eachDurankulakNumber = string.Empty;

        while (counter < durankulakNumber.Length)
        {
            if ((durankulakNumber[counter] >= 'A') && (durankulakNumber[counter] <= 'Z'))
            {
                durankulakNumbers.Add(durankulakNumber[counter].ToString());
                counter++;
            }
            else
            {
                durankulakNumbers.Add(durankulakNumber[counter].ToString() + durankulakNumber[counter + 1].ToString());
                counter += 2;
            }
        }

        return durankulakNumbers;
    }

    static string[] GettingTheDurankulakNumbers(string[] durankulakNumbers)
    {
        for (int i = 0; i < 168; i++)
        {
            if (i < 26)
            {
                durankulakNumbers[i] = ((char)('A' + i)).ToString();
            }
            else if (i < 2 * 26)
            {
                durankulakNumbers[i] = "a" + durankulakNumbers[i - 26];
            }
            else if (i < 3 * 26)
            {
                durankulakNumbers[i] = "b" + durankulakNumbers[i - 2 * 26];
            }
            else if (i < 4 * 26)
            {
                durankulakNumbers[i] = "c" + durankulakNumbers[i - 3 * 26];
            }
            else if (i < 5 * 26)
            {
                durankulakNumbers[i] = "d" + durankulakNumbers[i - 4 * 26];
            }
            else if (i < 6 * 26)
            {
                durankulakNumbers[i] = "e" + durankulakNumbers[i - 5 * 26];
            }
            else
            {
                durankulakNumbers[i] = "f" + durankulakNumbers[i - 6 * 26];
            }
        }

        return durankulakNumbers;
    }
}
