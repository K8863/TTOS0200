/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 01 - Tehtävä 2
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 9.1.2017
 * Kuvaus: 
 *          Tee ohjelma, jossa annetaan oppilaalle koulunumero taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron). */

using System;

namespace T02
{
    class Arvosana
    {
        static void Main(string[] args)
        {
            // Kysytään pistemäärä
            int pisteet;
            Console.Write("Anna pistemäärä > ");
            pisteet = int.Parse(Console.ReadLine());
            // Annetaan koulunumero pistemäärän perusteella
            switch (pisteet)
            {
                case 0:
                case 1:
                    Console.WriteLine("Koulunumero on 0");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Koulunumero on 1");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Koulunumero on 2");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Koulunumero on 3");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Koulunumero on 4");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Koulunumero on 5");
                    break;
            }
        }
    }
}
