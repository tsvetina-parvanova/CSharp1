﻿//Write a program that prints all the numbers from 1 to N.
using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");
        int number=int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        { 
            Console.WriteLine(i);
        }
    }

}
