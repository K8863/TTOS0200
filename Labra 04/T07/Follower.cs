using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Follower : Npc
    {
        public bool Follow { get; set; }
        public bool Marry { get; set; }
        public bool Steward { get; set; }

        // Default constructor
        public Follower()
        {
            Follow = true;
        }

        // Override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + "Follower: " + Follow + ", Marry: " + Marry + ", Steward: " + Steward + "\n";
        }
    }
}
