//Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, 
//move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

    class Sorting
    {
        static void Main(string[] args)
        {

            int[] array = { 3,5,1,-2,4,5,-7,-2 };

            int firstPosition = 0;
            while (firstPosition <= array.Length - 1)
            {
                int minIndex = 0;
                int currentMin = int.MaxValue;
                for (int i = firstPosition; i < array.Length; i++)
                {
                    if (array[i] < currentMin)
                    {
                        currentMin = array[i];
                        minIndex = i;
                    }
                }
                int temp = array[firstPosition];

                array[firstPosition] = currentMin;
                array[minIndex] = temp;
                firstPosition++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, array[i]);
            }
    }
        }
    

