/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 03 - Tehtävä 1
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 16.1.2017
 * Kuvaus: 
 *          Tehtävänäsi on ohjelmoida kiukaan toiminta. Kiuas pitää pystyä laittamaan päälle ja pois, 
 *          sekä sen lämpötilaa että sen antamaa kosteutta pitää pystyä säätämään (arvoja ei ole rajattu).
 *          
 *          Suunnittele Kiuas-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.
 *          
 *          Toteuta Kiuas-luokan ohjelmointi sekä pääohjelma, jolla luot olion Kiuas-luokasta. 
 *          Säädä kiuas-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, 
 *          jotta kiuas-olion käyttäminen jää näkyville. */

using System;
using JAMK.IT;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaKiuas();
        }

        // Tehtävän 1 Kiuas-luokan testaus
        static void TestaaKiuas()
        {
            // Luodaan kiuas-olio
            Kiuas kiuas = new JAMK.IT.Kiuas();
            // Pistetään kiuas lämpenemään ja asetetaan lämpöä & kosteutta
            kiuas.OnkoPäällä = true;
            kiuas.Lämpötila = 90;
            kiuas.Kosteus = 50;
            // Näytetään konsolilla
            Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPäällä);
            Console.WriteLine("Kiukaan lämpötila {0}", kiuas.Lämpötila);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Kosteus);
        }
    }
}
