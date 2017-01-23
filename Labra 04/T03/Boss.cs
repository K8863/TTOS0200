using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        // Default constructor
        public Boss()
        {
        }

        // Return Boss data as one string
        public override string ToString()
        {
            return base.ToString() + ", Car: " + Car + ", Bonus: " + Bonus;
        }
    }
}
