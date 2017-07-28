using System;

namespace GetAClue.Models
{
    public class GenerateAnswer
    {
        //instantiated outside for true random numbers
        public static Random Randomizer = new Random();

        public string AnswerGenerator(string[] murderOption, int maxNumberOfOptions)
        {
            int generateRandomNumber = Randomizer.Next(1, maxNumberOfOptions);
            return murderOption[generateRandomNumber];
        }

        //public string AnswerWeapon()
        //{
        //    string[] weapons =
        //    {
        //        "Candlestick",
        //        "Revolver",
        //        "Knife",
        //        "Lead Pipe",
        //        "Wrench"
        //    };
            
        //    int generateRandomWeapon = Randomizer.Next(1, 5);
        //    return weapons[generateRandomWeapon];
        //}

        //public string AnswerPeople()
        //{
        //    string[] suspects =
        //    {
        //        "Colonel Mustard",
        //        "Mr Green",
        //        "Professor Plum",
        //        "Miss Scarlet",
        //        "Mrs Peacock",
        //        "Mrs White"
        //    };

        //    int generateRandomSuspect = Randomizer.Next(1, 6);
        //    return suspects[generateRandomSuspect];
        //}

        //public string AnswerRoom()
        //{
        //    string[] rooms =
        //    {
        //        "Lounge",
        //        "Study",
        //        "Hall",
        //        "Library",
        //        "Dining Room",
        //        "Kitchen",
        //        "Ballroom",
        //        "Conservatory",
        //        "Billiard Room"
        //    };

        //    int generateRandomRoom = Randomizer.Next(1, 6);
        //    return rooms[generateRandomRoom];
        //}
    }
}



