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

            int a = 7;
            int b = 8;
            int c = Total(a, b);
            Console.WriteLine(c);
        }
        public static int Total(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}