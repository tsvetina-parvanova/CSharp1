using System;

class MarketingFirmRecord
{
    static void Main(string[] args)
    {
        string firstName;
        string familyName;
        byte age;
        char gender;
        long idNumber;
        long employNumber;
        Console.WriteLine("Please enter first name:");
        firstName = Console.ReadLine();

        Console.WriteLine("Please enter family name:");
        familyName = Console.ReadLine();

        Console.WriteLine("Please enter your age: ");
        age = byte.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your gender - m or f: ");
        gender = char.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your ID number: ");
        idNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Please enter your unique employee number: ");
        employNumber = long.Parse(Console.ReadLine());

        Console.WriteLine("Information about {0} {1}",firstName,familyName);
        Console.WriteLine("Age:"+ age);
        if(gender=='m')
        { Console.WriteLine("Male");}
        else 
            if(gender=='f')Console.WriteLine("Female");
            else Console.WriteLine("error");
        Console.WriteLine("ID number: "+ idNumber);
        Console.WriteLine("Unique employee number: " + employNumber);


    }
}
