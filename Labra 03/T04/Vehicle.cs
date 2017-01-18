using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Vehicle
    {
        public string Name;
        public int Speed;
        public int Tyres;

        // Tulostaa auton ominaisuudet
        public void PrintData()
        {
            Console.WriteLine("AUTON OMINAISUUDET\n");
            Console.WriteLine("Auto: {0}", Name);
            Console.WriteLine("Auton nopeus: {0} km/h", Speed);
            Console.WriteLine("Auton renkaat: {0} tuumaa", Tyres);
        }

        // Palauttaa kaikki auton ominaisuudet yhtenä merkkijonona
        public override string ToString()
        {
            return Name + ", nopeus " + Speed + " km/h, renkaiden koko " + Tyres + " tuumaa";
        }
    }
}
