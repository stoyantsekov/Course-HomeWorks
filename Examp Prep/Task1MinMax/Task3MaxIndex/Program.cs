using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3MaxIndex  //without index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have the following matrix:  ");
            int[,] naturalArr = new int[,] { { 2, 4, 80 },
                                           { 7, 20, 30 },
                                           { 40, 1, 7 }
                                                       };
            int Min = naturalArr[0,0];
            int Max = naturalArr[0,0];

            for (int i = 0; i < naturalArr.GetLength(0); i++)
            {
                for (int y = 0; y < naturalArr.GetLength(1); y++)
                {
                    Console.Write("   " + naturalArr[i, y]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < naturalArr.GetLength(0); i++)
            {
                for (int y = 0; y < naturalArr.GetLength(1); y++)
                {
                    if (naturalArr[i, y] == 0)
                    {
                        Max = naturalArr[i, y];
                        Min = naturalArr[i, y];
                    }
                    else if (naturalArr[i,y]>Max)
                    {
                        Max = naturalArr[i, y];
                    }
                    else if (naturalArr[i, y] < Min)
                    {
                        Min = naturalArr[i, y];
                    }
                }
            }
            Console.WriteLine("The max element of your array is {0}", Max);
            Console.WriteLine("The min element of your array is {0}", Min);
        }
    }
}
