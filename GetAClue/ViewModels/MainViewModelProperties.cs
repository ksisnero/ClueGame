using GetAClue.Models;

namespace GetAClue.ViewModels
{
    public partial class MainViewModel
    {
        public virtual bool RoomOption { get; set; }
        public virtual bool WeaponOption { get; set; }
        public virtual bool SuspectOption { get; set; }
        public virtual bool InstructionOption { get; set; }
        public virtual bool EnterButtonEnabler { get; set; }

        public virtual bool RoomButtonEnabler { get; set; }
        public virtual bool WeaponButtonEnabler { get; set; }
        public virtual bool SuspectButtonEnabler { get; set; }

        public virtual bool LoungeRadioButton { get; set; }
        public virtual bool StudyRadioButton { get; set; }
        public virtual bool HallRadioButton { get; set; }
        public virtual bool LibraryRadioButton { get; set; }
        public virtual bool DiningRoomRadioButton { get; set; }
        public virtual bool KitchenRadioButton { get; set; }
        public virtual bool BallroomRadioButton { get; set; }
        public virtual bool ConservatoryRadioButton { get; set; }
        public virtual bool BilliardRoomRadioButton { get; set; }

        public virtual bool CandlestickRadioButton { get; set; }
        public virtual bool RevolverRadioButton { get; set; }
        public virtual bool KnifeRadioButton { get; set; }
        public virtual bool LeadPipeRadioButton { get; set; }
        public virtual bool WrenchRadioButton { get; set; }

        public virtual bool ColonelMustardRadioButton { get; set; }
        public virtual bool MrGreenRadioButton { get; set; }
        public virtual bool ProfessorPlumRadioButton { get; set; }
        public virtual bool MissScarletRadioButton { get; set; }
        public virtual bool MrsPeacockRadioButton { get; set; }
        public virtual bool MrsWhiteRadioButton { get; set; }

        public virtual bool YouWinVisibility { get; set; }
        public virtual bool YouLoseVisibility { get; set; }

        public virtual GuessDisplay GuessDisplay { get; set; }
        public virtual GuessCount CounterDisplay { get; set; } 

    }
}
