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

        public Opiskelija(string name, int age, string id) 
        {
            Nimi = name;
            Ika = age;
            Tunnus = id;
        }
    }
}
