using System;

class MyAgeAfter10Years
{
    static void Main(string[] args)
    {
        Console.WriteLine("Your Years Now:");
        int YearsNow = int.Parse(Console.ReadLine());
        int AgeInTenYears = YearsNow + 10;
        Console.Write("After 10 years you will be " + AgeInTenYears + " years old");

    }
}


