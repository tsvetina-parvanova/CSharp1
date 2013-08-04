//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}

using System;

    class MaxSumArray
    {
        static void Main(string[] args)
        {

            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int maximalSum = 0;
            int sumCurrent = 0;
            int firstIndex = 0;
            int lastIndex = 1;
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[j] <= 0)
                    j++;
                else if (sumCurrent + array[i] > maximalSum)
                {
                    sumCurrent += array[i];
                    maximalSum = sumCurrent;
                    firstIndex = j;
                    lastIndex = i;
                }
                else if ((i < array.Length - 1) && (array[i] + array[i + 1] > 0))
                    sumCurrent += array[i];
                else
                {
                    sumCurrent = 0;
                    i = j;
                    j++;
                }
            }

            Console.WriteLine(maximalSum);
            for (int i = firstIndex; i <= lastIndex; i++)
            {
                Console.Write(array[i] + " ");
            }  


        }
    }

