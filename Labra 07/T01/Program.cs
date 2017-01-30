﻿/* Kurssi: TTOS0200 Olio-ohjelmointi
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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter outputFile = null;

            // Write input lines to file
            try
            {
                outputFile = new System.IO.StreamWriter("T1TextLines.txt");
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
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
            
            // Read lines from file
            try
            {
                string text = System.IO.File.ReadAllText("T1TextLines.txt");
                System.Console.WriteLine("Contents of T1TextLines.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
    }
}
