using System;

namespace GetAClue.Models
{
    public class Answer
    {
        //instantiated outside for true random numbers
        private Random _random = new Random();

        public string AnswerGenerator(string[] murderOption, int maxNumberOfOptions)
        {
            int generateRandomNumber = _random.Next(1, maxNumberOfOptions);
            return murderOption[generateRandomNumber];
        }

        public string AnswerWeapon()
        {
            string[] weapons =
            {
                "Candlestick",
                "Revolver",
                "Knife",
                "Lead Pipe",
                "Wrench"
            };

            return AnswerGenerator(weapons, 5);
        }

        public string AnswerSuspect()
        {
            string[] suspects =
            {
                "Colonel Mustard",
                "Mr Green",
                "Professor Plum",
                "Miss Scarlet",
                "Mrs Peacock",
                "Mrs White"
            };

            return AnswerGenerator(suspects, 6);
        }

        public string AnswerRoom()
        {
            string[] rooms =
            {
                "Lounge",
                "Study",
                "Hall",
                "Library",
                "Dining Room",
                "Kitchen",
                "Ballroom",
                "Conservatory",
                "Billiard Room"
            };
            return AnswerGenerator(rooms, 9);
        }
    }
}
