/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 03 - Tehtävä 6
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 17.1.2017
 * Kuvaus: 
 *          Valitse jokin reaalimaailman asia ja suunnittele siitä luokkarakenne UML-editorilla. 
 *          Tee uusi projekti. Ohjelmoi suunnittelema luokkasi sekä käytä tekemääsi luokkaa edellisten tehtävien mukaisesti. */

using System;
using JAMK.IT;

namespace T06
{
    class Program
    {
        static void Main(string[] args)
        {
            GameInfo();
        }

        static void GameInfo()
        {
            // Luodaan game-olio
            Game game = new JAMK.IT.Game();
            // Annetaan oliolle arvot
            game.Name = "The Elder Scrolls V: Skyrim";
            game.Year = "2011";
            game.Developer = "Bethesda";
            game.Genre = "RPG";
            game.Achievement = true;
            game.Leaderboard = false;
            game.Dlc = true;
            // Tulostetaan tiedot
            Console.WriteLine("GAME INFORMATION\n");
            Console.WriteLine("Game: {0}", game.Name);
            Console.WriteLine("Released: {0}", game.Year);
            Console.WriteLine("Developer: {0}", game.Developer);
            Console.WriteLine("Genre: {0}", game.Genre);
            Console.WriteLine("Achievements: {0}", game.Achievement);
            Console.WriteLine("Leaderboards: {0}", game.Leaderboard);
            Console.WriteLine("DLC: {0}", game.Dlc);
        }
    }
}