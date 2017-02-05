/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 08 - Tehtävä 2
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 1.2.2017
 * Kuvaus: 
 *          Toteuta sovellus, jolla voit hallita ostoskärryn sisältöä. Ostettavalta tuotteelta riittää käsitellä nimi ja hinta. 
 *          Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi List-tietorakenteeseen muutamia Product-luokan oliota. 
 *          Tulosta lopuksi kokoelman sisältö.
 *          
 *          Esimerkkitulostus:
 *          
 *              All products in collection:
 *              - product : Milk 1,4 e
 *              - product : Beer 2,2 e
 *              - product : Butter 3,2 e
 *              - product : Cheese 4,2 e
 *              
 *              Press enter key to continue... */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return Name + " " + Price + " e";
        }
        public Product(string name, double price) { Name = name; Price = price; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ShoppingCart();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ShoppingCart()
        {
            try
            {
                List<Product> products = new List<Product>();
                products.Add(new Product("Beer", 19.99));
                products.Add(new Product("Crisps", 2.79));
                products.Add(new Product("Chocolate", 1.99));

                Console.WriteLine("Items in shopping cart:\n");
                foreach (Product product in products)
                {
                    Console.WriteLine(product.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
