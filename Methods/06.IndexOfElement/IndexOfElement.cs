//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Linq;
    class FirstElement
    {
        static void Main()
        {
            Console.WriteLine("Please enter number of numbers in array:");
            int arrayLenght = int.Parse(Console.ReadLine());
            int[] array = new int[1000];
            ReadArray(arrayLenght, array);
            Console.WriteLine("The first element that is bigger than its neighbors has index:{0}.",BiggerThanItsNeighbours(array));
      }

        private static void ReadArray(int arrayLenght, int[] array)
        {
            for (int index = 0; index < arrayLenght; index++)
            {
                Console.WriteLine("Please enter {0} number", index + 1);
                array[index] = int.Parse(Console.ReadLine());
            }
        }
        static int BiggerThanItsNeighbours(int[] array)
        {
            int firstMax = 0;
            for (int i = 1; i < array.Length-1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    firstMax = i;
                    break;
                }
                else
                    {
                        firstMax = -1;
                    }
                
            }
            return firstMax;
        }
    }

                          

 
    

