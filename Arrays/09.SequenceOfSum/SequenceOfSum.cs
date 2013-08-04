//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;
 class SequenceOfSum
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int[] check = new int[0];
            Array.Sort(arr);
            int frequentNumber = arr[0];
            if (arr[arr.Length - 1] < arr.Length)
            {
                check = new int[arr.Length];
            }
            else if (arr[arr.Length - 1] > arr.Length)
            {
                check = new int[arr[arr.Length - 1] + 1];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                check[arr[i]]++;
            }

           for (int i = 0; i < check.Length; i++)
          {
                if (frequentNumber < check[i]) frequentNumber = check[i];
                
       }

            Console.WriteLine("The most frequent number is : {1}, appeared {0} times.", frequentNumber, Array.IndexOf(check, frequentNumber));
        }
    }

