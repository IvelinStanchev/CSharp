/*http://bgcoder.com/Contest/Practice/95 *//*    !!**!--!!-	  ->  653 */
using System;
using System.Collections.Generic;
using System.Numerics;

class NineGagNumbers
{
    static void Main()
    {
        string nineGag = Console.ReadLine();

        string[] allNineGagNumbers = new string[9] { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };

        List<string> allNineGagDigits = new List<string>();
        allNineGagDigits = GettingAllNineGagDigits(nineGag, allNineGagNumbers, allNineGagDigits);

        string numberInNinthNumeralSystem;
        numberInNinthNumeralSystem = allNineGagDigitsInNinthNumeralSystem(allNineGagDigits);

        ulong decimalNumber;
        decimalNumber = RevertingNineNumeralSystemToDecimalRepresentation(numberInNinthNumeralSystem);
        Console.WriteLine(decimalNumber);
    }

    private static ulong RevertingNineNumeralSystemToDecimalRepresentation(string numberInNinthNumeralSystem)
    {
        ulong decimalNumber = 0;
        int counter = 0;
        // 805
        for (int i = numberInNinthNumeralSystem.Length - 1; i >= 0; i--)
        {
            decimalNumber += ulong.Parse(numberInNinthNumeralSystem[i].ToString()) * (ulong)BigInteger.Pow(9, counter);
            counter++;
        }

        return decimalNumber;
    }

    private static ulong PowerByNine(int counter)
    {
        ulong result = 1;
        for (int i = 0; i < counter; i++)
        {
            result *= 9;
        }
        return result;
    }

    private static string allNineGagDigitsInNinthNumeralSystem(List<string> allNineGagDigits)
    {
        string numberInNinthNumeralSystem = string.Empty;
        for (int i = 0; i < allNineGagDigits.Count; i++)
        {
            switch (allNineGagDigits[i])
            {
                case "-!":
                    numberInNinthNumeralSystem += "0";
                    break;
                case "**":
                    numberInNinthNumeralSystem += "1";
                    break;
                case "!!!":
                    numberInNinthNumeralSystem += "2";
                    break;
                case "&&":
                    numberInNinthNumeralSystem += "3";
                    break;
                case "&-":
                    numberInNinthNumeralSystem += "4";
                    break;
                case "!-":
                    numberInNinthNumeralSystem += "5";
                    break;
                case "*!!!":
                    numberInNinthNumeralSystem += "6";
                    break;
                case "&*!":
                    numberInNinthNumeralSystem += "7";
                    break;
                case "!!**!-":
                    numberInNinthNumeralSystem += "8";
                    break;
                default:
                    break;
            }
        }
        return numberInNinthNumeralSystem;
    }

    private static List<string> GettingAllNineGagDigits(string nineGag, string[] allNineGagNumbers, List<string> allNineGagDigits)
    {
        for (int i = 1; i < nineGag.Length; i++)
        {
            string currentWord = nineGag[i - 1].ToString();
            bool isGagNumber = false;

            while (isGagNumber == false)
            {
                for (int j = 0; j < allNineGagNumbers.Length; j++)
                {
                    if (currentWord == allNineGagNumbers[j])
                    {
                        isGagNumber = true;
                        break;
                    }
                }
                if (isGagNumber == false)
                {
                    currentWord += nineGag[i];
                    i++;
                }
                else
                {
                    break;
                }
            }
            allNineGagDigits.Add(currentWord);
        }
        return allNineGagDigits;
    }
}
