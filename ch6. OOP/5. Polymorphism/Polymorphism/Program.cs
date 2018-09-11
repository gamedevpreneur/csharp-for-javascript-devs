using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Rabbit
    {
        public /* virtual */ void ThrowCarrot()
        {
            Console.WriteLine("Throw one carrot.");
        }
    }

    class BossRabbit : Rabbit
    {
        public /* override */ void ThrowCarrot()
        {
            Console.WriteLine("Throw 3 carrots.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            rabbit.ThrowCarrot(); // throw one carrot. 
            Rabbit bossRabbit = new BossRabbit();
            bossRabbit.ThrowCarrot(); // throw 3 carrots. 
        }
    }
}
