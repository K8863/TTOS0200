/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 07 - Tehtävä 2
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 30.1.2017
 * Kuvaus: 
 *          Tee ohjelma, joka lukee yksinkertaisesta tekstitiedosto nimet.txt henkilöitten nimiä ja 
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
 *              Press any key to continue . . . */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"d:\Temp\nimet.txt");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                int numberOfLines = System.IO.File.ReadAllLines(@"d:\Temp\nimet.txt").Count();
                Console.WriteLine("Number of lines: " + numberOfLines);
                int numberOfUniqueLines = System.IO.File.ReadAllLines(@"d:\Temp\nimet.txt").Distinct().Count();
                Console.WriteLine("Number of names: " + numberOfUniqueLines);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
