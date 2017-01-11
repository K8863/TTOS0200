/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 01 - Tehtävä 5
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 9.1.2017
 * Kuvaus: 
 *          Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
 *          Esimerkkitoiminta:
 *          Anna sekunnit > 3661 [Enter]
 *          Antamasi sekunttiaika voidaan ilmaista muodossa: 1 tunti 1 minuutti 1 sekuntti */

using System;

namespace T05
{
    class Laskin
    {
        static void Main(string[] args)
        {
            // Kysytään sekuntimäärä
            int input;
            Console.Write("Anna sekuntimäärä > ");
            input = int.Parse(Console.ReadLine());
            // Lasketaan tunnit
            int hours = input / 3600;
            // Lasketaan minuutit
            int mins = input % 3600 / 60;
            // Lasketaan sekunnit
            int secs = input % 3600 % 60;
            // Tulostetaan 
            Console.WriteLine("Antamasi sekuntiaika voidaan ilmaista muodossa: " + hours + " tuntia " + mins + " minuuttia " + secs + " sekuntia");
        }
    }
}
