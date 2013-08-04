//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

class quickSort
{
    class quick
    {

        static void Main()
        {
            string[] array = { "a", "dbca", "b", "abda", "addd", "abc" };
            QuickSort(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static int Partition(string[] array, int p, int r)
        {
            string x = array[r];
            int i = p - 1;
            string temp = "";
            for (int j = p; j < r; j++)
            {
                if (string.Compare(array[j], x) < 0)
                {
                    i = i + 1;
                    //swap stringArr[i] with stringArr[j]
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            //swap stringArr[i+1] with stringArr[r]
            temp = array[i + 1];
            array[i + 1] = array[r];
            array[r] = temp;

            return i + 1;
        }

        static void QuickSort(string[] array, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(array, p, r);
                QuickSort(array, p, q - 1);
                QuickSort(array, q + 1, r);
            }
        }
    }
}
       
