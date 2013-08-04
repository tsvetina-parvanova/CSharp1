using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please,enter first number:");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please,enter second number:");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        if (Math.Abs(firstNumber-secondNumber)<0.000001M) { Console.WriteLine("Numbers are equal with precision of 0.000001"); }
        else Console.WriteLine("Numbers are not equal");
    }
}

