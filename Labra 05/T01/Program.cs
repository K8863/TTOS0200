/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 05 - Tehtävä 1
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 23.1.2017
 * Kuvaus: 
 *          Tee Rengas-luokka, jolla on seuraavat ominaisuudet: merkki, tyyppi ja rengaskoko. Tee tämän jälkeen 
 *          Kulkuneuvo-luokka muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli) ja käytä tekemääsi 
 *          Rengas-luokkaa apuna renkaiden käsittelyyn. Tässä vaiheessa voit koostaa kulkuneuvon renkaat Rengas-olioina 
 *          esim. taulukkoon tai kurssimateriaalissa esitettyy List-rakenteeseen (kokoelmaluokat käsitellään tarkemmin 
 *          seuraavissa demoissa). Tee pääohjelma, jossa luot muutamia kulkuneuvoja (esim. auto ja moottoripyörä) renkaineen. 
 *          Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa. */

using System;
using System.Collections.Generic;

namespace T01
{
    class Rengas
    {
        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public string Rengaskoko { get; set; }

        public override string ToString()
        {
            return "Valmistaja: " + Valmistaja + ", malli: " + Malli + ", rengaskoko: " + Rengaskoko;
        }
    }
    class Auto
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        private const int maxRenkaat = 4;
        private int lkmRenkaat = 0;

        public List<Rengas> Renkaat { get; }

        public Auto()
        {
            Renkaat = new List<Rengas>();
        }

        public void LisääRengas(Rengas rengas)
        {
            if (lkmRenkaat < maxRenkaat)
            {
                Renkaat.Add(rengas);
                lkmRenkaat++;
                Console.WriteLine("Rengas {0} lisätty ajoneuvoon {1}", rengas.Malli, Nimi);
            }
            else
            {
                Console.WriteLine("No room for a new tyres..., sorry!");
            }
        }

        public override string ToString()
        {
            string s = "\nAutossa " + Nimi + " " + Malli + " renkaat:";
            foreach (Rengas r in Renkaat)
            {
                if (r != null) s += "\n-" + r.ToString();
            }
            return s;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TestCarWithFourWheelsV2();
        }

        static void TestCarWithFourWheelsV2()
        {
            // create tyre
            Rengas tyre1 = new Rengas { Valmistaja = "Nokia", Malli = "Hakkapeliitta", Rengaskoko = "205R16" };
            // create a car
            Auto kaara = new Auto { Nimi = "Porsche", Malli = "911" };
            Console.WriteLine("Luotu uusi auto {0} {1}", kaara.Nimi, kaara.Malli);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            kaara.LisääRengas(tyre1);
            Console.WriteLine(kaara.ToString());
        }

    }
}
