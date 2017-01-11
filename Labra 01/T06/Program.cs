/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 01 - Tehtävä 6
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 11.1.2017
 * Kuvaus: 
 *          Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. 
 *          Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
 *          
 *          Esimerkkitoiminta:
 *          Anna matka > 250 [Enter]
 *          Bensaa kuluu 17,55 litraa, kustannus 27,99 euroa */

using System;

namespace T06
{
    class Laskuri
    {
        static void Main(string[] args)
        {
            // Määritellään bensan litrahinta ja auton kulutus (l/km)
            double hinta = 1.595;
            double litra = 0.0702;
            double matka;
            // Pyydetään matka
            Console.Write("Anna matka kilometreinä > ");
            matka = double.Parse(Console.ReadLine());
            // Lasketaan matkan bensankulutus ja -kustannus
            double kulutus = matka * litra;
            double kustannus = kulutus * hinta;
            // Lyhennetään kahteen desimaaliin
            string loppukulutus = kulutus.ToString("N2");
            string loppukustannus = kustannus.ToString("N2");
            // Tulostetaan matkan kulutus ja kustannus
            Console.WriteLine("Bensaa kuluu " + loppukulutus + " litraa, kustannus " + loppukustannus + " euroa.");
        }
    }
}