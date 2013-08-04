//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such 
//that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.


using System;
using System.Globalization;
using System.Text;
using System.Threading;

class NumbersDividedByFive
{
    static void Main(string[] args)
    {
        Thread.CurrentThread.CurrentCulture =
  CultureInfo.InvariantCulture;

        Console.WriteLine("Please enter first positive number:");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter second positive number:");
        int secondNumber = int.Parse(Console.ReadLine());

        int change;
        int count=0;
        if (firstNumber > secondNumber) { change = firstNumber; firstNumber = secondNumber; secondNumber = change; }
        if(firstNumber < 0 ||secondNumber < 0)   {Console.WriteLine("Error.You must enter positive integer number:");}
        int i = firstNumber;
        do
        {
            if (i % 5 == 0)
            { count++; }
            i++;
        }
        while (firstNumber <= i && i <= secondNumber);
        Console.WriteLine("The number of numbers divided by five between {0} and {1} is: {2}", firstNumber,secondNumber,count);

    }
}