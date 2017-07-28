using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAClue.Models
{
    public class GuessCount
    {
        public int Count;
        public virtual string DisplayCounter { get; set; }

        public string Counter()
        {
            if (Count < 11)
            {
                Count = Count + 1;
            }

            string counterDisplay = Count.ToString();
            return counterDisplay;
        }
    }
}
