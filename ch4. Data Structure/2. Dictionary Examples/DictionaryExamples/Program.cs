using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExamples
{
    class Player { }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            items["gun"] = 200;
            items["sword"] = 500;

            var players = new Dictionary<string, Player>();
            players["mario"] = new Player();
            players.Add("sonic", new Player());
            players.ContainsKey("link"); // false
            players.Remove("mario");

            foreach (var pair in items)
            {
                Console.WriteLine("{0} : {1}", pair.Key, pair.Value);
            }

            foreach (var key in items.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var val in items.Values)
            {
                Console.WriteLine(val);
            }
        }
    }
}
