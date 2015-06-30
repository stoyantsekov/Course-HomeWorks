using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[4];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i] = int.Parse(Console.ReadLine());
            }
            PrintBackwards(Numbers);
        }
        private static void PrintBackwards(int[] Numbers)
        {
            for (int i = Numbers.Length - 1; i > -1; i--)
            {
                Console.WriteLine(Numbers[i]);
            }
        }


    }
}
