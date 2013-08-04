//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;

    class BiggerOfTwoNeighbours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number you want to check:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number of numbers in array:");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = new int[1000];
            ReadArray(arrayLenght, array);
            CheckCountNumber(number, arrayLenght, array);
            CheckIfItsBiggerThanItsNeighbours(number, arrayLenght, array);
            }
// check if there are more than one numbers "number" in array
        private static void CheckCountNumber(int number, int arrayLenght, int[] array)
        {
            int count = 0;
            for (int index = 0; index < arrayLenght; index++)
            {
                if (array[index] == number) count++;

            }
            if(count>1)
            Console.WriteLine("There is more than one number {0} in array", number);
                 }
//check which of numbers is bigger 
        private static void CheckIfItsBiggerThanItsNeighbours(int number, int arrayLenght, int[] array)
        {
            if (number == array[0])
            {
                if (array[1] < number) Console.WriteLine("The number {0} is bigger than its neighbour {1}", number, array[1]);
                else
                    Console.WriteLine("The number {0} is smaller than its neighbour {1}", number, array[1]);
                return;
            }

            if (number == array[arrayLenght - 1])
            {
                if (array[arrayLenght - 2] < number) Console.WriteLine("The number {0} is bigger than its neighbour {1}", number, array[arrayLenght - 2]);
                else
                    Console.WriteLine("The number {0} is smaller than its neighbour {1}", number, array[arrayLenght - 2]);
                return;

            }
            for (int index = 0; index < arrayLenght; index++)
            {

                if (array[index] == number)
                {
                    if (array[index] > array[index + 1] && array[index] > array[index - 1])
                    {
                        Console.WriteLine("The number {0} is bigger than its neighbours ", number);
                    }
                    else
                        if (array[index] < array[index + 1] && array[index] > array[index - 1])
                        {
                            Console.WriteLine("The number {0} is smaller than its neighbour {1} and bigger than its neighbour {2} ", number, array[index + 1], array[index - 1]);
                        }
                        else
                            if (array[index] > array[index + 1] && array[index] < array[index - 1])
                            {
                                Console.WriteLine("The number {0} is smaller than its neighbour {1} and bigger than its neighbour {2}", number, array[index - 1], array[index + 1]);
                            }
                }
            }
            Console.WriteLine("There is not such a number");
        }

        //read array
        private static void ReadArray(int arrayLenght, int[] array)
        {
            for (int index = 0; index < arrayLenght; index++)
            {
                Console.WriteLine("Please enter {0} number", index + 1);
                array[index] = int.Parse(Console.ReadLine());
            }

        }
    }

