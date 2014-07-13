/*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
 If an invalid number or non-number text is entered, the method should throw an exception. 
 Using this method write a program that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100 */
using System;

class MethodReadNumber
{
    static void ReadNumber(int start, int end)
    {
        int enterNumber = 0;
        Console.WriteLine("Enter ten numbers in the range [1, 100] so that 1 < a1 < ... < a10 < 100: ");

        for (int i = 0; i < 10; i++)
        {
            try
            {
                enterNumber = int.Parse(Console.ReadLine());

                if ((enterNumber <= start) || (enterNumber >= end))
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    start = enterNumber;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number isn't in the proper range or doesn't satisfy the requirement");
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("You have entered non-number");
                break;
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number doesn't fit in int");
                break;
            }
        }
    }

    static void Main()
    {
        ReadNumber(1, 100);
    }
}
