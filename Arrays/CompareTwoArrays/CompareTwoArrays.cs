//Write a program that reads two arrays from the console and compares them element by element.

using System;

    class CompareTwoArrays
    {
        static void Main(string[] args)
        {
            bool equal=true;
            Console.WriteLine("Please enter arrays length");
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            //Enter arrays
            Console.WriteLine("Please enter {0} numbers of first array:",n);
            for (int index = 0; index < n; index++)
            { firstArray[index] = int.Parse(Console.ReadLine()); }
            Console.WriteLine("Please enter {0} numbers of second array:", n);
            //Comapre arrays
            for (int indexTwo = 0; indexTwo< n; indexTwo++)
            { secondArray[indexTwo] = int.Parse(Console.ReadLine()); }
            for (int index = 0; index < n; index++)
            {
                    if (firstArray[index] != secondArray[index])
                     equal = false; 
            }
            //Check and print
            if (equal) { Console.WriteLine("The arrays are equal"); }
            else Console.WriteLine("The arrays are different");
            

        }
    }






