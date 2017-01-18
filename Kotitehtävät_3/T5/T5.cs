using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Tehtävä 5
///Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle tyypillisiä tietoja ja 
///toimintoja. Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, joka luo muutamia 
///opiskelijoita ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa). Tulosta taulukossa olevien 
///opiskelijoiden tiedot käyttämällä toistorakennetta.
/// </summary>
using JAMK.IT;

namespace T5
{
    class T5
    {
        static void Main(string[] args)
        {
            var Opiskelijat = new List<Opiskelija>
            {
                new Opiskelija() { enimi="Pekka", snimi="Nisanen", keskiarvo=4.3},
                new Opiskelija() { enimi="Jukka", snimi="Halonen", keskiarvo=4.7},
                new Opiskelija() { enimi="Jakko", snimi="Turunen", keskiarvo=3.2},
                new Opiskelija() { enimi="Jarmo", snimi="Loikkanen", keskiarvo=3.8},
                new Opiskelija() { enimi="Emma", snimi="Rantalainen", keskiarvo=5.0},
            };

            foreach (Opiskelija theOpiskelija in Opiskelijat)
            {
                Console.WriteLine(theOpiskelija.enimi + " " + theOpiskelija.snimi + " " + theOpiskelija.keskiarvo);
            }
            
        }
    }
}
