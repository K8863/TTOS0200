/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 03 - Tehtävä 2
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 17.1.2017
 * Kuvaus: 
 *          Tehtävänäsi on ohjelmoida pesukoneen toiminta. 
 *          Samoin kuin edellinen tehtävä: mitä ominaisuuksia ja toimintoja tekisit Pesukone-luokkaan?
 *          
 *          Suunnittele Pesukone-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.
 *          Toteuta Pesukone-luokan ohjelmointi sekä pääohjelma, jolla luot olion Pesukone-luokasta. 
 *          Säädä pesukone-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, 
 *          jotta pesukone-olion käyttäminen jää näkyville. 
 *          Toteuta Pesukone-luokkaan muutamia erilaisia konstruktoreita ja alusta niitä käyttämällä oliota pääohjelmasta käsin. */

using System;
using JAMK.IT;

namespace T02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyykkäri();
        }

        static void Pyykkäri()
        {
            // Luodaan pesukone-olio
            Pesukone pesukone = new JAMK.IT.Pesukone();
            // Annetaan oliolle arvot
            pesukone.Merkki = "LG";
            pesukone.Koko = 8;
            pesukone.OnkoKäynnissä = true;
            // Tulostetaan tiedot
            Console.WriteLine("PESUKONE\n");
            Console.WriteLine("Merkki: {0}", pesukone.Merkki);
            Console.WriteLine("Koko: {0} kg", pesukone.Koko);
            Console.WriteLine("Käynnissä: {0}", pesukone.OnkoKäynnissä);
        }
    }
}
