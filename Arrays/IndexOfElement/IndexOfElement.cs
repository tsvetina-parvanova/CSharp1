//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

using System;

    class IndexOfElement
    {
        static void Main(string[] args)
        {
            int[] array = {0,1,2,3,4,5,6,7,8,9,10};
        int searchedNumber = int.Parse(Console.ReadLine());
        int number = 0;
        int length= array.Length - 1;
        int middle;
        while (number <= length)
        {
            middle = (number + length) / 2;

            if (array[middle] == searchedNumber)
            {
                Console.WriteLine("Index is: {0}.", middle);
                break;
            }

            if (array[middle] < searchedNumber)
            {
                number = middle + 1;
            }

            if (array[middle] > searchedNumber)
            {
                length = middle - 1;
            }
        }
        }
    }

