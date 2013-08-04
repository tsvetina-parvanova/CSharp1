using System;

    class SortStrings
    {
static void Main(string[] args)
        {
            string[] stringArray = { "hi", "hello", "Lqlqlq", "hoh", "nanananan","j" };
 
            SortBySize(stringArray);
        }
 
        static void SortBySize(string[] stringArray)
        {
            int n = stringArray.Length;
            int[] sizes = new int[n];              
 
            for (int i = 0; i < n; i++)
            {
                sizes[i] = stringArray[i].Length;
            }
 
            Array.Sort(sizes, stringArray);       
            foreach (var element in stringArray)
            {
                Console.WriteLine(element);
            }
 
 
        }
    }
