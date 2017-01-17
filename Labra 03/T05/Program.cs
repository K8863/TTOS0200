/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 03 - Tehtävä 5
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 17.1.2017
 * Kuvaus: 
 *          Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja. 
 *          Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, 
 *          joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa). 
 *          Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta. */

using System;
using System.Collections.Generic;
using JAMK.IT;

namespace T05
{
    class Program
    {
        static void Main(string[] args)
        {
            OpiskelijaTiedot();
        }

        static void OpiskelijaTiedot()
        {
            // Luodaan opiskelijat
            List<Opiskelija> lista = new List<Opiskelija>();
            lista.Add(new Opiskelija("Matti", 25, "K8912"));
            lista.Add(new Opiskelija("Mauno", 21, "K9771"));
            lista.Add(new Opiskelija("Jaana", 23, "K9155"));
            lista.Add(new Opiskelija("Timppa", 27, "K8821"));
            lista.Add(new Opiskelija("Alduin", 666, "K1234"));

            // Tulostetaan opiskelijoiden tiedot
            Console.WriteLine("OPISKELIJAT\n");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("{0}, {1}, {2}", lista[i].Nimi, lista[i].Ika, lista[i].Tunnus);
            }
        }
    }
}
