using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
