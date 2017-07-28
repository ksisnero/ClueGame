using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GetAClue.Models
{
    class GameOver
    {
        public bool Check(string guess)
        {
            bool isFound = false;

            var words = Regex.Split(guess, "\n");
            var find = words.Count(c => c == "*");

            if (find > 0)
            {
                isFound = true;
            }
            return isFound;
        }

        public bool GameOverDisplay(string roomGuess, string weaponGuess, string suspectGuess)
        {
            bool results = Check(roomGuess) && Check(weaponGuess) && Check(suspectGuess);
            return results;
        }
    }
}
