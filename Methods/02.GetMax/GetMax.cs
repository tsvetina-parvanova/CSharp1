//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().
using System;

    class GetMax
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 3 numbers");
            Console.WriteLine("Number 1:");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2:");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 3:");
            int numberThree = int.Parse(Console.ReadLine());
            int maxOne = GetMaxNum(numberOne, numberTwo);
            int max = GetMaxNum(maxOne, numberThree);
            Console.WriteLine(max);
           
        }
        static int GetMaxNum(int number1, int number2)
        {
            int max = number1;
            if (number1 < number2)
            {
                max = number2;
            }
            return max;
            
               

        }
    }

