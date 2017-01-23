using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }

        // Default constructor
        public Vehicle()
        {
        }

        // Return Vehicle data as one string
        public override string ToString()
        {
            return "- Name: " + Name + ", Model: " + Model + ", Year: " + Year + ", Color: " + Color;
        }
    }
}
