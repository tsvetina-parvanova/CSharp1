//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}
using System;

    class SequenceInArray
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 2, 3, 4, 2, 2, 4 };
        int maximumSequence = 0;
        int sequence = 1;
        string numbers = "";
        string maxSequence = "";
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                sequence++;
                numbers += array[i] + " ";
            }
            else
            {
                if (maximumSequence < sequence)
                {
                    maximumSequence = sequence;
                    numbers += array[i] + " ";
                    maxSequence = numbers;
                }
                sequence = 1;
                numbers = "";
            }
        }
 
        if (maximumSequence < sequence)
        {
            numbers += array[array.Length - 1];
            maxSequence = numbers;
        }
 
        Console.WriteLine(maxSequence);
    }
        }
    

