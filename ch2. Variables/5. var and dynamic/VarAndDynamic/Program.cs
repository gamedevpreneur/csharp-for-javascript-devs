using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarAndDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 4; // type of a became int. 
            a = 10; // OK
            // a = "Princess Peach"; // Compile error

            dynamic a2 = 1;
            a2 = "Portal";

            dynamic a3 = new ExpandoObject();
            a3.name = "Bowser";
            Console.WriteLine(a3["name"]); // RuntimeBinderException
        }
    }
}
