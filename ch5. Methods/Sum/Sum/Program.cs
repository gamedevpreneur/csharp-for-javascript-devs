using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(10));
            Console.WriteLine(Sum(1, 10));
        }

        static int Sum(int end)
        {
            return Sum(0, end);
        }

        static int Sum(int start, int end)
        {
            int s = 0;

            for (int i = start; i <= end; i++)
            {
                s += i;
            }

            return s;
        }
    }
}
