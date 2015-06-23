using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divideby7or11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:  ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                if ((i % 7 == 0) || (i % 11 == 0))
                    Console.WriteLine(i);
            }
        }
    }
}
