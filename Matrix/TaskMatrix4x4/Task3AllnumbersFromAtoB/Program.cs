using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3AllnumbersFromAtoB
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number for A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for B (B>A): ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
