using System;

/* Sormiharjoitus: Käyttäjien nimet aakkosjärjestykseen
 * Tee ohjelma joka kysyy käyttäjältä viisi (5) etunimeä. Tämän jälkeen ohjelma näyttää nimet annetussa järjestyksessä sekä aakkosjärjestyksessä. */

namespace Sormiharjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään nimet.
            string[] names = new string[5];
            Console.WriteLine("Anna käyttäjien etunimet: ");
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }
            // Näytetään nimet annetussa järjestyksessä.
            Console.WriteLine("\nAnnoit nimet: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            // Järjestetään ja näytetään nimet aakkosjärjestyksessä.
            Console.WriteLine("\nNimet aakkosjärjestyksessä: ");
            Array.Sort(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}