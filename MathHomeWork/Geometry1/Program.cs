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
            Console.WriteLine("Let's do some geometry :)");
            Console.Write("Write a number for a triangle's side:   ");
              float x = float.Parse(Console.ReadLine());
            Console.Write("Now let's choose value for the triangle's height:  ");
              float y = float.Parse(Console.ReadLine());
              float s = (x * y) / 2;
            Console.WriteLine("Let's see the result for this formula:   ");
            Console.WriteLine(s);
        }
    }
}
