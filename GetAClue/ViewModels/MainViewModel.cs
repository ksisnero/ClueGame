using System;
using System.Text.RegularExpressions;
using System.Windows;
using DevExpress.Mvvm.POCO;
using DevExpress.Web.ASPxRichEdit.Export;
using GetAClue.Models;

namespace GetAClue.ViewModels
{
    public partial class MainViewModel
    {
        //Change slides automatically

        private string _roomGuess;
        private string _weaponGuess;
        private string _suspectGuess;

        private string _answerRoom;
        private string _answerWeapon;
        private string _answerSuspect;

        private GuessCount _guessCount = new GuessCount();
        private GameOver _gameOver;

        public MainViewModel()
        {
            GenerateAnswer();
            InstructionOption = true;

            GuessDisplay = ViewModelSource.Create(() => new GuessDisplay());
            CounterDisplay = ViewModelSource.Create(() => new GuessCount());
        }

        public void StartGame()
        {
            _gameOver = new GameOver();

            InstructionOption = false;
            YouLoseVisibility = false;
            YouWinVisibility = false;

            SuspectOption = true;
            WeaponOption = false;
            RoomOption = false;

            RoomButtonEnabler = true;
            WeaponButtonEnabler = true;
            SuspectButtonEnabler = true;

            EnterButtonEnabler = true;
            UncheckRadioButtons();
        }

        public void EnableRoom()
        {
            RoomOption = true;
            WeaponOption = false;
            SuspectOption = false;
        }

        public void EnableSuspect()
        {
            RoomOption = false;
            WeaponOption = false;
            SuspectOption = true;
        }

        public void EnableWeapon()
        {
            RoomOption = false;
            WeaponOption = true;
            SuspectOption = false;
        }

        public void UncheckRadioButtons()
        {
            LoungeRadioButton = false;
            StudyRadioButton = false;
            HallRadioButton = false;
            LibraryRadioButton = false;
            DiningRoomRadioButton = false;
            KitchenRadioButton = false;
            BallroomRadioButton = false;
            ConservatoryRadioButton = false;
            BilliardRoomRadioButton = false;

            CandlestickRadioButton = false;
            RevolverRadioButton = false;
            KnifeRadioButton = false;
            LeadPipeRadioButton = false;
            WrenchRadioButton = false;

            ColonelMustardRadioButton = false;
            MrGreenRadioButton = false;
            ProfessorPlumRadioButton = false;
            MissScarletRadioButton = false;
            MrsPeacockRadioButton = false;
            MrsWhiteRadioButton = false;
        }

        public void EnterButton()
        {
            DisplayGuess();
            CheckIfGameOver();
            UncheckRadioButtons();
            CheckForAnswer();
            CountGuess();      
        }

        public void GenerateAnswer()
        {
            //put string[] here?

            GenerateAnswer generateAnswer = new GenerateAnswer();
            _answerRoom = generateAnswer.AnswerGenerator();
            _answerSuspect = generateAnswer.AnswerGenerator();
            _answerWeapon = generateAnswer.AnswerGenerator();
        }

        public void CountGuess()
        {
            CounterDisplay.DisplayCounter = _guessCount.Counter();
        }

        public void DisplayGuess()
        {
            GuessDisplay userGuessDisplay = new GuessDisplay();

            _roomGuess += userGuessDisplay.DisplayGuesses(LoungeRadioButton, "Lounge");
            _roomGuess += userGuessDisplay.DisplayGuesses(StudyRadioButton, "Study");
            _roomGuess += userGuessDisplay.DisplayGuesses(HallRadioButton, "Hall");
            _roomGuess += userGuessDisplay.DisplayGuesses(LibraryRadioButton, "Library");
            _roomGuess += userGuessDisplay.DisplayGuesses(DiningRoomRadioButton, "Dining Room");
            _roomGuess += userGuessDisplay.DisplayGuesses(KitchenRadioButton, "Kitchen");
            _roomGuess += userGuessDisplay.DisplayGuesses(BallroomRadioButton, "Ballroom");
            _roomGuess += userGuessDisplay.DisplayGuesses(ConservatoryRadioButton, "Conservatory");
            _roomGuess += userGuessDisplay.DisplayGuesses(BilliardRoomRadioButton, "Billiard Room");

            _weaponGuess += userGuessDisplay.DisplayGuesses(CandlestickRadioButton, "Candlestick");
            _weaponGuess += userGuessDisplay.DisplayGuesses(RevolverRadioButton, "Revolver");
            _weaponGuess += userGuessDisplay.DisplayGuesses(KnifeRadioButton, "Knife");
            _weaponGuess += userGuessDisplay.DisplayGuesses(LeadPipeRadioButton, "Lead Pipe");
            _weaponGuess += userGuessDisplay.DisplayGuesses(WrenchRadioButton, "Wrench");

            _suspectGuess += userGuessDisplay.DisplayGuesses(ColonelMustardRadioButton, "Colonel Mustard");
            _suspectGuess += userGuessDisplay.DisplayGuesses(MrGreenRadioButton, "Mr Green");
            _suspectGuess += userGuessDisplay.DisplayGuesses(ProfessorPlumRadioButton, "Professor Plum");
            _suspectGuess += userGuessDisplay.DisplayGuesses(MissScarletRadioButton, "Miss Scarlet");
            _suspectGuess += userGuessDisplay.DisplayGuesses(MrsPeacockRadioButton, "Mrs Peacock");
            _suspectGuess += userGuessDisplay.DisplayGuesses(MrsWhiteRadioButton, "Mrs White");

            CheckForAnswer();

            GuessDisplay.SuspectTextbox = _suspectGuess += "\n";
            GuessDisplay.WeaponTextbox = _weaponGuess += "\n";
            GuessDisplay.RoomTextbox = _roomGuess += "\n";
        }

        public void CheckForAnswer()
        {
            CheckForAnswer checkForAnswerRoom = new CheckForAnswer();
            _roomGuess = checkForAnswerRoom.CheckIfAnswer(_roomGuess, _answerRoom);
            _weaponGuess = checkForAnswerRoom.CheckIfAnswer(_weaponGuess, _answerWeapon);
            _suspectGuess = checkForAnswerRoom.CheckIfAnswer(_suspectGuess, _answerSuspect);
        }

        public void CheckIfGameOver()
        {
            if (_gameOver.GameOverDisplay(_roomGuess, _weaponGuess, _suspectGuess) == true)
            {
                YouWinVisibility = true;
                SuspectOption = false;
                WeaponOption = false;
                RoomOption = false;
            }
            else if (CounterDisplay.DisplayCounter == "6")
            {
                YouLoseVisibility = true;
                SuspectOption = false;
                WeaponOption = false;
                RoomOption = false;
            }
            else
            {
                SuspectOption = true;
                WeaponOption = false;
                RoomOption = false;
            }
        }
    }
}
