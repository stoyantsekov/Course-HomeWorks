using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a word? -     ");
            string a = Console.ReadLine();
            string b = a.Substring(a.Length - 1, 1);
            Console.WriteLine(b);
        }
    }
}
