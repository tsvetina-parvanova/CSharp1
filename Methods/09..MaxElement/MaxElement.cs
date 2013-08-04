//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class Max
{
    static int[] ArraySort(int[] firstArray, int startArray)
    {

        int select = 0;
        int select1 = 0;
        int n = firstArray.Length;
        int[] secondArray = new int[n];
        for (int index = startArray; index < n; index++)
        {
            select = index;
            for (int k = index + 1; k < n; k++)
            {
                if (firstArray[select] > firstArray[k])
                {
                    select = k;
                }
            }
            select1 = firstArray[select];
            firstArray[select] = firstArray[index];
            secondArray[index] = select1;
        }
        return secondArray;
    }

    static void Main()
    {
        Console.WriteLine("Please enter length of array:");
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        int lastElement = 0;
        Console.WriteLine("Please enter elements of array:");
        firstArray = enterElemnts(n, firstArray);
        Console.WriteLine("Please enter start array:");
        int startArray = int.Parse(Console.ReadLine());
        secondArray = ArraySort(firstArray, startArray);
        lastElement = volumeLastElementArray(secondArray, lastElement);
        Console.WriteLine(lastElement);
    }

    private static int volumeLastElementArray(int[] secondArray, int lastElementOfArray)
    {
        int lastLengthArray = secondArray.Length;
        lastElementOfArray = secondArray[lastLengthArray - 1];
        return lastElementOfArray;
    }

    private static int[] enterElemnts(int n, int[] array1)
    {
        for (int i = 0; i < n; i++)
        {
            array1[i] = int.Parse(Console.ReadLine());
        }
        return array1;
    }
}
