/*We are given 5 integer numbers. 
 Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.*/
 using System;

class IntegerNumbersSubset
{
    static void Main()
    {
        Console.Write("Enter a first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a third number: ");
        int thirdNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a fourth number: ");
        int fourthNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter a fifth number: ");
        int fifthNumber = int.Parse(Console.ReadLine());

        if ((firstNumber + secondNumber) == 0)//We are checking all possibilities the sum of the first number and the rest to be 0
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} = 0", firstNumber, secondNumber);
        }
        else if ((firstNumber + thirdNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} = 0", firstNumber, thirdNumber);
        }
        else if ((firstNumber + fourthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} = 0", firstNumber, fourthNumber);
        }
        else if ((firstNumber + fifthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} = 0", firstNumber, fifthNumber);
        }
        else if ((firstNumber + secondNumber + thirdNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, thirdNumber);
        }
        else if ((firstNumber + thirdNumber + fourthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, thirdNumber, fourthNumber);
        }
        else if ((firstNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} + {2} = 0", firstNumber, secondNumber, thirdNumber);
        }
        else if ((firstNumber + secondNumber + thirdNumber + fourthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are susbsets which sum is 0: ");
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber);
        }
        else if ((firstNumber + thirdNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are susbsets which sum is 0: ");
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        else if ((secondNumber + thirdNumber) == 0)//We are checking all possibilities the sum of the second number and the rest
        {//                                          to be 0
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} = 0", secondNumber, thirdNumber);
        }
        else if ((secondNumber + fourthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} = 0", secondNumber, fourthNumber);
        }
        else if ((secondNumber + fifthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} = 0", secondNumber, fifthNumber);
        }
        else if ((secondNumber + thirdNumber + fourthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, thirdNumber, fourthNumber);
        }
        else if ((secondNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} + {2} = 0", secondNumber, fourthNumber, fifthNumber);
        }
        else if ((thirdNumber + fourthNumber) == 0)//We are checking all possibilities the sum of the third number and the rest
        {//                                          to be 0
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} = 0", thirdNumber, fourthNumber);
        }
        else if ((thirdNumber + fifthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} = 0", thirdNumber, fifthNumber);
        }
        else if ((thirdNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} + {2} = 0", thirdNumber, fourthNumber, fifthNumber);
        }
        else if ((fourthNumber + fifthNumber) == 0)//We are checking all possibilities the sum of the third number and the rest
        {//                                          to be 0
            Console.WriteLine();
            Console.Write("There are subsets which sum is 0: ");
            Console.WriteLine("{0} + {1} = 0", fourthNumber, fifthNumber);
        }
        else if ((firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber) == 0)
        {
            Console.WriteLine();
            Console.Write("There is susbsets which sum is 0: ");
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("There are no subsets which sum is 0");
        }
    }
}

