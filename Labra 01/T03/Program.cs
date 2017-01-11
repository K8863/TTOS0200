/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 01 - Tehtävä 3
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 9.1.2017
 * Kuvaus: 
 *          Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon. */

using System;

namespace T03
{
    class Laskin
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[3];
            // Kysytään käyttäjältä luvut
            for (int i = 0; i < luvut.Length; i++)
            {
                Console.Write("Anna luku > ");
                luvut[i] = int.Parse(Console.ReadLine());
            }
            // Tulostetaan lukujen summa ja keskiarvo
            int summa = luvut[0] + luvut[1] + luvut[2];
            Console.WriteLine("Lukujen summa: " + summa);
            Console.WriteLine("Lukujen keskiarvo: " + summa / 3);
        }
    }
}
