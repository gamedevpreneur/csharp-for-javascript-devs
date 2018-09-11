using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            if ("1" == 1)
            {
                Console.WriteLine("\"1\" == 1 is false in C#.");
            }

            int a = 1;

            if (a = 2)
            {
                Console.WriteLine("Compile Error!");
            }
            //*/


            string s = "";
            string n = null;

            if (s == "")
            {
                Console.WriteLine("String is empty");
            }

            if (n == null)
            {
                Console.WriteLine("Null Object");
            }


            bool someProblem = false;

            if (someProblem)
            {
                throw new Exception("You should wrap it with Exception in C#");
            }



            int sum = 0;

            for (int i = 0; i < 100; i++)
            {
                sum += i;
            }


            string[] enemies = { "Bowser", "Dr. Eggman", "Ganon", };

            foreach (string enemy in enemies)
            {
                Console.WriteLine(enemy);
            }
        }
    }
}
