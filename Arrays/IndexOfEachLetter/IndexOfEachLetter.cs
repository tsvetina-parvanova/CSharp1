//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

using System;

    class IndexOfEachLetter
    {
        static void Main(string[] args)
        {

            char[] array = new char[26];
            string word = (Console.ReadLine().ToLower());

            for (int i = 0; i < 26; i++)
            {
                array[i] = Convert.ToChar('a' + i);
            }

            for (int J = 0; J < word.Length; J++)
            {
                Console.WriteLine("{0} [{1}]", word[J], word[J] - 'a');
            }    
        }
    }
