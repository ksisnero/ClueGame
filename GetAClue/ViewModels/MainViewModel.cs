using GetAClue.Models;

namespace GetAClue.ViewModels
{
    public partial class MainViewModel
    {
        #region Properties
        public virtual string SuspectTextbox { get; set; }
        public virtual string WeaponTextbox { get; set; }
        public virtual string RoomTextbox { get; set; }
        public virtual string CounterTextbox { get; set; }
        #endregion

        #region Declarations
        //Counter's initializer must be outside or the counter will always restart
        private Answer _answer = new Answer();
        private Guesses _guess = new Guesses();
        private GameOver _gameOver = new GameOver();

        public string RoomGuess;
        public string WeaponGuess;
        public string SuspectGuess;

        public string RoomAnswer;
        public string WeaponAnswer;
        public string SuspectAnswer;

        public int Counter;
        #endregion

        public MainViewModel()
        {
            InstructionsVisible = true;
        }

        public void GenerateAnswer()
        {
            RoomAnswer = _answer.AnswerRoom();
            SuspectAnswer = _answer.AnswerSuspect();
            WeaponAnswer = _answer.AnswerWeapon();
        }

        public void CountGuess()
        {
            if (Counter < 6)
                Counter = Counter + 1;
            else
                CheckIfGameOver();

        CounterTextbox = Counter.ToString();
    }

        public void DisplayGuess()
        {
            RoomGuess += _guess.DisplayGuesses(LoungeRadioButton, "Lounge");
            RoomGuess += _guess.DisplayGuesses(StudyRadioButton, "Study");
            RoomGuess += _guess.DisplayGuesses(HallRadioButton, "Hall");
            RoomGuess += _guess.DisplayGuesses(LibraryRadioButton, "Library");
            RoomGuess += _guess.DisplayGuesses(DiningRoomRadioButton, "Dining Room");
            RoomGuess += _guess.DisplayGuesses(KitchenRadioButton, "Kitchen");
            RoomGuess += _guess.DisplayGuesses(BallroomRadioButton, "Ballroom");
            RoomGuess += _guess.DisplayGuesses(ConservatoryRadioButton, "Conservatory");
            RoomGuess += _guess.DisplayGuesses(BilliardRoomRadioButton, "Billiard Room");

            WeaponGuess += _guess.DisplayGuesses(CandlestickRadioButton, "Candlestick");
            WeaponGuess += _guess.DisplayGuesses(RevolverRadioButton, "Revolver");
            WeaponGuess += _guess.DisplayGuesses(KnifeRadioButton, "Knife");
            WeaponGuess += _guess.DisplayGuesses(LeadPipeRadioButton, "Lead Pipe");
            WeaponGuess += _guess.DisplayGuesses(WrenchRadioButton, "Wrench");

            SuspectGuess += _guess.DisplayGuesses(ColonelMustardRadioButton, "Colonel Mustard");
            SuspectGuess += _guess.DisplayGuesses(MrGreenRadioButton, "Mr Green");
            SuspectGuess += _guess.DisplayGuesses(ProfessorPlumRadioButton, "Professor Plum");
            SuspectGuess += _guess.DisplayGuesses(MissScarletRadioButton, "Miss Scarlet");
            SuspectGuess += _guess.DisplayGuesses(MrsPeacockRadioButton, "Mrs Peacock");
            SuspectGuess += _guess.DisplayGuesses(MrsWhiteRadioButton, "Mrs White");

            CheckForAnswer();

            SuspectTextbox = SuspectGuess += "\n";
            WeaponTextbox = WeaponGuess += "\n";
            RoomTextbox = RoomGuess += "\n";
        }

        public void CheckForAnswer()
        {
            RoomGuess = _guess.CheckIfAnswer(RoomGuess, RoomAnswer);
            WeaponGuess = _guess.CheckIfAnswer(WeaponGuess, WeaponAnswer);
            SuspectGuess = _guess.CheckIfAnswer(SuspectGuess, SuspectAnswer);
        }

        public void CheckIfGameOver()
        {
            if (_gameOver.IfGameOverDisplay(RoomGuess, WeaponGuess, SuspectGuess))
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
                EnterButtonEnabled = false;
            }
        }

        #region Button Commands
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

            Counter = 0;

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
        #endregion
    }
}
