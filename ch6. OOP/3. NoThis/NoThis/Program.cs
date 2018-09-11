using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoThis
{
    class Player
    {
        public Player(string name)
        {
            this.name = name;
            hp = 300;
        }

        public void GotAttack(int attackPoint)
        {
            hp -= attackPoint;
        }

	    public string name;
        public int hp;
    };

    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("Asuna");
            p.GotAttack(50);
            Console.WriteLine(p.hp);
        }
    }
}
