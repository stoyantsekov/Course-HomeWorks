using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Matix3by4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ourMatrix = new int[3, 4];
            Console.WriteLine("Please fill your Matrix(3by4):  ");
            for (int i = 0; i < ourMatrix.GetLength(0); i++)
            {
                for (int y = 0; y < ourMatrix.GetLength(1); y++)
                {
                    ourMatrix[i, y] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("You have created the following Matrix:  ");
            for (int i = 0; i < ourMatrix.GetLength(0); i++)
            {
                for (int y = 0; y < ourMatrix.GetLength(1); y++)
                {
                    Console.Write("  " + ourMatrix[i,y]);
                }
                Console.WriteLine();
            }
        }
    }
}
