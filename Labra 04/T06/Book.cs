using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Book : Publication
    {
        public string Author { get; set; }

        // Default constructor
        public Book()
        {
        }

        // Override base class ToString()-method
        public override string ToString()
        {
            return base.ToString() + ", by " + Author;
        }
    }
}
