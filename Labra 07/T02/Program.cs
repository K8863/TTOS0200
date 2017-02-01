/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 07 - Tehtävä 2
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 30.1.2017
 * Kuvaus: 
 *          Tee ohjelma, joka lukee yksinkertaisesta tekstitiedostosta nimet.txt henkilöitten nimiä ja 
 *          kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy. 
 *          Kopioi (tai luo itse vastaava tiedosto) D:\Temp -kansioon ja ohjelmoi koodisi tarkistamaan onko 
 *          em.hakemistossa tiedostoa. Käytä File.Exist-metodia. 
 *          Huomioi myös muut mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa.
 *          
 *          Esimerkkitulostus:
 *          
 *              Löytyi 20 riviä, ja 9 nimeä.
 *              Nimi Aappo esiintyy 4 kertaa
 *              Nimi Benkku esiintyy 2 kertaa
 *              Nimi Jaakko esiintyy 3 kertaa
 *              Nimi Wille esiintyy 4 kertaa
 *              Nimi Sebastian esiintyy 1 kertaa
 *              Nimi Cecilia esiintyy 2 kertaa
 *              Nimi Netta esiintyy 2 kertaa
 *              Nimi Matias esiintyy 1 kertaa
 *              Nimi Otto esiintyy 1 kertaa
 *              Press any key to continue . . . 
 *              
 *          Bonustehtävä: Lajittele nimet aakkosjärjestykseen ennen tulostusta. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace T02
{
    class Program
    {
        static void Main(string[] args)
        {
            NameCheck();
        }
        static void NameCheck()
        {
            int numberOfLines = 0;
            int numberOfNames = 0;
            string path = @"d:\Temp\nimet.txt";
            var countNames = new Dictionary<string, int>();

            try
            {
                if (File.Exists(path))
                {
                    foreach (string s in File.ReadAllLines(path))
                    {
                        if (countNames.ContainsKey(s))
                        {
                            countNames[s] = countNames[s] + 1;
                        }
                        else
                        {
                            countNames.Add(s, 1);
                            numberOfNames++;
                        }
                        numberOfLines++;
                    }

                    // Print
                    Console.WriteLine("Found {0} lines and {1} names:\n", numberOfLines, numberOfNames);
                    foreach (var pair in countNames)
                    {
                        Console.WriteLine("Name {0} - {1} times", pair.Key, pair.Value);
                    }

                    // Sort and print alphabetically
                    var alphabeticalNames = countNames.Keys.ToList();
                    alphabeticalNames.Sort();
                    Console.WriteLine("\nFound {0} lines and {1} names, in alphabetical order:\n", numberOfLines, numberOfNames);
                    foreach (var key in alphabeticalNames)
                    {
                        Console.WriteLine("Name {0} - {1} times", key, countNames[key]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
