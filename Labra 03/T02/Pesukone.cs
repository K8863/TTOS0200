using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Pesukone
    {
        public bool OnkoKäynnissä { get; set; }
        public int Kapasiteetti { get; set; }
        public string Energialuokka { get; set; }
        public string Merkki { get; set; }
        public Pesukone()
        {
            OnkoKäynnissä = true;
        }
    }
}
