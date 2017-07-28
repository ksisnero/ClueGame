using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GetAClue.Models
{
    public class GuessDisplay
    {
        public virtual string RoomTextbox { get; set; }
        public virtual string WeaponTextbox { get; set; }
        public virtual string SuspectTextbox { get; set; }


        public string DisplayGuesses(bool radioButton, string radioButtonName)
        {
            string display = string.Empty;

            if (radioButton == true)
            {
                display = radioButtonName;
            }
            return display;
        }
    }
}
