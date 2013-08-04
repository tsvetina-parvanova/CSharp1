//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it.
//Use a sequence of if statements.

using System;

class ShowTheSign
{
    static void Main(string[] args)
    {
        //Enter three numbers
        Console.WriteLine("Please enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        //Check if they are equal
        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The number is 0");
        }
        else
            //Check different cases
        if (firstNumber > 0 && secondNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("The number is positive");
        }
        else
        if (firstNumber < 0 && secondNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("The number is negative");
        }
        else
            if ((firstNumber < 0 && secondNumber < 0 && thirdNumber > 0) || (firstNumber > 0 && secondNumber < 0 && thirdNumber < 0) || (firstNumber < 0 && secondNumber > 0 && thirdNumber < 0))
            {
                Console.WriteLine("The number is positive");
            }
            else
                if ((firstNumber > 0 && secondNumber > 0 && thirdNumber < 0) || (firstNumber > 0 && secondNumber < 0 && thirdNumber > 0) || (firstNumber < 0 && secondNumber > 0 && thirdNumber > 0))
                {
                    Console.WriteLine("The number is negative");
                }

    
 
    }
}