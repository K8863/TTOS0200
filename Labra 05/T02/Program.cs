/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 05 - Tehtävä 2
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 23.1.2017
 * Kuvaus: 
 *          Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy. 
 *          Tee pienimuotoinen toteutus, joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista. */

using System;
using System.Collections.Generic;

namespace T02
{
    public class Item
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Item(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Name + " " + Quantity + " kpl\n";
        }
    }
 
    public class Fridge
    {
        public List<Item> Items = new List<Item>();

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            string s = "Jääkaapin sisältö:\n";
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
            FridgeContent();
        }

        static void FridgeContent()
        {
            Fridge fridge = new Fridge();
            fridge.AddItem(new Item("Olut", 24));
            fridge.AddItem(new Item("Porkkana", 7));
            fridge.AddItem(new Item("Luumuhillo", 1));
            fridge.AddItem(new Item("Roiskeläppä", 3));
            Console.WriteLine(fridge.ToString());
        }
    }
}
