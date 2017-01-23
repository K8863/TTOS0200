using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        // Default constructor
        public Employee()
        {
        }

        // Return NPC data as one string
        public override string ToString()
        {
            return "- Name: " + Name + ", Profession: " + Profession + ", Salary: " + Salary;
        }
    }
}

