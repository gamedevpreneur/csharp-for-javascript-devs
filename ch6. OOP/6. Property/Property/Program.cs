using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    class Prop
    {
        public int Value
        {
            get
            {
                return val;
            }
            set
            {
                if (value >= 100)
                {
                    value = 100;
                }

                this.val = value;
            }
        }

        private int val;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Prop p = new Prop();
            p.Value++;
            Console.WriteLine(p.Value); // 1
            p.Value = 300;
            Console.WriteLine(p.Value); // 100
        }
    }
}
