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
        public string Luokka { get; set; }
        public string Nimi { get; set; }

        public Opiskelija(string Name, int Age, string Class) 
        {
            Nimi = Name;
            Ika = Age;
            Luokka = Class;
        }
    }
}
