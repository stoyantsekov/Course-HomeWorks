using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your game score:");
            int numBonus = int.Parse(Console.ReadLine());
            if (numBonus >= 1 && numBonus <= 3)
            {
                Console.WriteLine(numBonus * 5);
            }
            else if (numBonus >= 4 && numBonus <= 6)
            {
                Console.WriteLine(numBonus * 10);
            }
            else if (numBonus >= 7 && numBonus <= 9)
            {
                Console.WriteLine(numBonus * 50);
            }
            else
            {
                Console.WriteLine("Enter value between 1-9 only");
            }
        }
    }
}
