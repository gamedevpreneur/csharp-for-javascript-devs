using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enemies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] enemies = { "Bowser", "Dr. Eggman", "Ganon", };

            Console.Write("Defeated enemies: ");

            for (int i = 0; i < enemies.Length; i++)
            {
                Console.Write(enemies[i]);

                if (i < (enemies.Length - 1))
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("");
        }
    }
}
