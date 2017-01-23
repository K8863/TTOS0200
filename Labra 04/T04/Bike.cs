using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Bike : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }

        // Default constructor
        public Bike()
        {
        }

        // Return NPC data as one string
        public override string ToString()
        {
            return base.ToString() + ", Gear Wheels: " + GearWheels + ", Gear Name: " + GearName;
        }
    }
}