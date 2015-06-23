using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassivTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ourCopy = new int[] { 1, 2, 3, 4, 5 };
            int[] newCopy = new int[ourCopy.Length];
            for (int i = 0; i < ourCopy.Length; i++)
            {
                newCopy[i] = ourCopy[i];
            }

            foreach (int item in newCopy)
            {
                Console.WriteLine(item);
            }

        }
    }
}
