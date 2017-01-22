/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 04 - Tehtävä 5
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 21.1.2017
 * Kuvaus: 
 *          Tehtävässä tulee toteuttaa C#-ohjelma radion perustoimintojen testaamiseen.
 *          Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin, äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) 
 *          ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0). Laadi luokka kannettavan radion toteutukseksi. 
 *          Käytä tekemääsi luokkaa pääohjelmasta käsin, eli testaile radion toimivuutta erilaisilla voimakkuuden ja taajuuden arvoilla. 
 *          Jätä asetus- ja tulostuslauseet näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa. */

using System;
using JAMK.IT;

namespace T05
{
    class Program
    {
        static void Main(string[] args)
        {
            ListenRadio();
        }

        static void ListenRadio()
        {
            // Luodaan radio-olio
            Radio radio = new JAMK.IT.Radio();
            // Laitetaan radio päälle
            string onoff;
            Console.Write("Radio is turned off. Turn on? (y/n) > ");
            onoff = Console.ReadLine();
            if (onoff == "y")
            {
                radio.TurnedOn = true;
                Console.Write("Choose frequency > ");
                radio.Frequency = double.Parse(Console.ReadLine());
                Console.Write("Set volume (0-9) > ");
                radio.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Listening to frequency {0} on volume {1}.", radio.Frequency, radio.Volume);
            }
        }
    }
}
