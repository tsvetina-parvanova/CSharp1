using System;

class BinSearch
{
    static void Main(string[] args)
    {
        int result;
        Console.WriteLine("Please enter number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number k: ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Please enter integer number {0}", i + 1);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        if (arr[0] > k) Console.WriteLine("There is no number that is less than or equal to k.");
        else
        {
            int IndexOfElement = Array.BinarySearch(arr, k);
            if (IndexOfElement >= 0) result = arr[IndexOfElement];
            else result = arr[~IndexOfElement - 1];
            Console.WriteLine(result);
        }
    }
}



