/* Kurssi: TTOS0200 Olio-ohjelmointi
 * Tehtävä: Labra 03 - Tehtävä 5
 * Tekijä: Niia Neuvonen K8863
 * Pvm: 17.1.2017
 * Kuvaus: 
 *          Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja. 
 *          Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, 
 *          joka luo muutamia opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa). 
 *          Tulosta taulukossa olevien opiskelijoiden tiedot käyttämällä toistorakennetta. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAMK.IT;

namespace T05
{
    class Program
    {
        static void Main(string[] args)
        {
            OpiskelijaHallinta();
        }

        static void OpiskelijaHallinta()
        {
            Opiskelija a = new JAMK.IT.Opiskelija("Matti", 25, "K8912");
            Opiskelija b = new JAMK.IT.Opiskelija("Mauno", 21, "K9771");
            Opiskelija c = new JAMK.IT.Opiskelija("Jaana", 23, "K9155");
        }
    }
}
