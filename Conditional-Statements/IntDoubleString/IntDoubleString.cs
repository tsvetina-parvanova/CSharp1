//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is 
//integer or double, increases it with 1. If the variable is string, appends "*" at its end.
//The program must show the value of that variable as a console output. Use switch statement.

using System;

    class IntDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 1 for Int , 2 for Double , 3 for String");
            int key= int.Parse(Console.ReadLine());
            switch (key)
            {
                case 1:
                    int intCase = int.Parse(Console.ReadLine());
                    Console.WriteLine(intCase + 1);
                    break;
                case 2:
                    double doubleCase = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleCase + 1);
                    break;
                case 3:
                    string stringCase = Console.ReadLine();
                    Console.WriteLine(stringCase + '*');
                    break;
                default: Console.WriteLine("ERROR");
                    break;


            }
        }
    }

