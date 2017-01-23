using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Boat : Vehicle
    {
        public int SeatCount { get; set; }
        public string BoatType { get; set; }

        // Default constructor
        public Boat()
        {
        }

        // Return NPC data as one string
        public override string ToString()
        {
            return base.ToString() + ", Seat Count: " + SeatCount + ", Boat Type: " + BoatType;
        }
    }
}
