//Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

using System;

    class CountNumberInArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number you want to check:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number of numbers in array:");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array=new int[1000];
            ReadArray(arrayLenght, array);
            CheckCountNumber(number, arrayLenght, array);



        }

        private static void CheckCountNumber(int number, int arrayLenght, int[] array)
        {
            int count = 0;
            for (int index = 0; index < arrayLenght; index++)
            {
                if (array[index] == number) count++;

            }
            Console.WriteLine("The number {0} counts {1} times in array", number, count);
        }

private static void ReadArray(int arrayLenght, int[] array)
{
            for (int index = 0; index < arrayLenght; index++)
            {
                Console.WriteLine("Please enter {0} number", index + 1);
                array[index]=int.Parse(Console.ReadLine());
            }

}
    }

