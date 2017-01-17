using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Opiskelija
    {
        public int Ika { get; set; }
        public string Nimi { get; set; }
        public string Tunnus { get; set; }

        public Opiskelija(string Name, int Age, string ID) 
        {
            Nimi = Name;
            Ika = Age;
            Tunnus = ID;
        }
    }
}
