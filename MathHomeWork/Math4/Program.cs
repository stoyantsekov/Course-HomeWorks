using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number:  ");
              string a = Console.ReadLine();
              int aa = int.Parse(a);
            Console.WriteLine("Pick a second number:  ");
              string b = Console.ReadLine();
              int bb = int.Parse(b);
            Console.WriteLine(aa/bb);
        }
    }
}
