/*Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. 
 If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
 if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
		Use a switch statement and at the end print the calculated new value in the console.*/
using System;

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter a digit in the range (1, 9): ");
        int digit = int.Parse(Console.ReadLine());
        int multipliedDigit;

        switch (digit)
        {
            case 1:
            case 2:
            case 3:
                multipliedDigit = digit * 10;
                Console.WriteLine();
                Console.WriteLine("The digit is in the range (1,3)");
                Console.WriteLine();
                Console.WriteLine("After multiplying by 10, the number {0} is: {1} ({0} * 10 = {1})", digit, multipliedDigit);
                break;
            case 4:
            case 5:
            case 6:
                multipliedDigit = digit * 100;
                Console.WriteLine();
                Console.WriteLine("The digit is in the range (4,6)");
                Console.WriteLine();
                Console.WriteLine("After multiplying by 100, the number {0} is: {1} ({0} * 100 = {1})", digit, multipliedDigit);
                break;
            case 7:
            case 8:
            case 9:
                multipliedDigit = digit * 1000;
                Console.WriteLine();
                Console.WriteLine("The digit is between the range (7,9)");
                Console.WriteLine();
                Console.WriteLine("After multiplying by 1000, the number {0} is: {1} ({0} * 1000 = {1})", digit, multipliedDigit);
                break;
            default:
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;//Coloring the words in red
                if (digit == 0)
                {
                    Console.WriteLine("Error!\nYou have entered 0");
                }
                if (digit > 9)
                {
                    Console.WriteLine("Error!\nYou have entered number bigger than 9");
                }
                break;
            }
        }
    }
}
