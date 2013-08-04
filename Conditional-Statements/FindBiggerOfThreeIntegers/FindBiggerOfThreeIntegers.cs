using System;

class FindBiggerOfThreeIntegers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        int bigger=firstNumber;
        if (bigger < secondNumber)
        {
            bigger = secondNumber;
        }
        if (bigger < thirdNumber)
        {
            bigger = thirdNumber;
        }
        Console.WriteLine("The bigger number is:" + bigger);

    }
}

