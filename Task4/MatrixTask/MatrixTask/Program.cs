using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTask
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrixtask = new int[2, 2];
            Console.WriteLine("Enter 4 numbers:  ");
            for (int i = 0; i < matrixtask.GetLength(0); i++)
            {
                for (int x = 0; x < matrixtask.GetLength(1); x++)
                {
                    matrixtask[i, x] = int.Parse(Console.ReadLine());
                    if (matrixtask[i, x] % 2 == 1)
                    {
                        matrixtask[i, x] *= 2;
                    }

                }

            }
            for (int i = 0; i < matrixtask.GetLength(0); i++)
            {
                for (int x = 0; x < matrixtask.GetLength(1); x++)
                {
                    Console.Write(matrixtask[i, x] + " ");

                }
                Console.WriteLine();

            }
        }
    }
}
