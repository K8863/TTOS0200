/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 06 - Tehtävä 4
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 29.1.2017
 * Kuvaus: 
 *          Toteuta ohjelma, jolla voidaan lisätä, poistaa ja listata SM-Liiga-joukkueen JYP pelaajia. 
 *          
 *          Luo Pelaaja-luokka jolla on ominaisuudet Etunimi, Sukunimi, Ikä ja Numero. 
 *          Luo myös Joukkue-luokka jolla on ominnaisuudet Nimi, Kotikaupunki ja Pelaajat. 
 *          Ominaisuus Pelaajat on siis lista Pelaaja-olioita. 
 *          Tee Joukkue-luokalle sisäinen metodi HaePelaajat(string joukkue), jota konstruktori kutsuu. 
 *          HaePelaajat metodi luo Pelaajat-listaan oikeat pelaajat. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ikä { get; set; }
        public int Numero { get; set; }
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + ", " + Ikä + ", #" + Numero + "\n";
        }
        public Pelaaja(string etunimi, string sukunimi, int ikä, int numero)
        { Etunimi = etunimi; Sukunimi = sukunimi; Ikä = ikä; Numero = numero; }
    }
    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public override string ToString()
        {
            string s = Nimi + " - " + Kotikaupunki + "\n\n";
            foreach (Pelaaja pelaaja in Pelaajat)
            {
                s += pelaaja.ToString();
            }
            return s;
        }
        public Joukkue(string nimi, string kotikaupunki)
        { Nimi = nimi;  Kotikaupunki = kotikaupunki; }
        public List<Pelaaja> Pelaajat = new List<Pelaaja>();

        public void LisääPelaaja(Pelaaja pelaaja)
        {
            Pelaajat.Add(pelaaja);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            JoukkueInfo();
        }
        static void JoukkueInfo()
        {
            Joukkue jyp = new Joukkue("JYP", "Jyväskylä");
            jyp.LisääPelaaja(new Pelaaja("Juho", "Olkinuora", 26, 45));
            jyp.LisääPelaaja(new Pelaaja("Markus", "Ruusu", 19, 97));
            jyp.LisääPelaaja(new Pelaaja("Pekka", "Tuokkola", 33, 83));
            jyp.LisääPelaaja(new Pelaaja("Olli", "Aitola", 24, 60));
            jyp.LisääPelaaja(new Pelaaja("Joona", "Erving", 22, 53));
            jyp.LisääPelaaja(new Pelaaja("Niklas", "Friman", 23, 20));
            jyp.LisääPelaaja(new Pelaaja("Jaakko", "Jokinen", 23, 16));
            jyp.LisääPelaaja(new Pelaaja("Mikko", "Kalteva", 32, 7));
            jyp.LisääPelaaja(new Pelaaja("Mikko", "Kuukka", 31, 91));
            jyp.LisääPelaaja(new Pelaaja("Kai", "Lehtinen", 26, 59));
            Console.WriteLine(jyp.ToString());
        }
    }
}
