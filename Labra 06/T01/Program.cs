/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 06 - Tehtävä 1
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 25.1.2017
 * Kuvaus: 
 *          Toteutetaan opettajan kanssa yhdessä konsolipohjainen ohjelma, 
 *          jolla voidaan hallita henkilöitä, eli henkilörekisteri. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01
{
    /// <summary>
    /// This class contains person properties
    /// </summary>
    class Henkilo
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Hetu { get; set; }
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Hetu;
        }
    }
    /// This class holds person information in a collection
    class Henkilot
    {
        private List<Henkilo> henkilot;
        public List<Henkilo> Henkilolista
        {
            get { return henkilot; }
        }
        public Henkilot()
        {
            henkilot = new List<Henkilo>();
        }
        public void LisaaHenkilo(Henkilo hlo)
        {
            henkilot.Add(hlo);
        }
        public Henkilo HaeHenkilo(int index)
        {
            if (index < henkilot.Count)
            {
                return henkilot.ElementAt(index);
            }
            else
            {
                return null;
            }
        }
        public Henkilo HaeHenkiloHetulla(string hetu)
        {
            foreach (Henkilo hlo in henkilot)
            {
                if (hlo.Hetu == hetu)
                {
                    return hlo;
                }
            }
            return null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestaaHenkiloRekisteri();
        }

        static void TestaaHenkiloRekisteri()
        {
            // Luodaan muutama testihenkilö
            Henkilot poppoo = new Henkilot();
            Henkilo hlo = new Henkilo { Etunimi = "Jack", Sukunimi = "Russell", Hetu = "311270-123A" };
            Henkilo hlo1 = new Henkilo { Etunimi = "Sean", Sukunimi = "Bean", Hetu = "101072-666B" };
            Henkilo hlo2 = new Henkilo { Etunimi = "Mads", Sukunimi = "Mikkelsen", Hetu = "121269-123C" };
            // Lisätään henkilöt poppooseen
            poppoo.LisaaHenkilo(hlo);
            poppoo.LisaaHenkilo(hlo1);
            poppoo.LisaaHenkilo(hlo2);

            // Tulostetaan poppoo näytölle
            foreach (Henkilo h in poppoo.Henkilolista)
            {
                Console.WriteLine("Henkilö {0}", h.ToString());
            }
            // TODO kysy käyttäjältä hetu ja hetaan sitä vastaava henkilö näytölle
            Console.Write("\nHae hetu > ");
            Console.WriteLine(poppoo.HaeHenkiloHetulla(Console.ReadLine()));
        }
    }
}
