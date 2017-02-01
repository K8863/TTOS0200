/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 08 - Tehtävä 1
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 1.2.2017
 * Kuvaus: 
 *          Toteuta Noppa-luokka siten, että noppaa voidaan heittää. Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla. 
 *          Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran ja tulosta nopan luku. 
 *          Toteuta tämän jälkeen ohjelma siten, että kysyt käyttäjältä heittojen määrän. 
 *          Heitä noppaa ja tulosta heittojen lukujen keskiarvo.
 *          
 *          Esimerkkitulostus:
 *          
 *              Dice, one test throw value is 4
 *              
 *              How many times you want to throw a dice :  10000
 *               Dice is now thrown 10000 times, average is 3,4853
 *               
 *          +tehtävä. Tulosta lopuksi kaikkien heitettyjen lukujen esiintymismäärät.
 *          
 *              How many times you want to throw a dice :  10000
 *              
 *              Dice is now thrown 10000 times
 *              - average is 3,4853
 *              - 1 count is 1726
 *              - 2 count is 1610
 *              - 3 count is 1705
 *              - 4 count is 1691
 *              - 5 count is 1580
 *              - 6 count is 1688
 *              
 *              Press enter key to continue... */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01
{
    class Noppa
    {
        public Random rnd = new Random();
        public int DiceRoll()
        {
            int result = rnd.Next(1, 7);
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RollDice();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void RollDice()
        {
            try
            {
                Noppa noppa = new Noppa();

                Console.WriteLine("Dice, one test throw value is " + noppa.DiceRoll());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
