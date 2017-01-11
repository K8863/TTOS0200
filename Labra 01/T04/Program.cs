/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 01 - Tehtävä 4
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 9.1.2017
 * Kuvaus: 
 *          Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", 
 *          jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori". */

using System;

namespace T04
{
    class Ikaluokka
    {
        static void Main(string[] args)
        {
            // Kysytään käyttäjän ikä
            int age;
            Console.WriteLine("Anna ikä > ");
            age = int.Parse(Console.ReadLine());
            // Tulostetaan käyttäjän ikäluokka
            if (age < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            else if (age >= 18 && age <= 65)
            {
                Console.WriteLine("Aikuinen");
            }
            else if (age >= 65)
            {
                Console.WriteLine("Seniori");
            }
        }
    }
}
