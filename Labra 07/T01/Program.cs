/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 07 - Tehtävä 1
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 30.1.2017
 * Kuvaus: 
 *          Tiedostoon kirjoittaminen ja lukeminen.
 *          
 *          Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon 
 *          (lopetusehdon voit päättää itse) ja sulje tiedosto. 
 *          Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin. 
 *          Huomioi mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa.
 *          
 *          Esimerkkitulostus:
 *          
 *              Give a text line (enter ends) : Matti
 *              Give a text line (enter ends) : Teppo
 *              Give a text line (enter ends) : Seppo
 *              Give a text line (enter ends) : Jorma
 *              Give a text line (enter ends) :
 *          
 *              Contents of T1TextLines.txt:
 *              Matti
 *              Teppo
 *              Seppo
 *              Jorma */

using System;
using System.IO;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Write input lines to file
                StreamWriter outputFile = new StreamWriter("T1TextLines.txt");
                string input;
                while (true)
                {
                    Console.Write("Give a text line (enter ends) > ");
                    outputFile.WriteLine(input = Console.ReadLine());
                    if (input == "")
                    {
                        break;
                    }
                }
                outputFile.Close();

                // Read lines from file     
                string text = File.ReadAllText("T1TextLines.txt");
                Console.WriteLine("Contents of T1TextLines.txt:\n" + text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
