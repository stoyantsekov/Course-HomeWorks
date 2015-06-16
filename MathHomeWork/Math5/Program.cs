using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you first name? -     ");
              string a = Console.ReadLine();
            Console.WriteLine("What is you last name? -     ");
              string b = Console.ReadLine();
              string names = a + "_" + b;
            Console.WriteLine(names);
        }
    }
}
