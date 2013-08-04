//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.

using System;

    class UserName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Name(name);
            
         }
        static void Name(string name)
        {
            
            Console.WriteLine("Hello,{0}",name);
        }
    }

