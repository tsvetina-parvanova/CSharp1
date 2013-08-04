//Write a program that finds the greatest of given 5 variables.

using System;

class FindGreaterOfFiveVariables
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter 5 numbers :");
        int oneNumber = int.Parse(Console.ReadLine());
        int twoNumber = int.Parse(Console.ReadLine());
        int threeNumber = int.Parse(Console.ReadLine());
        int fourNumber = int.Parse(Console.ReadLine());
        int fiveNumber = int.Parse(Console.ReadLine());
        int biggest = oneNumber;
        if (twoNumber > biggest)
        {
            biggest = twoNumber;
        }
        if (threeNumber > biggest)
        {
            biggest = threeNumber;
        }
        if (fourNumber > biggest)
        {
            biggest = fourNumber;
        }
        if (fiveNumber > biggest)
        {
            biggest = fiveNumber;
        }
        Console.WriteLine("The biggest number is {0}", biggest);
    }
}