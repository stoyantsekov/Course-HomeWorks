using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1MinMax
{
    class Program   //Not ready
    {
        static void Main(string[] args)
        {
            int[] ourArray = new int[10] { 300, 4, 400, 30, 20, 110, 7,200, 40, 22 };
 
            int maxNumber = 0; 
            for (int i = 0; i < ourArray.Length; i++)
            {
                if (ourArray.Length%2!=0)
                {
                    if (ourArray[i] > maxNumber)
                    {
                        maxNumber = ourArray[i];
                    }
                }
            }

            int minNumber = 0; 

            for (int i = 0; i < ourArray.Length; i++)
            {
                if ((ourArray.Length%2 != 0))
                {
                    if (ourArray[i] > minNumber)
                    {
                        minNumber = ourArray[i];
                    }
                }
            }
            Console.WriteLine("Min number is: The Min is{0} and the Max is {1}", minNumber,maxNumber);
        }
    }
}
