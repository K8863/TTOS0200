/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 07 - Tehtävä 3
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 30.1.2017
 * Kuvaus: 
 *          Tee ohjelma, joka kysyy käyttäjältä lukuja (joko kokonaisluku tai reaaliluku) ja tallenna kokonaisluvut eri tiedostoon kuin reaaliluvut. 
 *          Sovellus tulee lopettaa, jos käyttäjä ei syötä kokonais- tai reaalilukua. Tarkista tiedostojen sisältö jollain tekstieditorilla.
 *          
 *          Esimerkkitulostus:
 *          
 *              Give a number (enter or not a number ends) : 1,0
 *              Give a number (enter or not a number ends) : 2,0
 *              Give a number (enter or not a number ends) : 3,0
 *              Give a number (enter or not a number ends) : 4
 *              Give a number (enter or not a number ends) : 5
 *              Give a number (enter or not a number ends) : 6
 *              Give a number (enter or not a number ends) :
 *              
 *              Contents of T2Integers.txt:
 *              4
 *              5
 *              6
 *              
 *              Contents of T2Doubles.txt:
 *              1,0
 *              2,0
 *              3,0 */

using System;
using System.Collections.Generic;
using System.IO;

namespace T03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                NumberTest();          
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }      
        }

        static void NumberTest()
        {
            try
            {
                double d; int i; string s;
                List<double> Doubles = new List<double>();
                List<int> Integers = new List<int>();

                // Ask for numbers and add them to appropriate lists
                do
                {
                    Console.Write("Give a number > ");
                    s = Console.ReadLine();

                    if (int.TryParse(s, out i)) { Integers.Add(i); }
                    else if (double.TryParse(s, out d)) { Doubles.Add(d); }
                }
                while (int.TryParse(s, out i) || double.TryParse(s, out d));

                using (StreamWriter intFile = new StreamWriter("T3integers.txt"))
                {
                    foreach (int integer in Integers)
                    {
                        intFile.WriteLine(integer);
                    }
                }
                using (StreamWriter doubleFile = new StreamWriter("T3doubles.txt"))
                {
                    foreach (double dubbel in Doubles)
                    {
                        doubleFile.WriteLine(dubbel);
                    }
                }
                // Read integers from file
                string ints = File.ReadAllText("T3integers.txt");
                Console.WriteLine("\nContents of T3integers:\n" + ints);

                // Read doubles from file
                string doubles = File.ReadAllText("T3doubles.txt");
                Console.WriteLine("\nContents of T3doubles:\n" + doubles);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
