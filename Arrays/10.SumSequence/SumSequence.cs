//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	

using System;

    class SumSequence
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            int sum = 11;
            int currentSum = 0;
            int firstElement = 0;
            int start = 0;
            int end = 0;

            for (int i = 0; i < array.Length; i++)
            {
                currentSum += array[i];
                if (currentSum == sum)
                {
                    start = firstElement; 
                    end = i;
                    break;
                }
                if (i == array.Length - 1)
                {
                    currentSum = 0;
                    firstElement++;
                    if (firstElement == array.Length)
                    {
                        break;
                    }
                    i = firstElement - 1; 
                }
            }
            if (sum != currentSum)
            {
                Console.WriteLine("No such sum in array");
                return;
            }
            for (int i = start; i <= end; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }

