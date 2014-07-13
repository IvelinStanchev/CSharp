/*Write a program that, depending on the user's choice inputs int, double or string variable. 
  If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
  The program must show the value of that variable as a console output. Use switch statement.*/
using System;

class IntDoubleOrString
{
    static void Main()
    {
        Console.Write("What type of variable you want to input (i(int), d(double) or s(string)) ? - ");
        char inputCharacter = char.Parse(Console.ReadLine());

        switch (inputCharacter)
        {
            case 'i':
                Console.Write("Enter an integer number: ");
                int numberInteger = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("The number after adding value 1 is: ");
                Console.WriteLine(numberInteger + 1);
                break;
            case 'd':
                Console.Write("Enter a double number: ");
                double numberDouble = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("The number after adding value 1 is: ");
                Console.WriteLine(numberDouble + 1);
                break;
            case 's' :
                Console.Write("Enter a word: ");
                string wordString = Console.ReadLine();
                Console.WriteLine();
                Console.Write("The word after adding '*' at the end: ");
                Console.WriteLine(wordString + "*");
                break;
        }
    }
}

