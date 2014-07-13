/*Write a program that compares two char arrays lexicographically (letter by letter).*/
using System;

class ComparingCharArrays
{
    static void Main()
    {
        Console.Write("How much elements do you want to have the first array? : ");
        int firstElements = int.Parse(Console.ReadLine());
        Console.Write("How much elements do you want to have the second array? : ");
        int secondElements = int.Parse(Console.ReadLine());

        char[] firstArray = new char[firstElements];
        char[] secondArray = new char[secondElements];

        Console.WriteLine("Enter each of the {0} chars of the first array: ", firstElements);
        Console.WriteLine();

        for (int i = 0; i < firstElements; i++)
        {
            Console.Write("firstArray[{0}] -> ", i);
            char eachChar = char.Parse(Console.ReadLine());
            firstArray[i] = eachChar;//Here I convert each entered char to the array
        }

        Console.WriteLine("Enter each of the {0} chars of the second array: ", secondElements);
        Console.WriteLine();

        for (int i = 0; i < secondElements; i++)
        {
            Console.Write("secondArray[{0}] -> ", i);
            char eachChar = char.Parse(Console.ReadLine());
            secondArray[i] = eachChar;//Here I convert each entered char to the array
        }

        //Here I will check the elements letter by letter

        int min = 0;
        min = firstElements;
        if (secondElements < min)//Here I check which array is smaller
        {
            min = secondElements;
        }

        Console.WriteLine();

        int counter = 0;//I will use it to check if the two arrays are equal

        for (int i = 0; i < min; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("The second array is bigger");
                Console.WriteLine();
                break;
            }
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("The first array is bigger");
                Console.WriteLine();
                break;
            }
            if (firstArray[i] == secondArray[i])
            {
                counter++;
                continue;
            }
        }

        if ((firstElements > counter) && (counter == min))
        {
            Console.WriteLine("The first array is bigger");
            Console.WriteLine();
        }
        if ((firstElements == secondElements) && (counter == min))
        {
            Console.WriteLine("The two arrays are equal");
            Console.WriteLine();
        }
    }
}
