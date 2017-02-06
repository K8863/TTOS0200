/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 08 - Tehtävä 6
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 1.2.2017
 * Kuvaus: 
 *          Toteuta ohjelma, jossa voidaan näyttää lasku ostetuista tavaroista.
 *          
 *          Jokaisesta ostetusta tavarasta tulee käsitellä seuraavat tiedot: nimi, hinta ja määrä. 
 *          Toteutetun luokan tulee osata palauttaa tieto siitä paljonko ko. ostetut tavarat kokonaisuudessaan maksavat (hinta*määrä). 
 *          Toteuta myös ToString()-metodi, joka palauttaa tuotteen nimen, hinnan ja määrät merkkijonona. 
 *          
 *              InvoiceItem
 *              - Name : String
 *              - Price : double
 *              - Quantity : int
 *              - Total == Price * Quantity : double
 *              - ToString() : string
 *              
 *          Toteuta luokka, joka pitää sisällään List-rakenteessa yllä määriteltyjä tuotteita. 
 *          Luokan tulee pystyä kertomaan myös asiakkaan nimi, paljonko "laskulla" on yhteensä tuotteita sekä niihin kuluva rahan määrä kokonaisuudessaan.
 *          
 *              Invoice
 *              - Customer : string (just a string, no Customer class..)
 *              - List<InvoiceItem>
 *              - Total ("sum of InvoiceItem Total's") : string
 *              - PrintInvoice() ("prints invoice to screen")
 *              
 *          Toteuta pääohjelma ja määrittele laskulle tavaroita ja ostajan nimi.
 *          
 *          Esimerkkitulostus:
 *          
 *              Customer Kirsi Kernel's invoice:
 *              =================================
 *              Milk   1,75e 1 pieces 1,75e total
 *              Beer   5,25e 1 pieces 5,25e total
 *              Butter 2,50e 2 pieces 5,00e total
 *              =================================
 *              Total : 12,00 euros
 *              
 *          Invoice-luokan kokonaissumman (total) testaaminen
 *          Testaa yksikkötestauksen avulla, että laskulle määritelty kokonaissumma varmasti lasketaan oikein. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06
{
    class InvoiceItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total() { return Price * Quantity; }
        public override string ToString() { return Name + " " + Price + "e " + Quantity + " pieces " + Total() + "e total\n"; }
        public InvoiceItem(string name, double price, int quantity) { Name = name; Price = price; Quantity = quantity; }
    }
    class Invoice
    {
        public string Customer { get; set; }
        public List<InvoiceItem> products = new List<InvoiceItem>();
        public void AddItem(InvoiceItem product) { products.Add(product); }
        public string TotalSum()
        {
            double totalsum = 0;
            totalsum += products.Sum(product => product.Total());
            return "Total: " + totalsum + " euros\n";
        }
        public string PrintInvoice()
        {
            string s = "Customer " + Customer + "'s invoice:\n=================================\n";
            foreach (InvoiceItem product in products) { s += product.ToString(); }
            s += "=================================";
            return s;
        }
        public Invoice(string customer) { Customer = customer; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try { Shopping(); }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        static void Shopping()
        {
            try
            {
                Invoice invoice = new Invoice("Chris Lovasz");
                invoice.AddItem(new InvoiceItem("Beer", 0.83, 24));
                invoice.AddItem(new InvoiceItem("Crisps", 2.79, 1));
                Console.WriteLine(invoice.PrintInvoice());
                Console.WriteLine(invoice.TotalSum());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
