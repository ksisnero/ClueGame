using System.Security.Policy;
using DevExpress.Mvvm.POCO;
using GetAClue.Models;

namespace GetAClue.ViewModels
{
    public partial class MainViewModel
    {
        public virtual string SuspectTextbox { get; set; }
        public virtual string WeaponTextbox { get; set; }
        public virtual string RoomTextbox { get; set; }
        public virtual string CounterTextbox { get; set; }

        //Counter's initializer must be outside or the counter will always restart
        private Guesses guessCount = new Guesses();
        private string _roomGuess;
        private string _weaponGuess;
        private string _suspectGuess;

        private string _answerRoom;
        private string _answerWeapon;
        private string _answerSuspect;

        private int _counter;

        public MainViewModel()
        {
            InstructionsVisible = true;
        }

        public void StartGame()
        {
            InstructionsVisible = false;
            YouLoseVisible = false;
            YouWinVisible = false;

            ChooseRoomOptionVisible = false;
            ChooseWeaponOptionVisible = false;
            ChooseSuspectOptionVisible = true;

            NextButtonEnabled = true;
            BackButtonEnabled = true;

            EnterButtonEnabled = true;
            _counter = 0;

            UncheckAllRadioButtons();
            GenerateAnswer();
        }

        public virtual void Back()
        {
            if (ChooseRoomOptionVisible)
            {
                ChooseRoomOptionVisible = false;
                ChooseWeaponOptionVisible = false;
                ChooseSuspectOptionVisible = true;
            }
            else if (ChooseSuspectOptionVisible)
            {
                ChooseRoomOptionVisible = true;
                ChooseWeaponOptionVisible = false;
                ChooseSuspectOptionVisible = false;
            }
            else if (ChooseWeaponOptionVisible)
            {
                ChooseRoomOptionVisible = false;
                ChooseWeaponOptionVisible = false;
                ChooseSuspectOptionVisible = true;
            }
        }

        public virtual void Next()
        {
            if (ChooseSuspectOptionVisible)
            {
                ChooseRoomOptionVisible = false;
                ChooseWeaponOptionVisible = true;
                ChooseSuspectOptionVisible = false;
            }
            else if (ChooseWeaponOptionVisible)
            {
                ChooseRoomOptionVisible = true;
                ChooseWeaponOptionVisible = false;
                ChooseSuspectOptionVisible = false;
            }
            else if (ChooseRoomOptionVisible)
            {
                ChooseRoomOptionVisible = false;
                ChooseWeaponOptionVisible = false;
                ChooseSuspectOptionVisible = true;
            }
        }

        public void UncheckAllRadioButtons()
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
            ChooseRoomOptionVisible = false;
            ChooseWeaponOptionVisible = false;
            ChooseSuspectOptionVisible = true;

            DisplayGuess();
            CheckIfGameOver();
            UncheckAllRadioButtons();
            CheckForAnswer();
            CountGuess();
        }

        public void GenerateAnswer()
        {
            Answer generateAnswer = new Answer();
            _answerRoom = generateAnswer.AnswerRoom();
            _answerSuspect = generateAnswer.AnswerSuspect();
            _answerWeapon = generateAnswer.AnswerWeapon();
        }

        public void CountGuess()
        {
            if (_counter < 5)
                _counter = _counter + 1;
            else
                CheckIfGameOver();

        CounterTextbox = _counter.ToString();
    }

        public void DisplayGuess()
        {
            Guesses userGuessDisplay = new Guesses();

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

            SuspectTextbox = _suspectGuess += "\n";
            WeaponTextbox = _weaponGuess += "\n";
            RoomTextbox = _roomGuess += "\n";
        }

        public void CheckForAnswer()
        {
            Guesses checkForAnswer = new Guesses();
            _roomGuess = checkForAnswer.CheckIfAnswer(_roomGuess, _answerRoom);
            _weaponGuess = checkForAnswer.CheckIfAnswer(_weaponGuess, _answerWeapon);
            _suspectGuess = checkForAnswer.CheckIfAnswer(_suspectGuess, _answerSuspect);
        }

        public void CheckIfGameOver()
        {
            GameOver gameOver = new GameOver();

            if (gameOver.GameOverDisplay(_roomGuess, _weaponGuess, _suspectGuess))
            {
                YouWinVisible = true;
                ChooseSuspectOptionVisible = false;
                ChooseWeaponOptionVisible = false;
                ChooseRoomOptionVisible = false;
            }
            else if (CounterTextbox == "6")
            {
                YouLoseVisible = true;
                ChooseSuspectOptionVisible = false;
                ChooseWeaponOptionVisible = false;
                ChooseRoomOptionVisible = false;
            }
        }
    }
}
