//Sort 3 real values in descending order using nested if statements.

using System;

class SortThreeValues
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        int change;
        if (firstNumber > secondNumber)
        {
            change = firstNumber;
            firstNumber = secondNumber;
            secondNumber = change;
            Console.WriteLine(firstNumber + " "  + secondNumber  + " " + thirdNumber);
        }
        if (secondNumber > thirdNumber)
        {
            change = secondNumber;
            secondNumber = thirdNumber;
            thirdNumber = change;
            Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber);
        }
        if (firstNumber > thirdNumber)
        {
            change = firstNumber;
            firstNumber = thirdNumber;
            thirdNumber = change;
        }

        if (firstNumber > secondNumber)
        {
            change = firstNumber;
            firstNumber = secondNumber;
            secondNumber = change;
            Console.WriteLine(firstNumber + " " + secondNumber + " " + thirdNumber);
        }
        Console.WriteLine("Numbers are:" + firstNumber + " " + secondNumber + " " + thirdNumber);


    }
}
