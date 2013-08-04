using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScores
{
    class BonusScores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number from 1 to 9");
            int key = int.Parse(Console.ReadLine());
            switch(key)
            {   case 1:
                case 2:
                case 3: Console.WriteLine(key+10);
                    break;
                case 4:
                case 5:
                case 6: Console.WriteLine(key + 100);
                    break;
                case 7:
                case 8:
                case 9: Console.WriteLine(key + 1000);
                    break;
                default: Console.WriteLine("ERROR");
                    break;



            }

        }
    }
}
