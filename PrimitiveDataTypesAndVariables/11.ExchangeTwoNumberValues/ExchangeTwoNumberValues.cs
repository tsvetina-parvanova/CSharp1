using System;

class ExchangeTwoNumberValues
{
    static void Main(string[] args)
    {
        int numberOne = 5;
        int numberTwo = 10;
        int change;
        change = numberOne;
        numberOne = numberTwo;
        numberTwo = change;
        Console.WriteLine(numberOne + " " + numberTwo);

    }
}

