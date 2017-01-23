/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 04 - Tehtävä 4
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 21.1.2017
 * Kuvaus: 
 *          Toteutettavassa sovelluksessa tulisi pysyä käsittelemään erilaisia kulkuneuvoja. 
 *          Kaikilla kulkuneuvoilla on löydettävissä yhteisinä ominaisuuksina: nimi, malli, vuosimalli ja väri. 
 *          Erikoistapauksina pitää pystyä käsittelemään polkupyöriä ja veneitä. Polkupyörän osalta pitää pystyä erottelemaan se, 
 *          että onko kyseessä vaihdepyörä vai ei sekä mahdollisen vaihteiston mallinimi. 
 *          Veneiden osalta tietoina pitää ainakin olla veneen tyyppi (soutuvene, moottorivene, kajakki, ...) 
 *          ja kuinka monta istuinpaikkaa veneestä löytyy.
 *          
 *          Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot. 
 *          Toteuta tämän jälkeen vaaditut luokat, luo ja käytä olioita pääohjelmasta. 
 *          Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan. 
 *          Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.
 *          
 *          Esimerkkitoiminta:
 *          
 *          Bike info 
 *          - Name:Jopo Model:Street ModelYear:2016 Color:Blue GearWheels:False Gear Name:
 *          
 *          Bike2 info 
 *          - Name:Tunturi Model:StreetPower ModelYear:2010 Color:Black GearWheels:True Gear Name:Shimano
 *          
 *          Boat info 
 *          - Name:Suvi Model:S900 ModelYear:1990 Color:White SeatCount:3 BoatType:Rowboat
 *          
 *          Boat2 info 
 *          - Name:Yamaha Model:Model 1000 ModelYear:2010 Color:Yellow SeatCount:5 BoatType:Motorboat */

using System;
using JAMK.IT;

namespace T04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bike Info");
            Bike bike1 = new JAMK.IT.Bike();
            bike1.Name = "Tunturi";
            bike1.Model = "Street Power";
            bike1.Year = 2010;
            bike1.Color = "Black";
            bike1.GearWheels = true;
            bike1.GearName = "Shimano";
            Console.WriteLine(bike1.ToString());

            Console.WriteLine("\nBoat Info");
            Boat boat1 = new JAMK.IT.Boat();
            boat1.Name = "Suvi";
            boat1.Model = "S900";
            boat1.Year = 1990;
            boat1.Color = "White";
            boat1.SeatCount = 3;
            boat1.BoatType = "Rowboat";
            Console.WriteLine(boat1.ToString());
        }
    }
}
