//Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

    class RevrsesDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number thet you want to reverse");
            int number = int.Parse(Console.ReadLine());
            if (number > 0 && number < 9) { Console.WriteLine( "The digit cannot be reversed" ); }
            number = ReverseNumber(number);
        }

        private static int ReverseNumber(int number)
        {
            int remainder;
            int reversed = 0;
            while (number > 0)
            {
                remainder = number % 10;
                number = number / 10;
                reversed = reversed * 10 + remainder;

            }
            Console.WriteLine(reversed);
            return number;
        }

    }

