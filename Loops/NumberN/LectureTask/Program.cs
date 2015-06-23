using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureTask
{
    class Program
    {
        static void Main(string[] args)
        {

            //Not ready yet...
            int first = Console.Read();
            Console.WriteLine("Enter a number");
            int counter = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            int seccounter = int.Parse(Console.ReadLine());
            int result = counter + seccounter;

            do
            {

                Console.Write(result);
                Console.WriteLine();
            }
            while (true);
        }
    }
}
