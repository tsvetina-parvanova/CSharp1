﻿//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

using System;

    class LastDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            int number=int.Parse(Console.ReadLine());
            
             number = number % 10; 
            LastDigitNum(number);
        }

        static void LastDigitNum(int number)
        {
            switch (number)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                case 6: Console.WriteLine("Six");
                    break;
                case 7: Console.WriteLine("Seven");
                    break;
                case 8: Console.WriteLine("Eight");
                    break;
                case 9: Console.WriteLine("Nine");
                    break;
                default: Console.WriteLine("error");
                    break;
            }


        }
    }

