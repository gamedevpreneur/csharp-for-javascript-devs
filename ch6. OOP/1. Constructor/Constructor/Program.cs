using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Player
    {
        public Player(string name)
        {
            this.name = name;
        }

        public string name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("Kirito");
            Console.WriteLine(p.name);
        }
    }
}
