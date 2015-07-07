using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1ShowEvenMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] evenMatrix = new int[,] { { 1, 2, 3 },
                                             { 4, 5, 6 },
                                             { 7, 8, 9 }
                                                       };
            Console.WriteLine("Your current matrix is: ");
            for (int i = 0; i < evenMatrix.GetLength(0); i++)
            {
                for (int y = 0; y < evenMatrix.GetLength(1); y++)
                {
                    Console.Write("  " + evenMatrix[i, y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Let's see only the even numbers from your matrix");
            Console.WriteLine();
            for (int i = 0; i < evenMatrix.GetLength(0); i++)
            {
                for (int y = 0; y < evenMatrix.GetLength(1); y++)
                {
                    if (evenMatrix[i,y]%2==0)
                    {
                        Console.Write("   {0}",evenMatrix[i,y]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
