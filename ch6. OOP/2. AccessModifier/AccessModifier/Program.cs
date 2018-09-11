using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    class PlayerBase
    {
        protected string secretSkill = "Big magical hat";
    }

    class Player : PlayerBase
    {
        public Player(string name, string hiddenName)
        {
            this.name = name;
            this.hiddenName = hiddenName;
            secretSkill = "Star burst stream";
        }

        public void ShowHiddenName()
        {
            Console.WriteLine(this.hiddenName);
        }

        public string name;
        private string hiddenName;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("Kirito", "Krigaya Kazuto");
            Console.WriteLine(p.name);
            //Console.WriteLine(p.hiddenName); // COMPILE ERROR!
            p.ShowHiddenName(); // OK.
            //Console.WriteLine(p.secretSkill); // COMPILE ERROR!
        }
    }
}
