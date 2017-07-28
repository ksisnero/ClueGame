using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GetAClue.Models;

namespace GetAClue.ViewModels
{
    class EnablingButtons
    {
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
    }
}
