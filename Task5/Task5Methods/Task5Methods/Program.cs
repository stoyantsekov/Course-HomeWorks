using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            Total(a, b);
        }
        public static void Total(int first, int second)
        {
            int result = first + second;
            Console.WriteLine(result);
        }
    }
}