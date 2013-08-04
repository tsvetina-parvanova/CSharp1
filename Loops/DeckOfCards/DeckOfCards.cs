//Write a program that prints all possible cards from a standard deck of 52 cards (without jokers).
//The cards should be printed with their English names. Use nested for loops and switch-case.



using System;

class DeckOfCards
{
    static void Main()
    {

        for (int i = 2; i <= 14; i++)
        {

            for (int j = 0; j < 4; j++)
            {
                string color = "";
                switch (j)
                {
                    case 0:
                        color = "Clubs";
                        break;
                    case 1:
                        color = "Diamonds";
                        break;
                    case 2:
                        color = "Hearts";
                        break;
                    case 3:
                        color = "Spades";
                        break;
                    default:
                        Console.WriteLine("There is some mistake!");
                        break;
                }
                switch (i)
                {

                    case 1:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 2:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 3:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 4:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 5:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 6:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 7:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 8:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 9:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 10:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 11:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 12:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 13:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;
                    case 14:
                        Console.WriteLine("{0} of {1}", i, color);
                        break;

                }
            }
        }
    }
}


