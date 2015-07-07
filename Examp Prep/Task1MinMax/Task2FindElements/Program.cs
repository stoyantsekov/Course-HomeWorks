using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2FindElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 5, 6, 8, 9 };
            int[] second = new int[] { 3, 5, 2, 7, 1 };
            for (int i = 0; i < first.Length; i++)
            {
                for (int y = 0; y < second.Length; y++)
                {
                    if (first[i] == second[y])
                    {
                        Console.WriteLine(first[i]);
                        break;
                    }
                }
            }
        }
    }
}
