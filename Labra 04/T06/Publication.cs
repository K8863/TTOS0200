using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Publication
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        // Default constructor
        public Publication()
        {
        }

        // Return Publication data as one string
        public override string ToString()
        {
            return Title + ", " + Year + ", " + Genre;
        }
    }
}
