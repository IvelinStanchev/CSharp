/*We are given an array of integers and a number S. 
 Write a program to find if there exists a subset of the elements of the array that has a sum S. Example:
	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14 -> yes (1+2+5+6)*/
using System;

class SubsetOfSumS
{
    static void Main()
    {
        Console.Write("Enter a length for the array: ");
        int length = int.Parse(Console.ReadLine());
        Console.Write("Enter the sum: ");
        int sum = int.Parse(Console.ReadLine());
        int[] arrayOfSubSet = new int[length];
        int[] array = new int[length];

        //Getting the numbers into an array

        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        int currentSum = 0;
        int counter = 0;
        bool flag = false;

        Array.Sort(array);//First I sort the array

        for (int i = 0; i < length; i++)//Checking if there is any subset with increasing each time the position by 1(1 2 6 61) Checking if is a subset
        {//                                                                                                          (  2 6 61) Checking if is a subset
            currentSum = array[i];//                                                                                 (    6 61) Checking if is a subset
            for (int j = i + 1; j < length; j++)//                                                                   (      61) Checking if is a subset
            {
                currentSum += array[j];
                if (currentSum == sum)//If there is a subset I print it
                {
                    flag = true;
                    counter = i;//The starting print position

                    for (int h = counter; h <= j; h++)
                    {
                        if (counter == h)
                        {
                            Console.Write(array[h] + " ");
                        }
                        else
                        {
                            Console.Write("+ " + array[h] + " ");
                        }
                    }
                    Console.WriteLine(" = {0}", sum);
                    Console.WriteLine();
                    break;
                }
            }
        }
        if (flag == false)//If there is no subsets 
        {
            Console.WriteLine("There are no subsets");
        }
    }
}