using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int i, j;

            for (i = 2; i < 1000; i++)
            {
                for (j = 2; j <= (i/j); j++)
                {
                    //when prime
                    if ((i%j) == 0) break; 
                }
                if (j > (i/j))
                {
                    Console.WriteLine("Prime Number : {0}", i);
                }
            }
            Console.ReadLine();
        }
    }
}