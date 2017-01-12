/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 01 - Tehtävä 7
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 12.1.2017
 * Kuvaus: 
 *          Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
 *          
 *          Algoritmi
 *          4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat
 *          Esim. 1991 -> ei, 1992 -> on, 1900 -> ei, 2000 -> on */

using System;

namespace T07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään käyttäjältä vuosi
            Console.Write("Anna vuosiluku > ");
            int vuosi = int.Parse(Console.ReadLine());

            // Tarkistetaan onko karkausvuosi
            if ((vuosi % 4 == 0 && vuosi % 100 != 0) || (vuosi % 400 == 0))
            {
                Console.WriteLine("Vuosi {0} on karkausvuosi.", vuosi);
            }
            else
            {
                Console.WriteLine("Vuosi {0} ei ole karkausvuosi.", vuosi);
            }
        }
    }
}
