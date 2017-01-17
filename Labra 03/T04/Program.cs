/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 03 - Tehtävä 4
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 17.1.2017
 * Kuvaus: 
 *          Luo Vehicle-luokka seuraavien tietojen mukaisesti:
 *          
 *          ominaisuudet
 *              Name:string
 *              Speed:int
 *              Tyres:int
 *          
 *          toiminnot
 *              PrintData(), tulostaa Vehiclen ominaisuudet näytölle
 *              ToString():string, palauttaa kaikki Vehiclen ominaisuudet yhtenä merkkijonona
 *              
 *          Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma, jolla luot olion Vehicle-luokasta. 
 *          Muuta olion arvoja ja tulosta olion arvoja konsolille. */

using System;
using JAMK.IT;

namespace T04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan vehicle-olio
            Vehicle vehicle = new JAMK.IT.Vehicle();
            // Annetaan oliolle arvot
            vehicle.Name = "Kaara";
            vehicle.Speed = 180;
            vehicle.Tyres = 20;
            // Tulostetaan ominaisuudet
            vehicle.PrintData();
            // Tulostetaan ominaisuudet yhtenä merkkijonona
            string merkkijono;
            merkkijono = vehicle.ToString();
            Console.WriteLine("\n" + merkkijono + "\n");
        }
    }
}
