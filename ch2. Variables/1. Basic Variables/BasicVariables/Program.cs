using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 12;
            string name = "Lara Croft";

            age = new object(); // ERROR!
            name = 1234; // ERROR!
        }
    }
}
