using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Movie : Publication
    {
        public int Length { get; set; }
        public string Rating { get; set; }

        // Default constructor
        public Movie()
        {
        }

        // Override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + ", " + Length + " min, Rated " + Rating;
        }
    }
}
