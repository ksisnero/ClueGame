using GetAClue.Models;

namespace GetAClue.ViewModels
{
    public partial class MainViewModel
    {
        public virtual bool ChooseRoomOptionVisible { get; set; }
        public virtual bool ChooseWeaponOptionVisible { get; set; }
        public virtual bool ChooseSuspectOptionVisible { get; set; }
        public virtual bool InstructionsVisible { get; set; }
        public virtual bool EnterButtonEnabled { get; set; }

        public virtual bool NextButtonEnabled { get; set; }
        public virtual bool BackButtonEnabled { get; set; }

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

        public virtual bool YouWinVisible { get; set; }
        public virtual bool YouLoseVisible { get; set; }

    }
}
