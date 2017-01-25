/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 06 - Tehtävä 2
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 25.1.2017
 * Kuvaus: 
 *          Aikaisemmissa demoissa tehtiin CD-luokka, joka sisälsi CD:lle yleisesti kuuluvia ominaisuuksia. 
 *          Muuta/tee toteutus, jossa CD:n sisällä olevien biisien määrää ei ole rajattu. 
 *          Käsittele CD:n osalta ainakin seuraavat tiedot: nimi, artisti ja biisit.
 *          
 *          Ohjelmoi suunnittelemasi CD-luokka. Toteuta pääohjelmassa CD-olio. 
 *          Tiedot voit keksiä itse, niitä ei tarvitse kysyä käyttäjältä. Tulosta ruudulle CD:n tietoja.
 *          
 *          Esimerkkitoiminta:
 *          
 *           CD data:
 *           - name:Endless Forms Most Beautiful
 *           - artist: Nightwish
 *           - songs:
 *             - Shudder Before the Beautiful, 6:29
 *             - Weak Fantasy, 5:23
 *             - Elan, 4:45
 *             - Yours Is an Empty Hope, 5:34
 *             - Our Decades in the Sun, 6:37
 *             - My Walden, 4:38
 *             - Endless Forms Most Beautiful, 5:07
 *             - Edema Ruh, 5:15
 *             - Alpenglow, 4:45
 *             - The Eyes of Sharbat Gula, 6:03
 *             - The Greatest Show on Earth, 24:00 */

using System;
using System.Collections.Generic;

namespace T02
{
    class Song
    {
        public string Name { get; set; }
        public string Duration { get; set; }

        public Song(string name, string duration)
        { Name = name; Duration = duration; }

        public override string ToString()
        {
            return Name + " " + Duration + "\n";
        }
    }

    class Cd
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<Song> Songs = new List<Song>();

        public Cd(string artist, string title, int year)
        { Artist = artist; Title = title; Year = year; }

        public void AddSong(Song song)
        {
            Songs.Add(song);
        }

        public override string ToString()
        {
            string s = Artist + " - " + Title + " (" + Year + ")\n\n";
            foreach (Song song in Songs)
            {
                s += song.ToString();
            }
            return s;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            CdData();
        }

        static void CdData()
        {
            Cd cd = new Cd("Moonsorrow", "Voimasta ja kunniasta", 2001);
            cd.AddSong(new Song("Tyven", "1:52"));
            cd.AddSong(new Song("Sankarihauta", "7:41"));
            cd.AddSong(new Song("Kylän päässä", "7:38"));
            cd.AddSong(new Song("Hiidenpelto", "9:20"));
            cd.AddSong(new Song("Aurinko ja kuu", "8:14"));
            cd.AddSong(new Song("Sankaritarina", "13:50"));
            Console.WriteLine(cd.ToString());
        }
    }
}
