using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5MatrixVerticalFirst
{
    class Program
    {
        static void Main(string[] args)  //Not Ready :(
        {
 
            Console.WriteLine("Please enter the first dimenssion of you matrix:  ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second dimenssion of you matrix:  ");
            int b = int.Parse(Console.ReadLine());
            int[,] firstArray = new int[a, b];

   
            Console.WriteLine("Now let's fill you matrix {0} by {1} now : ", a , b );
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int y = 0; y < firstArray.GetLength(1); y++)
                {
                    //if (y==i)
                    //{
                    //    if (y!=i)
                    //    {
                            firstArray[i,y] = int.Parse(Console.ReadLine());
                    //    }
                    //}
                }
            }
            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int y = 0; y < firstArray.GetLength(1); y++)
                {
                    Console.Write(firstArray[i, y]);
                }
                Console.WriteLine();
            }

        }
    }
}
