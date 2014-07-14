/*Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
 Find in the array a subset of K elements that have sum S or indicate about its absence.*/
using System;

class SubsetOfKElements
{
    static void Main()
    {

        Console.Write("Enter a number for the length of the array (N): ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for the sum (S): ");
        int S = int.Parse(Console.ReadLine());
        Console.Write("Enter a number for elements (K): ");
        int K = int.Parse(Console.ReadLine());
        int[] arrayOfSubSet = new int[N];
        int[] array = new int[N];

        //Getting the numbers into an array

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        int currentSum = 0;
        int counter = 0;
        bool flag = false;

        Array.Sort(array);//First I sort the array

        for (int i = 0; i < N; i++)//Checking if there is any subset with increasing each time the position by 1(1 2 6 61) Checking if is a subset
        {//                                                                                                          (  2 6 61) Checking if is a subset
            currentSum = array[i];//                                                                                 (    6 61) Checking if is a subset
            for (int j = i + 1; j < N; j++)//                                                                        (      61) Checking if is a subset
            {
                currentSum += array[j];
                if ((currentSum == S) && ((j - i + 1) == K))//If there is a subset and the numbers containing in it are equal to the number K I print it
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
                    Console.WriteLine(" = {0}", S);
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
