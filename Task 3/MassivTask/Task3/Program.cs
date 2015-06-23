using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < first.Length/2; i++)
            {
                int temp;
                temp = first[i];
                first[i] = first[first.Length - 1 - i];
                first[first.Length - 1 - i] = temp;
            }
            foreach (int item in first)
            {
                Console.WriteLine(item);
            }
        }
    }
}
