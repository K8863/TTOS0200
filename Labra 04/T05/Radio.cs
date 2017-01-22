using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Radio
    {
        public bool TurnedOn { get; set; }

        // Taajuus 2000.0 - 26000.0
        double frequency;
        public double Frequency
        {
            get { return frequency; }
            set
            {
                frequency = value;
                if (frequency < 2000.0) { frequency = 2000.0; }
                else if (frequency > 26000.0) { frequency = 26000.0; }
            }
        }
        // Äänenvoimakkuus 0-9
        int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                if (volume < 0) { volume = 0; }
                else if (volume > 9) { volume = 9; }
            }
        }
        public Radio()
        {
            TurnedOn = false;
        }
    }
}