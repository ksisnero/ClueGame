using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace GetAClue.Models
{
    class CheckForAnswer
    {
        public string CheckIfAnswer(string guess, string answer)
        {
            string display = String.Empty;

            var words = Regex.Split(guess, "\n");
            var find = words.Count(c => c == answer);

            if (find > 0)
            {
                display = "*";
            }
            else
            {
                display = guess;
            }

            return display;
        }
    }
}
