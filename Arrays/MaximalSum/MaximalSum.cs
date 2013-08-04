//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

    class MaximalSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length of array");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the count of number which sum you want to check");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0;

        if (k>n) { Console.WriteLine("Error"); }

        Console.WriteLine("Please enter {0} numbers",k);
 
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());  
        }
 
        Array.Sort(array);
 
        for (int index = n - 1; index >= n - k; index--)
        {
            sum += array[index];
        }
 
        Console.WriteLine(sum);
    }
        }
    

