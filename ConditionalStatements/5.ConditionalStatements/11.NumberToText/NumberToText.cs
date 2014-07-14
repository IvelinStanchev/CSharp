/** Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0 -> "Zero"
	273 -> "Two hundred seventy three"
	400 -> "Four hundred"
	501 -> "Five hundred and one"
	711 -> "Seven hundred and eleven"*/
using System;

class NumberToText
{
    static void Main()
    {
        //If you want to see how the code works just debug(F10 and F11)
        Console.Write("Enter a number in the range (0, 999): ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int tens;//This variable will show the digit of tens
        int units;//This variable will show the digit of units
        int hundreds;//This variable will show the digit of hundreds
        int tensAndUnits;//Example: 515 -> tensAndUnits = 15;


        hundreds = number / 100;
        tens = (number % 100) / 10;
        units = (number % 100) % 10;
        tensAndUnits = number % 100;

        if ((number > 999) || (number < 0))
        {
            Console.ForegroundColor = ConsoleColor.Red;//Makes the words red
            Console.WriteLine("The number is out of range");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;//Gives back the normal color of words
        }
        else
        {
            if ((number >= 0) && (number < 20))//If the number is between 0 and 20
            {
                switch (number)
                {
                    case 0:
                        Console.WriteLine("{0} -> Zero", number);
                        break;
                    case 1:
                        Console.WriteLine("{0} -> One", number);
                        break;
                    case 2:
                        Console.WriteLine("{0} -> Two", number);
                        break;
                    case 3:
                        Console.WriteLine("{0} -> Three", number);
                        break;
                    case 4:
                        Console.WriteLine("{0} -> Four", number);
                        break;
                    case 5:
                        Console.WriteLine("{0} -> Five", number);
                        break;
                    case 6:
                        Console.WriteLine("{0} -> Six", number);
                        break;
                    case 7:
                        Console.WriteLine("{0} -> Seven", number);
                        break;
                    case 8:
                        Console.WriteLine("{0} -> Eight", number);
                        break;
                    case 9:
                        Console.WriteLine("{0} -> Nine", number);
                        break;
                    case 10:
                        Console.WriteLine("{0} -> Ten", number);
                        break;
                    case 11:
                        Console.WriteLine("{0} -> Eleven", number);
                        break;
                    case 12:
                        Console.WriteLine("{0} -> Twelve", number);
                        break;
                    case 13:
                        Console.WriteLine("{0} -> Thirteen", number);
                        break;
                    case 14:
                        Console.WriteLine("{0} -> Fourteen", number);
                        break;
                    case 15:
                        Console.WriteLine("{0} -> Fifteen", number);
                        break;
                    case 16:
                        Console.WriteLine("{0} -> Sixteen", number);
                        break;
                    case 17:
                        Console.WriteLine("{0} -> Seventeen", number);
                        break;
                    case 18:
                        Console.WriteLine("{0} -> Eighteen", number);
                        break;
                    case 19:
                        Console.WriteLine("{0} -> Nineteen", number);
                        break;
                    case 20:
                        Console.WriteLine("{0} -> Twenty", number);
                        break;
                }
            }
            else if ((number >= 20) && (number < 100))
            {
                if (number % 10 == 0)//If it can be divided by 10 without remainder, print it (20, 30 ,40...) 
                {//                    else print the number + ont, two, three..(21, 22, 23...)
                    switch (tens)
                    {
                        case 2:
                            Console.WriteLine("{0} - > Twenty", number);
                            break;
                        case 3:
                            Console.WriteLine("{0} -> Thirty", number);
                            break;
                        case 4:
                            Console.WriteLine("{0} -> Forty", number);
                            break;
                        case 5:
                            Console.WriteLine("{0} -> Fifty", number);
                            break;
                        case 6:
                            Console.WriteLine("{0} -> Sixty", number);
                            break;
                        case 7:
                            Console.WriteLine("{0} -> Seventy", number);
                            break;
                        case 8:
                            Console.WriteLine("{0} -> Eighty", number);
                            break;
                        case 9:
                            Console.WriteLine("{0} -> Ninety", number);
                            break;
                    }
                }
                else
                {
                    switch (tens)
                    {
                        case 2:
                            Console.Write("{0} -> Twenty ", number);
                            break;
                        case 3:
                            Console.Write("{0} -> Thirty ", number);
                            break;
                        case 4:
                            Console.Write("{0} -> Forty ", number);
                            break;
                        case 5:
                            Console.Write("{0} -> Fifty ", number);
                            break;
                        case 6:
                            Console.Write("{0} -> Sixty ", number);
                            break;
                        case 7:
                            Console.Write("{0} -> Seventy ", number);
                            break;
                        case 8:
                            Console.Write("{0} -> Eighty ", number);
                            break;
                        case 9:
                            Console.Write("{0} -> Ninety ", number);
                            break;
                    }
                    switch (units)
                    {
                        case 1:
                            Console.WriteLine("one");
                            break;
                        case 2:
                            Console.WriteLine("two");
                            break;
                        case 3:
                            Console.WriteLine("three");
                            break;
                        case 4:
                            Console.WriteLine("four");
                            break;
                        case 5:
                            Console.WriteLine("five");
                            break;
                        case 6:
                            Console.WriteLine("six");
                            break;
                        case 7:
                            Console.WriteLine("seven");
                            break;
                        case 8:
                            Console.WriteLine("eight");
                            break;
                        case 9:
                            Console.WriteLine("nine");
                            break;
                    }
                }
            }
            else if (number % 100 == 0)//If the number is 100, 200, 300, 400, 500, 600, 700, 800, or 900
            {
                switch (number)
                {
                    case 100:
                        Console.WriteLine("{0} -> One hundred", number);
                        break;
                    case 200:
                        Console.WriteLine("{0} -> Two hundred", number);
                        break;
                    case 300:
                        Console.WriteLine("{0} -> Three hundred", number);
                        break;
                    case 400:
                        Console.WriteLine("{0} -> Four hundred", number);
                        break;
                    case 500:
                        Console.WriteLine("{0} -> Five hundred", number);
                        break;
                    case 600:
                        Console.WriteLine("{0} -> Six hundred", number);
                        break;
                    case 700:
                        Console.WriteLine("{0} -> Seven hundred", number);
                        break;
                    case 800:
                        Console.WriteLine("{0} -> Eight hundred", number);
                        break;
                    case 900:
                        Console.WriteLine("{0} -> Nine hundred", number);
                        break;
                }
            }

            //If the number is not exception

            else if ((tens >= 2) && (number % 10 != 0))
            {
                switch (hundreds)
                {
                    case 1:
                        Console.Write("{0} -> One hundred ", number);
                        break;
                    case 2:
                        Console.Write("{0} -> Two hundred ", number);
                        break;
                    case 3:
                        Console.Write("{0} -> Three hundred ", number);
                        break;
                    case 4:
                        Console.Write("{0} -> Four hundred ", number);
                        break;
                    case 5:
                        Console.Write("{0} -> Five hundred ", number);
                        break;
                    case 6:
                        Console.Write("{0} -> Six hundred ", number);
                        break;
                    case 7:
                        Console.Write("{0} -> Seven hundred ", number);
                        break;
                    case 8:
                        Console.Write("{0} -> Eight hundred ", number);
                        break;
                    case 9:
                        Console.Write("{0} -> Nine hundred ", number);
                        break;
                }
                switch (tens)
                {
                    case 2:
                        Console.Write("twenty ");
                        break;
                    case 3:
                        Console.Write("thirty ");
                        break;
                    case 4:
                        Console.Write("fourty ");
                        break;
                    case 5:
                        Console.Write("fifty ");
                        break;
                    case 6:
                        Console.Write("sixty ");
                        break;
                    case 7:
                        Console.Write("seventy ");
                        break;
                    case 8:
                        Console.Write("eighty ");
                        break;
                    case 9:
                        Console.Write("ninety ");
                        break;
                }
                switch (units)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                }
            }
            else if ((tens == 1) || (tens == 0))
            {
                switch (hundreds)
                {
                    case 1:
                        Console.Write("{0} -> One hundred and ", number);
                        break;
                    case 2:
                        Console.Write("{0} -> Two hundred and ", number);
                        break;
                    case 3:
                        Console.Write("{0} -> Three hundred and ", number);
                        break;
                    case 4:
                        Console.Write("{0} -> Four hundred and ", number);
                        break;
                    case 5:
                        Console.Write("{0} -> Five hundred and ", number);
                        break;
                    case 6:
                        Console.Write("{0} -> Six hundred and ", number);
                        break;
                    case 7:
                        Console.Write("{0} -> Seven hundred and ", number);
                        break;
                    case 8:
                        Console.Write("{0} -> Eight hundred and ", number);
                        break;
                    case 9:
                        Console.Write("{0} -> Nine hundred and ", number);
                        break;
                }
                switch (tensAndUnits)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two", number);
                        break;
                    case 3:
                        Console.WriteLine("three", number);
                        break;
                    case 4:
                        Console.WriteLine("four", number);
                        break;
                    case 5:
                        Console.WriteLine("five", number);
                        break;
                    case 6:
                        Console.WriteLine("six", number);
                        break;
                    case 7:
                        Console.WriteLine("seven", number);
                        break;
                    case 8:
                        Console.WriteLine("eight", number);
                        break;
                    case 9:
                        Console.WriteLine("nine", number);
                        break;
                    case 10:
                        Console.WriteLine("ten", number);
                        break;
                    case 11:
                        Console.WriteLine("eleven", number);
                        break;
                    case 12:
                        Console.WriteLine("twelve", number);
                        break;
                    case 13:
                        Console.WriteLine("thirteen", number);
                        break;
                    case 14:
                        Console.WriteLine("fourteen", number);
                        break;
                    case 15:
                        Console.WriteLine("fifteen", number);
                        break;
                    case 16:
                        Console.WriteLine("sixteen", number);
                        break;
                    case 17:
                        Console.WriteLine("seventeen", number);
                        break;
                    case 18:
                        Console.WriteLine("eighteen", number);
                        break;
                    case 19:
                        Console.WriteLine("nineteen", number);
                        break;
                }
            }
            else if ((number % 10 == 0) && (number > 100))
            {
                switch (hundreds)
                {
                    case 1:
                        Console.Write("{0} -> One hundred ", number);
                        break;
                    case 2:
                        Console.Write("{0} -> Two hundred ", number);
                        break;
                    case 3:
                        Console.Write("{0} -> Three hundred ", number);
                        break;
                    case 4:
                        Console.Write("{0} -> Four hundred ", number);
                        break;
                    case 5:
                        Console.Write("{0} -> Five hundred ", number);
                        break;
                    case 6:
                        Console.Write("{0} -> Six hundred ", number);
                        break;
                    case 7:
                        Console.Write("{0} -> Seven hundred ", number);
                        break;
                    case 8:
                        Console.Write("{0} -> Eight hundred ", number);
                        break;
                    case 9:
                        Console.Write("{0} -> Nine hundred ", number);
                        break;
                }
                switch (tens)
                {
                    case 2:
                        Console.WriteLine("twenty");
                        break;
                    case 3:
                        Console.WriteLine("thirty");
                        break;
                    case 4:
                        Console.WriteLine("fourty");
                        break;
                    case 5:
                        Console.WriteLine("fifty");
                        break;
                    case 6:
                        Console.WriteLine("sixty");
                        break;
                    case 7:
                        Console.WriteLine("seventy");
                        break;
                    case 8:
                        Console.WriteLine("eighty");
                        break;
                    case 9:
                        Console.WriteLine("ninety");
                        break;
                }
            }
        }
    }
}
