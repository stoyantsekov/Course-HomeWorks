using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMatrix4x4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ourMatrix = new int[2, 2];
            Console.WriteLine("Enter numbers to fill the Array: ");
            for (int i = 0; i < ourMatrix.GetLength(0); i++)
            {
                for (int y = 0; y < ourMatrix.GetLength(1); y++)
                {
                    ourMatrix[i, y] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Your current matrix is:  ");
            for (int i = 0; i < ourMatrix.GetLength(0); i++)
            {
                for (int y = 0; y < ourMatrix.GetLength(1); y++)
                {
                    Console.Write("  " + ourMatrix[i, y]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < ourMatrix.GetLength(0); i++)
            {
                for (int y = 0; y < ourMatrix.GetLength(1); y++)
                {
                    if (ourMatrix[i,y]%2!=0)
                    {
                        ourMatrix[i, y] *= 2;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Your matrix with all the odd numbers converted to even");
            for (int i = 0; i < ourMatrix.GetLength(0); i++)
            {
                for (int y = 0; y < ourMatrix.GetLength(1); y++)
                {
                    Console.Write("  " + ourMatrix[i, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
