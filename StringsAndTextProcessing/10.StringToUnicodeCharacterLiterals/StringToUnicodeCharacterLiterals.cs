/*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
 Hi!
 Expected output:
 \u0048\u0069\u0021*/
using System;

class StringToUnicodeCharacterLiterals
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string word = Console.ReadLine();

        PrintingAllElementsToUnicodeCharacterLiterals(word);
    }

    private static void PrintingAllElementsToUnicodeCharacterLiterals(string word)
    {
        foreach (var symbol in word)
        {
            int charSymbol = symbol;
            Console.Write("\\u{0:x4}", charSymbol);//I get the number in hexadecimal format
        }
        Console.WriteLine();
    }
}
