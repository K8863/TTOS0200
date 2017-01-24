/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 05 - Tehtävä 4
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 23.1.2017
 * Kuvaus: 
 *          Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää koostamista. 
 *          
 *          1. Suunnittele luokkarakenne UML-kaaviona.
 *          2. Laadi tarvittavat luokat ja testipääohjelma. */

using System;
using System.Collections.Generic;

namespace T04
{
    public class Item
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Value { get; set; }

        public Item(string name, double weight, int value)
        {
            Name = name;
            Weight = weight;
            Value = value;
        }

        public override string ToString()
        {
            return Name + ", weight " + Weight + ", value " + Value + "\n";
        }
    }

    public class Chest
    {
        public List<Item> Items = new List<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            string s = "LOOT CHEST CONTENTS\n\n";
            foreach (Item item in Items)
            {
                if (item != null) s += item.ToString();
            }
            return s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChestContent();
        }

        static void ChestContent()
        {
            Chest chest = new Chest();
            chest.AddItem(new Item("Cabbage", 0.25, 2));
            chest.AddItem(new Item("Daedric Shield", 15, 1600));
            chest.AddItem(new Item("Iron Mace", 13, 35));
            chest.AddItem(new Item("Mammoth Snout", 3, 6));
            Console.WriteLine(chest.ToString());
        }
    }
}
