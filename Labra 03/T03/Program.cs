/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 03 - Tehtävä 3
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 17.1.2017
 * Kuvaus: 
 *          Tehtävänäsi on ohjelmoida television toiminta. 
 *          Samoin kuin edellinen tehtävä: mitä ominaisuuksia ja toimintoja tekisit Televisio-luokkaan?
 *          
 *          Suunnittele Televisio-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.
 *          Toteuta Televisio-luokan ohjelmointi sekä pääohjelma, jolla luot olion Televisio-luokasta. 
 *          Säädä luomaasi Televsio-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, 
 *          jotta televisio-olion käyttäminen jää näkyville. */

using System;
using JAMK.IT;

namespace T03
{
    class Program
    {
        static void Main(string[] args)
        {
            Telkkari();
        }

        static void Telkkari()
        {
            // Luodaan televisio-olio
            TV televisio = new JAMK.IT.TV();
            // Annetaan oliolle arvot
            televisio.Merkki = "Samsung";
            televisio.Koko = 45;
            televisio.OnkoPäällä = true;
            // Tulostetaan tiedot
            Console.WriteLine("TELEVISIO\n");
            Console.WriteLine("Merkki: {0}", televisio.Merkki);
            Console.WriteLine("Koko: {0} tuumaa", televisio.Koko);
            Console.WriteLine("Päällä: {0}", televisio.OnkoPäällä);
        }
    }
}
