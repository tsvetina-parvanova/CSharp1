//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;
class MinAndMaxNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number of numbers");
        int number = int.Parse(Console.ReadLine());
        int[] array=new int[number];

        for (int i = 0; i < number; i++)
        {
           array[i] = int.Parse(Console.ReadLine());
        }

        int min=array[0];
        int max=array[0];

        for (int i = 0; i < number; i++)
        {
            if (min > array[i])
                min = array[i];

            if (max < array[i]) 
            max = array[i];
        }
        Console.WriteLine("Minimal number is: " + min);
        Console.WriteLine("Maximal number is: " +  max);



    }
}

