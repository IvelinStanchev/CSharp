/*Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.*/
using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter a number to check the third digit: ");
        int firstNumber = int.Parse(Console.ReadLine());
        int thirdDigit;
        thirdDigit = (firstNumber % 1000) / 100;
        bool variable;
        if (thirdDigit == 7)
        {
            variable = true;
            Console.WriteLine("The third digit is 7: {0}", variable);
        }
        else
        {
            variable = false;
            Console.WriteLine("The third digit is 7: {0}", variable);
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The third digit is: {0}", thirdDigit);
        }
    }
}

