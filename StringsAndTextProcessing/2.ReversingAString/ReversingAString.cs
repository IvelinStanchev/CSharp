/*Write a program that reads a string, reverses it and prints the result at the console.
Example: "sample" -> "elpmas".*/
using System;

class ReversingAString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string word = Console.ReadLine();
        char[] reversedWord = word.ToCharArray();
        Array.Reverse(reversedWord);
        Console.Write("The reversed string is: ");
        Console.WriteLine(reversedWord);//I use the 4/19 option to print the char array
    }
}
