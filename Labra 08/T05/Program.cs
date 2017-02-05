/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 08 - Tehtävä 5
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 1.2.2017
 * Kuvaus: 
 *          Toteuta ArrayCalcs-niminen luokka ja sen sisälle seuraavat staattiset-metodit: Sum, Average, Min ja Max. 
 *          Metodit ottavat parametriksi double[]-taulukon ja laskevat nimensä mukaisen laskutoimintuksen taulukon alkioille ja palauttavat tuloksen kutsuvalle ohjelmalle.
 *          
 *          Toteuta pääohjelma ja esimerkiksi seuraavaa dataa sisältävä taulukko: double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 }; 
 *          Kutsu pääohjelmasta ArrayCalcs-luokan staattisia laskutoimituksia tekeviä metodeja annetun taulukon arvoilla ja tulosta tulokset näyttölaitteelle.
 *          
 *          Esimerkkitulostus:
 *          
 *              Sum = 25,60
 *              Ave = 3,66
 *              Min = -4,50
 *              Max = 12,00
 *          
 *          ArrayCalcs-luokan metodien testaaminen
 *          Toteuta solutioniin uusi yksikkötestaukseen liittyvä projekti ja testaa ArrayCalcs-luokan kaikki metodit.
 *          Kuinka ArrayCalcs-luokan metodit toimivat, jos välität parametrina tyhjän double[]-taulukon: double[] array = { }; */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05
{
    public class ArrayCalcs
    {
        public static double Sum(double[] lista)
        {
            double sum = 0;
            foreach (double dubbel in lista)
            {
                sum += dubbel;
            }
            return sum;
        }
        public static double Average(double[] lista)
        {
            return Sum(lista) / lista.Length;
        }
        public static double Min(double[] lista)
        {
            return lista.Min();
        }
        public static double Max(double[] lista)
        {
            return lista.Max();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Calculator()
        {
            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                Console.WriteLine("Sum: " + ArrayCalcs.Sum(array));
                Console.WriteLine("Average: " + ArrayCalcs.Average(array));            
                Console.WriteLine("Min: " + ArrayCalcs.Min(array));
                Console.WriteLine("Max: " + ArrayCalcs.Max(array));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
