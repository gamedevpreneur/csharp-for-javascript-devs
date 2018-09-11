using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(3.14f, 2.718f));
            Console.WriteLine(Add("Hello", "World"));
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static float Add(float a, float b)
        {
            return a + b;
        }

        static string Add(string a, string b)
        {
            return a + b;
        }
    }
}
