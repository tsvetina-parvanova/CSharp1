//Write an if statement that examines two integer variables and exchanges their values if the first
//one is greater than the second one.

using System;

class ExchangeNumbersValues
{
    static void Main(string[] args)
    {
        //Enter two numbers
        Console.WriteLine("Please enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        int change;
        //check if first is bigger than second and if it is true exchange their values
        if (firstNumber > secondNumber)
        { change = firstNumber;
        firstNumber = secondNumber;
        secondNumber = change;
        }
        Console.WriteLine("The smaller number is {0} and the bigger number is {1}",firstNumber,secondNumber);

    }
}
