/*Write a program that reads two arrays from the console and compares them element by element.*/
using System;

class ComparingTwoArrays
{
    static void Main()
    {
        Console.Write("How much elements do you want to have the arrays? : ");
        int elements = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int[] firstArray = new int[elements];
        int[] secondArray = new int[elements];

        Console.WriteLine("Enter each of the {0} numbers of the first array: ", elements);
        Console.WriteLine();

        for (int i = 0; i < elements; i++)
        {
            Console.Write("firstArray[{0}] -> ", i);
            int eachNumber = int.Parse(Console.ReadLine());
            firstArray[i] = eachNumber;//Here I convert each entered number to the array
        }

        Console.WriteLine();
        Console.WriteLine("Enter each of the {0} numbers of the second array: ", elements);
        Console.WriteLine();

        for (int i = 0; i < elements; i++)
        {
            Console.Write("secondArray[{0}] -> ", i);
            int eachNumber = int.Parse(Console.ReadLine());
            secondArray[i] = eachNumber;//Here I convert each entered number to the array
        }

        //Here I will print the arrays superimposed
        Console.WriteLine();

        Console.Write("First array: ");
        for (int i = 0; i < elements; i++)
        {
            Console.Write(firstArray[i]);
        }

        Console.WriteLine();


        Console.Write("Second array: ");
        for (int i = 0; i < elements; i++)
        {
            Console.Write(secondArray[i]);
        }

        Console.WriteLine();
        Console.WriteLine(new string('-', 50));
        Console.WriteLine();

        int counter = 0;//I will use it to see if the two arrays are equal

        //Here I am comparing the two arays element by element

        for (int i = 0; i < elements; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("The first array is bigger");
                Console.WriteLine();
                break;
            }
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("The second array is bigger");
                Console.WriteLine();
                break;
            }
            if (firstArray[i] == secondArray[i])
            {
                counter++;
                continue;
            }
        }

        if (counter == elements)//Checking if counter = elements -> the two arrays are equal
        {
            Console.WriteLine("The two arrays are equal");
            Console.WriteLine();
        }
    }
}
