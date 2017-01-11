/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Sormiharjoitus - Lotto 7/40
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 9.1.2017
 * Kuvaus: 
 *          Suomalaisessa Lotossa arvotaan seitsemän (7) numeroa 40:sta. 
 *          Tee ohjelma, joka arpoo käyttäjän haluaman määrän Lotto-rivejä. */

using System;
using System.Linq;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lottonumeroiden muuttujien luonti
            const int a = 7;
            int[] numerot = new int[40];
            int[] voittonumerot = new int[7];
            int rand;
            Random rng = new Random();

            // Kysytään haluttujen rivien määrä
            Console.Write("Anna arvottavien rivien määrä > ");
            int rivit = int.Parse(Console.ReadLine());
            int b = 0;

            // Lototaan kunnes haluttujen rivien määrä tulee täyteen
            while (b < rivit)
            {
                // Numerot taulukkoon
                for (int i = 0; i < numerot.Length; i++)
                {
                    numerot[i] = i;
                }
                // Arvotaan numerot
                for (int i = 0; i < a; i++)
                {
                    // Asetetaan randomoitu luku rand-muuttujaan
                    rand = rng.Next(numerot[39]);
                    // Tarkistetaan onko luku jo voittonumeroissa
                    if (voittonumerot.Contains(rand))
                    {
                        // Jos on, niin arvotaan uusi numero
                        i--;
                    }
                    else
                    {
                        // Jos ei, niin tallennetaan se voittonumeroihin
                        voittonumerot[i] = rand;
                    }
                }
                // Laitetaan numerot suuruusjärjestykseen
                Array.Sort(voittonumerot);

                // Tulostetaan numerot
                Console.Write("Rivi " + (b + 1) + ": ");
                for (int i = 0; i < a; i++)
                {
                    Console.Write(voittonumerot[i] + " ");
                }
                Console.Write("\n");
                b++;
            }
        }
    }
}
