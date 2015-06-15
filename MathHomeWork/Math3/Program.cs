using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pick number:  ");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Pick agan:  ");
            float y = float.Parse(Console.ReadLine());
            float s = x / y;
            Console.WriteLine("Let's see the result:   ");
            Console.WriteLine(s);
        }
    }
}