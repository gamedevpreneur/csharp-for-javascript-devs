using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    class Player
    {
        public static int maxAttack = 50;
        public int normalAttack = 25;
        public void Attack()
        {
            Console.WriteLine("Normal Attack: " + normalAttack +
                " Max Attack: " + maxAttack);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new Player();
            Player p2 = new Player();

            p1.Attack();
            p1.normalAttack = 50;
            Player.maxAttack = 100;

            p2.Attack();
        }
    }
}
