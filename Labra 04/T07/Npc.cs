using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Npc
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Gender { get; set; }

        // Default constructor
        public Npc()
        {
        }

        // Return NPC data as one string
        public override string ToString()
        {
            return Name + ", " + Race + ", " + Gender + "\n";
        }
    }
}
