//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm.

using System;

class EuclideanAlgorithm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter first number");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number");
        int numberTwo = int.Parse(Console.ReadLine());
        int change;
        int remainder;
        if (numberOne < numberTwo)
        {
            change = numberOne;
            numberOne = numberTwo;
            numberTwo = change;
        }
        int result;
        while (true)
        {
            result = numberOne / numberTwo;
            remainder = numberOne % numberTwo;
            if (remainder != 0)
            {
                numberOne = numberTwo;
                numberTwo = remainder;
            }
            else
            {
                Console.WriteLine("The divider is:  " + numberTwo);
                break;
            }
        }

    }
}
