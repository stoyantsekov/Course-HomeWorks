using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stepen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            int result = 1;

            for (int i = 1; i <= m; i++)
            {
                result *= n;
            }

            Console.WriteLine("{0}! = {1}", n, result);
        }
    }
}
