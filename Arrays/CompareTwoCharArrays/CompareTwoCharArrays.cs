//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

    class CompareTwoCharArrays
    {
        static void Main(string[] args)
        {
            bool equal = true;
            Console.WriteLine("Please enter arrays length");
            int n = int.Parse(Console.ReadLine());
            char[] firstArray = new char[n];
            char[] secondArray = new char[n];
            //Enter arrays
            Console.WriteLine("Please enter {0} numbers of first array:", n);
            for (int index = 0; index < n; index++)
            { firstArray[index] = char.Parse(Console.ReadLine()); }
            Console.WriteLine("Please enter {0} numbers of second array:", n);
            //Comapre arrays
            for (int indexTwo = 0; indexTwo < n; indexTwo++)
            { secondArray[indexTwo] = char.Parse(Console.ReadLine()); }
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
