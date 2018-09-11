using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            string b = "abc";
            //char c = "1"; // ERROR. "1" is a string, not a character. 
            //string d = 's'; // ERROR. ‘s’ is a character, not a string. 
            string e = "e"; // CORRECT. "e" is a string with a single character. 

            string f = "I am fed up with \"Hello, World!\" examples.";

            string name = "Lara " + "Croft";

            int i = 1;
            int j = 2;
            string a2 = "" + i + " + " + j + " = " + (i + j);
            string b2 = string.Format("{0} + {1} = {2}", i, j, i + j);
            string c = $"{i} + {j} = {i + j}";

            Console.WriteLine(a2);
            Console.WriteLine(b2);
            Console.WriteLine(c);

            string name2 = "Mario";
            char a3 = name[0]; // a3 == 'M'

            string name4 = "Sonic the Hedgehog";
            string[] words = name4.Split(' '); // { "Sonic", "the", "Hedgehog" }
            int position = name4.IndexOf("the"); // 6
            string sub = name4.Substring(10); // Hedgehog
            bool isAmy = name4.StartsWith("Amy"); // false
            string trimmed = "	  Tails	  ".Trim(); // Tails
            string poke = "Pokemon Edition".Insert(8, "Pikachu "); // Pokemon Pikachu Edition
            string amy = name4.Replace("Sonic", "Amy"); // Amy the Hedgehog

            string s = "C# and JavaScript are different";
            string js = s.Substring(7, 10);

            Console.WriteLine(js);

            int a4 = Int32.Parse("5") * Convert.ToInt32("2");
        }
    }
}
