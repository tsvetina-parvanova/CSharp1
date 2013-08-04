//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
//Print the obtained array on the console.

using System;


    class MultipliedByFIve
    {
        static void Main(string[] args)
        {
            int arrayLength = 20;
            int[] arrayOfIntegers = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                arrayOfIntegers[i] = i * 5;
            }

            //Print on console
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(arrayOfIntegers[i] + " ");
            }
            Console.WriteLine();
        }
    }
