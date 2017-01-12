/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 01 - Tehtävä 8
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 12.1.2017
 * Kuvaus: 
 *          Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
 *          
 *          Esimerkkitoiminta:
 *          Anna Luku > 5 [Enter]
 *          Anna Luku > 15 [Enter]
 *          Anna Luku > 7 [Enter]
 *          Suurin luku on 15 */

using System;
using System.Linq;

namespace T08
{
    class Program
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
            // Tulostetaan suurin luku
            int suurin = luvut.Max();
            Console.WriteLine("Suurin luku on " + suurin);
        }
    }
}
