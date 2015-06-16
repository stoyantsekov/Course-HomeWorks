using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number:   ");
              float a = int.Parse(Console.ReadLine());
              int b = (int)a;
            Console.WriteLine("Pick a number:   ");
              string c = Console.ReadLine();
              int bb = int.Parse(c);
              int cc = b/bb;
            Console.WriteLine(cc);
        }
    }
}
