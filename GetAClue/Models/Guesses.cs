using System.Linq;
using System.Text.RegularExpressions;

namespace GetAClue.Models
{
    public class Guesses
    {
        public string CheckIfAnswer(string guess, string answer)
        {
            string display = string.Empty;

            var guesses = Regex.Split(guess, "\n");
            var matches = guesses.Count(c => c == answer);

            if (matches > 0)
                display = "*";
            else
                display = guess;

            return display;
        }

        public string DisplayGuesses(bool radioButton, string radioButtonName)
        {
            string display = string.Empty;

            if (radioButton)
            {
                display = radioButtonName;
            }
            return display;
        }
    }
}
