using System.Linq;
using System.Text.RegularExpressions;

namespace GetAClue.Models
{
    public class GameOver
    {
        public bool CheckIfCorrect(string guess)
        {
            bool isCorrect = false;

            var words = Regex.Split(guess, "\n");
            var find = words.Count(c => c == "*");

            if (find > 0)
            {
                isCorrect = true;
            }
            return isCorrect;
        }

        public bool IfGameOverDisplay(string roomGuess, string weaponGuess, string suspectGuess)
        {
            bool allAreCorrect = CheckIfCorrect(roomGuess) && CheckIfCorrect(weaponGuess) && CheckIfCorrect(suspectGuess);
            return allAreCorrect;
        }
    }
}
