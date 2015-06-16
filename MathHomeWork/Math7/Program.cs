using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a word? -     ");
              string a = Console.ReadLine();
            Console.WriteLine("Pick a second word ? -     ");
              string b = Console.ReadLine();
              bool c = a.Contains(b);
            Console.WriteLine(b);
        }
    }
}
