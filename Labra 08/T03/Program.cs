/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 08 - Tehtävä 3
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 1.2.2017
 * Kuvaus: 
 *          Toteuta sovellus, jossa voit hallita kalastukseen liittyviä tietoja. Ohjelman pitää pystyä käsittelemään: saadun kalan perustiedot 
 *          (laji, pituus ja paino), kalastajan perustiedot (nimi, puhelinnumero) sekä saadun kalapaikan perustiedot (nimi ja paikka). 
 *          Pohdi tarvittava luokkarakenne UML-kaaviona. Toteuta pääohjelmassa kalastaja ja muutamia kaloja. Tulosta lopuksi kalarekisterin sisältö.
 *          
 *          Esimerkkitulostus:
 *          
 *              A new fisherman added to register:
 *              - Fisherman: Kirsi Kernel Phone: 020-12345678
 *              
 *              Fisher : Kirsi Kernel got a new fish
 *              - specie : pike 120 cm 4,5 kg
 *              - place: The Lake of Jyväskylä
 *              - location: Jyväskylä
 *              
 *              Fisher : Kirsi Kernel got a new fish
 *              - specie: salmon 190 cm 13,2 kg
 *              - place: River Teno
 *              - location: The Northern edge of Finland
 *              
 *              All fishes in register:
 *              
 *              Fisherman Kirsi Kernel has got following fishes:
 *              
 *              - specie: pike 120 cm 4,5 kg
 *              - place: The Lake of Jyväskylä
 *              - location: Jyväskylä
 *              
 *              - specie: salmon 190 cm 13,2 kg
 *              - place: River Teno
 *              - location: The Northern edge of Finland */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03
{
    class Fish
    {
        public string Species { get; set; }
        public float Length { get; set; }
        public double Weight { get; set; }
        public string Place { get; set; }
        public string Location { get; set; }
        public string FishInfo() { return "\n- Fish: " + Species + ", " + Length + " cm, " + Weight + " kg\n- Place: " + Place + "\n- Location: " + Location + "\n"; }
        public Fish(string species, float length, double weight, string place, string location)
        { Species = species; Length = length; Weight = weight; Place = place; Location = location; }
    }
    class Fisherman
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string FishermanInfo()
        {
            return "A new fisherman added to the register:\n- Fisherman: " + Name + ", Phone: " + Phone + "\n";
        }
        public Fisherman(string name, string phone) { Name = name; Phone = phone; }

        public List<Fish> fishies = new List<Fish>();
        public string AllFishies()
        {
            string s = "Fisherman " + Name + " has caught the following fishes:\n";
            foreach (Fish fish in fishies)
            {
                s += fish.FishInfo();
            }
            return s;
        }
        public void AddFish(Fish fish)
        {
            fishies.Add(fish);
        }
    }
    class FishingSpot
    {
        public string Place { get; set; }
        public string Location { get; set; }
        public string SpotInfo() { return "- Place: " + Place + "\n- Location: " + Location; }
        public FishingSpot(string place, string location) { Place = place; Location = location; }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FishData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void FishData()
        {
            try
            {
                Fisherman fisher1 = new Fisherman("Chris Lovasz", "015345 859000");
                Console.WriteLine(fisher1.FishermanInfo());
                fisher1.AddFish(new Fish("pike", 120, 4.5, "Jyväsjärvi", "Jyväskylä"));
                fisher1.AddFish(new Fish("salmon", 190, 13.2, "Teno river", "Utsjoki"));
                Console.WriteLine(fisher1.AllFishies());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
