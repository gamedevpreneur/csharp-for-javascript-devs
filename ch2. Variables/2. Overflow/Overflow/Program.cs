using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 2147483647; // int maximum
            int min = -2147483648;

            Console.WriteLine("Max + 1 is min: {0}", max + 1 == min);
            Console.WriteLine("Min - 1 is max: {0}", min - 1 == max);
        }
    }
}
