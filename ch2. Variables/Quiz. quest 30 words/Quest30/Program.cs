using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest30
{
    class Program
    {
        static void Main(string[] args)
        {
            string questMessage =
                "This letter quest has been started in England 200 years ago. " +
                "And this letter gave happiness to its recipients. " +
                "Unfortunately, this letter should leave your hands in 4 days. " +
                "Otherwise, the happiness will become an unreversible misery.";

            string summary = questMessage.Substring(0, 30);

            Console.WriteLine(summary);
        }
    }
}
