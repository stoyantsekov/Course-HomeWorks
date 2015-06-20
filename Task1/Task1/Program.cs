using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int a = int.Parse(Console.ReadLine());
            if (a >= 1 && a <= 5)
            {
                if (a % 2 == 0)
                    Console.WriteLine("The number is even");
                else
                    Console.WriteLine("The number is odd");
            }
            else if (a >= 6 && a <= 15)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine("Dived by 3 without");
                }
            }
            else
            {
                if (a > 0)
                    Console.WriteLine("The number is above 0");

                if (a < 0)
                    Console.WriteLine("The number is below 0");

                if (a == 0)
                    Console.WriteLine("The number is equal to 0");
            }
            }

        }
    }

