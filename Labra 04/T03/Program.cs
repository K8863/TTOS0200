/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 04 - Tehtävä 3
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 21.1.2017
 * Kuvaus: 
 *          Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee). 
 *          Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään: 
 *          työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary). 
 *          Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien tietoja (Boss), 
 *          heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).
 *          
 *          Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. 
 *          Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. 
 *          Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. 
 *          Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.
 *          
 *          Esimerkkitoiminta: (huomaa, että Kirsi Kernelin tietoja on muutettu ohjelman suorituksessa)
 *          
 *          Employee:
 *          - Name:Kirsi Kernel Profession:Teacher Salary:1200
 *          
 *          Boss:
 *          - Name:Jussi Jurkka Profession:Head of Institute Salary:9000 Car:Audi Bonus:5000
 *          
 *          Employee:
 *          - Name:Kirsi Kernel Profession:Principal Teacher Salary:2200 */

using System;
using JAMK.IT;

namespace T03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee:");
            Employee employee1 = new JAMK.IT.Employee();
            employee1.Name = "Ondolemar";
            employee1.Profession = "Thalmor Justiciar";
            employee1.Salary = 2000;
            Console.WriteLine(employee1.ToString());

            Console.WriteLine("\nBoss:");
            Boss boss1 = new JAMK.IT.Boss();
            boss1.Name = "Elenwen";
            boss1.Profession = "First Emissary";
            boss1.Salary = 4000;
            boss1.Car = "Horse cart";
            boss1.Bonus = 2000;
            Console.WriteLine(boss1.ToString());
        }
    }
}
