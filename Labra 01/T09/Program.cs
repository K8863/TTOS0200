/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 01 - Tehtävä 9
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 12.1.2017
 * Kuvaus: 
 *          Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
 *          
 *          Esimerkkitoiminta:
 *          Anna Luku > 10 [Enter]
 *          Anna Luku > 30 [Enter]
 *          Anna Luku > 0 [Enter]
 *          Lukujen summa on 60 */

using System;

namespace T09
{
    class Program
    {
        static void Main(string[] args)
        {
            int annettu = 1;
            int i = 0;
            int[] luvut = new int[9999];
            int summa = 0;

            // Kysytään käyttäjältä luvut
            while (annettu != 0)
            {
                Console.Write("Anna luku > ");
                annettu = int.Parse(Console.ReadLine());
                luvut[i] = annettu;
                i++;
            }
            // Lasketaan syötettyjen lukujen summa
            for (int j = 0; j < i; j++)
            {
                summa = summa + luvut[j];
            }
            Console.WriteLine("Lukujen summa on {0}", summa);
        }
    }
}
