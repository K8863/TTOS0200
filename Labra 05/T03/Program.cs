/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 05 - Tehtävä 3
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 23.1.2017
 * Kuvaus: 
 *          Tehtävässä tulee toteuttaa muutamia luokkia, joiden avulla testataan abstraktien metodien toimivuutta.
 *          
 *          Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta (abstrakti metodi).
 *          
 *          Peri Nisakas-luokasta Ihminen-luokka, jolla on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi). 
 *          Lisää Ihminen-luokkaan metodit: Liiku ja Kasva, joista ensimmäinen tulostaa ruutuun "liikun" ja jälkimmäinen lisää ihmisen ikää yhdellä vuodella. 
 *          Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa
 *          
 *          Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa". 
 *          Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto (String). 
 *          Lisää vauvalle ominaisuus vaippa (String).
 *          
 *          Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille. */

using System;
using System.Collections.Generic;

namespace T03
{
    abstract class Nisakas
    {
        public int Ika { get; set; }
        
        public Nisakas(int ika) { Ika = ika; }

        public abstract void Liiku();
    }

    class Ihminen : Nisakas
    {
        public string Nimi { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }

        public Ihminen(string nimi, int paino, int pituus, int ika)
            : base(ika) { Paino = paino; Pituus = pituus; Nimi = nimi; }

        public override string ToString()
        { return Nimi + " " + Ika + " v. " + Paino + " kg, " + Pituus + " cm, "; }

        public override void Liiku() { Console.WriteLine("liikkuu"); }

        public void Kasva() { Ika++; }
    }

    class Vauva : Ihminen
    {
        public string Vaippa { get; set; }

        public Vauva(string nimi, int paino, int pituus, int ika, string vaippa)
            : base(nimi, paino, pituus, ika) { Vaippa = vaippa; }

        public override string ToString()
        { return base.ToString() + "vaippa " + Vaippa + ", "; }

        public override void Liiku() { Console.WriteLine("konttaa"); }
    }

    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }

        public Aikuinen(string nimi, int paino, int pituus, int ika, string auto)
            : base(nimi, paino, pituus, ika) { Auto = auto; }

        public override string ToString()
        { return base.ToString() + "autona " + Auto + ", "; }

        public override void Liiku() { Console.WriteLine("kävelee"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Nisakas> Nisakkaat = new List<Nisakas>();

            Nisakkaat.Add(new Vauva("Paavo", 4, 50, 1, "täynnä"));
            Nisakkaat.Add(new Aikuinen("Marja", 58, 155, 43, "Nissan Note"));
            Nisakkaat.Add(new Ihminen("Topi", 61, 174, 17));
            Nisakkaat.Add(new Vauva("Gilderoy", 6, 54, 2, "tyhjä"));

            foreach (Nisakas nisakas in Nisakkaat)
            {
                Console.Write(nisakas.ToString());
                nisakas.Liiku();
            }
        }
    }
}
