/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 07 - Tehtävä 4
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 30.1.2017
 * Kuvaus: 
 *          Tee ohjelma, jossa voidaan käsitellä TV-ohjelmia. TV-ohjelman tietoina tulee käsitellä: ohjelman nimi, 
 *          kanava (jolta ohjelma tulee), alku- ja loppuaika sekä pienimuotoinen infoteksti ohjelmasta. 
 *          Luo pääohjelmassa muutamia TV-ohjelmaolioita (tiedot voit alustaa suoraan koodista, ei tarvitse kysyä käyttäjältä) ja 
 *          tallenna ne levylle. Mieti käytätkö jotain tietorakennetta apunasi. 
 *          Toteuta ohjelmaan myös tiedostonlukeminen ja tulosta TV-oliot näkyville. */

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace T04
{
    [Serializable]
    class Programme
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Name + "\n" + Channel + " " + StartTime + " - " + EndTime + "\n" + Description + "\n";
        }
        public Programme(string name, string channel, string start, string end, string desc)
        { Name = name; Channel = channel; StartTime = start; EndTime = end; Description = desc; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TvGuide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void TvGuide()
        {
            List<Programme> programmes = new List<Programme>();

            programmes.Add(new Programme("Kodiak", "Discovery Channel", "4:00", "5:00", "The lodge opens for the fall season and Bob and Ernie luck upon a whale carcass on the beach that has attracted a swarm of bears."));
            programmes.Add(new Programme("Wild Scotland", "Nat Geo Wild", "22:15", "23:03", "Scotland's Hebrides are Europe's final frontier against the unpredictable Atlantic. Ewan McGregor narrates the story of animal life there."));
            programmes.Add(new Programme("Life", "BBC Knowledge", "19:50", "20:40", "Journeying into the uncharted corners of the ocean, discover why a Pacific giant octopus makes the ultimate sacrifice to protect her young."));

            try
            {
                // Write
                Stream writeStream = new FileStream("MyProgrammes.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writeStream, programmes);
                writeStream.Close();

                // Read
                Stream openStream = new FileStream("MyProgrammes.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                List<Programme> readProgrammes = (List<Programme>)formatter.Deserialize(openStream);
                openStream.Close();

                // Print
                Console.WriteLine("TV GUIDE\n");
                foreach (Programme p in readProgrammes)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }  
        }
    }
}
