/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 04 - Tehtävä 6
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 21.1.2017
 * Kuvaus: 
 *          ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia tavaroita: 
 *          kirjoja, lehtiä, cd-levyjä, dvd-levyjä, bluray-levyjä, puhelimia, tabletteja, läppäreitä, ... jne. 
 *          Pohdi UML-kaaviota käyttäen millaisia luokkarakenteita (ainakin luokkien ja ominaisuuksien osalta) esiintyy ja käytä apua perintää, 
 *          jos tavaroille löytyy yhteisiä ominaisuuksia. Toteuta tämän jälkeen muutamia luokkia, joissa perintää esiintyy. 
 *          Tee myös pääohjelma, jossa käytät tekemiäsi luokkia ja luot olioita. */

using System;
using JAMK.IT;

namespace T06
{
    class Program
    {
        static void Main(string[] args)
        {
            // New movie objects
            Console.WriteLine("* DVDs *");
            
            Movie movie1 = new JAMK.IT.Movie();
            movie1.Title = "The Boondock Saints";
            movie1.Genre = "Crime";
            movie1.Year = 1999;
            movie1.Length = 108;
            movie1.Rating = "R";
            Console.WriteLine(movie1.ToString());

            Movie movie2 = new JAMK.IT.Movie();
            movie2.Title = "Reservoir Dogs";
            movie2.Genre = "Crime";
            movie2.Year = 1992;
            movie2.Length = 99;
            movie2.Rating = "R";
            Console.WriteLine(movie2.ToString());

            Movie movie3 = new JAMK.IT.Movie();
            movie3.Title = "Batman Begins";
            movie3.Genre = "Action";
            movie3.Year = 2005;
            movie3.Length = 140;
            movie3.Rating = "PG-13";
            Console.WriteLine(movie3.ToString());

            // New book objects
            Console.WriteLine("\n* Books *");
            
            Book book1 = new JAMK.IT.Book();
            book1.Title = "La Nausée";
            book1.Genre = "Philosophy";
            book1.Year = 1938;
            book1.Author = "Jean-Paul Sartre";
            Console.WriteLine(book1.ToString());

            Book book2 = new JAMK.IT.Book();
            book2.Title = "The Silmarillion";
            book2.Genre = "Fantasy";
            book2.Year = 1977;
            book2.Author = "J.R.R. Tolkien";
            Console.WriteLine(book2.ToString());
        }
    }
}
