using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task430Backwards
{
    class Program     // Not READY :(
    {
        static void Main(string[] args)
        {
            int[,] ourArray = new int[6, 5] { { 1, 2, 3, 4, 5 },
                                             { 6, 7, 8, 9, 10 },
                                         { 11, 12, 13, 14, 15 },
                                         { 16, 17, 18, 19, 20 },
                                         { 21, 22, 23, 24, 25 },
                                         { 26, 27, 28, 29, 30 }
                                                              };

            Console.WriteLine("We have created the following matrix  :");
            for (int i = 0; i < ourArray.GetLength(0); i++)
            {
                for (int y = 0; y < ourArray.GetLength(1); y++)
                {
                    Console.Write("   " + ourArray[i, y]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Let's see our matrix displayed backwards: ");

            for (int i = 0; i <= ourArray.GetUpperBound(0); i++)
            {
                for (int y = 0; y <= ourArray.GetLowerBound(1); y++)
                {
                    int temp = ourArray[i, y];
                    ourArray[i, y] = ourArray[i, ourArray.GetUpperBound(1) - y];
                    ourArray[i, ourArray.GetUpperBound(1) - y] = temp;
                }
            }
            for (int i = 0; i < ourArray.GetLength(0); i++)
            {
                for (int y = 0; y < ourArray.GetLength(1); y++)
                {
                    Console.Write("   " + ourArray[i, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
