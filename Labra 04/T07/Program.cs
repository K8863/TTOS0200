/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 04 - Tehtävä 7
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 21.1.2017
 * Kuvaus: 
 *          Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää perintää. */

using System;
using JAMK.IT;

namespace T07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Skyrim NPCs ***\n");

            Npc npc1 = new JAMK.IT.Npc();
            npc1.Name = "Ondolemar";
            npc1.Race = "Altmer";
            npc1.Gender = "Male";
            Console.WriteLine(npc1.ToString());

            Npc npc2 = new JAMK.IT.Npc();
            npc2.Name = "Nazir";
            npc2.Race = "Redguard";
            npc2.Gender = "Male";
            Console.WriteLine(npc2.ToString());

            Follower follower1 = new JAMK.IT.Follower();
            follower1.Name = "Teldryn Sero";
            follower1.Race = "Dunmer";
            follower1.Gender = "Male";
            follower1.Marry = false;
            follower1.Steward = false;
            Console.WriteLine(follower1.ToString());

            Follower follower2 = new JAMK.IT.Follower();
            follower2.Name = "J'zargo";
            follower2.Race = "Khajiit";
            follower2.Gender = "Male";
            follower2.Marry = false;
            follower2.Steward = false;
            Console.WriteLine(follower2.ToString());

            Follower follower3 = new JAMK.IT.Follower();
            follower3.Name = "Brelyna Maryon";
            follower3.Race = "Dunmer";
            follower3.Gender = "Female";
            follower3.Marry = true;
            follower3.Steward = true;
            Console.WriteLine(follower3.ToString());
        }
    }
}
