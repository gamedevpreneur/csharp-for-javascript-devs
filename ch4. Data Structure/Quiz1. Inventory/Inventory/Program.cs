using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            items["bomb"] = 5;
            items["arrow"] = 10;

            Console.WriteLine("One bomb has been used.");
            items["bomb"] -= 1;

            Console.WriteLine("Current Items:");
            foreach (var item in items)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
