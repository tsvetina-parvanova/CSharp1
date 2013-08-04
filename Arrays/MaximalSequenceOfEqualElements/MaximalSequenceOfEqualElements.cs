//Write a program that finds the maximal sequence of equal elements in an array.

using System;

    class MaximalSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
                   Console.WriteLine("Please enter count of numbers");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
 
        int count = 1;
        int maxCount = 0;
        int element = 0;
 
 
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter {0} number: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;
            }
            if (array[i] != array[i + 1])
            {
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                element = array[i];

            }
        }
        Console.WriteLine("The longest sequence is {0} elements of type {1} .", maxCount, element);

        }
    }

