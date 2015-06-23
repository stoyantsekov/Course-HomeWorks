using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ourArr = new int[] { 1, 2, 3, 7, 5 };
            foreach (int item in ourArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
