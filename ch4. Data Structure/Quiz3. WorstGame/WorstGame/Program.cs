using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorstGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> gameReviewScores = new Dictionary<string, int>();
            gameReviewScores["Super Mario Odyssey"] = 97;
            gameReviewScores["Legend of Zelda: Breath of the Wild"] = 97;
            gameReviewScores["Sonic Mania"] = 86;
            gameReviewScores["Sonic Forces"] = 99;

            gameReviewScores["Sonic Forces"] = 55;

            string worstGameName = "Super Mario Odyssey";
            int worstScore = gameReviewScores[worstGameName];

            foreach (var game in gameReviewScores)
            {
                if (game.Value < worstScore)
                {
                    worstScore = game.Value;
                    worstGameName = game.Key;
                }
            }

            Console.WriteLine("Worst game in 2017: " + worstGameName);
        }
    }
}
